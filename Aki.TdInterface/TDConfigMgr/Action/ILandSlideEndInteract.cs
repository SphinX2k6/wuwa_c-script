using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B6E RID: 7022
	[NullableContext(1)]
	[Nullable(0)]
	public class ILandSlideEndInteract : ILeisureInteractType
	{
		// Token: 0x06009665 RID: 38501 RVA: 0x0015B6F4 File Offset: 0x001598F4
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

		// Token: 0x06009666 RID: 38502 RVA: 0x0015B72C File Offset: 0x0015992C
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

		// Token: 0x06009667 RID: 38503 RVA: 0x0015B73F File Offset: 0x0015993F
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

		// Token: 0x06009668 RID: 38504 RVA: 0x0015B752 File Offset: 0x00159952
		public new ILandSlideEndInteract_SetValue ToSetValue()
		{
			return new ILandSlideEndInteract_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F64 RID: 12132
		// (get) Token: 0x06009669 RID: 38505 RVA: 0x0015B765 File Offset: 0x00159965
		// (set) Token: 0x0600966A RID: 38506 RVA: 0x0015B790 File Offset: 0x00159990
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

		// Token: 0x04005BF7 RID: 23543
		[Nullable(2)]
		protected new ILandSlideEndInteract FbInstance;

		// Token: 0x04005BF8 RID: 23544
		[Nullable(2)]
		protected new ILandSlideEndInteract_SetValue PocoInterface;
	}
}
