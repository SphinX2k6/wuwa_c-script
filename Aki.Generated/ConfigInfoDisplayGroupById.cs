using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200041F RID: 1055
	public class ConfigInfoDisplayGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060018C3 RID: 6339 RVA: 0x000E5B60 File Offset: 0x000E3D60
		static ConfigInfoDisplayGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfoDisplayGroupById.CreateStaticDefaultValue), new Action(ConfigInfoDisplayGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x000E5B80 File Offset: 0x000E3D80
		public static void CreateStaticDefaultValue()
		{
			ConfigInfoDisplayGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfoDisplayGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_infodisplay.db"),
				new ValueTuple<string, object>("文件", "x.信息展示.xlsx"),
				new ValueTuple<string, object>("表名", "InfoDisplayGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `InfoDisplayGroup` where Id=?")
			});
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x000E5BFF File Offset: 0x000E3DFF
		public static void ResetStaticDefaultValue()
		{
			ConfigInfoDisplayGroupById.LogPair = null;
			ConfigInfoDisplayGroupById.HandleId = 0;
		}

		// Token: 0x060018C6 RID: 6342 RVA: 0x000E5C0D File Offset: 0x000E3E0D
		public static void Init()
		{
			ConfigInfoDisplayGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigInfoDisplayGroupById.HandleId, "db_infodisplay.db", "select BinData from `InfoDisplayGroup` where Id=?");
		}

		// Token: 0x060018C7 RID: 6343 RVA: 0x000E5C28 File Offset: 0x000E3E28
		public static InfoDisplayGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfoDisplayGroupById.HandleId, ConfigInfoDisplayGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfoDisplayGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new InfoDisplayGroup?(InfoDisplayGroup.GetRootAsInfoDisplayGroup(configBuffer));
				}
			}
			ConfigInfoDisplayGroupById.LogPair.Clear();
			ConfigInfoDisplayGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigInfoDisplayGroupById.HandleId, 1, p0Id, ConfigInfoDisplayGroupById.LogPair) || ConfigCommon.Step(ConfigInfoDisplayGroupById.HandleId, true, ConfigInfoDisplayGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigInfoDisplayGroupById.HandleId, ConfigInfoDisplayGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfoDisplayGroupById.HandleId, 0, ConfigInfoDisplayGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigInfoDisplayGroupById.HandleId, ConfigInfoDisplayGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			InfoDisplayGroup rootAsInfoDisplayGroup = InfoDisplayGroup.GetRootAsInfoDisplayGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("InfoDisplayGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigInfoDisplayGroupById.HandleId, ConfigInfoDisplayGroupById.LogPair);
			return new InfoDisplayGroup?(rootAsInfoDisplayGroup);
		}

		// Token: 0x04001CBD RID: 7357
		private const string DB = "db_infodisplay.db";

		// Token: 0x04001CBE RID: 7358
		private const string FILE = "x.信息展示.xlsx";

		// Token: 0x04001CBF RID: 7359
		private const string TABLE = "InfoDisplayGroup";

		// Token: 0x04001CC0 RID: 7360
		private const string COMMAND = "select BinData from `InfoDisplayGroup` where Id=?";

		// Token: 0x04001CC1 RID: 7361
		private const string KEY_PREFIX = "InfoDisplayGroupById";

		// Token: 0x04001CC2 RID: 7362
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001CC3 RID: 7363
		private static int HandleId;
	}
}
