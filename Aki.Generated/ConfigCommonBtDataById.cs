using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000196 RID: 406
	public class ConfigCommonBtDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000985 RID: 2437 RVA: 0x00092D60 File Offset: 0x00090F60
		static ConfigCommonBtDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonBtDataById.CreateStaticDefaultValue), new Action(ConfigCommonBtDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00092D80 File Offset: 0x00090F80
		public static void CreateStaticDefaultValue()
		{
			ConfigCommonBtDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCommonBtDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_commonbtdata.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/CommonBt/行为树_*"),
				new ValueTuple<string, object>("表名", "CommonBtData"),
				new ValueTuple<string, object>("语句", "select BinData from `CommonBtData` where Id=?")
			});
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00092DFF File Offset: 0x00090FFF
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonBtDataById.LogPair = null;
			ConfigCommonBtDataById.HandleId = 0;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00092E0D File Offset: 0x0009100D
		public static void Init()
		{
			ConfigCommonBtDataById.HandleId = ConfigCommon.InitDataStatement(ConfigCommonBtDataById.HandleId, "db_commonbtdata.db", "select BinData from `CommonBtData` where Id=?");
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00092E28 File Offset: 0x00091028
		public static CommonBtData? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCommonBtDataById.HandleId, ConfigCommonBtDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommonBtDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CommonBtData?(CommonBtData.GetRootAsCommonBtData(configBuffer));
				}
			}
			ConfigCommonBtDataById.LogPair.Clear();
			ConfigCommonBtDataById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCommonBtDataById.HandleId, 1, p0Id, ConfigCommonBtDataById.LogPair) || ConfigCommon.Step(ConfigCommonBtDataById.HandleId, true, ConfigCommonBtDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCommonBtDataById.HandleId, ConfigCommonBtDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCommonBtDataById.HandleId, 0, ConfigCommonBtDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCommonBtDataById.HandleId, ConfigCommonBtDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CommonBtData rootAsCommonBtData = CommonBtData.GetRootAsCommonBtData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommonBtDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCommonBtDataById.HandleId, ConfigCommonBtDataById.LogPair);
			return new CommonBtData?(rootAsCommonBtData);
		}

		// Token: 0x04000AFE RID: 2814
		private const string DB = "db_commonbtdata.db";

		// Token: 0x04000AFF RID: 2815
		private const string FILE = "UniverseEditor/CommonBt/行为树_*";

		// Token: 0x04000B00 RID: 2816
		private const string TABLE = "CommonBtData";

		// Token: 0x04000B01 RID: 2817
		private const string COMMAND = "select BinData from `CommonBtData` where Id=?";

		// Token: 0x04000B02 RID: 2818
		private const string KEY_PREFIX = "CommonBtDataById";

		// Token: 0x04000B03 RID: 2819
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B04 RID: 2820
		private static int HandleId;
	}
}
