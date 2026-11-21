using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003E6 RID: 998
	public class ConfigHeadIconById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600176B RID: 5995 RVA: 0x000E16E0 File Offset: 0x000DF8E0
		static ConfigHeadIconById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHeadIconById.CreateStaticDefaultValue), new Action(ConfigHeadIconById.ResetStaticDefaultValue));
		}

		// Token: 0x0600176C RID: 5996 RVA: 0x000E1700 File Offset: 0x000DF900
		public static void CreateStaticDefaultValue()
		{
			ConfigHeadIconById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHeadIconById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_head_icon.db"),
				new ValueTuple<string, object>("文件", "t.头像.xlsx"),
				new ValueTuple<string, object>("表名", "HeadIcon"),
				new ValueTuple<string, object>("语句", "select BinData from `HeadIcon` where Id=?")
			});
		}

		// Token: 0x0600176D RID: 5997 RVA: 0x000E177F File Offset: 0x000DF97F
		public static void ResetStaticDefaultValue()
		{
			ConfigHeadIconById.LogPair = null;
			ConfigHeadIconById.HandleId = 0;
		}

		// Token: 0x0600176E RID: 5998 RVA: 0x000E178D File Offset: 0x000DF98D
		public static void Init()
		{
			ConfigHeadIconById.HandleId = ConfigCommon.InitDataStatement(ConfigHeadIconById.HandleId, "db_head_icon.db", "select BinData from `HeadIcon` where Id=?");
		}

		// Token: 0x0600176F RID: 5999 RVA: 0x000E17A8 File Offset: 0x000DF9A8
		public static HeadIcon? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigHeadIconById.HandleId, ConfigHeadIconById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HeadIconById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new HeadIcon?(HeadIcon.GetRootAsHeadIcon(configBuffer));
				}
			}
			ConfigHeadIconById.LogPair.Clear();
			ConfigHeadIconById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigHeadIconById.HandleId, 1, p0Id, ConfigHeadIconById.LogPair) || ConfigCommon.Step(ConfigHeadIconById.HandleId, true, ConfigHeadIconById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigHeadIconById.HandleId, ConfigHeadIconById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigHeadIconById.HandleId, 0, ConfigHeadIconById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigHeadIconById.HandleId, ConfigHeadIconById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			HeadIcon rootAsHeadIcon = HeadIcon.GetRootAsHeadIcon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("HeadIconById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigHeadIconById.HandleId, ConfigHeadIconById.LogPair);
			return new HeadIcon?(rootAsHeadIcon);
		}

		// Token: 0x04001B2E RID: 6958
		private const string DB = "db_head_icon.db";

		// Token: 0x04001B2F RID: 6959
		private const string FILE = "t.头像.xlsx";

		// Token: 0x04001B30 RID: 6960
		private const string TABLE = "HeadIcon";

		// Token: 0x04001B31 RID: 6961
		private const string COMMAND = "select BinData from `HeadIcon` where Id=?";

		// Token: 0x04001B32 RID: 6962
		private const string KEY_PREFIX = "HeadIconById";

		// Token: 0x04001B33 RID: 6963
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001B34 RID: 6964
		private static int HandleId;
	}
}
