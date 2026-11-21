using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x020042D6 RID: 17110
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueDungeonDataItem : AutoAttachItem<int>
	{
		// Token: 0x0602B502 RID: 177410 RVA: 0x00C2AF00 File Offset: 0x00C29100
		public RogueDungeonDataItem(AActor uiItem = null) : base(null)
		{
			this.Canvas = (uiItem.GetComponentByClass(ULGUICanvas.StaticClass()) as ULGUICanvas);
		}

		// Token: 0x0602B503 RID: 177411 RVA: 0x00C2AF24 File Offset: 0x00C29124
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.SelectedItem))
			};
		}

		// Token: 0x0602B504 RID: 177412 RVA: 0x00C2AFB7 File Offset: 0x00C291B7
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CheckCanClick));
		}

		// Token: 0x0602B505 RID: 177413 RVA: 0x00C2AFDC File Offset: 0x00C291DC
		public override void OnSelect()
		{
			if (this.OnSelectCall != null && this.Data != 0)
			{
				this.OnSelectCall(this.Data);
			}
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
			}
			this.Canvas.SetSortOrder(1, true);
		}

		// Token: 0x0602B506 RID: 177414 RVA: 0x00C2B02D File Offset: 0x00C2922D
		protected override void OnUnSelect()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.Canvas.SetSortOrder(0, true);
		}

		// Token: 0x0602B507 RID: 177415 RVA: 0x00C2B052 File Offset: 0x00C29252
		protected override void OnRefreshItem(int data)
		{
			this.Data = data;
			this.RefreshCover();
			this.RefreshState();
		}

		// Token: 0x0602B508 RID: 177416 RVA: 0x00C2B067 File Offset: 0x00C29267
		protected override void OnMoveItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0602B509 RID: 177417 RVA: 0x00C2B080 File Offset: 0x00C29280
		private void RefreshCover()
		{
			if (this.Data == 0)
			{
				string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_SelectLevelPixEmpty");
				base.SetTextureByPath(resourcePath, base.GetTexture(1), null, null);
				return;
			}
			RogueResDungeonConfig? config = ConfigRogueResDungeonConfigById.GetConfig(this.Data, true);
			if (config == null)
			{
				return;
			}
			string path = (PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Female) ? config.Value.IconF : config.Value.IconM;
			base.SetTextureByPath(path, base.GetTexture(1), null, null);
		}

		// Token: 0x0602B50A RID: 177418 RVA: 0x00C2B11C File Offset: 0x00C2931C
		private void RefreshState()
		{
			if (this.Data == 0)
			{
				base.GetExtendToggle(0).SetSelfInteractive(false);
				UUIItem item = base.GetItem(3);
				if (item != null)
				{
					item.SetUIActive(false);
				}
				UUIItem item2 = base.GetItem(2);
				if (item2 == null)
				{
					return;
				}
				item2.SetUIActive(false);
				return;
			}
			else
			{
				base.GetExtendToggle(0).SetSelfInteractive(true);
				RogueResDungeonConfig? config = ConfigRogueResDungeonConfigById.GetConfig(this.Data, true);
				if (config == null)
				{
					return;
				}
				bool flag = ConfigRogueResThemeById.GetConfig(config.Value.SeasonId, true).Value.Insts().IndexOf(this.Data) == 0;
				ERogueResInstState instDungeonState = ActivityPermanentRogueModel.Instance.GetInstDungeonState(this.Data);
				UUIItem item3 = base.GetItem(3);
				if (item3 != null)
				{
					item3.SetUIActive(!flag && instDungeonState == ERogueResInstState.Lock);
				}
				UUIItem item4 = base.GetItem(2);
				if (item4 == null)
				{
					return;
				}
				item4.SetUIActive(instDungeonState == ERogueResInstState.Finished);
				return;
			}
		}

		// Token: 0x0602B50B RID: 177419 RVA: 0x00C2B200 File Offset: 0x00C29400
		private void SelectedItem(EToggleState toggleState)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
			}
			Action<RogueDungeonDataItem> onToggleClick = this.OnToggleClick;
			if (onToggleClick == null)
			{
				return;
			}
			onToggleClick(this);
		}

		// Token: 0x0602B50C RID: 177420 RVA: 0x00C2B229 File Offset: 0x00C29429
		private bool CheckCanClick()
		{
			return this.CheckToggleCanClick == null || this.CheckToggleCanClick(this.Data);
		}

		// Token: 0x0602B50D RID: 177421 RVA: 0x00C2B246 File Offset: 0x00C29446
		public int? GetData()
		{
			return new int?(this.Data);
		}

		// Token: 0x0602B50E RID: 177422 RVA: 0x00C2B253 File Offset: 0x00C29453
		public void UnSelectWhenEnter()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.Canvas.SetSortOrder(0, true);
		}

		// Token: 0x040175C8 RID: 95688
		private int Data;

		// Token: 0x040175C9 RID: 95689
		private readonly ULGUICanvas Canvas;

		// Token: 0x040175CA RID: 95690
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RogueDungeonDataItem> OnToggleClick;

		// Token: 0x040175CB RID: 95691
		public Action<int> OnSelectCall;

		// Token: 0x040175CC RID: 95692
		public Func<int, bool> CheckToggleCanClick;

		// Token: 0x040175CD RID: 95693
		public const int SORT_MAX = 1;

		// Token: 0x040175CE RID: 95694
		public const int SORT_EMPTY = 0;
	}
}
