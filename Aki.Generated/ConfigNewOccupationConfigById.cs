using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005F2 RID: 1522
	public class ConfigNewOccupationConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060023BB RID: 9147 RVA: 0x001238A3 File Offset: 0x00121AA3
		static ConfigNewOccupationConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewOccupationConfigById.CreateStaticDefaultValue), new Action(ConfigNewOccupationConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x001238C4 File Offset: 0x00121AC4
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

		// Token: 0x060023BD RID: 9149 RVA: 0x00123943 File Offset: 0x00121B43
		public static void ResetStaticDefaultValue()
		{
			ConfigNewOccupationConfigById.LogPair = null;
			ConfigNewOccupationConfigById.HandleId = 0;
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x00123951 File Offset: 0x00121B51
		public static void Init()
		{
			ConfigNewOccupationConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigNewOccupationConfigById.HandleId, "db_new_occupation.db", "select BinData from `NewOccupationConfig` where Id=?");
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x0012396C File Offset: 0x00121B6C
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

		// Token: 0x04002984 RID: 10628
		private const string DB = "db_new_occupation.db";

		// Token: 0x04002985 RID: 10629
		private const string FILE = "UniverseEditor/Occupation/无音区玩法占用_Json_Occupation.csv";

		// Token: 0x04002986 RID: 10630
		private const string TABLE = "NewOccupationConfig";

		// Token: 0x04002987 RID: 10631
		private const string COMMAND = "select BinData from `NewOccupationConfig` where Id=?";

		// Token: 0x04002988 RID: 10632
		private const string KEY_PREFIX = "NewOccupationConfigById";

		// Token: 0x04002989 RID: 10633
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400298A RID: 10634
		private static int HandleId;
	}
}
