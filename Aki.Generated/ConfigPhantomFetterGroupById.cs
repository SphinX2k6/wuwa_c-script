using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006AD RID: 1709
	public class ConfigPhantomFetterGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600281E RID: 10270 RVA: 0x0013FF37 File Offset: 0x0013E137
		static ConfigPhantomFetterGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomFetterGroupById.CreateStaticDefaultValue), new Action(ConfigPhantomFetterGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x0013FF58 File Offset: 0x0013E158
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

		// Token: 0x06002820 RID: 10272 RVA: 0x0013FFD7 File Offset: 0x0013E1D7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomFetterGroupById.LogPair = null;
			ConfigPhantomFetterGroupById.HandleId = 0;
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x0013FFE5 File Offset: 0x0013E1E5
		public static void Init()
		{
			ConfigPhantomFetterGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomFetterGroupById.HandleId, "db_phantom.db", "select BinData from `PhantomFetterGroup` where Id=?");
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x00140000 File Offset: 0x0013E200
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

		// Token: 0x04002EA1 RID: 11937
		private const string DB = "db_phantom.db";

		// Token: 0x04002EA2 RID: 11938
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EA3 RID: 11939
		private const string TABLE = "PhantomFetterGroup";

		// Token: 0x04002EA4 RID: 11940
		private const string COMMAND = "select BinData from `PhantomFetterGroup` where Id=?";

		// Token: 0x04002EA5 RID: 11941
		private const string KEY_PREFIX = "PhantomFetterGroupById";

		// Token: 0x04002EA6 RID: 11942
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EA7 RID: 11943
		private static int HandleId;
	}
}
