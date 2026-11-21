using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002EF RID: 751
	public class ConfigFishingGridItemShapeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600119F RID: 4511 RVA: 0x000C0904 File Offset: 0x000BEB04
		static ConfigFishingGridItemShapeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingGridItemShapeById.CreateStaticDefaultValue), new Action(ConfigFishingGridItemShapeById.ResetStaticDefaultValue));
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x000C0924 File Offset: 0x000BEB24
		public static void CreateStaticDefaultValue()
		{
			ConfigFishingGridItemShapeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFishingGridItemShapeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_fishinggriditemshape.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/g.格子道具形状/*.csv*"),
				new ValueTuple<string, object>("表名", "FishingGridItemShape"),
				new ValueTuple<string, object>("语句", "select BinData from `FishingGridItemShape` where Id=?")
			});
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x000C09A3 File Offset: 0x000BEBA3
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingGridItemShapeById.LogPair = null;
			ConfigFishingGridItemShapeById.HandleId = 0;
		}

		// Token: 0x060011A2 RID: 4514 RVA: 0x000C09B1 File Offset: 0x000BEBB1
		public static void Init()
		{
			ConfigFishingGridItemShapeById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingGridItemShapeById.HandleId, "db_fishinggriditemshape.db", "select BinData from `FishingGridItemShape` where Id=?");
		}

		// Token: 0x060011A3 RID: 4515 RVA: 0x000C09CC File Offset: 0x000BEBCC
		public static FishingGridItemShape? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFishingGridItemShapeById.HandleId, ConfigFishingGridItemShapeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingGridItemShapeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FishingGridItemShape?(FishingGridItemShape.GetRootAsFishingGridItemShape(configBuffer));
				}
			}
			ConfigFishingGridItemShapeById.LogPair.Clear();
			ConfigFishingGridItemShapeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFishingGridItemShapeById.HandleId, 1, p0Id, ConfigFishingGridItemShapeById.LogPair) || ConfigCommon.Step(ConfigFishingGridItemShapeById.HandleId, true, ConfigFishingGridItemShapeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFishingGridItemShapeById.HandleId, ConfigFishingGridItemShapeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFishingGridItemShapeById.HandleId, 0, ConfigFishingGridItemShapeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFishingGridItemShapeById.HandleId, ConfigFishingGridItemShapeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FishingGridItemShape rootAsFishingGridItemShape = FishingGridItemShape.GetRootAsFishingGridItemShape(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FishingGridItemShapeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFishingGridItemShapeById.HandleId, ConfigFishingGridItemShapeById.LogPair);
			return new FishingGridItemShape?(rootAsFishingGridItemShape);
		}

		// Token: 0x0400146D RID: 5229
		private const string DB = "db_fishinggriditemshape.db";

		// Token: 0x0400146E RID: 5230
		private const string FILE = "k.可视化编辑/c.Csv/g.格子道具形状/*.csv*";

		// Token: 0x0400146F RID: 5231
		private const string TABLE = "FishingGridItemShape";

		// Token: 0x04001470 RID: 5232
		private const string COMMAND = "select BinData from `FishingGridItemShape` where Id=?";

		// Token: 0x04001471 RID: 5233
		private const string KEY_PREFIX = "FishingGridItemShapeById";

		// Token: 0x04001472 RID: 5234
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001473 RID: 5235
		private static int HandleId;
	}
}
