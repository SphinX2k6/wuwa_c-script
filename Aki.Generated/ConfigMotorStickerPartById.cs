using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C7 RID: 1479
	public class ConfigMotorStickerPartById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022B7 RID: 8887 RVA: 0x0011DCE4 File Offset: 0x0011BEE4
		static ConfigMotorStickerPartById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorStickerPartById.CreateStaticDefaultValue), new Action(ConfigMotorStickerPartById.ResetStaticDefaultValue));
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x0011DD04 File Offset: 0x0011BF04
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

		// Token: 0x060022B9 RID: 8889 RVA: 0x0011DD83 File Offset: 0x0011BF83
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorStickerPartById.LogPair = null;
			ConfigMotorStickerPartById.HandleId = 0;
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x0011DD91 File Offset: 0x0011BF91
		public static void Init()
		{
			ConfigMotorStickerPartById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorStickerPartById.HandleId, "db_motordiy.db", "select BinData from `MotorStickerPart` where Id=?");
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x0011DDAC File Offset: 0x0011BFAC
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

		// Token: 0x04002855 RID: 10325
		private const string DB = "db_motordiy.db";

		// Token: 0x04002856 RID: 10326
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x04002857 RID: 10327
		private const string TABLE = "MotorStickerPart";

		// Token: 0x04002858 RID: 10328
		private const string COMMAND = "select BinData from `MotorStickerPart` where Id=?";

		// Token: 0x04002859 RID: 10329
		private const string KEY_PREFIX = "MotorStickerPartById";

		// Token: 0x0400285A RID: 10330
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400285B RID: 10331
		private static int HandleId;
	}
}
