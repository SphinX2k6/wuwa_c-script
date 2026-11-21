using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Battle;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02004395 RID: 17301
	public class MoraleLvInfoItem : UiPanelBase
	{
		// Token: 0x0602BB55 RID: 179029 RVA: 0x00C44920 File Offset: 0x00C42B20
		[NullableContext(1)]
		public UniTask Init(UUIItem item)
		{
			MoraleLvInfoItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MoraleLvInfoItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB56 RID: 179030 RVA: 0x00C4496C File Offset: 0x00C42B6C
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIArtText)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnBtnHelp))
			};
		}

		// Token: 0x0602BB57 RID: 179031 RVA: 0x00C44A18 File Offset: 0x00C42C18
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleLvInfoItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleLvInfoItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602BB58 RID: 179032 RVA: 0x00C44A5B File Offset: 0x00C42C5B
		private void OnBtnHelp()
		{
			HelpController.Instance.OpenHelpById(328);
		}

		// Token: 0x0602BB59 RID: 179033 RVA: 0x00C44A6C File Offset: 0x00C42C6C
		public void UpdateData()
		{
			MoraleBattleModel instance = MoraleBattleModel.Instance;
			int moraleLevel = instance.GetMoraleLevel();
			base.GetArtText(0).SetText(moraleLevel.ToString());
			int moraleCurrentLevelExp = instance.GetMoraleCurrentLevelExp();
			int moraleLevelUpExp = instance.GetMoraleLevelUpExp(null);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(moraleCurrentLevelExp);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(moraleLevelUpExp);
			string newText = defaultInterpolatedStringHandler.ToStringAndClear();
			UUIText text = base.GetText(1);
			if (text != null)
			{
				text.SetText(newText, true);
			}
			float moraleCurrentExpProgress = instance.GetMoraleCurrentExpProgress();
			UUISprite sprite = base.GetSprite(2);
			if (sprite != null)
			{
				sprite.SetFillAmount(moraleCurrentExpProgress);
			}
			UUIText text2 = base.GetText(4);
			if (text2 == null)
			{
				return;
			}
			text2.ShowTextNew("Morale_title_2");
		}

		// Token: 0x0200A086 RID: 41094
		private class EChildType
		{
			// Token: 0x04031E02 RID: 204290
			public const int ArtTextMoraleLv = 0;

			// Token: 0x04031E03 RID: 204291
			public const int TxtMoraleLvExpProgress = 1;

			// Token: 0x04031E04 RID: 204292
			public const int SpriteMoraleLvExpProgress = 2;

			// Token: 0x04031E05 RID: 204293
			public const int BtnHelp = 3;

			// Token: 0x04031E06 RID: 204294
			public const int TxtTitle = 4;
		}
	}
}
