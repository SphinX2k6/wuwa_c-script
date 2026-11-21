using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B4F RID: 2895
	public class ConfigWeaponConfByIsShow : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060043EE RID: 17390 RVA: 0x001DD375 File Offset: 0x001DB575
		static ConfigWeaponConfByIsShow()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigWeaponConfByIsShow.CreateStaticDefaultValue), new Action(ConfigWeaponConfByIsShow.ResetStaticDefaultValue));
		}

		// Token: 0x060043EF RID: 17391 RVA: 0x001DD394 File Offset: 0x001DB594
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

		// Token: 0x060043F0 RID: 17392 RVA: 0x001DD413 File Offset: 0x001DB613
		public static void ResetStaticDefaultValue()
		{
			ConfigWeaponConfByIsShow.LogPair = null;
			ConfigWeaponConfByIsShow.HandleId = 0;
		}

		// Token: 0x060043F1 RID: 17393 RVA: 0x001DD421 File Offset: 0x001DB621
		public static void Init()
		{
			ConfigWeaponConfByIsShow.HandleId = ConfigCommon.InitDataStatement(ConfigWeaponConfByIsShow.HandleId, "db_weapon.db", "select BinData from `WeaponConf` where IsShow = ?");
		}

		// Token: 0x060043F2 RID: 17394 RVA: 0x001DD43C File Offset: 0x001DB63C
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

		// Token: 0x04004F0F RID: 20239
		private const string DB = "db_weapon.db";

		// Token: 0x04004F10 RID: 20240
		private const string FILE = "w.武器基础配置.xlsx";

		// Token: 0x04004F11 RID: 20241
		private const string TABLE = "WeaponConf";

		// Token: 0x04004F12 RID: 20242
		private const string COMMAND = "select BinData from `WeaponConf` where IsShow = ?";

		// Token: 0x04004F13 RID: 20243
		private const string KEY_PREFIX = "WeaponConfByIsShow";

		// Token: 0x04004F14 RID: 20244
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004F15 RID: 20245
		private static int HandleId;
	}
}
