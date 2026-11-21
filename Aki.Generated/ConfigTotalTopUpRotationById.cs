using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AC1 RID: 2753
	public class ConfigTotalTopUpRotationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600409A RID: 16538 RVA: 0x001CA14F File Offset: 0x001C834F
		static ConfigTotalTopUpRotationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTotalTopUpRotationById.CreateStaticDefaultValue), new Action(ConfigTotalTopUpRotationById.ResetStaticDefaultValue));
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x001CA170 File Offset: 0x001C8370
		public static void CreateStaticDefaultValue()
		{
			ConfigTotalTopUpRotationById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTotalTopUpRotationById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_totaltopup.db"),
				new ValueTuple<string, object>("文件", "l.累充活动.xlsx"),
				new ValueTuple<string, object>("表名", "TotalTopUpRotation"),
				new ValueTuple<string, object>("语句", "select BinData from `TotalTopUpRotation` where Id=?")
			});
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x001CA1EF File Offset: 0x001C83EF
		public static void ResetStaticDefaultValue()
		{
			ConfigTotalTopUpRotationById.LogPair = null;
			ConfigTotalTopUpRotationById.HandleId = 0;
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x001CA1FD File Offset: 0x001C83FD
		public static void Init()
		{
			ConfigTotalTopUpRotationById.HandleId = ConfigCommon.InitDataStatement(ConfigTotalTopUpRotationById.HandleId, "db_totaltopup.db", "select BinData from `TotalTopUpRotation` where Id=?");
		}

		// Token: 0x0600409E RID: 16542 RVA: 0x001CA218 File Offset: 0x001C8418
		public static TotalTopUpRotation? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTotalTopUpRotationById.HandleId, ConfigTotalTopUpRotationById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TotalTopUpRotationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TotalTopUpRotation?(TotalTopUpRotation.GetRootAsTotalTopUpRotation(configBuffer));
				}
			}
			ConfigTotalTopUpRotationById.LogPair.Clear();
			ConfigTotalTopUpRotationById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTotalTopUpRotationById.HandleId, 1, p0Id, ConfigTotalTopUpRotationById.LogPair) || ConfigCommon.Step(ConfigTotalTopUpRotationById.HandleId, true, ConfigTotalTopUpRotationById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTotalTopUpRotationById.HandleId, ConfigTotalTopUpRotationById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTotalTopUpRotationById.HandleId, 0, ConfigTotalTopUpRotationById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTotalTopUpRotationById.HandleId, ConfigTotalTopUpRotationById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TotalTopUpRotation rootAsTotalTopUpRotation = TotalTopUpRotation.GetRootAsTotalTopUpRotation(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TotalTopUpRotationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTotalTopUpRotationById.HandleId, ConfigTotalTopUpRotationById.LogPair);
			return new TotalTopUpRotation?(rootAsTotalTopUpRotation);
		}

		// Token: 0x04004B2D RID: 19245
		private const string DB = "db_totaltopup.db";

		// Token: 0x04004B2E RID: 19246
		private const string FILE = "l.累充活动.xlsx";

		// Token: 0x04004B2F RID: 19247
		private const string TABLE = "TotalTopUpRotation";

		// Token: 0x04004B30 RID: 19248
		private const string COMMAND = "select BinData from `TotalTopUpRotation` where Id=?";

		// Token: 0x04004B31 RID: 19249
		private const string KEY_PREFIX = "TotalTopUpRotationById";

		// Token: 0x04004B32 RID: 19250
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004B33 RID: 19251
		private static int HandleId;
	}
}
