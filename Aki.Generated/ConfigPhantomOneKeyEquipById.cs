using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C5 RID: 1733
	public class ConfigPhantomOneKeyEquipById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060028AE RID: 10414 RVA: 0x00143143 File Offset: 0x00141343
		static ConfigPhantomOneKeyEquipById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhantomOneKeyEquipById.CreateStaticDefaultValue), new Action(ConfigPhantomOneKeyEquipById.ResetStaticDefaultValue));
		}

		// Token: 0x060028AF RID: 10415 RVA: 0x00143164 File Offset: 0x00141364
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

		// Token: 0x060028B0 RID: 10416 RVA: 0x001431E3 File Offset: 0x001413E3
		public static void ResetStaticDefaultValue()
		{
			ConfigPhantomOneKeyEquipById.LogPair = null;
			ConfigPhantomOneKeyEquipById.HandleId = 0;
		}

		// Token: 0x060028B1 RID: 10417 RVA: 0x001431F1 File Offset: 0x001413F1
		public static void Init()
		{
			ConfigPhantomOneKeyEquipById.HandleId = ConfigCommon.InitDataStatement(ConfigPhantomOneKeyEquipById.HandleId, "db_visionrecommend.db", "select BinData from `PhantomOneKeyEquip` where Id=?");
		}

		// Token: 0x060028B2 RID: 10418 RVA: 0x0014320C File Offset: 0x0014140C
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

		// Token: 0x04002F49 RID: 12105
		private const string DB = "db_visionrecommend.db";

		// Token: 0x04002F4A RID: 12106
		private const string FILE = "h.幻象推荐.xlsx";

		// Token: 0x04002F4B RID: 12107
		private const string TABLE = "PhantomOneKeyEquip";

		// Token: 0x04002F4C RID: 12108
		private const string COMMAND = "select BinData from `PhantomOneKeyEquip` where Id=?";

		// Token: 0x04002F4D RID: 12109
		private const string KEY_PREFIX = "PhantomOneKeyEquipById";

		// Token: 0x04002F4E RID: 12110
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F4F RID: 12111
		private static int HandleId;
	}
}
