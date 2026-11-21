using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D0 RID: 2256
	public class ConfigRoleInfoLangByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060034F3 RID: 13555 RVA: 0x00187F3F File Offset: 0x0018613F
		static ConfigRoleInfoLangByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleInfoLangByRoleId.CreateStaticDefaultValue), new Action(ConfigRoleInfoLangByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x00187F60 File Offset: 0x00186160
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleInfoLangByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleInfoLangByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_audio.db"),
				new ValueTuple<string, object>("文件", "y.音频_角色音频.xlsx"),
				new ValueTuple<string, object>("表名", "RoleInfoLang"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleInfoLang` where RoleId=?")
			});
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x00187FDF File Offset: 0x001861DF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleInfoLangByRoleId.LogPair = null;
			ConfigRoleInfoLangByRoleId.HandleId = 0;
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x00187FED File Offset: 0x001861ED
		public static void Init()
		{
			ConfigRoleInfoLangByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigRoleInfoLangByRoleId.HandleId, "db_audio.db", "select BinData from `RoleInfoLang` where RoleId=?");
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x00188008 File Offset: 0x00186208
		public static RoleInfoLang? GetConfig(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleInfoLangByRoleId.HandleId, ConfigRoleInfoLangByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleInfoLangByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoleInfoLang?(RoleInfoLang.GetRootAsRoleInfoLang(configBuffer));
				}
			}
			ConfigRoleInfoLangByRoleId.LogPair.Clear();
			ConfigRoleInfoLangByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigRoleInfoLangByRoleId.HandleId, 1, p0RoleId, ConfigRoleInfoLangByRoleId.LogPair) || ConfigCommon.Step(ConfigRoleInfoLangByRoleId.HandleId, true, ConfigRoleInfoLangByRoleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoleInfoLangByRoleId.HandleId, ConfigRoleInfoLangByRoleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleInfoLangByRoleId.HandleId, 0, ConfigRoleInfoLangByRoleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoleInfoLangByRoleId.HandleId, ConfigRoleInfoLangByRoleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoleInfoLang rootAsRoleInfoLang = RoleInfoLang.GetRootAsRoleInfoLang(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoleInfoLangByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoleInfoLangByRoleId.HandleId, ConfigRoleInfoLangByRoleId.LogPair);
			return new RoleInfoLang?(rootAsRoleInfoLang);
		}

		// Token: 0x04003D96 RID: 15766
		private const string DB = "db_audio.db";

		// Token: 0x04003D97 RID: 15767
		private const string FILE = "y.音频_角色音频.xlsx";

		// Token: 0x04003D98 RID: 15768
		private const string TABLE = "RoleInfoLang";

		// Token: 0x04003D99 RID: 15769
		private const string COMMAND = "select BinData from `RoleInfoLang` where RoleId=?";

		// Token: 0x04003D9A RID: 15770
		private const string KEY_PREFIX = "RoleInfoLangByRoleId";

		// Token: 0x04003D9B RID: 15771
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D9C RID: 15772
		private static int HandleId;
	}
}
