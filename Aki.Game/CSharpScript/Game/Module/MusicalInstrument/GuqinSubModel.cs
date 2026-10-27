using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x02005369 RID: 21353
	[NullableContext(1)]
	[Nullable(0)]
	public class GuqinSubModel : MusicalInstrumentSubModel
	{
		// Token: 0x060368F7 RID: 223479 RVA: 0x00CEB804 File Offset: 0x00CE9A04
		public override EInstrumentType GetType()
		{
			return EInstrumentType.ChineseZither;
		}

		// Token: 0x060368F8 RID: 223480 RVA: 0x00CEB808 File Offset: 0x00CE9A08
		public override void OnRegister()
		{
			MusicalInstrumentConfig? config = ConfigMusicalInstrumentConfigById.GetConfig(800001, true);
			if (config != null)
			{
				GuqinSubModel.KeyConfigsJson keyConfigsJson = Json.Parse<GuqinSubModel.KeyConfigsJson>(config.GetValueOrDefault().KeyConfigs, null);
				List<GuqinSubModel.GridJson> grids = keyConfigsJson.Grids;
				GuqinSubModel.BoardSizeJson boardSize = keyConfigsJson.BoardSize;
				for (int i = 0; i < boardSize.Y; i++)
				{
					List<GuqinKeyConfig> list = new List<GuqinKeyConfig>();
					for (int j = 0; j < boardSize.X; j++)
					{
						GuqinSubModel.GridJson gridJson = grids[i * boardSize.X + j];
						list.Add(new GuqinKeyConfig
						{
							FundamentalToneAudioEvent = AudioSystem.Instance.parseAudioEventPath(gridJson.FundamentalToneAssetPath),
							OverToneAudioEvent = AudioSystem.Instance.parseAudioEventPath(gridJson.OverToneAssetPath),
							KeyIconPath = gridJson.TextureAssetPath
						});
					}
					this.Configs.Add(list);
				}
				return;
			}
			global::Log.Instance.Error(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:获取古琴配置失败", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x060368F9 RID: 223481 RVA: 0x00CEB910 File Offset: 0x00CE9B10
		[NullableContext(2)]
		public unsafe GuqinKeyConfig GetKeyConfig(int rowIndex, int columnIndex)
		{
			if (rowIndex < 0 || rowIndex >= this.Configs.Count || columnIndex < 0 || columnIndex >= this.Configs[rowIndex].Count)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.MusicalInstrument;
				ELogAuthor author = ELogAuthor.CB;
				string message = "古琴玩法:获取古琴按键配置数组越界";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("rowIndex", rowIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("columnIndex", columnIndex);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			return this.Configs[rowIndex][columnIndex];
		}

		// Token: 0x060368FA RID: 223482 RVA: 0x00CEB9BB File Offset: 0x00CE9BBB
		public override void OnClear()
		{
			this.Configs.Clear();
		}

		// Token: 0x0401CD7C RID: 118140
		private const int GUQIN_CONFIG_ID = 800001;

		// Token: 0x0401CD7D RID: 118141
		private readonly List<List<GuqinKeyConfig>> Configs = new List<List<GuqinKeyConfig>>();

		// Token: 0x0200B5E0 RID: 46560
		[Nullable(0)]
		private class KeyConfigsJson
		{
			// Token: 0x1700A1B0 RID: 41392
			// (get) Token: 0x0604EEEC RID: 323308 RVA: 0x015123FA File Offset: 0x015105FA
			// (set) Token: 0x0604EEED RID: 323309 RVA: 0x01512402 File Offset: 0x01510602
			public List<GuqinSubModel.GridJson> Grids { get; set; } = new List<GuqinSubModel.GridJson>();

			// Token: 0x1700A1B1 RID: 41393
			// (get) Token: 0x0604EEEE RID: 323310 RVA: 0x0151240B File Offset: 0x0151060B
			// (set) Token: 0x0604EEEF RID: 323311 RVA: 0x01512413 File Offset: 0x01510613
			public GuqinSubModel.BoardSizeJson BoardSize { get; set; } = new GuqinSubModel.BoardSizeJson();
		}

		// Token: 0x0200B5E1 RID: 46561
		[Nullable(0)]
		private class GridJson
		{
			// Token: 0x1700A1B2 RID: 41394
			// (get) Token: 0x0604EEF1 RID: 323313 RVA: 0x0151243A File Offset: 0x0151063A
			// (set) Token: 0x0604EEF2 RID: 323314 RVA: 0x01512442 File Offset: 0x01510642
			public string FundamentalToneAssetPath { get; set; } = "";

			// Token: 0x1700A1B3 RID: 41395
			// (get) Token: 0x0604EEF3 RID: 323315 RVA: 0x0151244B File Offset: 0x0151064B
			// (set) Token: 0x0604EEF4 RID: 323316 RVA: 0x01512453 File Offset: 0x01510653
			public string OverToneAssetPath { get; set; } = "";

			// Token: 0x1700A1B4 RID: 41396
			// (get) Token: 0x0604EEF5 RID: 323317 RVA: 0x0151245C File Offset: 0x0151065C
			// (set) Token: 0x0604EEF6 RID: 323318 RVA: 0x01512464 File Offset: 0x01510664
			public string TextureAssetPath { get; set; } = "";
		}

		// Token: 0x0200B5E2 RID: 46562
		[NullableContext(0)]
		private class BoardSizeJson
		{
			// Token: 0x1700A1B5 RID: 41397
			// (get) Token: 0x0604EEF8 RID: 323320 RVA: 0x01512496 File Offset: 0x01510696
			// (set) Token: 0x0604EEF9 RID: 323321 RVA: 0x0151249E File Offset: 0x0151069E
			public int X { get; set; }

			// Token: 0x1700A1B6 RID: 41398
			// (get) Token: 0x0604EEFA RID: 323322 RVA: 0x015124A7 File Offset: 0x015106A7
			// (set) Token: 0x0604EEFB RID: 323323 RVA: 0x015124AF File Offset: 0x015106AF
			public int Y { get; set; }
		}
	}
}
