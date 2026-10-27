using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000184 RID: 388
	public class ConfigCommonBtDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000919 RID: 2329 RVA: 0x0008CE28 File Offset: 0x0008B028
		static ConfigCommonBtDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonBtDataById.CreateStaticDefaultValue), new Action(ConfigCommonBtDataById.ResetStaticDefaultValue));
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0008CE48 File Offset: 0x0008B048
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

		// Token: 0x0600091B RID: 2331 RVA: 0x0008CEC7 File Offset: 0x0008B0C7
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonBtDataById.LogPair = null;
			ConfigCommonBtDataById.HandleId = 0;
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0008CED5 File Offset: 0x0008B0D5
		public static void Init()
		{
			ConfigCommonBtDataById.HandleId = ConfigCommon.InitDataStatement(ConfigCommonBtDataById.HandleId, "db_commonbtdata.db", "select BinData from `CommonBtData` where Id=?");
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x0008CEF0 File Offset: 0x0008B0F0
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

		// Token: 0x04000A80 RID: 2688
		private const string DB = "db_commonbtdata.db";

		// Token: 0x04000A81 RID: 2689
		private const string FILE = "UniverseEditor/CommonBt/行为树_*";

		// Token: 0x04000A82 RID: 2690
		private const string TABLE = "CommonBtData";

		// Token: 0x04000A83 RID: 2691
		private const string COMMAND = "select BinData from `CommonBtData` where Id=?";

		// Token: 0x04000A84 RID: 2692
		private const string KEY_PREFIX = "CommonBtDataById";

		// Token: 0x04000A85 RID: 2693
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A86 RID: 2694
		private static int HandleId;
	}
}
