using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000126 RID: 294
	public class ConfigBuffGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006E5 RID: 1765 RVA: 0x000809E3 File Offset: 0x0007EBE3
		static ConfigBuffGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffGroupById.CreateStaticDefaultValue), new Action(ConfigBuffGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x00080A04 File Offset: 0x0007EC04
		public static void CreateStaticDefaultValue()
		{
			ConfigBuffGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBuffGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_buffgroup.db"),
				new ValueTuple<string, object>("文件", "b.Buff分组.xlsx"),
				new ValueTuple<string, object>("表名", "BuffGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `BuffGroup` where Id = ?")
			});
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x00080A83 File Offset: 0x0007EC83
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffGroupById.LogPair = null;
			ConfigBuffGroupById.HandleId = 0;
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x00080A91 File Offset: 0x0007EC91
		public static void Init()
		{
			ConfigBuffGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigBuffGroupById.HandleId, "db_buffgroup.db", "select BinData from `BuffGroup` where Id = ?");
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x00080AAC File Offset: 0x0007ECAC
		public static BuffGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBuffGroupById.HandleId, ConfigBuffGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BuffGroup?(BuffGroup.GetRootAsBuffGroup(configBuffer));
				}
			}
			ConfigBuffGroupById.LogPair.Clear();
			ConfigBuffGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBuffGroupById.HandleId, 1, p0Id, ConfigBuffGroupById.LogPair) || ConfigCommon.Step(ConfigBuffGroupById.HandleId, true, ConfigBuffGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBuffGroupById.HandleId, ConfigBuffGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBuffGroupById.HandleId, 0, ConfigBuffGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBuffGroupById.HandleId, ConfigBuffGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BuffGroup rootAsBuffGroup = BuffGroup.GetRootAsBuffGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBuffGroupById.HandleId, ConfigBuffGroupById.LogPair);
			return new BuffGroup?(rootAsBuffGroup);
		}

		// Token: 0x040007EE RID: 2030
		private const string DB = "db_buffgroup.db";

		// Token: 0x040007EF RID: 2031
		private const string FILE = "b.Buff分组.xlsx";

		// Token: 0x040007F0 RID: 2032
		private const string TABLE = "BuffGroup";

		// Token: 0x040007F1 RID: 2033
		private const string COMMAND = "select BinData from `BuffGroup` where Id = ?";

		// Token: 0x040007F2 RID: 2034
		private const string KEY_PREFIX = "BuffGroupById";

		// Token: 0x040007F3 RID: 2035
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007F4 RID: 2036
		private static int HandleId;
	}
}
