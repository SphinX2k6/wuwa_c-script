using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000386 RID: 902
	public class ConfigGachaRoleDevelopInsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600152A RID: 5418 RVA: 0x000D4B8C File Offset: 0x000D2D8C
		static ConfigGachaRoleDevelopInsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGachaRoleDevelopInsById.CreateStaticDefaultValue), new Action(ConfigGachaRoleDevelopInsById.ResetStaticDefaultValue));
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x000D4BAC File Offset: 0x000D2DAC
		public static void CreateStaticDefaultValue()
		{
			ConfigGachaRoleDevelopInsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGachaRoleDevelopInsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gacharoledevelop.db"),
				new ValueTuple<string, object>("文件", "d.当期卡池角色养成推荐.xlsx"),
				new ValueTuple<string, object>("表名", "GachaRoleDevelopIns"),
				new ValueTuple<string, object>("语句", "select BinData from `GachaRoleDevelopIns` where Id=?")
			});
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x000D4C2B File Offset: 0x000D2E2B
		public static void ResetStaticDefaultValue()
		{
			ConfigGachaRoleDevelopInsById.LogPair = null;
			ConfigGachaRoleDevelopInsById.HandleId = 0;
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x000D4C39 File Offset: 0x000D2E39
		public static void Init()
		{
			ConfigGachaRoleDevelopInsById.HandleId = ConfigCommon.InitDataStatement(ConfigGachaRoleDevelopInsById.HandleId, "db_gacharoledevelop.db", "select BinData from `GachaRoleDevelopIns` where Id=?");
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x000D4C54 File Offset: 0x000D2E54
		public static GachaRoleDevelopIns? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGachaRoleDevelopInsById.HandleId, ConfigGachaRoleDevelopInsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaRoleDevelopInsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GachaRoleDevelopIns?(GachaRoleDevelopIns.GetRootAsGachaRoleDevelopIns(configBuffer));
				}
			}
			ConfigGachaRoleDevelopInsById.LogPair.Clear();
			ConfigGachaRoleDevelopInsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGachaRoleDevelopInsById.HandleId, 1, p0Id, ConfigGachaRoleDevelopInsById.LogPair) || ConfigCommon.Step(ConfigGachaRoleDevelopInsById.HandleId, true, ConfigGachaRoleDevelopInsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGachaRoleDevelopInsById.HandleId, ConfigGachaRoleDevelopInsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGachaRoleDevelopInsById.HandleId, 0, ConfigGachaRoleDevelopInsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGachaRoleDevelopInsById.HandleId, ConfigGachaRoleDevelopInsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GachaRoleDevelopIns rootAsGachaRoleDevelopIns = GachaRoleDevelopIns.GetRootAsGachaRoleDevelopIns(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GachaRoleDevelopInsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGachaRoleDevelopInsById.HandleId, ConfigGachaRoleDevelopInsById.LogPair);
			return new GachaRoleDevelopIns?(rootAsGachaRoleDevelopIns);
		}

		// Token: 0x0400188E RID: 6286
		private const string DB = "db_gacharoledevelop.db";

		// Token: 0x0400188F RID: 6287
		private const string FILE = "d.当期卡池角色养成推荐.xlsx";

		// Token: 0x04001890 RID: 6288
		private const string TABLE = "GachaRoleDevelopIns";

		// Token: 0x04001891 RID: 6289
		private const string COMMAND = "select BinData from `GachaRoleDevelopIns` where Id=?";

		// Token: 0x04001892 RID: 6290
		private const string KEY_PREFIX = "GachaRoleDevelopInsById";

		// Token: 0x04001893 RID: 6291
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001894 RID: 6292
		private static int HandleId;
	}
}
