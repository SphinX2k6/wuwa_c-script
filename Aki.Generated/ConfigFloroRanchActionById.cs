using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200031F RID: 799
	public class ConfigFloroRanchActionById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012BF RID: 4799 RVA: 0x000C7114 File Offset: 0x000C5314
		static ConfigFloroRanchActionById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloroRanchActionById.CreateStaticDefaultValue), new Action(ConfigFloroRanchActionById.ResetStaticDefaultValue));
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x000C7134 File Offset: 0x000C5334
		public static void CreateStaticDefaultValue()
		{
			ConfigFloroRanchActionById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloroRanchActionById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_flororanchaction.db"),
				new ValueTuple<string, object>("文件", "f.弗洛洛牧场_行为.xlsx"),
				new ValueTuple<string, object>("表名", "FloroRanchAction"),
				new ValueTuple<string, object>("语句", "select BinData from `FloroRanchAction` where Id=?")
			});
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x000C71B3 File Offset: 0x000C53B3
		public static void ResetStaticDefaultValue()
		{
			ConfigFloroRanchActionById.LogPair = null;
			ConfigFloroRanchActionById.HandleId = 0;
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x000C71C1 File Offset: 0x000C53C1
		public static void Init()
		{
			ConfigFloroRanchActionById.HandleId = ConfigCommon.InitDataStatement(ConfigFloroRanchActionById.HandleId, "db_flororanchaction.db", "select BinData from `FloroRanchAction` where Id=?");
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x000C71DC File Offset: 0x000C53DC
		public static FloroRanchAction? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloroRanchActionById.HandleId, ConfigFloroRanchActionById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchActionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloroRanchAction?(FloroRanchAction.GetRootAsFloroRanchAction(configBuffer));
				}
			}
			ConfigFloroRanchActionById.LogPair.Clear();
			ConfigFloroRanchActionById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloroRanchActionById.HandleId, 1, p0Id, ConfigFloroRanchActionById.LogPair) || ConfigCommon.Step(ConfigFloroRanchActionById.HandleId, true, ConfigFloroRanchActionById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloroRanchActionById.HandleId, ConfigFloroRanchActionById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloroRanchActionById.HandleId, 0, ConfigFloroRanchActionById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloroRanchActionById.HandleId, ConfigFloroRanchActionById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloroRanchAction rootAsFloroRanchAction = FloroRanchAction.GetRootAsFloroRanchAction(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloroRanchActionById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloroRanchActionById.HandleId, ConfigFloroRanchActionById.LogPair);
			return new FloroRanchAction?(rootAsFloroRanchAction);
		}

		// Token: 0x040015BD RID: 5565
		private const string DB = "db_flororanchaction.db";

		// Token: 0x040015BE RID: 5566
		private const string FILE = "f.弗洛洛牧场_行为.xlsx";

		// Token: 0x040015BF RID: 5567
		private const string TABLE = "FloroRanchAction";

		// Token: 0x040015C0 RID: 5568
		private const string COMMAND = "select BinData from `FloroRanchAction` where Id=?";

		// Token: 0x040015C1 RID: 5569
		private const string KEY_PREFIX = "FloroRanchActionById";

		// Token: 0x040015C2 RID: 5570
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015C3 RID: 5571
		private static int HandleId;
	}
}
