using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D4C RID: 7500
	[NullableContext(1)]
	[Nullable(0)]
	public class IPreloadPhantomCharacterForSkill : IPreloadCharacterType
	{
		// Token: 0x0600A0E7 RID: 41191 RVA: 0x0016ED6C File Offset: 0x0016CF6C
		private IPreloadPhantomCharacterForSkill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPreloadPhantomCharacterForSkill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPreloadPhantomCharacterForSkill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPreloadPhantomCharacterForSkill_SetValue());
			}
			return result;
		}

		// Token: 0x0600A0E8 RID: 41192 RVA: 0x0016EDA4 File Offset: 0x0016CFA4
		public static IPreloadPhantomCharacterForSkill Create([Nullable(2)] IPreloadPhantomCharacterForSkill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadPhantomCharacterForSkill
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A0E9 RID: 41193 RVA: 0x0016EDB7 File Offset: 0x0016CFB7
		public static IPreloadPhantomCharacterForSkill CreateFromSetValue([Nullable(2)] IPreloadPhantomCharacterForSkill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPreloadPhantomCharacterForSkill
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A0EA RID: 41194 RVA: 0x0016EDCA File Offset: 0x0016CFCA
		public new IPreloadPhantomCharacterForSkill_SetValue ToSetValue()
		{
			return new IPreloadPhantomCharacterForSkill_SetValue
			{
				Type = this.Type,
				Id = this.Id
			};
		}

		// Token: 0x170031D8 RID: 12760
		// (get) Token: 0x0600A0EB RID: 41195 RVA: 0x0016EDE9 File Offset: 0x0016CFE9
		// (set) Token: 0x0600A0EC RID: 41196 RVA: 0x0016EE14 File Offset: 0x0016D014
		public override EPreloadObjectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPreloadObjectType.PreloadTrialCharacterForSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x0600A0ED RID: 41197 RVA: 0x0016EE22 File Offset: 0x0016D022
		// (set) Token: 0x0600A0EE RID: 41198 RVA: 0x0016EE4D File Offset: 0x0016D04D
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x040060E9 RID: 24809
		[Nullable(2)]
		protected new IPreloadPhantomCharacterForSkill FbInstance;

		// Token: 0x040060EA RID: 24810
		[Nullable(2)]
		protected new IPreloadPhantomCharacterForSkill_SetValue PocoInterface;
	}
}
