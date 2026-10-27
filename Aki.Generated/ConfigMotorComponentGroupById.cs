using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000575 RID: 1397
	public class ConfigMotorComponentGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020CB RID: 8395 RVA: 0x00112D00 File Offset: 0x00110F00
		static ConfigMotorComponentGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorComponentGroupById.CreateStaticDefaultValue), new Action(ConfigMotorComponentGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00112D20 File Offset: 0x00110F20
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorComponentGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorComponentGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motordiy.db"),
				new ValueTuple<string, object>("文件", "m.摩托车自定义.xlsx"),
				new ValueTuple<string, object>("表名", "MotorComponentGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorComponentGroup` where Id=?")
			});
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00112D9F File Offset: 0x00110F9F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorComponentGroupById.LogPair = null;
			ConfigMotorComponentGroupById.HandleId = 0;
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00112DAD File Offset: 0x00110FAD
		public static void Init()
		{
			ConfigMotorComponentGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorComponentGroupById.HandleId, "db_motordiy.db", "select BinData from `MotorComponentGroup` where Id=?");
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00112DC8 File Offset: 0x00110FC8
		public static MotorComponentGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorComponentGroupById.HandleId, ConfigMotorComponentGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorComponentGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorComponentGroup?(MotorComponentGroup.GetRootAsMotorComponentGroup(configBuffer));
				}
			}
			ConfigMotorComponentGroupById.LogPair.Clear();
			ConfigMotorComponentGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorComponentGroupById.HandleId, 1, p0Id, ConfigMotorComponentGroupById.LogPair) || ConfigCommon.Step(ConfigMotorComponentGroupById.HandleId, true, ConfigMotorComponentGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorComponentGroupById.HandleId, ConfigMotorComponentGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorComponentGroupById.HandleId, 0, ConfigMotorComponentGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorComponentGroupById.HandleId, ConfigMotorComponentGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorComponentGroup rootAsMotorComponentGroup = MotorComponentGroup.GetRootAsMotorComponentGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorComponentGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorComponentGroupById.HandleId, ConfigMotorComponentGroupById.LogPair);
			return new MotorComponentGroup?(rootAsMotorComponentGroup);
		}

		// Token: 0x04002617 RID: 9751
		private const string DB = "db_motordiy.db";

		// Token: 0x04002618 RID: 9752
		private const string FILE = "m.摩托车自定义.xlsx";

		// Token: 0x04002619 RID: 9753
		private const string TABLE = "MotorComponentGroup";

		// Token: 0x0400261A RID: 9754
		private const string COMMAND = "select BinData from `MotorComponentGroup` where Id=?";

		// Token: 0x0400261B RID: 9755
		private const string KEY_PREFIX = "MotorComponentGroupById";

		// Token: 0x0400261C RID: 9756
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400261D RID: 9757
		private static int HandleId;
	}
}
