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
	// Token: 0x020053B2 RID: 21426
	public class MoraleLvInfoItem : UiPanelBase
	{
		// Token: 0x06036C0F RID: 224271 RVA: 0x00CF5878 File Offset: 0x00CF3A78
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

		// Token: 0x06036C10 RID: 224272 RVA: 0x00CF58C4 File Offset: 0x00CF3AC4
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

		// Token: 0x06036C11 RID: 224273 RVA: 0x00CF5970 File Offset: 0x00CF3B70
		protected override UniTask OnBeforeStartAsync()
		{
			MoraleLvInfoItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<MoraleLvInfoItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036C12 RID: 224274 RVA: 0x00CF59B3 File Offset: 0x00CF3BB3
		private void OnBtnHelp()
		{
			HelpController.Instance.OpenHelpById(328);
		}

		// Token: 0x06036C13 RID: 224275 RVA: 0x00CF59C4 File Offset: 0x00CF3BC4
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

		// Token: 0x0200B64E RID: 46670
		private class EChildType
		{
			// Token: 0x040373AD RID: 226221
			public const int ArtTextMoraleLv = 0;

			// Token: 0x040373AE RID: 226222
			public const int TxtMoraleLvExpProgress = 1;

			// Token: 0x040373AF RID: 226223
			public const int SpriteMoraleLvExpProgress = 2;

			// Token: 0x040373B0 RID: 226224
			public const int BtnHelp = 3;

			// Token: 0x040373B1 RID: 226225
			public const int TxtTitle = 4;
		}
	}
}
