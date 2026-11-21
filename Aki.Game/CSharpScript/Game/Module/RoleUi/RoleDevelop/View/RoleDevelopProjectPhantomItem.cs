using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D0A RID: 15626
	public class RoleDevelopProjectPhantomItem : UiPanelBase
	{
		// Token: 0x06027FE2 RID: 163810 RVA: 0x00B30EEC File Offset: 0x00B2F0EC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickHeadItem));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06027FE3 RID: 163811 RVA: 0x00B3109C File Offset: 0x00B2F29C
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectPhantomItem.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectPhantomItem.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06027FE4 RID: 163812 RVA: 0x00B310E0 File Offset: 0x00B2F2E0
		[NullableContext(1)]
		public void Refresh(RoleDevelopData developData, int phantomIncId, int index, bool clickEnabled = true)
		{
			this.DevelopData = developData;
			this.PhantomIncId = phantomIncId;
			this.Index = index;
			this.ClickEnabled = clickEnabled;
			base.GetButton(0).SetSelfInteractive(clickEnabled);
			PhantomBattleData phantomBattleData = PhantomBattleModel.Instance.GetPhantomBattleData(this.PhantomIncId);
			if (phantomBattleData == null)
			{
				base.GetItem(8).SetUIActive(false);
				base.GetItem(9).SetUIActive(true);
				return;
			}
			base.GetItem(8).SetUIActive(true);
			base.GetItem(9).SetUIActive(false);
			this.VisionFetterSuitItem.Update(new PhantomFetterGroup?(phantomBattleData.GetFetterGroupConfig()));
			ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(phantomBattleData.GetConfigId(true));
			base.SetTextureByPath(itemConfigData.Icon, base.GetTexture(1), null, null);
			int quality = phantomBattleData.GetQuality();
			this.SetSpriteByPath(PhantomBattleConfig.Instance.GetPhantomQualityBgSprite(quality), base.GetSprite(2), false, null, null);
			base.GetText(4).SetText(phantomBattleData.GetCost().ToString(), true);
			base.GetText(7).SetText("+" + phantomBattleData.GetPhantomLevel().ToString(), true);
		}

		// Token: 0x06027FE5 RID: 163813 RVA: 0x00B31214 File Offset: 0x00B2F414
		private void OnClickHeadItem()
		{
			if (this.DevelopData == null || !this.ClickEnabled)
			{
				return;
			}
			int id = this.DevelopData.GetId();
			PhantomBattleModel.Instance.CurrentEquipmentSelectIndex = this.Index;
			int equipByIndex = PhantomBattleController.Instance.GetEquipByIndex(id, this.Index);
			PhantomBattleModel.Instance.CurrentSelectUniqueId = equipByIndex;
			PhantomUtil.OpenVisionEquipmentView(id, this.Index, null);
		}

		// Token: 0x04015C6B RID: 89195
		[Nullable(2)]
		private RoleDevelopData DevelopData;

		// Token: 0x04015C6C RID: 89196
		private int PhantomIncId;

		// Token: 0x04015C6D RID: 89197
		[Nullable(1)]
		private VisionFetterSuitItem VisionFetterSuitItem;

		// Token: 0x04015C6E RID: 89198
		private int Index;

		// Token: 0x04015C6F RID: 89199
		private bool ClickEnabled = true;

		// Token: 0x020098D5 RID: 39125
		private enum EComponentType
		{
			// Token: 0x0402FA8F RID: 195215
			ButtonHeadItem,
			// Token: 0x0402FA90 RID: 195216
			CircleItemTexture,
			// Token: 0x0402FA91 RID: 195217
			QualitySprite,
			// Token: 0x0402FA92 RID: 195218
			CostItem,
			// Token: 0x0402FA93 RID: 195219
			CostNumText,
			// Token: 0x0402FA94 RID: 195220
			SuitElementItem,
			// Token: 0x0402FA95 RID: 195221
			LevelItem,
			// Token: 0x0402FA96 RID: 195222
			LevelText,
			// Token: 0x0402FA97 RID: 195223
			PanelNor,
			// Token: 0x0402FA98 RID: 195224
			PanelEmpty
		}
	}
}
