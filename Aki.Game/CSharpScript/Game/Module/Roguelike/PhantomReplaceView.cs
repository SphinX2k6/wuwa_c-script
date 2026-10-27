using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DEC RID: 19948
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomReplaceView : PhantomSelectView
	{
		// Token: 0x060337A5 RID: 210853 RVA: 0x00C073DC File Offset: 0x00C055DC
		public PhantomReplaceView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060337A6 RID: 210854 RVA: 0x00C073E8 File Offset: 0x00C055E8
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

		// Token: 0x060337A7 RID: 210855 RVA: 0x00C07455 File Offset: 0x00C05655
		protected void GiveUpBtn()
		{
			RoguelikeController.Instance.RoguelikeGiveUpGainRequest(this.RoguelikeChooseData.Index).Forget();
		}

		// Token: 0x060337A8 RID: 210856 RVA: 0x00C07471 File Offset: 0x00C05671
		protected override void OnStart()
		{
			base.OnStart();
			this.IsShowChooseTips = true;
		}

		// Token: 0x060337A9 RID: 210857 RVA: 0x00C07480 File Offset: 0x00C05680
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

		// Token: 0x060337AA RID: 210858 RVA: 0x00C0753A File Offset: 0x00C0573A
		protected override void RefreshBtnEnableClick()
		{
		}

		// Token: 0x060337AB RID: 210859 RVA: 0x00C0753C File Offset: 0x00C0573C
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
