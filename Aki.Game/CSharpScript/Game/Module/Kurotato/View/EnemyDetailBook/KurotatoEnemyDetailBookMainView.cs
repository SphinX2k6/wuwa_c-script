using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.EnemyDetailBook
{
	// Token: 0x02004745 RID: 18245
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoEnemyDetailBookMainView : UiViewBase
	{
		// Token: 0x0602DCBF RID: 187583 RVA: 0x00CD0C29 File Offset: 0x00CCEE29
		public KurotatoEnemyDetailBookMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602DCC0 RID: 187584 RVA: 0x00CD0C64 File Offset: 0x00CCEE64
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIInturnAnimController));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DCC1 RID: 187585 RVA: 0x00CD0D74 File Offset: 0x00CCEF74
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoEnemyDetailBookMainView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoEnemyDetailBookMainView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DCC2 RID: 187586 RVA: 0x00CD0DB7 File Offset: 0x00CCEFB7
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<KurotatoEnemyData>(EEventName.KurotatoEnemyDetailBookGridItemClick, new Action<KurotatoEnemyData>(this.OnClickGridItem));
		}

		// Token: 0x0602DCC3 RID: 187587 RVA: 0x00CD0DD5 File Offset: 0x00CCEFD5
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<KurotatoEnemyData>(EEventName.KurotatoEnemyDetailBookGridItemClick, new Action<KurotatoEnemyData>(this.OnClickGridItem));
		}

		// Token: 0x0602DCC4 RID: 187588 RVA: 0x00CD0DF4 File Offset: 0x00CCEFF4
		protected override void OnBeforeShow()
		{
			List<KurotatoEnemyDetailBookBigItemData> list;
			if (this.BigItemDataListMap.TryGetValue(EKurotatoEnemyDetailBookTabAllOrWave.Wave, out list) && list.Count > 0)
			{
				int num = Math.Max(this.InitTargetWave - 1, 0);
				if (num < list.Count)
				{
					List<KurotatoEnemyData> monsterGridItemDataList = list[num].GetMonsterGridItemDataList();
					if (monsterGridItemDataList.Count > 0)
					{
						this.CurSelectedDataInWave = monsterGridItemDataList[0];
					}
				}
			}
			List<KurotatoEnemyDetailBookBigItemData> list2;
			if (this.BigItemDataListMap.TryGetValue(EKurotatoEnemyDetailBookTabAllOrWave.All, out list2) && list2.Count > 0)
			{
				List<KurotatoEnemyData> monsterGridItemDataList2 = list2[0].GetMonsterGridItemDataList();
				if (monsterGridItemDataList2.Count > 0)
				{
					this.CurSelectedDataInAll = monsterGridItemDataList2[0];
				}
			}
			if (this.InitTargetWave > 0)
			{
				this.OnClickTabTog(EKurotatoEnemyDetailBookTabAllOrWave.Wave);
				return;
			}
			this.OnClickTabTog(EKurotatoEnemyDetailBookTabAllOrWave.All);
		}

		// Token: 0x0602DCC5 RID: 187589 RVA: 0x00CD0EAC File Offset: 0x00CCF0AC
		private KurotatoEnemyDetailBookTabTog CreateTabTogItem()
		{
			return new KurotatoEnemyDetailBookTabTog
			{
				OnTogClickCallBack = new Action<EKurotatoEnemyDetailBookTabAllOrWave>(this.OnClickTabTog),
				CanExecuteChangeFunc = new Func<int, bool>(this.CanTabTogChange)
			};
		}

		// Token: 0x0602DCC6 RID: 187590 RVA: 0x00CD0ED7 File Offset: 0x00CCF0D7
		private KurotatoEnemyDetailBookBigItem CreateBigItem()
		{
			return new KurotatoEnemyDetailBookBigItem
			{
				CanGridItemExecuteChangeCb = new Func<KurotatoEnemyData, bool>(this.CanGridItemExecuteChange)
			};
		}

		// Token: 0x0602DCC7 RID: 187591 RVA: 0x00CD0EF0 File Offset: 0x00CCF0F0
		private void OnClickTabTog(EKurotatoEnemyDetailBookTabAllOrWave data)
		{
			this.CurShowAllOrWave = data;
			GenericLayout<KurotatoEnemyDetailBookTabTog, EKurotatoEnemyDetailBookTabAllOrWave> tabTogLayout = this.TabTogLayout;
			if (tabTogLayout != null)
			{
				tabTogLayout.SelectGridProxy((int)data, false);
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer != null)
			{
				levelSequencePlayer.StopSequenceByKey("Switch", false, true);
			}
			LevelSequencePlayer levelSequencePlayer2 = this.LevelSequencePlayer;
			if (levelSequencePlayer2 != null)
			{
				levelSequencePlayer2.PlayLevelSequenceByName("Switch", false, null, false);
			}
			this.RefreshView();
		}

		// Token: 0x0602DCC8 RID: 187592 RVA: 0x00CD0F58 File Offset: 0x00CCF158
		private bool CanTabTogChange(int gridIndex)
		{
			GenericLayout<KurotatoEnemyDetailBookTabTog, EKurotatoEnemyDetailBookTabAllOrWave> tabTogLayout = this.TabTogLayout;
			int? num = (tabTogLayout != null) ? new int?(tabTogLayout.GetSelectedGridIndex()) : null;
			return !(num.GetValueOrDefault() == gridIndex & num != null);
		}

		// Token: 0x0602DCC9 RID: 187593 RVA: 0x00CD0F9C File Offset: 0x00CCF19C
		private bool CanGridItemExecuteChange(KurotatoEnemyData data)
		{
			EKurotatoEnemyDetailBookTabAllOrWave curShowAllOrWave = this.CurShowAllOrWave;
			if (curShowAllOrWave != EKurotatoEnemyDetailBookTabAllOrWave.All)
			{
				return curShowAllOrWave == EKurotatoEnemyDetailBookTabAllOrWave.Wave && this.CurSelectedDataInWave != data;
			}
			return this.CurSelectedDataInAll != data;
		}

		// Token: 0x0602DCCA RID: 187594 RVA: 0x00CD0FD4 File Offset: 0x00CCF1D4
		private void OnClickGridItem(KurotatoEnemyData data)
		{
			this.SetCurSelectedData(data);
			int displayGridStartIndex = this.ScrollView.GetDisplayGridStartIndex();
			int displayGridEndIndex = this.ScrollView.GetDisplayGridEndIndex();
			for (int i = displayGridStartIndex; i <= displayGridEndIndex; i++)
			{
				KurotatoEnemyDetailBookBigItem kurotatoEnemyDetailBookBigItem = this.ScrollView.UnsafeGetGridProxy(i, false);
				if (kurotatoEnemyDetailBookBigItem != null)
				{
					kurotatoEnemyDetailBookBigItem.CheckSelectedStateIsInBigItem(data);
				}
			}
			this.RefreshDetailInfoView();
		}

		// Token: 0x0602DCCB RID: 187595 RVA: 0x00CD1028 File Offset: 0x00CCF228
		private void CreateBigItemDataList()
		{
			List<KurotatoEnemyDetailBookBigItemData> list = new List<KurotatoEnemyDetailBookBigItemData>();
			List<KurotatoEnemyDetailBookBigItemData> list2 = new List<KurotatoEnemyDetailBookBigItemData>();
			for (int i = 3; i >= 1; i--)
			{
				KurotatoEnemyDetailBookBigItemDataAll kurotatoEnemyDetailBookBigItemDataAll = new KurotatoEnemyDetailBookBigItemDataAll(this.CurTargetLevel, i);
				if (kurotatoEnemyDetailBookBigItemDataAll.GetMonsterGridItemDataList().Count > 0)
				{
					list.Add(kurotatoEnemyDetailBookBigItemDataAll);
				}
			}
			List<KurotatoWave> waveByLevelId = KurotatoConfig.Instance.GetWaveByLevelId(this.CurTargetLevel);
			if (waveByLevelId == null || waveByLevelId.Count == 0)
			{
				return;
			}
			foreach (KurotatoWave kurotatoWave in waveByLevelId)
			{
				if (kurotatoWave.WaveType != 1)
				{
					int wave = kurotatoWave.Wave;
					KurotatoEnemyDetailBookBigItemDataWave item = new KurotatoEnemyDetailBookBigItemDataWave(this.CurTargetLevel, wave, this.InitTargetWave);
					list2.Add(item);
				}
			}
			this.BigItemDataListMap[EKurotatoEnemyDetailBookTabAllOrWave.All] = list;
			this.BigItemDataListMap[EKurotatoEnemyDetailBookTabAllOrWave.Wave] = list2;
		}

		// Token: 0x0602DCCC RID: 187596 RVA: 0x00CD1118 File Offset: 0x00CCF318
		[NullableContext(2)]
		private void SetCurSelectedData(KurotatoEnemyData data)
		{
			EKurotatoEnemyDetailBookTabAllOrWave curShowAllOrWave = this.CurShowAllOrWave;
			if (curShowAllOrWave != EKurotatoEnemyDetailBookTabAllOrWave.All)
			{
				if (curShowAllOrWave == EKurotatoEnemyDetailBookTabAllOrWave.Wave)
				{
					this.CurSelectedDataInWave = data;
				}
			}
			else
			{
				this.CurSelectedDataInAll = data;
			}
			foreach (KurotatoEnemyDetailBookBigItemData kurotatoEnemyDetailBookBigItemData in this.BigItemDataListMap[this.CurShowAllOrWave])
			{
				kurotatoEnemyDetailBookBigItemData.CurSelectedGridItemData = null;
				if (kurotatoEnemyDetailBookBigItemData.GetMonsterGridItemDataList().Contains(data))
				{
					kurotatoEnemyDetailBookBigItemData.CurSelectedGridItemData = data;
				}
			}
		}

		// Token: 0x0602DCCD RID: 187597 RVA: 0x00CD11AC File Offset: 0x00CCF3AC
		private void RefreshView()
		{
			List<KurotatoEnemyDetailBookBigItemData> data = this.BigItemDataListMap[this.CurShowAllOrWave];
			this.ScrollView.RefreshByData(data, false, delegate
			{
				EKurotatoEnemyDetailBookTabAllOrWave curShowAllOrWave = this.CurShowAllOrWave;
				if (curShowAllOrWave == EKurotatoEnemyDetailBookTabAllOrWave.All)
				{
					this.OnClickGridItem(this.CurSelectedDataInAll);
					return;
				}
				if (curShowAllOrWave != EKurotatoEnemyDetailBookTabAllOrWave.Wave)
				{
					return;
				}
				this.OnClickGridItem(this.CurSelectedDataInWave);
				this.ScrollView.ScrollToGridIndexLate(Math.Max(this.InitTargetWave - 1, 0), false);
			}, false);
		}

		// Token: 0x0602DCCE RID: 187598 RVA: 0x00CD11E8 File Offset: 0x00CCF3E8
		private void RefreshDetailInfoView()
		{
			KurotatoEnemyData monsterData = (this.CurShowAllOrWave == EKurotatoEnemyDetailBookTabAllOrWave.All) ? this.CurSelectedDataInAll : this.CurSelectedDataInWave;
			KurotatoEnemyDetailBookInfoPanel enemyInfoPanel = this.EnemyInfoPanel;
			if (enemyInfoPanel == null)
			{
				return;
			}
			enemyInfoPanel.RefreshMonsterInfoShow(monsterData);
		}

		// Token: 0x0602DCCF RID: 187599 RVA: 0x00CD121D File Offset: 0x00CCF41D
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x040187B3 RID: 100275
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040187B4 RID: 100276
		private int CurTargetLevel = 1001;

		// Token: 0x040187B5 RID: 100277
		private EKurotatoEnemyDetailBookTabAllOrWave CurShowAllOrWave;

		// Token: 0x040187B6 RID: 100278
		private int InitTargetWave;

		// Token: 0x040187B7 RID: 100279
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<KurotatoEnemyDetailBookTabTog, EKurotatoEnemyDetailBookTabAllOrWave> TabTogLayout;

		// Token: 0x040187B8 RID: 100280
		private readonly List<EKurotatoEnemyDetailBookTabAllOrWave> TabTogDataList = new List<EKurotatoEnemyDetailBookTabAllOrWave>
		{
			EKurotatoEnemyDetailBookTabAllOrWave.All,
			EKurotatoEnemyDetailBookTabAllOrWave.Wave
		};

		// Token: 0x040187B9 RID: 100281
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected LoopScrollView<KurotatoEnemyDetailBookBigItem, KurotatoEnemyDetailBookBigItemData> ScrollView;

		// Token: 0x040187BA RID: 100282
		protected Dictionary<EKurotatoEnemyDetailBookTabAllOrWave, List<KurotatoEnemyDetailBookBigItemData>> BigItemDataListMap = new Dictionary<EKurotatoEnemyDetailBookTabAllOrWave, List<KurotatoEnemyDetailBookBigItemData>>();

		// Token: 0x040187BB RID: 100283
		[Nullable(2)]
		private KurotatoEnemyData CurSelectedDataInAll;

		// Token: 0x040187BC RID: 100284
		[Nullable(2)]
		private KurotatoEnemyData CurSelectedDataInWave;

		// Token: 0x040187BD RID: 100285
		[Nullable(2)]
		private KurotatoEnemyDetailBookInfoPanel EnemyInfoPanel;

		// Token: 0x040187BE RID: 100286
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200A391 RID: 41873
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04032B4A RID: 207690
			public const int CaptionItem = 0;

			// Token: 0x04032B4B RID: 207691
			public const int PanelTab = 1;

			// Token: 0x04032B4C RID: 207692
			public const int ToggleTab = 2;

			// Token: 0x04032B4D RID: 207693
			public const int MainScrollView = 3;

			// Token: 0x04032B4E RID: 207694
			public const int NodeEnemyItemGrid = 4;

			// Token: 0x04032B4F RID: 207695
			public const int PanelEnemyInfo = 5;

			// Token: 0x04032B50 RID: 207696
			public const int Content = 6;
		}
	}
}
