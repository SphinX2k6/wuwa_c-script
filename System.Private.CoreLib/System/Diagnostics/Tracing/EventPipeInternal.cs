using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008BD RID: 2237
	internal static class EventPipeInternal
	{
		// Token: 0x06008A2C RID: 35372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern ulong Enable(char* outputFile, EventPipeSerializationFormat format, uint circularBufferSizeInMB, EventPipeInternal.EventPipeProviderConfigurationNative* providers, uint numProviders);

		// Token: 0x06008A2D RID: 35373
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void Disable(ulong sessionID);

		// Token: 0x06008A2E RID: 35374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr CreateProvider(string providerName, IntPtr callbackFunc, IntPtr callbackContext);

		// Token: 0x06008A2F RID: 35375 RVA: 0x0014EBF2 File Offset: 0x0014CDF2
		internal static IntPtr CreateProvider(string providerName, method callbackFunc, ushort callbackContext)
		{
			return EventPipeInternal.CreateProvider(providerName, callbackFunc, (IntPtr)callbackContext);
		}

		// Token: 0x06008A30 RID: 35376
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern IntPtr DefineEvent(IntPtr provHandle, uint eventID, long keywords, uint eventVersion, uint level, byte* pMetadata, uint metadataLength);

		// Token: 0x06008A31 RID: 35377
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern IntPtr GetProvider(char* providerName);

		// Token: 0x06008A32 RID: 35378 RVA: 0x0014EBFC File Offset: 0x0014CDFC
		internal unsafe static IntPtr GetProvider(string providerName)
		{
			char* providerName2;
			if (providerName == null)
			{
				providerName2 = null;
			}
			else
			{
				fixed (char* pinnableReference = providerName.GetPinnableReference())
				{
					providerName2 = pinnableReference;
				}
			}
			return EventPipeInternal.GetProvider(providerName2);
		}

		// Token: 0x06008A33 RID: 35379
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern void DeleteProvider(IntPtr provHandle);

		// Token: 0x06008A34 RID: 35380
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern int EventActivityIdControl(uint controlCode, ref Guid activityId);

		// Token: 0x06008A35 RID: 35381
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void WriteEventData(IntPtr eventHandle, EventProvider.EventData* pEventData, uint dataCount, Guid* activityId, Guid* relatedActivityId);

		// Token: 0x06008A36 RID: 35382
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern bool GetSessionInfo(ulong sessionID, EventPipeSessionInfo* pSessionInfo);

		// Token: 0x06008A37 RID: 35383
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern bool GetNextEvent(ulong sessionID, EventPipeEventInstanceData* pInstance);

		// Token: 0x06008A38 RID: 35384
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool SignalSession(ulong sessionID);

		// Token: 0x06008A39 RID: 35385
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern bool WaitForSessionSignal(ulong sessionID, int timeoutMs);

		// Token: 0x06008A3A RID: 35386
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal static extern ulong GetRuntimeCounterValue(EventPipeInternal.RuntimeCounters counterID);

		// Token: 0x06008A3B RID: 35387 RVA: 0x0014EC20 File Offset: 0x0014CE20
		internal unsafe static ulong Enable(string outputFile, EventPipeSerializationFormat format, uint circularBufferSizeInMB, EventPipeProviderConfiguration[] providers)
		{
			Span<EventPipeInternal.EventPipeProviderConfigurationNative> span = new Span<EventPipeInternal.EventPipeProviderConfigurationNative>(Marshal.AllocCoTaskMem(sizeof(EventPipeInternal.EventPipeProviderConfigurationNative) * providers.Length), providers.Length);
			span.Clear();
			ulong result;
			try
			{
				for (int i = 0; i < providers.Length; i++)
				{
					EventPipeInternal.EventPipeProviderConfigurationNative.MarshalToNative(providers[i], span[i]);
				}
				try
				{
					char* ptr;
					if (outputFile == null)
					{
						ptr = null;
					}
					else
					{
						fixed (char* ptr2 = outputFile.GetPinnableReference())
						{
							ptr = ptr2;
						}
					}
					char* outputFile2 = ptr;
					try
					{
						fixed (EventPipeInternal.EventPipeProviderConfigurationNative* ptr3 = span.GetPinnableReference())
						{
							EventPipeInternal.EventPipeProviderConfigurationNative* providers2 = ptr3;
							result = EventPipeInternal.Enable(outputFile2, format, circularBufferSizeInMB, providers2, (uint)span.Length);
						}
					}
					finally
					{
						EventPipeInternal.EventPipeProviderConfigurationNative* ptr3 = null;
					}
				}
				finally
				{
					char* ptr2 = null;
				}
			}
			finally
			{
				for (int j = 0; j < providers.Length; j++)
				{
					span[j].Release();
				}
				fixed (EventPipeInternal.EventPipeProviderConfigurationNative* ptr3 = span.GetPinnableReference())
				{
					Marshal.FreeCoTaskMem(ptr3);
				}
			}
			return result;
		}

		// Token: 0x020008BE RID: 2238
		internal enum RuntimeCounters
		{
			// Token: 0x04001EAC RID: 7852
			ASSEMBLY_COUNT,
			// Token: 0x04001EAD RID: 7853
			EXCEPTION_COUNT,
			// Token: 0x04001EAE RID: 7854
			GC_NURSERY_SIZE_BYTES,
			// Token: 0x04001EAF RID: 7855
			GC_MAJOR_SIZE_BYTES,
			// Token: 0x04001EB0 RID: 7856
			GC_LARGE_OBJECT_SIZE_BYTES,
			// Token: 0x04001EB1 RID: 7857
			GC_LAST_PERCENT_TIME_IN_GC,
			// Token: 0x04001EB2 RID: 7858
			JIT_IL_BYTES_JITTED,
			// Token: 0x04001EB3 RID: 7859
			JIT_METHODS_JITTED,
			// Token: 0x04001EB4 RID: 7860
			JIT_TICKS_IN_JIT
		}

		// Token: 0x020008BF RID: 2239
		private struct EventPipeProviderConfigurationNative
		{
			// Token: 0x06008A3C RID: 35388 RVA: 0x0014ED10 File Offset: 0x0014CF10
			internal static void MarshalToNative(EventPipeProviderConfiguration managed, ref EventPipeInternal.EventPipeProviderConfigurationNative native)
			{
				native.m_pProviderName = Marshal.StringToCoTaskMemUni(managed.ProviderName);
				native.m_keywords = managed.Keywords;
				native.m_loggingLevel = managed.LoggingLevel;
				native.m_pFilterData = Marshal.StringToCoTaskMemUni(managed.FilterData);
			}

			// Token: 0x06008A3D RID: 35389 RVA: 0x0014ED50 File Offset: 0x0014CF50
			internal void Release()
			{
				if (this.m_pProviderName != null)
				{
					Marshal.FreeCoTaskMem(this.m_pProviderName);
				}
				if (this.m_pFilterData != null)
				{
					Marshal.FreeCoTaskMem(this.m_pFilterData);
				}
			}

			// Token: 0x04001EB5 RID: 7861
			private unsafe char* m_pProviderName;

			// Token: 0x04001EB6 RID: 7862
			private ulong m_keywords;

			// Token: 0x04001EB7 RID: 7863
			private uint m_loggingLevel;

			// Token: 0x04001EB8 RID: 7864
			private unsafe char* m_pFilterData;
		}
	}
}
