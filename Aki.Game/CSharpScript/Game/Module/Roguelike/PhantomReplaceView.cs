using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003DB5 RID: 15797
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomReplaceView : PhantomSelectView
	{
		// Token: 0x06028610 RID: 165392 RVA: 0x00B508EC File Offset: 0x00B4EAEC
		public PhantomReplaceView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06028611 RID: 165393 RVA: 0x00B508F8 File Offset: 0x00B4EAF8
		protected override void ConfirmBtn(int _)
		{
			RogueGainEntry rogueGainEntry = (this.RoguelikeChooseData.RogueGainEntryList.Count > 0) ? this.RoguelikeChooseData.RogueGainEntryList[0] : null;
			if (rogueGainEntry == null)
			{
				Log.Instance.Error(ELogModule.Roguelike, ELogAuthor.ZJC, "当前没有选中的声骸", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			RoguelikeModel.Instance.CurrentRogueGainEntry = rogueGainEntry;
			RoguelikeController.Instance.RogueChooseDataResultRequest(EPerkType.Phantom);
		}

		// Token: 0x06028612 RID: 165394 RVA: 0x00B50965 File Offset: 0x00B4EB65
		protected void GiveUpBtn()
		{
			RoguelikeController.Instance.RoguelikeGiveUpGainRequest(this.RoguelikeChooseData.Index).Forget();
		}

		// Token: 0x06028613 RID: 165395 RVA: 0x00B50981 File Offset: 0x00B4EB81
		protected override void OnStart()
		{
			base.OnStart();
			this.IsShowChooseTips = true;
		}

		// Token: 0x06028614 RID: 165396 RVA: 0x00B50990 File Offset: 0x00B4EB90
		protected override void RefreshTopPanel()
		{
			this.TopPanel.RefreshTitle("RoguelikeView_1_Text");
			RogueGainEntry[] rogueGainEntryList = this.GetRogueGainEntryList();
			RoguePokemon? roguePhantomConfig = RoguelikeConfig.Instance.GetRoguePhantomConfig(rogueGainEntryList[0].ConfigId);
			RoguePokemon? roguePhantomConfig2 = RoguelikeConfig.Instance.GetRoguePhantomConfig(rogueGainEntryList[1].ConfigId);
			this.TopPanel.RefreshSelectTipsText("RoguelikeView_2_Text", true, new object[]
			{
				new TableTextArgNew((roguePhantomConfig != null) ? roguePhantomConfig.GetValueOrDefault().PokemonName : null, Array.Empty<object>()),
				new TableTextArgNew((roguePhantomConfig2 != null) ? roguePhantomConfig2.GetValueOrDefault().PokemonName : null, Array.Empty<object>()),
				true
			});
		}

		// Token: 0x06028615 RID: 165397 RVA: 0x00B50A4A File Offset: 0x00B4EC4A
		protected override void RefreshBtnEnableClick()
		{
		}

		// Token: 0x06028616 RID: 165398 RVA: 0x00B50A4C File Offset: 0x00B4EC4C
		private RogueGainEntry[] GetRogueGainEntryList()
		{
			List<RogueGainEntry> list = new List<RogueGainEntry>();
			RogueGainEntry phantomEntry = RoguelikeModel.Instance.RogueInfo.PhantomEntry;
			if (phantomEntry != null)
			{
				list.Add(phantomEntry);
			}
			if (this.RoguelikeChooseData.RogueGainEntryList.Count > 0)
			{
				list.Add(this.RoguelikeChooseData.RogueGainEntryList[0]);
			}
			return list.ToArray();
		}
	}
}
