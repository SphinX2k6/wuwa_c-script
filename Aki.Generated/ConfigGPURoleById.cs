using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003AE RID: 942
	public class ConfigGPURoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600161B RID: 5659 RVA: 0x000D68F0 File Offset: 0x000D4AF0
		static ConfigGPURoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGPURoleById.CreateStaticDefaultValue), new Action(ConfigGPURoleById.ResetStaticDefaultValue));
		}

		// Token: 0x0600161C RID: 5660 RVA: 0x000D6910 File Offset: 0x000D4B10
		public static void CreateStaticDefaultValue()
		{
			ConfigGPURoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGPURoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gpuentity.db"),
				new ValueTuple<string, object>("文件", "g.GPU角色实体映射表.xlsx"),
				new ValueTuple<string, object>("表名", "GPURole"),
				new ValueTuple<string, object>("语句", "select BinData from `GPURole` where Id=?")
			});
		}

		// Token: 0x0600161D RID: 5661 RVA: 0x000D698F File Offset: 0x000D4B8F
		public static void ResetStaticDefaultValue()
		{
			ConfigGPURoleById.LogPair = null;
			ConfigGPURoleById.HandleId = 0;
		}

		// Token: 0x0600161E RID: 5662 RVA: 0x000D699D File Offset: 0x000D4B9D
		public static void Init()
		{
			ConfigGPURoleById.HandleId = ConfigCommon.InitDataStatement(ConfigGPURoleById.HandleId, "db_gpuentity.db", "select BinData from `GPURole` where Id=?");
		}

		// Token: 0x0600161F RID: 5663 RVA: 0x000D69B8 File Offset: 0x000D4BB8
		public static GPURole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGPURoleById.HandleId, ConfigGPURoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GPURoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GPURole?(GPURole.GetRootAsGPURole(configBuffer));
				}
			}
			ConfigGPURoleById.LogPair.Clear();
			ConfigGPURoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGPURoleById.HandleId, 1, p0Id, ConfigGPURoleById.LogPair) || ConfigCommon.Step(ConfigGPURoleById.HandleId, true, ConfigGPURoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGPURoleById.HandleId, ConfigGPURoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGPURoleById.HandleId, 0, ConfigGPURoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGPURoleById.HandleId, ConfigGPURoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GPURole rootAsGPURole = GPURole.GetRootAsGPURole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GPURoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGPURoleById.HandleId, ConfigGPURoleById.LogPair);
			return new GPURole?(rootAsGPURole);
		}

		// Token: 0x040019A6 RID: 6566
		private const string DB = "db_gpuentity.db";

		// Token: 0x040019A7 RID: 6567
		private const string FILE = "g.GPU角色实体映射表.xlsx";

		// Token: 0x040019A8 RID: 6568
		private const string TABLE = "GPURole";

		// Token: 0x040019A9 RID: 6569
		private const string COMMAND = "select BinData from `GPURole` where Id=?";

		// Token: 0x040019AA RID: 6570
		private const string KEY_PREFIX = "GPURoleById";

		// Token: 0x040019AB RID: 6571
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019AC RID: 6572
		private static int HandleId;
	}
}
