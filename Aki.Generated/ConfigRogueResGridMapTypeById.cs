using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200086A RID: 2154
	public class ConfigRogueResGridMapTypeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600328E RID: 12942 RVA: 0x0017AC74 File Offset: 0x00178E74
		static ConfigRogueResGridMapTypeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResGridMapTypeById.CreateStaticDefaultValue), new Action(ConfigRogueResGridMapTypeById.ResetStaticDefaultValue));
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x0017AC94 File Offset: 0x00178E94
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResGridMapTypeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResGridMapTypeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResGridMapType"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResGridMapType` where Id=?")
			});
		}

		// Token: 0x06003290 RID: 12944 RVA: 0x0017AD13 File Offset: 0x00178F13
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResGridMapTypeById.LogPair = null;
			ConfigRogueResGridMapTypeById.HandleId = 0;
		}

		// Token: 0x06003291 RID: 12945 RVA: 0x0017AD21 File Offset: 0x00178F21
		public static void Init()
		{
			ConfigRogueResGridMapTypeById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResGridMapTypeById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResGridMapType` where Id=?");
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x0017AD3C File Offset: 0x00178F3C
		public static RogueResGridMapType? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResGridMapTypeById.HandleId, ConfigRogueResGridMapTypeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResGridMapTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResGridMapType?(RogueResGridMapType.GetRootAsRogueResGridMapType(configBuffer));
				}
			}
			ConfigRogueResGridMapTypeById.LogPair.Clear();
			ConfigRogueResGridMapTypeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResGridMapTypeById.HandleId, 1, p0Id, ConfigRogueResGridMapTypeById.LogPair) || ConfigCommon.Step(ConfigRogueResGridMapTypeById.HandleId, true, ConfigRogueResGridMapTypeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResGridMapTypeById.HandleId, ConfigRogueResGridMapTypeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResGridMapTypeById.HandleId, 0, ConfigRogueResGridMapTypeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResGridMapTypeById.HandleId, ConfigRogueResGridMapTypeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResGridMapType rootAsRogueResGridMapType = RogueResGridMapType.GetRootAsRogueResGridMapType(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResGridMapTypeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResGridMapTypeById.HandleId, ConfigRogueResGridMapTypeById.LogPair);
			return new RogueResGridMapType?(rootAsRogueResGridMapType);
		}

		// Token: 0x04003ACC RID: 15052
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003ACD RID: 15053
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003ACE RID: 15054
		private const string TABLE = "RogueResGridMapType";

		// Token: 0x04003ACF RID: 15055
		private const string COMMAND = "select BinData from `RogueResGridMapType` where Id=?";

		// Token: 0x04003AD0 RID: 15056
		private const string KEY_PREFIX = "RogueResGridMapTypeById";

		// Token: 0x04003AD1 RID: 15057
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003AD2 RID: 15058
		private static int HandleId;
	}
}
