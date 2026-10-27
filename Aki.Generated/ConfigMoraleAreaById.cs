using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000562 RID: 1378
	public class ConfigMoraleAreaById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002059 RID: 8281 RVA: 0x00110407 File Offset: 0x0010E607
		static ConfigMoraleAreaById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoraleAreaById.CreateStaticDefaultValue), new Action(ConfigMoraleAreaById.ResetStaticDefaultValue));
		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00110428 File Offset: 0x0010E628
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

		// Token: 0x0600205B RID: 8283 RVA: 0x001104A7 File Offset: 0x0010E6A7
		public static void ResetStaticDefaultValue()
		{
			ConfigMoraleAreaById.LogPair = null;
			ConfigMoraleAreaById.HandleId = 0;
		}

		// Token: 0x0600205C RID: 8284 RVA: 0x001104B5 File Offset: 0x0010E6B5
		public static void Init()
		{
			ConfigMoraleAreaById.HandleId = ConfigCommon.InitDataStatement(ConfigMoraleAreaById.HandleId, "db_moraleplay.db", "select BinData from `MoraleArea` where Id=?");
		}

		// Token: 0x0600205D RID: 8285 RVA: 0x001104D0 File Offset: 0x0010E6D0
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

		// Token: 0x04002592 RID: 9618
		private const string DB = "db_moraleplay.db";

		// Token: 0x04002593 RID: 9619
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04002594 RID: 9620
		private const string TABLE = "MoraleArea";

		// Token: 0x04002595 RID: 9621
		private const string COMMAND = "select BinData from `MoraleArea` where Id=?";

		// Token: 0x04002596 RID: 9622
		private const string KEY_PREFIX = "MoraleAreaById";

		// Token: 0x04002597 RID: 9623
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002598 RID: 9624
		private static int HandleId;
	}
}
