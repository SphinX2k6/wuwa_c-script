using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000634 RID: 1588
	public class ConfigNpcHeadInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002548 RID: 9544 RVA: 0x0012FF17 File Offset: 0x0012E117
		static ConfigNpcHeadInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNpcHeadInfoById.CreateStaticDefaultValue), new Action(ConfigNpcHeadInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x0012FF38 File Offset: 0x0012E138
		public static void CreateStaticDefaultValue()
		{
			ConfigNpcHeadInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNpcHeadInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_npc_headinfo.db"),
				new ValueTuple<string, object>("文件", "n.NPC头顶信息.xlsx"),
				new ValueTuple<string, object>("表名", "NpcHeadInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `NpcHeadInfo` where Id=?")
			});
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x0012FFB7 File Offset: 0x0012E1B7
		public static void ResetStaticDefaultValue()
		{
			ConfigNpcHeadInfoById.LogPair = null;
			ConfigNpcHeadInfoById.HandleId = 0;
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x0012FFC5 File Offset: 0x0012E1C5
		public static void Init()
		{
			ConfigNpcHeadInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigNpcHeadInfoById.HandleId, "db_npc_headinfo.db", "select BinData from `NpcHeadInfo` where Id=?");
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x0012FFE0 File Offset: 0x0012E1E0
		public static NpcHeadInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNpcHeadInfoById.HandleId, ConfigNpcHeadInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NpcHeadInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NpcHeadInfo?(NpcHeadInfo.GetRootAsNpcHeadInfo(configBuffer));
				}
			}
			ConfigNpcHeadInfoById.LogPair.Clear();
			ConfigNpcHeadInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigNpcHeadInfoById.HandleId, 1, p0Id, ConfigNpcHeadInfoById.LogPair) || ConfigCommon.Step(ConfigNpcHeadInfoById.HandleId, true, ConfigNpcHeadInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNpcHeadInfoById.HandleId, ConfigNpcHeadInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNpcHeadInfoById.HandleId, 0, ConfigNpcHeadInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNpcHeadInfoById.HandleId, ConfigNpcHeadInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NpcHeadInfo rootAsNpcHeadInfo = NpcHeadInfo.GetRootAsNpcHeadInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NpcHeadInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNpcHeadInfoById.HandleId, ConfigNpcHeadInfoById.LogPair);
			return new NpcHeadInfo?(rootAsNpcHeadInfo);
		}

		// Token: 0x04002B52 RID: 11090
		private const string DB = "db_npc_headinfo.db";

		// Token: 0x04002B53 RID: 11091
		private const string FILE = "n.NPC头顶信息.xlsx";

		// Token: 0x04002B54 RID: 11092
		private const string TABLE = "NpcHeadInfo";

		// Token: 0x04002B55 RID: 11093
		private const string COMMAND = "select BinData from `NpcHeadInfo` where Id=?";

		// Token: 0x04002B56 RID: 11094
		private const string KEY_PREFIX = "NpcHeadInfoById";

		// Token: 0x04002B57 RID: 11095
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B58 RID: 11096
		private static int HandleId;
	}
}
