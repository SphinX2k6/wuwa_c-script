using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E4B RID: 7755
	public class IMusicBattleBtnEffect : ISkillBtnEffectBase
	{
		// Token: 0x0600A4E7 RID: 42215 RVA: 0x0017873C File Offset: 0x0017693C
		private IMusicBattleBtnEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMusicBattleBtnEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMusicBattleBtnEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMusicBattleBtnEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4E8 RID: 42216 RVA: 0x00178774 File Offset: 0x00176974
		public static IMusicBattleBtnEffect Create([Nullable(2)] IMusicBattleBtnEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMusicBattleBtnEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4E9 RID: 42217 RVA: 0x00178787 File Offset: 0x00176987
		public static IMusicBattleBtnEffect CreateFromSetValue([Nullable(2)] IMusicBattleBtnEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMusicBattleBtnEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4EA RID: 42218 RVA: 0x0017879A File Offset: 0x0017699A
		public new IMusicBattleBtnEffect_SetValue ToSetValue()
		{
			return new IMusicBattleBtnEffect_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003311 RID: 13073
		// (get) Token: 0x0600A4EB RID: 42219 RVA: 0x001787AD File Offset: 0x001769AD
		// (set) Token: 0x0600A4EC RID: 42220 RVA: 0x001787D8 File Offset: 0x001769D8
		public override ESkillBtnEffectType Type
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

		// Token: 0x040063AE RID: 25518
		[Nullable(2)]
		protected new IMusicBattleBtnEffect FbInstance;

		// Token: 0x040063AF RID: 25519
		[Nullable(2)]
		protected new IMusicBattleBtnEffect_SetValue PocoInterface;
	}
}
