using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000194 RID: 404
	public class ConfigConfirmBoxById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600097B RID: 2427 RVA: 0x0008F21C File Offset: 0x0008D41C
		static ConfigConfirmBoxById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConfirmBoxById.CreateStaticDefaultValue), new Action(ConfigConfirmBoxById.ResetStaticDefaultValue));
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x0008F23C File Offset: 0x0008D43C
		public static void CreateStaticDefaultValue()
		{
			ConfigConfirmBoxById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigConfirmBoxById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_confirmbox.db"),
				new ValueTuple<string, object>("文件", "q.确认框.xlsx"),
				new ValueTuple<string, object>("表名", "ConfirmBox"),
				new ValueTuple<string, object>("语句", "select BinData from `ConfirmBox` where Id=?")
			});
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x0008F2BB File Offset: 0x0008D4BB
		public static void ResetStaticDefaultValue()
		{
			ConfigConfirmBoxById.LogPair = null;
			ConfigConfirmBoxById.HandleId = 0;
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x0008F2C9 File Offset: 0x0008D4C9
		public static void Init()
		{
			ConfigConfirmBoxById.HandleId = ConfigCommon.InitDataStatement(ConfigConfirmBoxById.HandleId, "db_confirmbox.db", "select BinData from `ConfirmBox` where Id=?");
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0008F2E4 File Offset: 0x0008D4E4
		public static ConfirmBox? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigConfirmBoxById.HandleId, ConfigConfirmBoxById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ConfirmBoxById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ConfirmBox?(ConfirmBox.GetRootAsConfirmBox(configBuffer));
				}
			}
			ConfigConfirmBoxById.LogPair.Clear();
			ConfigConfirmBoxById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigConfirmBoxById.HandleId, 1, p0Id, ConfigConfirmBoxById.LogPair) || ConfigCommon.Step(ConfigConfirmBoxById.HandleId, true, ConfigConfirmBoxById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigConfirmBoxById.HandleId, ConfigConfirmBoxById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigConfirmBoxById.HandleId, 0, ConfigConfirmBoxById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigConfirmBoxById.HandleId, ConfigConfirmBoxById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ConfirmBox rootAsConfirmBox = ConfirmBox.GetRootAsConfirmBox(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ConfirmBoxById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigConfirmBoxById.HandleId, ConfigConfirmBoxById.LogPair);
			return new ConfirmBox?(rootAsConfirmBox);
		}

		// Token: 0x04000AF0 RID: 2800
		private const string DB = "db_confirmbox.db";

		// Token: 0x04000AF1 RID: 2801
		private const string FILE = "q.确认框.xlsx";

		// Token: 0x04000AF2 RID: 2802
		private const string TABLE = "ConfirmBox";

		// Token: 0x04000AF3 RID: 2803
		private const string COMMAND = "select BinData from `ConfirmBox` where Id=?";

		// Token: 0x04000AF4 RID: 2804
		private const string KEY_PREFIX = "ConfirmBoxById";

		// Token: 0x04000AF5 RID: 2805
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000AF6 RID: 2806
		private static int HandleId;
	}
}
