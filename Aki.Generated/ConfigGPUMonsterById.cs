using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003AD RID: 941
	public class ConfigGPUMonsterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001615 RID: 5653 RVA: 0x000D66A7 File Offset: 0x000D48A7
		static ConfigGPUMonsterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGPUMonsterById.CreateStaticDefaultValue), new Action(ConfigGPUMonsterById.ResetStaticDefaultValue));
		}

		// Token: 0x06001616 RID: 5654 RVA: 0x000D66C8 File Offset: 0x000D48C8
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

		// Token: 0x06001617 RID: 5655 RVA: 0x000D6747 File Offset: 0x000D4947
		public static void ResetStaticDefaultValue()
		{
			ConfigGPUMonsterById.LogPair = null;
			ConfigGPUMonsterById.HandleId = 0;
		}

		// Token: 0x06001618 RID: 5656 RVA: 0x000D6755 File Offset: 0x000D4955
		public static void Init()
		{
			ConfigGPUMonsterById.HandleId = ConfigCommon.InitDataStatement(ConfigGPUMonsterById.HandleId, "db_gpuentity.db", "select BinData from `GPUMonster` where Id=?");
		}

		// Token: 0x06001619 RID: 5657 RVA: 0x000D6770 File Offset: 0x000D4970
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

		// Token: 0x0400199F RID: 6559
		private const string DB = "db_gpuentity.db";

		// Token: 0x040019A0 RID: 6560
		private const string FILE = "g.GPU怪物_刷怪器.xlsx";

		// Token: 0x040019A1 RID: 6561
		private const string TABLE = "GPUMonster";

		// Token: 0x040019A2 RID: 6562
		private const string COMMAND = "select BinData from `GPUMonster` where Id=?";

		// Token: 0x040019A3 RID: 6563
		private const string KEY_PREFIX = "GPUMonsterById";

		// Token: 0x040019A4 RID: 6564
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019A5 RID: 6565
		private static int HandleId;
	}
}
