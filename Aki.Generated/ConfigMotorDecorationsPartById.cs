using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200057E RID: 1406
	public class ConfigMotorDecorationsPartById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002101 RID: 8449 RVA: 0x001140B4 File Offset: 0x001122B4
		static ConfigMotorDecorationsPartById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorDecorationsPartById.CreateStaticDefaultValue), new Action(ConfigMotorDecorationsPartById.ResetStaticDefaultValue));
		}

		// Token: 0x06002102 RID: 8450 RVA: 0x001140D4 File Offset: 0x001122D4
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

		// Token: 0x06002103 RID: 8451 RVA: 0x00114153 File Offset: 0x00112353
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorDecorationsPartById.LogPair = null;
			ConfigMotorDecorationsPartById.HandleId = 0;
		}

		// Token: 0x06002104 RID: 8452 RVA: 0x00114161 File Offset: 0x00112361
		public static void Init()
		{
			ConfigMotorDecorationsPartById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorDecorationsPartById.HandleId, "db_motordiy.db", "select BinData from `MotorDecorationsPart` where Id=?");
		}

		// Token: 0x06002105 RID: 8453 RVA: 0x0011417C File Offset: 0x0011237C
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

		// Token: 0x04002656 RID: 9814
		private const string DB = "db_motordiy.db";

		// Token: 0x04002657 RID: 9815
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x04002658 RID: 9816
		private const string TABLE = "MotorDecorationsPart";

		// Token: 0x04002659 RID: 9817
		private const string COMMAND = "select BinData from `MotorDecorationsPart` where Id=?";

		// Token: 0x0400265A RID: 9818
		private const string KEY_PREFIX = "MotorDecorationsPartById";

		// Token: 0x0400265B RID: 9819
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400265C RID: 9820
		private static int HandleId;
	}
}
