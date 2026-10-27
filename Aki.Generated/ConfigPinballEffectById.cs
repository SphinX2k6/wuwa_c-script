using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000719 RID: 1817
	public class ConfigPinballEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002AA6 RID: 10918 RVA: 0x0014A694 File Offset: 0x00148894
		static ConfigPinballEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballEffectById.CreateStaticDefaultValue), new Action(ConfigPinballEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x0014A6B4 File Offset: 0x001488B4
		public static void CreateStaticDefaultValue()
		{
			ConfigPinballEffectById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPinballEffectById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_pinballbattle.db"),
				new ValueTuple<string, object>("文件", "x.星弹奇游_通用.xlsx"),
				new ValueTuple<string, object>("表名", "PinballEffect"),
				new ValueTuple<string, object>("语句", "select BinData from `PinballEffect` where Id=?")
			});
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x0014A733 File Offset: 0x00148933
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballEffectById.LogPair = null;
			ConfigPinballEffectById.HandleId = 0;
		}

		// Token: 0x06002AA9 RID: 10921 RVA: 0x0014A741 File Offset: 0x00148941
		public static void Init()
		{
			ConfigPinballEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballEffectById.HandleId, "db_pinballbattle.db", "select BinData from `PinballEffect` where Id=?");
		}

		// Token: 0x06002AAA RID: 10922 RVA: 0x0014A75C File Offset: 0x0014895C
		public static PinballEffect? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPinballEffectById.HandleId, ConfigPinballEffectById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PinballEffect?(PinballEffect.GetRootAsPinballEffect(configBuffer));
				}
			}
			ConfigPinballEffectById.LogPair.Clear();
			ConfigPinballEffectById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPinballEffectById.HandleId, 1, p0Id, ConfigPinballEffectById.LogPair) || ConfigCommon.Step(ConfigPinballEffectById.HandleId, true, ConfigPinballEffectById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPinballEffectById.HandleId, ConfigPinballEffectById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPinballEffectById.HandleId, 0, ConfigPinballEffectById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPinballEffectById.HandleId, ConfigPinballEffectById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PinballEffect rootAsPinballEffect = PinballEffect.GetRootAsPinballEffect(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PinballEffectById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPinballEffectById.HandleId, ConfigPinballEffectById.LogPair);
			return new PinballEffect?(rootAsPinballEffect);
		}

		// Token: 0x04003195 RID: 12693
		private const string DB = "db_pinballbattle.db";

		// Token: 0x04003196 RID: 12694
		private const string FILE = "x.星弹奇游_通用.xlsx";

		// Token: 0x04003197 RID: 12695
		private const string TABLE = "PinballEffect";

		// Token: 0x04003198 RID: 12696
		private const string COMMAND = "select BinData from `PinballEffect` where Id=?";

		// Token: 0x04003199 RID: 12697
		private const string KEY_PREFIX = "PinballEffectById";

		// Token: 0x0400319A RID: 12698
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400319B RID: 12699
		private static int HandleId;
	}
}
