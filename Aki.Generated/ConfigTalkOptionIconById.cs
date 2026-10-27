using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009BF RID: 2495
	public class ConfigTalkOptionIconById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A8E RID: 14990 RVA: 0x001A4F08 File Offset: 0x001A3108
		static ConfigTalkOptionIconById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTalkOptionIconById.CreateStaticDefaultValue), new Action(ConfigTalkOptionIconById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x001A4F28 File Offset: 0x001A3128
		public static void CreateStaticDefaultValue()
		{
			ConfigTalkOptionIconById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTalkOptionIconById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_talkoptionicon.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/d.对话选项图标/*.csv*"),
				new ValueTuple<string, object>("表名", "TalkOptionIcon"),
				new ValueTuple<string, object>("语句", "select BinData from `TalkOptionIcon` where Id=?")
			});
		}

		// Token: 0x06003A90 RID: 14992 RVA: 0x001A4FA7 File Offset: 0x001A31A7
		public static void ResetStaticDefaultValue()
		{
			ConfigTalkOptionIconById.LogPair = null;
			ConfigTalkOptionIconById.HandleId = 0;
		}

		// Token: 0x06003A91 RID: 14993 RVA: 0x001A4FB5 File Offset: 0x001A31B5
		public static void Init()
		{
			ConfigTalkOptionIconById.HandleId = ConfigCommon.InitDataStatement(ConfigTalkOptionIconById.HandleId, "db_talkoptionicon.db", "select BinData from `TalkOptionIcon` where Id=?");
		}

		// Token: 0x06003A92 RID: 14994 RVA: 0x001A4FD0 File Offset: 0x001A31D0
		public static TalkOptionIcon? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTalkOptionIconById.HandleId, ConfigTalkOptionIconById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TalkOptionIconById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TalkOptionIcon?(TalkOptionIcon.GetRootAsTalkOptionIcon(configBuffer));
				}
			}
			ConfigTalkOptionIconById.LogPair.Clear();
			ConfigTalkOptionIconById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigTalkOptionIconById.HandleId, 1, p0Id, ConfigTalkOptionIconById.LogPair) || ConfigCommon.Step(ConfigTalkOptionIconById.HandleId, true, ConfigTalkOptionIconById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTalkOptionIconById.HandleId, ConfigTalkOptionIconById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTalkOptionIconById.HandleId, 0, ConfigTalkOptionIconById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTalkOptionIconById.HandleId, ConfigTalkOptionIconById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TalkOptionIcon rootAsTalkOptionIcon = TalkOptionIcon.GetRootAsTalkOptionIcon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TalkOptionIconById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTalkOptionIconById.HandleId, ConfigTalkOptionIconById.LogPair);
			return new TalkOptionIcon?(rootAsTalkOptionIcon);
		}

		// Token: 0x0400441F RID: 17439
		private const string DB = "db_talkoptionicon.db";

		// Token: 0x04004420 RID: 17440
		private const string FILE = "k.可视化编辑/c.Csv/d.对话选项图标/*.csv*";

		// Token: 0x04004421 RID: 17441
		private const string TABLE = "TalkOptionIcon";

		// Token: 0x04004422 RID: 17442
		private const string COMMAND = "select BinData from `TalkOptionIcon` where Id=?";

		// Token: 0x04004423 RID: 17443
		private const string KEY_PREFIX = "TalkOptionIconById";

		// Token: 0x04004424 RID: 17444
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004425 RID: 17445
		private static int HandleId;
	}
}
