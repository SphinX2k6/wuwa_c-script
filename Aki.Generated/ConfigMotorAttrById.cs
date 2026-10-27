using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000574 RID: 1396
	public class ConfigMotorAttrById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020C5 RID: 8389 RVA: 0x00112AB7 File Offset: 0x00110CB7
		static ConfigMotorAttrById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorAttrById.CreateStaticDefaultValue), new Action(ConfigMotorAttrById.ResetStaticDefaultValue));
		}

		// Token: 0x060020C6 RID: 8390 RVA: 0x00112AD8 File Offset: 0x00110CD8
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

		// Token: 0x060020C7 RID: 8391 RVA: 0x00112B57 File Offset: 0x00110D57
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorAttrById.LogPair = null;
			ConfigMotorAttrById.HandleId = 0;
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x00112B65 File Offset: 0x00110D65
		public static void Init()
		{
			ConfigMotorAttrById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorAttrById.HandleId, "db_motor.db", "select BinData from `MotorAttr` where Id=?");
		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x00112B80 File Offset: 0x00110D80
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

		// Token: 0x04002610 RID: 9744
		private const string DB = "db_motor.db";

		// Token: 0x04002611 RID: 9745
		private const string FILE = "m.摩托车.xlsx";

		// Token: 0x04002612 RID: 9746
		private const string TABLE = "MotorAttr";

		// Token: 0x04002613 RID: 9747
		private const string COMMAND = "select BinData from `MotorAttr` where Id=?";

		// Token: 0x04002614 RID: 9748
		private const string KEY_PREFIX = "MotorAttrById";

		// Token: 0x04002615 RID: 9749
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002616 RID: 9750
		private static int HandleId;
	}
}
