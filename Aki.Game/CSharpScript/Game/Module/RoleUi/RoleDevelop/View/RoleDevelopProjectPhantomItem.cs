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
	// Token: 0x02004D41 RID: 19777
	public class RoleDevelopProjectPhantomItem : UiPanelBase
	{
		// Token: 0x0603318A RID: 209290 RVA: 0x00BE8184 File Offset: 0x00BE6384
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

		// Token: 0x0603318B RID: 209291 RVA: 0x00BE8334 File Offset: 0x00BE6534
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopProjectPhantomItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopProjectPhantomItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603318C RID: 209292 RVA: 0x00BE8378 File Offset: 0x00BE6578
		[NullableContext(1)]
		public void Refresh(RoleDevelopData developData, int phantomIncId, int index)
		{
			this.DevelopData = developData;
			this.PhantomIncId = phantomIncId;
			this.Index = index;
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

		// Token: 0x0603318D RID: 209293 RVA: 0x00BE8498 File Offset: 0x00BE6698
		private void OnClickHeadItem()
		{
			if (this.DevelopData == null)
			{
				return;
			}
			int id = this.DevelopData.GetId();
			PhantomBattleModel.Instance.CurrentEquipmentSelectIndex = this.Index;
			int equipByIndex = PhantomBattleController.Instance.GetEquipByIndex(id, this.Index);
			PhantomBattleModel.Instance.CurrentSelectUniqueId = equipByIndex;
			PhantomUtil.OpenVisionEquipmentView(id, this.Index, null);
		}

		// Token: 0x0401B29C RID: 111260
		[Nullable(2)]
		private RoleDevelopData DevelopData;

		// Token: 0x0401B29D RID: 111261
		private int PhantomIncId;

		// Token: 0x0401B29E RID: 111262
		[Nullable(1)]
		private VisionFetterSuitItem VisionFetterSuitItem;

		// Token: 0x0401B29F RID: 111263
		private int Index;

		// Token: 0x0200AEA2 RID: 44706
		public static class EComponentType
		{
			// Token: 0x04035073 RID: 217203
			public const int ButtonHeadItem = 0;

			// Token: 0x04035074 RID: 217204
			public const int CircleItemTexture = 1;

			// Token: 0x04035075 RID: 217205
			public const int QualitySprite = 2;

			// Token: 0x04035076 RID: 217206
			public const int CostItem = 3;

			// Token: 0x04035077 RID: 217207
			public const int CostNumText = 4;

			// Token: 0x04035078 RID: 217208
			public const int SuitElementItem = 5;

			// Token: 0x04035079 RID: 217209
			public const int LevelItem = 6;

			// Token: 0x0403507A RID: 217210
			public const int LevelText = 7;

			// Token: 0x0403507B RID: 217211
			public const int PanelNor = 8;

			// Token: 0x0403507C RID: 217212
			public const int PanelEmpty = 9;
		}
	}
}
