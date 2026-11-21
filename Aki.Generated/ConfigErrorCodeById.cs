using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200029B RID: 667
	public class ConfigErrorCodeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000FA7 RID: 4007 RVA: 0x000B57B4 File Offset: 0x000B39B4
		static ConfigErrorCodeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigErrorCodeById.CreateStaticDefaultValue), new Action(ConfigErrorCodeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x000B57D4 File Offset: 0x000B39D4
		public static void CreateStaticDefaultValue()
		{
			ConfigErrorCodeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigErrorCodeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_error_code.db"),
				new ValueTuple<string, object>("文件", "c.错误码/ErrorCode*"),
				new ValueTuple<string, object>("表名", "ErrorCode"),
				new ValueTuple<string, object>("语句", "select BinData from `ErrorCode` where Id=?")
			});
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x000B5853 File Offset: 0x000B3A53
		public static void ResetStaticDefaultValue()
		{
			ConfigErrorCodeById.LogPair = null;
			ConfigErrorCodeById.HandleId = 0;
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x000B5861 File Offset: 0x000B3A61
		public static void Init()
		{
			ConfigErrorCodeById.HandleId = ConfigCommon.InitDataStatement(ConfigErrorCodeById.HandleId, "db_error_code.db", "select BinData from `ErrorCode` where Id=?");
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x000B587C File Offset: 0x000B3A7C
		public static ErrorCode? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigErrorCodeById.HandleId, ConfigErrorCodeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ErrorCodeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ErrorCode?(ErrorCode.GetRootAsErrorCode(configBuffer));
				}
			}
			ConfigErrorCodeById.LogPair.Clear();
			ConfigErrorCodeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigErrorCodeById.HandleId, 1, p0Id, ConfigErrorCodeById.LogPair) || ConfigCommon.Step(ConfigErrorCodeById.HandleId, true, ConfigErrorCodeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigErrorCodeById.HandleId, ConfigErrorCodeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigErrorCodeById.HandleId, 0, ConfigErrorCodeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigErrorCodeById.HandleId, ConfigErrorCodeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ErrorCode rootAsErrorCode = ErrorCode.GetRootAsErrorCode(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ErrorCodeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigErrorCodeById.HandleId, ConfigErrorCodeById.LogPair);
			return new ErrorCode?(rootAsErrorCode);
		}

		// Token: 0x04001221 RID: 4641
		private const string DB = "db_error_code.db";

		// Token: 0x04001222 RID: 4642
		private const string FILE = "c.错误码/ErrorCode*";

		// Token: 0x04001223 RID: 4643
		private const string TABLE = "ErrorCode";

		// Token: 0x04001224 RID: 4644
		private const string COMMAND = "select BinData from `ErrorCode` where Id=?";

		// Token: 0x04001225 RID: 4645
		private const string KEY_PREFIX = "ErrorCodeById";

		// Token: 0x04001226 RID: 4646
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001227 RID: 4647
		private static int HandleId;
	}
}
