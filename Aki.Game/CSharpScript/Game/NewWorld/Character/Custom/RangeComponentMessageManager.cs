using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.NewWorld.Character.Custom
{
	// Token: 0x020070A8 RID: 28840
	[NullableContext(1)]
	[Nullable(0)]
	public class RangeComponentMessageManager : Singleton
	{
		// Token: 0x06046437 RID: 287799 RVA: 0x01195679 File Offset: 0x01193879
		public RangeComponentMessageManager()
		{
			this.RegisterInfoMap.Clear();
		}

		// Token: 0x06046438 RID: 287800 RVA: 0x01195698 File Offset: 0x01193898
		public void RegisterMessage(Entity entity, AccessRangeType accessRangeType, AccessRangeResultType accessRangeResultType, TMessageRegisterCallback callback)
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

		// Token: 0x06046439 RID: 287801 RVA: 0x011957C4 File Offset: 0x011939C4
		public void UnRegisterMessage(Entity entity, AccessRangeType accessRangeType, AccessRangeResultType accessRangeResultType, TMessageRegisterCallback callback)
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

		// Token: 0x0604643A RID: 287802 RVA: 0x0119582C File Offset: 0x01193A2C
		private void RemoveCallbackInternal(List<TMessageRegisterCallback> allCallbacks, TMessageRegisterCallback needRemovedCallback)
		{
			int num = allCallbacks.IndexOf(needRemovedCallback);
			if (num != -1)
			{
				allCallbacks.RemoveAt(num);
			}
		}

		// Token: 0x0604643B RID: 287803 RVA: 0x0119584C File Offset: 0x01193A4C
		public bool HasMessage(Entity entity, AccessRangeType accessRangeType, AccessRangeResultType accessRangeResultType, TMessageRegisterCallback callback)
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

		// Token: 0x0604643C RID: 287804 RVA: 0x011958B4 File Offset: 0x01193AB4
		public void EmitMessage(Entity entity, AccessRangeType accessRangeType, AccessRangeResultType accessRangeResultType, Entity otherEntity, ErrorCode errorCode)
		{
			Dictionary<AccessRangeResultType, MessageRegisterCallBackInfo> dictionary;
			MessageRegisterCallBackInfo messageRegisterCallBackInfo;
			if (this.RegisterInfoMap.TryGetValue(entity, out dictionary) && dictionary.TryGetValue(accessRangeResultType, out messageRegisterCallBackInfo))
			{
				switch (accessRangeType)
				{
				case AccessRangeType.RangeEnter:
					using (List<TMessageRegisterCallback>.Enumerator enumerator = messageRegisterCallBackInfo.EnterCallbacks.GetEnumerator())
					{
						while (enumerator.MoveNext())
						{
							TMessageRegisterCallback tmessageRegisterCallback = enumerator.Current;
							tmessageRegisterCallback(accessRangeType, accessRangeResultType, otherEntity, errorCode);
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
				using (List<TMessageRegisterCallback>.Enumerator enumerator = messageRegisterCallBackInfo.LeaveCallback.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						TMessageRegisterCallback tmessageRegisterCallback2 = enumerator.Current;
						tmessageRegisterCallback2(accessRangeType, accessRangeResultType, otherEntity, errorCode);
					}
					return;
				}
				IL_A9:
				foreach (TMessageRegisterCallback tmessageRegisterCallback3 in messageRegisterCallBackInfo.InitCallback)
				{
					tmessageRegisterCallback3(accessRangeType, accessRangeResultType, otherEntity, errorCode);
				}
			}
		}

		// Token: 0x17009C2E RID: 39982
		// (get) Token: 0x0604643D RID: 287805 RVA: 0x011959CC File Offset: 0x01193BCC
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

		// Token: 0x0604643E RID: 287806 RVA: 0x011959EF File Offset: 0x01193BEF
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604643F RID: 287807 RVA: 0x011959F1 File Offset: 0x01193BF1
		public static void ResetStaticDefaultValue()
		{
			RangeComponentMessageManager instance = RangeComponentMessageManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			RangeComponentMessageManager._instance = null;
		}

		// Token: 0x06046440 RID: 287808 RVA: 0x01195A0A File Offset: 0x01193C0A
		static RangeComponentMessageManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RangeComponentMessageManager.CreateStaticDefaultValue), new Action(RangeComponentMessageManager.ResetStaticDefaultValue));
		}

		// Token: 0x04024D1C RID: 150812
		private readonly Dictionary<Entity, Dictionary<AccessRangeResultType, MessageRegisterCallBackInfo>> RegisterInfoMap = new Dictionary<Entity, Dictionary<AccessRangeResultType, MessageRegisterCallBackInfo>>();

		// Token: 0x04024D1D RID: 150813
		[Nullable(2)]
		private static RangeComponentMessageManager _instance;
	}
}
