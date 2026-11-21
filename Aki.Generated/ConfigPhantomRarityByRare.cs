using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C9 RID: 1737
	public class ConfigPhantomRarityByRare : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028C6 RID: 10438 RVA: 0x001439AF File Offset: 0x00141BAF
		static ConfigPhantomRarityByRare()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomRarityByRare.CreateStaticDefaultValue), new Action(ConfigPhantomRarityByRare.ResetStaticDefaultValue));
		}

		// Token: 0x060028C7 RID: 10439 RVA: 0x001439D0 File Offset: 0x00141BD0
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomRarityByRare.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomRarityByRare.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phantom.db"),
				new ValueTuple<string, object>("文件", "h.幻象.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomRarity"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomRarity` where Rare=?")
			});
		}

		// Token: 0x060028C8 RID: 10440 RVA: 0x00143A4F File Offset: 0x00141C4F
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomRarityByRare.LogPair = null;
			ConfigPhantomRarityByRare.HandleId = 0;
		}

		// Token: 0x060028C9 RID: 10441 RVA: 0x00143A5D File Offset: 0x00141C5D
		public static void Init()
		{
			ConfigPhantomRarityByRare.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomRarityByRare.HandleId, "db_phantom.db", "select BinData from `PhantomRarity` where Rare=?");
		}

		// Token: 0x060028CA RID: 10442 RVA: 0x00143A78 File Offset: 0x00141C78
		public static PhantomRarity? GetConfig(int p0Rare, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomRarityByRare.HandleId, ConfigPhantomRarityByRare.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomRarityByRare");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Rare);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomRarity?(PhantomRarity.GetRootAsPhantomRarity(configBuffer));
				}
			}
			ConfigPhantomRarityByRare.LogPair.Clear();
			ConfigPhantomRarityByRare.LogPair.Add(new ValueTuple<string, object>("Rare", p0Rare));
			if (!ConfigCommon.BindInt(ConfigPhantomRarityByRare.HandleId, 1, p0Rare, ConfigPhantomRarityByRare.LogPair) || ConfigCommon.Step(ConfigPhantomRarityByRare.HandleId, true, ConfigPhantomRarityByRare.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomRarityByRare.HandleId, ConfigPhantomRarityByRare.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomRarityByRare.HandleId, 0, ConfigPhantomRarityByRare.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomRarityByRare.HandleId, ConfigPhantomRarityByRare.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomRarity rootAsPhantomRarity = PhantomRarity.GetRootAsPhantomRarity(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomRarityByRare");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Rare);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomRarityByRare.HandleId, ConfigPhantomRarityByRare.LogPair);
			return new PhantomRarity?(rootAsPhantomRarity);
		}

		// Token: 0x04002F65 RID: 12133
		private const string DB = "db_phantom.db";

		// Token: 0x04002F66 RID: 12134
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002F67 RID: 12135
		private const string TABLE = "PhantomRarity";

		// Token: 0x04002F68 RID: 12136
		private const string COMMAND = "select BinData from `PhantomRarity` where Rare=?";

		// Token: 0x04002F69 RID: 12137
		private const string KEY_PREFIX = "PhantomRarityByRare";

		// Token: 0x04002F6A RID: 12138
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F6B RID: 12139
		private static int HandleId;
	}
}
