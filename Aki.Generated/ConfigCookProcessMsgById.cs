using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A2 RID: 418
	public class ConfigCookProcessMsgById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009CF RID: 2511 RVA: 0x00090E88 File Offset: 0x0008F088
		static ConfigCookProcessMsgById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookProcessMsgById.CreateStaticDefaultValue), new Action(ConfigCookProcessMsgById.ResetStaticDefaultValue));
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00090EA8 File Offset: 0x0008F0A8
		public static void CreateStaticDefaultValue()
		{
			ConfigCookProcessMsgById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCookProcessMsgById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cook.db"),
				new ValueTuple<string, object>("文件", "p.烹饪.xlsx"),
				new ValueTuple<string, object>("表名", "CookProcessMsg"),
				new ValueTuple<string, object>("语句", "select BinData from `CookProcessMsg` where Id=?")
			});
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00090F27 File Offset: 0x0008F127
		public static void ResetStaticDefaultValue()
		{
			ConfigCookProcessMsgById.LogPair = null;
			ConfigCookProcessMsgById.HandleId = 0;
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x00090F35 File Offset: 0x0008F135
		public static void Init()
		{
			ConfigCookProcessMsgById.HandleId = ConfigCommon.InitDataStatement(ConfigCookProcessMsgById.HandleId, "db_cook.db", "select BinData from `CookProcessMsg` where Id=?");
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00090F50 File Offset: 0x0008F150
		public static CookProcessMsg? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCookProcessMsgById.HandleId, ConfigCookProcessMsgById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookProcessMsgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CookProcessMsg?(CookProcessMsg.GetRootAsCookProcessMsg(configBuffer));
				}
			}
			ConfigCookProcessMsgById.LogPair.Clear();
			ConfigCookProcessMsgById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCookProcessMsgById.HandleId, 1, p0Id, ConfigCookProcessMsgById.LogPair) || ConfigCommon.Step(ConfigCookProcessMsgById.HandleId, true, ConfigCookProcessMsgById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCookProcessMsgById.HandleId, ConfigCookProcessMsgById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCookProcessMsgById.HandleId, 0, ConfigCookProcessMsgById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCookProcessMsgById.HandleId, ConfigCookProcessMsgById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CookProcessMsg rootAsCookProcessMsg = CookProcessMsg.GetRootAsCookProcessMsg(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookProcessMsgById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCookProcessMsgById.HandleId, ConfigCookProcessMsgById.LogPair);
			return new CookProcessMsg?(rootAsCookProcessMsg);
		}

		// Token: 0x04000B52 RID: 2898
		private const string DB = "db_cook.db";

		// Token: 0x04000B53 RID: 2899
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000B54 RID: 2900
		private const string TABLE = "CookProcessMsg";

		// Token: 0x04000B55 RID: 2901
		private const string COMMAND = "select BinData from `CookProcessMsg` where Id=?";

		// Token: 0x04000B56 RID: 2902
		private const string KEY_PREFIX = "CookProcessMsgById";

		// Token: 0x04000B57 RID: 2903
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B58 RID: 2904
		private static int HandleId;
	}
}
