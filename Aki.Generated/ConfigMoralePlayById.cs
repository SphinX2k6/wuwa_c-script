using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200056C RID: 1388
	public class ConfigMoralePlayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002095 RID: 8341 RVA: 0x001118BC File Offset: 0x0010FABC
		static ConfigMoralePlayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMoralePlayById.CreateStaticDefaultValue), new Action(ConfigMoralePlayById.ResetStaticDefaultValue));
		}

		// Token: 0x06002096 RID: 8342 RVA: 0x001118DC File Offset: 0x0010FADC
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

		// Token: 0x06002097 RID: 8343 RVA: 0x0011195B File Offset: 0x0010FB5B
		public static void ResetStaticDefaultValue()
		{
			ConfigMoralePlayById.LogPair = null;
			ConfigMoralePlayById.HandleId = 0;
		}

		// Token: 0x06002098 RID: 8344 RVA: 0x00111969 File Offset: 0x0010FB69
		public static void Init()
		{
			ConfigMoralePlayById.HandleId = ConfigCommon.InitDataStatement(ConfigMoralePlayById.HandleId, "db_moraleplay.db", "select BinData from `MoralePlay` where Id=?");
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00111984 File Offset: 0x0010FB84
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

		// Token: 0x040025D8 RID: 9688
		private const string DB = "db_moraleplay.db";

		// Token: 0x040025D9 RID: 9689
		private const string FILE = "c.插旗玩法.xlsx";

		// Token: 0x040025DA RID: 9690
		private const string TABLE = "MoralePlay";

		// Token: 0x040025DB RID: 9691
		private const string COMMAND = "select BinData from `MoralePlay` where Id=?";

		// Token: 0x040025DC RID: 9692
		private const string KEY_PREFIX = "MoralePlayById";

		// Token: 0x040025DD RID: 9693
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040025DE RID: 9694
		private static int HandleId;
	}
}
