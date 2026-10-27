using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200187E RID: 6270
	[NullableContext(1)]
	[Nullable(0)]
	public class ICharacterGroupNew
	{
		// Token: 0x060086B7 RID: 34487 RVA: 0x0013FD60 File Offset: 0x0013DF60
		private ICharacterGroupNew_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICharacterGroupNew 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICharacterGroupNew_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICharacterGroupNew_SetValue());
			}
			return result;
		}

		// Token: 0x060086B8 RID: 34488 RVA: 0x0013FD98 File Offset: 0x0013DF98
		public static ICharacterGroupNew Create([Nullable(2)] ICharacterGroupNew instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICharacterGroupNew
			{
				FbInstance = instance
			};
		}

		// Token: 0x060086B9 RID: 34489 RVA: 0x0013FDAB File Offset: 0x0013DFAB
		public static ICharacterGroupNew CreateFromSetValue([Nullable(2)] ICharacterGroupNew_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICharacterGroupNew
			{
				PocoInterface = value
			};
		}

		// Token: 0x060086BA RID: 34490 RVA: 0x0013FDBE File Offset: 0x0013DFBE
		public ICharacterGroupNew_SetValue ToSetValue()
		{
			return new ICharacterGroupNew_SetValue
			{
				CharacterId = this.CharacterId,
				IsAiCharacter = this.IsAiCharacter
			};
		}

		// Token: 0x17002BF3 RID: 11251
		// (get) Token: 0x060086BB RID: 34491 RVA: 0x0013FDDD File Offset: 0x0013DFDD
		// (set) Token: 0x060086BC RID: 34492 RVA: 0x0013FE08 File Offset: 0x0013E008
		public virtual int CharacterId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CharacterId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CharacterId;
			}
			set
			{
				this.GetOrCreatePoco().CharacterId = value;
			}
		}

		// Token: 0x17002BF4 RID: 11252
		// (get) Token: 0x060086BD RID: 34493 RVA: 0x0013FE16 File Offset: 0x0013E016
		// (set) Token: 0x060086BE RID: 34494 RVA: 0x0013FE41 File Offset: 0x0013E041
		public virtual bool IsAiCharacter
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsAiCharacter;
				}
				return this.PocoInterface != null && this.PocoInterface.IsAiCharacter;
			}
			set
			{
				this.GetOrCreatePoco().IsAiCharacter = value;
			}
		}

		// Token: 0x040054EA RID: 21738
		[Nullable(2)]
		protected ICharacterGroupNew FbInstance;

		// Token: 0x040054EB RID: 21739
		[Nullable(2)]
		protected ICharacterGroupNew_SetValue PocoInterface;
	}
}
