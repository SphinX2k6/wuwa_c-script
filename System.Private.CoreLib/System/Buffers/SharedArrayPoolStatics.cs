using System;

namespace System.Buffers
{
	// Token: 0x0200034F RID: 847
	internal static class SharedArrayPoolStatics
	{
		// Token: 0x06003ADD RID: 15069 RVA: 0x000C409C File Offset: 0x000C229C
		private static int GetPartitionCount()
		{
			int num;
			return Math.Min((SharedArrayPoolStatics.TryGetInt32EnvironmentVariable("DOTNET_SYSTEM_BUFFERS_SHAREDARRAYPOOL_MAXPARTITIONCOUNT", out num) && num > 0) ? num : int.MaxValue, Environment.ProcessorCount);
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x000C40D0 File Offset: 0x000C22D0
		private static int GetMaxArraysPerPartition()
		{
			int num;
			if (!SharedArrayPoolStatics.TryGetInt32EnvironmentVariable("DOTNET_SYSTEM_BUFFERS_SHAREDARRAYPOOL_MAXARRAYSPERPARTITION", out num) || num <= 0)
			{
				return 32;
			}
			return num;
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x000C40F4 File Offset: 0x000C22F4
		private unsafe static bool TryGetInt32EnvironmentVariable(string variable, out int result)
		{
			string environmentVariableCore_NoArrayPool = Environment.GetEnvironmentVariableCore_NoArrayPool(variable);
			if (environmentVariableCore_NoArrayPool != null)
			{
				int i = environmentVariableCore_NoArrayPool.Length;
				if (i > 0 && i <= 32)
				{
					ReadOnlySpan<char> readOnlySpan = environmentVariableCore_NoArrayPool.AsSpan().Trim(' ');
					if (!readOnlySpan.IsEmpty && readOnlySpan.Length <= 10)
					{
						long num = 0L;
						ReadOnlySpan<char> readOnlySpan2 = readOnlySpan;
						for (i = 0; i < readOnlySpan2.Length; i++)
						{
							uint num2 = (uint)(*readOnlySpan2[i] - 48);
							if (num2 > 9U)
							{
								goto IL_86;
							}
							num = num * 10L + (long)((ulong)num2);
						}
						if (num >= 0L && num <= 2147483647L)
						{
							result = (int)num;
							return true;
						}
					}
				}
			}
			IL_86:
			result = 0;
			return false;
		}

		// Token: 0x04000C59 RID: 3161
		internal static readonly int s_partitionCount = SharedArrayPoolStatics.GetPartitionCount();

		// Token: 0x04000C5A RID: 3162
		internal static readonly int s_maxArraysPerPartition = SharedArrayPoolStatics.GetMaxArraysPerPartition();
	}
}
