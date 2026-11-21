using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000434 RID: 1076
	public class ConfigInfoDisplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001941 RID: 6465 RVA: 0x000EC06C File Offset: 0x000EA26C
		static ConfigInfoDisplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfoDisplayById.CreateStaticDefaultValue), new Action(ConfigInfoDisplayById.ResetStaticDefaultValue));
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x000EC08C File Offset: 0x000EA28C
		public static void CreateStaticDefaultValue()
		{
			ConfigInfoDisplayById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfoDisplayById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infodisplay.db"),
				new ValueTuple<string, object>("文件", "x.信息展示.xlsx"),
				new ValueTuple<string, object>("表名", "InfoDisplay"),
				new ValueTuple<string, object>("语句", "select BinData from `InfoDisplay` where Id=?")
			});
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x000EC10B File Offset: 0x000EA30B
		public static void ResetStaticDefaultValue()
		{
			ConfigInfoDisplayById.LogPair = null;
			ConfigInfoDisplayById.HandleId = 0;
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x000EC119 File Offset: 0x000EA319
		public static void Init()
		{
			ConfigInfoDisplayById.HandleId = ConfigCommon.InitDataStatement(ConfigInfoDisplayById.HandleId, "db_infodisplay.db", "select BinData from `InfoDisplay` where Id=?");
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x000EC134 File Offset: 0x000EA334
		public static InfoDisplay? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfoDisplayById.HandleId, ConfigInfoDisplayById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfoDisplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfoDisplay?(InfoDisplay.GetRootAsInfoDisplay(configBuffer));
				}
			}
			ConfigInfoDisplayById.LogPair.Clear();
			ConfigInfoDisplayById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInfoDisplayById.HandleId, 1, p0Id, ConfigInfoDisplayById.LogPair) || ConfigCommon.Step(ConfigInfoDisplayById.HandleId, true, ConfigInfoDisplayById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfoDisplayById.HandleId, ConfigInfoDisplayById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfoDisplayById.HandleId, 0, ConfigInfoDisplayById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfoDisplayById.HandleId, ConfigInfoDisplayById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfoDisplay rootAsInfoDisplay = InfoDisplay.GetRootAsInfoDisplay(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfoDisplayById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfoDisplayById.HandleId, ConfigInfoDisplayById.LogPair);
			return new InfoDisplay?(rootAsInfoDisplay);
		}

		// Token: 0x04001D50 RID: 7504
		private const string DB = "db_infodisplay.db";

		// Token: 0x04001D51 RID: 7505
		private const string FILE = "x.信息展示.xlsx";

		// Token: 0x04001D52 RID: 7506
		private const string TABLE = "InfoDisplay";

		// Token: 0x04001D53 RID: 7507
		private const string COMMAND = "select BinData from `InfoDisplay` where Id=?";

		// Token: 0x04001D54 RID: 7508
		private const string KEY_PREFIX = "InfoDisplayById";

		// Token: 0x04001D55 RID: 7509
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D56 RID: 7510
		private static int HandleId;
	}
}
