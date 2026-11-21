using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200019E RID: 414
	public class ConfigCommunicateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009B6 RID: 2486 RVA: 0x00093FA4 File Offset: 0x000921A4
		static ConfigCommunicateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommunicateById.CreateStaticDefaultValue), new Action(ConfigCommunicateById.ResetStaticDefaultValue));
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00093FC4 File Offset: 0x000921C4
		public static void CreateStaticDefaultValue()
		{
			ConfigCommunicateById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCommunicateById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_communicate.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/t.通讯/*.csv*"),
				new ValueTuple<string, object>("表名", "Communicate"),
				new ValueTuple<string, object>("语句", "select BinData from `Communicate` where Id=?")
			});
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00094043 File Offset: 0x00092243
		public static void ResetStaticDefaultValue()
		{
			ConfigCommunicateById.LogPair = null;
			ConfigCommunicateById.HandleId = 0;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x00094051 File Offset: 0x00092251
		public static void Init()
		{
			ConfigCommunicateById.HandleId = ConfigCommon.InitDataStatement(ConfigCommunicateById.HandleId, "db_communicate.db", "select BinData from `Communicate` where Id=?");
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0009406C File Offset: 0x0009226C
		public static Communicate? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCommunicateById.HandleId, ConfigCommunicateById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommunicateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Communicate?(Communicate.GetRootAsCommunicate(configBuffer));
				}
			}
			ConfigCommunicateById.LogPair.Clear();
			ConfigCommunicateById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCommunicateById.HandleId, 1, p0Id, ConfigCommunicateById.LogPair) || ConfigCommon.Step(ConfigCommunicateById.HandleId, true, ConfigCommunicateById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCommunicateById.HandleId, ConfigCommunicateById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCommunicateById.HandleId, 0, ConfigCommunicateById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCommunicateById.HandleId, ConfigCommunicateById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Communicate rootAsCommunicate = Communicate.GetRootAsCommunicate(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CommunicateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCommunicateById.HandleId, ConfigCommunicateById.LogPair);
			return new Communicate?(rootAsCommunicate);
		}

		// Token: 0x04000B36 RID: 2870
		private const string DB = "db_communicate.db";

		// Token: 0x04000B37 RID: 2871
		private const string FILE = "k.可视化编辑/c.Csv/t.通讯/*.csv*";

		// Token: 0x04000B38 RID: 2872
		private const string TABLE = "Communicate";

		// Token: 0x04000B39 RID: 2873
		private const string COMMAND = "select BinData from `Communicate` where Id=?";

		// Token: 0x04000B3A RID: 2874
		private const string KEY_PREFIX = "CommunicateById";

		// Token: 0x04000B3B RID: 2875
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B3C RID: 2876
		private static int HandleId;
	}
}
