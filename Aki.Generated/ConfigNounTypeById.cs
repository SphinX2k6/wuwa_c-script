using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000618 RID: 1560
	public class ConfigNounTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024A0 RID: 9376 RVA: 0x00128A4F File Offset: 0x00126C4F
		static ConfigNounTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNounTypeById.CreateStaticDefaultValue), new Action(ConfigNounTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x060024A1 RID: 9377 RVA: 0x00128A70 File Offset: 0x00126C70
		public static void CreateStaticDefaultValue()
		{
			ConfigNounTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNounTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "NounType"),
				new ValueTuple<string, object>("语句", "select BinData from `NounType` where Id=?")
			});
		}

		// Token: 0x060024A2 RID: 9378 RVA: 0x00128AEF File Offset: 0x00126CEF
		public static void ResetStaticDefaultValue()
		{
			ConfigNounTypeById.LogPair = null;
			ConfigNounTypeById.HandleId = 0;
		}

		// Token: 0x060024A3 RID: 9379 RVA: 0x00128AFD File Offset: 0x00126CFD
		public static void Init()
		{
			ConfigNounTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigNounTypeById.HandleId, "db_handbook.db", "select BinData from `NounType` where Id=?");
		}

		// Token: 0x060024A4 RID: 9380 RVA: 0x00128B18 File Offset: 0x00126D18
		public static NounType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNounTypeById.HandleId, ConfigNounTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NounTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NounType?(NounType.GetRootAsNounType(configBuffer));
				}
			}
			ConfigNounTypeById.LogPair.Clear();
			ConfigNounTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNounTypeById.HandleId, 1, p0Id, ConfigNounTypeById.LogPair) || ConfigCommon.Step(ConfigNounTypeById.HandleId, true, ConfigNounTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNounTypeById.HandleId, ConfigNounTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNounTypeById.HandleId, 0, ConfigNounTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNounTypeById.HandleId, ConfigNounTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NounType rootAsNounType = NounType.GetRootAsNounType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NounTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNounTypeById.HandleId, ConfigNounTypeById.LogPair);
			return new NounType?(rootAsNounType);
		}

		// Token: 0x04002A8E RID: 10894
		private const string DB = "db_handbook.db";

		// Token: 0x04002A8F RID: 10895
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04002A90 RID: 10896
		private const string TABLE = "NounType";

		// Token: 0x04002A91 RID: 10897
		private const string COMMAND = "select BinData from `NounType` where Id=?";

		// Token: 0x04002A92 RID: 10898
		private const string KEY_PREFIX = "NounTypeById";

		// Token: 0x04002A93 RID: 10899
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A94 RID: 10900
		private static int HandleId;
	}
}
