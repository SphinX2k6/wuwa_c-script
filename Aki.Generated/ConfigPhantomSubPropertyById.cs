using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B5 RID: 1717
	public class ConfigPhantomSubPropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600284E RID: 10318 RVA: 0x0013D843 File Offset: 0x0013BA43
		static ConfigPhantomSubPropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomSubPropertyById.CreateStaticDefaultValue), new Action(ConfigPhantomSubPropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x0600284F RID: 10319 RVA: 0x0013D864 File Offset: 0x0013BA64
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomSubPropertyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomSubPropertyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomSubProperty"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomSubProperty` where Id=?")
			});
		}

		// Token: 0x06002850 RID: 10320 RVA: 0x0013D8E3 File Offset: 0x0013BAE3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomSubPropertyById.LogPair = null;
			ConfigPhantomSubPropertyById.HandleId = 0;
		}

		// Token: 0x06002851 RID: 10321 RVA: 0x0013D8F1 File Offset: 0x0013BAF1
		public static void Init()
		{
			ConfigPhantomSubPropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomSubPropertyById.HandleId, "db_phantom.db", "select BinData from `PhantomSubProperty` where Id=?");
		}

		// Token: 0x06002852 RID: 10322 RVA: 0x0013D90C File Offset: 0x0013BB0C
		public static PhantomSubProperty? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomSubPropertyById.HandleId, ConfigPhantomSubPropertyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomSubPropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomSubProperty?(PhantomSubProperty.GetRootAsPhantomSubProperty(configBuffer));
				}
			}
			ConfigPhantomSubPropertyById.LogPair.Clear();
			ConfigPhantomSubPropertyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomSubPropertyById.HandleId, 1, p0Id, ConfigPhantomSubPropertyById.LogPair) || ConfigCommon.Step(ConfigPhantomSubPropertyById.HandleId, true, ConfigPhantomSubPropertyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomSubPropertyById.HandleId, ConfigPhantomSubPropertyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomSubPropertyById.HandleId, 0, ConfigPhantomSubPropertyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomSubPropertyById.HandleId, ConfigPhantomSubPropertyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomSubProperty rootAsPhantomSubProperty = PhantomSubProperty.GetRootAsPhantomSubProperty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomSubPropertyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomSubPropertyById.HandleId, ConfigPhantomSubPropertyById.LogPair);
			return new PhantomSubProperty?(rootAsPhantomSubProperty);
		}

		// Token: 0x04002ED9 RID: 11993
		private const string DB = "db_phantom.db";

		// Token: 0x04002EDA RID: 11994
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EDB RID: 11995
		private const string TABLE = "PhantomSubProperty";

		// Token: 0x04002EDC RID: 11996
		private const string COMMAND = "select BinData from `PhantomSubProperty` where Id=?";

		// Token: 0x04002EDD RID: 11997
		private const string KEY_PREFIX = "PhantomSubPropertyById";

		// Token: 0x04002EDE RID: 11998
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EDF RID: 11999
		private static int HandleId;
	}
}
