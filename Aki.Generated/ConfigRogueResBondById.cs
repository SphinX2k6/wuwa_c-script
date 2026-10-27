using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000832 RID: 2098
	public class ConfigRogueResBondById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600313E RID: 12606 RVA: 0x0016FCCB File Offset: 0x0016DECB
		static ConfigRogueResBondById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRogueResBondById.CreateStaticDefaultValue), new Action(ConfigRogueResBondById.ResetStaticDefaultValue));
		}

		// Token: 0x0600313F RID: 12607 RVA: 0x0016FCEC File Offset: 0x0016DEEC
		public static void CreateStaticDefaultValue()
		{
			ConfigRogueResBondById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRogueResBondById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_permanentrogue.db"),
				new ValueTuple<string, object>("文件", "c.常驻肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RogueResBond"),
				new ValueTuple<string, object>("语句", "select BinData from `RogueResBond` where Id=?")
			});
		}

		// Token: 0x06003140 RID: 12608 RVA: 0x0016FD6B File Offset: 0x0016DF6B
		public static void ResetStaticDefaultValue()
		{
			ConfigRogueResBondById.LogPair = null;
			ConfigRogueResBondById.HandleId = 0;
		}

		// Token: 0x06003141 RID: 12609 RVA: 0x0016FD79 File Offset: 0x0016DF79
		public static void Init()
		{
			ConfigRogueResBondById.HandleId = ConfigCommon.InitDataStatement(ConfigRogueResBondById.HandleId, "db_permanentrogue.db", "select BinData from `RogueResBond` where Id=?");
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x0016FD94 File Offset: 0x0016DF94
		public static RogueResBond? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRogueResBondById.HandleId, ConfigRogueResBondById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResBondById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RogueResBond?(RogueResBond.GetRootAsRogueResBond(configBuffer));
				}
			}
			ConfigRogueResBondById.LogPair.Clear();
			ConfigRogueResBondById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRogueResBondById.HandleId, 1, p0Id, ConfigRogueResBondById.LogPair) || ConfigCommon.Step(ConfigRogueResBondById.HandleId, true, ConfigRogueResBondById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRogueResBondById.HandleId, ConfigRogueResBondById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRogueResBondById.HandleId, 0, ConfigRogueResBondById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRogueResBondById.HandleId, ConfigRogueResBondById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RogueResBond rootAsRogueResBond = RogueResBond.GetRootAsRogueResBond(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RogueResBondById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRogueResBondById.HandleId, ConfigRogueResBondById.LogPair);
			return new RogueResBond?(rootAsRogueResBond);
		}

		// Token: 0x04003944 RID: 14660
		private const string DB = "db_permanentrogue.db";

		// Token: 0x04003945 RID: 14661
		private const string FILE = "c.常驻肉鸽.xlsx";

		// Token: 0x04003946 RID: 14662
		private const string TABLE = "RogueResBond";

		// Token: 0x04003947 RID: 14663
		private const string COMMAND = "select BinData from `RogueResBond` where Id=?";

		// Token: 0x04003948 RID: 14664
		private const string KEY_PREFIX = "RogueResBondById";

		// Token: 0x04003949 RID: 14665
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400394A RID: 14666
		private static int HandleId;
	}
}
