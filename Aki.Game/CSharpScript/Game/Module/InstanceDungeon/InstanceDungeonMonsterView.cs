using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.InstanceDungeon.InstanceDungeonSubComponent;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.InstanceDungeon
{
	// Token: 0x02004855 RID: 18517
	public class InstanceDungeonMonsterView : UiViewBase
	{
		// Token: 0x0602E99D RID: 190877 RVA: 0x00D02942 File Offset: 0x00D00B42
		[NullableContext(1)]
		public InstanceDungeonMonsterView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602E99E RID: 190878 RVA: 0x00D0294C File Offset: 0x00D00B4C
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

		// Token: 0x0602E99F RID: 190879 RVA: 0x00D02A3C File Offset: 0x00D00C3C
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

		// Token: 0x0602E9A0 RID: 190880 RVA: 0x00D02B60 File Offset: 0x00D00D60
		protected override void OnBeforeShow()
		{
			InstanceDungeon value = InstanceDungeonConfig.Instance.GetConfig(this.CurrentInstanceId).Value;
			this.MonsterLayout.RefreshByData(new List<int>(value.MonsterPreviewIter()), null, false);
			if (value.RecommendElementLength > 0)
			{
				UUIItem item = base.GetItem(2);
				if (item != null)
				{
					item.SetUIActive(true);
				}
				this.ElementLayout.RefreshByData(new List<int>(value.RecommendElementIter()), null, false);
				return;
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(false);
		}

		// Token: 0x0602E9A1 RID: 190881 RVA: 0x00D02BE8 File Offset: 0x00D00DE8
		protected override void OnBeforeDestroy()
		{
			this.MonsterLayout.ClearChildren();
		}

		// Token: 0x0602E9A2 RID: 190882 RVA: 0x00D02BF5 File Offset: 0x00D00DF5
		[NullableContext(1)]
		private InstanceDungeonMonsterGrid CreateMonsterItem()
		{
			return new InstanceDungeonMonsterGrid
			{
				CurrentInstanceId = this.CurrentInstanceId
			};
		}

		// Token: 0x0602E9A3 RID: 190883 RVA: 0x00D02C08 File Offset: 0x00D00E08
		[NullableContext(1)]
		private TowerElementItem CreateElementItem()
		{
			return new TowerElementItem();
		}

		// Token: 0x04018CAD RID: 101549
		private int CurrentInstanceId;

		// Token: 0x04018CAE RID: 101550
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<TowerElementItem, int> ElementLayout;

		// Token: 0x04018CAF RID: 101551
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<InstanceDungeonMonsterGrid, int> MonsterLayout;

		// Token: 0x0200A4F0 RID: 42224
		private static class EChildCom
		{
			// Token: 0x04033164 RID: 209252
			public const int UITextMonsterTips = 0;

			// Token: 0x04033165 RID: 209253
			public const int UILayoutMonster = 1;

			// Token: 0x04033166 RID: 209254
			public const int UIElementItem = 2;

			// Token: 0x04033167 RID: 209255
			public const int UIElementLayout = 3;

			// Token: 0x04033168 RID: 209256
			public const int BigTitle = 4;

			// Token: 0x04033169 RID: 209257
			public const int SmallTitle = 5;
		}

		// Token: 0x0200A4F1 RID: 42225
		public class InstanceDungeonMonsterViewOpenParam
		{
			// Token: 0x170079BC RID: 31164
			// (get) Token: 0x06045F0E RID: 286478 RVA: 0x01507735 File Offset: 0x01505935
			// (set) Token: 0x06045F0F RID: 286479 RVA: 0x0150773D File Offset: 0x0150593D
			public int InstanceId { get; set; }

			// Token: 0x170079BD RID: 31165
			// (get) Token: 0x06045F10 RID: 286480 RVA: 0x01507746 File Offset: 0x01505946
			// (set) Token: 0x06045F11 RID: 286481 RVA: 0x0150774E File Offset: 0x0150594E
			public InstanceDungeonBuffItem.EBuffInfoType? InfoType { get; set; }
		}
	}
}
