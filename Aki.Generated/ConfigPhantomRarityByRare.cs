using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006B1 RID: 1713
	public class ConfigPhantomRarityByRare : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002836 RID: 10294 RVA: 0x0013CF33 File Offset: 0x0013B133
		static ConfigPhantomRarityByRare()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomRarityByRare.CreateStaticDefaultValue), new Action(ConfigPhantomRarityByRare.ResetStaticDefaultValue));
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x0013CF54 File Offset: 0x0013B154
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

		// Token: 0x06002838 RID: 10296 RVA: 0x0013CFD3 File Offset: 0x0013B1D3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomRarityByRare.LogPair = null;
			ConfigPhantomRarityByRare.HandleId = 0;
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x0013CFE1 File Offset: 0x0013B1E1
		public static void Init()
		{
			ConfigPhantomRarityByRare.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomRarityByRare.HandleId, "db_phantom.db", "select BinData from `PhantomRarity` where Rare=?");
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x0013CFFC File Offset: 0x0013B1FC
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

		// Token: 0x04002EBD RID: 11965
		private const string DB = "db_phantom.db";

		// Token: 0x04002EBE RID: 11966
		private const string FILE = "h.幻象.xlsx";

		// Token: 0x04002EBF RID: 11967
		private const string TABLE = "PhantomRarity";

		// Token: 0x04002EC0 RID: 11968
		private const string COMMAND = "select BinData from `PhantomRarity` where Rare=?";

		// Token: 0x04002EC1 RID: 11969
		private const string KEY_PREFIX = "PhantomRarityByRare";

		// Token: 0x04002EC2 RID: 11970
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EC3 RID: 11971
		private static int HandleId;
	}
}
