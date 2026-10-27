using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C6 RID: 1478
	public class ConfigMotorStickerById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022B1 RID: 8881 RVA: 0x0011DA9C File Offset: 0x0011BC9C
		static ConfigMotorStickerById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorStickerById.CreateStaticDefaultValue), new Action(ConfigMotorStickerById.ResetStaticDefaultValue));
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x0011DABC File Offset: 0x0011BCBC
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

		// Token: 0x060022B3 RID: 8883 RVA: 0x0011DB3B File Offset: 0x0011BD3B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorStickerById.LogPair = null;
			ConfigMotorStickerById.HandleId = 0;
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x0011DB49 File Offset: 0x0011BD49
		public static void Init()
		{
			ConfigMotorStickerById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorStickerById.HandleId, "db_motordiy.db", "select BinData from `MotorSticker` where Id=?");
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x0011DB64 File Offset: 0x0011BD64
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

		// Token: 0x0400284E RID: 10318
		private const string DB = "db_motordiy.db";

		// Token: 0x0400284F RID: 10319
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x04002850 RID: 10320
		private const string TABLE = "MotorSticker";

		// Token: 0x04002851 RID: 10321
		private const string COMMAND = "select BinData from `MotorSticker` where Id=?";

		// Token: 0x04002852 RID: 10322
		private const string KEY_PREFIX = "MotorStickerById";

		// Token: 0x04002853 RID: 10323
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002854 RID: 10324
		private static int HandleId;
	}
}
