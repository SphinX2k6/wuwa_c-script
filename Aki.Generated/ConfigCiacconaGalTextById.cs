using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200017C RID: 380
	public class ConfigCiacconaGalTextById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008E9 RID: 2281 RVA: 0x0008F680 File Offset: 0x0008D880
		static ConfigCiacconaGalTextById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalTextById.CreateStaticDefaultValue), new Action(ConfigCiacconaGalTextById.ResetStaticDefaultValue));
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x0008F6A0 File Offset: 0x0008D8A0
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaGalTextById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaGalTextById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaGalText"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaGalText` where Id=?")
			});
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x0008F71F File Offset: 0x0008D91F
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalTextById.LogPair = null;
			ConfigCiacconaGalTextById.HandleId = 0;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0008F72D File Offset: 0x0008D92D
		public static void Init()
		{
			ConfigCiacconaGalTextById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalTextById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalText` where Id=?");
		}

		// Token: 0x060008ED RID: 2285 RVA: 0x0008F748 File Offset: 0x0008D948
		public static CiacconaGalText? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaGalTextById.HandleId, ConfigCiacconaGalTextById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CiacconaGalText?(CiacconaGalText.GetRootAsCiacconaGalText(configBuffer));
				}
			}
			ConfigCiacconaGalTextById.LogPair.Clear();
			ConfigCiacconaGalTextById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCiacconaGalTextById.HandleId, 1, p0Id, ConfigCiacconaGalTextById.LogPair) || ConfigCommon.Step(ConfigCiacconaGalTextById.HandleId, true, ConfigCiacconaGalTextById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCiacconaGalTextById.HandleId, ConfigCiacconaGalTextById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaGalTextById.HandleId, 0, ConfigCiacconaGalTextById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCiacconaGalTextById.HandleId, ConfigCiacconaGalTextById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CiacconaGalText rootAsCiacconaGalText = CiacconaGalText.GetRootAsCiacconaGalText(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalTextById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCiacconaGalTextById.HandleId, ConfigCiacconaGalTextById.LogPair);
			return new CiacconaGalText?(rootAsCiacconaGalText);
		}

		// Token: 0x04000A48 RID: 2632
		private const string DB = "db_ciacconagal.db";

		// Token: 0x04000A49 RID: 2633
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x04000A4A RID: 2634
		private const string TABLE = "CiacconaGalText";

		// Token: 0x04000A4B RID: 2635
		private const string COMMAND = "select BinData from `CiacconaGalText` where Id=?";

		// Token: 0x04000A4C RID: 2636
		private const string KEY_PREFIX = "CiacconaGalTextById";

		// Token: 0x04000A4D RID: 2637
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A4E RID: 2638
		private static int HandleId;
	}
}
