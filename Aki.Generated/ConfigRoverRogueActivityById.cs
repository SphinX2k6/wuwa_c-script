using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008DC RID: 2268
	public class ConfigRoverRogueActivityById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600353B RID: 13627 RVA: 0x0018640C File Offset: 0x0018460C
		static ConfigRoverRogueActivityById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoverRogueActivityById.CreateStaticDefaultValue), new Action(ConfigRoverRogueActivityById.ResetStaticDefaultValue));
		}

		// Token: 0x0600353C RID: 13628 RVA: 0x0018642C File Offset: 0x0018462C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoverRogueActivityById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoverRogueActivityById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roverlike.db"),
				new ValueTuple<string, object>("文件", "f.俯视肉鸽_局外.xlsx"),
				new ValueTuple<string, object>("表名", "RoverRogueActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `RoverRogueActivity` where Id=?")
			});
		}

		// Token: 0x0600353D RID: 13629 RVA: 0x001864AB File Offset: 0x001846AB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoverRogueActivityById.LogPair = null;
			ConfigRoverRogueActivityById.HandleId = 0;
		}

		// Token: 0x0600353E RID: 13630 RVA: 0x001864B9 File Offset: 0x001846B9
		public static void Init()
		{
			ConfigRoverRogueActivityById.HandleId = ConfigCommon.InitDataStatement(ConfigRoverRogueActivityById.HandleId, "db_roverlike.db", "select BinData from `RoverRogueActivity` where Id=?");
		}

		// Token: 0x0600353F RID: 13631 RVA: 0x001864D4 File Offset: 0x001846D4
		public static RoverRogueActivity? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoverRogueActivityById.HandleId, ConfigRoverRogueActivityById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RoverRogueActivity?(RoverRogueActivity.GetRootAsRoverRogueActivity(configBuffer));
				}
			}
			ConfigRoverRogueActivityById.LogPair.Clear();
			ConfigRoverRogueActivityById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRoverRogueActivityById.HandleId, 1, p0Id, ConfigRoverRogueActivityById.LogPair) || ConfigCommon.Step(ConfigRoverRogueActivityById.HandleId, true, ConfigRoverRogueActivityById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRoverRogueActivityById.HandleId, ConfigRoverRogueActivityById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoverRogueActivityById.HandleId, 0, ConfigRoverRogueActivityById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRoverRogueActivityById.HandleId, ConfigRoverRogueActivityById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RoverRogueActivity rootAsRoverRogueActivity = RoverRogueActivity.GetRootAsRoverRogueActivity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RoverRogueActivityById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRoverRogueActivityById.HandleId, ConfigRoverRogueActivityById.LogPair);
			return new RoverRogueActivity?(rootAsRoverRogueActivity);
		}

		// Token: 0x04003DEA RID: 15850
		private const string DB = "db_roverlike.db";

		// Token: 0x04003DEB RID: 15851
		private const string FILE = "f.俯视肉鸽_局外.xlsx";

		// Token: 0x04003DEC RID: 15852
		private const string TABLE = "RoverRogueActivity";

		// Token: 0x04003DED RID: 15853
		private const string COMMAND = "select BinData from `RoverRogueActivity` where Id=?";

		// Token: 0x04003DEE RID: 15854
		private const string KEY_PREFIX = "RoverRogueActivityById";

		// Token: 0x04003DEF RID: 15855
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DF0 RID: 15856
		private static int HandleId;
	}
}
