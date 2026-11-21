using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006AB RID: 1707
	public class ConfigPhantomFetterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002812 RID: 10258 RVA: 0x0013FB5B File Offset: 0x0013DD5B
		static ConfigPhantomFetterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomFetterById.CreateStaticDefaultValue), new Action(ConfigPhantomFetterById.ResetStaticDefaultValue));
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x0013FB7C File Offset: 0x0013DD7C
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomFetterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomFetterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomFetter"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomFetter` where Id=?")
			});
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x0013FBFB File Offset: 0x0013DDFB
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomFetterById.LogPair = null;
			ConfigPhantomFetterById.HandleId = 0;
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x0013FC09 File Offset: 0x0013DE09
		public static void Init()
		{
			ConfigPhantomFetterById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomFetterById.HandleId, "db_phantom.db", "select BinData from `PhantomFetter` where Id=?");
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x0013FC24 File Offset: 0x0013DE24
		public static PhantomFetter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomFetterById.HandleId, ConfigPhantomFetterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomFetterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomFetter?(PhantomFetter.GetRootAsPhantomFetter(configBuffer));
				}
			}
			ConfigPhantomFetterById.LogPair.Clear();
			ConfigPhantomFetterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomFetterById.HandleId, 1, p0Id, ConfigPhantomFetterById.LogPair) || ConfigCommon.Step(ConfigPhantomFetterById.HandleId, true, ConfigPhantomFetterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomFetterById.HandleId, ConfigPhantomFetterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomFetterById.HandleId, 0, ConfigPhantomFetterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomFetterById.HandleId, ConfigPhantomFetterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomFetter rootAsPhantomFetter = PhantomFetter.GetRootAsPhantomFetter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomFetterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomFetterById.HandleId, ConfigPhantomFetterById.LogPair);
			return new PhantomFetter?(rootAsPhantomFetter);
		}

		// Token: 0x04002E93 RID: 11923
		private const string DB = "db_phantom.db";

		// Token: 0x04002E94 RID: 11924
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002E95 RID: 11925
		private const string TABLE = "PhantomFetter";

		// Token: 0x04002E96 RID: 11926
		private const string COMMAND = "select BinData from `PhantomFetter` where Id=?";

		// Token: 0x04002E97 RID: 11927
		private const string KEY_PREFIX = "PhantomFetterById";

		// Token: 0x04002E98 RID: 11928
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002E99 RID: 11929
		private static int HandleId;
	}
}
