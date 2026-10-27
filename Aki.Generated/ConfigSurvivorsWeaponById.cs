using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B3 RID: 2483
	public class ConfigSurvivorsWeaponById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A46 RID: 14918 RVA: 0x001A34CB File Offset: 0x001A16CB
		static ConfigSurvivorsWeaponById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsWeaponById.CreateStaticDefaultValue), new Action(ConfigSurvivorsWeaponById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A47 RID: 14919 RVA: 0x001A34EC File Offset: 0x001A16EC
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsWeaponById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsWeaponById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局内.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsWeapon"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsWeapon` where Id=?")
			});
		}

		// Token: 0x06003A48 RID: 14920 RVA: 0x001A356B File Offset: 0x001A176B
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsWeaponById.LogPair = null;
			ConfigSurvivorsWeaponById.HandleId = 0;
		}

		// Token: 0x06003A49 RID: 14921 RVA: 0x001A3579 File Offset: 0x001A1779
		public static void Init()
		{
			ConfigSurvivorsWeaponById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsWeaponById.HandleId, "db_survivors.db", "select BinData from `SurvivorsWeapon` where Id=?");
		}

		// Token: 0x06003A4A RID: 14922 RVA: 0x001A3594 File Offset: 0x001A1794
		public static SurvivorsWeapon? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsWeaponById.HandleId, ConfigSurvivorsWeaponById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWeaponById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsWeapon?(SurvivorsWeapon.GetRootAsSurvivorsWeapon(configBuffer));
				}
			}
			ConfigSurvivorsWeaponById.LogPair.Clear();
			ConfigSurvivorsWeaponById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsWeaponById.HandleId, 1, p0Id, ConfigSurvivorsWeaponById.LogPair) || ConfigCommon.Step(ConfigSurvivorsWeaponById.HandleId, true, ConfigSurvivorsWeaponById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsWeaponById.HandleId, ConfigSurvivorsWeaponById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsWeaponById.HandleId, 0, ConfigSurvivorsWeaponById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsWeaponById.HandleId, ConfigSurvivorsWeaponById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsWeapon rootAsSurvivorsWeapon = SurvivorsWeapon.GetRootAsSurvivorsWeapon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWeaponById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsWeaponById.HandleId, ConfigSurvivorsWeaponById.LogPair);
			return new SurvivorsWeapon?(rootAsSurvivorsWeapon);
		}

		// Token: 0x040043CB RID: 17355
		private const string DB = "db_survivors.db";

		// Token: 0x040043CC RID: 17356
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x040043CD RID: 17357
		private const string TABLE = "SurvivorsWeapon";

		// Token: 0x040043CE RID: 17358
		private const string COMMAND = "select BinData from `SurvivorsWeapon` where Id=?";

		// Token: 0x040043CF RID: 17359
		private const string KEY_PREFIX = "SurvivorsWeaponById";

		// Token: 0x040043D0 RID: 17360
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043D1 RID: 17361
		private static int HandleId;
	}
}
