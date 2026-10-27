using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200061C RID: 1564
	public class ConfigNpcHeadInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024B8 RID: 9400 RVA: 0x0012949B File Offset: 0x0012769B
		static ConfigNpcHeadInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNpcHeadInfoById.CreateStaticDefaultValue), new Action(ConfigNpcHeadInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x001294BC File Offset: 0x001276BC
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

		// Token: 0x060024BA RID: 9402 RVA: 0x0012953B File Offset: 0x0012773B
		public static void ResetStaticDefaultValue()
		{
			ConfigNpcHeadInfoById.LogPair = null;
			ConfigNpcHeadInfoById.HandleId = 0;
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x00129549 File Offset: 0x00127749
		public static void Init()
		{
			ConfigNpcHeadInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigNpcHeadInfoById.HandleId, "db_npc_headinfo.db", "select BinData from `NpcHeadInfo` where Id=?");
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x00129564 File Offset: 0x00127764
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

		// Token: 0x04002AAA RID: 10922
		private const string DB = "db_npc_headinfo.db";

		// Token: 0x04002AAB RID: 10923
		private const string FILE = "n.NPC头顶信息.xlsx";

		// Token: 0x04002AAC RID: 10924
		private const string TABLE = "NpcHeadInfo";

		// Token: 0x04002AAD RID: 10925
		private const string COMMAND = "select BinData from `NpcHeadInfo` where Id=?";

		// Token: 0x04002AAE RID: 10926
		private const string KEY_PREFIX = "NpcHeadInfoById";

		// Token: 0x04002AAF RID: 10927
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AB0 RID: 10928
		private static int HandleId;
	}
}
