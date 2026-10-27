using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004D0 RID: 1232
	[NullableContext(1)]
	[Nullable(0)]
	public class ILookAtTargetBase
	{
		// Token: 0x06001904 RID: 6404 RVA: 0x0004A5CC File Offset: 0x000487CC
		private ILookAtTargetBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILookAtTargetBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILookAtTargetBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILookAtTargetBase_SetValue());
			}
			return result;
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x0004A604 File Offset: 0x00048804
		public static ILookAtTargetBase Create([Nullable(2)] ILookAtTargetBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILookAtTargetBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x0004A617 File Offset: 0x00048817
		public static ILookAtTargetBase CreateFromSetValue([Nullable(2)] ILookAtTargetBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILookAtTargetBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x0004A62A File Offset: 0x0004882A
		public ILookAtTargetBase_SetValue ToSetValue()
		{
			return new ILookAtTargetBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170006A9 RID: 1705
		// (get) Token: 0x06001908 RID: 6408 RVA: 0x0004A63D File Offset: 0x0004883D
		// (set) Token: 0x06001909 RID: 6409 RVA: 0x0004A668 File Offset: 0x00048868
		public virtual ELookAtTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELookAtTargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001273 RID: 4723
		[Nullable(2)]
		protected ILookAtTargetBase FbInstance;

		// Token: 0x04001274 RID: 4724
		[Nullable(2)]
		protected ILookAtTargetBase_SetValue PocoInterface;
	}
}
