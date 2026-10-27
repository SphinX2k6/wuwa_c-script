using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200057D RID: 1405
	public class ConfigMotorDecorationsById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020FB RID: 8443 RVA: 0x00113E6C File Offset: 0x0011206C
		static ConfigMotorDecorationsById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDecorationsById.CreateStaticDefaultValue), new Action(ConfigMotorDecorationsById.ResetStaticDefaultValue));
		}

		// Token: 0x060020FC RID: 8444 RVA: 0x00113E8C File Offset: 0x0011208C
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

		// Token: 0x060020FD RID: 8445 RVA: 0x00113F0B File Offset: 0x0011210B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDecorationsById.LogPair = null;
			ConfigMotorDecorationsById.HandleId = 0;
		}

		// Token: 0x060020FE RID: 8446 RVA: 0x00113F19 File Offset: 0x00112119
		public static void Init()
		{
			ConfigMotorDecorationsById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDecorationsById.HandleId, "db_motordiy.db", "select BinData from `MotorDecorations` where Id=?");
		}

		// Token: 0x060020FF RID: 8447 RVA: 0x00113F34 File Offset: 0x00112134
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

		// Token: 0x0400264F RID: 9807
		private const string DB = "db_motordiy.db";

		// Token: 0x04002650 RID: 9808
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x04002651 RID: 9809
		private const string TABLE = "MotorDecorations";

		// Token: 0x04002652 RID: 9810
		private const string COMMAND = "select BinData from `MotorDecorations` where Id=?";

		// Token: 0x04002653 RID: 9811
		private const string KEY_PREFIX = "MotorDecorationsById";

		// Token: 0x04002654 RID: 9812
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002655 RID: 9813
		private static int HandleId;
	}
}
