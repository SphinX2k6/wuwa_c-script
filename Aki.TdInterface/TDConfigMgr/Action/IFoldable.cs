using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C4C RID: 7244
	public class IFoldable
	{
		// Token: 0x06009A14 RID: 39444 RVA: 0x00164CF8 File Offset: 0x00162EF8
		private IFoldable_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFoldable 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFoldable_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFoldable_SetValue());
			}
			return result;
		}

		// Token: 0x06009A15 RID: 39445 RVA: 0x00164D30 File Offset: 0x00162F30
		public static IFoldable Create([Nullable(2)] IFoldable instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFoldable
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009A16 RID: 39446 RVA: 0x00164D43 File Offset: 0x00162F43
		public static IFoldable CreateFromSetValue([Nullable(2)] IFoldable_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFoldable
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009A17 RID: 39447 RVA: 0x00164D56 File Offset: 0x00162F56
		public IFoldable_SetValue ToSetValue()
		{
			return new IFoldable_SetValue
			{
				_folded = this._Folded
			};
		}

		// Token: 0x170030A5 RID: 12453
		// (get) Token: 0x06009A18 RID: 39448 RVA: 0x00164D6C File Offset: 0x00162F6C
		// (set) Token: 0x06009A19 RID: 39449 RVA: 0x00164DA6 File Offset: 0x00162FA6
		public virtual bool? _Folded
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance._Folded;
				}
				IFoldable_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface._folded;
			}
			set
			{
				this.GetOrCreatePoco()._folded = value;
			}
		}

		// Token: 0x04005EAC RID: 24236
		[Nullable(2)]
		protected IFoldable FbInstance;

		// Token: 0x04005EAD RID: 24237
		[Nullable(2)]
		protected IFoldable_SetValue PocoInterface;
	}
}
