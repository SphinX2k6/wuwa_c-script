using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000582 RID: 1410
	public class ConfigMoralePlayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002119 RID: 8473 RVA: 0x00118010 File Offset: 0x00116210
		static ConfigMoralePlayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoralePlayById.CreateStaticDefaultValue), new Action(ConfigMoralePlayById.ResetStaticDefaultValue));
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x00118030 File Offset: 0x00116230
		public static void CreateStaticDefaultValue()
		{
			ConfigMoralePlayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMoralePlayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moraleplay.db"),
				new ValueTuple<string, object>("文件", "c.插旗玩法.xlsx"),
				new ValueTuple<string, object>("表名", "MoralePlay"),
				new ValueTuple<string, object>("语句", "select BinData from `MoralePlay` where Id=?")
			});
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x001180AF File Offset: 0x001162AF
		public static void ResetStaticDefaultValue()
		{
			ConfigMoralePlayById.LogPair = null;
			ConfigMoralePlayById.HandleId = 0;
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x001180BD File Offset: 0x001162BD
		public static void Init()
		{
			ConfigMoralePlayById.HandleId = ConfigCommon.InitDataStatement(ConfigMoralePlayById.HandleId, "db_moraleplay.db", "select BinData from `MoralePlay` where Id=?");
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x001180D8 File Offset: 0x001162D8
		public static MoralePlay? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMoralePlayById.HandleId, ConfigMoralePlayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoralePlayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MoralePlay?(MoralePlay.GetRootAsMoralePlay(configBuffer));
				}
			}
			ConfigMoralePlayById.LogPair.Clear();
			ConfigMoralePlayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMoralePlayById.HandleId, 1, p0Id, ConfigMoralePlayById.LogPair) || ConfigCommon.Step(ConfigMoralePlayById.HandleId, true, ConfigMoralePlayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMoralePlayById.HandleId, ConfigMoralePlayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMoralePlayById.HandleId, 0, ConfigMoralePlayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMoralePlayById.HandleId, ConfigMoralePlayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MoralePlay rootAsMoralePlay = MoralePlay.GetRootAsMoralePlay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MoralePlayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMoralePlayById.HandleId, ConfigMoralePlayById.LogPair);
			return new MoralePlay?(rootAsMoralePlay);
		}

		// Token: 0x04002672 RID: 9842
		private const string DB = "db_moraleplay.db";

		// Token: 0x04002673 RID: 9843
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x04002674 RID: 9844
		private const string TABLE = "MoralePlay";

		// Token: 0x04002675 RID: 9845
		private const string COMMAND = "select BinData from `MoralePlay` where Id=?";

		// Token: 0x04002676 RID: 9846
		private const string KEY_PREFIX = "MoralePlayById";

		// Token: 0x04002677 RID: 9847
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002678 RID: 9848
		private static int HandleId;
	}
}
