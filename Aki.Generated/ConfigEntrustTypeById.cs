using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200029A RID: 666
	public class ConfigEntrustTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FA1 RID: 4001 RVA: 0x000B556C File Offset: 0x000B376C
		static ConfigEntrustTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntrustTypeById.CreateStaticDefaultValue), new Action(ConfigEntrustTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x000B558C File Offset: 0x000B378C
		public static void CreateStaticDefaultValue()
		{
			ConfigEntrustTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEntrustTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "EntrustType"),
				new ValueTuple<string, object>("语句", "select BinData from `EntrustType` where Id=?")
			});
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x000B560B File Offset: 0x000B380B
		public static void ResetStaticDefaultValue()
		{
			ConfigEntrustTypeById.LogPair = null;
			ConfigEntrustTypeById.HandleId = 0;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x000B5619 File Offset: 0x000B3819
		public static void Init()
		{
			ConfigEntrustTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigEntrustTypeById.HandleId, "db_moonchasing.db", "select BinData from `EntrustType` where Id=?");
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x000B5634 File Offset: 0x000B3834
		public static EntrustType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEntrustTypeById.HandleId, ConfigEntrustTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EntrustTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new EntrustType?(EntrustType.GetRootAsEntrustType(configBuffer));
				}
			}
			ConfigEntrustTypeById.LogPair.Clear();
			ConfigEntrustTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigEntrustTypeById.HandleId, 1, p0Id, ConfigEntrustTypeById.LogPair) || ConfigCommon.Step(ConfigEntrustTypeById.HandleId, true, ConfigEntrustTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigEntrustTypeById.HandleId, ConfigEntrustTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEntrustTypeById.HandleId, 0, ConfigEntrustTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigEntrustTypeById.HandleId, ConfigEntrustTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			EntrustType rootAsEntrustType = EntrustType.GetRootAsEntrustType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("EntrustTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigEntrustTypeById.HandleId, ConfigEntrustTypeById.LogPair);
			return new EntrustType?(rootAsEntrustType);
		}

		// Token: 0x0400121A RID: 4634
		private const string DB = "db_moonchasing.db";

		// Token: 0x0400121B RID: 4635
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400121C RID: 4636
		private const string TABLE = "EntrustType";

		// Token: 0x0400121D RID: 4637
		private const string COMMAND = "select BinData from `EntrustType` where Id=?";

		// Token: 0x0400121E RID: 4638
		private const string KEY_PREFIX = "EntrustTypeById";

		// Token: 0x0400121F RID: 4639
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001220 RID: 4640
		private static int HandleId;
	}
}
