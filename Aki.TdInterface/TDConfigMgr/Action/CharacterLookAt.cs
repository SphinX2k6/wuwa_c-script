using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020014EE RID: 5358
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterLookAt : ActionParams
	{
		// Token: 0x060079E6 RID: 31206 RVA: 0x001236D0 File Offset: 0x001218D0
		private CharacterLookAt_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("CharacterLookAt 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			CharacterLookAt_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new CharacterLookAt_SetValue());
			}
			return result;
		}

		// Token: 0x060079E7 RID: 31207 RVA: 0x00123708 File Offset: 0x00121908
		public static CharacterLookAt Create([Nullable(2)] CharacterLookAt instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new CharacterLookAt
			{
				FbInstance = instance
			};
		}

		// Token: 0x060079E8 RID: 31208 RVA: 0x0012371B File Offset: 0x0012191B
		public static CharacterLookAt CreateFromSetValue([Nullable(2)] CharacterLookAt_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new CharacterLookAt
			{
				PocoInterface = value
			};
		}

		// Token: 0x060079E9 RID: 31209 RVA: 0x0012372E File Offset: 0x0012192E
		public CharacterLookAt_SetValue ToSetValue()
		{
			return new CharacterLookAt_SetValue
			{
				CharEntityId = this.CharEntityId,
				Target = this.Target
			};
		}

		// Token: 0x170028C4 RID: 10436
		// (get) Token: 0x060079EA RID: 31210 RVA: 0x0012374D File Offset: 0x0012194D
		// (set) Token: 0x060079EB RID: 31211 RVA: 0x00123778 File Offset: 0x00121978
		public virtual int CharEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CharEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.CharEntityId;
			}
			set
			{
				this.GetOrCreatePoco().CharEntityId = value;
			}
		}

		// Token: 0x170028C5 RID: 10437
		// (get) Token: 0x060079EC RID: 31212 RVA: 0x00123786 File Offset: 0x00121986
		// (set) Token: 0x060079ED RID: 31213 RVA: 0x001237AD File Offset: 0x001219AD
		public virtual ICharacterLookAtData Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				CharacterLookAt_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x040046AB RID: 18091
		[Nullable(2)]
		protected new CharacterLookAt FbInstance;

		// Token: 0x040046AC RID: 18092
		[Nullable(2)]
		protected CharacterLookAt_SetValue PocoInterface;
	}
}
