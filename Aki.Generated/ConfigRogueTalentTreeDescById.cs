using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200086A RID: 2154
	public class ConfigRogueTalentTreeDescById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600328E RID: 12942 RVA: 0x00177470 File Offset: 0x00175670
		static ConfigRogueTalentTreeDescById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueTalentTreeDescById.CreateStaticDefaultValue), new Action(ConfigRogueTalentTreeDescById.ResetStaticDefaultValue));
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x00177490 File Offset: 0x00175690
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueTalentTreeDescById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueTalentTreeDescById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueTalentTreeDesc"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueTalentTreeDesc` where Id=?")
			});
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x0017750F File Offset: 0x0017570F
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueTalentTreeDescById.LogPair = null;
			ConfigRogueTalentTreeDescById.HandleId = 0;
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x0017751D File Offset: 0x0017571D
		public static void Init()
		{
			ConfigRogueTalentTreeDescById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueTalentTreeDescById.HandleId, "db_rogue.db", "select BinData from `RogueTalentTreeDesc` where Id=?");
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x00177538 File Offset: 0x00175738
		public static RogueTalentTreeDesc? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueTalentTreeDescById.HandleId, ConfigRogueTalentTreeDescById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueTalentTreeDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueTalentTreeDesc?(RogueTalentTreeDesc.GetRootAsRogueTalentTreeDesc(configBuffer));
				}
			}
			ConfigRogueTalentTreeDescById.LogPair.Clear();
			ConfigRogueTalentTreeDescById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueTalentTreeDescById.HandleId, 1, p0Id, ConfigRogueTalentTreeDescById.LogPair) || ConfigCommon.Step(ConfigRogueTalentTreeDescById.HandleId, true, ConfigRogueTalentTreeDescById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueTalentTreeDescById.HandleId, ConfigRogueTalentTreeDescById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueTalentTreeDescById.HandleId, 0, ConfigRogueTalentTreeDescById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueTalentTreeDescById.HandleId, ConfigRogueTalentTreeDescById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueTalentTreeDesc rootAsRogueTalentTreeDesc = RogueTalentTreeDesc.GetRootAsRogueTalentTreeDesc(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueTalentTreeDescById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueTalentTreeDescById.HandleId, ConfigRogueTalentTreeDescById.LogPair);
			return new RogueTalentTreeDesc?(rootAsRogueTalentTreeDesc);
		}

		// Token: 0x04003ACC RID: 15052
		private const string DB = "db_rogue.db";

		// Token: 0x04003ACD RID: 15053
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003ACE RID: 15054
		private const string TABLE = "RogueTalentTreeDesc";

		// Token: 0x04003ACF RID: 15055
		private const string COMMAND = "select BinData from `RogueTalentTreeDesc` where Id=?";

		// Token: 0x04003AD0 RID: 15056
		private const string KEY_PREFIX = "RogueTalentTreeDescById";

		// Token: 0x04003AD1 RID: 15057
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AD2 RID: 15058
		private static int HandleId;
	}
}
