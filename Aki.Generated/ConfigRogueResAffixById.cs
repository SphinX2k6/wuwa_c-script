using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200084C RID: 2124
	public class ConfigRogueResAffixById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031DA RID: 12762 RVA: 0x00176BD8 File Offset: 0x00174DD8
		static ConfigRogueResAffixById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResAffixById.CreateStaticDefaultValue), new Action(ConfigRogueResAffixById.ResetStaticDefaultValue));
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x00176BF8 File Offset: 0x00174DF8
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResAffixById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResAffixById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResAffix"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResAffix` where Id=?")
			});
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x00176C77 File Offset: 0x00174E77
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResAffixById.LogPair = null;
			ConfigRogueResAffixById.HandleId = 0;
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x00176C85 File Offset: 0x00174E85
		public static void Init()
		{
			ConfigRogueResAffixById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResAffixById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResAffix` where Id=?");
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x00176CA0 File Offset: 0x00174EA0
		public static RogueResAffix? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResAffixById.HandleId, ConfigRogueResAffixById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResAffixById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResAffix?(RogueResAffix.GetRootAsRogueResAffix(configBuffer));
				}
			}
			ConfigRogueResAffixById.LogPair.Clear();
			ConfigRogueResAffixById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResAffixById.HandleId, 1, p0Id, ConfigRogueResAffixById.LogPair) || ConfigCommon.Step(ConfigRogueResAffixById.HandleId, true, ConfigRogueResAffixById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResAffixById.HandleId, ConfigRogueResAffixById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResAffixById.HandleId, 0, ConfigRogueResAffixById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResAffixById.HandleId, ConfigRogueResAffixById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResAffix rootAsRogueResAffix = RogueResAffix.GetRootAsRogueResAffix(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResAffixById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResAffixById.HandleId, ConfigRogueResAffixById.LogPair);
			return new RogueResAffix?(rootAsRogueResAffix);
		}

		// Token: 0x040039FA RID: 14842
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040039FB RID: 14843
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040039FC RID: 14844
		private const string TABLE = "RogueResAffix";

		// Token: 0x040039FD RID: 14845
		private const string COMMAND = "select BinData from `RogueResAffix` where Id=?";

		// Token: 0x040039FE RID: 14846
		private const string KEY_PREFIX = "RogueResAffixById";

		// Token: 0x040039FF RID: 14847
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A00 RID: 14848
		private static int HandleId;
	}
}
