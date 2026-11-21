using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;

// Token: 0x0200230E RID: 8974
[NullableContext(1)]
[Nullable(0)]
public class BulletDataTimeScale
{
	// Token: 0x17002209 RID: 8713
	// (get) Token: 0x06016248 RID: 90696 RVA: 0x0066F51D File Offset: 0x0066D71D
	public bool AreaTimeScale
	{
		get
		{
			if (this.AreaTimeScaleInternal == null)
			{
				this.AreaTimeScaleInternal = new bool?(this.Data.区域受击者时间膨胀);
			}
			return this.AreaTimeScaleInternal.Value;
		}
	}

	// Token: 0x1700220A RID: 8714
	// (get) Token: 0x06016249 RID: 90697 RVA: 0x0066F54D File Offset: 0x0066D74D
	public STimeScale TimeScaleOnHit
	{
		get
		{
			if (this.TimeScaleOnHitInternal == null)
			{
				this.TimeScaleOnHitInternal = this.Data.受击顿帧;
			}
			return this.TimeScaleOnHitInternal;
		}
	}

	// Token: 0x1700220B RID: 8715
	// (get) Token: 0x0601624A RID: 90698 RVA: 0x0066F574 File Offset: 0x0066D774
	public bool ForceBulletTimeScaleInArea
	{
		get
		{
			if (this.ForceBulletTimeScaleInAreaInternal == null)
			{
				this.ForceBulletTimeScaleInAreaInternal = new bool?(this.Data.强制影响区域内子弹);
			}
			return this.ForceBulletTimeScaleInAreaInternal.Value;
		}
	}

	// Token: 0x1700220C RID: 8716
	// (get) Token: 0x0601624B RID: 90699 RVA: 0x0066F5A4 File Offset: 0x0066D7A4
	public STimeScale TimeScaleOnAttack
	{
		get
		{
			if (this.TimeScaleOnAttackInternal == null)
			{
				this.TimeScaleOnAttackInternal = this.Data.攻击顿帧;
			}
			return this.TimeScaleOnAttackInternal;
		}
	}

	// Token: 0x1700220D RID: 8717
	// (get) Token: 0x0601624C RID: 90700 RVA: 0x0066F5CB File Offset: 0x0066D7CB
	public bool TimeScaleOnAttackIgnoreAttacker
	{
		get
		{
			if (this.TimeScaleOnAttackIgnoreAttackerInternal == null)
			{
				this.TimeScaleOnAttackIgnoreAttackerInternal = new bool?(this.Data.攻击顿帧忽略攻击者);
			}
			return this.TimeScaleOnAttackIgnoreAttackerInternal.Value;
		}
	}

	// Token: 0x1700220E RID: 8718
	// (get) Token: 0x0601624D RID: 90701 RVA: 0x0066F5FB File Offset: 0x0066D7FB
	public float TimeScaleEffectImmune
	{
		get
		{
			if (this.TimeScaleEffectImmuneInternal == null)
			{
				this.TimeScaleEffectImmuneInternal = new float?(this.Data.时间膨胀失效);
			}
			return this.TimeScaleEffectImmuneInternal.Value;
		}
	}

	// Token: 0x1700220F RID: 8719
	// (get) Token: 0x0601624E RID: 90702 RVA: 0x0066F62B File Offset: 0x0066D82B
	public bool TimeScaleWithAttacker
	{
		get
		{
			if (this.TimeScaleWithAttackerInternal == null)
			{
				this.TimeScaleWithAttackerInternal = new bool?(this.Data.是否跟随攻击者顿帧);
			}
			return this.TimeScaleWithAttackerInternal.Value;
		}
	}

