using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A1F RID: 6687
	public class ICheckFlowLookAtEntity : ICheckFlowLookAtTarget
	{
		// Token: 0x06008E49 RID: 36425 RVA: 0x00150188 File Offset: 0x0014E388
		private ICheckFlowLookAtEntity_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICheckFlowLookAtEntity 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICheckFlowLookAtEntity_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICheckFlowLookAtEntity_SetValue());
			}
			return result;
		}

		// Token: 0x06008E4A RID: 36426 RVA: 0x001501C0 File Offset: 0x0014E3C0
		public static ICheckFlowLookAtEntity Create([Nullable(2)] ICheckFlowLookAtEntity instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICheckFlowLookAtEntity
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E4B RID: 36427 RVA: 0x001501D3 File Offset: 0x0014E3D3
		public static ICheckFlowLookAtEntity CreateFromSetValue([Nullable(2)] ICheckFlowLookAtEntity_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICheckFlowLookAtEntity
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E4C RID: 36428 RVA: 0x001501E6 File Offset: 0x0014E3E6
		public new ICheckFlowLookAtEntity_SetValue ToSetValue()
		{
			return new ICheckFlowLookAtEntity_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId
			};
		}

		// Token: 0x17002E02 RID: 11778
		// (get) Token: 0x06008E4D RID: 36429 RVA: 0x00150205 File Offset: 0x0014E405
		// (set) Token: 0x06008E4E RID: 36430 RVA: 0x00150230 File Offset: 0x0014E430
		public override ECheckFlowLookAtTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECheckFlowLookAtTargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E03 RID: 11779
		// (get) Token: 0x06008E4F RID: 36431 RVA: 0x0015023E File Offset: 0x0014E43E
		// (set) Token: 0x06008E50 RID: 36432 RVA: 0x00150269 File Offset: 0x0014E469
		public virtual int EntityId
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

		// Token: 0x0400596B RID: 22891
		[Nullable(2)]
		protected new ICheckFlowLookAtEntity FbInstance;

		// Token: 0x0400596C RID: 22892
		[Nullable(2)]
		protected new ICheckFlowLookAtEntity_SetValue PocoInterface;
	}
}
