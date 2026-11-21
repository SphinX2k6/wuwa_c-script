using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045E6 RID: 17894
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueGrid : UiPanelBase
	{
		// Token: 0x0602D008 RID: 184328 RVA: 0x00C94ECC File Offset: 0x00C930CC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUISprite)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
		}

		// Token: 0x0602D009 RID: 184329 RVA: 0x00C94F80 File Offset: 0x00C93180
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			extendToggle.OnPointDownCallBack.Unbind();
			extendToggle.OnPointDownCallBack.Bind(new Action<EToggleState>(this.OnPointerDown));
			extendToggle.OnPointUpCallBack.Unbind();
			extendToggle.OnPointUpCallBack.Bind(new Action<EToggleState>(this.OnPointerUp));
			extendToggle.OnStateChange.Clear();
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.ExtendToggleStateChanged));
			extendToggle.CanExecuteChange.Unbind();
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CanExecuteChange));
			extendToggle.OnHover.Clear();
			extendToggle.OnHover.Add(new Action(this.OnHover));
			extendToggle.OnUnHover.Clear();
			extendToggle.OnUnHover.Add(new Action(this.OnUnHover));
		}

		// Token: 0x0602D00A RID: 184330 RVA: 0x00C9505F File Offset: 0x00C9325F
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0602D00B RID: 184331 RVA: 0x00C95064 File Offset: 0x00C93264
		private void OnPointerDown(EToggleState state)
		{
			foreach (ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase> valueTuple in this.SelectPanel)
			{
				valueTuple.Item1.PlaySequence("Pre", false);
				valueTuple.Item2.PlaySequence("Pre", false);
			}
			Action<EToggleState, MapGridData> onExtendTogglePointerDown = this.OnExtendTogglePointerDown;
			if (onExtendTogglePointerDown == null)
			{
				return;
			}
			onExtendTogglePointerDown(state, this.Data);
		}

		// Token: 0x0602D00C RID: 184332 RVA: 0x00C950E8 File Offset: 0x00C932E8
		private void OnPointerUp(EToggleState state)
		{
			foreach (ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase> valueTuple in this.SelectPanel)
			{
				valueTuple.Item1.PlaySequence("PreUp", false);
				valueTuple.Item2.PlaySequence("PreUp", false);
			}
		}

		// Token: 0x0602D00D RID: 184333 RVA: 0x00C95154 File Offset: 0x00C93354
		private void ExtendToggleStateChanged(EToggleState state)
		{
			string seqDefine = (state == EToggleState.ETT_Checked) ? "Sle" : "UnSle";
			foreach (ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase> valueTuple in this.SelectPanel)
			{
				valueTuple.Item1.PlaySequence(seqDefine, true);
				valueTuple.Item2.PlaySequence(seqDefine, true);
			}
			Action<EToggleState, MapGridData> onExtendToggleStateChanged = this.OnExtendToggleStateChanged;
			if (onExtendToggleStateChanged == null)
			{
				return;
			}
			onExtendToggleStateChanged(state, this.Data);
		}

		// Token: 0x0602D00E RID: 184334 RVA: 0x00C951E4 File Offset: 0x00C933E4
		private bool CanExecuteChange()
		{
			return this.OnCanExecuteChangeFunc == null || this.OnCanExecuteChangeFunc(base.GetExtendToggle(0).GetToggleState(), this.Data);
		}

		// Token: 0x0602D00F RID: 184335 RVA: 0x00C95210 File Offset: 0x00C93410
		private void OnHover()
		{
			Action<MapGridData> onHoverFunc = this.OnHoverFunc;
			if (onHoverFunc != null)
			{
				onHoverFunc(this.Data);
			}
			if (Info.Instance.IsInTouch())
			{
				return;
			}
			foreach (ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase> valueTuple in this.SelectPanel)
			{
				valueTuple.Item1.PlaySequence("Float", false);
				valueTuple.Item2.PlaySequence("Float", false);
			}
		}

		// Token: 0x0602D010 RID: 184336 RVA: 0x00C952A0 File Offset: 0x00C934A0
		private void OnUnHover()
		{
			foreach (ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase> valueTuple in this.SelectPanel)
			{
				valueTuple.Item1.PlaySequence("Move", false);
				valueTuple.Item2.PlaySequence("Move", false);
			}
			Action<MapGridData> onUnHoverFunc = this.OnUnHoverFunc;
			if (onUnHoverFunc == null)
			{
				return;
			}
			onUnHoverFunc(this.Data);
		}

		// Token: 0x0602D011 RID: 184337 RVA: 0x00C95324 File Offset: 0x00C93524
		public void SetGridToggleState(bool bSelectOn, bool bFireEvent = false)
		{
			if (!this.Data.Walkable)
			{
				return;
			}
			bool flag = base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_Checked;
			EToggleState state = bSelectOn ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleStateForce(state, bFireEvent, false, false);
			if (flag == bSelectOn)
			{
				return;
			}
			string seqDefine = bSelectOn ? "Sle" : "UnSle";
			foreach (ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase> valueTuple in this.SelectPanel)
			{
				valueTuple.Item1.PlaySequence(seqDefine, true);
				valueTuple.Item2.PlaySequence(seqDefine, true);
			}
		}

		// Token: 0x0602D012 RID: 184338 RVA: 0x00C953D4 File Offset: 0x00C935D4
		public void SetToggleMoveEnable(bool bEnable)
		{
			if (!this.Data.Walkable)
			{
				return;
			}
			this.WalkEnable = bEnable;
			foreach (ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase> valueTuple in this.SelectPanel)
			{
				valueTuple.Item1.SetState(bEnable);
				valueTuple.Item2.SetState(bEnable);
			}
		}

		// Token: 0x0602D013 RID: 184339 RVA: 0x00C9544C File Offset: 0x00C9364C
		public void SetSelectPanel(MapRogueGridSelectBase back, MapRogueGridSelectBase front)
		{
			back.GetRootItem().SetUIParent(this.GetPanelSelectBack(), false);
			front.GetRootItem().SetUIParent(this.GetPanelSelectFront(), false);
			back.ResetAllSequence();
			front.ResetAllSequence();
			this.SelectPanel.Add(new ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase>(back, front));
			bool selected = base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_Checked;
			foreach (ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase> valueTuple in this.SelectPanel)
			{
				valueTuple.Item1.SetSelected(selected);
				valueTuple.Item2.SetSelected(selected);
				valueTuple.Item1.SetState(this.WalkEnable);
				valueTuple.Item2.SetState(this.WalkEnable);
			}
			back.SetUiActive(true);
			front.SetUiActive(true);
		}

		// Token: 0x0602D014 RID: 184340 RVA: 0x00C95530 File Offset: 0x00C93730
		public void ClearSelectPanel()
		{
			this.SelectPanel.Clear();
		}

		// Token: 0x0602D015 RID: 184341 RVA: 0x00C9553D File Offset: 0x00C9373D
		public UUIItem GetPanelEvent()
		{
			return base.GetItem(3);
		}

		// Token: 0x0602D016 RID: 184342 RVA: 0x00C95546 File Offset: 0x00C93746
		public UUIItem GetPanelSelectFront()
		{
			return base.GetItem(5);
		}

		// Token: 0x0602D017 RID: 184343 RVA: 0x00C9554F File Offset: 0x00C9374F
		public UUIItem GetPanelSelectBack()
		{
			return base.GetItem(4);
		}

		// Token: 0x0602D018 RID: 184344 RVA: 0x00C95558 File Offset: 0x00C93758
		public void Refresh(MapGridData data)
		{
			this.Data = data;
			RogueResGridMapType? gridMapTypeConfigById = MapRogueConfig.Instance.GetGridMapTypeConfigById(this.Data.GridTypeId);
			if (gridMapTypeConfigById == null)
			{
				return;
			}
			List<string> list = new List<string>(gridMapTypeConfigById.Value.GroundPath().Keys);
			UUISprite sprite = base.GetSprite(1);
			sprite.SetUIActive(false);
			this.SetSpriteByPath(list[data.GroundPathIndex], sprite, true, null, delegate(bool _)
			{
				sprite.SetUIActive(true);
			});
			bool flag = gridMapTypeConfigById.Value.ExtraPathListLength > 0;
			bool flag2 = this.Data.ExtraPathIndex >= 0;
			this.HasDecoration = (flag || flag2);
			UUIItem item = base.GetItem(6);
			UUISprite spriteExtra = base.GetSprite(2);
			item.SetAlpha(1f);
			item.SetUIActive(this.HasDecoration && this.Data.HasVision);
			float anchorOffsetY = spriteExtra.GetAnchorOffsetY();
			spriteExtra.SetUIActive(false);
			if (flag2)
			{
				List<string> list2 = new List<string>(gridMapTypeConfigById.Value.DecorationPath().Keys);
				this.SetSpriteByPath(list2[data.ExtraPathIndex], spriteExtra, true, null, delegate(bool _)
				{
					spriteExtra.SetUIActive(true);
				});
			}
			TArray<UUIItem> attachUIChildren = item.GetAttachUIChildren();
			attachUIChildren.RemoveAt(0);
			int num = attachUIChildren.Num();
			int num2 = Math.Max(num, gridMapTypeConfigById.Value.ExtraPathListLength);
			for (int i = 0; i < num2; i++)
			{
				if (i >= gridMapTypeConfigById.Value.ExtraPathListLength)
				{
					attachUIChildren.Get(i).SetUIActive(false);
				}
				else
				{
					UUISprite uuisprite;
					if (i < num)
					{
						uuisprite = (attachUIChildren.Get(i) as UUISprite);
					}
					else
					{
						uuisprite = (LguiUtil.Instance.CopyItem(spriteExtra, item) as UUISprite);
					}
					int num3 = (i < gridMapTypeConfigById.Value.ExtraOffsetListLength) ? gridMapTypeConfigById.Value.ExtraOffsetList(i) : 0;
					uuisprite.SetAnchorOffsetY(anchorOffsetY + (float)num3);
					uuisprite.SetUIActive(false);
					UUISprite capturedCopyDecoration = uuisprite;
					this.SetSpriteByPath(gridMapTypeConfigById.Value.ExtraPathList(i), capturedCopyDecoration, true, null, delegate(bool _)
					{
						capturedCopyDecoration.SetUIActive(true);
					});
				}
			}
			this.WalkEnable = this.Data.Walkable;
			bool selected = base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_Checked;
			foreach (ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase> valueTuple in this.SelectPanel)
			{
				valueTuple.Item1.SetSelected(selected);
				valueTuple.Item2.SetSelected(selected);
				valueTuple.Item1.SetState(this.WalkEnable);
				valueTuple.Item2.SetState(this.WalkEnable);
			}
			this.SetActive(true);
		}

		// Token: 0x0602D019 RID: 184345 RVA: 0x00C958A0 File Offset: 0x00C93AA0
		public void SetVision(bool bHasVision)
		{
			if (this.HasDecoration)
			{
				base.GetItem(6).SetUIActive(bHasVision);
			}
		}

		// Token: 0x0602D01A RID: 184346 RVA: 0x00C958B8 File Offset: 0x00C93AB8
		public void SetPerspectiveMode(bool bOn)
		{
			if (!this.HasDecoration)
			{
				return;
			}
			this.PerspectiveModeCount = Math.Max(0, this.PerspectiveModeCount + (bOn ? 1 : -1));
			bool flag = this.PerspectiveModeCount > 0;
			if (this.IsInPerspectiveMode == flag)
			{
				return;
			}
			this.IsInPerspectiveMode = bOn;
			int num = (!bOn) ? 1 : 0;
			TArray<UActorComponent> tarray = base.GetItem(6).GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			int num2 = tarray.Num();
			for (int i = 0; i < num2; i++)
			{
				ULGUIPlayTweenComponent ulguiplayTweenComponent = tarray.Get(i) as ULGUIPlayTweenComponent;
				ulguiplayTweenComponent.Stop();
				if (i == num)
				{
					ulguiplayTweenComponent.Play();
				}
			}
		}

		// Token: 0x0401821D RID: 98845
		private MapGridData Data;

		// Token: 0x0401821E RID: 98846
		private int PerspectiveModeCount;

		// Token: 0x0401821F RID: 98847
		private bool IsInPerspectiveMode;

		// Token: 0x04018220 RID: 98848
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<EToggleState, MapGridData> OnExtendTogglePointerDown;

		// Token: 0x04018221 RID: 98849
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<EToggleState, MapGridData> OnExtendToggleStateChanged;

		// Token: 0x04018222 RID: 98850
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<EToggleState, MapGridData, bool> OnCanExecuteChangeFunc;

		// Token: 0x04018223 RID: 98851
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MapGridData> OnHoverFunc;

		// Token: 0x04018224 RID: 98852
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MapGridData> OnUnHoverFunc;

		// Token: 0x04018225 RID: 98853
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public List<ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase>> SelectPanel = new List<ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase>>();

		// Token: 0x04018226 RID: 98854
		private bool WalkEnable = true;

		// Token: 0x04018227 RID: 98855
		private bool HasDecoration;
	}
}
