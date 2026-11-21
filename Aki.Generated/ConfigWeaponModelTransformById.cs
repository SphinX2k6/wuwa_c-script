using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B59 RID: 2905
	public class ConfigWeaponModelTransformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600442A RID: 17450 RVA: 0x001DE9BD File Offset: 0x001DCBBD
		static ConfigWeaponModelTransformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponModelTransformById.CreateStaticDefaultValue), new Action(ConfigWeaponModelTransformById.ResetStaticDefaultValue));
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x001DE9DC File Offset: 0x001DCBDC
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponModelTransformById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponModelTransformById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponModelTransform"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponModelTransform` where Id = ?")
			});
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x001DEA5B File Offset: 0x001DCC5B
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponModelTransformById.LogPair = null;
			ConfigWeaponModelTransformById.HandleId = 0;
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x001DEA69 File Offset: 0x001DCC69
		public static void Init()
		{
			ConfigWeaponModelTransformById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponModelTransformById.HandleId, "db_weapon.db", "select BinData from `WeaponModelTransform` where Id = ?");
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x001DEA84 File Offset: 0x001DCC84
		public static WeaponModelTransform? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponModelTransformById.HandleId, ConfigWeaponModelTransformById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponModelTransformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new WeaponModelTransform?(WeaponModelTransform.GetRootAsWeaponModelTransform(configBuffer));
				}
			}
			ConfigWeaponModelTransformById.LogPair.Clear();
			ConfigWeaponModelTransformById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigWeaponModelTransformById.HandleId, 1, p0Id, ConfigWeaponModelTransformById.LogPair) || ConfigCommon.Step(ConfigWeaponModelTransformById.HandleId, true, ConfigWeaponModelTransformById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigWeaponModelTransformById.HandleId, ConfigWeaponModelTransformById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponModelTransformById.HandleId, 0, ConfigWeaponModelTransformById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigWeaponModelTransformById.HandleId, ConfigWeaponModelTransformById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			WeaponModelTransform rootAsWeaponModelTransform = WeaponModelTransform.GetRootAsWeaponModelTransform(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponModelTransformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigWeaponModelTransformById.HandleId, ConfigWeaponModelTransformById.LogPair);
			return new WeaponModelTransform?(rootAsWeaponModelTransform);
		}

		// Token: 0x04004F55 RID: 20309
		private const string DB = "db_weapon.db";

		// Token: 0x04004F56 RID: 20310
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004F57 RID: 20311
		private const string TABLE = "WeaponModelTransform";

		// Token: 0x04004F58 RID: 20312
		private const string COMMAND = "select BinData from `WeaponModelTransform` where Id = ?";

		// Token: 0x04004F59 RID: 20313
		private const string KEY_PREFIX = "WeaponModelTransformById";

		// Token: 0x04004F5A RID: 20314
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F5B RID: 20315
		private static int HandleId;
	}
}
