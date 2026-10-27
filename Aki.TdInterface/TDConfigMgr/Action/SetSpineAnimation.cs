using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021DA RID: 8666
	[NullableContext(1)]
	[Nullable(0)]
	public class SetSpineAnimation : ActionParams
	{
		// Token: 0x0600BE6F RID: 48751 RVA: 0x001B6728 File Offset: 0x001B4928
		private SetSpineAnimation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("SetSpineAnimation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			SetSpineAnimation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new SetSpineAnimation_SetValue());
			}
			return result;
		}

		// Token: 0x0600BE70 RID: 48752 RVA: 0x001B6760 File Offset: 0x001B4960
		public static SetSpineAnimation Create([Nullable(2)] SetSpineAnimation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new SetSpineAnimation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BE71 RID: 48753 RVA: 0x001B6773 File Offset: 0x001B4973
		public static SetSpineAnimation CreateFromSetValue([Nullable(2)] SetSpineAnimation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new SetSpineAnimation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BE72 RID: 48754 RVA: 0x001B6786 File Offset: 0x001B4986
		public SetSpineAnimation_SetValue ToSetValue()
		{
			return new SetSpineAnimation_SetValue
			{
				Config = this.Config
			};
		}

		// Token: 0x170039D2 RID: 14802
		// (get) Token: 0x0600BE73 RID: 48755 RVA: 0x001B679C File Offset: 0x001B499C
		// (set) Token: 0x0600BE74 RID: 48756 RVA: 0x001B67FD File Offset: 0x001B49FD
		public virtual IPlaySpineAnimation Config
		{
			get
			{
				if (this._ConfigInited)
				{
					return this._ConfigCache;
				}
				this._ConfigInited = true;
				if (this.FbInstance != null)
				{
					this._ConfigCache = IPlaySpineAnimation.Create(this.FbInstance.Config);
				}
				else
				{
					SetSpineAnimation_SetValue pocoInterface = this.PocoInterface;
					this._ConfigCache = ((pocoInterface != null) ? pocoInterface.Config : null);
				}
				return this._ConfigCache;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
				this._ConfigInited = false;
			}
		}

		// Token: 0x040071A6 RID: 29094
		[Nullable(2)]
		protected new SetSpineAnimation FbInstance;

		// Token: 0x040071A7 RID: 29095
		[Nullable(2)]
		protected SetSpineAnimation_SetValue PocoInterface;

		// Token: 0x040071A8 RID: 29096
		private IPlaySpineAnimation _ConfigCache;

		// Token: 0x040071A9 RID: 29097
		private bool _ConfigInited;
	}
}
