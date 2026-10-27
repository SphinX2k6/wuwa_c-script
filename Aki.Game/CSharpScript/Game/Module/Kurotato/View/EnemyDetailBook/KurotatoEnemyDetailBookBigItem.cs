using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.EnemyDetailBook
{
	// Token: 0x0200576C RID: 22380
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoEnemyDetailBookBigItem : GridProxyAbstract<KurotatoEnemyDetailBookBigItemData>
	{
		// Token: 0x06038D9D RID: 232861 RVA: 0x00D81B30 File Offset: 0x00D7FD30
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038D9E RID: 232862 RVA: 0x00D81CA3 File Offset: 0x00D7FEA3
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<KurotatoEnemyDetailBookGridItem, KurotatoEnemyData>(base.GetGridLayout(8), new Func<KurotatoEnemyDetailBookGridItem>(this.InitGridItem), null, false, true);
		}

		// Token: 0x06038D9F RID: 232863 RVA: 0x00D81CC6 File Offset: 0x00D7FEC6
		private KurotatoEnemyDetailBookGridItem InitGridItem()
		{
			return new KurotatoEnemyDetailBookGridItem
			{
				OnItemClickCallback = new Action<KurotatoEnemyData>(this.OnClickGridItem)
			};
		}

		// Token: 0x06038DA0 RID: 232864 RVA: 0x00D81CDF File Offset: 0x00D7FEDF
		public bool GetChildRefreshed()
		{
			return this.IsRefreshed;
		}

		// Token: 0x06038DA1 RID: 232865 RVA: 0x00D81CE8 File Offset: 0x00D7FEE8
		public override void Refresh(KurotatoEnemyDetailBookBigItemData data, bool isSelected, int gridIndex)
		{
			if (this.Layout == null)
			{
				this.Layout = new GenericLayout<KurotatoEnemyDetailBookGridItem, KurotatoEnemyData>(base.GetGridLayout(8), new Func<KurotatoEnemyDetailBookGridItem>(this.InitGridItem), null, false, true);
			}
			this.DataList = data.GetMonsterGridItemDataList();
			this.Layout.RefreshByData(this.DataList, delegate
			{
				foreach (KurotatoEnemyDetailBookGridItem kurotatoEnemyDetailBookGridItem in this.Layout.GetLayoutItemList())
				{
					UUIItem rootItem = kurotatoEnemyDetailBookGridItem.GetRootItem();
					if (rootItem != null)
					{
						rootItem.SetAlpha(1f);
					}
				}
				EKurotatoEnemyDetailBookTabAllOrWave tabAllOrWave = data.TabAllOrWave;
				if (tabAllOrWave != EKurotatoEnemyDetailBookTabAllOrWave.All)
				{
					if (tabAllOrWave == EKurotatoEnemyDetailBookTabAllOrWave.Wave)
					{
						this.RefreshAsWaveItem(data);
					}
				}
				else
				{
					this.RefreshAsAllItem(data);
				}
				if (this.Data.CurSelectedGridItemData != null)
				{
					int num = this.DataList.IndexOf(this.Data.CurSelectedGridItemData);
					if (num != -1)
					{
						this.Layout.SelectGridProxy(num, false);
						return;
					}
					this.Layout.DeselectCurrentGridProxy();
				}
			}, true);
			bool flag = data.TabAllOrWave == EKurotatoEnemyDetailBookTabAllOrWave.All;
			base.GetItem(1).SetUIActive(flag);
			base.GetText(3).SetUIActive(!flag);
			base.GetItem(5).SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
			base.GetItem(6).SetUIActive(false);
			base.GetItem(0).SetAlpha(1f);
		}

		// Token: 0x06038DA2 RID: 232866 RVA: 0x00D81DC8 File Offset: 0x00D7FFC8
		private void RefreshAsAllItem(KurotatoEnemyDetailBookBigItemData data)
		{
			this.Data = data;
			KurotatoEnemyDetailBookBigItemDataAll kurotatoEnemyDetailBookBigItemDataAll = data as KurotatoEnemyDetailBookBigItemDataAll;
			if (kurotatoEnemyDetailBookBigItemDataAll == null)
			{
				return;
			}
			KurotatoMonsterRisk? monsterRiskConfig = KurotatoConfig.Instance.GetMonsterRiskConfig(kurotatoEnemyDetailBookBigItemDataAll.RiskType);
			if (monsterRiskConfig == null)
			{
				return;
			}
			string icon = monsterRiskConfig.Value.Icon;
			string name = monsterRiskConfig.Value.Name;
			this.SetSpriteByPath(icon, base.GetSprite(2), false, null, null);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), name, Array.Empty<object>());
		}

		// Token: 0x06038DA3 RID: 232867 RVA: 0x00D81E58 File Offset: 0x00D80058
		private void RefreshAsWaveItem(KurotatoEnemyDetailBookBigItemData data)
		{
			this.Data = data;
			KurotatoEnemyDetailBookBigItemDataWave kurotatoEnemyDetailBookBigItemDataWave = data as KurotatoEnemyDetailBookBigItemDataWave;
			if (kurotatoEnemyDetailBookBigItemDataWave == null)
			{
				return;
			}
			base.GetText(3).SetText(kurotatoEnemyDetailBookBigItemDataWave.ThisWave.ToString().PadLeft(2, '0'), true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "Survivor_Wave", Array.Empty<object>());
			base.GetItem(5).SetUIActive(kurotatoEnemyDetailBookBigItemDataWave.IsHighDiff);
			bool flag = false;
			switch (kurotatoEnemyDetailBookBigItemDataWave.WaveStatus)
			{
			case EKurotatoWaveStatus.Current:
				flag = true;
				base.GetItem(7).SetUIActive(true);
				break;
			case EKurotatoWaveStatus.Completed:
				base.GetItem(6).SetUIActive(true);
				foreach (KurotatoEnemyDetailBookGridItem kurotatoEnemyDetailBookGridItem in this.Layout.GetLayoutItemList())
				{
					UUIItem rootItem = kurotatoEnemyDetailBookGridItem.GetRootItem();
					if (rootItem != null)
					{
						rootItem.SetAlpha(0.5f);
					}
				}
				flag = false;
				break;
			case EKurotatoWaveStatus.NotCompleted:
				flag = false;
				break;
			}
			UUIText text = base.GetText(3);
			UUIItem uuiitem = text;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(text.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
			UUIText text2 = base.GetText(4);
			UUIItem uuiitem2 = text2;
			bool bUseChangeColor2 = flag;
			fcolor = new FColor?(text2.changeColor);
			uuiitem2.SetChangeColor(bUseChangeColor2, fcolor);
		}

		// Token: 0x06038DA4 RID: 232868 RVA: 0x00D81FA4 File Offset: 0x00D801A4
		public void CheckSelectedStateIsInBigItem(KurotatoEnemyData data)
		{
			this.Layout.DeselectCurrentGridProxy();
			int gridIndex = this.DataList.IndexOf(data);
			GenericLayout<KurotatoEnemyDetailBookGridItem, KurotatoEnemyData> layout = this.Layout;
			if (layout == null)
			{
				return;
			}
			layout.SelectGridProxy(gridIndex, false);
		}

		// Token: 0x06038DA5 RID: 232869 RVA: 0x00D81FDB File Offset: 0x00D801DB
		private void OnClickGridItem(KurotatoEnemyData data)
		{
			EventSystem.Instance.Emit<KurotatoEnemyData>(EEventName.KurotatoEnemyDetailBookGridItemClick, data);
		}

		// Token: 0x0401DD15 RID: 122133
		[Nullable(2)]
		private KurotatoEnemyDetailBookBigItemData Data;

		// Token: 0x0401DD16 RID: 122134
		private List<KurotatoEnemyData> DataList = new List<KurotatoEnemyData>();

		// Token: 0x0401DD17 RID: 122135
		private readonly bool IsRefreshed;

		// Token: 0x0401DD18 RID: 122136
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<KurotatoEnemyDetailBookGridItem, KurotatoEnemyData> Layout;

		// Token: 0x0401DD19 RID: 122137
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<KurotatoEnemyData, bool> CanGridItemExecuteChangeCb;

		// Token: 0x0200B975 RID: 47477
		[NullableContext(0)]
		private class EBigItemComponent
		{
			// Token: 0x04038144 RID: 229700
			public const int TitleHorizontalLayout = 0;

			// Token: 0x04038145 RID: 229701
			public const int ItemIconAll = 1;

			// Token: 0x04038146 RID: 229702
			public const int SpriteIconAll = 2;

			// Token: 0x04038147 RID: 229703
			public const int TextNumWave = 3;

			// Token: 0x04038148 RID: 229704
			public const int TextTitle = 4;

			// Token: 0x04038149 RID: 229705
			public const int ItemWarringWave = 5;

			// Token: 0x0403814A RID: 229706
			public const int ItemDoneWave = 6;

			// Token: 0x0403814B RID: 229707
			public const int ItemChoose = 7;

			// Token: 0x0403814C RID: 229708
			public const int GridItemLayout = 8;

			// Token: 0x0403814D RID: 229709
			public const int GridItem = 9;
		}
	}
}
