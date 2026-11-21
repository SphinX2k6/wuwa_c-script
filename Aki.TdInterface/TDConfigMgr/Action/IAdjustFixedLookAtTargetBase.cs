using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001941 RID: 6465
	public class IAdjustFixedLookAtTargetBase
	{
		// Token: 0x060088BF RID: 35007 RVA: 0x00145490 File Offset: 0x00143690
		private IAdjustFixedLookAtTargetBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAdjustFixedLookAtTargetBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAdjustFixedLookAtTargetBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAdjustFixedLookAtTargetBase_SetValue());
			}
			return result;
		}

		// Token: 0x060088C0 RID: 35008 RVA: 0x001454C8 File Offset: 0x001436C8
		public static IAdjustFixedLookAtTargetBase Create([Nullable(2)] IAdjustFixedLookAtTargetBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAdjustFixedLookAtTargetBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x060088C1 RID: 35009 RVA: 0x001454DB File Offset: 0x001436DB
		public static IAdjustFixedLookAtTargetBase CreateFromSetValue([Nullable(2)] IAdjustFixedLookAtTargetBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAdjustFixedLookAtTargetBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x060088C2 RID: 35010 RVA: 0x001454EE File Offset: 0x001436EE
		public IAdjustFixedLookAtTargetBase_SetValue ToSetValue()
		{
			return new IAdjustFixedLookAtTargetBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C8A RID: 11402
		// (get) Token: 0x060088C3 RID: 35011 RVA: 0x00145501 File Offset: 0x00143701
		// (set) Token: 0x060088C4 RID: 35012 RVA: 0x0014552C File Offset: 0x0014372C
		public virtual EFixedLookAtTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EFixedLookAtTargetType.RangeEntity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040056A7 RID: 22183
		[Nullable(2)]
		protected IAdjustFixedLookAtTargetBase FbInstance;

		// Token: 0x040056A8 RID: 22184
		[Nullable(2)]
		protected IAdjustFixedLookAtTargetBase_SetValue PocoInterface;
	}
}
