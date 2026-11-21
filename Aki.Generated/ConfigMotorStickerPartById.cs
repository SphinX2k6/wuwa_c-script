using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005DF RID: 1503
	public class ConfigMotorStickerPartById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002347 RID: 9031 RVA: 0x00124760 File Offset: 0x00122960
		static ConfigMotorStickerPartById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorStickerPartById.CreateStaticDefaultValue), new Action(ConfigMotorStickerPartById.ResetStaticDefaultValue));
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x00124780 File Offset: 0x00122980
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorStickerPartById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorStickerPartById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorStickerPart"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorStickerPart` where Id=?")
			});
		}

		// Token: 0x06002349 RID: 9033 RVA: 0x001247FF File Offset: 0x001229FF
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorStickerPartById.LogPair = null;
			ConfigMotorStickerPartById.HandleId = 0;
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x0012480D File Offset: 0x00122A0D
		public static void Init()
		{
			ConfigMotorStickerPartById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorStickerPartById.HandleId, "db_motordiy.db", "select BinData from `MotorStickerPart` where Id=?");
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x00124828 File Offset: 0x00122A28
		public static MotorStickerPart? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorStickerPartById.HandleId, ConfigMotorStickerPartById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorStickerPartById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorStickerPart?(MotorStickerPart.GetRootAsMotorStickerPart(configBuffer));
				}
			}
			ConfigMotorStickerPartById.LogPair.Clear();
			ConfigMotorStickerPartById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorStickerPartById.HandleId, 1, p0Id, ConfigMotorStickerPartById.LogPair) || ConfigCommon.Step(ConfigMotorStickerPartById.HandleId, true, ConfigMotorStickerPartById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorStickerPartById.HandleId, ConfigMotorStickerPartById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorStickerPartById.HandleId, 0, ConfigMotorStickerPartById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorStickerPartById.HandleId, ConfigMotorStickerPartById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorStickerPart rootAsMotorStickerPart = MotorStickerPart.GetRootAsMotorStickerPart(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorStickerPartById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorStickerPartById.HandleId, ConfigMotorStickerPartById.LogPair);
			return new MotorStickerPart?(rootAsMotorStickerPart);
		}

		// Token: 0x040028FD RID: 10493
		private const string DB = "db_motordiy.db";

		// Token: 0x040028FE RID: 10494
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x040028FF RID: 10495
		private const string TABLE = "MotorStickerPart";

		// Token: 0x04002900 RID: 10496
		private const string COMMAND = "select BinData from `MotorStickerPart` where Id=?";

		// Token: 0x04002901 RID: 10497
		private const string KEY_PREFIX = "MotorStickerPartById";

		// Token: 0x04002902 RID: 10498
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002903 RID: 10499
		private static int HandleId;
	}
}
