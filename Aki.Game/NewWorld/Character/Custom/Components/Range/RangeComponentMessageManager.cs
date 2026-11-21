using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace Aki.Game.NewWorld.Character.Custom.Components.Range
{
	// Token: 0x02002F71 RID: 12145
	[NullableContext(1)]
	[Nullable(0)]
	public class RangeComponentMessageManager : Singleton
	{
		// Token: 0x0601CC28 RID: 117800 RVA: 0x008C7318 File Offset: 0x008C5518
		public RangeComponentMessageManager()
		{
			this.RegisterInfoMap.Clear();
		}

		// Token: 0x0601CC29 RID: 117801 RVA: 0x008C7338 File Offset: 0x008C5538
		public void RegisterMessage(Entity entity, AccessRangeType accessRangeType, AccessRangeResultType accessRangeResultType, MessageRegisterCallback callback)
		{
			if (!this.RegisterInfoMap.ContainsKey(entity))
			{
				Dictionary<AccessRangeResultType, MessageRegisterCallBackInfo> dictionary = new Dictionary<AccessRangeResultType, MessageRegisterCallBackInfo>();
				MessageRegisterCallBackInfo messageRegisterCallBackInfo = new MessageRegisterCallBackInfo();
				switch (accessRangeType)
				{
				case AccessRangeType.RangeEnter:
					messageRegisterCallBackInfo.EnterCallbacks.Add(callback);
					break;
				case AccessRangeType.RangeLeave:
					messageRegisterCallBackInfo.LeaveCallback.Add(callback);
					break;
				case AccessRangeType.RangeInit:
					messageRegisterCallBackInfo.InitCallback.Add(callback);
					break;
				}
				dictionary[accessRangeResultType] = messageRegisterCallBackInfo;
				this.RegisterInfoMap[entity] = dictionary;
				return;
			}
			Dictionary<AccessRangeResultType, MessageRegisterCallBackInfo> dictionary2 = this.RegisterInfoMap[entity];
			if (!dictionary2.ContainsKey(accessRangeResultType))
			{
				MessageRegisterCallBackInfo messageRegisterCallBackInfo2 = new MessageRegisterCallBackInfo();
				switch (accessRangeType)
				{
				case AccessRangeType.RangeEnter:
					messageRegisterCallBackInfo2.EnterCallbacks.Add(callback);
					break;
				case AccessRangeType.RangeLeave:
					messageRegisterCallBackInfo2.LeaveCallback.Add(callback);
					break;
				case AccessRangeType.RangeInit:
					messageRegisterCallBackInfo2.InitCallback.Add(callback);
					break;
				}
				dictionary2[accessRangeResultType] = messageRegisterCallBackInfo2;
				return;
			}
			MessageRegisterCallBackInfo messageRegisterCallBackInfo3 = dictionary2[accessRangeResultType];
			switch (accessRangeType)
			{
			case AccessRangeType.RangeEnter:
				messageRegisterCallBackInfo3.EnterCallbacks.Add(callback);
				return;
			case AccessRangeType.RangeLeave:
				messageRegisterCallBackInfo3.LeaveCallback.Add(callback);
				return;
			case AccessRangeType.RangeInit:
				messageRegisterCallBackInfo3.InitCallback.Add(callback);
				return;
			default:
				return;
			}
		}

		// Token: 0x0601CC2A RID: 117802 RVA: 0x008C7464 File Offset: 0x008C5664
		public void UnRegisterMessage(Entity entity, AccessRangeType accessRangeType, AccessRangeResultType accessRangeResultType, MessageRegisterCallback callback)
		{
			Dictionary<AccessRangeResultType, MessageRegisterCallBackInfo> dictionary;
			MessageRegisterCallBackInfo messageRegisterCallBackInfo;
			if (this.RegisterInfoMap.TryGetValue(entity, out dictionary) && dictionary.TryGetValue(accessRangeResultType, out messageRegisterCallBackInfo))
			{
				switch (accessRangeType)
				{
				case AccessRangeType.RangeEnter:
					this.RemoveCallbackInternal(messageRegisterCallBackInfo.EnterCallbacks, callback);
					return;
				case AccessRangeType.RangeLeave:
					this.RemoveCallbackInternal(messageRegisterCallBackInfo.LeaveCallback, callback);
					return;
				case AccessRangeType.RangeInit:
					this.RemoveCallbackInternal(messageRegisterCallBackInfo.InitCallback, callback);
					break;
				default:
					return;
				}
			}
		}

		// Token: 0x0601CC2B RID: 117803 RVA: 0x008C74CC File Offset: 0x008C56CC
		private void RemoveCallbackInternal(List<MessageRegisterCallback> allCallbacks, MessageRegisterCallback needRemovedCallback)
		{
			int num = allCallbacks.IndexOf(needRemovedCallback);
			if (num != -1)
			{
				allCallbacks.RemoveAt(num);
			}
		}

		// Token: 0x0601CC2C RID: 117804 RVA: 0x008C74EC File Offset: 0x008C56EC
		public bool HasMessage(Entity entity, AccessRangeType accessRangeType, AccessRangeResultType accessRangeResultType, MessageRegisterCallback callback)
		{
			Dictionary<AccessRangeResultType, MessageRegisterCallBackInfo> dictionary;
			MessageRegisterCallBackInfo messageRegisterCallBackInfo;
			if (this.RegisterInfoMap.TryGetValue(entity, out dictionary) && dictionary.TryGetValue(accessRangeResultType, out messageRegisterCallBackInfo))
			{
				switch (accessRangeType)
				{
				case AccessRangeType.RangeEnter:
					return messageRegisterCallBackInfo.EnterCallbacks.Contains(callback);
				case AccessRangeType.RangeLeave:
					return messageRegisterCallBackInfo.LeaveCallback.Contains(callback);
				case AccessRangeType.RangeInit:
					return messageRegisterCallBackInfo.InitCallback.Contains(callback);
				}
			}
			return false;
		}

		// Token: 0x0601CC2D RID: 117805 RVA: 0x008C7554 File Offset: 0x008C5754
		public void EmitMessage(Entity entity, AccessRangeType accessRangeType, AccessRangeResultType accessRangeResultType, Entity otherEntity, ErrorCode errorCode)
		{
			Dictionary<AccessRangeResultType, MessageRegisterCallBackInfo> dictionary;
			MessageRegisterCallBackInfo messageRegisterCallBackInfo;
			if (this.RegisterInfoMap.TryGetValue(entity, out dictionary) && dictionary.TryGetValue(accessRangeResultType, out messageRegisterCallBackInfo))
			{
				switch (accessRangeType)
				{
				case AccessRangeType.RangeEnter:
					using (List<MessageRegisterCallback>.Enumerator enumerator = messageRegisterCallBackInfo.EnterCallbacks.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							MessageRegisterCallback messageRegisterCallback = enumerator.Current;
							messageRegisterCallback(accessRangeType, accessRangeResultType, otherEntity, errorCode);
						}
						return;
					}
					break;
				case AccessRangeType.RangeLeave:
					break;
				case AccessRangeType.RangeInit:
					goto IL_A9;
				default:
					return;
				}
				using (List<MessageRegisterCallback>.Enumerator enumerator = messageRegisterCallBackInfo.LeaveCallback.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						MessageRegisterCallback messageRegisterCallback2 = enumerator.Current;
						messageRegisterCallback2(accessRangeType, accessRangeResultType, otherEntity, errorCode);
					}
					return;
				}
				IL_A9:
				foreach (MessageRegisterCallback messageRegisterCallback3 in messageRegisterCallBackInfo.InitCallback)
				{
					messageRegisterCallback3(accessRangeType, accessRangeResultType, otherEntity, errorCode);
				}
			}
		}

		// Token: 0x17002D80 RID: 11648
		// (get) Token: 0x0601CC2E RID: 117806 RVA: 0x008C766C File Offset: 0x008C586C
		public static RangeComponentMessageManager Instance
		{
			get
			{
				if (RangeComponentMessageManager._instance == null)
				{
					RangeComponentMessageManager._instance = new RangeComponentMessageManager();
					RangeComponentMessageManager._instance.OnInit();
				}
				return RangeComponentMessageManager._instance;
			}
		}

		// Token: 0x0601CC2F RID: 117807 RVA: 0x008C768F File Offset: 0x008C588F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0601CC30 RID: 117808 RVA: 0x008C7691 File Offset: 0x008C5891
		public static void ResetStaticDefaultValue()
		{
			RangeComponentMessageManager instance = RangeComponentMessageManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			RangeComponentMessageManager._instance = null;
		}

		// Token: 0x0601CC31 RID: 117809 RVA: 0x008C76AA File Offset: 0x008C58AA
		static RangeComponentMessageManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RangeComponentMessageManager.CreateStaticDefaultValue), new Action(RangeComponentMessageManager.ResetStaticDefaultValue));
		}

		// Token: 0x0400F260 RID: 62048
		private readonly Dictionary<Entity, Dictionary<AccessRangeResultType, MessageRegisterCallBackInfo>> RegisterInfoMap = new Dictionary<Entity, Dictionary<AccessRangeResultType, MessageRegisterCallBackInfo>>();

		// Token: 0x0400F261 RID: 62049
		[Nullable(2)]
		private static RangeComponentMessageManager _instance;
	}
}
