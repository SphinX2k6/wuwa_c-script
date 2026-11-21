using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200215D RID: 8541
	public class ITalkEffectActionType
	{
		// Token: 0x0600B546 RID: 46406 RVA: 0x00195CAC File Offset: 0x00193EAC
		private ITalkEffectActionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkEffectActionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkEffectActionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkEffectActionType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B547 RID: 46407 RVA: 0x00195CE4 File Offset: 0x00193EE4
		public static ITalkEffectActionType Create([Nullable(2)] ITalkEffectActionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkEffectActionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B548 RID: 46408 RVA: 0x00195CF7 File Offset: 0x00193EF7
		public static ITalkEffectActionType CreateFromSetValue([Nullable(2)] ITalkEffectActionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkEffectActionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B549 RID: 46409 RVA: 0x00195D0A File Offset: 0x00193F0A
		public ITalkEffectActionType_SetValue ToSetValue()
		{
			return new ITalkEffectActionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036A7 RID: 13991
		// (get) Token: 0x0600B54A RID: 46410 RVA: 0x00195D1D File Offset: 0x00193F1D
		// (set) Token: 0x0600B54B RID: 46411 RVA: 0x00195D48 File Offset: 0x00193F48
		public virtual ETalkEffectActionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkEffectActionType.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006B2D RID: 27437
		[Nullable(2)]
		protected ITalkEffectActionType FbInstance;

		// Token: 0x04006B2E RID: 27438
		[Nullable(2)]
		protected ITalkEffectActionType_SetValue PocoInterface;
	}
}
