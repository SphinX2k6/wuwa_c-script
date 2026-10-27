using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000845 RID: 2117
	public class ConfigRogueResEventBgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031B0 RID: 12720 RVA: 0x00172608 File Offset: 0x00170808
		static ConfigRogueResEventBgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResEventBgById.CreateStaticDefaultValue), new Action(ConfigRogueResEventBgById.ResetStaticDefaultValue));
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x00172628 File Offset: 0x00170828
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResEventBgById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResEventBgById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResEventBg"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResEventBg` where Id=?")
			});
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x001726A7 File Offset: 0x001708A7
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResEventBgById.LogPair = null;
			ConfigRogueResEventBgById.HandleId = 0;
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x001726B5 File Offset: 0x001708B5
		public static void Init()
		{
			ConfigRogueResEventBgById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResEventBgById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResEventBg` where Id=?");
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x001726D0 File Offset: 0x001708D0
		public static RogueResEventBg? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResEventBgById.HandleId, ConfigRogueResEventBgById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventBgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResEventBg?(RogueResEventBg.GetRootAsRogueResEventBg(configBuffer));
				}
			}
			ConfigRogueResEventBgById.LogPair.Clear();
			ConfigRogueResEventBgById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResEventBgById.HandleId, 1, p0Id, ConfigRogueResEventBgById.LogPair) || ConfigCommon.Step(ConfigRogueResEventBgById.HandleId, true, ConfigRogueResEventBgById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResEventBgById.HandleId, ConfigRogueResEventBgById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResEventBgById.HandleId, 0, ConfigRogueResEventBgById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResEventBgById.HandleId, ConfigRogueResEventBgById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResEventBg rootAsRogueResEventBg = RogueResEventBg.GetRootAsRogueResEventBg(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResEventBgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResEventBgById.HandleId, ConfigRogueResEventBgById.LogPair);
			return new RogueResEventBg?(rootAsRogueResEventBg);
		}

		// Token: 0x040039C9 RID: 14793
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040039CA RID: 14794
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040039CB RID: 14795
		private const string TABLE = "RogueResEventBg";

		// Token: 0x040039CC RID: 14796
		private const string COMMAND = "select BinData from `RogueResEventBg` where Id=?";

		// Token: 0x040039CD RID: 14797
		private const string KEY_PREFIX = "RogueResEventBgById";

		// Token: 0x040039CE RID: 14798
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040039CF RID: 14799
		private static int HandleId;
	}
}