	// Token: 0x17002210 RID: 8720
	// (get) Token: 0x0601624F RID: 90703 RVA: 0x0066F65C File Offset: 0x0066D85C
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public string[] CharacterCustomKeyTimeScale
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			if (!this.CharacterCustomKeyTimeScaleInit)
			{
				this.CharacterCustomKeyTimeScaleInit = true;
				string 自定义连携顿帧单位key = this.Data.自定义连携顿帧单位key;
				if (!string.IsNullOrEmpty(自定义连携顿帧单位key))
				{
					string[] array = 自定义连携顿帧单位key.Split(',', StringSplitOptions.None);
					if (array.Length != 0)
					{
						this.CharacterCustomKeyTimeScaleInternal = array;
					}
				}
			}
			return this.CharacterCustomKeyTimeScaleInternal;
		}
	}

	// Token: 0x17002211 RID: 8721
	// (get) Token: 0x06016250 RID: 90704 RVA: 0x0066F6A7 File Offset: 0x0066D8A7
	public STimeScale AttackerTimeScaleOnHitWeakPoint
	{
		get
		{
			if (this.AttackerTimeScaleOnHitWeakPointInternal == null)
			{
				this.AttackerTimeScaleOnHitWeakPointInternal = this.Data.命中弱点攻击者顿帧;
			}
			return this.AttackerTimeScaleOnHitWeakPointInternal;
		}
	}

	// Token: 0x17002212 RID: 8722
	// (get) Token: 0x06016251 RID: 90705 RVA: 0x0066F6CE File Offset: 0x0066D8CE
	public STimeScale VictimTimeScaleOnHitWeakPoint
	{
		get
		{
			if (this.VictimTimeScaleOnHitWeakPointInternal == null)
			{
				this.VictimTimeScaleOnHitWeakPointInternal = this.Data.命中弱点受击者顿帧;
			}
			return this.VictimTimeScaleOnHitWeakPointInternal;
		}
	}

	// Token: 0x17002213 RID: 8723
	// (get) Token: 0x06016252 RID: 90706 RVA: 0x0066F6F5 File Offset: 0x0066D8F5
	public bool RemoveHitTimeScaleOnDestroy
	{
		get
		{
			if (this.RemoveTimeScaleOnDestroyInternal == null)
			{
				this.RemoveTimeScaleOnDestroyInternal = new bool?(this.Data.子弹销毁时移除受击顿帧);
			}
			return this.RemoveTimeScaleOnDestroyInternal.Value;
		}
	}

	// Token: 0x06016253 RID: 90707 RVA: 0x0066F725 File Offset: 0x0066D925
	public BulletDataTimeScale(SReBulletDataTime data)
	{
		this.Data = data;
	}

	// Token: 0x0400BA45 RID: 47685
	private readonly SReBulletDataTime Data;

	// Token: 0x0400BA46 RID: 47686
	private bool? AreaTimeScaleInternal;

	// Token: 0x0400BA47 RID: 47687
	[Nullable(2)]
	private STimeScale TimeScaleOnHitInternal;

	// Token: 0x0400BA48 RID: 47688
	private bool? ForceBulletTimeScaleInAreaInternal;

	// Token: 0x0400BA49 RID: 47689
	[Nullable(2)]
	private STimeScale TimeScaleOnAttackInternal;

	// Token: 0x0400BA4A RID: 47690
	private bool? TimeScaleOnAttackIgnoreAttackerInternal;

	// Token: 0x0400BA4B RID: 47691
	private float? TimeScaleEffectImmuneInternal;

	// Token: 0x0400BA4C RID: 47692
	private bool? TimeScaleWithAttackerInternal;

	// Token: 0x0400BA4D RID: 47693
	private bool CharacterCustomKeyTimeScaleInit;

	// Token: 0x0400BA4E RID: 47694
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private string[] CharacterCustomKeyTimeScaleInternal;

	// Token: 0x0400BA4F RID: 47695
	[Nullable(2)]
	private STimeScale AttackerTimeScaleOnHitWeakPointInternal;

	// Token: 0x0400BA50 RID: 47696
	[Nullable(2)]
	private STimeScale VictimTimeScaleOnHitWeakPointInternal;

	// Token: 0x0400BA51 RID: 47697
	private bool? RemoveTimeScaleOnDestroyInternal;
}
