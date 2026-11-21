using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002229 RID: 8745
	public class ITransitionPopupArtTextTypeBase
	{
		// Token: 0x0600BEA8 RID: 48808 RVA: 0x001B85F8 File Offset: 0x001B67F8
		private ITransitionPopupArtTextTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITransitionPopupArtTextTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITransitionPopupArtTextTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITransitionPopupArtTextTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600BEA9 RID: 48809 RVA: 0x001B8630 File Offset: 0x001B6830
		public static ITransitionPopupArtTextTypeBase Create([Nullable(2)] ITransitionPopupArtTextTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupArtTextTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BEAA RID: 48810 RVA: 0x001B8643 File Offset: 0x001B6843
		public static ITransitionPopupArtTextTypeBase CreateFromSetValue([Nullable(2)] ITransitionPopupArtTextTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITransitionPopupArtTextTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BEAB RID: 48811 RVA: 0x001B8656 File Offset: 0x001B6856
		public ITransitionPopupArtTextTypeBase_SetValue ToSetValue()
		{
			return new ITransitionPopupArtTextTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A26 RID: 14886
		// (get) Token: 0x0600BEAC RID: 48812 RVA: 0x001B8669 File Offset: 0x001B6869
		// (set) Token: 0x0600BEAD RID: 48813 RVA: 0x001B8694 File Offset: 0x001B6894
		public virtual ETransitionPopupArtTextType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETransitionPopupArtTextType.YuanCheng;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04007259 RID: 29273
		[Nullable(2)]
		protected ITransitionPopupArtTextTypeBase FbInstance;

		// Token: 0x0400725A RID: 29274
		[Nullable(2)]
		protected ITransitionPopupArtTextTypeBase_SetValue PocoInterface;
	}
}
