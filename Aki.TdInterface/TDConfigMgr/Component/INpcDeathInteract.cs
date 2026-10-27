using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200055A RID: 1370
	[NullableContext(2)]
	[Nullable(0)]
	public class INpcDeathInteract
	{
		// Token: 0x06001C06 RID: 7174 RVA: 0x00050840 File Offset: 0x0004EA40
		[NullableContext(1)]
		private INpcDeathInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INpcDeathInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INpcDeathInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INpcDeathInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00050878 File Offset: 0x0004EA78
		[NullableContext(1)]
		public static INpcDeathInteract Create([Nullable(2)] INpcDeathInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcDeathInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x0005088B File Offset: 0x0004EA8B
		[NullableContext(1)]
		public static INpcDeathInteract CreateFromSetValue([Nullable(2)] INpcDeathInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INpcDeathInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x0005089E File Offset: 0x0004EA9E
		[NullableContext(1)]
		public INpcDeathInteract_SetValue ToSetValue()
		{
			return new INpcDeathInteract_SetValue
			{
				Montage = this.Montage,
				MaterialDa = this.MaterialDa
			};
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06001C0A RID: 7178 RVA: 0x000508C0 File Offset: 0x0004EAC0
		// (set) Token: 0x06001C0B RID: 7179 RVA: 0x00050921 File Offset: 0x0004EB21
		public virtual IMontageId Montage
		{
			get
			{
				if (this._MontageInited)
				{
					return this._MontageCache;
				}
				this._MontageInited = true;
				if (this.FbInstance != null)
				{
					this._MontageCache = IMontageId.Create(this.FbInstance.Montage);
				}
				else
				{
					INpcDeathInteract_SetValue pocoInterface = this.PocoInterface;
					this._MontageCache = ((pocoInterface != null) ? pocoInterface.Montage : null);
				}
				return this._MontageCache;
			}
			set
			{
				this.GetOrCreatePoco().Montage = value;
				this._MontageInited = false;
			}
		}

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x06001C0C RID: 7180 RVA: 0x00050936 File Offset: 0x0004EB36
		// (set) Token: 0x06001C0D RID: 7181 RVA: 0x0005095D File Offset: 0x0004EB5D
		public virtual string MaterialDa
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MaterialDa;
				}
				INpcDeathInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MaterialDa;
			}
			set
			{
				this.GetOrCreatePoco().MaterialDa = value;
			}
		}

		// Token: 0x04001413 RID: 5139
		protected INpcDeathInteract FbInstance;

		// Token: 0x04001414 RID: 5140
		protected INpcDeathInteract_SetValue PocoInterface;

		// Token: 0x04001415 RID: 5141
		[Nullable(1)]
		private IMontageId _MontageCache;

		// Token: 0x04001416 RID: 5142
		private bool _MontageInited;
	}
}
