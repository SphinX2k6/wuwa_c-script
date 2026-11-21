using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004DF RID: 1247
	public class ConfigLanguageDefineByLanguageType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D45 RID: 7493 RVA: 0x001021F5 File Offset: 0x001003F5
		static ConfigLanguageDefineByLanguageType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLanguageDefineByLanguageType.CreateStaticDefaultValue), new Action(ConfigLanguageDefineByLanguageType.ResetStaticDefaultValue));
		}

		// Token: 0x06001D46 RID: 7494 RVA: 0x00102214 File Offset: 0x00100414
		public static void CreateStaticDefaultValue()
		{
			ConfigLanguageDefineByLanguageType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLanguageDefineByLanguageType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_menu.db"),
				new ValueTuple<string, object>("文件", "s.设置系统.xlsx"),
				new ValueTuple<string, object>("表名", "LanguageDefine"),
				new ValueTuple<string, object>("语句", "select BinData from `LanguageDefine` where LanguageType = ?")
			});
		}

		// Token: 0x06001D47 RID: 7495 RVA: 0x00102293 File Offset: 0x00100493
		public static void ResetStaticDefaultValue()
		{
			ConfigLanguageDefineByLanguageType.LogPair = null;
			ConfigLanguageDefineByLanguageType.HandleId = 0;
		}

		// Token: 0x06001D48 RID: 7496 RVA: 0x001022A1 File Offset: 0x001004A1
		public static void Init()
		{
			ConfigLanguageDefineByLanguageType.HandleId = ConfigCommon.InitDataStatement(ConfigLanguageDefineByLanguageType.HandleId, "db_menu.db", "select BinData from `LanguageDefine` where LanguageType = ?");
		}

		// Token: 0x06001D49 RID: 7497 RVA: 0x001022BC File Offset: 0x001004BC
		public static LanguageDefine? GetConfig(int p0LanguageType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLanguageDefineByLanguageType.HandleId, ConfigLanguageDefineByLanguageType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LanguageDefineByLanguageType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LanguageType);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LanguageDefine?(LanguageDefine.GetRootAsLanguageDefine(configBuffer));
				}
			}
			ConfigLanguageDefineByLanguageType.LogPair.Clear();
			ConfigLanguageDefineByLanguageType.LogPair.Add(new ValueTuple<string, object>("LanguageType", p0LanguageType));
			if (!ConfigCommon.BindInt(ConfigLanguageDefineByLanguageType.HandleId, 1, p0LanguageType, ConfigLanguageDefineByLanguageType.LogPair) || ConfigCommon.Step(ConfigLanguageDefineByLanguageType.HandleId, true, ConfigLanguageDefineByLanguageType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLanguageDefineByLanguageType.HandleId, ConfigLanguageDefineByLanguageType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLanguageDefineByLanguageType.HandleId, 0, ConfigLanguageDefineByLanguageType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLanguageDefineByLanguageType.HandleId, ConfigLanguageDefineByLanguageType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LanguageDefine rootAsLanguageDefine = LanguageDefine.GetRootAsLanguageDefine(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LanguageDefineByLanguageType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0LanguageType);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLanguageDefineByLanguageType.HandleId, ConfigLanguageDefineByLanguageType.LogPair);
			return new LanguageDefine?(rootAsLanguageDefine);
		}

		// Token: 0x040021FD RID: 8701
		private const string DB = "db_menu.db";

		// Token: 0x040021FE RID: 8702
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x040021FF RID: 8703
		private const string TABLE = "LanguageDefine";

		// Token: 0x04002200 RID: 8704
		private const string COMMAND = "select BinData from `LanguageDefine` where LanguageType = ?";

		// Token: 0x04002201 RID: 8705
		private const string KEY_PREFIX = "LanguageDefineByLanguageType";

		// Token: 0x04002202 RID: 8706
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002203 RID: 8707
		private static int HandleId;
	}
}
