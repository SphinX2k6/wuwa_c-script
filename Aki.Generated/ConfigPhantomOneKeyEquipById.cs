using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006AD RID: 1709
	public class ConfigPhantomOneKeyEquipById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600281E RID: 10270 RVA: 0x0013C6C7 File Offset: 0x0013A8C7
		static ConfigPhantomOneKeyEquipById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomOneKeyEquipById.CreateStaticDefaultValue), new Action(ConfigPhantomOneKeyEquipById.ResetStaticDefaultValue));
		}

		// Token: 0x0600281F RID: 10271 RVA: 0x0013C6E8 File Offset: 0x0013A8E8
		public static void CreateStaticDefaultValue()
		{
			ConfigPhantomOneKeyEquipById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhantomOneKeyEquipById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_visionrecommend.db"),
				new ValueTuple<string, object>("文件", "h.幻象推荐.xlsx"),
				new ValueTuple<string, object>("表名", "PhantomOneKeyEquip"),
				new ValueTuple<string, object>("语句", "select BinData from `PhantomOneKeyEquip` where Id=?")
			});
		}

		// Token: 0x06002820 RID: 10272 RVA: 0x0013C767 File Offset: 0x0013A967
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomOneKeyEquipById.LogPair = null;
			ConfigPhantomOneKeyEquipById.HandleId = 0;
		}

		// Token: 0x06002821 RID: 10273 RVA: 0x0013C775 File Offset: 0x0013A975
		public static void Init()
		{
			ConfigPhantomOneKeyEquipById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomOneKeyEquipById.HandleId, "db_visionrecommend.db", "select BinData from `PhantomOneKeyEquip` where Id=?");
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x0013C790 File Offset: 0x0013A990
		public static PhantomOneKeyEquip? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhantomOneKeyEquipById.HandleId, ConfigPhantomOneKeyEquipById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomOneKeyEquipById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhantomOneKeyEquip?(PhantomOneKeyEquip.GetRootAsPhantomOneKeyEquip(configBuffer));
				}
			}
			ConfigPhantomOneKeyEquipById.LogPair.Clear();
			ConfigPhantomOneKeyEquipById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPhantomOneKeyEquipById.HandleId, 1, p0Id, ConfigPhantomOneKeyEquipById.LogPair) || ConfigCommon.Step(ConfigPhantomOneKeyEquipById.HandleId, true, ConfigPhantomOneKeyEquipById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhantomOneKeyEquipById.HandleId, ConfigPhantomOneKeyEquipById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhantomOneKeyEquipById.HandleId, 0, ConfigPhantomOneKeyEquipById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhantomOneKeyEquipById.HandleId, ConfigPhantomOneKeyEquipById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhantomOneKeyEquip rootAsPhantomOneKeyEquip = PhantomOneKeyEquip.GetRootAsPhantomOneKeyEquip(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhantomOneKeyEquipById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhantomOneKeyEquipById.HandleId, ConfigPhantomOneKeyEquipById.LogPair);
			return new PhantomOneKeyEquip?(rootAsPhantomOneKeyEquip);
		}

		// Token: 0x04002EA1 RID: 11937
		private const string DB = "db_visionrecommend.db";

		// Token: 0x04002EA2 RID: 11938
		private const string FILE = "h.幻象推荐.xlsx";

		// Token: 0x04002EA3 RID: 11939
		private const string TABLE = "PhantomOneKeyEquip";

		// Token: 0x04002EA4 RID: 11940
		private const string COMMAND = "select BinData from `PhantomOneKeyEquip` where Id=?";

		// Token: 0x04002EA5 RID: 11941
		private const string KEY_PREFIX = "PhantomOneKeyEquipById";

		// Token: 0x04002EA6 RID: 11942
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002EA7 RID: 11943
		private static int HandleId;
	}
}
