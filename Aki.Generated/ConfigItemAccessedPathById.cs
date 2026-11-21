using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000469 RID: 1129
	public class ConfigItemAccessedPathById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A80 RID: 6784 RVA: 0x000F2D69 File Offset: 0x000F0F69
		static ConfigItemAccessedPathById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemAccessedPathById.CreateStaticDefaultValue), new Action(ConfigItemAccessedPathById.ResetStaticDefaultValue));
		}

		// Token: 0x06001A81 RID: 6785 RVA: 0x000F2D88 File Offset: 0x000F0F88
		public static void CreateStaticDefaultValue()
		{
			ConfigItemAccessedPathById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemAccessedPathById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giftpackage.db"),
				new ValueTuple<string, object>("文件", "l.礼包.xlsx"),
				new ValueTuple<string, object>("表名", "ItemAccessedPath"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemAccessedPath` where Id=?")
			});
		}

		// Token: 0x06001A82 RID: 6786 RVA: 0x000F2E07 File Offset: 0x000F1007
		public static void ResetStaticDefaultValue()
		{
			ConfigItemAccessedPathById.LogPair = null;
			ConfigItemAccessedPathById.HandleId = 0;
		}

		// Token: 0x06001A83 RID: 6787 RVA: 0x000F2E15 File Offset: 0x000F1015
		public static void Init()
		{
			ConfigItemAccessedPathById.HandleId = ConfigCommon.InitDataStatement(ConfigItemAccessedPathById.HandleId, "db_giftpackage.db", "select BinData from `ItemAccessedPath` where Id=?");
		}

		// Token: 0x06001A84 RID: 6788 RVA: 0x000F2E30 File Offset: 0x000F1030
		public static ItemAccessedPath? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemAccessedPathById.HandleId, ConfigItemAccessedPathById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemAccessedPathById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ItemAccessedPath?(ItemAccessedPath.GetRootAsItemAccessedPath(configBuffer));
				}
			}
			ConfigItemAccessedPathById.LogPair.Clear();
			ConfigItemAccessedPathById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigItemAccessedPathById.HandleId, 1, p0Id, ConfigItemAccessedPathById.LogPair) || ConfigCommon.Step(ConfigItemAccessedPathById.HandleId, false, ConfigItemAccessedPathById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigItemAccessedPathById.HandleId, ConfigItemAccessedPathById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemAccessedPathById.HandleId, 0, ConfigItemAccessedPathById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigItemAccessedPathById.HandleId, ConfigItemAccessedPathById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ItemAccessedPath rootAsItemAccessedPath = ItemAccessedPath.GetRootAsItemAccessedPath(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemAccessedPathById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigItemAccessedPathById.HandleId, ConfigItemAccessedPathById.LogPair);
			return new ItemAccessedPath?(rootAsItemAccessedPath);
		}

		// Token: 0x04001EC3 RID: 7875
		private const string DB = "db_giftpackage.db";

		// Token: 0x04001EC4 RID: 7876
		private const string FILE = "l.礼包.xlsx";

		// Token: 0x04001EC5 RID: 7877
		private const string TABLE = "ItemAccessedPath";

		// Token: 0x04001EC6 RID: 7878
		private const string COMMAND = "select BinData from `ItemAccessedPath` where Id=?";

		// Token: 0x04001EC7 RID: 7879
		private const string KEY_PREFIX = "ItemAccessedPathById";

		// Token: 0x04001EC8 RID: 7880
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EC9 RID: 7881
		private static int HandleId;
	}
}
