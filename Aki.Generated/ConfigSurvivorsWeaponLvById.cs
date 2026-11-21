using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A8A RID: 2698
	public class ConfigSurvivorsWeaponLvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F50 RID: 16208 RVA: 0x001C2CF0 File Offset: 0x001C0EF0
		static ConfigSurvivorsWeaponLvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsWeaponLvById.CreateStaticDefaultValue), new Action(ConfigSurvivorsWeaponLvById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x001C2D10 File Offset: 0x001C0F10
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsWeaponLvById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsWeaponLvById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局内.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsWeaponLv"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsWeaponLv` where Id=?")
			});
		}

		// Token: 0x06003F52 RID: 16210 RVA: 0x001C2D8F File Offset: 0x001C0F8F
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsWeaponLvById.LogPair = null;
			ConfigSurvivorsWeaponLvById.HandleId = 0;
		}

		// Token: 0x06003F53 RID: 16211 RVA: 0x001C2D9D File Offset: 0x001C0F9D
		public static void Init()
		{
			ConfigSurvivorsWeaponLvById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsWeaponLvById.HandleId, "db_survivors.db", "select BinData from `SurvivorsWeaponLv` where Id=?");
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x001C2DB8 File Offset: 0x001C0FB8
		public static SurvivorsWeaponLv? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsWeaponLvById.HandleId, ConfigSurvivorsWeaponLvById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWeaponLvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsWeaponLv?(SurvivorsWeaponLv.GetRootAsSurvivorsWeaponLv(configBuffer));
				}
			}
			ConfigSurvivorsWeaponLvById.LogPair.Clear();
			ConfigSurvivorsWeaponLvById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsWeaponLvById.HandleId, 1, p0Id, ConfigSurvivorsWeaponLvById.LogPair) || ConfigCommon.Step(ConfigSurvivorsWeaponLvById.HandleId, true, ConfigSurvivorsWeaponLvById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsWeaponLvById.HandleId, ConfigSurvivorsWeaponLvById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsWeaponLvById.HandleId, 0, ConfigSurvivorsWeaponLvById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsWeaponLvById.HandleId, ConfigSurvivorsWeaponLvById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsWeaponLv rootAsSurvivorsWeaponLv = SurvivorsWeaponLv.GetRootAsSurvivorsWeaponLv(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWeaponLvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsWeaponLvById.HandleId, ConfigSurvivorsWeaponLvById.LogPair);
			return new SurvivorsWeaponLv?(rootAsSurvivorsWeaponLv);
		}

		// Token: 0x040049AC RID: 18860
		private const string DB = "db_survivors.db";

		// Token: 0x040049AD RID: 18861
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x040049AE RID: 18862
		private const string TABLE = "SurvivorsWeaponLv";

		// Token: 0x040049AF RID: 18863
		private const string COMMAND = "select BinData from `SurvivorsWeaponLv` where Id=?";

		// Token: 0x040049B0 RID: 18864
		private const string KEY_PREFIX = "SurvivorsWeaponLvById";

		// Token: 0x040049B1 RID: 18865
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040049B2 RID: 18866
		private static int HandleId;
	}
}
