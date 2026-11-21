using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C4 RID: 964
	public class ConfigGPURoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600169F RID: 5791 RVA: 0x000DD044 File Offset: 0x000DB244
		static ConfigGPURoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGPURoleById.CreateStaticDefaultValue), new Action(ConfigGPURoleById.ResetStaticDefaultValue));
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x000DD064 File Offset: 0x000DB264
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

		// Token: 0x060016A1 RID: 5793 RVA: 0x000DD0E3 File Offset: 0x000DB2E3
		public static void ResetStaticDefaultValue()
		{
			ConfigGPURoleById.LogPair = null;
			ConfigGPURoleById.HandleId = 0;
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x000DD0F1 File Offset: 0x000DB2F1
		public static void Init()
		{
			ConfigGPURoleById.HandleId = ConfigCommon.InitDataStatement(ConfigGPURoleById.HandleId, "db_gpuentity.db", "select BinData from `GPURole` where Id=?");
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x000DD10C File Offset: 0x000DB30C
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

		// Token: 0x04001A40 RID: 6720
		private const string DB = "db_gpuentity.db";

		// Token: 0x04001A41 RID: 6721
		private const string FILE = "g.GPU角色实体映射表.xlsx";

		// Token: 0x04001A42 RID: 6722
		private const string TABLE = "GPURole";

		// Token: 0x04001A43 RID: 6723
		private const string COMMAND = "select BinData from `GPURole` where Id=?";

		// Token: 0x04001A44 RID: 6724
		private const string KEY_PREFIX = "GPURoleById";

		// Token: 0x04001A45 RID: 6725
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A46 RID: 6726
		private static int HandleId;
	}
}
