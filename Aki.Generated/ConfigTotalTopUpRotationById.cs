using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009EC RID: 2540
	public class ConfigTotalTopUpRotationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B9C RID: 15260 RVA: 0x001AADBB File Offset: 0x001A8FBB
		static ConfigTotalTopUpRotationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTotalTopUpRotationById.CreateStaticDefaultValue), new Action(ConfigTotalTopUpRotationById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x001AADDC File Offset: 0x001A8FDC
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

		// Token: 0x06003B9E RID: 15262 RVA: 0x001AAE5B File Offset: 0x001A905B
		public static void ResetStaticDefaultValue()
		{
			ConfigTotalTopUpRotationById.LogPair = null;
			ConfigTotalTopUpRotationById.HandleId = 0;
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x001AAE69 File Offset: 0x001A9069
		public static void Init()
		{
			ConfigTotalTopUpRotationById.HandleId = ConfigCommon.InitDataStatement(ConfigTotalTopUpRotationById.HandleId, "db_totaltopup.db", "select BinData from `TotalTopUpRotation` where Id=?");
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x001AAE84 File Offset: 0x001A9084
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

		// Token: 0x0400455A RID: 17754
		private const string DB = "db_totaltopup.db";

		// Token: 0x0400455B RID: 17755
		private const string FILE = "l.累充活动.xlsx";

		// Token: 0x0400455C RID: 17756
		private const string TABLE = "TotalTopUpRotation";

		// Token: 0x0400455D RID: 17757
		private const string COMMAND = "select BinData from `TotalTopUpRotation` where Id=?";

		// Token: 0x0400455E RID: 17758
		private const string KEY_PREFIX = "TotalTopUpRotationById";

		// Token: 0x0400455F RID: 17759
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004560 RID: 17760
		private static int HandleId;
	}
}
