using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C54 RID: 7252
	[NullableContext(1)]
	[Nullable(0)]
	public class IMusicBattleBtnEffect : ISkillBtnEffectBase
	{
		// Token: 0x06009B8F RID: 39823 RVA: 0x001653FC File Offset: 0x001635FC
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

		// Token: 0x06009B90 RID: 39824 RVA: 0x00165434 File Offset: 0x00163634
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

		// Token: 0x06009B91 RID: 39825 RVA: 0x00165447 File Offset: 0x00163647
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

		// Token: 0x06009B92 RID: 39826 RVA: 0x0016545A File Offset: 0x0016365A
		public new IMusicBattleBtnEffect_SetValue ToSetValue()
		{
			return new IMusicBattleBtnEffect_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170030A0 RID: 12448
		// (get) Token: 0x06009B93 RID: 39827 RVA: 0x0016546D File Offset: 0x0016366D
		// (set) Token: 0x06009B94 RID: 39828 RVA: 0x00165498 File Offset: 0x00163698
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

		// Token: 0x04005E77 RID: 24183
		[Nullable(2)]
		protected new IMusicBattleBtnEffect FbInstance;

		// Token: 0x04005E78 RID: 24184
		[Nullable(2)]
		protected new IMusicBattleBtnEffect_SetValue PocoInterface;
	}
}
