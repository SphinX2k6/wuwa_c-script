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
	// Token: 0x02004743 RID: 18243
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class KurotatoEnemyDetailBookBigItem : GridProxyAbstract<KurotatoEnemyDetailBookBigItemData>
	{
		// Token: 0x0602DCAD RID: 187565 RVA: 0x00CD062C File Offset: 0x00CCE82C
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

		// Token: 0x0602DCAE RID: 187566 RVA: 0x00CD079F File Offset: 0x00CCE99F
		protected override void OnStart()
		{
			this.Layout = new GenericLayout<KurotatoEnemyDetailBookGridItem, KurotatoEnemyData>(base.GetGridLayout(8), new Func<KurotatoEnemyDetailBookGridItem>(this.InitGridItem), null, false, true);
		}

		// Token: 0x0602DCAF RID: 187567 RVA: 0x00CD07C2 File Offset: 0x00CCE9C2
		private KurotatoEnemyDetailBookGridItem InitGridItem()
		{
			return new KurotatoEnemyDetailBookGridItem
			{
				OnItemClickCallback = new Action<KurotatoEnemyData>(this.OnClickGridItem)
			};
		}

		// Token: 0x0602DCB0 RID: 187568 RVA: 0x00CD07DB File Offset: 0x00CCE9DB
		public bool GetChildRefreshed()
		{
			return this.IsRefreshed;
		}

		// Token: 0x0602DCB1 RID: 187569 RVA: 0x00CD07E4 File Offset: 0x00CCE9E4
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

		// Token: 0x0602DCB2 RID: 187570 RVA: 0x00CD08C4 File Offset: 0x00CCEAC4
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

		// Token: 0x0602DCB3 RID: 187571 RVA: 0x00CD0954 File Offset: 0x00CCEB54
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

		// Token: 0x0602DCB4 RID: 187572 RVA: 0x00CD0AA0 File Offset: 0x00CCECA0
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

		// Token: 0x0602DCB5 RID: 187573 RVA: 0x00CD0AD7 File Offset: 0x00CCECD7
		private void OnClickGridItem(KurotatoEnemyData data)
		{
			EventSystem.Instance.Emit<KurotatoEnemyData>(EEventName.KurotatoEnemyDetailBookGridItemClick, data);
		}

		// Token: 0x040187AB RID: 100267
		[Nullable(2)]
		private KurotatoEnemyDetailBookBigItemData Data;

		// Token: 0x040187AC RID: 100268
		private List<KurotatoEnemyData> DataList = new List<KurotatoEnemyData>();

		// Token: 0x040187AD RID: 100269
		private readonly bool IsRefreshed;

		// Token: 0x040187AE RID: 100270
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected GenericLayout<KurotatoEnemyDetailBookGridItem, KurotatoEnemyData> Layout;

		// Token: 0x040187AF RID: 100271
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<KurotatoEnemyData, bool> CanGridItemExecuteChangeCb;

		// Token: 0x0200A38F RID: 41871
		[NullableContext(0)]
		private class EBigItemComponent
		{
			// Token: 0x04032B3E RID: 207678
			public const int TitleHorizontalLayout = 0;

			// Token: 0x04032B3F RID: 207679
			public const int ItemIconAll = 1;

			// Token: 0x04032B40 RID: 207680
			public const int SpriteIconAll = 2;

			// Token: 0x04032B41 RID: 207681
			public const int TextNumWave = 3;

			// Token: 0x04032B42 RID: 207682
			public const int TextTitle = 4;

			// Token: 0x04032B43 RID: 207683
			public const int ItemWarringWave = 5;

			// Token: 0x04032B44 RID: 207684
			public const int ItemDoneWave = 6;

			// Token: 0x04032B45 RID: 207685
			public const int ItemChoose = 7;

			// Token: 0x04032B46 RID: 207686
			public const int GridItemLayout = 8;

			// Token: 0x04032B47 RID: 207687
			public const int GridItem = 9;
		}
	}
}
