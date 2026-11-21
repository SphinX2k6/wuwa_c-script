using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200207D RID: 8317
	public class ISetTeleControlConfig
	{
		// Token: 0x0600B095 RID: 45205 RVA: 0x0018D678 File Offset: 0x0018B878
		private ISetTeleControlConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetTeleControlConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetTeleControlConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetTeleControlConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600B096 RID: 45206 RVA: 0x0018D6B0 File Offset: 0x0018B8B0
		public static ISetTeleControlConfig Create([Nullable(2)] ISetTeleControlConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetTeleControlConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B097 RID: 45207 RVA: 0x0018D6C3 File Offset: 0x0018B8C3
		public static ISetTeleControlConfig CreateFromSetValue([Nullable(2)] ISetTeleControlConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetTeleControlConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B098 RID: 45208 RVA: 0x0018D6D6 File Offset: 0x0018B8D6
		public ISetTeleControlConfig_SetValue ToSetValue()
		{
			return new ISetTeleControlConfig_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x1700359D RID: 13725
		// (get) Token: 0x0600B099 RID: 45209 RVA: 0x0018D6F5 File Offset: 0x0018B8F5
		// (set) Token: 0x0600B09A RID: 45210 RVA: 0x0018D720 File Offset: 0x0018B920
		public virtual ESetTeleControlType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetTeleControlType.OpenGravity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700359E RID: 13726
		// (get) Token: 0x0600B09B RID: 45211 RVA: 0x0018D72E File Offset: 0x0018B92E
		// (set) Token: 0x0600B09C RID: 45212 RVA: 0x0018D759 File Offset: 0x0018B959
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x0400690A RID: 26890
		[Nullable(2)]
		protected ISetTeleControlConfig FbInstance;

		// Token: 0x0400690B RID: 26891
		[Nullable(2)]
		protected ISetTeleControlConfig_SetValue PocoInterface;
	}
}
