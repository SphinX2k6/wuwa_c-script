using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A94 RID: 2708
	public class ConfigTalkOptionIconById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F8C RID: 16268 RVA: 0x001C429C File Offset: 0x001C249C
		static ConfigTalkOptionIconById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTalkOptionIconById.CreateStaticDefaultValue), new Action(ConfigTalkOptionIconById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F8D RID: 16269 RVA: 0x001C42BC File Offset: 0x001C24BC
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

		// Token: 0x06003F8E RID: 16270 RVA: 0x001C433B File Offset: 0x001C253B
		public static void ResetStaticDefaultValue()
		{
			ConfigTalkOptionIconById.LogPair = null;
			ConfigTalkOptionIconById.HandleId = 0;
		}

		// Token: 0x06003F8F RID: 16271 RVA: 0x001C4349 File Offset: 0x001C2549
		public static void Init()
		{
			ConfigTalkOptionIconById.HandleId = ConfigCommon.InitDataStatement(ConfigTalkOptionIconById.HandleId, "db_talkoptionicon.db", "select BinData from `TalkOptionIcon` where Id=?");
		}

		// Token: 0x06003F90 RID: 16272 RVA: 0x001C4364 File Offset: 0x001C2564
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

		// Token: 0x040049F2 RID: 18930
		private const string DB = "db_talkoptionicon.db";

		// Token: 0x040049F3 RID: 18931
		private const string FILE = "k.可视化编辑/c.Csv/d.对话选项图标/*.csv*";

		// Token: 0x040049F4 RID: 18932
		private const string TABLE = "TalkOptionIcon";

		// Token: 0x040049F5 RID: 18933
		private const string COMMAND = "select BinData from `TalkOptionIcon` where Id=?";

		// Token: 0x040049F6 RID: 18934
		private const string KEY_PREFIX = "TalkOptionIconById";

		// Token: 0x040049F7 RID: 18935
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049F8 RID: 18936
		private static int HandleId;
	}
}
