using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B35 RID: 2869
	public class ConfigTypeInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06004352 RID: 17234 RVA: 0x001D9A34 File Offset: 0x001D7C34
		static ConfigTypeInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTypeInfoById.CreateStaticDefaultValue), new Action(ConfigTypeInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x001D9A54 File Offset: 0x001D7C54
		public static void CreateStaticDefaultValue()
		{
			ConfigTypeInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTypeInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_item.db"),
				new ValueTuple<string, object>("文件", "d.道具.xlsx"),
				new ValueTuple<string, object>("表名", "TypeInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `TypeInfo` where Id=?")
			});
		}

		// Token: 0x06004354 RID: 17236 RVA: 0x001D9AD3 File Offset: 0x001D7CD3
		public static void ResetStaticDefaultValue()
		{
			ConfigTypeInfoById.LogPair = null;
			ConfigTypeInfoById.HandleId = 0;
		}

		// Token: 0x06004355 RID: 17237 RVA: 0x001D9AE1 File Offset: 0x001D7CE1
		public static void Init()
		{
			ConfigTypeInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigTypeInfoById.HandleId, "db_item.db", "select BinData from `TypeInfo` where Id=?");
		}

		// Token: 0x06004356 RID: 17238 RVA: 0x001D9AFC File Offset: 0x001D7CFC
		public static TypeInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTypeInfoById.HandleId, ConfigTypeInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TypeInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TypeInfo?(TypeInfo.GetRootAsTypeInfo(configBuffer));
				}
			}
			ConfigTypeInfoById.LogPair.Clear();
			ConfigTypeInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTypeInfoById.HandleId, 1, p0Id, ConfigTypeInfoById.LogPair) || ConfigCommon.Step(ConfigTypeInfoById.HandleId, true, ConfigTypeInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTypeInfoById.HandleId, ConfigTypeInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTypeInfoById.HandleId, 0, ConfigTypeInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTypeInfoById.HandleId, ConfigTypeInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TypeInfo rootAsTypeInfo = TypeInfo.GetRootAsTypeInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TypeInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTypeInfoById.HandleId, ConfigTypeInfoById.LogPair);
			return new TypeInfo?(rootAsTypeInfo);
		}

		// Token: 0x04004E59 RID: 20057
		private const string DB = "db_item.db";

		// Token: 0x04004E5A RID: 20058
		private const string FILE = "d.道具.xlsx";

		// Token: 0x04004E5B RID: 20059
		private const string TABLE = "TypeInfo";

		// Token: 0x04004E5C RID: 20060
		private const string COMMAND = "select BinData from `TypeInfo` where Id=?";

		// Token: 0x04004E5D RID: 20061
		private const string KEY_PREFIX = "TypeInfoById";

		// Token: 0x04004E5E RID: 20062
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004E5F RID: 20063
		private static int HandleId;
	}
}
