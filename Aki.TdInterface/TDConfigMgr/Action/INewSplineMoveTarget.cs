using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C58 RID: 7256
	[NullableContext(1)]
	[Nullable(0)]
	public class INewSplineMoveTarget
	{
		// Token: 0x06009BA1 RID: 39841 RVA: 0x001655B4 File Offset: 0x001637B4
		private INewSplineMoveTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INewSplineMoveTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INewSplineMoveTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INewSplineMoveTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06009BA2 RID: 39842 RVA: 0x001655EC File Offset: 0x001637EC
		public static INewSplineMoveTarget Create([Nullable(2)] INewSplineMoveTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewSplineMoveTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BA3 RID: 39843 RVA: 0x001655FF File Offset: 0x001637FF
		public static INewSplineMoveTarget CreateFromSetValue([Nullable(2)] INewSplineMoveTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INewSplineMoveTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BA4 RID: 39844 RVA: 0x00165612 File Offset: 0x00163812
		public INewSplineMoveTarget_SetValue ToSetValue()
		{
			return new INewSplineMoveTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030A3 RID: 12451
		// (get) Token: 0x06009BA5 RID: 39845 RVA: 0x00165625 File Offset: 0x00163825
		// (set) Token: 0x06009BA6 RID: 39846 RVA: 0x00165650 File Offset: 0x00163850
		public virtual ENewSplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005E7E RID: 24190
		[Nullable(2)]
		protected INewSplineMoveTarget FbInstance;

		// Token: 0x04005E7F RID: 24191
		[Nullable(2)]
		protected INewSplineMoveTarget_SetValue PocoInterface;
	}
}
