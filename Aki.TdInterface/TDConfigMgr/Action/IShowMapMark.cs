using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002091 RID: 8337
	public class IShowMapMark : ToggleMapMarkState
	{
		// Token: 0x0600B10F RID: 45327 RVA: 0x0018E410 File Offset: 0x0018C610
		private IShowMapMark_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowMapMark 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowMapMark_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowMapMark_SetValue());
			}
			return result;
		}

		// Token: 0x0600B110 RID: 45328 RVA: 0x0018E448 File Offset: 0x0018C648
		public static IShowMapMark Create([Nullable(2)] IShowMapMark instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowMapMark
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B111 RID: 45329 RVA: 0x0018E45B File Offset: 0x0018C65B
		public static IShowMapMark CreateFromSetValue([Nullable(2)] IShowMapMark_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowMapMark
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B112 RID: 45330 RVA: 0x0018E46E File Offset: 0x0018C66E
		public new IShowMapMark_SetValue ToSetValue()
		{
			return new IShowMapMark_SetValue
			{
				Type = this.Type,
				MarkId = this.MarkId,
				IsFocusOnFirstShow = this.IsFocusOnFirstShow
			};
		}

		// Token: 0x170035BC RID: 13756
		// (get) Token: 0x0600B113 RID: 45331 RVA: 0x0018E499 File Offset: 0x0018C699
		// (set) Token: 0x0600B114 RID: 45332 RVA: 0x0018E4C4 File Offset: 0x0018C6C4
		public override EMapMarkState Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMapMarkState.Show;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170035BD RID: 13757
		// (get) Token: 0x0600B115 RID: 45333 RVA: 0x0018E4D2 File Offset: 0x0018C6D2
		// (set) Token: 0x0600B116 RID: 45334 RVA: 0x0018E4FD File Offset: 0x0018C6FD
		public virtual int MarkId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MarkId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MarkId;
			}
			set
			{
				this.GetOrCreatePoco().MarkId = value;
			}
		}

		// Token: 0x170035BE RID: 13758
		// (get) Token: 0x0600B117 RID: 45335 RVA: 0x0018E50C File Offset: 0x0018C70C
		// (set) Token: 0x0600B118 RID: 45336 RVA: 0x0018E546 File Offset: 0x0018C746
		public virtual bool? IsFocusOnFirstShow
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsFocusOnFirstShow;
				}
				IShowMapMark_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsFocusOnFirstShow;
			}
			set
			{
				this.GetOrCreatePoco().IsFocusOnFirstShow = value;
			}
		}

		// Token: 0x0400693F RID: 26943
		[Nullable(2)]
		protected new IShowMapMark FbInstance;

		// Token: 0x04006940 RID: 26944
		[Nullable(2)]
		protected new IShowMapMark_SetValue PocoInterface;
	}
}
