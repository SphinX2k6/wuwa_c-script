using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200037B RID: 891
	public class ConfigFurnitureDiyTagById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014E7 RID: 5351 RVA: 0x000D321F File Offset: 0x000D141F
		static ConfigFurnitureDiyTagById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFurnitureDiyTagById.CreateStaticDefaultValue), new Action(ConfigFurnitureDiyTagById.ResetStaticDefaultValue));
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x000D3240 File Offset: 0x000D1440
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

		// Token: 0x060014E9 RID: 5353 RVA: 0x000D32BF File Offset: 0x000D14BF
		public static void ResetStaticDefaultValue()
		{
			ConfigFurnitureDiyTagById.LogPair = null;
			ConfigFurnitureDiyTagById.HandleId = 0;
		}

		// Token: 0x060014EA RID: 5354 RVA: 0x000D32CD File Offset: 0x000D14CD
		public static void Init()
		{
			ConfigFurnitureDiyTagById.HandleId = ConfigCommon.InitDataStatement(ConfigFurnitureDiyTagById.HandleId, "db_furniture.db", "select BinData from `FurnitureDiyTag` where Id=?");
		}

		// Token: 0x060014EB RID: 5355 RVA: 0x000D32E8 File Offset: 0x000D14E8
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

		// Token: 0x04001841 RID: 6209
		private const string DB = "db_furniture.db";

		// Token: 0x04001842 RID: 6210
		private const string FILE = "j.家具DIY玩法.xlsx";

		// Token: 0x04001843 RID: 6211
		private const string TABLE = "FurnitureDiyTag";

		// Token: 0x04001844 RID: 6212
		private const string COMMAND = "select BinData from `FurnitureDiyTag` where Id=?";

		// Token: 0x04001845 RID: 6213
		private const string KEY_PREFIX = "FurnitureDiyTagById";

		// Token: 0x04001846 RID: 6214
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001847 RID: 6215
		private static int HandleId;
	}
}
