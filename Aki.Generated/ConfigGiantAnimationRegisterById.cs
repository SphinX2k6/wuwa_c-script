using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A5 RID: 933
	public class ConfigGiantAnimationRegisterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015E4 RID: 5604 RVA: 0x000D8E9C File Offset: 0x000D709C
		static ConfigGiantAnimationRegisterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantAnimationRegisterById.CreateStaticDefaultValue), new Action(ConfigGiantAnimationRegisterById.ResetStaticDefaultValue));
		}

		// Token: 0x060015E5 RID: 5605 RVA: 0x000D8EBC File Offset: 0x000D70BC
		public static void CreateStaticDefaultValue()
		{
			ConfigGiantAnimationRegisterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiantAnimationRegisterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giantanimationregister.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/j.巨人动画注册/*.csv*"),
				new ValueTuple<string, object>("表名", "GiantAnimationRegister"),
				new ValueTuple<string, object>("语句", "select BinData from `GiantAnimationRegister` where Id=?")
			});
		}

		// Token: 0x060015E6 RID: 5606 RVA: 0x000D8F3B File Offset: 0x000D713B
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantAnimationRegisterById.LogPair = null;
			ConfigGiantAnimationRegisterById.HandleId = 0;
		}

		// Token: 0x060015E7 RID: 5607 RVA: 0x000D8F49 File Offset: 0x000D7149
		public static void Init()
		{
			ConfigGiantAnimationRegisterById.HandleId = ConfigCommon.InitDataStatement(ConfigGiantAnimationRegisterById.HandleId, "db_giantanimationregister.db", "select BinData from `GiantAnimationRegister` where Id=?");
		}

		// Token: 0x060015E8 RID: 5608 RVA: 0x000D8F64 File Offset: 0x000D7164
		public static GiantAnimationRegister? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiantAnimationRegisterById.HandleId, ConfigGiantAnimationRegisterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantAnimationRegisterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GiantAnimationRegister?(GiantAnimationRegister.GetRootAsGiantAnimationRegister(configBuffer));
				}
			}
			ConfigGiantAnimationRegisterById.LogPair.Clear();
			ConfigGiantAnimationRegisterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGiantAnimationRegisterById.HandleId, 1, p0Id, ConfigGiantAnimationRegisterById.LogPair) || ConfigCommon.Step(ConfigGiantAnimationRegisterById.HandleId, true, ConfigGiantAnimationRegisterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGiantAnimationRegisterById.HandleId, ConfigGiantAnimationRegisterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiantAnimationRegisterById.HandleId, 0, ConfigGiantAnimationRegisterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGiantAnimationRegisterById.HandleId, ConfigGiantAnimationRegisterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GiantAnimationRegister rootAsGiantAnimationRegister = GiantAnimationRegister.GetRootAsGiantAnimationRegister(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantAnimationRegisterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGiantAnimationRegisterById.HandleId, ConfigGiantAnimationRegisterById.LogPair);
			return new GiantAnimationRegister?(rootAsGiantAnimationRegister);
		}

		// Token: 0x04001967 RID: 6503
		private const string DB = "db_giantanimationregister.db";

		// Token: 0x04001968 RID: 6504
		private const string FILE = "k.可视化编辑/c.Csv/j.巨人动画注册/*.csv*";

		// Token: 0x04001969 RID: 6505
		private const string TABLE = "GiantAnimationRegister";

		// Token: 0x0400196A RID: 6506
		private const string COMMAND = "select BinData from `GiantAnimationRegister` where Id=?";

		// Token: 0x0400196B RID: 6507
		private const string KEY_PREFIX = "GiantAnimationRegisterById";

		// Token: 0x0400196C RID: 6508
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400196D RID: 6509
		private static int HandleId;
	}
}
