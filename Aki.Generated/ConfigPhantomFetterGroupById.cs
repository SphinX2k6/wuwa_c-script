using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000695 RID: 1685
	public class ConfigPhantomFetterGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600278E RID: 10126 RVA: 0x001394BB File Offset: 0x001376BB
		static ConfigPhantomFetterGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomFetterGroupById.CreateStaticDefaultValue), new Action(ConfigPhantomFetterGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x001394DC File Offset: 0x001376DC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomFetterGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomFetterGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomFetterGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomFetterGroup` where Id=?")
			});
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x0013955B File Offset: 0x0013775B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomFetterGroupById.LogPair = null;
			ConfigPhantomFetterGroupById.HandleId = 0;
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x00139569 File Offset: 0x00137769
		public static void Init()
		{
			ConfigPhantomFetterGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomFetterGroupById.HandleId, "db_phantom.db", "select BinData from `PhantomFetterGroup` where Id=?");
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x00139584 File Offset: 0x00137784
		public static PhantomFetterGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomFetterGroupById.HandleId, ConfigPhantomFetterGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomFetterGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomFetterGroup?(PhantomFetterGroup.GetRootAsPhantomFetterGroup(configBuffer));
				}
			}
			ConfigPhantomFetterGroupById.LogPair.Clear();
			ConfigPhantomFetterGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomFetterGroupById.HandleId, 1, p0Id, ConfigPhantomFetterGroupById.LogPair) || ConfigCommon.Step(ConfigPhantomFetterGroupById.HandleId, true, ConfigPhantomFetterGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomFetterGroupById.HandleId, ConfigPhantomFetterGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomFetterGroupById.HandleId, 0, ConfigPhantomFetterGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomFetterGroupById.HandleId, ConfigPhantomFetterGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomFetterGroup rootAsPhantomFetterGroup = PhantomFetterGroup.GetRootAsPhantomFetterGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomFetterGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomFetterGroupById.HandleId, ConfigPhantomFetterGroupById.LogPair);
			return new PhantomFetterGroup?(rootAsPhantomFetterGroup);
		}

		// Token: 0x04002DF9 RID: 11769
		private const string DB = "db_phantom.db";

		// Token: 0x04002DFA RID: 11770
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002DFB RID: 11771
		private const string TABLE = "PhantomFetterGroup";

		// Token: 0x04002DFC RID: 11772
		private const string COMMAND = "select BinData from `PhantomFetterGroup` where Id=?";

		// Token: 0x04002DFD RID: 11773
		private const string KEY_PREFIX = "PhantomFetterGroupById";

		// Token: 0x04002DFE RID: 11774
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DFF RID: 11775
		private static int HandleId;
	}
}
