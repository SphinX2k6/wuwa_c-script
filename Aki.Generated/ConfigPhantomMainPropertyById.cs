using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A4 RID: 1700
	public class ConfigPhantomMainPropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027E8 RID: 10216 RVA: 0x0013B48D File Offset: 0x0013968D
		static ConfigPhantomMainPropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomMainPropertyById.CreateStaticDefaultValue), new Action(ConfigPhantomMainPropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x0013B4AC File Offset: 0x001396AC
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

		// Token: 0x060027EA RID: 10218 RVA: 0x0013B52B File Offset: 0x0013972B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomMainPropertyById.LogPair = null;
			ConfigPhantomMainPropertyById.HandleId = 0;
		}

		// Token: 0x060027EB RID: 10219 RVA: 0x0013B539 File Offset: 0x00139739
		public static void Init()
		{
			ConfigPhantomMainPropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomMainPropertyById.HandleId, "db_phantom.db", "select BinData from `PhantomMainProperty` where Id=?");
		}

		// Token: 0x060027EC RID: 10220 RVA: 0x0013B554 File Offset: 0x00139754
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

		// Token: 0x04002E62 RID: 11874
		private const string DB = "db_phantom.db";

		// Token: 0x04002E63 RID: 11875
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E64 RID: 11876
		private const string TABLE = "PhantomMainProperty";

		// Token: 0x04002E65 RID: 11877
		private const string COMMAND = "select BinData from `PhantomMainProperty` where Id=?";

		// Token: 0x04002E66 RID: 11878
		private const string KEY_PREFIX = "PhantomMainPropertyById";

		// Token: 0x04002E67 RID: 11879
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E68 RID: 11880
		private static int HandleId;
	}
}
