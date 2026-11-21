using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E71 RID: 7793
	public class INpcLeisureInteractType
	{
		// Token: 0x0600A5A5 RID: 42405 RVA: 0x00179B3C File Offset: 0x00177D3C
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

		// Token: 0x0600A5A6 RID: 42406 RVA: 0x00179B74 File Offset: 0x00177D74
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

		// Token: 0x0600A5A7 RID: 42407 RVA: 0x00179B87 File Offset: 0x00177D87
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

		// Token: 0x0600A5A8 RID: 42408 RVA: 0x00179B9A File Offset: 0x00177D9A
		public INpcLeisureInteractType_SetValue ToSetValue()
		{
			return new INpcLeisureInteractType_SetValue
			{
				Type = this.Type,
				KeepState = this.KeepState
			};
		}

		// Token: 0x17003337 RID: 13111
		// (get) Token: 0x0600A5A9 RID: 42409 RVA: 0x00179BB9 File Offset: 0x00177DB9
		// (set) Token: 0x0600A5AA RID: 42410 RVA: 0x00179BE4 File Offset: 0x00177DE4
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

		// Token: 0x17003338 RID: 13112
		// (get) Token: 0x0600A5AB RID: 42411 RVA: 0x00179BF4 File Offset: 0x00177DF4
		// (set) Token: 0x0600A5AC RID: 42412 RVA: 0x00179C2E File Offset: 0x00177E2E
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

		// Token: 0x04006402 RID: 25602
		[Nullable(2)]
		protected INpcLeisureInteractType FbInstance;

		// Token: 0x04006403 RID: 25603
		[Nullable(2)]
		protected INpcLeisureInteractType_SetValue PocoInterface;
	}
}
