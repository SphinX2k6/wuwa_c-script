using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006BC RID: 1724
	public class ConfigPhantomMainPropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002878 RID: 10360 RVA: 0x00141F09 File Offset: 0x00140109
		static ConfigPhantomMainPropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomMainPropertyById.CreateStaticDefaultValue), new Action(ConfigPhantomMainPropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x06002879 RID: 10361 RVA: 0x00141F28 File Offset: 0x00140128
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomMainPropertyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomMainPropertyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomMainProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomMainProperty` where Id=?")
			});
		}

		// Token: 0x0600287A RID: 10362 RVA: 0x00141FA7 File Offset: 0x001401A7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomMainPropertyById.LogPair = null;
			ConfigPhantomMainPropertyById.HandleId = 0;
		}

		// Token: 0x0600287B RID: 10363 RVA: 0x00141FB5 File Offset: 0x001401B5
		public static void Init()
		{
			ConfigPhantomMainPropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomMainPropertyById.HandleId, "db_phantom.db", "select BinData from `PhantomMainProperty` where Id=?");
		}

		// Token: 0x0600287C RID: 10364 RVA: 0x00141FD0 File Offset: 0x001401D0
		public static PhantomMainProperty? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomMainPropertyById.HandleId, ConfigPhantomMainPropertyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomMainPropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomMainProperty?(PhantomMainProperty.GetRootAsPhantomMainProperty(configBuffer));
				}
			}
			ConfigPhantomMainPropertyById.LogPair.Clear();
			ConfigPhantomMainPropertyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomMainPropertyById.HandleId, 1, p0Id, ConfigPhantomMainPropertyById.LogPair) || ConfigCommon.Step(ConfigPhantomMainPropertyById.HandleId, true, ConfigPhantomMainPropertyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomMainPropertyById.HandleId, ConfigPhantomMainPropertyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomMainPropertyById.HandleId, 0, ConfigPhantomMainPropertyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomMainPropertyById.HandleId, ConfigPhantomMainPropertyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomMainProperty rootAsPhantomMainProperty = PhantomMainProperty.GetRootAsPhantomMainProperty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomMainPropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomMainPropertyById.HandleId, ConfigPhantomMainPropertyById.LogPair);
			return new PhantomMainProperty?(rootAsPhantomMainProperty);
		}

		// Token: 0x04002F0A RID: 12042
		private const string DB = "db_phantom.db";

		// Token: 0x04002F0B RID: 12043
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002F0C RID: 12044
		private const string TABLE = "PhantomMainProperty";

		// Token: 0x04002F0D RID: 12045
		private const string COMMAND = "select BinData from `PhantomMainProperty` where Id=?";

		// Token: 0x04002F0E RID: 12046
		private const string KEY_PREFIX = "PhantomMainPropertyById";

		// Token: 0x04002F0F RID: 12047
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F10 RID: 12048
		private static int HandleId;
	}
}
