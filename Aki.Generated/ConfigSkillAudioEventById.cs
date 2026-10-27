using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000931 RID: 2353
	public class ConfigSkillAudioEventById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003739 RID: 14137 RVA: 0x00191957 File Offset: 0x0018FB57
		static ConfigSkillAudioEventById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillAudioEventById.CreateStaticDefaultValue), new Action(ConfigSkillAudioEventById.ResetStaticDefaultValue));
		}

		// Token: 0x0600373A RID: 14138 RVA: 0x00191978 File Offset: 0x0018FB78
		public static void CreateStaticDefaultValue()
		{
			ConfigSkillAudioEventById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkillAudioEventById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skillaudioevent.db"),
				new ValueTuple<string, object>("文件", "y.音频_技能音频.xlsx"),
				new ValueTuple<string, object>("表名", "SkillAudioEvent"),
				new ValueTuple<string, object>("语句", "select BinData from `SkillAudioEvent` where Id=?")
			});
		}

		// Token: 0x0600373B RID: 14139 RVA: 0x001919F7 File Offset: 0x0018FBF7
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillAudioEventById.LogPair = null;
			ConfigSkillAudioEventById.HandleId = 0;
		}

		// Token: 0x0600373C RID: 14140 RVA: 0x00191A05 File Offset: 0x0018FC05
		public static void Init()
		{
			ConfigSkillAudioEventById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillAudioEventById.HandleId, "db_skillaudioevent.db", "select BinData from `SkillAudioEvent` where Id=?");
		}

		// Token: 0x0600373D RID: 14141 RVA: 0x00191A20 File Offset: 0x0018FC20
		public static SkillAudioEvent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkillAudioEventById.HandleId, ConfigSkillAudioEventById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillAudioEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SkillAudioEvent?(SkillAudioEvent.GetRootAsSkillAudioEvent(configBuffer));
				}
			}
			ConfigSkillAudioEventById.LogPair.Clear();
			ConfigSkillAudioEventById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSkillAudioEventById.HandleId, 1, p0Id, ConfigSkillAudioEventById.LogPair) || ConfigCommon.Step(ConfigSkillAudioEventById.HandleId, true, ConfigSkillAudioEventById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkillAudioEventById.HandleId, ConfigSkillAudioEventById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkillAudioEventById.HandleId, 0, ConfigSkillAudioEventById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkillAudioEventById.HandleId, ConfigSkillAudioEventById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SkillAudioEvent rootAsSkillAudioEvent = SkillAudioEvent.GetRootAsSkillAudioEvent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkillAudioEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkillAudioEventById.HandleId, ConfigSkillAudioEventById.LogPair);
			return new SkillAudioEvent?(rootAsSkillAudioEvent);
		}

		// Token: 0x0400403D RID: 16445
		private const string DB = "db_skillaudioevent.db";

		// Token: 0x0400403E RID: 16446
		private const string FILE = "y.音频_技能音频.xlsx";

		// Token: 0x0400403F RID: 16447
		private const string TABLE = "SkillAudioEvent";

		// Token: 0x04004040 RID: 16448
		private const string COMMAND = "select BinData from `SkillAudioEvent` where Id=?";

		// Token: 0x04004041 RID: 16449
		private const string KEY_PREFIX = "SkillAudioEventById";

		// Token: 0x04004042 RID: 16450
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004043 RID: 16451
		private static int HandleId;
	}
}
