using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200060A RID: 1546
	public class ConfigNewOccupationConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600244B RID: 9291 RVA: 0x0012A31F File Offset: 0x0012851F
		static ConfigNewOccupationConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewOccupationConfigById.CreateStaticDefaultValue), new Action(ConfigNewOccupationConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x0012A340 File Offset: 0x00128540
		public static void CreateStaticDefaultValue()
		{
			ConfigNewOccupationConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewOccupationConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_new_occupation.db"),
				new ValueTuple<string, object>("文件", "UniverseEditor/Occupation/无音区玩法占用_Json_Occupation.csv"),
				new ValueTuple<string, object>("表名", "NewOccupationConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `NewOccupationConfig` where Id=?")
			});
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x0012A3BF File Offset: 0x001285BF
		public static void ResetStaticDefaultValue()
		{
			ConfigNewOccupationConfigById.LogPair = null;
			ConfigNewOccupationConfigById.HandleId = 0;
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x0012A3CD File Offset: 0x001285CD
		public static void Init()
		{
			ConfigNewOccupationConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigNewOccupationConfigById.HandleId, "db_new_occupation.db", "select BinData from `NewOccupationConfig` where Id=?");
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x0012A3E8 File Offset: 0x001285E8
		public static NewOccupationConfig? GetConfig(string p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewOccupationConfigById.HandleId, ConfigNewOccupationConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer("NewOccupationConfigById#" + p0Id);
				if (configBuffer != null)
				{
					return new NewOccupationConfig?(NewOccupationConfig.GetRootAsNewOccupationConfig(configBuffer));
				}
			}
			ConfigNewOccupationConfigById.LogPair.Clear();
			ConfigNewOccupationConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindString(ConfigNewOccupationConfigById.HandleId, 1, p0Id, ConfigNewOccupationConfigById.LogPair) || ConfigCommon.Step(ConfigNewOccupationConfigById.HandleId, true, ConfigNewOccupationConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewOccupationConfigById.HandleId, ConfigNewOccupationConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewOccupationConfigById.HandleId, 0, ConfigNewOccupationConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewOccupationConfigById.HandleId, ConfigNewOccupationConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewOccupationConfig rootAsNewOccupationConfig = NewOccupationConfig.GetRootAsNewOccupationConfig(byteBuffer);
			if (useCache)
			{
				ConfigCommon.SaveConfigBuffer("NewOccupationConfigById#" + p0Id, byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewOccupationConfigById.HandleId, ConfigNewOccupationConfigById.LogPair);
			return new NewOccupationConfig?(rootAsNewOccupationConfig);
		}

		// Token: 0x04002A2C RID: 10796
		private const string DB = "db_new_occupation.db";

		// Token: 0x04002A2D RID: 10797
		private const string FILE = "UniverseEditor/Occupation/无音区玩法占用_Json_Occupation.csv";

		// Token: 0x04002A2E RID: 10798
		private const string TABLE = "NewOccupationConfig";

		// Token: 0x04002A2F RID: 10799
		private const string COMMAND = "select BinData from `NewOccupationConfig` where Id=?";

		// Token: 0x04002A30 RID: 10800
		private const string KEY_PREFIX = "NewOccupationConfigById";

		// Token: 0x04002A31 RID: 10801
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002A32 RID: 10802
		private static int HandleId;
	}
}
