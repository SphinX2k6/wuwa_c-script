using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200068F RID: 1679
	public class ConfigPhantomDirectRefiningById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600276A RID: 10090 RVA: 0x00138927 File Offset: 0x00136B27
		static ConfigPhantomDirectRefiningById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomDirectRefiningById.CreateStaticDefaultValue), new Action(ConfigPhantomDirectRefiningById.ResetStaticDefaultValue));
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00138948 File Offset: 0x00136B48
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

		// Token: 0x0600276C RID: 10092 RVA: 0x001389C7 File Offset: 0x00136BC7
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomDirectRefiningById.LogPair = null;
			ConfigPhantomDirectRefiningById.HandleId = 0;
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x001389D5 File Offset: 0x00136BD5
		public static void Init()
		{
			ConfigPhantomDirectRefiningById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomDirectRefiningById.HandleId, "db_calabash.db", "select BinData from `PhantomDirectRefining` where Id=?");
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x001389F0 File Offset: 0x00136BF0
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

		// Token: 0x04002DCF RID: 11727
		private const string DB = "db_calabash.db";

		// Token: 0x04002DD0 RID: 11728
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x04002DD1 RID: 11729
		private const string TABLE = "PhantomDirectRefining";

		// Token: 0x04002DD2 RID: 11730
		private const string COMMAND = "select BinData from `PhantomDirectRefining` where Id=?";

		// Token: 0x04002DD3 RID: 11731
		private const string KEY_PREFIX = "PhantomDirectRefiningById";

		// Token: 0x04002DD4 RID: 11732
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002DD5 RID: 11733
		private static int HandleId;
	}
}
