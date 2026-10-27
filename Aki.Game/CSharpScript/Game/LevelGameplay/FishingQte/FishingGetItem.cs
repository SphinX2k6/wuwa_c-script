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
	// Token: 0x02006E3F RID: 28223
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingGetItem : SliderItem
	{
		// Token: 0x06044CDF RID: 281823 RVA: 0x010FA72C File Offset: 0x010F892C
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

		// Token: 0x06044CE0 RID: 281824 RVA: 0x010FA81C File Offset: 0x010F8A1C
		protected override UniTask OnBeforeStartAsync()
		{
			FishingGetItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingGetItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06044CE1 RID: 281825 RVA: 0x010FA85F File Offset: 0x010F8A5F
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.LevelSequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.FinishSequenceEvent), false);
		}

		// Token: 0x06044CE2 RID: 281826 RVA: 0x010FA88A File Offset: 0x010F8A8A
		protected override void OnBeforeDestroy()
		{
			if (this.LevelSequencePlayer != null)
			{
				this.LevelSequencePlayer.Clear();
				this.LevelSequencePlayer = null;
			}
		}

		// Token: 0x06044CE3 RID: 281827 RVA: 0x010FA8A6 File Offset: 0x010F8AA6
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

		// Token: 0x06044CE4 RID: 281828 RVA: 0x010FA8D0 File Offset: 0x010F8AD0
		protected override void PlayStart()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
		}

		// Token: 0x06044CE5 RID: 281829 RVA: 0x010FA8F8 File Offset: 0x010F8AF8
		public override void PlayEnd()
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Close", false, null, false);
		}

		// Token: 0x06044CE6 RID: 281830 RVA: 0x010FA920 File Offset: 0x010F8B20
		protected override void OnActiveStatusChange(bool value)
		{
		}

		// Token: 0x06044CE7 RID: 281831 RVA: 0x010FA924 File Offset: 0x010F8B24
		public override UniTask AsyncLoadUiResource()
		{
			FishingGetItem.<AsyncLoadUiResource>d__13 <AsyncLoadUiResource>d__;
			<AsyncLoadUiResource>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<AsyncLoadUiResource>d__.<>4__this = this;
			<AsyncLoadUiResource>d__.<>1__state = -1;
			<AsyncLoadUiResource>d__.<>t__builder.Start<FishingGetItem.<AsyncLoadUiResource>d__13>(ref <AsyncLoadUiResource>d__);
			return <AsyncLoadUiResource>d__.<>t__builder.Task;
		}

		// Token: 0x06044CE8 RID: 281832 RVA: 0x010FA968 File Offset: 0x010F8B68
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

		// Token: 0x06044CE9 RID: 281833 RVA: 0x010FA9B4 File Offset: 0x010F8BB4
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

		// Token: 0x04023CBC RID: 146620
		private const int SPECIAL_QUALITY_ID = 5;

		// Token: 0x04023CBD RID: 146621
		protected LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x04023CBE RID: 146622
		protected DockyardItemBlockOriginalData Data;

		// Token: 0x04023CBF RID: 146623
		protected FishingGetTagItem TagItem;

		// Token: 0x0200CCF1 RID: 52465
		[NullableContext(0)]
		private class EItemComponents
		{
			// Token: 0x0403DCD4 RID: 253140
			public const int SpriteBg = 0;

			// Token: 0x0403DCD5 RID: 253141
			public const int TexIcon = 1;

			// Token: 0x0403DCD6 RID: 253142
			public const int TxtName = 2;

			// Token: 0x0403DCD7 RID: 253143
			public const int TagItem = 3;

			// Token: 0x0403DCD8 RID: 253144
			public const int PanelQuality1 = 4;

			// Token: 0x0403DCD9 RID: 253145
			public const int PanelQuality2 = 5;
		}
	}
}
