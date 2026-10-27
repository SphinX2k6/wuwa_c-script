using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Main
{
	// Token: 0x02006331 RID: 25393
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballMainChapterItem : UiPanelBase, IPinballChapterItem
	{
		// Token: 0x0603FE27 RID: 261671 RVA: 0x00F74734 File Offset: 0x00F72934
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnChapterClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FE28 RID: 261672 RVA: 0x00F748C4 File Offset: 0x00F72AC4
		protected override void OnStart()
		{
			this.ProgressLayout = new GenericLayout<PinballMainChapterProgressItem, PinballLevelRecordData>(base.GetHorizontalLayout(7), new Func<PinballMainChapterProgressItem>(this.InitProgressItem), base.GetItem(8).GetOwner() as AUIBaseActor, false, true);
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			UUIEffectOutline extraEffectOutline = base.GetText(6).GetOwner().GetComponentByClass(UUIEffectOutline.StaticClass()) as UUIEffectOutline;
			this.ExtraEffectOutline = extraEffectOutline;
			base.GetButton(0).OnPointEnterCallBack.Bind(new Action(this.OnPointerEnter));
		}

		// Token: 0x0603FE29 RID: 261673 RVA: 0x00F74958 File Offset: 0x00F72B58
		protected override void OnBeforeDestroy()
		{
			base.GetButton(0).OnPointEnterCallBack.Unbind();
		}

		// Token: 0x0603FE2A RID: 261674 RVA: 0x00F7496C File Offset: 0x00F72B6C
		[NullableContext(2)]
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

		// Token: 0x0603FE2B RID: 261675 RVA: 0x00F7499C File Offset: 0x00F72B9C
		private EPinballChapterLevelLockStatus GetChapterLockStatus(int chapterId)
		{
			return PinballModel.Instance.ActivityData.GetChapterLockStatus(chapterId);
		}

		// Token: 0x0603FE2C RID: 261676 RVA: 0x00F749AE File Offset: 0x00F72BAE
		void IPinballChapterItem.Refresh(PinballChapterData data)
		{
			this.Refresh(data, false);
		}

		// Token: 0x0603FE2D RID: 261677 RVA: 0x00F749B8 File Offset: 0x00F72BB8
		public void Refresh(PinballChapterData data, bool defaultGray = false)
		{
			PinballChapterConfig? pinballChapterConfigById = PinballConfig.Instance.GetPinballChapterConfigById(data.ChapterId);
			EPinballChapterLevelLockStatus chapterLockStatus = this.GetChapterLockStatus(data.ChapterId);
			bool flag = chapterLockStatus == EPinballChapterLevelLockStatus.Lock;
			bool flag2 = chapterLockStatus == EPinballChapterLevelLockStatus.Activated;
			UUITexture texture = base.GetTexture(2);
			UUITexture texture2 = base.GetTexture(3);
			UUITexture texture3 = base.GetTexture(4);
			if (texture != null)
			{
				texture.SetIsGray(defaultGray || !flag2);
			}
			if (texture2 != null)
			{
				texture2.SetIsGray(defaultGray || !flag2);
			}
			if (texture3 != null)
			{
				texture3.SetIsGray(defaultGray || !flag2);
			}
			base.SetTextureByPath(pinballChapterConfigById.Value.IconBg, texture, null, null);
			base.SetTextureByPath(pinballChapterConfigById.Value.IconDecoration, texture2, null, null);
			base.SetTextureByPath(pinballChapterConfigById.Value.IconArtName, texture3, null, null);
			base.GetItem(5).SetUIActive(defaultGray || !flag2);
			List<PinballLevelRecordData> list = new List<PinballLevelRecordData>();
			PinballActivityData activityData = PinballModel.Instance.ActivityData;
			for (int i = 0; i < pinballChapterConfigById.Value.LevelListLength; i++)
			{
				int levelId = pinballChapterConfigById.Value.LevelList(i);
				PinballLevelRecordData levelData = activityData.GetLevelData(levelId);
				list.Add(levelData);
			}
			this.SetRedDotVisible(activityData.HasNewChapterRedDot(data.ChapterId));
			GenericLayout<PinballMainChapterProgressItem, PinballLevelRecordData> progressLayout = this.ProgressLayout;
			if (progressLayout != null)
			{
				progressLayout.RefreshByData(list, null, false);
			}
			string newText;
			if (flag)
			{
				newText = "???";
				GenericLayout<PinballMainChapterProgressItem, PinballLevelRecordData> progressLayout2 = this.ProgressLayout;
				if (progressLayout2 != null)
				{
					progressLayout2.SetActive(false);
				}
			}
			else
			{
				newText = ConfigMultiTextLang.GetLocalTextNew(pinballChapterConfigById.Value.Name, null);
				GenericLayout<PinballMainChapterProgressItem, PinballLevelRecordData> progressLayout3 = this.ProgressLayout;
				if (progressLayout3 != null)
				{
					progressLayout3.SetActive(true);
				}
			}
			UUIText text = base.GetText(6);
			text.SetText(newText, true);
			text.outlineColor = FColor.FromHex(pinballChapterConfigById.Value.OutlineColor);
			UUIEffectOutline extraEffectOutline = this.ExtraEffectOutline;
			if (extraEffectOutline != null)
			{
				extraEffectOutline.SetOutlineColor(FColor.FromHex(pinballChapterConfigById.Value.ExOutlineColor));
			}
			this.ChapterData = data;
			this.LevelDataList = list;
		}

		// Token: 0x0603FE2E RID: 261678 RVA: 0x00F74BF0 File Offset: 0x00F72DF0
		public void SetProgressActive(bool isActive)
		{
			GenericLayout<PinballMainChapterProgressItem, PinballLevelRecordData> progressLayout = this.ProgressLayout;
			if (progressLayout == null)
			{
				return;
			}
			progressLayout.SetActive(isActive);
		}

		// Token: 0x0603FE2F RID: 261679 RVA: 0x00F74C03 File Offset: 0x00F72E03
		public void SetRedDotVisible(bool isVisible)
		{
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isVisible);
		}

		// Token: 0x0603FE30 RID: 261680 RVA: 0x00F74C18 File Offset: 0x00F72E18
		public void SetGray(bool isSetGray)
		{
			UUITexture texture = base.GetTexture(2);
			UUITexture texture2 = base.GetTexture(3);
			UUITexture texture3 = base.GetTexture(4);
			if (texture != null)
			{
				texture.SetIsGray(isSetGray);
			}
			if (texture2 != null)
			{
				texture2.SetIsGray(isSetGray);
			}
			if (texture3 != null)
			{
				texture3.SetIsGray(isSetGray);
			}
			base.GetItem(5).SetUIActive(isSetGray);
		}

		// Token: 0x0603FE31 RID: 261681 RVA: 0x00F74C6C File Offset: 0x00F72E6C
		public UniTask PlayUnlockTweenAsync()
		{
			PinballMainChapterItem.<PlayUnlockTweenAsync>d__18 <PlayUnlockTweenAsync>d__;
			<PlayUnlockTweenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockTweenAsync>d__.<>4__this = this;
			<PlayUnlockTweenAsync>d__.<>1__state = -1;
			<PlayUnlockTweenAsync>d__.<>t__builder.Start<PinballMainChapterItem.<PlayUnlockTweenAsync>d__18>(ref <PlayUnlockTweenAsync>d__);
			return <PlayUnlockTweenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FE32 RID: 261682 RVA: 0x00F74CAF File Offset: 0x00F72EAF
		private PinballMainChapterProgressItem InitProgressItem()
		{
			return new PinballMainChapterProgressItem();
		}

		// Token: 0x0603FE33 RID: 261683 RVA: 0x00F74CB8 File Offset: 0x00F72EB8
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
			Action<PinballChapterData, List<PinballLevelRecordData>> onClickChapterBack = this.OnClickChapterBack;
			if (onClickChapterBack == null)
			{
				return;
			}
			onClickChapterBack(this.ChapterData, this.LevelDataList);
		}

		// Token: 0x0603FE34 RID: 261684 RVA: 0x00F74D90 File Offset: 0x00F72F90
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

		// Token: 0x04021539 RID: 136505
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Action<PinballChapterData, List<PinballLevelRecordData>> OnClickChapterBack;

		// Token: 0x0402153A RID: 136506
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<string, string, int> OnPointerEnterChapterBack;

		// Token: 0x0402153B RID: 136507
		[Nullable(2)]
		private PinballChapterData ChapterData;

		// Token: 0x0402153C RID: 136508
		private List<PinballLevelRecordData> LevelDataList = new List<PinballLevelRecordData>();

		// Token: 0x0402153D RID: 136509
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0402153E RID: 136510
		[Nullable(2)]
		private UUIEffectOutline ExtraEffectOutline;

		// Token: 0x0402153F RID: 136511
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PinballMainChapterProgressItem, PinballLevelRecordData> ProgressLayout;

		// Token: 0x0200C52B RID: 50475
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B825 RID: 243749
			BtnChapter,
			// Token: 0x0403B826 RID: 243750
			BgIcon,
			// Token: 0x0403B827 RID: 243751
			TexBg,
			// Token: 0x0403B828 RID: 243752
			TexDecoration,
			// Token: 0x0403B829 RID: 243753
			TexArtName,
			// Token: 0x0403B82A RID: 243754
			LockItem,
			// Token: 0x0403B82B RID: 243755
			TxtName,
			// Token: 0x0403B82C RID: 243756
			ProgressLayout,
			// Token: 0x0403B82D RID: 243757
			ProgressItem,
			// Token: 0x0403B82E RID: 243758
			RedDotItem
		}
	}
}
