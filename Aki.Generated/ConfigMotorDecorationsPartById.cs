using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000595 RID: 1429
	public class ConfigMotorDecorationsPartById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600218B RID: 8587 RVA: 0x0011A99C File Offset: 0x00118B9C
		static ConfigMotorDecorationsPartById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDecorationsPartById.CreateStaticDefaultValue), new Action(ConfigMotorDecorationsPartById.ResetStaticDefaultValue));
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x0011A9BC File Offset: 0x00118BBC
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorDecorationsPartById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorDecorationsPartById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorDecorationsPart"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorDecorationsPart` where Id=?")
			});
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x0011AA3B File Offset: 0x00118C3B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDecorationsPartById.LogPair = null;
			ConfigMotorDecorationsPartById.HandleId = 0;
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x0011AA49 File Offset: 0x00118C49
		public static void Init()
		{
			ConfigMotorDecorationsPartById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDecorationsPartById.HandleId, "db_motordiy.db", "select BinData from `MotorDecorationsPart` where Id=?");
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x0011AA64 File Offset: 0x00118C64
		public static MotorDecorationsPart? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorDecorationsPartById.HandleId, ConfigMotorDecorationsPartById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecorationsPartById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorDecorationsPart?(MotorDecorationsPart.GetRootAsMotorDecorationsPart(configBuffer));
				}
			}
			ConfigMotorDecorationsPartById.LogPair.Clear();
			ConfigMotorDecorationsPartById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorDecorationsPartById.HandleId, 1, p0Id, ConfigMotorDecorationsPartById.LogPair) || ConfigCommon.Step(ConfigMotorDecorationsPartById.HandleId, true, ConfigMotorDecorationsPartById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorDecorationsPartById.HandleId, ConfigMotorDecorationsPartById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorDecorationsPartById.HandleId, 0, ConfigMotorDecorationsPartById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorDecorationsPartById.HandleId, ConfigMotorDecorationsPartById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorDecorationsPart rootAsMotorDecorationsPart = MotorDecorationsPart.GetRootAsMotorDecorationsPart(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecorationsPartById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorDecorationsPartById.HandleId, ConfigMotorDecorationsPartById.LogPair);
			return new MotorDecorationsPart?(rootAsMotorDecorationsPart);
		}

		// Token: 0x040026F7 RID: 9975
		private const string DB = "db_motordiy.db";

		// Token: 0x040026F8 RID: 9976
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x040026F9 RID: 9977
		private const string TABLE = "MotorDecorationsPart";

		// Token: 0x040026FA RID: 9978
		private const string COMMAND = "select BinData from `MotorDecorationsPart` where Id=?";

		// Token: 0x040026FB RID: 9979
		private const string KEY_PREFIX = "MotorDecorationsPartById";

		// Token: 0x040026FC RID: 9980
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026FD RID: 9981
		private static int HandleId;
	}
}
