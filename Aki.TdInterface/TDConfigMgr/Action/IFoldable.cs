using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AB3 RID: 6835
	[NullableContext(1)]
	[Nullable(0)]
	public class IFoldable
	{
		// Token: 0x06009294 RID: 37524 RVA: 0x00154B0C File Offset: 0x00152D0C
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

		// Token: 0x06009295 RID: 37525 RVA: 0x00154B44 File Offset: 0x00152D44
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

		// Token: 0x06009296 RID: 37526 RVA: 0x00154B57 File Offset: 0x00152D57
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

		// Token: 0x06009297 RID: 37527 RVA: 0x00154B6A File Offset: 0x00152D6A
		public IFoldable_SetValue ToSetValue()
		{
			return new IFoldable_SetValue
			{
				_folded = this._Folded
			};
		}

		// Token: 0x17002E93 RID: 11923
		// (get) Token: 0x06009298 RID: 37528 RVA: 0x00154B80 File Offset: 0x00152D80
		// (set) Token: 0x06009299 RID: 37529 RVA: 0x00154BBA File Offset: 0x00152DBA
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

		// Token: 0x04005A3C RID: 23100
		[Nullable(2)]
		protected IFoldable FbInstance;

		// Token: 0x04005A3D RID: 23101
		[Nullable(2)]
		protected IFoldable_SetValue PocoInterface;
	}
}
