using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000578 RID: 1400
	public class ConfigMoraleAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060020DD RID: 8413 RVA: 0x00116B5B File Offset: 0x00114D5B
		static ConfigMoraleAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleAreaById.CreateStaticDefaultValue), new Action(ConfigMoraleAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00116B7C File Offset: 0x00114D7C
		public static void CreateStaticDefaultValue()
		{
			ConfigMoraleAreaById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoraleAreaById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoraleArea"),
				new ValueTuple<string, object>("语句", "select BinData from `MoraleArea` where Id=?")
			});
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00116BFB File Offset: 0x00114DFB
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleAreaById.LogPair = null;
			ConfigMoraleAreaById.HandleId = 0;
		}

		// Token: 0x060020E0 RID: 8416 RVA: 0x00116C09 File Offset: 0x00114E09
		public static void Init()
		{
			ConfigMoraleAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleAreaById.HandleId, "db_moraleplay.db", "select BinData from `MoraleArea` where Id=?");
		}

		// Token: 0x060020E1 RID: 8417 RVA: 0x00116C24 File Offset: 0x00114E24
		public static MoraleArea? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoraleAreaById.HandleId, ConfigMoraleAreaById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoraleArea?(MoraleArea.GetRootAsMoraleArea(configBuffer));
				}
			}
			ConfigMoraleAreaById.LogPair.Clear();
			ConfigMoraleAreaById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMoraleAreaById.HandleId, 1, p0Id, ConfigMoraleAreaById.LogPair) || ConfigCommon.Step(ConfigMoraleAreaById.HandleId, true, ConfigMoraleAreaById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoraleAreaById.HandleId, ConfigMoraleAreaById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoraleAreaById.HandleId, 0, ConfigMoraleAreaById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoraleAreaById.HandleId, ConfigMoraleAreaById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoraleArea rootAsMoraleArea = MoraleArea.GetRootAsMoraleArea(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoraleAreaById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoraleAreaById.HandleId, ConfigMoraleAreaById.LogPair);
			return new MoraleArea?(rootAsMoraleArea);
		}

		// Token: 0x0400262C RID: 9772
		private const string DB = "db_moraleplay.db";

		// Token: 0x0400262D RID: 9773
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x0400262E RID: 9774
		private const string TABLE = "MoraleArea";

		// Token: 0x0400262F RID: 9775
		private const string COMMAND = "select BinData from `MoraleArea` where Id=?";

		// Token: 0x04002630 RID: 9776
		private const string KEY_PREFIX = "MoraleAreaById";

		// Token: 0x04002631 RID: 9777
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002632 RID: 9778
		private static int HandleId;
	}
}
