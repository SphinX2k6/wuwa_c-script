using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest;
using AkiClient.Game.Aki.Data.Gameplay.Tetris;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SlidingBlocks
{
	// Token: 0x02003B28 RID: 15144
	[NullableContext(2)]
	[Nullable(0)]
	public class SlidingBlocksGlobal : IStaticVariableResetter
	{
		// Token: 0x06026EE4 RID: 159460 RVA: 0x00AE5423 File Offset: 0x00AE3623
		static SlidingBlocksGlobal()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SlidingBlocksGlobal.CreateStaticDefaultValue), new Action(SlidingBlocksGlobal.ResetStaticDefaultValue));
		}

		// Token: 0x17004FE8 RID: 20456
		// (get) Token: 0x06026EE5 RID: 159461 RVA: 0x00AE5444 File Offset: 0x00AE3644
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

		// Token: 0x06026EE6 RID: 159462 RVA: 0x00AE5480 File Offset: 0x00AE3680
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

		// Token: 0x06026EE7 RID: 159463 RVA: 0x00AE54BB File Offset: 0x00AE36BB
		public static void ClearSettingData()
		{
			SlidingBlocksGlobal._settingDataAsset = null;
		}

		// Token: 0x06026EE8 RID: 159464 RVA: 0x00AE54C4 File Offset: 0x00AE36C4
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

		// Token: 0x06026EE9 RID: 159465 RVA: 0x00AE5524 File Offset: 0x00AE3724
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

		// Token: 0x06026EEA RID: 159466 RVA: 0x00AE5584 File Offset: 0x00AE3784
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

		// Token: 0x06026EEB RID: 159467 RVA: 0x00AE55E4 File Offset: 0x00AE37E4
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

		// Token: 0x06026EEC RID: 159468 RVA: 0x00AE5644 File Offset: 0x00AE3844
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

		// Token: 0x06026EED RID: 159469 RVA: 0x00AE5680 File Offset: 0x00AE3880
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

		// Token: 0x06026EEE RID: 159470 RVA: 0x00AE56E0 File Offset: 0x00AE38E0
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

		// Token: 0x06026EEF RID: 159471 RVA: 0x00AE5740 File Offset: 0x00AE3940
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

		// Token: 0x06026EF0 RID: 159472 RVA: 0x00AE579F File Offset: 0x00AE399F
		public static void CreateStaticDefaultValue()
		{
			SlidingBlocksGlobal._settingDataAsset = null;
		}

		// Token: 0x06026EF1 RID: 159473 RVA: 0x00AE57A7 File Offset: 0x00AE39A7
		public static void ResetStaticDefaultValue()
		{
			SlidingBlocksGlobal._settingDataAsset = null;
		}

		// Token: 0x04015432 RID: 87090
		[Nullable(1)]
		private const string SETTING_DA_PATH = "/Game/Aki/Data/Gameplay/Tetris/DA_TetrisSetting.DA_TetrisSetting";

		// Token: 0x04015433 RID: 87091
		private static Bp_Tetris_C _settingDataAsset;
	}
}
