using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002DA RID: 730
	public class ConfigFishingGridItemShapeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001121 RID: 4385 RVA: 0x000BA3F8 File Offset: 0x000B85F8
		static ConfigFishingGridItemShapeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFishingGridItemShapeById.CreateStaticDefaultValue), new Action(ConfigFishingGridItemShapeById.ResetStaticDefaultValue));
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x000BA418 File Offset: 0x000B8618
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

		// Token: 0x06001123 RID: 4387 RVA: 0x000BA497 File Offset: 0x000B8697
		public static void ResetStaticDefaultValue()
		{
			ConfigFishingGridItemShapeById.LogPair = null;
			ConfigFishingGridItemShapeById.HandleId = 0;
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x000BA4A5 File Offset: 0x000B86A5
		public static void Init()
		{
			ConfigFishingGridItemShapeById.HandleId = ConfigCommon.InitDataStatement(ConfigFishingGridItemShapeById.HandleId, "db_fishinggriditemshape.db", "select BinData from `FishingGridItemShape` where Id=?");
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x000BA4C0 File Offset: 0x000B86C0
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

		// Token: 0x040013DA RID: 5082
		private const string DB = "db_fishinggriditemshape.db";

		// Token: 0x040013DB RID: 5083
		private const string FILE = "k.可视化编辑/c.Csv/g.格子道具形状/*.csv*";

		// Token: 0x040013DC RID: 5084
		private const string TABLE = "FishingGridItemShape";

		// Token: 0x040013DD RID: 5085
		private const string COMMAND = "select BinData from `FishingGridItemShape` where Id=?";

		// Token: 0x040013DE RID: 5086
		private const string KEY_PREFIX = "FishingGridItemShapeById";

		// Token: 0x040013DF RID: 5087
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040013E0 RID: 5088
		private static int HandleId;
	}
}
