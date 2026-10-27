using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B70 RID: 7024
	[NullableContext(1)]
	[Nullable(0)]
	public class ILandSlideInteract : ILeisureInteractType
	{
		// Token: 0x0600966D RID: 38509 RVA: 0x0015B7B0 File Offset: 0x001599B0
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

		// Token: 0x0600966E RID: 38510 RVA: 0x0015B7E8 File Offset: 0x001599E8
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

		// Token: 0x0600966F RID: 38511 RVA: 0x0015B7FB File Offset: 0x001599FB
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

		// Token: 0x06009670 RID: 38512 RVA: 0x0015B80E File Offset: 0x00159A0E
		public new ILandSlideInteract_SetValue ToSetValue()
		{
			return new ILandSlideInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F65 RID: 12133
		// (get) Token: 0x06009671 RID: 38513 RVA: 0x0015B821 File Offset: 0x00159A21
		// (set) Token: 0x06009672 RID: 38514 RVA: 0x0015B84C File Offset: 0x00159A4C
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

		// Token: 0x04005BFA RID: 23546
		[Nullable(2)]
		protected new ILandSlideInteract FbInstance;

		// Token: 0x04005BFB RID: 23547
		[Nullable(2)]
		protected new ILandSlideInteract_SetValue PocoInterface;
	}
}
