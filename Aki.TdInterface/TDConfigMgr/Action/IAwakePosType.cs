using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001979 RID: 6521
	public class IAwakePosType
	{
		// Token: 0x06008ABB RID: 35515 RVA: 0x001499A8 File Offset: 0x00147BA8
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

		// Token: 0x06008ABC RID: 35516 RVA: 0x001499E0 File Offset: 0x00147BE0
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

		// Token: 0x06008ABD RID: 35517 RVA: 0x001499F3 File Offset: 0x00147BF3
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

		// Token: 0x06008ABE RID: 35518 RVA: 0x00149A06 File Offset: 0x00147C06
		public IAwakePosType_SetValue ToSetValue()
		{
			return new IAwakePosType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D34 RID: 11572
		// (get) Token: 0x06008ABF RID: 35519 RVA: 0x00149A19 File Offset: 0x00147C19
		// (set) Token: 0x06008AC0 RID: 35520 RVA: 0x00149A44 File Offset: 0x00147C44
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

		// Token: 0x040057C3 RID: 22467
		[Nullable(2)]
		protected IAwakePosType FbInstance;

		// Token: 0x040057C4 RID: 22468
		[Nullable(2)]
		protected IAwakePosType_SetValue PocoInterface;
	}
}
