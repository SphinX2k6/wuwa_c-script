using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000131 RID: 305
	public class ConfigBuffById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000727 RID: 1831 RVA: 0x00085AFD File Offset: 0x00083CFD
		static ConfigBuffById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffById.CreateStaticDefaultValue), new Action(ConfigBuffById.ResetStaticDefaultValue));
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00085B1C File Offset: 0x00083D1C
		public static void CreateStaticDefaultValue()
		{
			ConfigBuffById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBuffById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_buff.db"),
				new ValueTuple<string, object>("文件", "b.Buff.xlsx"),
				new ValueTuple<string, object>("表名", "Buff"),
				new ValueTuple<string, object>("语句", "select BinData from `Buff` where Id=?")
			});
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00085B9B File Offset: 0x00083D9B
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffById.LogPair = null;
			ConfigBuffById.HandleId = 0;
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00085BA9 File Offset: 0x00083DA9
		public static void Init()
		{
			ConfigBuffById.HandleId = ConfigCommon.InitDataStatement(ConfigBuffById.HandleId, "db_buff.db", "select BinData from `Buff` where Id=?");
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00085BC4 File Offset: 0x00083DC4
		public static Buff? GetConfig(long p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBuffById.HandleId, ConfigBuffById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Buff?(Buff.GetRootAsBuff(configBuffer));
				}
			}
			ConfigBuffById.LogPair.Clear();
			ConfigBuffById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindFloat64(ConfigBuffById.HandleId, 1, (double)p0Id, ConfigBuffById.LogPair) || ConfigCommon.Step(ConfigBuffById.HandleId, true, ConfigBuffById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBuffById.HandleId, ConfigBuffById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBuffById.HandleId, 0, ConfigBuffById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBuffById.HandleId, ConfigBuffById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Buff rootAsBuff = Buff.GetRootAsBuff(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<long>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBuffById.HandleId, ConfigBuffById.LogPair);
			return new Buff?(rootAsBuff);
		}

		// Token: 0x0400083B RID: 2107
		private const string DB = "db_buff.db";

		// Token: 0x0400083C RID: 2108
		private const string FILE = "b.Buff.xlsx";

		// Token: 0x0400083D RID: 2109
		private const string TABLE = "Buff";

		// Token: 0x0400083E RID: 2110
		private const string COMMAND = "select BinData from `Buff` where Id=?";

		// Token: 0x0400083F RID: 2111
		private const string KEY_PREFIX = "BuffById";

		// Token: 0x04000840 RID: 2112
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000841 RID: 2113
		private static int HandleId;
	}
}
