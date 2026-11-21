using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000343 RID: 835
	public class ConfigFloroRanchTechById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001397 RID: 5015 RVA: 0x000CBA73 File Offset: 0x000C9C73
		static ConfigFloroRanchTechById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTechById.CreateStaticDefaultValue), new Action(ConfigFloroRanchTechById.ResetStaticDefaultValue));
		}

		// Token: 0x06001398 RID: 5016 RVA: 0x000CBA94 File Offset: 0x000C9C94
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchTechById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchTechById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchTech"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchTech` where Id=?")
			});
		}

		// Token: 0x06001399 RID: 5017 RVA: 0x000CBB13 File Offset: 0x000C9D13
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTechById.LogPair = null;
			ConfigFloroRanchTechById.HandleId = 0;
		}

		// Token: 0x0600139A RID: 5018 RVA: 0x000CBB21 File Offset: 0x000C9D21
		public static void Init()
		{
			ConfigFloroRanchTechById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTechById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTech` where Id=?");
		}

		// Token: 0x0600139B RID: 5019 RVA: 0x000CBB3C File Offset: 0x000C9D3C
		public static FloroRanchTech? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchTechById.HandleId, ConfigFloroRanchTechById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTechById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchTech?(FloroRanchTech.GetRootAsFloroRanchTech(configBuffer));
				}
			}
			ConfigFloroRanchTechById.LogPair.Clear();
			ConfigFloroRanchTechById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchTechById.HandleId, 1, p0Id, ConfigFloroRanchTechById.LogPair) || ConfigCommon.Step(ConfigFloroRanchTechById.HandleId, true, ConfigFloroRanchTechById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchTechById.HandleId, ConfigFloroRanchTechById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchTechById.HandleId, 0, ConfigFloroRanchTechById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchTechById.HandleId, ConfigFloroRanchTechById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchTech rootAsFloroRanchTech = FloroRanchTech.GetRootAsFloroRanchTech(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchTechById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchTechById.HandleId, ConfigFloroRanchTechById.LogPair);
			return new FloroRanchTech?(rootAsFloroRanchTech);
		}

		// Token: 0x040016B9 RID: 5817
		private const string DB = "db_flororanch.db";

		// Token: 0x040016BA RID: 5818
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x040016BB RID: 5819
		private const string TABLE = "FloroRanchTech";

		// Token: 0x040016BC RID: 5820
		private const string COMMAND = "select BinData from `FloroRanchTech` where Id=?";

		// Token: 0x040016BD RID: 5821
		private const string KEY_PREFIX = "FloroRanchTechById";

		// Token: 0x040016BE RID: 5822
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040016BF RID: 5823
		private static int HandleId;
	}
}
