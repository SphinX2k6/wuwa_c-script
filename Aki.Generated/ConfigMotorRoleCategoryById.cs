using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005D7 RID: 1495
	public class ConfigMotorRoleCategoryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002317 RID: 8983 RVA: 0x0012373B File Offset: 0x0012193B
		static ConfigMotorRoleCategoryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorRoleCategoryById.CreateStaticDefaultValue), new Action(ConfigMotorRoleCategoryById.ResetStaticDefaultValue));
		}

		// Token: 0x06002318 RID: 8984 RVA: 0x0012375C File Offset: 0x0012195C
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

		// Token: 0x06002319 RID: 8985 RVA: 0x001237DB File Offset: 0x001219DB
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorRoleCategoryById.LogPair = null;
			ConfigMotorRoleCategoryById.HandleId = 0;
		}

		// Token: 0x0600231A RID: 8986 RVA: 0x001237E9 File Offset: 0x001219E9
		public static void Init()
		{
			ConfigMotorRoleCategoryById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorRoleCategoryById.HandleId, "db_motorcommon.db", "select BinData from `MotorRoleCategory` where Id=?");
		}

		// Token: 0x0600231B RID: 8987 RVA: 0x00123804 File Offset: 0x00121A04
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

		// Token: 0x040028C5 RID: 10437
		private const string DB = "db_motorcommon.db";

		// Token: 0x040028C6 RID: 10438
		private const string FILE = "m.摩托车共乘.xlsx";

		// Token: 0x040028C7 RID: 10439
		private const string TABLE = "MotorRoleCategory";

		// Token: 0x040028C8 RID: 10440
		private const string COMMAND = "select BinData from `MotorRoleCategory` where Id=?";

		// Token: 0x040028C9 RID: 10441
		private const string KEY_PREFIX = "MotorRoleCategoryById";

		// Token: 0x040028CA RID: 10442
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028CB RID: 10443
		private static int HandleId;
	}
}
