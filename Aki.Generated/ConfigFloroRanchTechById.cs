using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200032E RID: 814
	public class ConfigFloroRanchTechById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001319 RID: 4889 RVA: 0x000C5567 File Offset: 0x000C3767
		static ConfigFloroRanchTechById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchTechById.CreateStaticDefaultValue), new Action(ConfigFloroRanchTechById.ResetStaticDefaultValue));
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x000C5588 File Offset: 0x000C3788
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

		// Token: 0x0600131B RID: 4891 RVA: 0x000C5607 File Offset: 0x000C3807
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchTechById.LogPair = null;
			ConfigFloroRanchTechById.HandleId = 0;
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x000C5615 File Offset: 0x000C3815
		public static void Init()
		{
			ConfigFloroRanchTechById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchTechById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchTech` where Id=?");
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x000C5630 File Offset: 0x000C3830
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

		// Token: 0x04001626 RID: 5670
		private const string DB = "db_flororanch.db";

		// Token: 0x04001627 RID: 5671
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001628 RID: 5672
		private const string TABLE = "FloroRanchTech";

		// Token: 0x04001629 RID: 5673
		private const string COMMAND = "select BinData from `FloroRanchTech` where Id=?";

		// Token: 0x0400162A RID: 5674
		private const string KEY_PREFIX = "FloroRanchTechById";

		// Token: 0x0400162B RID: 5675
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400162C RID: 5676
		private static int HandleId;
	}
}
