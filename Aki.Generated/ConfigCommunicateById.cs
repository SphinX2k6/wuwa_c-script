using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200018C RID: 396
	public class ConfigCommunicateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600094A RID: 2378 RVA: 0x0008E06C File Offset: 0x0008C26C
		static ConfigCommunicateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommunicateById.CreateStaticDefaultValue), new Action(ConfigCommunicateById.ResetStaticDefaultValue));
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0008E08C File Offset: 0x0008C28C
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

		// Token: 0x0600094C RID: 2380 RVA: 0x0008E10B File Offset: 0x0008C30B
		public static void ResetStaticDefaultValue()
		{
			ConfigCommunicateById.LogPair = null;
			ConfigCommunicateById.HandleId = 0;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x0008E119 File Offset: 0x0008C319
		public static void Init()
		{
			ConfigCommunicateById.HandleId = ConfigCommon.InitDataStatement(ConfigCommunicateById.HandleId, "db_communicate.db", "select BinData from `Communicate` where Id=?");
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0008E134 File Offset: 0x0008C334
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

		// Token: 0x04000AB8 RID: 2744
		private const string DB = "db_communicate.db";

		// Token: 0x04000AB9 RID: 2745
		private const string FILE = "k.可视化编辑/c.Csv/t.通讯/*.csv*";

		// Token: 0x04000ABA RID: 2746
		private const string TABLE = "Communicate";

		// Token: 0x04000ABB RID: 2747
		private const string COMMAND = "select BinData from `Communicate` where Id=?";

		// Token: 0x04000ABC RID: 2748
		private const string KEY_PREFIX = "CommunicateById";

		// Token: 0x04000ABD RID: 2749
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000ABE RID: 2750
		private static int HandleId;
	}
}
