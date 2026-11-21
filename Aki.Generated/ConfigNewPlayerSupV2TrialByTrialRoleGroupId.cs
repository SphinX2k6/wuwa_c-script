using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000611 RID: 1553
	public class ConfigNewPlayerSupV2TrialByTrialRoleGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002475 RID: 9333 RVA: 0x0012B150 File Offset: 0x00129350
		static ConfigNewPlayerSupV2TrialByTrialRoleGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.CreateStaticDefaultValue), new Action(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06002476 RID: 9334 RVA: 0x0012B170 File Offset: 0x00129370
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

		// Token: 0x06002477 RID: 9335 RVA: 0x0012B1EF File Offset: 0x001293EF
		public static void ResetStaticDefaultValue()
		{
			ConfigNewPlayerSupV2TrialByTrialRoleGroupId.LogPair = null;
			ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId = 0;
		}

		// Token: 0x06002478 RID: 9336 RVA: 0x0012B1FD File Offset: 0x001293FD
		public static void Init()
		{
			ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigNewPlayerSupV2TrialByTrialRoleGroupId.HandleId, "db_newplayersupportactivityv2.db", "select BinData from `NewPlayerSupV2Trial` where TrialRoleGroupId=?");
		}

		// Token: 0x06002479 RID: 9337 RVA: 0x0012B218 File Offset: 0x00129418
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

		// Token: 0x0600247A RID: 9338 RVA: 0x0012B390 File Offset: 0x00129590
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

		// Token: 0x04002A5D RID: 10845
		private const string DB = "db_newplayersupportactivityv2.db";

		// Token: 0x04002A5E RID: 10846
		private const string FILE = "x.新玩家助力活动V2.xlsx";

		// Token: 0x04002A5F RID: 10847
		private const string TABLE = "NewPlayerSupV2Trial";

		// Token: 0x04002A60 RID: 10848
		private const string COMMAND = "select BinData from `NewPlayerSupV2Trial` where TrialRoleGroupId=?";

		// Token: 0x04002A61 RID: 10849
		private const string KEY_PREFIX = "NewPlayerSupV2TrialByTrialRoleGroupId";

		// Token: 0x04002A62 RID: 10850
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A63 RID: 10851
		private static int HandleId;
	}
}
