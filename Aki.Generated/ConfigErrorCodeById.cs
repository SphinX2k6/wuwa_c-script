using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000287 RID: 647
	public class ConfigErrorCodeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F2F RID: 3887 RVA: 0x000AF4F0 File Offset: 0x000AD6F0
		static ConfigErrorCodeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigErrorCodeById.CreateStaticDefaultValue), new Action(ConfigErrorCodeById.ResetStaticDefaultValue));
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x000AF510 File Offset: 0x000AD710
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

		// Token: 0x06000F31 RID: 3889 RVA: 0x000AF58F File Offset: 0x000AD78F
		public static void ResetStaticDefaultValue()
		{
			ConfigErrorCodeById.LogPair = null;
			ConfigErrorCodeById.HandleId = 0;
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x000AF59D File Offset: 0x000AD79D
		public static void Init()
		{
			ConfigErrorCodeById.HandleId = ConfigCommon.InitDataStatement(ConfigErrorCodeById.HandleId, "db_error_code.db", "select BinData from `ErrorCode` where Id=?");
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x000AF5B8 File Offset: 0x000AD7B8
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

		// Token: 0x04001195 RID: 4501
		private const string DB = "db_error_code.db";

		// Token: 0x04001196 RID: 4502
		private const string FILE = "c.错误码/ErrorCode*";

		// Token: 0x04001197 RID: 4503
		private const string TABLE = "ErrorCode";

		// Token: 0x04001198 RID: 4504
		private const string COMMAND = "select BinData from `ErrorCode` where Id=?";

		// Token: 0x04001199 RID: 4505
		private const string KEY_PREFIX = "ErrorCodeById";

		// Token: 0x0400119A RID: 4506
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400119B RID: 4507
		private static int HandleId;
	}
}
