using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Action.Fb;
using Aki.UniverseEditor.Interface.Fbs.Action;
using CSharpScript.Game.Common;
using Google.FlatBuffers;
using UnrealEngine;

namespace CSharpScript.Game.Module.MusicalInstrument
{
	// Token: 0x0200434C RID: 17228
	[NullableContext(1)]
	[Nullable(0)]
	public class GuqinSubModel : MusicalInstrumentSubModel
	{
		// Token: 0x0602B83D RID: 178237 RVA: 0x00C3A678 File Offset: 0x00C38878
		public override Aki.TDConfigMgr.Action.EInstrumentType GetType()
		{
			return Aki.TDConfigMgr.Action.EInstrumentType.ChineseZither;
		}

		// Token: 0x0602B83E RID: 178238 RVA: 0x00C3A67C File Offset: 0x00C3887C
		public override void OnRegister()
		{
			Aki.TDConfigMgr.Action.IInstrumentKeyConfigs instrumentKeyConfigs = this.KeyConfigsFbLru.Get(800001);
			if (instrumentKeyConfigs == null)
			{
				global::Log.Instance.Error(ELogModule.MusicalInstrument, ELogAuthor.CB, "古琴玩法:读取古琴按键配置FB数据失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			Aki.TDConfigMgr.Action.IInstrumentKeyConfigs instrumentKeyConfigs2 = instrumentKeyConfigs;
			List<Aki.TDConfigMgr.Action.IInstrumentKeyAttribute> grids = instrumentKeyConfigs2.Grids;
			Aki.TDConfigMgr.Action.IInstrumentBoardSize boardSize = instrumentKeyConfigs2.BoardSize;
			for (int i = 0; i < boardSize.Y; i++)
			{
				List<GuqinKeyConfig> list = new List<GuqinKeyConfig>();
				for (int j = 0; j < boardSize.X; j++)
				{
					Aki.TDConfigMgr.Action.IInstrumentKeyAttribute instrumentKeyAttribute = grids[i * boardSize.X + j];
					list.Add(new GuqinKeyConfig
					{
						FundamentalToneAudioEvent = AudioSystem.Instance.parseAudioEventPath(instrumentKeyAttribute.FundamentalToneAssetPath),
						OverToneAudioEvent = AudioSystem.Instance.parseAudioEventPath(instrumentKeyAttribute.OverToneAssetPath),
						KeyIconPath = instrumentKeyAttribute.TextureAssetPath
					});
				}
				this.Configs.Add(list);
			}
		}

		// Token: 0x0602B83F RID: 178239 RVA: 0x00C3A770 File Offset: 0x00C38970
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

		// Token: 0x0602B840 RID: 178240 RVA: 0x00C3A81B File Offset: 0x00C38A1B
		public override void OnClear()
		{
			this.Configs.Clear();
		}

		// Token: 0x04017810 RID: 96272
		private const int GUQIN_CONFIG_ID = 800001;

		// Token: 0x04017811 RID: 96273
		private const int GUQIN_KEY_CONFIGS_FB_LRU_CAPACITY = 50;

		// Token: 0x04017812 RID: 96274
		private readonly List<List<GuqinKeyConfig>> Configs = new List<List<GuqinKeyConfig>>();

		// Token: 0x04017813 RID: 96275
		private readonly CacheLru<int, Aki.TDConfigMgr.Action.IInstrumentKeyConfigs> KeyConfigsFbLru = new CacheLru<int, Aki.TDConfigMgr.Action.IInstrumentKeyConfigs>(50, delegate(int configId)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(57, 2);
			defaultInterpolatedStringHandler.AppendFormatted(UBlueprintPathsLibrary.ProjectContentDir());
			defaultInterpolatedStringHandler.AppendLiteral("Aki/Config/UniverseEditorConfig/MusicalInstruments/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(configId);
			defaultInterpolatedStringHandler.AppendLiteral(".bytes");
			ByteBuffer byteBuffer = FbFileLoader.LoadBytes(defaultInterpolatedStringHandler.ToStringAndClear());
			if (byteBuffer == null)
			{
				return null;
			}
			return Aki.TDConfigMgr.Action.IInstrumentKeyConfigs.Create(Aki.TDConfigMgr.Action.Fb.IInstrumentKeyConfigs.Create(Aki.UniverseEditor.Interface.Fbs.Action.IInstrumentConfig.GetRootAsIInstrumentConfig(byteBuffer).KeyConfigs));
		});
	}
}
