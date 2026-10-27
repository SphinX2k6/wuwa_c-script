using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001870 RID: 6256
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeEntityStateLoop : ChangeEntityState
	{
		// Token: 0x0600866D RID: 34413 RVA: 0x0013F518 File Offset: 0x0013D718
		private IChangeEntityStateLoop_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeEntityStateLoop 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeEntityStateLoop_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeEntityStateLoop_SetValue());
			}
			return result;
		}

		// Token: 0x0600866E RID: 34414 RVA: 0x0013F550 File Offset: 0x0013D750
		public static IChangeEntityStateLoop Create([Nullable(2)] IChangeEntityStateLoop instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeEntityStateLoop
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600866F RID: 34415 RVA: 0x0013F563 File Offset: 0x0013D763
		public static IChangeEntityStateLoop CreateFromSetValue([Nullable(2)] IChangeEntityStateLoop_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeEntityStateLoop
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008670 RID: 34416 RVA: 0x0013F576 File Offset: 0x0013D776
		public new IChangeEntityStateLoop_SetValue ToSetValue()
		{
			return new IChangeEntityStateLoop_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				Circulation = this.Circulation
			};
		}

		// Token: 0x17002BE3 RID: 11235
		// (get) Token: 0x06008671 RID: 34417 RVA: 0x0013F5A1 File Offset: 0x0013D7A1
		// (set) Token: 0x06008672 RID: 34418 RVA: 0x0013F5CC File Offset: 0x0013D7CC
		public override EChangeEntityState Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EChangeEntityState.Directly;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002BE4 RID: 11236
		// (get) Token: 0x06008673 RID: 34419 RVA: 0x0013F5DA File Offset: 0x0013D7DA
		// (set) Token: 0x06008674 RID: 34420 RVA: 0x0013F605 File Offset: 0x0013D805
		public override int EntityId
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

		// Token: 0x17002BE5 RID: 11237
		// (get) Token: 0x06008675 RID: 34421 RVA: 0x0013F613 File Offset: 0x0013D813
		// (set) Token: 0x06008676 RID: 34422 RVA: 0x0013F63E File Offset: 0x0013D83E
		public virtual ELoopStateType Circulation
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Circulation;
				}
				if (this.PocoInterface == null)
				{
					return ELoopStateType.Prev;
				}
				return this.PocoInterface.Circulation;
			}
			set
			{
				this.GetOrCreatePoco().Circulation = value;
			}
		}

		// Token: 0x040054C8 RID: 21704
		[Nullable(2)]
		protected new IChangeEntityStateLoop FbInstance;

		// Token: 0x040054C9 RID: 21705
		[Nullable(2)]
		protected new IChangeEntityStateLoop_SetValue PocoInterface;
	}
}
