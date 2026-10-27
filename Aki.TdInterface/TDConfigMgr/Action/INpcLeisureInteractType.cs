using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C6C RID: 7276
	[NullableContext(1)]
	[Nullable(0)]
	public class INpcLeisureInteractType
	{
		// Token: 0x06009C0B RID: 39947 RVA: 0x00166148 File Offset: 0x00164348
		private INpcLeisureInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcLeisureInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcLeisureInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcLeisureInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x06009C0C RID: 39948 RVA: 0x00166180 File Offset: 0x00164380
		public static INpcLeisureInteractType Create([Nullable(2)] INpcLeisureInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcLeisureInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009C0D RID: 39949 RVA: 0x00166193 File Offset: 0x00164393
		public static INpcLeisureInteractType CreateFromSetValue([Nullable(2)] INpcLeisureInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcLeisureInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009C0E RID: 39950 RVA: 0x001661A6 File Offset: 0x001643A6
		public INpcLeisureInteractType_SetValue ToSetValue()
		{
			return new INpcLeisureInteractType_SetValue
			{
				Type = this.Type,
				KeepState = this.KeepState
			};
		}

		// Token: 0x170030BA RID: 12474
		// (get) Token: 0x06009C0F RID: 39951 RVA: 0x001661C5 File Offset: 0x001643C5
		// (set) Token: 0x06009C10 RID: 39952 RVA: 0x001661F0 File Offset: 0x001643F0
		public virtual ENpcLeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcLeisureInteract.SitDown;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030BB RID: 12475
		// (get) Token: 0x06009C11 RID: 39953 RVA: 0x00166200 File Offset: 0x00164400
		// (set) Token: 0x06009C12 RID: 39954 RVA: 0x0016623A File Offset: 0x0016443A
		public virtual bool? KeepState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.KeepState;
				}
				INpcLeisureInteractType_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.KeepState;
			}
			set
			{
				this.GetOrCreatePoco().KeepState = value;
			}
		}

		// Token: 0x04005EAF RID: 24239
		[Nullable(2)]
		protected INpcLeisureInteractType FbInstance;

		// Token: 0x04005EB0 RID: 24240
		[Nullable(2)]
		protected INpcLeisureInteractType_SetValue PocoInterface;
	}
}
