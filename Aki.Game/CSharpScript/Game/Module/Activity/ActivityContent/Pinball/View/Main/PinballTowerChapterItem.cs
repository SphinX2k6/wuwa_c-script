using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x020052B8 RID: 21176
	[NullableContext(2)]
	[Nullable(0)]
	public class PinballTowerChapterItem : UiPanelBase, IPinballChapterItem
	{
		// Token: 0x06034B85 RID: 215941 RVA: 0x00EBDFD8 File Offset: 0x00EBC1D8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnChapterClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06034B86 RID: 215942 RVA: 0x00EBE144 File Offset: 0x00EBC344
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			UUIEffectOutline extraEffectOutline = base.GetText(6).GetOwner().GetComponentByClass(UUIEffectOutline.StaticClass()) as UUIEffectOutline;
			this.ExtraEffectOutline = extraEffectOutline;
			base.GetButton(0).OnPointEnterCallBack.Bind(new Action(this.OnPointerEnter));
		}

		// Token: 0x06034B87 RID: 215943 RVA: 0x00EBE1A7 File Offset: 0x00EBC3A7
		protected override void OnBeforeDestroy()
		{
			base.GetButton(0).OnPointEnterCallBack.Unbind();
		}

		// Token: 0x06034B88 RID: 215944 RVA: 0x00EBE1BC File Offset: 0x00EBC3BC
		public UUIItem GetChapterButtonUiItem()
		{
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return null;
			}
			AUIBaseActor auibaseActor = button.GetOwner() as AUIBaseActor;
			if (auibaseActor == null)
			{
				return null;
			}
			return auibaseActor.GetUIItem();
		}

		// Token: 0x06034B89 RID: 215945 RVA: 0x00EBE1EC File Offset: 0x00EBC3EC
		private EPinballChapterLevelLockStatus GetChapterLockStatus(int chapterId)
		{
			return PinballModel.Instance.ActivityData.GetChapterLockStatus(chapterId);
		}

		// Token: 0x06034B8A RID: 215946 RVA: 0x00EBE1FE File Offset: 0x00EBC3FE
		[NullableContext(1)]
		void IPinballChapterItem.Refresh(PinballChapterData data)
		{
			this.Refresh(data, false);
		}

		// Token: 0x06034B8B RID: 215947 RVA: 0x00EBE208 File Offset: 0x00EBC408
		[NullableContext(1)]
		public void Refresh(PinballChapterData data, bool defaultGray = false)
		{
			PinballChapterConfig? pinballChapterConfigById = PinballConfig.Instance.GetPinballChapterConfigById(data.ChapterId);
			bool flag = this.GetChapterLockStatus(data.ChapterId) != EPinballChapterLevelLockStatus.Activated;
			base.GetItem(4).SetUIActive(defaultGray || flag);
			UUITexture texture = base.GetTexture(2);
			UUITexture texture2 = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetIsGray(defaultGray || flag);
			}
			if (texture2 != null)
			{
				texture2.SetIsGray(defaultGray || flag);
			}
			List<PinballLevelRecordData> list = new List<PinballLevelRecordData>();
			PinballActivityData activityData = PinballModel.Instance.ActivityData;
			int num = 0;
			foreach (int levelId in data.LevelIds)
			{
				PinballLevelRecordData levelData = activityData.GetLevelData(levelId);
				list.Add(levelData);
				if (levelData.PassStatus != EPinballLevelPassStatus.Unfinished)
				{
					num++;
				}
			}
			this.SetRedDotVisible(activityData.HasNewChapterRedDot(data.ChapterId));
			base.GetArtText(5).SetText(num.ToString());
			UUIText text = base.GetText(6);
			LguiUtil.Instance.SetLocalTextNew(text, pinballChapterConfigById.Value.Name, Array.Empty<object>());
			text.outlineColor = FColor.FromHex(pinballChapterConfigById.Value.OutlineColor);
			UUIEffectOutline extraEffectOutline = this.ExtraEffectOutline;
			if (extraEffectOutline != null)
			{
				extraEffectOutline.SetOutlineColor(FColor.FromHex(pinballChapterConfigById.Value.ExOutlineColor));
			}
			this.ChapterData = data;
			this.LevelDataList = list;
		}

		// Token: 0x06034B8C RID: 215948 RVA: 0x00EBE36C File Offset: 0x00EBC56C
		public void SetGray(bool isSetGray)
		{
			UUITexture texture = base.GetTexture(2);
			UUITexture texture2 = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetIsGray(isSetGray);
			}
			if (texture2 != null)
			{
				texture2.SetIsGray(isSetGray);
			}
		}

		// Token: 0x06034B8D RID: 215949 RVA: 0x00EBE39E File Offset: 0x00EBC59E
		public void SetRedDotVisible(bool isVisible)
		{
			UUIItem item = base.GetItem(7);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isVisible);
		}

		// Token: 0x06034B8E RID: 215950 RVA: 0x00EBE3B4 File Offset: 0x00EBC5B4
		public UniTask PlayUnlockTweenAsync()
		{
			PinballTowerChapterItem.<PlayUnlockTweenAsync>d__16 <PlayUnlockTweenAsync>d__;
			<PlayUnlockTweenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockTweenAsync>d__.<>4__this = this;
			<PlayUnlockTweenAsync>d__.<>1__state = -1;
			<PlayUnlockTweenAsync>d__.<>t__builder.Start<PinballTowerChapterItem.<PlayUnlockTweenAsync>d__16>(ref <PlayUnlockTweenAsync>d__);
			return <PlayUnlockTweenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034B8F RID: 215951 RVA: 0x00EBE3F8 File Offset: 0x00EBC5F8
		private void OnBtnChapterClick()
		{
			if (this.ChapterData == null || this.LevelDataList.Count == 0)
			{
				return;
			}
			EPinballChapterLevelLockStatus chapterLockStatus = this.GetChapterLockStatus(this.ChapterData.ChapterId);
			if (chapterLockStatus == EPinballChapterLevelLockStatus.Lock)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("Pinball_Main_ChapterTips01", null);
				string remainTimeText = ActivityModel.Instance.GetRemainTimeText((long)this.ChapterData.UnlockTime, localTextNew);
				ScrollingTipsController.Instance.ShowTipsByText(remainTimeText);
				return;
			}
			if (chapterLockStatus == EPinballChapterLevelLockStatus.PreLock)
			{
				string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew(PinballConfig.Instance.GetPinballChapterConfigById(this.ChapterData.PreChapterId).Value.Name, null);
				ScrollingTipsController.Instance.ShowTipsByTextId("Pinball_Level_UnlockInfo", new object[]
				{
					localTextNew2
				});
				return;
			}
			this.SetRedDotVisible(false);
			Action<PinballChapterData, List<PinballLevelRecordData>> onClickTowerBack = this.OnClickTowerBack;
			if (onClickTowerBack == null)
			{
				return;
			}
			onClickTowerBack(this.ChapterData, this.LevelDataList);
		}

		// Token: 0x06034B90 RID: 215952 RVA: 0x00EBE4D0 File Offset: 0x00EBC6D0
		private void OnPointerEnter()
		{
			if (this.ChapterData == null)
			{
				return;
			}
			int chapterId = this.ChapterData.ChapterId;
			PinballChapterConfig? pinballChapterConfigById = PinballConfig.Instance.GetPinballChapterConfigById(chapterId);
			if (pinballChapterConfigById == null || StringUtils.IsBlank(pinballChapterConfigById.Value.PlanetBg) || StringUtils.IsBlank(pinballChapterConfigById.Value.PlanetMaskBg))
			{
				return;
			}
			Action<string, string, int> onPointerEnterChapterBack = this.OnPointerEnterChapterBack;
			if (onPointerEnterChapterBack == null)
			{
				return;
			}
			onPointerEnterChapterBack(pinballChapterConfigById.Value.PlanetBg, pinballChapterConfigById.Value.PlanetMaskBg, chapterId);
		}

		// Token: 0x0401BEAE RID: 114350
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Action<PinballChapterData, List<PinballLevelRecordData>> OnClickTowerBack;

		// Token: 0x0401BEAF RID: 114351
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<string, string, int> OnPointerEnterChapterBack;

		// Token: 0x0401BEB0 RID: 114352
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401BEB1 RID: 114353
		private UUIEffectOutline ExtraEffectOutline;

		// Token: 0x0401BEB2 RID: 114354
		private PinballChapterData ChapterData;

		// Token: 0x0401BEB3 RID: 114355
		[Nullable(1)]
		private List<PinballLevelRecordData> LevelDataList = new List<PinballLevelRecordData>();

		// Token: 0x0200AF31 RID: 44849
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036213 RID: 221715
			BtnChapter,
			// Token: 0x04036214 RID: 221716
			NormalItem,
			// Token: 0x04036215 RID: 221717
			TexTowerBg,
			// Token: 0x04036216 RID: 221718
			TexDecoration,
			// Token: 0x04036217 RID: 221719
			LockItem,
			// Token: 0x04036218 RID: 221720
			ArtTxtLevelNum,
			// Token: 0x04036219 RID: 221721
			TxtChapterName,
			// Token: 0x0403621A RID: 221722
			RedDotItem
		}
	}
}
