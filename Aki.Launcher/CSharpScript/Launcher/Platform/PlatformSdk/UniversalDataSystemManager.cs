using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Platform.PlatformSdk
{
	// Token: 0x0200019F RID: 415
	[NullableContext(1)]
	[Nullable(0)]
	public class UniversalDataSystemManager
	{
		// Token: 0x06000B64 RID: 2916 RVA: 0x000484EC File Offset: 0x000466EC
		public void Initialize(string userId)
		{
			this.UserId = userId;
			UKuroStaticPS5Library.InitNpUniversalDataSystem(this.PoolSize);
			this.IsRegistered = false;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00048508 File Offset: 0x00046708
		public void Start()
		{
			this.CreateContext();
			this.CreateHandle();
			this.RegisterContext();
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0004851C File Offset: 0x0004671C
		public void Stop()
		{
			this.AbortHandle();
			this.DestroyHandle();
			this.DestroyContext();
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00048530 File Offset: 0x00046730
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

		// Token: 0x06000B68 RID: 2920 RVA: 0x0004859C File Offset: 0x0004679C
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

		// Token: 0x06000B69 RID: 2921 RVA: 0x000485E0 File Offset: 0x000467E0
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

		// Token: 0x06000B6A RID: 2922 RVA: 0x0004862C File Offset: 0x0004682C
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

		// Token: 0x06000B6B RID: 2923 RVA: 0x00048680 File Offset: 0x00046880
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

		// Token: 0x06000B6C RID: 2924 RVA: 0x000486F8 File Offset: 0x000468F8
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

		// Token: 0x06000B6D RID: 2925 RVA: 0x00048768 File Offset: 0x00046968
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

		// Token: 0x06000B6E RID: 2926 RVA: 0x000487F4 File Offset: 0x000469F4
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

		// Token: 0x06000B6F RID: 2927 RVA: 0x000488A0 File Offset: 0x00046AA0
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

		// Token: 0x06000B70 RID: 2928 RVA: 0x00048910 File Offset: 0x00046B10
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

		// Token: 0x06000B71 RID: 2929 RVA: 0x00048A0C File Offset: 0x00046C0C
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

		// Token: 0x06000B72 RID: 2930 RVA: 0x00048B08 File Offset: 0x00046D08
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

		// Token: 0x06000B73 RID: 2931 RVA: 0x00048B40 File Offset: 0x00046D40
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

		// Token: 0x06000B74 RID: 2932 RVA: 0x00048B8C File Offset: 0x00046D8C
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

		// Token: 0x06000B75 RID: 2933 RVA: 0x00048BE7 File Offset: 0x00046DE7
		public int GetHandle()
		{
			return this.Handle;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00048BEF File Offset: 0x00046DEF
		public int GetContext()
		{
			return this.Context;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00048BF7 File Offset: 0x00046DF7
		public bool GetIsRegistered()
		{
			return this.IsRegistered;
		}

		// Token: 0x04000728 RID: 1832
		private const int SCE_NP_UNIVERSAL_DATA_SYSTEM_INVALID_CONTEXT = -1;

		// Token: 0x04000729 RID: 1833
		private const int SCE_NP_UNIVERSAL_DATA_SYSTEM_INVALID_HANDLE = -1;

		// Token: 0x0400072A RID: 1834
		private const int UNIVERSAL_DATA_SYSTEM_MEMORY_POOL_SIZE = 262144;

		// Token: 0x0400072B RID: 1835
		private const int SCE_OK = 0;

		// Token: 0x0400072C RID: 1836
		private int Context = -1;

		// Token: 0x0400072D RID: 1837
		private int Handle = -1;

		// Token: 0x0400072E RID: 1838
		private readonly int PoolSize = 262144;

		// Token: 0x0400072F RID: 1839
		private bool IsRegistered;

		// Token: 0x04000730 RID: 1840
		[Nullable(2)]
		private string UserId;
	}
}
