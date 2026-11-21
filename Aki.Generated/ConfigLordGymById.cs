using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200050B RID: 1291
	public class ConfigLordGymById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E4D RID: 7757 RVA: 0x0010814B File Offset: 0x0010634B
		static ConfigLordGymById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLordGymById.CreateStaticDefaultValue), new Action(ConfigLordGymById.ResetStaticDefaultValue));
		}

		// Token: 0x06001E4E RID: 7758 RVA: 0x0010816C File Offset: 0x0010636C
		public static void CreateStaticDefaultValue()
		{
			ConfigLordGymById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLordGymById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lordgym.db"),
				new ValueTuple<string, object>("文件", "l.领主道馆.xlsx"),
				new ValueTuple<string, object>("表名", "LordGym"),
				new ValueTuple<string, object>("语句", "select BinData from `LordGym` where Id=?")
			});
		}

		// Token: 0x06001E4F RID: 7759 RVA: 0x001081EB File Offset: 0x001063EB
		public static void ResetStaticDefaultValue()
		{
			ConfigLordGymById.LogPair = null;
			ConfigLordGymById.HandleId = 0;
		}

		// Token: 0x06001E50 RID: 7760 RVA: 0x001081F9 File Offset: 0x001063F9
		public static void Init()
		{
			ConfigLordGymById.HandleId = ConfigCommon.InitDataStatement(ConfigLordGymById.HandleId, "db_lordgym.db", "select BinData from `LordGym` where Id=?");
		}

		// Token: 0x06001E51 RID: 7761 RVA: 0x00108214 File Offset: 0x00106414
		public static LordGym? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLordGymById.HandleId, ConfigLordGymById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LordGym?(LordGym.GetRootAsLordGym(configBuffer));
				}
			}
			ConfigLordGymById.LogPair.Clear();
			ConfigLordGymById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLordGymById.HandleId, 1, p0Id, ConfigLordGymById.LogPair) || ConfigCommon.Step(ConfigLordGymById.HandleId, true, ConfigLordGymById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLordGymById.HandleId, ConfigLordGymById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLordGymById.HandleId, 0, ConfigLordGymById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLordGymById.HandleId, ConfigLordGymById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LordGym rootAsLordGym = LordGym.GetRootAsLordGym(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LordGymById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLordGymById.HandleId, ConfigLordGymById.LogPair);
			return new LordGym?(rootAsLordGym);
		}

		// Token: 0x04002331 RID: 9009
		private const string DB = "db_lordgym.db";

		// Token: 0x04002332 RID: 9010
		private const string FILE = "l.领主道馆.xlsx";

		// Token: 0x04002333 RID: 9011
		private const string TABLE = "LordGym";

		// Token: 0x04002334 RID: 9012
		private const string COMMAND = "select BinData from `LordGym` where Id=?";

		// Token: 0x04002335 RID: 9013
		private const string KEY_PREFIX = "LordGymById";

		// Token: 0x04002336 RID: 9014
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002337 RID: 9015
		private static int HandleId;
	}
}
