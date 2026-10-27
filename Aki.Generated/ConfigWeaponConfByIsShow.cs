using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A7A RID: 2682
	public class ConfigWeaponConfByIsShow : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EF0 RID: 16112 RVA: 0x001BDFE1 File Offset: 0x001BC1E1
		static ConfigWeaponConfByIsShow()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponConfByIsShow.CreateStaticDefaultValue), new Action(ConfigWeaponConfByIsShow.ResetStaticDefaultValue));
		}

		// Token: 0x06003EF1 RID: 16113 RVA: 0x001BE000 File Offset: 0x001BC200
		public static void CreateStaticDefaultValue()
		{
			ConfigWeaponConfByIsShow.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigWeaponConfByIsShow.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_weapon.db"),
				new ValueTuple<string, object>("文件", "w.武器基础配置.xlsx"),
				new ValueTuple<string, object>("表名", "WeaponConf"),
				new ValueTuple<string, object>("语句", "select BinData from `WeaponConf` where IsShow = ?")
			});
		}

		// Token: 0x06003EF2 RID: 16114 RVA: 0x001BE07F File Offset: 0x001BC27F
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponConfByIsShow.LogPair = null;
			ConfigWeaponConfByIsShow.HandleId = 0;
		}

		// Token: 0x06003EF3 RID: 16115 RVA: 0x001BE08D File Offset: 0x001BC28D
		public static void Init()
		{
			ConfigWeaponConfByIsShow.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponConfByIsShow.HandleId, "db_weapon.db", "select BinData from `WeaponConf` where IsShow = ?");
		}

		// Token: 0x06003EF4 RID: 16116 RVA: 0x001BE0A8 File Offset: 0x001BC2A8
		[NullableContext(2)]
		public static IReadOnlyList<WeaponConf> GetConfigList(bool p0IsShow, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigWeaponConfByIsShow.HandleId, ConfigWeaponConfByIsShow.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponConfByIsShow");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(p0IsShow);
				IReadOnlyList<WeaponConf> readOnlyList = (IReadOnlyList<WeaponConf>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigWeaponConfByIsShow.LogPair.Clear();
			ConfigWeaponConfByIsShow.LogPair.Add(new ValueTuple<string, object>("IsShow", p0IsShow));
			if (!ConfigCommon.BindBool(ConfigWeaponConfByIsShow.HandleId, 1, p0IsShow, ConfigWeaponConfByIsShow.LogPair))
			{
				ConfigCommon.Reset(ConfigWeaponConfByIsShow.HandleId, ConfigWeaponConfByIsShow.LogPair);
				return null;
			}
			List<WeaponConf> list = new List<WeaponConf>();
			while (ConfigCommon.Step(ConfigWeaponConfByIsShow.HandleId, false, ConfigWeaponConfByIsShow.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigWeaponConfByIsShow.HandleId, 0, ConfigWeaponConfByIsShow.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigWeaponConfByIsShow.HandleId, ConfigWeaponConfByIsShow.LogPair);
					return null;
				}
				WeaponConf rootAsWeaponConf = WeaponConf.GetRootAsWeaponConf(new ByteBuffer(item2));
				list.Add(rootAsWeaponConf);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("WeaponConfByIsShow");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(p0IsShow);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigWeaponConfByIsShow.HandleId, ConfigWeaponConfByIsShow.LogPair);
			return list;
		}

		// Token: 0x0400493C RID: 18748
		private const string DB = "db_weapon.db";

		// Token: 0x0400493D RID: 18749
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x0400493E RID: 18750
		private const string TABLE = "WeaponConf";

		// Token: 0x0400493F RID: 18751
		private const string COMMAND = "select BinData from `WeaponConf` where IsShow = ?";

		// Token: 0x04004940 RID: 18752
		private const string KEY_PREFIX = "WeaponConfByIsShow";

		// Token: 0x04004941 RID: 18753
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004942 RID: 18754
		private static int HandleId;
	}
}
