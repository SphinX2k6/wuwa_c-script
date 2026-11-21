using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002163 RID: 8547
	public class ITalkEffectType
	{
		// Token: 0x0600B56C RID: 46444 RVA: 0x00196144 File Offset: 0x00194344
		private ITalkEffectType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkEffectType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkEffectType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkEffectType_SetValue());
			}
			return result;
		}

		// Token: 0x0600B56D RID: 46445 RVA: 0x0019617C File Offset: 0x0019437C
		public static ITalkEffectType Create([Nullable(2)] ITalkEffectType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkEffectType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B56E RID: 46446 RVA: 0x0019618F File Offset: 0x0019438F
		public static ITalkEffectType CreateFromSetValue([Nullable(2)] ITalkEffectType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkEffectType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B56F RID: 46447 RVA: 0x001961A2 File Offset: 0x001943A2
		public ITalkEffectType_SetValue ToSetValue()
		{
			return new ITalkEffectType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170036B1 RID: 14001
		// (get) Token: 0x0600B570 RID: 46448 RVA: 0x001961B5 File Offset: 0x001943B5
		// (set) Token: 0x0600B571 RID: 46449 RVA: 0x001961E0 File Offset: 0x001943E0
		public virtual ETalkEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkEffectType.Effect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006B3F RID: 27455
		[Nullable(2)]
		protected ITalkEffectType FbInstance;

		// Token: 0x04006B40 RID: 27456
		[Nullable(2)]
		protected ITalkEffectType_SetValue PocoInterface;
	}
}
