using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007EF RID: 2031
	public class ConfigRhythmEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002FAC RID: 12204 RVA: 0x00166C20 File Offset: 0x00164E20
		static ConfigRhythmEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRhythmEffectById.CreateStaticDefaultValue), new Action(ConfigRhythmEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06002FAD RID: 12205 RVA: 0x00166C40 File Offset: 0x00164E40
		public static void CreateStaticDefaultValue()
		{
			ConfigRhythmEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRhythmEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rhythmship.db"),
				new ValueTuple<string, object>("文件", "j.节奏飞船_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RhythmEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `RhythmEffect` where Id=?")
			});
		}

		// Token: 0x06002FAE RID: 12206 RVA: 0x00166CBF File Offset: 0x00164EBF
		public static void ResetStaticDefaultValue()
		{
			ConfigRhythmEffectById.LogPair = null;
			ConfigRhythmEffectById.HandleId = 0;
		}

		// Token: 0x06002FAF RID: 12207 RVA: 0x00166CCD File Offset: 0x00164ECD
		public static void Init()
		{
			ConfigRhythmEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigRhythmEffectById.HandleId, "db_rhythmship.db", "select BinData from `RhythmEffect` where Id=?");
		}

		// Token: 0x06002FB0 RID: 12208 RVA: 0x00166CE8 File Offset: 0x00164EE8
		public static RhythmEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRhythmEffectById.HandleId, ConfigRhythmEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RhythmEffect?(RhythmEffect.GetRootAsRhythmEffect(configBuffer));
				}
			}
			ConfigRhythmEffectById.LogPair.Clear();
			ConfigRhythmEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRhythmEffectById.HandleId, 1, p0Id, ConfigRhythmEffectById.LogPair) || ConfigCommon.Step(ConfigRhythmEffectById.HandleId, true, ConfigRhythmEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRhythmEffectById.HandleId, ConfigRhythmEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRhythmEffectById.HandleId, 0, ConfigRhythmEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRhythmEffectById.HandleId, ConfigRhythmEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RhythmEffect rootAsRhythmEffect = RhythmEffect.GetRootAsRhythmEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RhythmEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRhythmEffectById.HandleId, ConfigRhythmEffectById.LogPair);
			return new RhythmEffect?(rootAsRhythmEffect);
		}

		// Token: 0x0400376F RID: 14191
		private const string DB = "db_rhythmship.db";

		// Token: 0x04003770 RID: 14192
		private const string FILE = "j.节奏飞船_局外.xlsx";

		// Token: 0x04003771 RID: 14193
		private const string TABLE = "RhythmEffect";

		// Token: 0x04003772 RID: 14194
		private const string COMMAND = "select BinData from `RhythmEffect` where Id=?";

		// Token: 0x04003773 RID: 14195
		private const string KEY_PREFIX = "RhythmEffectById";

		// Token: 0x04003774 RID: 14196
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003775 RID: 14197
		private static int HandleId;
	}
}
