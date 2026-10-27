using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E7D RID: 7805
	[NullableContext(1)]
	[Nullable(0)]
	public class ISkillBtnEffectBase
	{
		// Token: 0x0600A708 RID: 42760 RVA: 0x00179C24 File Offset: 0x00177E24
		private ISkillBtnEffectBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISkillBtnEffectBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISkillBtnEffectBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISkillBtnEffectBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600A709 RID: 42761 RVA: 0x00179C5C File Offset: 0x00177E5C
		public static ISkillBtnEffectBase Create([Nullable(2)] ISkillBtnEffectBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkillBtnEffectBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A70A RID: 42762 RVA: 0x00179C6F File Offset: 0x00177E6F
		public static ISkillBtnEffectBase CreateFromSetValue([Nullable(2)] ISkillBtnEffectBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISkillBtnEffectBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A70B RID: 42763 RVA: 0x00179C82 File Offset: 0x00177E82
		public ISkillBtnEffectBase_SetValue ToSetValue()
		{
			return new ISkillBtnEffectBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003320 RID: 13088
		// (get) Token: 0x0600A70C RID: 42764 RVA: 0x00179C95 File Offset: 0x00177E95
		// (set) Token: 0x0600A70D RID: 42765 RVA: 0x00179CC0 File Offset: 0x00177EC0
		public virtual ESkillBtnEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESkillBtnEffectType.MusicBattleBtnEffect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040063B5 RID: 25525
		[Nullable(2)]
		protected ISkillBtnEffectBase FbInstance;

		// Token: 0x040063B6 RID: 25526
		[Nullable(2)]
		protected ISkillBtnEffectBase_SetValue PocoInterface;
	}
}
