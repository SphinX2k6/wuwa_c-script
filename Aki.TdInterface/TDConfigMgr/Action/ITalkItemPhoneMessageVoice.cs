using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200218B RID: 8587
	public class ITalkItemPhoneMessageVoice : ITalkItemPhoneMessageBase
	{
		// Token: 0x0600B93A RID: 47418 RVA: 0x001A7AA0 File Offset: 0x001A5CA0
		private ITalkItemPhoneMessageVoice_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemPhoneMessageVoice 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemPhoneMessageVoice_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemPhoneMessageVoice_SetValue());
			}
			return result;
		}

		// Token: 0x0600B93B RID: 47419 RVA: 0x001A7AD8 File Offset: 0x001A5CD8
		public static ITalkItemPhoneMessageVoice Create([Nullable(2)] ITalkItemPhoneMessageVoice instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageVoice
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B93C RID: 47420 RVA: 0x001A7AEB File Offset: 0x001A5CEB
		public static ITalkItemPhoneMessageVoice CreateFromSetValue([Nullable(2)] ITalkItemPhoneMessageVoice_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemPhoneMessageVoice
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B93D RID: 47421 RVA: 0x001A7AFE File Offset: 0x001A5CFE
		public new ITalkItemPhoneMessageVoice_SetValue ToSetValue()
		{
			return new ITalkItemPhoneMessageVoice_SetValue
			{
				Type = this.Type,
				PushCondition = this.PushCondition,
				AutoPlay = this.AutoPlay
			};
		}

		// Token: 0x1700385C RID: 14428
		// (get) Token: 0x0600B93E RID: 47422 RVA: 0x001A7B29 File Offset: 0x001A5D29
		// (set) Token: 0x0600B93F RID: 47423 RVA: 0x001A7B54 File Offset: 0x001A5D54
		public override EPhoneMessageType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPhoneMessageType.Voice;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700385D RID: 14429
		// (get) Token: 0x0600B940 RID: 47424 RVA: 0x001A7B64 File Offset: 0x001A5D64
		// (set) Token: 0x0600B941 RID: 47425 RVA: 0x001A7B9E File Offset: 0x001A5D9E
		public virtual EPhoneMessageVoicePushCondition? PushCondition
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PushCondition;
				}
				ITalkItemPhoneMessageVoice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PushCondition;
			}
			set
			{
				this.GetOrCreatePoco().PushCondition = value;
			}
		}

		// Token: 0x1700385E RID: 14430
		// (get) Token: 0x0600B942 RID: 47426 RVA: 0x001A7BAC File Offset: 0x001A5DAC
		// (set) Token: 0x0600B943 RID: 47427 RVA: 0x001A7BE6 File Offset: 0x001A5DE6
		public virtual bool? AutoPlay
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.AutoPlay;
				}
				ITalkItemPhoneMessageVoice_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.AutoPlay;
			}
			set
			{
				this.GetOrCreatePoco().AutoPlay = value;
			}
		}

		// Token: 0x04006EC4 RID: 28356
		[Nullable(2)]
		protected new ITalkItemPhoneMessageVoice FbInstance;

		// Token: 0x04006EC5 RID: 28357
		[Nullable(2)]
		protected new ITalkItemPhoneMessageVoice_SetValue PocoInterface;
	}
}
