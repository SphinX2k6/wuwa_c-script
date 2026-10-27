using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000633 RID: 1587
	public class ConfigOverlayAbpMontageDataById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002542 RID: 9538 RVA: 0x0012C524 File Offset: 0x0012A724
		static ConfigOverlayAbpMontageDataById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOverlayAbpMontageDataById.CreateStaticDefaultValue), new Action(ConfigOverlayAbpMontageDataById.ResetStaticDefaultValue));
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x0012C544 File Offset: 0x0012A744
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

		// Token: 0x06002544 RID: 9540 RVA: 0x0012C5C3 File Offset: 0x0012A7C3
		public static void ResetStaticDefaultValue()
		{
			ConfigOverlayAbpMontageDataById.LogPair = null;
			ConfigOverlayAbpMontageDataById.HandleId = 0;
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x0012C5D1 File Offset: 0x0012A7D1
		public static void Init()
		{
			ConfigOverlayAbpMontageDataById.HandleId = ConfigCommon.InitDataStatement(ConfigOverlayAbpMontageDataById.HandleId, "db_overlayabpmontagedata.db", "select BinData from `OverlayAbpMontageData` where Id=?");
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x0012C5EC File Offset: 0x0012A7EC
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

		// Token: 0x04002B4B RID: 11083
		private const string DB = "db_overlayabpmontagedata.db";

		// Token: 0x04002B4C RID: 11084
		private const string FILE = "k.可视化编辑/c.Csv/a.ABP叠加蒙太奇映射表/*.csv*";

		// Token: 0x04002B4D RID: 11085
		private const string TABLE = "OverlayAbpMontageData";

		// Token: 0x04002B4E RID: 11086
		private const string COMMAND = "select BinData from `OverlayAbpMontageData` where Id=?";

		// Token: 0x04002B4F RID: 11087
		private const string KEY_PREFIX = "OverlayAbpMontageDataById";

		// Token: 0x04002B50 RID: 11088
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B51 RID: 11089
		private static int HandleId;
	}
}
