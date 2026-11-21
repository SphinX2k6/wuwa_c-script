using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000491 RID: 1169
	public class IHookFetchMoveUniform : IHookFetchMoveModeBase
	{
		// Token: 0x06001767 RID: 5991 RVA: 0x00047BE8 File Offset: 0x00045DE8
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

		// Token: 0x06001768 RID: 5992 RVA: 0x00047C20 File Offset: 0x00045E20
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

		// Token: 0x06001769 RID: 5993 RVA: 0x00047C33 File Offset: 0x00045E33
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

		// Token: 0x0600176A RID: 5994 RVA: 0x00047C46 File Offset: 0x00045E46
		public new IHookFetchMoveUniform_SetValue ToSetValue()
		{
			return new IHookFetchMoveUniform_SetValue
			{
				Type = this.Type,
				Speed = this.Speed
			};
		}

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x00047C65 File Offset: 0x00045E65
		// (set) Token: 0x0600176C RID: 5996 RVA: 0x00047C90 File Offset: 0x00045E90
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

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x0600176D RID: 5997 RVA: 0x00047C9E File Offset: 0x00045E9E
		// (set) Token: 0x0600176E RID: 5998 RVA: 0x00047CCD File Offset: 0x00045ECD
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

		// Token: 0x040011E7 RID: 4583
		[Nullable(2)]
		protected new IHookFetchMoveUniform FbInstance;

		// Token: 0x040011E8 RID: 4584
		[Nullable(2)]
		protected new IHookFetchMoveUniform_SetValue PocoInterface;
	}
}
