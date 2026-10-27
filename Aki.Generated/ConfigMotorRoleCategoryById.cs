using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005C0 RID: 1472
	public class ConfigMotorRoleCategoryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600228D RID: 8845 RVA: 0x0011CE53 File Offset: 0x0011B053
		static ConfigMotorRoleCategoryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorRoleCategoryById.CreateStaticDefaultValue), new Action(ConfigMotorRoleCategoryById.ResetStaticDefaultValue));
		}

		// Token: 0x0600228E RID: 8846 RVA: 0x0011CE74 File Offset: 0x0011B074
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorRoleCategoryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorRoleCategoryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorcommon.db"),
				new ValueTuple<string, object>("文件", "m.摩托车共乘.xlsx"),
				new ValueTuple<string, object>("表名", "MotorRoleCategory"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorRoleCategory` where Id=?")
			});
		}

		// Token: 0x0600228F RID: 8847 RVA: 0x0011CEF3 File Offset: 0x0011B0F3
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorRoleCategoryById.LogPair = null;
			ConfigMotorRoleCategoryById.HandleId = 0;
		}

		// Token: 0x06002290 RID: 8848 RVA: 0x0011CF01 File Offset: 0x0011B101
		public static void Init()
		{
			ConfigMotorRoleCategoryById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorRoleCategoryById.HandleId, "db_motorcommon.db", "select BinData from `MotorRoleCategory` where Id=?");
		}

		// Token: 0x06002291 RID: 8849 RVA: 0x0011CF1C File Offset: 0x0011B11C
		public static MotorRoleCategory? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorRoleCategoryById.HandleId, ConfigMotorRoleCategoryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorRoleCategoryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorRoleCategory?(MotorRoleCategory.GetRootAsMotorRoleCategory(configBuffer));
				}
			}
			ConfigMotorRoleCategoryById.LogPair.Clear();
			ConfigMotorRoleCategoryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorRoleCategoryById.HandleId, 1, p0Id, ConfigMotorRoleCategoryById.LogPair) || ConfigCommon.Step(ConfigMotorRoleCategoryById.HandleId, true, ConfigMotorRoleCategoryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorRoleCategoryById.HandleId, ConfigMotorRoleCategoryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorRoleCategoryById.HandleId, 0, ConfigMotorRoleCategoryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorRoleCategoryById.HandleId, ConfigMotorRoleCategoryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorRoleCategory rootAsMotorRoleCategory = MotorRoleCategory.GetRootAsMotorRoleCategory(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorRoleCategoryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorRoleCategoryById.HandleId, ConfigMotorRoleCategoryById.LogPair);
			return new MotorRoleCategory?(rootAsMotorRoleCategory);
		}

		// Token: 0x04002824 RID: 10276
		private const string DB = "db_motorcommon.db";

		// Token: 0x04002825 RID: 10277
		private const string FILE = "m.摩托车共乘.xlsx";

		// Token: 0x04002826 RID: 10278
		private const string TABLE = "MotorRoleCategory";

		// Token: 0x04002827 RID: 10279
		private const string COMMAND = "select BinData from `MotorRoleCategory` where Id=?";

		// Token: 0x04002828 RID: 10280
		private const string KEY_PREFIX = "MotorRoleCategoryById";

		// Token: 0x04002829 RID: 10281
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400282A RID: 10282
		private static int HandleId;
	}
}
