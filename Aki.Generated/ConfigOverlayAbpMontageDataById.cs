using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200064B RID: 1611
	public class ConfigOverlayAbpMontageDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025D2 RID: 9682 RVA: 0x00132FA0 File Offset: 0x001311A0
		static ConfigOverlayAbpMontageDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOverlayAbpMontageDataById.CreateStaticDefaultValue), new Action(ConfigOverlayAbpMontageDataById.ResetStaticDefaultValue));
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x00132FC0 File Offset: 0x001311C0
		public static void CreateStaticDefaultValue()
		{
			ConfigOverlayAbpMontageDataById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOverlayAbpMontageDataById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_overlayabpmontagedata.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/a.ABP叠加蒙太奇映射表/*.csv*"),
				new ValueTuple<string, object>("表名", "OverlayAbpMontageData"),
				new ValueTuple<string, object>("语句", "select BinData from `OverlayAbpMontageData` where Id=?")
			});
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x0013303F File Offset: 0x0013123F
		public static void ResetStaticDefaultValue()
		{
			ConfigOverlayAbpMontageDataById.LogPair = null;
			ConfigOverlayAbpMontageDataById.HandleId = 0;
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x0013304D File Offset: 0x0013124D
		public static void Init()
		{
			ConfigOverlayAbpMontageDataById.HandleId = ConfigCommon.InitDataStatement(ConfigOverlayAbpMontageDataById.HandleId, "db_overlayabpmontagedata.db", "select BinData from `OverlayAbpMontageData` where Id=?");
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x00133068 File Offset: 0x00131268
		public static OverlayAbpMontageData? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOverlayAbpMontageDataById.HandleId, ConfigOverlayAbpMontageDataById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OverlayAbpMontageDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new OverlayAbpMontageData?(OverlayAbpMontageData.GetRootAsOverlayAbpMontageData(configBuffer));
				}
			}
			ConfigOverlayAbpMontageDataById.LogPair.Clear();
			ConfigOverlayAbpMontageDataById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigOverlayAbpMontageDataById.HandleId, 1, p0Id, ConfigOverlayAbpMontageDataById.LogPair) || ConfigCommon.Step(ConfigOverlayAbpMontageDataById.HandleId, true, ConfigOverlayAbpMontageDataById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigOverlayAbpMontageDataById.HandleId, ConfigOverlayAbpMontageDataById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOverlayAbpMontageDataById.HandleId, 0, ConfigOverlayAbpMontageDataById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigOverlayAbpMontageDataById.HandleId, ConfigOverlayAbpMontageDataById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			OverlayAbpMontageData rootAsOverlayAbpMontageData = OverlayAbpMontageData.GetRootAsOverlayAbpMontageData(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OverlayAbpMontageDataById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigOverlayAbpMontageDataById.HandleId, ConfigOverlayAbpMontageDataById.LogPair);
			return new OverlayAbpMontageData?(rootAsOverlayAbpMontageData);
		}

		// Token: 0x04002BF3 RID: 11251
		private const string DB = "db_overlayabpmontagedata.db";

		// Token: 0x04002BF4 RID: 11252
		private const string FILE = "k.可视化编辑/c.Csv/a.ABP叠加蒙太奇映射表/*.csv*";

		// Token: 0x04002BF5 RID: 11253
		private const string TABLE = "OverlayAbpMontageData";

		// Token: 0x04002BF6 RID: 11254
		private const string COMMAND = "select BinData from `OverlayAbpMontageData` where Id=?";

		// Token: 0x04002BF7 RID: 11255
		private const string KEY_PREFIX = "OverlayAbpMontageDataById";

		// Token: 0x04002BF8 RID: 11256
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BF9 RID: 11257
		private static int HandleId;
	}
}
