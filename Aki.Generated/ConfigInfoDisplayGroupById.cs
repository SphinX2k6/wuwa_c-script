using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000435 RID: 1077
	public class ConfigInfoDisplayGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001947 RID: 6471 RVA: 0x000EC2B4 File Offset: 0x000EA4B4
		static ConfigInfoDisplayGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfoDisplayGroupById.CreateStaticDefaultValue), new Action(ConfigInfoDisplayGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06001948 RID: 6472 RVA: 0x000EC2D4 File Offset: 0x000EA4D4
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

		// Token: 0x06001949 RID: 6473 RVA: 0x000EC353 File Offset: 0x000EA553
		public static void ResetStaticDefaultValue()
		{
			ConfigInfoDisplayGroupById.LogPair = null;
			ConfigInfoDisplayGroupById.HandleId = 0;
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x000EC361 File Offset: 0x000EA561
		public static void Init()
		{
			ConfigInfoDisplayGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigInfoDisplayGroupById.HandleId, "db_infodisplay.db", "select BinData from `InfoDisplayGroup` where Id=?");
		}

		// Token: 0x0600194B RID: 6475 RVA: 0x000EC37C File Offset: 0x000EA57C
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

		// Token: 0x04001D57 RID: 7511
		private const string DB = "db_infodisplay.db";

		// Token: 0x04001D58 RID: 7512
		private const string FILE = "x.信息展示.xlsx";

		// Token: 0x04001D59 RID: 7513
		private const string TABLE = "InfoDisplayGroup";

		// Token: 0x04001D5A RID: 7514
		private const string COMMAND = "select BinData from `InfoDisplayGroup` where Id=?";

		// Token: 0x04001D5B RID: 7515
		private const string KEY_PREFIX = "InfoDisplayGroupById";

		// Token: 0x04001D5C RID: 7516
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D5D RID: 7517
		private static int HandleId;
	}
}
