using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C5A RID: 7258
	[NullableContext(1)]
	[Nullable(0)]
	public class INewSplineStopTarget
	{
		// Token: 0x06009BA9 RID: 39849 RVA: 0x00165670 File Offset: 0x00163870
		private INewSplineStopTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INewSplineStopTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INewSplineStopTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INewSplineStopTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06009BAA RID: 39850 RVA: 0x001656A8 File Offset: 0x001638A8
		public static INewSplineStopTarget Create([Nullable(2)] INewSplineStopTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewSplineStopTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BAB RID: 39851 RVA: 0x001656BB File Offset: 0x001638BB
		public static INewSplineStopTarget CreateFromSetValue([Nullable(2)] INewSplineStopTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INewSplineStopTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BAC RID: 39852 RVA: 0x001656CE File Offset: 0x001638CE
		public INewSplineStopTarget_SetValue ToSetValue()
		{
			return new INewSplineStopTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030A4 RID: 12452
		// (get) Token: 0x06009BAD RID: 39853 RVA: 0x001656E1 File Offset: 0x001638E1
		// (set) Token: 0x06009BAE RID: 39854 RVA: 0x0016570C File Offset: 0x0016390C
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

		// Token: 0x04005E81 RID: 24193
		[Nullable(2)]
		protected INewSplineStopTarget FbInstance;

		// Token: 0x04005E82 RID: 24194
		[Nullable(2)]
		protected INewSplineStopTarget_SetValue PocoInterface;
	}
}
