using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200051B RID: 1307
	public class ConfigMapMarkByRelativeMainSubType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EAD RID: 7853 RVA: 0x001069D9 File Offset: 0x00104BD9
		static ConfigMapMarkByRelativeMainSubType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMapMarkByRelativeMainSubType.CreateStaticDefaultValue), new Action(ConfigMapMarkByRelativeMainSubType.ResetStaticDefaultValue));
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x001069F8 File Offset: 0x00104BF8
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

		// Token: 0x06001EAF RID: 7855 RVA: 0x00106A77 File Offset: 0x00104C77
		public static void ResetStaticDefaultValue()
		{
			ConfigMapMarkByRelativeMainSubType.LogPair = null;
			ConfigMapMarkByRelativeMainSubType.HandleId = 0;
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x00106A85 File Offset: 0x00104C85
		public static void Init()
		{
			ConfigMapMarkByRelativeMainSubType.HandleId = ConfigCommon.InitDataStatement(ConfigMapMarkByRelativeMainSubType.HandleId, "db_map_mark.db", "select BinData from `MapMark` where RelativeType=? and RelativeSubType=?");
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x00106AA0 File Offset: 0x00104CA0
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

		// Token: 0x040023A1 RID: 9121
		private const string DB = "db_map_mark.db";

		// Token: 0x040023A2 RID: 9122
		private const string FILE = "d.地图标记.xlsx";

		// Token: 0x040023A3 RID: 9123
		private const string TABLE = "MapMark";

		// Token: 0x040023A4 RID: 9124
		private const string COMMAND = "select BinData from `MapMark` where RelativeType=? and RelativeSubType=?";

		// Token: 0x040023A5 RID: 9125
		private const string KEY_PREFIX = "MapMarkByRelativeMainSubType";

		// Token: 0x040023A6 RID: 9126
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023A7 RID: 9127
		private static int HandleId;
	}
}
