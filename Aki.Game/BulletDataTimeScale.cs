using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;

// Token: 0x02002DB4 RID: 11700
[NullableContext(1)]
[Nullable(0)]
public class BulletDataTimeScale
{
	// Token: 0x170021AD RID: 8621
	// (get) Token: 0x060189A0 RID: 100768 RVA: 0x00649715 File Offset: 0x00647915
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

	// Token: 0x170021AE RID: 8622
	// (get) Token: 0x060189A1 RID: 100769 RVA: 0x00649745 File Offset: 0x00647945
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

	// Token: 0x170021AF RID: 8623
	// (get) Token: 0x060189A2 RID: 100770 RVA: 0x0064976C File Offset: 0x0064796C
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

	// Token: 0x170021B0 RID: 8624
	// (get) Token: 0x060189A3 RID: 100771 RVA: 0x0064979C File Offset: 0x0064799C
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

	// Token: 0x170021B1 RID: 8625
	// (get) Token: 0x060189A4 RID: 100772 RVA: 0x006497C3 File Offset: 0x006479C3
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

	// Token: 0x170021B2 RID: 8626
	// (get) Token: 0x060189A5 RID: 100773 RVA: 0x006497F3 File Offset: 0x006479F3
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

	// Token: 0x170021B3 RID: 8627
	// (get) Token: 0x060189A6 RID: 100774 RVA: 0x00649823 File Offset: 0x00647A23
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

	// Token: 0x170021B4 RID: 8628
	// (get) Token: 0x060189A7 RID: 100775 RVA: 0x00649854 File Offset: 0x00647A54
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

	// Token: 0x170021B5 RID: 8629
	// (get) Token: 0x060189A8 RID: 100776 RVA: 0x0064989F File Offset: 0x00647A9F
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

	// Token: 0x170021B6 RID: 8630
	// (get) Token: 0x060189A9 RID: 100777 RVA: 0x006498C6 File Offset: 0x00647AC6
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

	// Token: 0x170021B7 RID: 8631
	// (get) Token: 0x060189AA RID: 100778 RVA: 0x006498ED File Offset: 0x00647AED
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

	// Token: 0x060189AB RID: 100779 RVA: 0x0064991D File Offset: 0x00647B1D
	public BulletDataTimeScale(SReBulletDataTime data)
	{
		this.Data = data;
	}

	// Token: 0x0400B6CB RID: 46795
	private readonly SReBulletDataTime Data;

	// Token: 0x0400B6CC RID: 46796
	private bool? AreaTimeScaleInternal;

	// Token: 0x0400B6CD RID: 46797
	[Nullable(2)]
	private STimeScale TimeScaleOnHitInternal;

	// Token: 0x0400B6CE RID: 46798
	private bool? ForceBulletTimeScaleInAreaInternal;

	// Token: 0x0400B6CF RID: 46799
	[Nullable(2)]
	private STimeScale TimeScaleOnAttackInternal;

	// Token: 0x0400B6D0 RID: 46800
	private bool? TimeScaleOnAttackIgnoreAttackerInternal;

	// Token: 0x0400B6D1 RID: 46801
	private float? TimeScaleEffectImmuneInternal;

	// Token: 0x0400B6D2 RID: 46802
	private bool? TimeScaleWithAttackerInternal;

	// Token: 0x0400B6D3 RID: 46803
	private bool CharacterCustomKeyTimeScaleInit;

	// Token: 0x0400B6D4 RID: 46804
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private string[] CharacterCustomKeyTimeScaleInternal;

	// Token: 0x0400B6D5 RID: 46805
	[Nullable(2)]
	private STimeScale AttackerTimeScaleOnHitWeakPointInternal;

	// Token: 0x0400B6D6 RID: 46806
	[Nullable(2)]
	private STimeScale VictimTimeScaleOnHitWeakPointInternal;

	// Token: 0x0400B6D7 RID: 46807
	private bool? RemoveTimeScaleOnDestroyInternal;
}
