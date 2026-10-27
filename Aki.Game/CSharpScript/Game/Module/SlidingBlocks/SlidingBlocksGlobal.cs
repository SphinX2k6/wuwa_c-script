using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using AkiClient.Game.Aki.Data.Gameplay.Tetris;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02004B7E RID: 19326
	[NullableContext(2)]
	[Nullable(0)]
	public class SlidingBlocksGlobal : IStaticVariableResetter
	{
		// Token: 0x06032153 RID: 205139 RVA: 0x00BA1293 File Offset: 0x00B9F493
		static SlidingBlocksGlobal()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SlidingBlocksGlobal.CreateStaticDefaultValue), new Action(SlidingBlocksGlobal.ResetStaticDefaultValue));
		}

		// Token: 0x17007C3E RID: 31806
		// (get) Token: 0x06032154 RID: 205140 RVA: 0x00BA12B4 File Offset: 0x00B9F4B4
		public static Bp_Tetris_C Setting
		{
			get
			{
				if (SlidingBlocksGlobal._settingDataAsset != null)
				{
					return SlidingBlocksGlobal._settingDataAsset;
				}
				Log.Instance.Error(ELogModule.SlidingBlocks, ELogAuthor.YSQ, "SettingDataAsset is null", default(ReadOnlySpan<ValueTuple<string, object>>));
				return null;
			}
		}

		// Token: 0x06032155 RID: 205141 RVA: 0x00BA12F0 File Offset: 0x00B9F4F0
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static UniTask<Bp_Tetris_C> LoadSettingData()
		{
			SlidingBlocksGlobal.<LoadSettingData>d__5 <LoadSettingData>d__;
			<LoadSettingData>d__.<>t__builder = AsyncUniTaskMethodBuilder<Bp_Tetris_C>.Create();
			<LoadSettingData>d__.<>1__state = -1;
			<LoadSettingData>d__.<>t__builder.Start<SlidingBlocksGlobal.<LoadSettingData>d__5>(ref <LoadSettingData>d__);
			return <LoadSettingData>d__.<>t__builder.Task;
		}

		// Token: 0x06032156 RID: 205142 RVA: 0x00BA132B File Offset: 0x00B9F52B
		public static void ClearSettingData()
		{
			SlidingBlocksGlobal._settingDataAsset = null;
		}

		// Token: 0x06032157 RID: 205143 RVA: 0x00BA1334 File Offset: 0x00B9F534
		public static string GetMoveTrailEffectPath(ETetrisPlayMode mode)
		{
			string result = null;
			if (SlidingBlocksGlobal.Setting == null)
			{
				return result;
			}
			if (mode > ETetrisPlayMode.Endless)
			{
				if (mode == ETetrisPlayMode.MainLine)
				{
					result = SlidingBlocksGlobal.Setting.MainLineModeTetrominoMoveTrailEffect.GetAssetPathName().ToString();
				}
			}
			else
			{
				result = SlidingBlocksGlobal.Setting.NormalModeTetrominoMoveTrailEffect.GetAssetPathName().ToString();
			}
			return result;
		}

		// Token: 0x06032158 RID: 205144 RVA: 0x00BA1394 File Offset: 0x00B9F594
		public static string GetLineClearEffectPath(ETetrisPlayMode mode)
		{
			string result = null;
			if (SlidingBlocksGlobal.Setting == null)
			{
				return result;
			}
			if (mode > ETetrisPlayMode.Endless)
			{
				if (mode == ETetrisPlayMode.MainLine)
				{
					result = SlidingBlocksGlobal.Setting.MainLineModeLineClearEffect.GetAssetPathName().ToString();
				}
			}
			else
			{
				result = SlidingBlocksGlobal.Setting.NormalModeLineClearEffect.GetAssetPathName().ToString();
			}
			return result;
		}

		// Token: 0x06032159 RID: 205145 RVA: 0x00BA13F4 File Offset: 0x00B9F5F4
		public static string GetTetrominoLockEffectPath(ETetrisPlayMode mode)
		{
			string result = null;
			if (SlidingBlocksGlobal.Setting == null)
			{
				return result;
			}
			if (mode > ETetrisPlayMode.Endless)
			{
				if (mode == ETetrisPlayMode.MainLine)
				{
					result = SlidingBlocksGlobal.Setting.MainLineModeTetrominoLockEffect.GetAssetPathName().ToString();
				}
			}
			else
			{
				result = SlidingBlocksGlobal.Setting.NormalModeTetrominoLockEffect.GetAssetPathName().ToString();
			}
			return result;
		}

		// Token: 0x0603215A RID: 205146 RVA: 0x00BA1454 File Offset: 0x00B9F654
		public static string GetTetrominoSpawnEffectPath(ETetrisPlayMode mode)
		{
			string result = null;
			if (SlidingBlocksGlobal.Setting == null)
			{
				return result;
			}
			if (mode > ETetrisPlayMode.Endless)
			{
				if (mode == ETetrisPlayMode.MainLine)
				{
					result = SlidingBlocksGlobal.Setting.MainLineModeTetrominoSpawnEffect.GetAssetPathName().ToString();
				}
			}
			else
			{
				result = SlidingBlocksGlobal.Setting.NormalModeTetrominoSpawnEffect.GetAssetPathName().ToString();
			}
			return result;
		}

		// Token: 0x0603215B RID: 205147 RVA: 0x00BA14B4 File Offset: 0x00B9F6B4
		public static string GetPlayerDeadEffectPath(ETetrisPlayMode mode)
		{
			string result = null;
			if (SlidingBlocksGlobal.Setting == null)
			{
				return result;
			}
			if (mode <= ETetrisPlayMode.MainLine)
			{
				result = SlidingBlocksGlobal.Setting.NormalModePlayerDeadEffect.GetAssetPathName().ToString();
			}
			return result;
		}

		// Token: 0x0603215C RID: 205148 RVA: 0x00BA14F0 File Offset: 0x00B9F6F0
		public static string GetPlayerOutlineEffectPath(ETetrisPlayMode mode)
		{
			string result = null;
			if (SlidingBlocksGlobal.Setting == null)
			{
				return result;
			}
			if (mode > ETetrisPlayMode.Endless)
			{
				if (mode == ETetrisPlayMode.MainLine)
				{
					result = SlidingBlocksGlobal.Setting.MainLineModePlayerOutlineEffect.GetAssetPathName().ToString();
				}
			}
			else
			{
				result = SlidingBlocksGlobal.Setting.NormalModePlayerOutlineEffect.GetAssetPathName().ToString();
			}
			return result;
		}

		// Token: 0x0603215D RID: 205149 RVA: 0x00BA1550 File Offset: 0x00B9F750
		public static string GetDeadFailEffectPath(ETetrisPlayMode mode)
		{
			string result = null;
			if (SlidingBlocksGlobal.Setting == null)
			{
				return result;
			}
			if (mode > ETetrisPlayMode.Endless)
			{
				if (mode == ETetrisPlayMode.MainLine)
				{
					result = SlidingBlocksGlobal.Setting.MainLineModeFailEffect.GetAssetPathName().ToString();
				}
			}
			else
			{
				result = SlidingBlocksGlobal.Setting.NormalModeFailEffect.GetAssetPathName().ToString();
			}
			return result;
		}

		// Token: 0x0603215E RID: 205150 RVA: 0x00BA15B0 File Offset: 0x00B9F7B0
		public static string GetMinoDestroyEffectPath(ETetrisPlayMode mode)
		{
			string result = null;
			if (SlidingBlocksGlobal.Setting == null)
			{
				return result;
			}
			if (mode > ETetrisPlayMode.Endless)
			{
				if (mode == ETetrisPlayMode.MainLine)
				{
					result = SlidingBlocksGlobal.Setting.MainLineModeMinoDestroyEffect.GetAssetPathName().ToString();
				}
			}
			else
			{
				result = SlidingBlocksGlobal.Setting.NormalModeMinoDestroyEffect.GetAssetPathName().ToString();
			}
			return result;
		}

		// Token: 0x0603215F RID: 205151 RVA: 0x00BA160F File Offset: 0x00B9F80F
		public static void CreateStaticDefaultValue()
		{
			SlidingBlocksGlobal._settingDataAsset = null;
		}

		// Token: 0x06032160 RID: 205152 RVA: 0x00BA1617 File Offset: 0x00B9F817
		public static void ResetStaticDefaultValue()
		{
			SlidingBlocksGlobal._settingDataAsset = null;
		}

		// Token: 0x0401AADE RID: 109278
		[Nullable(1)]
		private const string SETTING_DA_PATH = "/Game/Aki/Data/Gameplay/Tetris/DA_TetrisSetting.DA_TetrisSetting";

		// Token: 0x0401AADF RID: 109279
		private static Bp_Tetris_C _settingDataAsset;
	}
}
