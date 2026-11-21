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
	// Token: 0x020052AF RID: 21167
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballMainChapterItem : UiPanelBase, IPinballChapterItem
	{
		// Token: 0x06034AE8 RID: 215784 RVA: 0x00EBB690 File Offset: 0x00EB9890
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

		// Token: 0x06034AE9 RID: 215785 RVA: 0x00EBB820 File Offset: 0x00EB9A20
		protected override void OnStart()
		{
			this.ProgressLayout = new GenericLayout<PinballMainChapterProgressItem, PinballLevelRecordData>(base.GetHorizontalLayout(7), new Func<PinballMainChapterProgressItem>(this.InitProgressItem), base.GetItem(8).GetOwner() as AUIBaseActor, false, true);
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
			UUIEffectOutline extraEffectOutline = base.GetText(6).GetOwner().GetComponentByClass(UUIEffectOutline.StaticClass()) as UUIEffectOutline;
			this.ExtraEffectOutline = extraEffectOutline;
			base.GetButton(0).OnPointEnterCallBack.Bind(new Action(this.OnPointerEnter));
		}

		// Token: 0x06034AEA RID: 215786 RVA: 0x00EBB8B4 File Offset: 0x00EB9AB4
		protected override void OnBeforeDestroy()
		{
			base.GetButton(0).OnPointEnterCallBack.Unbind();
		}

		// Token: 0x06034AEB RID: 215787 RVA: 0x00EBB8C8 File Offset: 0x00EB9AC8
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

		// Token: 0x06034AEC RID: 215788 RVA: 0x00EBB8F8 File Offset: 0x00EB9AF8
		private EPinballChapterLevelLockStatus GetChapterLockStatus(int chapterId)
		{
			return PinballModel.Instance.ActivityData.GetChapterLockStatus(chapterId);
		}

		// Token: 0x06034AED RID: 215789 RVA: 0x00EBB90A File Offset: 0x00EB9B0A
		void IPinballChapterItem.Refresh(PinballChapterData data)
		{
			this.Refresh(data, false);
		}

		// Token: 0x06034AEE RID: 215790 RVA: 0x00EBB914 File Offset: 0x00EB9B14
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

		// Token: 0x06034AEF RID: 215791 RVA: 0x00EBBB4C File Offset: 0x00EB9D4C
		public void SetProgressActive(bool isActive)
		{
			GenericLayout<PinballMainChapterProgressItem, PinballLevelRecordData> progressLayout = this.ProgressLayout;
			if (progressLayout == null)
			{
				return;
			}
			progressLayout.SetActive(isActive);
		}

		// Token: 0x06034AF0 RID: 215792 RVA: 0x00EBBB5F File Offset: 0x00EB9D5F
		public void SetRedDotVisible(bool isVisible)
		{
			UUIItem item = base.GetItem(9);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(isVisible);
		}

		// Token: 0x06034AF1 RID: 215793 RVA: 0x00EBBB74 File Offset: 0x00EB9D74
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

		// Token: 0x06034AF2 RID: 215794 RVA: 0x00EBBBC8 File Offset: 0x00EB9DC8
		public UniTask PlayUnlockTweenAsync()
		{
			PinballMainChapterItem.<PlayUnlockTweenAsync>d__18 <PlayUnlockTweenAsync>d__;
			<PlayUnlockTweenAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayUnlockTweenAsync>d__.<>4__this = this;
			<PlayUnlockTweenAsync>d__.<>1__state = -1;
			<PlayUnlockTweenAsync>d__.<>t__builder.Start<PinballMainChapterItem.<PlayUnlockTweenAsync>d__18>(ref <PlayUnlockTweenAsync>d__);
			return <PlayUnlockTweenAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034AF3 RID: 215795 RVA: 0x00EBBC0B File Offset: 0x00EB9E0B
		private PinballMainChapterProgressItem InitProgressItem()
		{
			return new PinballMainChapterProgressItem();
		}

		// Token: 0x06034AF4 RID: 215796 RVA: 0x00EBBC14 File Offset: 0x00EB9E14
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

		// Token: 0x06034AF5 RID: 215797 RVA: 0x00EBBCEC File Offset: 0x00EB9EEC
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

		// Token: 0x0401BE68 RID: 114280
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		public Action<PinballChapterData, List<PinballLevelRecordData>> OnClickChapterBack;

		// Token: 0x0401BE69 RID: 114281
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public Action<string, string, int> OnPointerEnterChapterBack;

		// Token: 0x0401BE6A RID: 114282
		[Nullable(2)]
		private PinballChapterData ChapterData;

		// Token: 0x0401BE6B RID: 114283
		private List<PinballLevelRecordData> LevelDataList = new List<PinballLevelRecordData>();

		// Token: 0x0401BE6C RID: 114284
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401BE6D RID: 114285
		[Nullable(2)]
		private UUIEffectOutline ExtraEffectOutline;

		// Token: 0x0401BE6E RID: 114286
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<PinballMainChapterProgressItem, PinballLevelRecordData> ProgressLayout;

		// Token: 0x0200AF12 RID: 44818
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036187 RID: 221575
			BtnChapter,
			// Token: 0x04036188 RID: 221576
			BgIcon,
			// Token: 0x04036189 RID: 221577
			TexBg,
			// Token: 0x0403618A RID: 221578
			TexDecoration,
			// Token: 0x0403618B RID: 221579
			TexArtName,
			// Token: 0x0403618C RID: 221580
			LockItem,
			// Token: 0x0403618D RID: 221581
			TxtName,
			// Token: 0x0403618E RID: 221582
			ProgressLayout,
			// Token: 0x0403618F RID: 221583
			ProgressItem,
			// Token: 0x04036190 RID: 221584
			RedDotItem
		}
	}
}
