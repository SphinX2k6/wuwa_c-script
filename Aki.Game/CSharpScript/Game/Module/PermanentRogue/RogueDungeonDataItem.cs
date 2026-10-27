using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x02005306 RID: 21254
	[NullableContext(2)]
	[Nullable(0)]
	public class RogueDungeonDataItem : AutoAttachItem<int>
	{
		// Token: 0x06036606 RID: 222726 RVA: 0x00CDD530 File Offset: 0x00CDB730
		public RogueDungeonDataItem(AActor uiItem = null) : base(null)
		{
			this.Canvas = (uiItem.GetComponentByClass(ULGUICanvas.StaticClass()) as ULGUICanvas);
		}

		// Token: 0x06036607 RID: 222727 RVA: 0x00CDD554 File Offset: 0x00CDB754
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

		// Token: 0x06036608 RID: 222728 RVA: 0x00CDD5E7 File Offset: 0x00CDB7E7
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.CanExecuteChange.Bind(new Func<bool>(this.CheckCanClick));
		}

		// Token: 0x06036609 RID: 222729 RVA: 0x00CDD60C File Offset: 0x00CDB80C
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

		// Token: 0x0603660A RID: 222730 RVA: 0x00CDD65D File Offset: 0x00CDB85D
		protected override void OnUnSelect()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.Canvas.SetSortOrder(0, true);
		}

		// Token: 0x0603660B RID: 222731 RVA: 0x00CDD682 File Offset: 0x00CDB882
		protected override void OnRefreshItem(int data)
		{
			this.Data = data;
			this.RefreshCover();
			this.RefreshState();
		}

		// Token: 0x0603660C RID: 222732 RVA: 0x00CDD697 File Offset: 0x00CDB897
		protected override void OnMoveItem()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0603660D RID: 222733 RVA: 0x00CDD6B0 File Offset: 0x00CDB8B0
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

		// Token: 0x0603660E RID: 222734 RVA: 0x00CDD74C File Offset: 0x00CDB94C
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

		// Token: 0x0603660F RID: 222735 RVA: 0x00CDD830 File Offset: 0x00CDBA30
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

		// Token: 0x06036610 RID: 222736 RVA: 0x00CDD859 File Offset: 0x00CDBA59
		private bool CheckCanClick()
		{
			return this.CheckToggleCanClick == null || this.CheckToggleCanClick(this.Data);
		}

		// Token: 0x06036611 RID: 222737 RVA: 0x00CDD876 File Offset: 0x00CDBA76
		public int? GetData()
		{
			return new int?(this.Data);
		}

		// Token: 0x06036612 RID: 222738 RVA: 0x00CDD883 File Offset: 0x00CDBA83
		public void UnSelectWhenEnter()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.Canvas.SetSortOrder(0, true);
		}

		// Token: 0x0401CB92 RID: 117650
		private int Data;

		// Token: 0x0401CB93 RID: 117651
		private readonly ULGUICanvas Canvas;

		// Token: 0x0401CB94 RID: 117652
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<RogueDungeonDataItem> OnToggleClick;

		// Token: 0x0401CB95 RID: 117653
		public Action<int> OnSelectCall;

		// Token: 0x0401CB96 RID: 117654
		public Func<int, bool> CheckToggleCanClick;

		// Token: 0x0401CB97 RID: 117655
		public const int SORT_MAX = 1;

		// Token: 0x0401CB98 RID: 117656
		public const int SORT_EMPTY = 0;
	}
}
