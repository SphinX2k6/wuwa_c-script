using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200084C RID: 2124
	public class ConfigRogueResGridEventById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060031DA RID: 12762 RVA: 0x001734FB File Offset: 0x001716FB
		static ConfigRogueResGridEventById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResGridEventById.CreateStaticDefaultValue), new Action(ConfigRogueResGridEventById.ResetStaticDefaultValue));
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x0017351C File Offset: 0x0017171C
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResGridEventById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResGridEventById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResGridEvent"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResGridEvent` where Id=?")
			});
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x0017359B File Offset: 0x0017179B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResGridEventById.LogPair = null;
			ConfigRogueResGridEventById.HandleId = 0;
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x001735A9 File Offset: 0x001717A9
		public static void Init()
		{
			ConfigRogueResGridEventById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResGridEventById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResGridEvent` where Id=?");
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x001735C4 File Offset: 0x001717C4
		public static RogueResGridEvent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResGridEventById.HandleId, ConfigRogueResGridEventById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResGridEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResGridEvent?(RogueResGridEvent.GetRootAsRogueResGridEvent(configBuffer));
				}
			}
			ConfigRogueResGridEventById.LogPair.Clear();
			ConfigRogueResGridEventById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResGridEventById.HandleId, 1, p0Id, ConfigRogueResGridEventById.LogPair) || ConfigCommon.Step(ConfigRogueResGridEventById.HandleId, true, ConfigRogueResGridEventById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResGridEventById.HandleId, ConfigRogueResGridEventById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResGridEventById.HandleId, 0, ConfigRogueResGridEventById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResGridEventById.HandleId, ConfigRogueResGridEventById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResGridEvent rootAsRogueResGridEvent = RogueResGridEvent.GetRootAsRogueResGridEvent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResGridEventById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResGridEventById.HandleId, ConfigRogueResGridEventById.LogPair);
			return new RogueResGridEvent?(rootAsRogueResGridEvent);
		}

		// Token: 0x040039FA RID: 14842
		private const string DB = "db_permanentrogue.db";

		// Token: 0x040039FB RID: 14843
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x040039FC RID: 14844
		private const string TABLE = "RogueResGridEvent";

		// Token: 0x040039FD RID: 14845
		private const string COMMAND = "select BinData from `RogueResGridEvent` where Id=?";

		// Token: 0x040039FE RID: 14846
		private const string KEY_PREFIX = "RogueResGridEventById";

		// Token: 0x040039FF RID: 14847
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003A00 RID: 14848
		private static int HandleId;
	}
}
