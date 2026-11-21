using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200231E RID: 8990
	public class LeisureInteract : ActionParams
	{
		// Token: 0x0600C3D0 RID: 50128 RVA: 0x001C1980 File Offset: 0x001BFB80
		private LeisureInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("LeisureInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			LeisureInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new LeisureInteract_SetValue());
			}
			return result;
		}

		// Token: 0x0600C3D1 RID: 50129 RVA: 0x001C19B8 File Offset: 0x001BFBB8
		public static LeisureInteract Create([Nullable(2)] LeisureInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new LeisureInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C3D2 RID: 50130 RVA: 0x001C19CB File Offset: 0x001BFBCB
		public static LeisureInteract CreateFromSetValue([Nullable(2)] LeisureInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new LeisureInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C3D3 RID: 50131 RVA: 0x001C19DE File Offset: 0x001BFBDE
		public LeisureInteract_SetValue ToSetValue()
		{
			return new LeisureInteract_SetValue
			{
				Option = this.Option,
				SceneEntity = this.SceneEntity
			};
		}

		// Token: 0x17003B4B RID: 15179
		// (get) Token: 0x0600C3D4 RID: 50132 RVA: 0x001C19FD File Offset: 0x001BFBFD
		// (set) Token: 0x0600C3D5 RID: 50133 RVA: 0x001C1A24 File Offset: 0x001BFC24
		public virtual ILeisureInteractType Option
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Option;
				}
				LeisureInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Option;
			}
			set
			{
				this.GetOrCreatePoco().Option = value;
			}
		}

		// Token: 0x17003B4C RID: 15180
		// (get) Token: 0x0600C3D6 RID: 50134 RVA: 0x001C1A34 File Offset: 0x001BFC34
		// (set) Token: 0x0600C3D7 RID: 50135 RVA: 0x001C1A6E File Offset: 0x001BFC6E
		public virtual int? SceneEntity
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SceneEntity;
				}
				LeisureInteract_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SceneEntity;
			}
			set
			{
				this.GetOrCreatePoco().SceneEntity = value;
			}
		}

		// Token: 0x040074AC RID: 29868
		[Nullable(2)]
		protected new LeisureInteract FbInstance;

		// Token: 0x040074AD RID: 29869
		[Nullable(2)]
		protected LeisureInteract_SetValue PocoInterface;
	}
}
