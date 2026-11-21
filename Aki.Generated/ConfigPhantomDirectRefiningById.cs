using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006A7 RID: 1703
	public class ConfigPhantomDirectRefiningById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060027FA RID: 10234 RVA: 0x0013F3A3 File Offset: 0x0013D5A3
		static ConfigPhantomDirectRefiningById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomDirectRefiningById.CreateStaticDefaultValue), new Action(ConfigPhantomDirectRefiningById.ResetStaticDefaultValue));
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x0013F3C4 File Offset: 0x0013D5C4
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomDirectRefiningById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomDirectRefiningById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomDirectRefining"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomDirectRefining` where Id=?")
			});
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x0013F443 File Offset: 0x0013D643
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomDirectRefiningById.LogPair = null;
			ConfigPhantomDirectRefiningById.HandleId = 0;
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x0013F451 File Offset: 0x0013D651
		public static void Init()
		{
			ConfigPhantomDirectRefiningById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomDirectRefiningById.HandleId, "db_calabash.db", "select BinData from `PhantomDirectRefining` where Id=?");
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x0013F46C File Offset: 0x0013D66C
		public static PhantomDirectRefining? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomDirectRefiningById.HandleId, ConfigPhantomDirectRefiningById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomDirectRefiningById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomDirectRefining?(PhantomDirectRefining.GetRootAsPhantomDirectRefining(configBuffer));
				}
			}
			ConfigPhantomDirectRefiningById.LogPair.Clear();
			ConfigPhantomDirectRefiningById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomDirectRefiningById.HandleId, 1, p0Id, ConfigPhantomDirectRefiningById.LogPair) || ConfigCommon.Step(ConfigPhantomDirectRefiningById.HandleId, true, ConfigPhantomDirectRefiningById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomDirectRefiningById.HandleId, ConfigPhantomDirectRefiningById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomDirectRefiningById.HandleId, 0, ConfigPhantomDirectRefiningById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomDirectRefiningById.HandleId, ConfigPhantomDirectRefiningById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomDirectRefining rootAsPhantomDirectRefining = PhantomDirectRefining.GetRootAsPhantomDirectRefining(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomDirectRefiningById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomDirectRefiningById.HandleId, ConfigPhantomDirectRefiningById.LogPair);
			return new PhantomDirectRefining?(rootAsPhantomDirectRefining);
		}

		// Token: 0x04002E77 RID: 11895
		private const string DB = "db_calabash.db";

		// Token: 0x04002E78 RID: 11896
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x04002E79 RID: 11897
		private const string TABLE = "PhantomDirectRefining";

		// Token: 0x04002E7A RID: 11898
		private const string COMMAND = "select BinData from `PhantomDirectRefining` where Id=?";

		// Token: 0x04002E7B RID: 11899
		private const string KEY_PREFIX = "PhantomDirectRefiningById";

		// Token: 0x04002E7C RID: 11900
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E7D RID: 11901
		private static int HandleId;
	}
}
