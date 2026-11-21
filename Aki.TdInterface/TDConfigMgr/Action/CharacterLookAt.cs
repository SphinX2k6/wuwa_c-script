using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001647 RID: 5703
	public class CharacterLookAt : ActionParams
	{
		// Token: 0x060080B3 RID: 32947 RVA: 0x00132308 File Offset: 0x00130508
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

		// Token: 0x060080B4 RID: 32948 RVA: 0x00132340 File Offset: 0x00130540
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

		// Token: 0x060080B5 RID: 32949 RVA: 0x00132353 File Offset: 0x00130553
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

		// Token: 0x060080B6 RID: 32950 RVA: 0x00132366 File Offset: 0x00130566
		public CharacterLookAt_SetValue ToSetValue()
		{
			return new CharacterLookAt_SetValue
			{
				CharEntityId = this.CharEntityId,
				Target = this.Target
			};
		}

		// Token: 0x17002AAE RID: 10926
		// (get) Token: 0x060080B7 RID: 32951 RVA: 0x00132385 File Offset: 0x00130585
		// (set) Token: 0x060080B8 RID: 32952 RVA: 0x001323B0 File Offset: 0x001305B0
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

		// Token: 0x17002AAF RID: 10927
		// (get) Token: 0x060080B9 RID: 32953 RVA: 0x001323BE File Offset: 0x001305BE
		// (set) Token: 0x060080BA RID: 32954 RVA: 0x001323E5 File Offset: 0x001305E5
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

		// Token: 0x04004A46 RID: 19014
		[Nullable(2)]
		protected new CharacterLookAt FbInstance;

		// Token: 0x04004A47 RID: 19015
		[Nullable(2)]
		protected CharacterLookAt_SetValue PocoInterface;
	}
}
