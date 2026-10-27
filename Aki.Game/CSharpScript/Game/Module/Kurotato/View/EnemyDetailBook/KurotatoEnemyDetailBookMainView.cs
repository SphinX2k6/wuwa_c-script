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
	// Token: 0x0200576E RID: 22382
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoEnemyDetailBookMainView : UiViewBase
	{
		// Token: 0x06038DAF RID: 232879 RVA: 0x00D8212D File Offset: 0x00D8032D
		public KurotatoEnemyDetailBookMainView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06038DB0 RID: 232880 RVA: 0x00D82168 File Offset: 0x00D80368
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

		// Token: 0x06038DB1 RID: 232881 RVA: 0x00D82278 File Offset: 0x00D80478
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoEnemyDetailBookMainView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoEnemyDetailBookMainView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038DB2 RID: 232882 RVA: 0x00D822BB File Offset: 0x00D804BB
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<KurotatoEnemyData>(EEventName.KurotatoEnemyDetailBookGridItemClick, new Action<KurotatoEnemyData>(this.OnClickGridItem));
		}

		// Token: 0x06038DB3 RID: 232883 RVA: 0x00D822D9 File Offset: 0x00D804D9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<KurotatoEnemyData>(EEventName.KurotatoEnemyDetailBookGridItemClick, new Action<KurotatoEnemyData>(this.OnClickGridItem));
		}

		// Token: 0x06038DB4 RID: 232884 RVA: 0x00D822F8 File Offset: 0x00D804F8
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

		// Token: 0x06038DB5 RID: 232885 RVA: 0x00D823B0 File Offset: 0x00D805B0
		private KurotatoEnemyDetailBookTabTog CreateTabTogItem()
		{
			return new KurotatoEnemyDetailBookTabTog
			{
				OnTogClickCallBack = new Action<EKurotatoEnemyDetailBookTabAllOrWave>(this.OnClickTabTog),
				CanExecuteChangeFunc = new Func<int, bool>(this.CanTabTogChange)
			};
		}

		// Token: 0x06038DB6 RID: 232886 RVA: 0x00D823DB File Offset: 0x00D805DB
		private KurotatoEnemyDetailBookBigItem CreateBigItem()
		{
			return new KurotatoEnemyDetailBookBigItem
			{
				CanGridItemExecuteChangeCb = new Func<KurotatoEnemyData, bool>(this.CanGridItemExecuteChange)
			};
		}

		// Token: 0x06038DB7 RID: 232887 RVA: 0x00D823F4 File Offset: 0x00D805F4
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

		// Token: 0x06038DB8 RID: 232888 RVA: 0x00D8245C File Offset: 0x00D8065C
		private bool CanTabTogChange(int gridIndex)
		{
			GenericLayout<KurotatoEnemyDetailBookTabTog, EKurotatoEnemyDetailBookTabAllOrWave> tabTogLayout = this.TabTogLayout;
			int? num = (tabTogLayout != null) ? new int?(tabTogLayout.GetSelectedGridIndex()) : null;
			return !(num.GetValueOrDefault() == gridIndex & num != null);
		}

		// Token: 0x06038DB9 RID: 232889 RVA: 0x00D824A0 File Offset: 0x00D806A0
		private bool CanGridItemExecuteChange(KurotatoEnemyData data)
		{
			EKurotatoEnemyDetailBookTabAllOrWave curShowAllOrWave = this.CurShowAllOrWave;
			if (curShowAllOrWave != EKurotatoEnemyDetailBookTabAllOrWave.All)
			{
				return curShowAllOrWave == EKurotatoEnemyDetailBookTabAllOrWave.Wave && this.CurSelectedDataInWave != data;
			}
			return this.CurSelectedDataInAll != data;
		}

		// Token: 0x06038DBA RID: 232890 RVA: 0x00D824D8 File Offset: 0x00D806D8
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

		// Token: 0x06038DBB RID: 232891 RVA: 0x00D8252C File Offset: 0x00D8072C
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

		// Token: 0x06038DBC RID: 232892 RVA: 0x00D8261C File Offset: 0x00D8081C
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

		// Token: 0x06038DBD RID: 232893 RVA: 0x00D826B0 File Offset: 0x00D808B0
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

		// Token: 0x06038DBE RID: 232894 RVA: 0x00D826EC File Offset: 0x00D808EC
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

		// Token: 0x06038DBF RID: 232895 RVA: 0x00D82721 File Offset: 0x00D80921
		private void OnCloseClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401DD1D RID: 122141
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401DD1E RID: 122142
		private int CurTargetLevel = 1001;

		// Token: 0x0401DD1F RID: 122143
		private EKurotatoEnemyDetailBookTabAllOrWave CurShowAllOrWave;

		// Token: 0x0401DD20 RID: 122144
		private int InitTargetWave;

		// Token: 0x0401DD21 RID: 122145
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<KurotatoEnemyDetailBookTabTog, EKurotatoEnemyDetailBookTabAllOrWave> TabTogLayout;

		// Token: 0x0401DD22 RID: 122146
		private readonly List<EKurotatoEnemyDetailBookTabAllOrWave> TabTogDataList = new List<EKurotatoEnemyDetailBookTabAllOrWave>
		{
			EKurotatoEnemyDetailBookTabAllOrWave.All,
			EKurotatoEnemyDetailBookTabAllOrWave.Wave
		};

		// Token: 0x0401DD23 RID: 122147
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected LoopScrollView<KurotatoEnemyDetailBookBigItem, KurotatoEnemyDetailBookBigItemData> ScrollView;

		// Token: 0x0401DD24 RID: 122148
		protected Dictionary<EKurotatoEnemyDetailBookTabAllOrWave, List<KurotatoEnemyDetailBookBigItemData>> BigItemDataListMap = new Dictionary<EKurotatoEnemyDetailBookTabAllOrWave, List<KurotatoEnemyDetailBookBigItemData>>();

		// Token: 0x0401DD25 RID: 122149
		[Nullable(2)]
		private KurotatoEnemyData CurSelectedDataInAll;

		// Token: 0x0401DD26 RID: 122150
		[Nullable(2)]
		private KurotatoEnemyData CurSelectedDataInWave;

		// Token: 0x0401DD27 RID: 122151
		[Nullable(2)]
		private KurotatoEnemyDetailBookInfoPanel EnemyInfoPanel;

		// Token: 0x0401DD28 RID: 122152
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B977 RID: 47479
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x04038150 RID: 229712
			public const int CaptionItem = 0;

			// Token: 0x04038151 RID: 229713
			public const int PanelTab = 1;

			// Token: 0x04038152 RID: 229714
			public const int ToggleTab = 2;

			// Token: 0x04038153 RID: 229715
			public const int MainScrollView = 3;

			// Token: 0x04038154 RID: 229716
			public const int NodeEnemyItemGrid = 4;

			// Token: 0x04038155 RID: 229717
			public const int PanelEnemyInfo = 5;

			// Token: 0x04038156 RID: 229718
			public const int Content = 6;
		}
	}
}
