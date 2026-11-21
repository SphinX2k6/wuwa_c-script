using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D1D RID: 7453
	public class ILandSlideInteract : ILeisureInteractType
	{
		// Token: 0x06009E4F RID: 40527 RVA: 0x0016C35C File Offset: 0x0016A55C
		private ILandSlideInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILandSlideInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILandSlideInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILandSlideInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06009E50 RID: 40528 RVA: 0x0016C394 File Offset: 0x0016A594
		public static ILandSlideInteract Create([Nullable(2)] ILandSlideInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILandSlideInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E51 RID: 40529 RVA: 0x0016C3A7 File Offset: 0x0016A5A7
		public static ILandSlideInteract CreateFromSetValue([Nullable(2)] ILandSlideInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILandSlideInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E52 RID: 40530 RVA: 0x0016C3BA File Offset: 0x0016A5BA
		public new ILandSlideInteract_SetValue ToSetValue()
		{
			return new ILandSlideInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700318A RID: 12682
		// (get) Token: 0x06009E53 RID: 40531 RVA: 0x0016C3CD File Offset: 0x0016A5CD
		// (set) Token: 0x06009E54 RID: 40532 RVA: 0x0016C3F8 File Offset: 0x0016A5F8
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006093 RID: 24723
		[Nullable(2)]
		protected new ILandSlideInteract FbInstance;

		// Token: 0x04006094 RID: 24724
		[Nullable(2)]
		protected new ILandSlideInteract_SetValue PocoInterface;
	}
}
