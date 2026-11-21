using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004EB RID: 1259
	public class ConfigLifePointEntranceById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D8D RID: 7565 RVA: 0x00103B7C File Offset: 0x00101D7C
		static ConfigLifePointEntranceById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLifePointEntranceById.CreateStaticDefaultValue), new Action(ConfigLifePointEntranceById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x00103B9C File Offset: 0x00101D9C
		public static void CreateStaticDefaultValue()
		{
			ConfigLifePointEntranceById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLifePointEntranceById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lifepoint.db"),
				new ValueTuple<string, object>("文件", "y.溢彩画.xlsx"),
				new ValueTuple<string, object>("表名", "LifePointEntrance"),
				new ValueTuple<string, object>("语句", "select BinData from `LifePointEntrance` where Id=?")
			});
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x00103C1B File Offset: 0x00101E1B
		public static void ResetStaticDefaultValue()
		{
			ConfigLifePointEntranceById.LogPair = null;
			ConfigLifePointEntranceById.HandleId = 0;
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x00103C29 File Offset: 0x00101E29
		public static void Init()
		{
			ConfigLifePointEntranceById.HandleId = ConfigCommon.InitDataStatement(ConfigLifePointEntranceById.HandleId, "db_lifepoint.db", "select BinData from `LifePointEntrance` where Id=?");
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00103C44 File Offset: 0x00101E44
		public static LifePointEntrance? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLifePointEntranceById.HandleId, ConfigLifePointEntranceById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LifePointEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LifePointEntrance?(LifePointEntrance.GetRootAsLifePointEntrance(configBuffer));
				}
			}
			ConfigLifePointEntranceById.LogPair.Clear();
			ConfigLifePointEntranceById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLifePointEntranceById.HandleId, 1, p0Id, ConfigLifePointEntranceById.LogPair) || ConfigCommon.Step(ConfigLifePointEntranceById.HandleId, true, ConfigLifePointEntranceById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLifePointEntranceById.HandleId, ConfigLifePointEntranceById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLifePointEntranceById.HandleId, 0, ConfigLifePointEntranceById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLifePointEntranceById.HandleId, ConfigLifePointEntranceById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LifePointEntrance rootAsLifePointEntrance = LifePointEntrance.GetRootAsLifePointEntrance(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LifePointEntranceById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLifePointEntranceById.HandleId, ConfigLifePointEntranceById.LogPair);
			return new LifePointEntrance?(rootAsLifePointEntrance);
		}

		// Token: 0x04002251 RID: 8785
		private const string DB = "db_lifepoint.db";

		// Token: 0x04002252 RID: 8786
		private const string FILE = "y.溢彩画.xlsx";

		// Token: 0x04002253 RID: 8787
		private const string TABLE = "LifePointEntrance";

		// Token: 0x04002254 RID: 8788
		private const string COMMAND = "select BinData from `LifePointEntrance` where Id=?";

		// Token: 0x04002255 RID: 8789
		private const string KEY_PREFIX = "LifePointEntranceById";

		// Token: 0x04002256 RID: 8790
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002257 RID: 8791
		private static int HandleId;
	}
}
