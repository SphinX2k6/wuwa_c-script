using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000CB RID: 203
	public class ConfigAvgSolarSchoolRoleAnimationById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004C3 RID: 1219 RVA: 0x00078418 File Offset: 0x00076618
		static ConfigAvgSolarSchoolRoleAnimationById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvgSolarSchoolRoleAnimationById.CreateStaticDefaultValue), new Action(ConfigAvgSolarSchoolRoleAnimationById.ResetStaticDefaultValue));
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00078438 File Offset: 0x00076638
		public static void CreateStaticDefaultValue()
		{
			ConfigAvgSolarSchoolRoleAnimationById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvgSolarSchoolRoleAnimationById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_avgsolarschoolroleanimation.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/a.Avg索拉学院角色动画/*.csv*"),
				new ValueTuple<string, object>("表名", "AvgSolarSchoolRoleAnimation"),
				new ValueTuple<string, object>("语句", "select BinData from `AvgSolarSchoolRoleAnimation` where Id=?")
			});
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000784B7 File Offset: 0x000766B7
		public static void ResetStaticDefaultValue()
		{
			ConfigAvgSolarSchoolRoleAnimationById.LogPair = null;
			ConfigAvgSolarSchoolRoleAnimationById.HandleId = 0;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000784C5 File Offset: 0x000766C5
		public static void Init()
		{
			ConfigAvgSolarSchoolRoleAnimationById.HandleId = ConfigCommon.InitDataStatement(ConfigAvgSolarSchoolRoleAnimationById.HandleId, "db_avgsolarschoolroleanimation.db", "select BinData from `AvgSolarSchoolRoleAnimation` where Id=?");
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000784E0 File Offset: 0x000766E0
		public static AvgSolarSchoolRoleAnimation? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAvgSolarSchoolRoleAnimationById.HandleId, ConfigAvgSolarSchoolRoleAnimationById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvgSolarSchoolRoleAnimationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AvgSolarSchoolRoleAnimation?(AvgSolarSchoolRoleAnimation.GetRootAsAvgSolarSchoolRoleAnimation(configBuffer));
				}
			}
			ConfigAvgSolarSchoolRoleAnimationById.LogPair.Clear();
			ConfigAvgSolarSchoolRoleAnimationById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAvgSolarSchoolRoleAnimationById.HandleId, 1, p0Id, ConfigAvgSolarSchoolRoleAnimationById.LogPair) || ConfigCommon.Step(ConfigAvgSolarSchoolRoleAnimationById.HandleId, true, ConfigAvgSolarSchoolRoleAnimationById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAvgSolarSchoolRoleAnimationById.HandleId, ConfigAvgSolarSchoolRoleAnimationById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAvgSolarSchoolRoleAnimationById.HandleId, 0, ConfigAvgSolarSchoolRoleAnimationById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAvgSolarSchoolRoleAnimationById.HandleId, ConfigAvgSolarSchoolRoleAnimationById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AvgSolarSchoolRoleAnimation rootAsAvgSolarSchoolRoleAnimation = AvgSolarSchoolRoleAnimation.GetRootAsAvgSolarSchoolRoleAnimation(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AvgSolarSchoolRoleAnimationById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAvgSolarSchoolRoleAnimationById.HandleId, ConfigAvgSolarSchoolRoleAnimationById.LogPair);
			return new AvgSolarSchoolRoleAnimation?(rootAsAvgSolarSchoolRoleAnimation);
		}

		// Token: 0x04000571 RID: 1393
		private const string DB = "db_avgsolarschoolroleanimation.db";

		// Token: 0x04000572 RID: 1394
		private const string FILE = "k.可视化编辑/c.Csv/a.Avg索拉学院角色动画/*.csv*";

		// Token: 0x04000573 RID: 1395
		private const string TABLE = "AvgSolarSchoolRoleAnimation";

		// Token: 0x04000574 RID: 1396
		private const string COMMAND = "select BinData from `AvgSolarSchoolRoleAnimation` where Id=?";

		// Token: 0x04000575 RID: 1397
		private const string KEY_PREFIX = "AvgSolarSchoolRoleAnimationById";

		// Token: 0x04000576 RID: 1398
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000577 RID: 1399
		private static int HandleId;
	}
}
