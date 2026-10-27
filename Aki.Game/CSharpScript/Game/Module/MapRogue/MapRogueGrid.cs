using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005610 RID: 22032
	[NullableContext(1)]
	[Nullable(0)]
	public class MapRogueGrid : UiPanelBase
	{
		// Token: 0x0603810A RID: 229642 RVA: 0x00D47184 File Offset: 0x00D45384
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

		// Token: 0x0603810B RID: 229643 RVA: 0x00D47238 File Offset: 0x00D45438
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

		// Token: 0x0603810C RID: 229644 RVA: 0x00D47317 File Offset: 0x00D45517
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x0603810D RID: 229645 RVA: 0x00D4731C File Offset: 0x00D4551C
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

		// Token: 0x0603810E RID: 229646 RVA: 0x00D473A0 File Offset: 0x00D455A0
		private void OnPointerUp(EToggleState state)
		{
			foreach (ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase> valueTuple in this.SelectPanel)
			{
				valueTuple.Item1.PlaySequence("PreUp", false);
				valueTuple.Item2.PlaySequence("PreUp", false);
			}
		}

		// Token: 0x0603810F RID: 229647 RVA: 0x00D4740C File Offset: 0x00D4560C
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

		// Token: 0x06038110 RID: 229648 RVA: 0x00D4749C File Offset: 0x00D4569C
		private bool CanExecuteChange()
		{
			return this.OnCanExecuteChangeFunc == null || this.OnCanExecuteChangeFunc(base.GetExtendToggle(0).GetToggleState(), this.Data);
		}

		// Token: 0x06038111 RID: 229649 RVA: 0x00D474C8 File Offset: 0x00D456C8
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

		// Token: 0x06038112 RID: 229650 RVA: 0x00D47558 File Offset: 0x00D45758
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

		// Token: 0x06038113 RID: 229651 RVA: 0x00D475DC File Offset: 0x00D457DC
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

		// Token: 0x06038114 RID: 229652 RVA: 0x00D4768C File Offset: 0x00D4588C
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

		// Token: 0x06038115 RID: 229653 RVA: 0x00D47704 File Offset: 0x00D45904
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

		// Token: 0x06038116 RID: 229654 RVA: 0x00D477E8 File Offset: 0x00D459E8
		public void ClearSelectPanel()
		{
			this.SelectPanel.Clear();
		}

		// Token: 0x06038117 RID: 229655 RVA: 0x00D477F5 File Offset: 0x00D459F5
		public UUIItem GetPanelEvent()
		{
			return base.GetItem(3);
		}

		// Token: 0x06038118 RID: 229656 RVA: 0x00D477FE File Offset: 0x00D459FE
		public UUIItem GetPanelSelectFront()
		{
			return base.GetItem(5);
		}

		// Token: 0x06038119 RID: 229657 RVA: 0x00D47807 File Offset: 0x00D45A07
		public UUIItem GetPanelSelectBack()
		{
			return base.GetItem(4);
		}

		// Token: 0x0603811A RID: 229658 RVA: 0x00D47810 File Offset: 0x00D45A10
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

		// Token: 0x0603811B RID: 229659 RVA: 0x00D47B58 File Offset: 0x00D45D58
		public void SetVision(bool bHasVision)
		{
			if (this.HasDecoration)
			{
				base.GetItem(6).SetUIActive(bHasVision);
			}
		}

		// Token: 0x0603811C RID: 229660 RVA: 0x00D47B70 File Offset: 0x00D45D70
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

		// Token: 0x0401D792 RID: 120722
		private MapGridData Data;

		// Token: 0x0401D793 RID: 120723
		private int PerspectiveModeCount;

		// Token: 0x0401D794 RID: 120724
		private bool IsInPerspectiveMode;

		// Token: 0x0401D795 RID: 120725
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<EToggleState, MapGridData> OnExtendTogglePointerDown;

		// Token: 0x0401D796 RID: 120726
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<EToggleState, MapGridData> OnExtendToggleStateChanged;

		// Token: 0x0401D797 RID: 120727
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<EToggleState, MapGridData, bool> OnCanExecuteChangeFunc;

		// Token: 0x0401D798 RID: 120728
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MapGridData> OnHoverFunc;

		// Token: 0x0401D799 RID: 120729
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<MapGridData> OnUnHoverFunc;

		// Token: 0x0401D79A RID: 120730
		[Nullable(new byte[]
		{
			1,
			0,
			1,
			1
		})]
		public List<ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase>> SelectPanel = new List<ValueTuple<MapRogueGridSelectBase, MapRogueGridSelectBase>>();

		// Token: 0x0401D79B RID: 120731
		private bool WalkEnable = true;

		// Token: 0x0401D79C RID: 120732
		private bool HasDecoration;
	}
}
