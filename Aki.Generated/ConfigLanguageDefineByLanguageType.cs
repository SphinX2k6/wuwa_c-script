using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004C9 RID: 1225
	public class ConfigLanguageDefineByLanguageType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001CC1 RID: 7361 RVA: 0x000FBAA1 File Offset: 0x000F9CA1
		static ConfigLanguageDefineByLanguageType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLanguageDefineByLanguageType.CreateStaticDefaultValue), new Action(ConfigLanguageDefineByLanguageType.ResetStaticDefaultValue));
		}

		// Token: 0x06001CC2 RID: 7362 RVA: 0x000FBAC0 File Offset: 0x000F9CC0
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

		// Token: 0x06001CC3 RID: 7363 RVA: 0x000FBB3F File Offset: 0x000F9D3F
		public static void ResetStaticDefaultValue()
		{
			ConfigLanguageDefineByLanguageType.LogPair = null;
			ConfigLanguageDefineByLanguageType.HandleId = 0;
		}

		// Token: 0x06001CC4 RID: 7364 RVA: 0x000FBB4D File Offset: 0x000F9D4D
		public static void Init()
		{
			ConfigLanguageDefineByLanguageType.HandleId = ConfigCommon.InitDataStatement(ConfigLanguageDefineByLanguageType.HandleId, "db_menu.db", "select BinData from `LanguageDefine` where LanguageType = ?");
		}

		// Token: 0x06001CC5 RID: 7365 RVA: 0x000FBB68 File Offset: 0x000F9D68
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

		// Token: 0x04002163 RID: 8547
		private const string DB = "db_menu.db";

		// Token: 0x04002164 RID: 8548
		private const string FILE = "s.设置系统.xlsx";

		// Token: 0x04002165 RID: 8549
		private const string TABLE = "LanguageDefine";

		// Token: 0x04002166 RID: 8550
		private const string COMMAND = "select BinData from `LanguageDefine` where LanguageType = ?";

		// Token: 0x04002167 RID: 8551
		private const string KEY_PREFIX = "LanguageDefineByLanguageType";

		// Token: 0x04002168 RID: 8552
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002169 RID: 8553
		private static int HandleId;
	}
}
