using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200035C RID: 860
	public class ConfigFunctionMenuByFunctionId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600142D RID: 5165 RVA: 0x000CB837 File Offset: 0x000C9A37
		static ConfigFunctionMenuByFunctionId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFunctionMenuByFunctionId.CreateStaticDefaultValue), new Action(ConfigFunctionMenuByFunctionId.ResetStaticDefaultValue));
		}

		// Token: 0x0600142E RID: 5166 RVA: 0x000CB858 File Offset: 0x000C9A58
		public static void CreateStaticDefaultValue()
		{
			ConfigFunctionMenuByFunctionId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFunctionMenuByFunctionId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_function.db"),
				new ValueTuple<string, object>("文件", "g.功能开启.xlsx"),
				new ValueTuple<string, object>("表名", "FunctionMenu"),
				new ValueTuple<string, object>("语句", "select BinData from `FunctionMenu` where FunctionId=?")
			});
		}

		// Token: 0x0600142F RID: 5167 RVA: 0x000CB8D7 File Offset: 0x000C9AD7
		public static void ResetStaticDefaultValue()
		{
			ConfigFunctionMenuByFunctionId.LogPair = null;
			ConfigFunctionMenuByFunctionId.HandleId = 0;
		}

		// Token: 0x06001430 RID: 5168 RVA: 0x000CB8E5 File Offset: 0x000C9AE5
		public static void Init()
		{
			ConfigFunctionMenuByFunctionId.HandleId = ConfigCommon.InitDataStatement(ConfigFunctionMenuByFunctionId.HandleId, "db_function.db", "select BinData from `FunctionMenu` where FunctionId=?");
		}

		// Token: 0x06001431 RID: 5169 RVA: 0x000CB900 File Offset: 0x000C9B00
		public static FunctionMenu? GetConfig(int p0FunctionId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFunctionMenuByFunctionId.HandleId, ConfigFunctionMenuByFunctionId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FunctionMenuByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FunctionMenu?(FunctionMenu.GetRootAsFunctionMenu(configBuffer));
				}
			}
			ConfigFunctionMenuByFunctionId.LogPair.Clear();
			ConfigFunctionMenuByFunctionId.LogPair.Add(new ValueTuple<string, object>("FunctionId", p0FunctionId));
			if (!ConfigCommon.BindInt(ConfigFunctionMenuByFunctionId.HandleId, 1, p0FunctionId, ConfigFunctionMenuByFunctionId.LogPair) || ConfigCommon.Step(ConfigFunctionMenuByFunctionId.HandleId, true, ConfigFunctionMenuByFunctionId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFunctionMenuByFunctionId.HandleId, ConfigFunctionMenuByFunctionId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFunctionMenuByFunctionId.HandleId, 0, ConfigFunctionMenuByFunctionId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFunctionMenuByFunctionId.HandleId, ConfigFunctionMenuByFunctionId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FunctionMenu rootAsFunctionMenu = FunctionMenu.GetRootAsFunctionMenu(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FunctionMenuByFunctionId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0FunctionId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFunctionMenuByFunctionId.HandleId, ConfigFunctionMenuByFunctionId.LogPair);
			return new FunctionMenu?(rootAsFunctionMenu);
		}

		// Token: 0x04001768 RID: 5992
		private const string DB = "db_function.db";

		// Token: 0x04001769 RID: 5993
		private const string FILE = "g.功能开启.xlsx";

		// Token: 0x0400176A RID: 5994
		private const string TABLE = "FunctionMenu";

		// Token: 0x0400176B RID: 5995
		private const string COMMAND = "select BinData from `FunctionMenu` where FunctionId=?";

		// Token: 0x0400176C RID: 5996
		private const string KEY_PREFIX = "FunctionMenuByFunctionId";

		// Token: 0x0400176D RID: 5997
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400176E RID: 5998
		private static int HandleId;
	}
}
