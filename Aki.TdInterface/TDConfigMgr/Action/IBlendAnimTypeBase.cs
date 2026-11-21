using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001999 RID: 6553
	public class IBlendAnimTypeBase
	{
		// Token: 0x06008B51 RID: 35665 RVA: 0x0014A87C File Offset: 0x00148A7C
		private IBlendAnimTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBlendAnimTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBlendAnimTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBlendAnimTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06008B52 RID: 35666 RVA: 0x0014A8B4 File Offset: 0x00148AB4
		public static IBlendAnimTypeBase Create([Nullable(2)] IBlendAnimTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBlendAnimTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B53 RID: 35667 RVA: 0x0014A8C7 File Offset: 0x00148AC7
		public static IBlendAnimTypeBase CreateFromSetValue([Nullable(2)] IBlendAnimTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBlendAnimTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B54 RID: 35668 RVA: 0x0014A8DA File Offset: 0x00148ADA
		public IBlendAnimTypeBase_SetValue ToSetValue()
		{
			return new IBlendAnimTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D4F RID: 11599
		// (get) Token: 0x06008B55 RID: 35669 RVA: 0x0014A8ED File Offset: 0x00148AED
		// (set) Token: 0x06008B56 RID: 35670 RVA: 0x0014A918 File Offset: 0x00148B18
		public virtual EBlendAnimType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBlendAnimType.StateMachine;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040057FE RID: 22526
		[Nullable(2)]
		protected IBlendAnimTypeBase FbInstance;

		// Token: 0x040057FF RID: 22527
		[Nullable(2)]
		protected IBlendAnimTypeBase_SetValue PocoInterface;
	}
}
