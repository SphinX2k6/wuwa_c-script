using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000491 RID: 1169
	public class ConfigKurotatoExpByLevelAndActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001B70 RID: 7024 RVA: 0x000F46A0 File Offset: 0x000F28A0
		static ConfigKurotatoExpByLevelAndActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigKurotatoExpByLevelAndActivityId.CreateStaticDefaultValue), new Action(ConfigKurotatoExpByLevelAndActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x000F46C0 File Offset: 0x000F28C0
		public static void CreateStaticDefaultValue()
		{
			ConfigKurotatoExpByLevelAndActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigKurotatoExpByLevelAndActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_kurotato.db"),
				new ValueTuple<string, object>("文件", "t.土豆兄弟_局内.xlsx"),
				new ValueTuple<string, object>("表名", "KurotatoExp"),
				new ValueTuple<string, object>("语句", "select BinData from `KurotatoExp` where RoleLevel=? AND ActivityId=?")
			});
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x000F473F File Offset: 0x000F293F
		public static void ResetStaticDefaultValue()
		{
			ConfigKurotatoExpByLevelAndActivityId.LogPair = null;
			ConfigKurotatoExpByLevelAndActivityId.HandleId = 0;
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x000F474D File Offset: 0x000F294D
		public static void Init()
		{
			ConfigKurotatoExpByLevelAndActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigKurotatoExpByLevelAndActivityId.HandleId, "db_kurotato.db", "select BinData from `KurotatoExp` where RoleLevel=? AND ActivityId=?");
		}

		// Token: 0x06001B74 RID: 7028 RVA: 0x000F4768 File Offset: 0x000F2968
		public static KurotatoExp? GetConfig(int p0RoleLevel, int p1ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoExpByLevelAndActivityId.HandleId, ConfigKurotatoExpByLevelAndActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoExpByLevelAndActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleLevel);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new KurotatoExp?(KurotatoExp.GetRootAsKurotatoExp(configBuffer));
				}
			}
			ConfigKurotatoExpByLevelAndActivityId.LogPair.Clear();
			ConfigKurotatoExpByLevelAndActivityId.LogPair.Add(new ValueTuple<string, object>("RoleLevel", p0RoleLevel));
			ConfigKurotatoExpByLevelAndActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p1ActivityId));
			if (!ConfigCommon.BindInt(ConfigKurotatoExpByLevelAndActivityId.HandleId, 1, p0RoleLevel, ConfigKurotatoExpByLevelAndActivityId.LogPair) || !ConfigCommon.BindInt(ConfigKurotatoExpByLevelAndActivityId.HandleId, 2, p1ActivityId, ConfigKurotatoExpByLevelAndActivityId.LogPair) || ConfigCommon.Step(ConfigKurotatoExpByLevelAndActivityId.HandleId, true, ConfigKurotatoExpByLevelAndActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigKurotatoExpByLevelAndActivityId.HandleId, ConfigKurotatoExpByLevelAndActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoExpByLevelAndActivityId.HandleId, 0, ConfigKurotatoExpByLevelAndActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigKurotatoExpByLevelAndActivityId.HandleId, ConfigKurotatoExpByLevelAndActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			KurotatoExp rootAsKurotatoExp = KurotatoExp.GetRootAsKurotatoExp(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoExpByLevelAndActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleLevel);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigKurotatoExpByLevelAndActivityId.HandleId, ConfigKurotatoExpByLevelAndActivityId.LogPair);
			return new KurotatoExp?(rootAsKurotatoExp);
		}

		// Token: 0x06001B75 RID: 7029 RVA: 0x000F4938 File Offset: 0x000F2B38
		[NullableContext(2)]
		public static IReadOnlyList<KurotatoExp> GetConfigList(int p0RoleLevel, int p1ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigKurotatoExpByLevelAndActivityId.HandleId, ConfigKurotatoExpByLevelAndActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoExpByLevelAndActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleLevel);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1ActivityId);
				IReadOnlyList<KurotatoExp> readOnlyList = (IReadOnlyList<KurotatoExp>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigKurotatoExpByLevelAndActivityId.LogPair.Clear();
			ConfigKurotatoExpByLevelAndActivityId.LogPair.Add(new ValueTuple<string, object>("RoleLevel", p0RoleLevel));
			ConfigKurotatoExpByLevelAndActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p1ActivityId));
			if (!ConfigCommon.BindInt(ConfigKurotatoExpByLevelAndActivityId.HandleId, 1, p0RoleLevel, ConfigKurotatoExpByLevelAndActivityId.LogPair) || !ConfigCommon.BindInt(ConfigKurotatoExpByLevelAndActivityId.HandleId, 2, p1ActivityId, ConfigKurotatoExpByLevelAndActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigKurotatoExpByLevelAndActivityId.HandleId, ConfigKurotatoExpByLevelAndActivityId.LogPair);
				return null;
			}
			List<KurotatoExp> list = new List<KurotatoExp>();
			while (ConfigCommon.Step(ConfigKurotatoExpByLevelAndActivityId.HandleId, false, ConfigKurotatoExpByLevelAndActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigKurotatoExpByLevelAndActivityId.HandleId, 0, ConfigKurotatoExpByLevelAndActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigKurotatoExpByLevelAndActivityId.HandleId, ConfigKurotatoExpByLevelAndActivityId.LogPair);
					return null;
				}
				KurotatoExp rootAsKurotatoExp = KurotatoExp.GetRootAsKurotatoExp(new ByteBuffer(item2));
				list.Add(rootAsKurotatoExp);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("KurotatoExpByLevelAndActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleLevel);
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p1ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigKurotatoExpByLevelAndActivityId.HandleId, ConfigKurotatoExpByLevelAndActivityId.LogPair);
			return list;
		}

		// Token: 0x04001FDB RID: 8155
		private const string DB = "db_kurotato.db";

		// Token: 0x04001FDC RID: 8156
		private const string FILE = "t.土豆兄弟_局内.xlsx";

		// Token: 0x04001FDD RID: 8157
		private const string TABLE = "KurotatoExp";

		// Token: 0x04001FDE RID: 8158
		private const string COMMAND = "select BinData from `KurotatoExp` where RoleLevel=? AND ActivityId=?";

		// Token: 0x04001FDF RID: 8159
		private const string KEY_PREFIX = "KurotatoExpByLevelAndActivityId";

		// Token: 0x04001FE0 RID: 8160
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001FE1 RID: 8161
		private static int HandleId;
	}
}
