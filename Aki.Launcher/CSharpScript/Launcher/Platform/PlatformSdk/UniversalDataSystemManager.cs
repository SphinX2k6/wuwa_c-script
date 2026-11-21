using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x020001A3 RID: 419
	[NullableContext(1)]
	[Nullable(0)]
	public class UniversalDataSystemManager
	{
		// Token: 0x06000B9B RID: 2971 RVA: 0x0004ACDC File Offset: 0x00048EDC
		public void Initialize(string userId)
		{
			this.UserId = userId;
			UKuroStaticPS5Library.InitNpUniversalDataSystem(this.PoolSize);
			this.IsRegistered = false;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x0004ACF8 File Offset: 0x00048EF8
		public void Start()
		{
			this.CreateContext();
			this.CreateHandle();
			this.RegisterContext();
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x0004AD0C File Offset: 0x00048F0C
		public void Stop()
		{
			this.AbortHandle();
			this.DestroyHandle();
			this.DestroyContext();
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x0004AD20 File Offset: 0x00048F20
		private void CreateHandle()
		{
			if (this.UserId == null)
			{
				LauncherLog.Instance.Debug("UniversalDataSystemManager: CreateHandle Fail!!! UserId Is Empty", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int handle = 0;
			int num = UKuroStaticPS5Library.CreateUdsHandle(ref handle);
			if (num != 0)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "UniversalDataSystemManager: CreateUdsHandle Fail";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", num);
				instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.Handle = handle;
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x0004AD8C File Offset: 0x00048F8C
		private void AbortHandle()
		{
			int num = UKuroStaticPS5Library.AbortUdsHandle(this.Handle);
			if (num != 0)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "UniversalDataSystemManager: AbortUdsHandle Fail";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", num);
				instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x0004ADD0 File Offset: 0x00048FD0
		private void DestroyHandle()
		{
			int num = UKuroStaticPS5Library.DestroyUdsHandle(this.Handle);
			if (num != 0)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "UniversalDataSystemManager: DestroyUdsHandle Fail";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", num);
				instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.Handle = -1;
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x0004AE1C File Offset: 0x0004901C
		private void RegisterContext()
		{
			int num = UKuroStaticPS5Library.RegisterUdsContext(this.Context, this.Handle);
			if (num != 0)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "UniversalDataSystemManager: RegisterUdsContext Fail";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", num);
				instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.IsRegistered = true;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x0004AE70 File Offset: 0x00049070
		private void CreateContext()
		{
			if (this.UserId == null)
			{
				LauncherLog.Instance.Debug("UniversalDataSystemManager: CreateUdsContext Fail!!! UserId Is Empty", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int context = this.Context;
			int num = UKuroStaticPS5Library.CreateUdsContext(ref this.UserId, ref context);
			if (num != 0)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "UniversalDataSystemManager: CreateUdsContext Fail";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", num);
				instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.Context = context;
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x0004AEE8 File Offset: 0x000490E8
		private void DestroyContext()
		{
			if (this.Context == -1)
			{
				LauncherLog.Instance.Debug("UniversalDataSystemManager: DestroyUdsContext Fail!!! Context Is Empty", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			int num = UKuroStaticPS5Library.DestroyUdsContext(this.Context);
			if (num != 0)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "UniversalDataSystemManager: DestroyUdsContext Fail";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", num);
				instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			this.IsRegistered = false;
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0004AF58 File Offset: 0x00049158
		[return: Nullable(2)]
		private EventData CreateEvent(string eventName)
		{
			long eventPtr = 0L;
			long proPtr = 0L;
			int num = UKuroStaticPS5Library.CreateUdsEvent(ref eventName, ref eventPtr, ref proPtr);
			if (num != 0)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "UniversalDataSystemManager: CreateUdsEvent Fail";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", num);
				instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return null;
			}
			EventData eventData = new EventData();
			eventData.EventName = eventName;
			eventData.EventPtr = eventPtr;
			eventData.ProPtr = proPtr;
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "UniversalDataSystemManager: CreateUdsEvent Success";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("eventName", eventName);
			instance2.Debug(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return eventData;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0004AFE4 File Offset: 0x000491E4
		private unsafe void PostEvent(EventData eventData)
		{
			int num = UKuroStaticPS5Library.PostUdsEvent(this.Context, this.Handle, eventData.EventPtr);
			if (num != 0)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "UniversalDataSystemManager: PostUdsEvent Fail";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("result", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("eventName", eventData.EventName);
				instance.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "UniversalDataSystemManager: PostUdsEvent Success";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("eventName", eventData.EventName);
			instance2.Debug(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x0004B090 File Offset: 0x00049290
		private void DestroyEvent(EventData eventData)
		{
			int num = UKuroStaticPS5Library.DestroyUdsEvent(eventData.EventPtr);
			if (num != 0)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "UniversalDataSystemManager: DestroyUdsEvent Fail";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("result", num);
				instance.Debug(message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "UniversalDataSystemManager: DestroyUdsEvent Success";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("eventName", eventData.EventName);
			instance2.Debug(message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x0004B100 File Offset: 0x00049300
		private unsafe void EventPropertyObjectSetString(EventData eventData, string key, string value)
		{
			int num = UKuroStaticPS5Library.UdsEventPropertyObjectSetString(eventData.ProPtr, ref key, ref value);
			if (num != 0)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "UniversalDataSystemManager: EventPropertyObjectSetString Fail";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("result", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("value", value);
				instance.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "UniversalDataSystemManager: EventPropertyObjectSetString Success";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("eventName", eventData.EventName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("value", value);
			instance2.Debug(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x0004B1FC File Offset: 0x000493FC
		private unsafe void EventPropertyArraySetString(EventData eventData, string key, TArray<string> value)
		{
			int num = UKuroStaticPS5Library.UdsEventPropertyArraySetString(eventData.ProPtr, ref key, ref value);
			if (num != 0)
			{
				LauncherLog instance = LauncherLog.Instance;
				string message = "UniversalDataSystemManager: EventPropertyArraySetString Fail";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("result", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", key);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("value", value);
				instance.Debug(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			LauncherLog instance2 = LauncherLog.Instance;
			string message2 = "UniversalDataSystemManager: EventPropertyArraySetString Success";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("eventName", eventData.EventName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("value", value);
			instance2.Debug(message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x0004B2F8 File Offset: 0x000494F8
		public void StartActivity(string activityId)
		{
			EventData eventData = this.CreateEvent("activityStart");
			if (eventData != null)
			{
				this.EventPropertyObjectSetString(eventData, "activityId", activityId);
				this.PostEvent(eventData);
				this.DestroyEvent(eventData);
			}
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x0004B330 File Offset: 0x00049530
		public void EndActivity(string activityId, EPsActivityEndActivityOutcome outcome = EPsActivityEndActivityOutcome.Completed)
		{
			EventData eventData = this.CreateEvent("activityEnd");
			if (eventData != null)
			{
				this.EventPropertyObjectSetString(eventData, "activityId", activityId);
				this.EventPropertyObjectSetString(eventData, "outcome", outcome.ToEnumString());
				this.PostEvent(eventData);
				this.DestroyEvent(eventData);
			}
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x0004B37C File Offset: 0x0004957C
		public void ChangeActivityAvailability([Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> availableActivities, [Nullable(new byte[]
		{
			2,
			1
		})] TArray<string> unavailableActivities)
		{
			EventData eventData = this.CreateEvent("activityAvailabilityChange");
			if (eventData != null)
			{
				if (availableActivities != null)
				{
					this.EventPropertyArraySetString(eventData, "availableActivities", availableActivities);
				}
				if (unavailableActivities != null)
				{
					this.EventPropertyArraySetString(eventData, "unavailableActivities", unavailableActivities);
				}
				this.EventPropertyObjectSetString(eventData, "mode", "full");
				this.PostEvent(eventData);
				this.DestroyEvent(eventData);
			}
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0004B3D7 File Offset: 0x000495D7
		public int GetHandle()
		{
			return this.Handle;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x0004B3DF File Offset: 0x000495DF
		public int GetContext()
		{
			return this.Context;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x0004B3E7 File Offset: 0x000495E7
		public bool GetIsRegistered()
		{
			return this.IsRegistered;
		}

		// Token: 0x04000764 RID: 1892
		private const int SCE_NP_UNIVERSAL_DATA_SYSTEM_INVALID_CONTEXT = -1;

		// Token: 0x04000765 RID: 1893
		private const int SCE_NP_UNIVERSAL_DATA_SYSTEM_INVALID_HANDLE = -1;

		// Token: 0x04000766 RID: 1894
		private const int UNIVERSAL_DATA_SYSTEM_MEMORY_POOL_SIZE = 262144;

		// Token: 0x04000767 RID: 1895
		private const int SCE_OK = 0;

		// Token: 0x04000768 RID: 1896
		private int Context = -1;

		// Token: 0x04000769 RID: 1897
		private int Handle = -1;

		// Token: 0x0400076A RID: 1898
		private readonly int PoolSize = 262144;

		// Token: 0x0400076B RID: 1899
		private bool IsRegistered;

		// Token: 0x0400076C RID: 1900
		[Nullable(2)]
		private string UserId;
	}
}
