using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200097C RID: 2428
	public class ConfigSkillAudioEventById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060038FB RID: 14587 RVA: 0x0019EB77 File Offset: 0x0019CD77
		static ConfigSkillAudioEventById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkillAudioEventById.CreateStaticDefaultValue), new Action(ConfigSkillAudioEventById.ResetStaticDefaultValue));
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x0019EB98 File Offset: 0x0019CD98
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

		// Token: 0x060038FD RID: 14589 RVA: 0x0019EC17 File Offset: 0x0019CE17
		public static void ResetStaticDefaultValue()
		{
			ConfigSkillAudioEventById.LogPair = null;
			ConfigSkillAudioEventById.HandleId = 0;
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x0019EC25 File Offset: 0x0019CE25
		public static void Init()
		{
			ConfigSkillAudioEventById.HandleId = ConfigCommon.InitDataStatement(ConfigSkillAudioEventById.HandleId, "db_skillaudioevent.db", "select BinData from `SkillAudioEvent` where Id=?");
		}

		// Token: 0x060038FF RID: 14591 RVA: 0x0019EC40 File Offset: 0x0019CE40
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

		// Token: 0x0400424A RID: 16970
		private const string DB = "db_skillaudioevent.db";

		// Token: 0x0400424B RID: 16971
		private const string FILE = "y.音频_技能音频.xlsx";

		// Token: 0x0400424C RID: 16972
		private const string TABLE = "SkillAudioEvent";

		// Token: 0x0400424D RID: 16973
		private const string COMMAND = "select BinData from `SkillAudioEvent` where Id=?";

		// Token: 0x0400424E RID: 16974
		private const string KEY_PREFIX = "SkillAudioEventById";

		// Token: 0x0400424F RID: 16975
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004250 RID: 16976
		private static int HandleId;
	}
}
