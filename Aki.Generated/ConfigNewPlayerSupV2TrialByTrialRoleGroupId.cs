using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F9 RID: 1529
	public class ConfigNewPlayerSupV2TrialByTrialRoleGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023E5 RID: 9189 RVA: 0x001246D4 File Offset: 0x001228D4
		static ConfigNewPlayerSupV2TrialByTrialRoleGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.CreateStaticDefaultValue), new Action(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x060023E6 RID: 9190 RVA: 0x001246F4 File Offset: 0x001228F4
		public static void CreateStaticDefaultValue()
		{
			ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newplayersupportactivityv2.db"),
				new ValueTuple<string, object>("文件", "x.新玩家助力活动V2.xlsx"),
				new ValueTuple<string, object>("表名", "NewPlayerSupV2Trial"),
				new ValueTuple<string, object>("语句", "select BinData from `NewPlayerSupV2Trial` where TrialRoleGroupId=?")
			});
		}

		// Token: 0x060023E7 RID: 9191 RVA: 0x00124773 File Offset: 0x00122973
		public static void ResetStaticDefaultValue()
		{
			ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair = null;
			ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId = 0;
		}

		// Token: 0x060023E8 RID: 9192 RVA: 0x00124781 File Offset: 0x00122981
		public static void Init()
		{
			ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewPlayerSupV2Trial` where TrialRoleGroupId=?");
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x0012479C File Offset: 0x0012299C
		public static NewPlayerSupV2Trial? GetConfig(int p0TrialRoleGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewPlayerSupV2TrialByTrialRoleGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TrialRoleGroupId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewPlayerSupV2Trial?(NewPlayerSupV2Trial.GetRootAsNewPlayerSupV2Trial(configBuffer));
				}
			}
			ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair.Clear();
			ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair.Add(new ValueTuple<string, object>("TrialRoleGroupId", p0TrialRoleGroupId));
			if (!ConfigCommon.BindInt(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, 1, p0TrialRoleGroupId, ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair) || ConfigCommon.Step(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, true, ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, 0, ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewPlayerSupV2Trial rootAsNewPlayerSupV2Trial = NewPlayerSupV2Trial.GetRootAsNewPlayerSupV2Trial(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewPlayerSupV2TrialByTrialRoleGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TrialRoleGroupId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair);
			return new NewPlayerSupV2Trial?(rootAsNewPlayerSupV2Trial);
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x00124914 File Offset: 0x00122B14
		[NullableContext(2)]
		public static IReadOnlyList<NewPlayerSupV2Trial> GetConfigList(int p0TrialRoleGroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewPlayerSupV2TrialByTrialRoleGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TrialRoleGroupId);
				IReadOnlyList<NewPlayerSupV2Trial> readOnlyList = (IReadOnlyList<NewPlayerSupV2Trial>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair.Clear();
			ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair.Add(new ValueTuple<string, object>("TrialRoleGroupId", p0TrialRoleGroupId));
			if (!ConfigCommon.BindInt(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, 1, p0TrialRoleGroupId, ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair))
			{
				ConfigCommon.Reset(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair);
				return null;
			}
			List<NewPlayerSupV2Trial> list = new List<NewPlayerSupV2Trial>();
			while (ConfigCommon.Step(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, false, ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, 0, ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair);
					return null;
				}
				NewPlayerSupV2Trial rootAsNewPlayerSupV2Trial = NewPlayerSupV2Trial.GetRootAsNewPlayerSupV2Trial(new ByteBuffer(item2));
				list.Add(rootAsNewPlayerSupV2Trial);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewPlayerSupV2TrialByTrialRoleGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0TrialRoleGroupId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair);
			return list;
		}

		// Token: 0x040029B5 RID: 10677
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x040029B6 RID: 10678
		private const string FILE = "x.新玩家助力活动V2.xlsx";

		// Token: 0x040029B7 RID: 10679
		private const string TABLE = "NewPlayerSupV2Trial";

		// Token: 0x040029B8 RID: 10680
		private const string COMMAND = "select BinData from `NewPlayerSupV2Trial` where TrialRoleGroupId=?";

		// Token: 0x040029B9 RID: 10681
		private const string KEY_PREFIX = "NewPlayerSupV2TrialByTrialRoleGroupId";

		// Token: 0x040029BA RID: 10682
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029BB RID: 10683
		private static int HandleId;
	}
}
