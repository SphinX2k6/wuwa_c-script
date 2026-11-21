using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005DE RID: 1502
	public class ConfigMotorStickerById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002341 RID: 9025 RVA: 0x00124517 File Offset: 0x00122717
		static ConfigMotorStickerById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorStickerById.CreateStaticDefaultValue), new Action(ConfigMotorStickerById.ResetStaticDefaultValue));
		}

		// Token: 0x06002342 RID: 9026 RVA: 0x00124538 File Offset: 0x00122738
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorStickerById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorStickerById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorSticker"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorSticker` where Id=?")
			});
		}

		// Token: 0x06002343 RID: 9027 RVA: 0x001245B7 File Offset: 0x001227B7
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorStickerById.LogPair = null;
			ConfigMotorStickerById.HandleId = 0;
		}

		// Token: 0x06002344 RID: 9028 RVA: 0x001245C5 File Offset: 0x001227C5
		public static void Init()
		{
			ConfigMotorStickerById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorStickerById.HandleId, "db_motordiy.db", "select BinData from `MotorSticker` where Id=?");
		}

		// Token: 0x06002345 RID: 9029 RVA: 0x001245E0 File Offset: 0x001227E0
		public static MotorSticker? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorStickerById.HandleId, ConfigMotorStickerById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorStickerById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorSticker?(MotorSticker.GetRootAsMotorSticker(configBuffer));
				}
			}
			ConfigMotorStickerById.LogPair.Clear();
			ConfigMotorStickerById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorStickerById.HandleId, 1, p0Id, ConfigMotorStickerById.LogPair) || ConfigCommon.Step(ConfigMotorStickerById.HandleId, true, ConfigMotorStickerById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorStickerById.HandleId, ConfigMotorStickerById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorStickerById.HandleId, 0, ConfigMotorStickerById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorStickerById.HandleId, ConfigMotorStickerById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorSticker rootAsMotorSticker = MotorSticker.GetRootAsMotorSticker(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorStickerById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorStickerById.HandleId, ConfigMotorStickerById.LogPair);
			return new MotorSticker?(rootAsMotorSticker);
		}

		// Token: 0x040028F6 RID: 10486
		private const string DB = "db_motordiy.db";

		// Token: 0x040028F7 RID: 10487
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x040028F8 RID: 10488
		private const string TABLE = "MotorSticker";

		// Token: 0x040028F9 RID: 10489
		private const string COMMAND = "select BinData from `MotorSticker` where Id=?";

		// Token: 0x040028FA RID: 10490
		private const string KEY_PREFIX = "MotorStickerById";

		// Token: 0x040028FB RID: 10491
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028FC RID: 10492
		private static int HandleId;
	}
}
