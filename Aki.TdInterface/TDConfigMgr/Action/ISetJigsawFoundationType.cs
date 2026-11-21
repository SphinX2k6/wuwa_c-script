using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002057 RID: 8279
	public class ISetJigsawFoundationType
	{
		// Token: 0x0600AFB5 RID: 44981 RVA: 0x0018BAC8 File Offset: 0x00189CC8
		private ISetJigsawFoundationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetJigsawFoundationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetJigsawFoundationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetJigsawFoundationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AFB6 RID: 44982 RVA: 0x0018BB00 File Offset: 0x00189D00
		public static ISetJigsawFoundationType Create([Nullable(2)] ISetJigsawFoundationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetJigsawFoundationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AFB7 RID: 44983 RVA: 0x0018BB13 File Offset: 0x00189D13
		public static ISetJigsawFoundationType CreateFromSetValue([Nullable(2)] ISetJigsawFoundationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetJigsawFoundationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AFB8 RID: 44984 RVA: 0x0018BB26 File Offset: 0x00189D26
		public ISetJigsawFoundationType_SetValue ToSetValue()
		{
			return new ISetJigsawFoundationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x0600AFB9 RID: 44985 RVA: 0x0018BB39 File Offset: 0x00189D39
		// (set) Token: 0x0600AFBA RID: 44986 RVA: 0x0018BB64 File Offset: 0x00189D64
		public virtual ESetJigsawFoundationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetJigsawFoundationType.SetPieceState;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006895 RID: 26773
		[Nullable(2)]
		protected ISetJigsawFoundationType FbInstance;

		// Token: 0x04006896 RID: 26774
		[Nullable(2)]
		protected ISetJigsawFoundationType_SetValue PocoInterface;
	}
}
