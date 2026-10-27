using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000286 RID: 646
	public class ConfigEntrustTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F29 RID: 3881 RVA: 0x000AF2A8 File Offset: 0x000AD4A8
		static ConfigEntrustTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEntrustTypeById.CreateStaticDefaultValue), new Action(ConfigEntrustTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x000AF2C8 File Offset: 0x000AD4C8
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

		// Token: 0x06000F2B RID: 3883 RVA: 0x000AF347 File Offset: 0x000AD547
		public static void ResetStaticDefaultValue()
		{
			ConfigEntrustTypeById.LogPair = null;
			ConfigEntrustTypeById.HandleId = 0;
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x000AF355 File Offset: 0x000AD555
		public static void Init()
		{
			ConfigEntrustTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigEntrustTypeById.HandleId, "db_moonchasing.db", "select BinData from `EntrustType` where Id=?");
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x000AF370 File Offset: 0x000AD570
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

		// Token: 0x0400118E RID: 4494
		private const string DB = "db_moonchasing.db";

		// Token: 0x0400118F RID: 4495
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04001190 RID: 4496
		private const string TABLE = "EntrustType";

		// Token: 0x04001191 RID: 4497
		private const string COMMAND = "select BinData from `EntrustType` where Id=?";

		// Token: 0x04001192 RID: 4498
		private const string KEY_PREFIX = "EntrustTypeById";

		// Token: 0x04001193 RID: 4499
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001194 RID: 4500
		private static int HandleId;
	}
}
