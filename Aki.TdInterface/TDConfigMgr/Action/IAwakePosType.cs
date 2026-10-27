using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017F0 RID: 6128
	[NullableContext(1)]
	[Nullable(0)]
	public class IAwakePosType
	{
		// Token: 0x0600839F RID: 33695 RVA: 0x0013A2C0 File Offset: 0x001384C0
		private IAwakePosType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAwakePosType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAwakePosType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAwakePosType_SetValue());
			}
			return result;
		}

		// Token: 0x060083A0 RID: 33696 RVA: 0x0013A2F8 File Offset: 0x001384F8
		public static IAwakePosType Create([Nullable(2)] IAwakePosType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAwakePosType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060083A1 RID: 33697 RVA: 0x0013A30B File Offset: 0x0013850B
		public static IAwakePosType CreateFromSetValue([Nullable(2)] IAwakePosType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAwakePosType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060083A2 RID: 33698 RVA: 0x0013A31E File Offset: 0x0013851E
		public IAwakePosType_SetValue ToSetValue()
		{
			return new IAwakePosType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B3C RID: 11068
		// (get) Token: 0x060083A3 RID: 33699 RVA: 0x0013A331 File Offset: 0x00138531
		// (set) Token: 0x060083A4 RID: 33700 RVA: 0x0013A35C File Offset: 0x0013855C
		public virtual EAwakePosType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAwakePosType.TransformVar;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400537B RID: 21371
		[Nullable(2)]
		protected IAwakePosType FbInstance;

		// Token: 0x0400537C RID: 21372
		[Nullable(2)]
		protected IAwakePosType_SetValue PocoInterface;
	}
}
