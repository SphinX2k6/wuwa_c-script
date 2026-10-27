using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000366 RID: 870
	public class ConfigFurnitureDiyTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001469 RID: 5225 RVA: 0x000CCD13 File Offset: 0x000CAF13
		static ConfigFurnitureDiyTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureDiyTagById.CreateStaticDefaultValue), new Action(ConfigFurnitureDiyTagById.ResetStaticDefaultValue));
		}

		// Token: 0x0600146A RID: 5226 RVA: 0x000CCD34 File Offset: 0x000CAF34
		public static void CreateStaticDefaultValue()
		{
			ConfigFurnitureDiyTagById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFurnitureDiyTagById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_furniture.db"),
				new ValueTuple<string, object>("文件", "j.家具DIY玩法.xlsx"),
				new ValueTuple<string, object>("表名", "FurnitureDiyTag"),
				new ValueTuple<string, object>("语句", "select BinData from `FurnitureDiyTag` where Id=?")
			});
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x000CCDB3 File Offset: 0x000CAFB3
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureDiyTagById.LogPair = null;
			ConfigFurnitureDiyTagById.HandleId = 0;
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x000CCDC1 File Offset: 0x000CAFC1
		public static void Init()
		{
			ConfigFurnitureDiyTagById.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureDiyTagById.HandleId, "db_furniture.db", "select BinData from `FurnitureDiyTag` where Id=?");
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x000CCDDC File Offset: 0x000CAFDC
		public static FurnitureDiyTag? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFurnitureDiyTagById.HandleId, ConfigFurnitureDiyTagById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureDiyTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FurnitureDiyTag?(FurnitureDiyTag.GetRootAsFurnitureDiyTag(configBuffer));
				}
			}
			ConfigFurnitureDiyTagById.LogPair.Clear();
			ConfigFurnitureDiyTagById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFurnitureDiyTagById.HandleId, 1, p0Id, ConfigFurnitureDiyTagById.LogPair) || ConfigCommon.Step(ConfigFurnitureDiyTagById.HandleId, true, ConfigFurnitureDiyTagById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFurnitureDiyTagById.HandleId, ConfigFurnitureDiyTagById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFurnitureDiyTagById.HandleId, 0, ConfigFurnitureDiyTagById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFurnitureDiyTagById.HandleId, ConfigFurnitureDiyTagById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FurnitureDiyTag rootAsFurnitureDiyTag = FurnitureDiyTag.GetRootAsFurnitureDiyTag(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FurnitureDiyTagById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFurnitureDiyTagById.HandleId, ConfigFurnitureDiyTagById.LogPair);
			return new FurnitureDiyTag?(rootAsFurnitureDiyTag);
		}

		// Token: 0x040017AE RID: 6062
		private const string DB = "db_furniture.db";

		// Token: 0x040017AF RID: 6063
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x040017B0 RID: 6064
		private const string TABLE = "FurnitureDiyTag";

		// Token: 0x040017B1 RID: 6065
		private const string COMMAND = "select BinData from `FurnitureDiyTag` where Id=?";

		// Token: 0x040017B2 RID: 6066
		private const string KEY_PREFIX = "FurnitureDiyTagById";

		// Token: 0x040017B3 RID: 6067
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040017B4 RID: 6068
		private static int HandleId;
	}
}
