using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200050D RID: 1293
	public class ConfigLordGymEntranceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E59 RID: 7769 RVA: 0x00108527 File Offset: 0x00106727
		static ConfigLordGymEntranceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymEntranceById.CreateStaticDefaultValue), new Action(ConfigLordGymEntranceById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x00108548 File Offset: 0x00106748
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymEntranceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymEntranceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGymEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGymEntrance` where Id=?")
			});
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x001085C7 File Offset: 0x001067C7
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymEntranceById.LogPair = null;
			ConfigLordGymEntranceById.HandleId = 0;
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x001085D5 File Offset: 0x001067D5
		public static void Init()
		{
			ConfigLordGymEntranceById.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymEntranceById.HandleId, "db_lordgym.db", "select BinData from `LordGymEntrance` where Id=?");
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x001085F0 File Offset: 0x001067F0
		public static LordGymEntrance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymEntranceById.HandleId, ConfigLordGymEntranceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LordGymEntrance?(LordGymEntrance.GetRootAsLordGymEntrance(configBuffer));
				}
			}
			ConfigLordGymEntranceById.LogPair.Clear();
			ConfigLordGymEntranceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLordGymEntranceById.HandleId, 1, p0Id, ConfigLordGymEntranceById.LogPair) || ConfigCommon.Step(ConfigLordGymEntranceById.HandleId, true, ConfigLordGymEntranceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLordGymEntranceById.HandleId, ConfigLordGymEntranceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymEntranceById.HandleId, 0, ConfigLordGymEntranceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLordGymEntranceById.HandleId, ConfigLordGymEntranceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LordGymEntrance rootAsLordGymEntrance = LordGymEntrance.GetRootAsLordGymEntrance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLordGymEntranceById.HandleId, ConfigLordGymEntranceById.LogPair);
			return new LordGymEntrance?(rootAsLordGymEntrance);
		}

		// Token: 0x0400233F RID: 9023
		private const string DB = "db_lordgym.db";

		// Token: 0x04002340 RID: 9024
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x04002341 RID: 9025
		private const string TABLE = "LordGymEntrance";

		// Token: 0x04002342 RID: 9026
		private const string COMMAND = "select BinData from `LordGymEntrance` where Id=?";

		// Token: 0x04002343 RID: 9027
		private const string KEY_PREFIX = "LordGymEntranceById";

		// Token: 0x04002344 RID: 9028
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002345 RID: 9029
		private static int HandleId;
	}
}
