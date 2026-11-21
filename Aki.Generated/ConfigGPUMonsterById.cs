using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C3 RID: 963
	public class ConfigGPUMonsterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001699 RID: 5785 RVA: 0x000DCDFB File Offset: 0x000DAFFB
		static ConfigGPUMonsterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGPUMonsterById.CreateStaticDefaultValue), new Action(ConfigGPUMonsterById.ResetStaticDefaultValue));
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x000DCE1C File Offset: 0x000DB01C
		public static void CreateStaticDefaultValue()
		{
			ConfigGPUMonsterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGPUMonsterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gpuentity.db"),
				new ValueTuple<string, object>("文件", "g.GPU怪物_刷怪器.xlsx"),
				new ValueTuple<string, object>("表名", "GPUMonster"),
				new ValueTuple<string, object>("语句", "select BinData from `GPUMonster` where Id=?")
			});
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x000DCE9B File Offset: 0x000DB09B
		public static void ResetStaticDefaultValue()
		{
			ConfigGPUMonsterById.LogPair = null;
			ConfigGPUMonsterById.HandleId = 0;
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x000DCEA9 File Offset: 0x000DB0A9
		public static void Init()
		{
			ConfigGPUMonsterById.HandleId = ConfigCommon.InitDataStatement(ConfigGPUMonsterById.HandleId, "db_gpuentity.db", "select BinData from `GPUMonster` where Id=?");
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x000DCEC4 File Offset: 0x000DB0C4
		public static GPUMonster? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGPUMonsterById.HandleId, ConfigGPUMonsterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GPUMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GPUMonster?(GPUMonster.GetRootAsGPUMonster(configBuffer));
				}
			}
			ConfigGPUMonsterById.LogPair.Clear();
			ConfigGPUMonsterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGPUMonsterById.HandleId, 1, p0Id, ConfigGPUMonsterById.LogPair) || ConfigCommon.Step(ConfigGPUMonsterById.HandleId, true, ConfigGPUMonsterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGPUMonsterById.HandleId, ConfigGPUMonsterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGPUMonsterById.HandleId, 0, ConfigGPUMonsterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGPUMonsterById.HandleId, ConfigGPUMonsterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GPUMonster rootAsGPUMonster = GPUMonster.GetRootAsGPUMonster(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GPUMonsterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGPUMonsterById.HandleId, ConfigGPUMonsterById.LogPair);
			return new GPUMonster?(rootAsGPUMonster);
		}

		// Token: 0x04001A39 RID: 6713
		private const string DB = "db_gpuentity.db";

		// Token: 0x04001A3A RID: 6714
		private const string FILE = "g.GPU怪物_刷怪器.xlsx";

		// Token: 0x04001A3B RID: 6715
		private const string TABLE = "GPUMonster";

		// Token: 0x04001A3C RID: 6716
		private const string COMMAND = "select BinData from `GPUMonster` where Id=?";

		// Token: 0x04001A3D RID: 6717
		private const string KEY_PREFIX = "GPUMonsterById";

		// Token: 0x04001A3E RID: 6718
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A3F RID: 6719
		private static int HandleId;
	}
}
