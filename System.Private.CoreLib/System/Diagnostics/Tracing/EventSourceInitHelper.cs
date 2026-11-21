using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008F0 RID: 2288
	internal static class EventSourceInitHelper
	{
		// Token: 0x06008C83 RID: 35971 RVA: 0x001589D4 File Offset: 0x00156BD4
		internal static EventSource GetMetricsEventSource()
		{
			Type type = Type.GetType("System.Diagnostics.Metrics.MetricsEventSource, System.Diagnostics.DiagnosticSource", false);
			if (type == null)
			{
				return null;
			}
			MethodInfo method = type.GetMethod("GetInstance", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, Type.EmptyTypes, null);
			if (method == null)
			{
				return null;
			}
			return method.Invoke(null, null) as EventSource;
		}

		// Token: 0x06008C84 RID: 35972 RVA: 0x00158A28 File Offset: 0x00156C28
		internal unsafe static void PreregisterEventProviders(Guid id, string name, Func<EventSource> eventSourceFactory)
		{
			try
			{
				EventSourceInitHelper.s_preregisteredEventSourceFactories.Add(eventSourceFactory);
				EventSource.OverrideEventProvider overrideEventProvider = new EventSource.OverrideEventProvider(eventSourceFactory, EventProviderType.ETW);
				overrideEventProvider.Register(id, name);
				byte[] array = Statics.MetadataForString(name, 0, 0, 0);
				try
				{
					byte[] array2;
					byte* data;
					if ((array2 = array) == null || array2.Length == 0)
					{
						data = null;
					}
					else
					{
						data = &array2[0];
					}
					overrideEventProvider.SetInformation(Interop.Advapi32.EVENT_INFO_CLASS.SetTraits, (void*)data, (uint)array.Length);
				}
				finally
				{
					byte[] array2 = null;
				}
				Dictionary<Guid, EventSource.OverrideEventProvider> obj = EventSourceInitHelper.s_preregisteredEtwProviders;
				lock (obj)
				{
					EventSourceInitHelper.s_preregisteredEtwProviders[id] = overrideEventProvider;
				}
				EventSource.OverrideEventProvider overrideEventProvider2 = new EventSource.OverrideEventProvider(eventSourceFactory, EventProviderType.EventPipe);
				overrideEventProvider2.Register(id, name);
				Dictionary<string, EventSource.OverrideEventProvider> obj2 = EventSourceInitHelper.s_preregisteredEventPipeProviders;
				lock (obj2)
				{
					EventSourceInitHelper.s_preregisteredEventPipeProviders[name] = overrideEventProvider2;
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06008C85 RID: 35973 RVA: 0x00158B2C File Offset: 0x00156D2C
		internal static void EnsurePreregisteredEventSourcesExist()
		{
			if (!EventSource.IsSupported)
			{
				return;
			}
			List<Func<EventSource>> obj = EventSourceInitHelper.s_preregisteredEventSourceFactories;
			Func<EventSource>[] array;
			lock (obj)
			{
				array = EventSourceInitHelper.s_preregisteredEventSourceFactories.ToArray();
				EventSourceInitHelper.s_preregisteredEventSourceFactories.Clear();
			}
			Func<EventSource>[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				array2[i]();
			}
		}

		// Token: 0x06008C86 RID: 35974 RVA: 0x00158BA0 File Offset: 0x00156DA0
		internal static EventSource.OverrideEventProvider TryGetPreregisteredEtwProvider(Guid id)
		{
			Dictionary<Guid, EventSource.OverrideEventProvider> obj = EventSourceInitHelper.s_preregisteredEtwProviders;
			EventSource.OverrideEventProvider result;
			lock (obj)
			{
				EventSource.OverrideEventProvider overrideEventProvider;
				EventSourceInitHelper.s_preregisteredEtwProviders.Remove(id, out overrideEventProvider);
				result = overrideEventProvider;
			}
			return result;
		}

		// Token: 0x06008C87 RID: 35975 RVA: 0x00158BEC File Offset: 0x00156DEC
		internal static EventSource.OverrideEventProvider TryGetPreregisteredEventPipeProvider(string name)
		{
			Dictionary<string, EventSource.OverrideEventProvider> obj = EventSourceInitHelper.s_preregisteredEventPipeProviders;
			EventSource.OverrideEventProvider result;
			lock (obj)
			{
				EventSource.OverrideEventProvider overrideEventProvider;
				EventSourceInitHelper.s_preregisteredEventPipeProviders.Remove(name, out overrideEventProvider);
				result = overrideEventProvider;
			}
			return result;
		}

		// Token: 0x04001FEA RID: 8170
		private static List<Func<EventSource>> s_preregisteredEventSourceFactories = new List<Func<EventSource>>();

		// Token: 0x04001FEB RID: 8171
		private static readonly Dictionary<Guid, EventSource.OverrideEventProvider> s_preregisteredEtwProviders = new Dictionary<Guid, EventSource.OverrideEventProvider>();

		// Token: 0x04001FEC RID: 8172
		private static readonly Dictionary<string, EventSource.OverrideEventProvider> s_preregisteredEventPipeProviders = new Dictionary<string, EventSource.OverrideEventProvider>();
	}
}
