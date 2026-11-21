using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000594 RID: 1428
	public class ConfigMotorDecorationsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002185 RID: 8581 RVA: 0x0011A753 File Offset: 0x00118953
		static ConfigMotorDecorationsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDecorationsById.CreateStaticDefaultValue), new Action(ConfigMotorDecorationsById.ResetStaticDefaultValue));
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x0011A774 File Offset: 0x00118974
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorDecorationsById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorDecorationsById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorDecorations"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorDecorations` where Id=?")
			});
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x0011A7F3 File Offset: 0x001189F3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDecorationsById.LogPair = null;
			ConfigMotorDecorationsById.HandleId = 0;
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x0011A801 File Offset: 0x00118A01
		public static void Init()
		{
			ConfigMotorDecorationsById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDecorationsById.HandleId, "db_motordiy.db", "select BinData from `MotorDecorations` where Id=?");
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x0011A81C File Offset: 0x00118A1C
		public static MotorDecorations? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorDecorationsById.HandleId, ConfigMotorDecorationsById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecorationsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorDecorations?(MotorDecorations.GetRootAsMotorDecorations(configBuffer));
				}
			}
			ConfigMotorDecorationsById.LogPair.Clear();
			ConfigMotorDecorationsById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorDecorationsById.HandleId, 1, p0Id, ConfigMotorDecorationsById.LogPair) || ConfigCommon.Step(ConfigMotorDecorationsById.HandleId, true, ConfigMotorDecorationsById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorDecorationsById.HandleId, ConfigMotorDecorationsById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorDecorationsById.HandleId, 0, ConfigMotorDecorationsById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorDecorationsById.HandleId, ConfigMotorDecorationsById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorDecorations rootAsMotorDecorations = MotorDecorations.GetRootAsMotorDecorations(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorDecorationsById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorDecorationsById.HandleId, ConfigMotorDecorationsById.LogPair);
			return new MotorDecorations?(rootAsMotorDecorations);
		}

		// Token: 0x040026F0 RID: 9968
		private const string DB = "db_motordiy.db";

		// Token: 0x040026F1 RID: 9969
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x040026F2 RID: 9970
		private const string TABLE = "MotorDecorations";

		// Token: 0x040026F3 RID: 9971
		private const string COMMAND = "select BinData from `MotorDecorations` where Id=?";

		// Token: 0x040026F4 RID: 9972
		private const string KEY_PREFIX = "MotorDecorationsById";

		// Token: 0x040026F5 RID: 9973
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026F6 RID: 9974
		private static int HandleId;
	}
}
