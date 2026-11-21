using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D1B RID: 7451
	public class ILandSlideEndInteract : ILeisureInteractType
	{
		// Token: 0x06009E47 RID: 40519 RVA: 0x0016C2A0 File Offset: 0x0016A4A0
		private ILandSlideEndInteract_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILandSlideEndInteract 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILandSlideEndInteract_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILandSlideEndInteract_SetValue());
			}
			return result;
		}

		// Token: 0x06009E48 RID: 40520 RVA: 0x0016C2D8 File Offset: 0x0016A4D8
		public static ILandSlideEndInteract Create([Nullable(2)] ILandSlideEndInteract instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILandSlideEndInteract
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009E49 RID: 40521 RVA: 0x0016C2EB File Offset: 0x0016A4EB
		public static ILandSlideEndInteract CreateFromSetValue([Nullable(2)] ILandSlideEndInteract_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILandSlideEndInteract
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009E4A RID: 40522 RVA: 0x0016C2FE File Offset: 0x0016A4FE
		public new ILandSlideEndInteract_SetValue ToSetValue()
		{
			return new ILandSlideEndInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003189 RID: 12681
		// (get) Token: 0x06009E4B RID: 40523 RVA: 0x0016C311 File Offset: 0x0016A511
		// (set) Token: 0x06009E4C RID: 40524 RVA: 0x0016C33C File Offset: 0x0016A53C
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

		// Token: 0x04006090 RID: 24720
		[Nullable(2)]
		protected new ILandSlideEndInteract FbInstance;

		// Token: 0x04006091 RID: 24721
		[Nullable(2)]
		protected new ILandSlideEndInteract_SetValue PocoInterface;
	}
}
