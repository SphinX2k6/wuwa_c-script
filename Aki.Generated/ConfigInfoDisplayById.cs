using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200041E RID: 1054
	public class ConfigInfoDisplayById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018BD RID: 6333 RVA: 0x000E5918 File Offset: 0x000E3B18
		static ConfigInfoDisplayById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfoDisplayById.CreateStaticDefaultValue), new Action(ConfigInfoDisplayById.ResetStaticDefaultValue));
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x000E5938 File Offset: 0x000E3B38
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

		// Token: 0x060018BF RID: 6335 RVA: 0x000E59B7 File Offset: 0x000E3BB7
		public static void ResetStaticDefaultValue()
		{
			ConfigInfoDisplayById.LogPair = null;
			ConfigInfoDisplayById.HandleId = 0;
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x000E59C5 File Offset: 0x000E3BC5
		public static void Init()
		{
			ConfigInfoDisplayById.HandleId = ConfigCommon.InitDataStatement(ConfigInfoDisplayById.HandleId, "db_infodisplay.db", "select BinData from `InfoDisplay` where Id=?");
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x000E59E0 File Offset: 0x000E3BE0
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

		// Token: 0x04001CB6 RID: 7350
		private const string DB = "db_infodisplay.db";

		// Token: 0x04001CB7 RID: 7351
		private const string FILE = "x.信息展示.xlsx";

		// Token: 0x04001CB8 RID: 7352
		private const string TABLE = "InfoDisplay";

		// Token: 0x04001CB9 RID: 7353
		private const string COMMAND = "select BinData from `InfoDisplay` where Id=?";

		// Token: 0x04001CBA RID: 7354
		private const string KEY_PREFIX = "InfoDisplayById";

		// Token: 0x04001CBB RID: 7355
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CBC RID: 7356
		private static int HandleId;
	}
}
