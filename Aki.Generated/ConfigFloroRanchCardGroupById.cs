using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000314 RID: 788
	public class ConfigFloroRanchCardGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600127D RID: 4733 RVA: 0x000C1FF7 File Offset: 0x000C01F7
		static ConfigFloroRanchCardGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchCardGroupById.CreateStaticDefaultValue), new Action(ConfigFloroRanchCardGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x000C2018 File Offset: 0x000C0218
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchCardGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchCardGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanch.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchCardGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchCardGroup` where Id=?")
			});
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x000C2097 File Offset: 0x000C0297
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchCardGroupById.LogPair = null;
			ConfigFloroRanchCardGroupById.HandleId = 0;
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x000C20A5 File Offset: 0x000C02A5
		public static void Init()
		{
			ConfigFloroRanchCardGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchCardGroupById.HandleId, "db_flororanch.db", "select BinData from `FloroRanchCardGroup` where Id=?");
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x000C20C0 File Offset: 0x000C02C0
		public static FloroRanchCardGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchCardGroupById.HandleId, ConfigFloroRanchCardGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchCardGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchCardGroup?(FloroRanchCardGroup.GetRootAsFloroRanchCardGroup(configBuffer));
				}
			}
			ConfigFloroRanchCardGroupById.LogPair.Clear();
			ConfigFloroRanchCardGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchCardGroupById.HandleId, 1, p0Id, ConfigFloroRanchCardGroupById.LogPair) || ConfigCommon.Step(ConfigFloroRanchCardGroupById.HandleId, true, ConfigFloroRanchCardGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchCardGroupById.HandleId, ConfigFloroRanchCardGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchCardGroupById.HandleId, 0, ConfigFloroRanchCardGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchCardGroupById.HandleId, ConfigFloroRanchCardGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchCardGroup rootAsFloroRanchCardGroup = FloroRanchCardGroup.GetRootAsFloroRanchCardGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchCardGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchCardGroupById.HandleId, ConfigFloroRanchCardGroupById.LogPair);
			return new FloroRanchCardGroup?(rootAsFloroRanchCardGroup);
		}

		// Token: 0x04001570 RID: 5488
		private const string DB = "db_flororanch.db";

		// Token: 0x04001571 RID: 5489
		private const string FILE = "f.弗洛洛牧场.xlsx";

		// Token: 0x04001572 RID: 5490
		private const string TABLE = "FloroRanchCardGroup";

		// Token: 0x04001573 RID: 5491
		private const string COMMAND = "select BinData from `FloroRanchCardGroup` where Id=?";

		// Token: 0x04001574 RID: 5492
		private const string KEY_PREFIX = "FloroRanchCardGroupById";

		// Token: 0x04001575 RID: 5493
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001576 RID: 5494
		private static int HandleId;
	}
}
