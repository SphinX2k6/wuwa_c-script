using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000531 RID: 1329
	public class ConfigMapMarkByRelativeMainSubType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001F31 RID: 7985 RVA: 0x0010D12D File Offset: 0x0010B32D
		static ConfigMapMarkByRelativeMainSubType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkByRelativeMainSubType.CreateStaticDefaultValue), new Action(ConfigMapMarkByRelativeMainSubType.ResetStaticDefaultValue));
		}

		// Token: 0x06001F32 RID: 7986 RVA: 0x0010D14C File Offset: 0x0010B34C
		public static void CreateStaticDefaultValue()
		{
			ConfigMapMarkByRelativeMainSubType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMapMarkByRelativeMainSubType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_map_mark.db"),
				new ValueTuple<string, object>("文件", "d.地图标记.xlsx"),
				new ValueTuple<string, object>("表名", "MapMark"),
				new ValueTuple<string, object>("语句", "select BinData from `MapMark` where RelativeType=? and RelativeSubType=?")
			});
		}

		// Token: 0x06001F33 RID: 7987 RVA: 0x0010D1CB File Offset: 0x0010B3CB
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkByRelativeMainSubType.LogPair = null;
			ConfigMapMarkByRelativeMainSubType.HandleId = 0;
		}

		// Token: 0x06001F34 RID: 7988 RVA: 0x0010D1D9 File Offset: 0x0010B3D9
		public static void Init()
		{
			ConfigMapMarkByRelativeMainSubType.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkByRelativeMainSubType.HandleId, "db_map_mark.db", "select BinData from `MapMark` where RelativeType=? and RelativeSubType=?");
		}

		// Token: 0x06001F35 RID: 7989 RVA: 0x0010D1F4 File Offset: 0x0010B3F4
		public static MapMark? GetConfig(int p0RelativeType, int p1RelativeSubType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMapMarkByRelativeMainSubType.HandleId, ConfigMapMarkByRelativeMainSubType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkByRelativeMainSubType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RelativeType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1RelativeSubType);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MapMark?(MapMark.GetRootAsMapMark(configBuffer));
				}
			}
			ConfigMapMarkByRelativeMainSubType.LogPair.Clear();
			ConfigMapMarkByRelativeMainSubType.LogPair.Add(new ValueTuple<string, object>("RelativeType", p0RelativeType));
			ConfigMapMarkByRelativeMainSubType.LogPair.Add(new ValueTuple<string, object>("RelativeSubType", p1RelativeSubType));
			if (!ConfigCommon.BindInt(ConfigMapMarkByRelativeMainSubType.HandleId, 1, p0RelativeType, ConfigMapMarkByRelativeMainSubType.LogPair) || !ConfigCommon.BindInt(ConfigMapMarkByRelativeMainSubType.HandleId, 2, p1RelativeSubType, ConfigMapMarkByRelativeMainSubType.LogPair) || ConfigCommon.Step(ConfigMapMarkByRelativeMainSubType.HandleId, true, ConfigMapMarkByRelativeMainSubType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMapMarkByRelativeMainSubType.HandleId, ConfigMapMarkByRelativeMainSubType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMapMarkByRelativeMainSubType.HandleId, 0, ConfigMapMarkByRelativeMainSubType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMapMarkByRelativeMainSubType.HandleId, ConfigMapMarkByRelativeMainSubType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MapMark rootAsMapMark = MapMark.GetRootAsMapMark(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("MapMarkByRelativeMainSubType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RelativeType);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1RelativeSubType);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMapMarkByRelativeMainSubType.HandleId, ConfigMapMarkByRelativeMainSubType.LogPair);
			return new MapMark?(rootAsMapMark);
		}

		// Token: 0x0400243B RID: 9275
		private const string DB = "db_map_mark.db";

		// Token: 0x0400243C RID: 9276
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x0400243D RID: 9277
		private const string TABLE = "MapMark";

		// Token: 0x0400243E RID: 9278
		private const string COMMAND = "select BinData from `MapMark` where RelativeType=? and RelativeSubType=?";

		// Token: 0x0400243F RID: 9279
		private const string KEY_PREFIX = "MapMarkByRelativeMainSubType";

		// Token: 0x04002440 RID: 9280
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002441 RID: 9281
		private static int HandleId;
	}
}
