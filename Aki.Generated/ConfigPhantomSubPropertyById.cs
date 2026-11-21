using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006CD RID: 1741
	public class ConfigPhantomSubPropertyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028DE RID: 10462 RVA: 0x001442BF File Offset: 0x001424BF
		static ConfigPhantomSubPropertyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomSubPropertyById.CreateStaticDefaultValue), new Action(ConfigPhantomSubPropertyById.ResetStaticDefaultValue));
		}

		// Token: 0x060028DF RID: 10463 RVA: 0x001442E0 File Offset: 0x001424E0
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

		// Token: 0x060028E0 RID: 10464 RVA: 0x0014435F File Offset: 0x0014255F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomSubPropertyById.LogPair = null;
			ConfigPhantomSubPropertyById.HandleId = 0;
		}

		// Token: 0x060028E1 RID: 10465 RVA: 0x0014436D File Offset: 0x0014256D
		public static void Init()
		{
			ConfigPhantomSubPropertyById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomSubPropertyById.HandleId, "db_phantom.db", "select BinData from `PhantomSubProperty` where Id=?");
		}

		// Token: 0x060028E2 RID: 10466 RVA: 0x00144388 File Offset: 0x00142588
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

		// Token: 0x04002F81 RID: 12161
		private const string DB = "db_phantom.db";

		// Token: 0x04002F82 RID: 12162
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002F83 RID: 12163
		private const string TABLE = "PhantomSubProperty";

		// Token: 0x04002F84 RID: 12164
		private const string COMMAND = "select BinData from `PhantomSubProperty` where Id=?";

		// Token: 0x04002F85 RID: 12165
		private const string KEY_PREFIX = "PhantomSubPropertyById";

		// Token: 0x04002F86 RID: 12166
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F87 RID: 12167
		private static int HandleId;
	}
}
