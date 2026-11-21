using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001A6 RID: 422
	public class ConfigConfirmBoxById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009E7 RID: 2535 RVA: 0x00095154 File Offset: 0x00093354
		static ConfigConfirmBoxById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigConfirmBoxById.CreateStaticDefaultValue), new Action(ConfigConfirmBoxById.ResetStaticDefaultValue));
		}

		// Token: 0x060009E8 RID: 2536 RVA: 0x00095174 File Offset: 0x00093374
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

		// Token: 0x060009E9 RID: 2537 RVA: 0x000951F3 File Offset: 0x000933F3
		public static void ResetStaticDefaultValue()
		{
			ConfigConfirmBoxById.LogPair = null;
			ConfigConfirmBoxById.HandleId = 0;
		}

		// Token: 0x060009EA RID: 2538 RVA: 0x00095201 File Offset: 0x00093401
		public static void Init()
		{
			ConfigConfirmBoxById.HandleId = ConfigCommon.InitDataStatement(ConfigConfirmBoxById.HandleId, "db_confirmbox.db", "select BinData from `ConfirmBox` where Id=?");
		}

		// Token: 0x060009EB RID: 2539 RVA: 0x0009521C File Offset: 0x0009341C
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

		// Token: 0x04000B6E RID: 2926
		private const string DB = "db_confirmbox.db";

		// Token: 0x04000B6F RID: 2927
		private const string FILE = "q.确认框.xlsx";

		// Token: 0x04000B70 RID: 2928
		private const string TABLE = "ConfirmBox";

		// Token: 0x04000B71 RID: 2929
		private const string COMMAND = "select BinData from `ConfirmBox` where Id=?";

		// Token: 0x04000B72 RID: 2930
		private const string KEY_PREFIX = "ConfirmBoxById";

		// Token: 0x04000B73 RID: 2931
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B74 RID: 2932
		private static int HandleId;
	}
}
