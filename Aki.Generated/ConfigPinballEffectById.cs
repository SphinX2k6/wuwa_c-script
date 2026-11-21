using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000731 RID: 1841
	public class ConfigPinballEffectById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B36 RID: 11062 RVA: 0x00151110 File Offset: 0x0014F310
		static ConfigPinballEffectById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPinballEffectById.CreateStaticDefaultValue), new Action(ConfigPinballEffectById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x00151130 File Offset: 0x0014F330
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

		// Token: 0x06002B38 RID: 11064 RVA: 0x001511AF File Offset: 0x0014F3AF
		public static void ResetStaticDefaultValue()
		{
			ConfigPinballEffectById.LogPair = null;
			ConfigPinballEffectById.HandleId = 0;
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x001511BD File Offset: 0x0014F3BD
		public static void Init()
		{
			ConfigPinballEffectById.HandleId = ConfigCommon.InitDataStatement(ConfigPinballEffectById.HandleId, "db_pinballbattle.db", "select BinData from `PinballEffect` where Id=?");
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x001511D8 File Offset: 0x0014F3D8
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

		// Token: 0x0400323D RID: 12861
		private const string DB = "db_pinballbattle.db";

		// Token: 0x0400323E RID: 12862
		private const string FILE = "x.星弹奇游_通用.xlsx";

		// Token: 0x0400323F RID: 12863
		private const string TABLE = "PinballEffect";

		// Token: 0x04003240 RID: 12864
		private const string COMMAND = "select BinData from `PinballEffect` where Id=?";

		// Token: 0x04003241 RID: 12865
		private const string KEY_PREFIX = "PinballEffectById";

		// Token: 0x04003242 RID: 12866
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003243 RID: 12867
		private static int HandleId;
	}
}
