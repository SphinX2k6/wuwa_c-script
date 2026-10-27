using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000438 RID: 1080
	[NullableContext(1)]
	[Nullable(0)]
	public class IHookFetchMoveUniform : IHookFetchMoveModeBase
	{
		// Token: 0x060015CD RID: 5581 RVA: 0x00043EA0 File Offset: 0x000420A0
		private IHookFetchMoveUniform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHookFetchMoveUniform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHookFetchMoveUniform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHookFetchMoveUniform_SetValue());
			}
			return result;
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00043ED8 File Offset: 0x000420D8
		public static IHookFetchMoveUniform Create([Nullable(2)] IHookFetchMoveUniform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHookFetchMoveUniform
			{
				FbInstance = instance
			};
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00043EEB File Offset: 0x000420EB
		public static IHookFetchMoveUniform CreateFromSetValue([Nullable(2)] IHookFetchMoveUniform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHookFetchMoveUniform
			{
				PocoInterface = value
			};
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00043EFE File Offset: 0x000420FE
		public new IHookFetchMoveUniform_SetValue ToSetValue()
		{
			return new IHookFetchMoveUniform_SetValue
			{
				Type = this.Type,
				Speed = this.Speed
			};
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00043F1D File Offset: 0x0004211D
		// (set) Token: 0x060015D2 RID: 5586 RVA: 0x00043F48 File Offset: 0x00042148
		public override EHookFetchMoveMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHookFetchMoveMode.Uniform;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x00043F56 File Offset: 0x00042156
		// (set) Token: 0x060015D4 RID: 5588 RVA: 0x00043F85 File Offset: 0x00042185
		public virtual float Speed
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Speed;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Speed;
			}
			set
			{
				this.GetOrCreatePoco().Speed = value;
			}
		}

		// Token: 0x040010C5 RID: 4293
		[Nullable(2)]
		protected new IHookFetchMoveUniform FbInstance;

		// Token: 0x040010C6 RID: 4294
		[Nullable(2)]
		protected new IHookFetchMoveUniform_SetValue PocoInterface;
	}
}
