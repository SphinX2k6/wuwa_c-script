using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A32 RID: 2610
	public class ConfigTrapDefenseMapByMapId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D40 RID: 15680 RVA: 0x001B4263 File Offset: 0x001B2463
		static ConfigTrapDefenseMapByMapId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigTrapDefenseMapByMapId.CreateStaticDefaultValue), new Action(ConfigTrapDefenseMapByMapId.ResetStaticDefaultValue));
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x001B4284 File Offset: 0x001B2484
		public static void CreateStaticDefaultValue()
		{
			ConfigTrapDefenseMapByMapId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigTrapDefenseMapByMapId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_trapdefense.db"),
				new ValueTuple<string, object>("文件", "x.陷阱塔防活动.xlsx"),
				new ValueTuple<string, object>("表名", "TrapDefenseMap"),
				new ValueTuple<string, object>("语句", "select BinData from `TrapDefenseMap` where MapId=?")
			});
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x001B4303 File Offset: 0x001B2503
		public static void ResetStaticDefaultValue()
		{
			ConfigTrapDefenseMapByMapId.LogPair = null;
			ConfigTrapDefenseMapByMapId.HandleId = 0;
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x001B4311 File Offset: 0x001B2511
		public static void Init()
		{
			ConfigTrapDefenseMapByMapId.HandleId = ConfigCommon.InitDataStatement(ConfigTrapDefenseMapByMapId.HandleId, "db_trapdefense.db", "select BinData from `TrapDefenseMap` where MapId=?");
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x001B432C File Offset: 0x001B252C
		public static TrapDefenseMap? GetConfig(int p0MapId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigTrapDefenseMapByMapId.HandleId, ConfigTrapDefenseMapByMapId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMapByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new TrapDefenseMap?(TrapDefenseMap.GetRootAsTrapDefenseMap(configBuffer));
				}
			}
			ConfigTrapDefenseMapByMapId.LogPair.Clear();
			ConfigTrapDefenseMapByMapId.LogPair.Add(new ValueTuple<string, object>("MapId", p0MapId));
			if (!ConfigCommon.BindInt(ConfigTrapDefenseMapByMapId.HandleId, 1, p0MapId, ConfigTrapDefenseMapByMapId.LogPair) || ConfigCommon.Step(ConfigTrapDefenseMapByMapId.HandleId, true, ConfigTrapDefenseMapByMapId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMapByMapId.HandleId, ConfigTrapDefenseMapByMapId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigTrapDefenseMapByMapId.HandleId, 0, ConfigTrapDefenseMapByMapId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigTrapDefenseMapByMapId.HandleId, ConfigTrapDefenseMapByMapId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			TrapDefenseMap rootAsTrapDefenseMap = TrapDefenseMap.GetRootAsTrapDefenseMap(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("TrapDefenseMapByMapId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MapId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigTrapDefenseMapByMapId.HandleId, ConfigTrapDefenseMapByMapId.LogPair);
			return new TrapDefenseMap?(rootAsTrapDefenseMap);
		}

		// Token: 0x04004744 RID: 18244
		private const string DB = "db_trapdefense.db";

		// Token: 0x04004745 RID: 18245
		private const string FILE = "x.陷阱塔防活动.xlsx";

		// Token: 0x04004746 RID: 18246
		private const string TABLE = "TrapDefenseMap";

		// Token: 0x04004747 RID: 18247
		private const string COMMAND = "select BinData from `TrapDefenseMap` where MapId=?";

		// Token: 0x04004748 RID: 18248
		private const string KEY_PREFIX = "TrapDefenseMapByMapId";

		// Token: 0x04004749 RID: 18249
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400474A RID: 18250
		private static int HandleId;
	}
}
