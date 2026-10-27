using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200186E RID: 6254
	[NullableContext(1)]
	[Nullable(0)]
	public class IChangeEntityStateDirectly : ChangeEntityState
	{
		// Token: 0x0600865F RID: 34399 RVA: 0x0013F380 File Offset: 0x0013D580
		private IChangeEntityStateDirectly_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IChangeEntityStateDirectly 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IChangeEntityStateDirectly_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IChangeEntityStateDirectly_SetValue());
			}
			return result;
		}

		// Token: 0x06008660 RID: 34400 RVA: 0x0013F3B8 File Offset: 0x0013D5B8
		public static IChangeEntityStateDirectly Create([Nullable(2)] IChangeEntityStateDirectly instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IChangeEntityStateDirectly
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008661 RID: 34401 RVA: 0x0013F3CB File Offset: 0x0013D5CB
		public static IChangeEntityStateDirectly CreateFromSetValue([Nullable(2)] IChangeEntityStateDirectly_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IChangeEntityStateDirectly
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008662 RID: 34402 RVA: 0x0013F3DE File Offset: 0x0013D5DE
		public new IChangeEntityStateDirectly_SetValue ToSetValue()
		{
			return new IChangeEntityStateDirectly_SetValue
			{
				Type = this.Type,
				EntityId = this.EntityId,
				State = this.State,
				DelayChange = this.DelayChange
			};
		}

		// Token: 0x17002BDF RID: 11231
		// (get) Token: 0x06008663 RID: 34403 RVA: 0x0013F415 File Offset: 0x0013D615
		// (set) Token: 0x06008664 RID: 34404 RVA: 0x0013F440 File Offset: 0x0013D640
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

		// Token: 0x17002BE0 RID: 11232
		// (get) Token: 0x06008665 RID: 34405 RVA: 0x0013F44E File Offset: 0x0013D64E
		// (set) Token: 0x06008666 RID: 34406 RVA: 0x0013F479 File Offset: 0x0013D679
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

		// Token: 0x17002BE1 RID: 11233
		// (get) Token: 0x06008667 RID: 34407 RVA: 0x0013F487 File Offset: 0x0013D687
		// (set) Token: 0x06008668 RID: 34408 RVA: 0x0013F4B2 File Offset: 0x0013D6B2
		public virtual string State
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.State;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.State;
			}
			set
			{
				this.GetOrCreatePoco().State = value;
			}
		}

		// Token: 0x17002BE2 RID: 11234
		// (get) Token: 0x06008669 RID: 34409 RVA: 0x0013F4C0 File Offset: 0x0013D6C0
		// (set) Token: 0x0600866A RID: 34410 RVA: 0x0013F4FA File Offset: 0x0013D6FA
		public virtual bool? DelayChange
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayChange;
				}
				IChangeEntityStateDirectly_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayChange;
			}
			set
			{
				this.GetOrCreatePoco().DelayChange = value;
			}
		}

		// Token: 0x040054C2 RID: 21698
		[Nullable(2)]
		protected new IChangeEntityStateDirectly FbInstance;

		// Token: 0x040054C3 RID: 21699
		[Nullable(2)]
		protected new IChangeEntityStateDirectly_SetValue PocoInterface;
	}
}
