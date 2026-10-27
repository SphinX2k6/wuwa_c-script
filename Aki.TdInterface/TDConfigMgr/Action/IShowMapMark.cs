using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E5C RID: 7772
	[NullableContext(1)]
	[Nullable(0)]
	public class IShowMapMark : ToggleMapMarkState
	{
		// Token: 0x0600A657 RID: 42583 RVA: 0x00178710 File Offset: 0x00176910
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

		// Token: 0x0600A658 RID: 42584 RVA: 0x00178748 File Offset: 0x00176948
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

		// Token: 0x0600A659 RID: 42585 RVA: 0x0017875B File Offset: 0x0017695B
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

		// Token: 0x0600A65A RID: 42586 RVA: 0x0017876E File Offset: 0x0017696E
		public new IShowMapMark_SetValue ToSetValue()
		{
			return new IShowMapMark_SetValue
			{
				Type = this.Type,
				MarkId = this.MarkId,
				IsFocusOnFirstShow = this.IsFocusOnFirstShow
			};
		}

		// Token: 0x170032F8 RID: 13048
		// (get) Token: 0x0600A65B RID: 42587 RVA: 0x00178799 File Offset: 0x00176999
		// (set) Token: 0x0600A65C RID: 42588 RVA: 0x001787C4 File Offset: 0x001769C4
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

		// Token: 0x170032F9 RID: 13049
		// (get) Token: 0x0600A65D RID: 42589 RVA: 0x001787D2 File Offset: 0x001769D2
		// (set) Token: 0x0600A65E RID: 42590 RVA: 0x001787FD File Offset: 0x001769FD
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

		// Token: 0x170032FA RID: 13050
		// (get) Token: 0x0600A65F RID: 42591 RVA: 0x0017880C File Offset: 0x00176A0C
		// (set) Token: 0x0600A660 RID: 42592 RVA: 0x00178846 File Offset: 0x00176A46
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

		// Token: 0x0400635B RID: 25435
		[Nullable(2)]
		protected new IShowMapMark FbInstance;

		// Token: 0x0400635C RID: 25436
		[Nullable(2)]
		protected new IShowMapMark_SetValue PocoInterface;
	}
}
