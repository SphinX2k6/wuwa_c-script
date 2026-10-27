using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C4 RID: 1476
	public class ConfigMotorSkinById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060022A5 RID: 8869 RVA: 0x0011D60B File Offset: 0x0011B80B
		static ConfigMotorSkinById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorSkinById.CreateStaticDefaultValue), new Action(ConfigMotorSkinById.ResetStaticDefaultValue));
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x0011D62C File Offset: 0x0011B82C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorSkinById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorSkinById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorSkin"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorSkin` where Id=?")
			});
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x0011D6AB File Offset: 0x0011B8AB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorSkinById.LogPair = null;
			ConfigMotorSkinById.HandleId = 0;
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x0011D6B9 File Offset: 0x0011B8B9
		public static void Init()
		{
			ConfigMotorSkinById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorSkinById.HandleId, "db_motordiy.db", "select BinData from `MotorSkin` where Id=?");
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x0011D6D4 File Offset: 0x0011B8D4
		public static MotorSkin? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorSkinById.HandleId, ConfigMotorSkinById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorSkinById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorSkin?(MotorSkin.GetRootAsMotorSkin(configBuffer));
				}
			}
			ConfigMotorSkinById.LogPair.Clear();
			ConfigMotorSkinById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorSkinById.HandleId, 1, p0Id, ConfigMotorSkinById.LogPair) || ConfigCommon.Step(ConfigMotorSkinById.HandleId, true, ConfigMotorSkinById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorSkinById.HandleId, ConfigMotorSkinById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorSkinById.HandleId, 0, ConfigMotorSkinById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorSkinById.HandleId, ConfigMotorSkinById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorSkin rootAsMotorSkin = MotorSkin.GetRootAsMotorSkin(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorSkinById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorSkinById.HandleId, ConfigMotorSkinById.LogPair);
			return new MotorSkin?(rootAsMotorSkin);
		}

		// Token: 0x04002840 RID: 10304
		private const string DB = "db_motordiy.db";

		// Token: 0x04002841 RID: 10305
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x04002842 RID: 10306
		private const string TABLE = "MotorSkin";

		// Token: 0x04002843 RID: 10307
		private const string COMMAND = "select BinData from `MotorSkin` where Id=?";

		// Token: 0x04002844 RID: 10308
		private const string KEY_PREFIX = "MotorSkinById";

		// Token: 0x04002845 RID: 10309
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002846 RID: 10310
		private static int HandleId;
	}
}
