using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200058A RID: 1418
	public class ConfigMotorAttrById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002149 RID: 8521 RVA: 0x0011920B File Offset: 0x0011740B
		static ConfigMotorAttrById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorAttrById.CreateStaticDefaultValue), new Action(ConfigMotorAttrById.ResetStaticDefaultValue));
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x0011922C File Offset: 0x0011742C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorAttrById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorAttrById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motor.db"),
				new ValueTuple<string, object>("文件", "m.摩托车.xlsx"),
				new ValueTuple<string, object>("表名", "MotorAttr"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorAttr` where Id=?")
			});
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x001192AB File Offset: 0x001174AB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorAttrById.LogPair = null;
			ConfigMotorAttrById.HandleId = 0;
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x001192B9 File Offset: 0x001174B9
		public static void Init()
		{
			ConfigMotorAttrById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorAttrById.HandleId, "db_motor.db", "select BinData from `MotorAttr` where Id=?");
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x001192D4 File Offset: 0x001174D4
		public static MotorAttr? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorAttrById.HandleId, ConfigMotorAttrById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorAttrById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorAttr?(MotorAttr.GetRootAsMotorAttr(configBuffer));
				}
			}
			ConfigMotorAttrById.LogPair.Clear();
			ConfigMotorAttrById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorAttrById.HandleId, 1, p0Id, ConfigMotorAttrById.LogPair) || ConfigCommon.Step(ConfigMotorAttrById.HandleId, true, ConfigMotorAttrById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorAttrById.HandleId, ConfigMotorAttrById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorAttrById.HandleId, 0, ConfigMotorAttrById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorAttrById.HandleId, ConfigMotorAttrById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorAttr rootAsMotorAttr = MotorAttr.GetRootAsMotorAttr(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorAttrById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorAttrById.HandleId, ConfigMotorAttrById.LogPair);
			return new MotorAttr?(rootAsMotorAttr);
		}

		// Token: 0x040026AA RID: 9898
		private const string DB = "db_motor.db";

		// Token: 0x040026AB RID: 9899
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x040026AC RID: 9900
		private const string TABLE = "MotorAttr";

		// Token: 0x040026AD RID: 9901
		private const string COMMAND = "select BinData from `MotorAttr` where Id=?";

		// Token: 0x040026AE RID: 9902
		private const string KEY_PREFIX = "MotorAttrById";

		// Token: 0x040026AF RID: 9903
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040026B0 RID: 9904
		private static int HandleId;
	}
}
