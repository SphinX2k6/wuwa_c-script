using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200038E RID: 910
	public class ConfigGachaWeaponTransformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600155A RID: 5466 RVA: 0x000D5DBC File Offset: 0x000D3FBC
		static ConfigGachaWeaponTransformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaWeaponTransformById.CreateStaticDefaultValue), new Action(ConfigGachaWeaponTransformById.ResetStaticDefaultValue));
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x000D5DDC File Offset: 0x000D3FDC
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaWeaponTransformById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaWeaponTransformById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacha.db"),
				new ValueTuple<string, object>("文件", "c.抽卡.xlsx"),
				new ValueTuple<string, object>("表名", "GachaWeaponTransform"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaWeaponTransform` where Id=?")
			});
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x000D5E5B File Offset: 0x000D405B
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaWeaponTransformById.LogPair = null;
			ConfigGachaWeaponTransformById.HandleId = 0;
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x000D5E69 File Offset: 0x000D4069
		public static void Init()
		{
			ConfigGachaWeaponTransformById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaWeaponTransformById.HandleId, "db_gacha.db", "select BinData from `GachaWeaponTransform` where Id=?");
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x000D5E84 File Offset: 0x000D4084
		public static GachaWeaponTransform? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaWeaponTransformById.HandleId, ConfigGachaWeaponTransformById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaWeaponTransformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaWeaponTransform?(GachaWeaponTransform.GetRootAsGachaWeaponTransform(configBuffer));
				}
			}
			ConfigGachaWeaponTransformById.LogPair.Clear();
			ConfigGachaWeaponTransformById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaWeaponTransformById.HandleId, 1, p0Id, ConfigGachaWeaponTransformById.LogPair) || ConfigCommon.Step(ConfigGachaWeaponTransformById.HandleId, true, ConfigGachaWeaponTransformById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaWeaponTransformById.HandleId, ConfigGachaWeaponTransformById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaWeaponTransformById.HandleId, 0, ConfigGachaWeaponTransformById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaWeaponTransformById.HandleId, ConfigGachaWeaponTransformById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaWeaponTransform rootAsGachaWeaponTransform = GachaWeaponTransform.GetRootAsGachaWeaponTransform(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaWeaponTransformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaWeaponTransformById.HandleId, ConfigGachaWeaponTransformById.LogPair);
			return new GachaWeaponTransform?(rootAsGachaWeaponTransform);
		}

		// Token: 0x040018C6 RID: 6342
		private const string DB = "db_gacha.db";

		// Token: 0x040018C7 RID: 6343
		private const string FILE = "c.抽卡.xlsx";

		// Token: 0x040018C8 RID: 6344
		private const string TABLE = "GachaWeaponTransform";

		// Token: 0x040018C9 RID: 6345
		private const string COMMAND = "select BinData from `GachaWeaponTransform` where Id=?";

		// Token: 0x040018CA RID: 6346
		private const string KEY_PREFIX = "GachaWeaponTransformById";

		// Token: 0x040018CB RID: 6347
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040018CC RID: 6348
		private static int HandleId;
	}
}
