using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A60 RID: 2656
	public class ConfigTypeInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E54 RID: 15956 RVA: 0x001BA6A0 File Offset: 0x001B88A0
		static ConfigTypeInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTypeInfoById.CreateStaticDefaultValue), new Action(ConfigTypeInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06003E55 RID: 15957 RVA: 0x001BA6C0 File Offset: 0x001B88C0
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

		// Token: 0x06003E56 RID: 15958 RVA: 0x001BA73F File Offset: 0x001B893F
		public static void ResetStaticDefaultValue()
		{
			ConfigTypeInfoById.LogPair = null;
			ConfigTypeInfoById.HandleId = 0;
		}

		// Token: 0x06003E57 RID: 15959 RVA: 0x001BA74D File Offset: 0x001B894D
		public static void Init()
		{
			ConfigTypeInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigTypeInfoById.HandleId, "db_item.db", "select BinData from `TypeInfo` where Id=?");
		}

		// Token: 0x06003E58 RID: 15960 RVA: 0x001BA768 File Offset: 0x001B8968
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

		// Token: 0x04004886 RID: 18566
		private const string DB = "db_item.db";

		// Token: 0x04004887 RID: 18567
		private const string FILE = "d.道具.xlsx";

		// Token: 0x04004888 RID: 18568
		private const string TABLE = "TypeInfo";

		// Token: 0x04004889 RID: 18569
		private const string COMMAND = "select BinData from `TypeInfo` where Id=?";

		// Token: 0x0400488A RID: 18570
		private const string KEY_PREFIX = "TypeInfoById";

		// Token: 0x0400488B RID: 18571
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400488C RID: 18572
		private static int HandleId;
	}
}
