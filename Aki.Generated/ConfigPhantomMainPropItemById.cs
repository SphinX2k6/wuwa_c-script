using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A6 RID: 1702
	public class ConfigPhantomMainPropItemById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027F4 RID: 10228 RVA: 0x0013B90B File Offset: 0x00139B0B
		static ConfigPhantomMainPropItemById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomMainPropItemById.CreateStaticDefaultValue), new Action(ConfigPhantomMainPropItemById.ResetStaticDefaultValue));
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x0013B92C File Offset: 0x00139B2C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomMainPropItemById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomMainPropItemById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomMainPropItem"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomMainPropItem` where Id=?")
			});
		}

		// Token: 0x060027F6 RID: 10230 RVA: 0x0013B9AB File Offset: 0x00139BAB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomMainPropItemById.LogPair = null;
			ConfigPhantomMainPropItemById.HandleId = 0;
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x0013B9B9 File Offset: 0x00139BB9
		public static void Init()
		{
			ConfigPhantomMainPropItemById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomMainPropItemById.HandleId, "db_phantom.db", "select BinData from `PhantomMainPropItem` where Id=?");
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x0013B9D4 File Offset: 0x00139BD4
		public static PhantomMainPropItem? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomMainPropItemById.HandleId, ConfigPhantomMainPropItemById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomMainPropItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomMainPropItem?(PhantomMainPropItem.GetRootAsPhantomMainPropItem(configBuffer));
				}
			}
			ConfigPhantomMainPropItemById.LogPair.Clear();
			ConfigPhantomMainPropItemById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomMainPropItemById.HandleId, 1, p0Id, ConfigPhantomMainPropItemById.LogPair) || ConfigCommon.Step(ConfigPhantomMainPropItemById.HandleId, true, ConfigPhantomMainPropItemById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomMainPropItemById.HandleId, ConfigPhantomMainPropItemById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomMainPropItemById.HandleId, 0, ConfigPhantomMainPropItemById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomMainPropItemById.HandleId, ConfigPhantomMainPropItemById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomMainPropItem rootAsPhantomMainPropItem = PhantomMainPropItem.GetRootAsPhantomMainPropItem(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomMainPropItemById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomMainPropItemById.HandleId, ConfigPhantomMainPropItemById.LogPair);
			return new PhantomMainPropItem?(rootAsPhantomMainPropItem);
		}

		// Token: 0x04002E70 RID: 11888
		private const string DB = "db_phantom.db";

		// Token: 0x04002E71 RID: 11889
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E72 RID: 11890
		private const string TABLE = "PhantomMainPropItem";

		// Token: 0x04002E73 RID: 11891
		private const string COMMAND = "select BinData from `PhantomMainPropItem` where Id=?";

		// Token: 0x04002E74 RID: 11892
		private const string KEY_PREFIX = "PhantomMainPropItemById";

		// Token: 0x04002E75 RID: 11893
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E76 RID: 11894
		private static int HandleId;
	}
}
