using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200110D RID: 4365
	public class IKurotatoConditionStepSaveRole : IKurotatoConditionStepBase
	{
		// Token: 0x06006064 RID: 24676 RVA: 0x000E8A60 File Offset: 0x000E6C60
		private IKurotatoConditionStepSaveRole_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKurotatoConditionStepSaveRole 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKurotatoConditionStepSaveRole_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKurotatoConditionStepSaveRole_SetValue());
			}
			return result;
		}

		// Token: 0x06006065 RID: 24677 RVA: 0x000E8A98 File Offset: 0x000E6C98
		public static IKurotatoConditionStepSaveRole Create([Nullable(2)] IKurotatoConditionStepSaveRole instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKurotatoConditionStepSaveRole
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006066 RID: 24678 RVA: 0x000E8AAB File Offset: 0x000E6CAB
		public static IKurotatoConditionStepSaveRole CreateFromSetValue([Nullable(2)] IKurotatoConditionStepSaveRole_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKurotatoConditionStepSaveRole
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006067 RID: 24679 RVA: 0x000E8ABE File Offset: 0x000E6CBE
		public new IKurotatoConditionStepSaveRole_SetValue ToSetValue()
		{
			return new IKurotatoConditionStepSaveRole_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001F9B RID: 8091
		// (get) Token: 0x06006068 RID: 24680 RVA: 0x000E8AD1 File Offset: 0x000E6CD1
		// (set) Token: 0x06006069 RID: 24681 RVA: 0x000E8AFC File Offset: 0x000E6CFC
		public override EKurotatoConditionStep Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EKurotatoConditionStep.Prepare;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040039BB RID: 14779
		[Nullable(2)]
		protected new IKurotatoConditionStepSaveRole FbInstance;

		// Token: 0x040039BC RID: 14780
		[Nullable(2)]
		protected new IKurotatoConditionStepSaveRole_SetValue PocoInterface;
	}
}
