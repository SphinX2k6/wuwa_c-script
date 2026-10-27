using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A84 RID: 2692
	public class ConfigWeaponModelTransformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F2C RID: 16172 RVA: 0x001BF629 File Offset: 0x001BD829
		static ConfigWeaponModelTransformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponModelTransformById.CreateStaticDefaultValue), new Action(ConfigWeaponModelTransformById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x001BF648 File Offset: 0x001BD848
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

		// Token: 0x06003F2E RID: 16174 RVA: 0x001BF6C7 File Offset: 0x001BD8C7
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponModelTransformById.LogPair = null;
			ConfigWeaponModelTransformById.HandleId = 0;
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x001BF6D5 File Offset: 0x001BD8D5
		public static void Init()
		{
			ConfigWeaponModelTransformById.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponModelTransformById.HandleId, "db_weapon.db", "select BinData from `WeaponModelTransform` where Id = ?");
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x001BF6F0 File Offset: 0x001BD8F0
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

		// Token: 0x04004982 RID: 18818
		private const string DB = "db_weapon.db";

		// Token: 0x04004983 RID: 18819
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004984 RID: 18820
		private const string TABLE = "WeaponModelTransform";

		// Token: 0x04004985 RID: 18821
		private const string COMMAND = "select BinData from `WeaponModelTransform` where Id = ?";

		// Token: 0x04004986 RID: 18822
		private const string KEY_PREFIX = "WeaponModelTransformById";

		// Token: 0x04004987 RID: 18823
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004988 RID: 18824
		private static int HandleId;
	}
}
