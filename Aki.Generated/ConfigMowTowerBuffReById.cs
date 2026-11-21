using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005E9 RID: 1513
	public class ConfigMowTowerBuffReById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002383 RID: 9091 RVA: 0x00125CA7 File Offset: 0x00123EA7
		static ConfigMowTowerBuffReById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMowTowerBuffReById.CreateStaticDefaultValue), new Action(ConfigMowTowerBuffReById.ResetStaticDefaultValue));
		}

		// Token: 0x06002384 RID: 9092 RVA: 0x00125CC8 File Offset: 0x00123EC8
		public static void CreateStaticDefaultValue()
		{
			ConfigMowTowerBuffReById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMowTowerBuffReById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_mowtower.db"),
				new ValueTuple<string, object>("文件", "g.割草爬塔活动.xlsx"),
				new ValueTuple<string, object>("表名", "MowTowerBuffRe"),
				new ValueTuple<string, object>("语句", "select BinData from `MowTowerBuffRe` where Id=?")
			});
		}

		// Token: 0x06002385 RID: 9093 RVA: 0x00125D47 File Offset: 0x00123F47
		public static void ResetStaticDefaultValue()
		{
			ConfigMowTowerBuffReById.LogPair = null;
			ConfigMowTowerBuffReById.HandleId = 0;
		}

		// Token: 0x06002386 RID: 9094 RVA: 0x00125D55 File Offset: 0x00123F55
		public static void Init()
		{
			ConfigMowTowerBuffReById.HandleId = ConfigCommon.InitDataStatement(ConfigMowTowerBuffReById.HandleId, "db_mowtower.db", "select BinData from `MowTowerBuffRe` where Id=?");
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x00125D70 File Offset: 0x00123F70
		public static MowTowerBuffRe? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMowTowerBuffReById.HandleId, ConfigMowTowerBuffReById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MowTowerBuffReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MowTowerBuffRe?(MowTowerBuffRe.GetRootAsMowTowerBuffRe(configBuffer));
				}
			}
			ConfigMowTowerBuffReById.LogPair.Clear();
			ConfigMowTowerBuffReById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMowTowerBuffReById.HandleId, 1, p0Id, ConfigMowTowerBuffReById.LogPair) || ConfigCommon.Step(ConfigMowTowerBuffReById.HandleId, true, ConfigMowTowerBuffReById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMowTowerBuffReById.HandleId, ConfigMowTowerBuffReById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMowTowerBuffReById.HandleId, 0, ConfigMowTowerBuffReById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMowTowerBuffReById.HandleId, ConfigMowTowerBuffReById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MowTowerBuffRe rootAsMowTowerBuffRe = MowTowerBuffRe.GetRootAsMowTowerBuffRe(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MowTowerBuffReById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMowTowerBuffReById.HandleId, ConfigMowTowerBuffReById.LogPair);
			return new MowTowerBuffRe?(rootAsMowTowerBuffRe);
		}

		// Token: 0x04002943 RID: 10563
		private const string DB = "db_mowtower.db";

		// Token: 0x04002944 RID: 10564
		private const string FILE = "g.割草爬塔活动.xlsx";

		// Token: 0x04002945 RID: 10565
		private const string TABLE = "MowTowerBuffRe";

		// Token: 0x04002946 RID: 10566
		private const string COMMAND = "select BinData from `MowTowerBuffRe` where Id=?";

		// Token: 0x04002947 RID: 10567
		private const string KEY_PREFIX = "MowTowerBuffReById";

		// Token: 0x04002948 RID: 10568
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002949 RID: 10569
		private static int HandleId;
	}
}
