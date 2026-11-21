using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.FishingQte
{
	// Token: 0x02005FC0 RID: 24512
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingGetItem : SliderItem
	{
		// Token: 0x0603AE6C RID: 241260 RVA: 0x010A4CAC File Offset: 0x010A2EAC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603AE6D RID: 241261 RVA: 0x010A4D9C File Offset: 0x010A2F9C
		protected override UniTask OnBeforeStartAsync()
		{
			FishingGetItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingGetItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE6E RID: 241262 RVA: 0x010A4DDF File Offset: 0x010A2FDF
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
		}

		// Token: 0x0603AE6F RID: 241263 RVA: 0x010A4E0A File Offset: 0x010A300A
		protected override void OnBeforeDestroy()
		{
			if (this.LevelSequencePlayer != null)
			{
				this.LevelSequencePlayer.Clear();
				this.LevelSequencePlayer = null;
			}
		}

		// Token: 0x0603AE70 RID: 241264 RVA: 0x010A4E26 File Offset: 0x010A3026
		[NullableContext(1)]
		private void FinishSequenceEvent(string sequenceName)
		{
			if (sequenceName == "Start")
			{
				base.FinishPlayStart();
				return;
			}
			if (sequenceName == "Close")
			{
				base.FinishPlayEnd();
			}
		}

		// Token: 0x0603AE71 RID: 241265 RVA: 0x010A4E50 File Offset: 0x010A3050
		protected override void PlayStart()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x0603AE72 RID: 241266 RVA: 0x010A4E78 File Offset: 0x010A3078
		public override void PlayEnd()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x0603AE73 RID: 241267 RVA: 0x010A4EA0 File Offset: 0x010A30A0
		protected override void OnActiveStatusChange(bool value)
		{
		}

		// Token: 0x0603AE74 RID: 241268 RVA: 0x010A4EA4 File Offset: 0x010A30A4
		public override UniTask AsyncLoadUiResource()
		{
			FishingGetItem.<AsyncLoadUiResource>d__13 <AsyncLoadUiResource>d__;
			<AsyncLoadUiResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AsyncLoadUiResource>d__.<>4__this = this;
			<AsyncLoadUiResource>d__.<>1__state = -1;
			<AsyncLoadUiResource>d__.<>t__builder.Start<FishingGetItem.<AsyncLoadUiResource>d__13>(ref <AsyncLoadUiResource>d__);
			return <AsyncLoadUiResource>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE75 RID: 241269 RVA: 0x010A4EE8 File Offset: 0x010A30E8
		[NullableContext(1)]
		public UniTask Refresh(DockyardItemBlockOriginalData data)
		{
			FishingGetItem.<Refresh>d__14 <Refresh>d__;
			<Refresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Refresh>d__.<>4__this = this;
			<Refresh>d__.data = data;
			<Refresh>d__.<>1__state = -1;
			<Refresh>d__.<>t__builder.Start<FishingGetItem.<Refresh>d__14>(ref <Refresh>d__);
			return <Refresh>d__.<>t__builder.Task;
		}

		// Token: 0x0603AE76 RID: 241270 RVA: 0x010A4F34 File Offset: 0x010A3134
		private void RefreshQuality(int qualityId)
		{
			FishingQuality fishingQualityConfig = FishingConfig.Instance.GetFishingQualityConfig(qualityId);
			UUISprite bg = base.GetSprite(0);
			bg.SetUIActive(false);
			this.SetSpriteByPath(fishingQualityConfig.TexBg, bg, false, null, delegate(bool success)
			{
				bg.SetUIActive(true);
			});
			FColor color = FColor.FromHex(fishingQualityConfig.TxtColor);
			base.GetText(2).SetColor(color);
			bool flag = qualityId == 5;
			base.GetItem(4).SetUIActive(flag);
			base.GetItem(5).SetUIActive(!flag);
		}

		// Token: 0x0401EF71 RID: 126833
		private const int SPECIAL_QUALITY_ID = 5;

		// Token: 0x0401EF72 RID: 126834
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401EF73 RID: 126835
		protected DockyardItemBlockOriginalData Data;

		// Token: 0x0401EF74 RID: 126836
		protected FishingGetTagItem TagItem;

		// Token: 0x0200B8E1 RID: 47329
		[NullableContext(0)]
		private class EItemComponents
		{
			// Token: 0x040390F6 RID: 233718
			public const int SpriteBg = 0;

			// Token: 0x040390F7 RID: 233719
			public const int TexIcon = 1;

			// Token: 0x040390F8 RID: 233720
			public const int TxtName = 2;

			// Token: 0x040390F9 RID: 233721
			public const int TagItem = 3;

			// Token: 0x040390FA RID: 233722
			public const int PanelQuality1 = 4;

			// Token: 0x040390FB RID: 233723
			public const int PanelQuality2 = 5;
		}
	}
}
