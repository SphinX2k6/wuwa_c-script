using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x0200587D RID: 22653
	public class InstanceDungeonMonsterView : UiViewBase
	{
		// Token: 0x06039A7A RID: 236154 RVA: 0x00DB3A2E File Offset: 0x00DB1C2E
		[NullableContext(1)]
		public InstanceDungeonMonsterView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06039A7B RID: 236155 RVA: 0x00DB3A38 File Offset: 0x00DB1C38
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06039A7C RID: 236156 RVA: 0x00DB3B28 File Offset: 0x00DB1D28
		protected override void OnStart()
		{
			InstanceDungeonMonsterView.InstanceDungeonMonsterViewOpenParam instanceDungeonMonsterViewOpenParam = this.OpenParam as InstanceDungeonMonsterView.InstanceDungeonMonsterViewOpenParam;
			this.CurrentInstanceId = instanceDungeonMonsterViewOpenParam.InstanceId;
			InstanceDungeonBuffItem.EBuffInfoType? infoType = instanceDungeonMonsterViewOpenParam.InfoType;
			if (infoType != null)
			{
				InstanceDungeonBuffItem.EBuffInfoType valueOrDefault = infoType.GetValueOrDefault();
				if (valueOrDefault != InstanceDungeonBuffItem.EBuffInfoType.Buff)
				{
					if (valueOrDefault == InstanceDungeonBuffItem.EBuffInfoType.Resistance)
					{
						LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "WeeklyBossInfo_Text", Array.Empty<object>());
						LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "WeeklyBossInfo_Title", Array.Empty<object>());
					}
				}
				else
				{
					LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "PrefabTextItem_3355612697_Text", Array.Empty<object>());
					LguiUtil.Instance.SetLocalTextNew(base.GetText(5), "PrefabTextItem_2611535427_Text", Array.Empty<object>());
				}
			}
			base.GetText(0).ShowTextNew(InstanceDungeonConfig.Instance.GetConfig(this.CurrentInstanceId).Value.MonsterTips);
			this.MonsterLayout = new GenericLayout<InstanceDungeonMonsterGrid, int>(base.GetGridLayout(1), new Func<InstanceDungeonMonsterGrid>(this.CreateMonsterItem), null, false, true);
			this.ElementLayout = new GenericLayout<TowerElementItem, int>(base.GetHorizontalLayout(3), new Func<TowerElementItem>(this.CreateElementItem), null, false, true);
		}

		// Token: 0x06039A7D RID: 236157 RVA: 0x00DB3C4C File Offset: 0x00DB1E4C
		protected override void OnBeforeShow()
		{
			InstanceDungeon value = InstanceDungeonConfig.Instance.GetConfig(this.CurrentInstanceId).Value;
			this.MonsterLayout.RefreshByData(value.MonsterPreviewIter().ToList<int>(), null, false);
			if (value.RecommendElementLength > 0)
			{
				UUIItem item = base.GetItem(2);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				this.ElementLayout.RefreshByData(value.RecommendElementIter().ToList<int>(), null, false);
				return;
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x06039A7E RID: 236158 RVA: 0x00DB3CD4 File Offset: 0x00DB1ED4
		protected override void OnBeforeDestroy()
		{
			this.MonsterLayout.ClearChildren();
		}

		// Token: 0x06039A7F RID: 236159 RVA: 0x00DB3CE1 File Offset: 0x00DB1EE1
		[NullableContext(1)]
		private InstanceDungeonMonsterGrid CreateMonsterItem()
		{
			return new InstanceDungeonMonsterGrid
			{
				CurrentInstanceId = this.CurrentInstanceId
			};
		}

		// Token: 0x06039A80 RID: 236160 RVA: 0x00DB3CF4 File Offset: 0x00DB1EF4
		[NullableContext(1)]
		private TowerElementItem CreateElementItem()
		{
			return new TowerElementItem();
		}

		// Token: 0x0401E210 RID: 123408
		private int CurrentInstanceId;

		// Token: 0x0401E211 RID: 123409
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TowerElementItem, int> ElementLayout;

		// Token: 0x0401E212 RID: 123410
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<InstanceDungeonMonsterGrid, int> MonsterLayout;

		// Token: 0x0200BAD7 RID: 47831
		private static class EChildCom
		{
			// Token: 0x04038763 RID: 231267
			public const int UITextMonsterTips = 0;

			// Token: 0x04038764 RID: 231268
			public const int UILayoutMonster = 1;

			// Token: 0x04038765 RID: 231269
			public const int UIElementItem = 2;

			// Token: 0x04038766 RID: 231270
			public const int UIElementLayout = 3;

			// Token: 0x04038767 RID: 231271
			public const int BigTitle = 4;

			// Token: 0x04038768 RID: 231272
			public const int SmallTitle = 5;
		}

		// Token: 0x0200BAD8 RID: 47832
		public class InstanceDungeonMonsterViewOpenParam
		{
			// Token: 0x1700A21F RID: 41503
			// (get) Token: 0x0604F97A RID: 326010 RVA: 0x0154E079 File Offset: 0x0154C279
			// (set) Token: 0x0604F97B RID: 326011 RVA: 0x0154E081 File Offset: 0x0154C281
			public int InstanceId { get; set; }

			// Token: 0x1700A220 RID: 41504
			// (get) Token: 0x0604F97C RID: 326012 RVA: 0x0154E08A File Offset: 0x0154C28A
			// (set) Token: 0x0604F97D RID: 326013 RVA: 0x0154E092 File Offset: 0x0154C292
			public InstanceDungeonBuffItem.EBuffInfoType? InfoType { get; set; }
		}
	}
}
