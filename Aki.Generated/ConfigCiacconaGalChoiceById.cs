using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000177 RID: 375
	public class ConfigCiacconaGalChoiceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060008CB RID: 2251 RVA: 0x0008EBCC File Offset: 0x0008CDCC
		static ConfigCiacconaGalChoiceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCiacconaGalChoiceById.CreateStaticDefaultValue), new Action(ConfigCiacconaGalChoiceById.ResetStaticDefaultValue));
		}

		// Token: 0x060008CC RID: 2252 RVA: 0x0008EBEC File Offset: 0x0008CDEC
		public static void CreateStaticDefaultValue()
		{
			ConfigCiacconaGalChoiceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCiacconaGalChoiceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ciacconagal.db"),
				new ValueTuple<string, object>("文件", "x.夏空活动.xlsx"),
				new ValueTuple<string, object>("表名", "CiacconaGalChoice"),
				new ValueTuple<string, object>("语句", "select BinData from `CiacconaGalChoice` where Id=?")
			});
		}

		// Token: 0x060008CD RID: 2253 RVA: 0x0008EC6B File Offset: 0x0008CE6B
		public static void ResetStaticDefaultValue()
		{
			ConfigCiacconaGalChoiceById.LogPair = null;
			ConfigCiacconaGalChoiceById.HandleId = 0;
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x0008EC79 File Offset: 0x0008CE79
		public static void Init()
		{
			ConfigCiacconaGalChoiceById.HandleId = ConfigCommon.InitDataStatement(ConfigCiacconaGalChoiceById.HandleId, "db_ciacconagal.db", "select BinData from `CiacconaGalChoice` where Id=?");
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x0008EC94 File Offset: 0x0008CE94
		public static CiacconaGalChoice? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCiacconaGalChoiceById.HandleId, ConfigCiacconaGalChoiceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalChoiceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CiacconaGalChoice?(CiacconaGalChoice.GetRootAsCiacconaGalChoice(configBuffer));
				}
			}
			ConfigCiacconaGalChoiceById.LogPair.Clear();
			ConfigCiacconaGalChoiceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCiacconaGalChoiceById.HandleId, 1, p0Id, ConfigCiacconaGalChoiceById.LogPair) || ConfigCommon.Step(ConfigCiacconaGalChoiceById.HandleId, true, ConfigCiacconaGalChoiceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCiacconaGalChoiceById.HandleId, ConfigCiacconaGalChoiceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCiacconaGalChoiceById.HandleId, 0, ConfigCiacconaGalChoiceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCiacconaGalChoiceById.HandleId, ConfigCiacconaGalChoiceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CiacconaGalChoice rootAsCiacconaGalChoice = CiacconaGalChoice.GetRootAsCiacconaGalChoice(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CiacconaGalChoiceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCiacconaGalChoiceById.HandleId, ConfigCiacconaGalChoiceById.LogPair);
			return new CiacconaGalChoice?(rootAsCiacconaGalChoice);
		}

		// Token: 0x04000A25 RID: 2597
		private const string DB = "db_ciacconagal.db";

		// Token: 0x04000A26 RID: 2598
		private const string FILE = "x.夏空活动.xlsx";

		// Token: 0x04000A27 RID: 2599
		private const string TABLE = "CiacconaGalChoice";

		// Token: 0x04000A28 RID: 2600
		private const string COMMAND = "select BinData from `CiacconaGalChoice` where Id=?";

		// Token: 0x04000A29 RID: 2601
		private const string KEY_PREFIX = "CiacconaGalChoiceById";

		// Token: 0x04000A2A RID: 2602
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000A2B RID: 2603
		private static int HandleId;
	}
}
