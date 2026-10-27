using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002DAB RID: 11691
[NullableContext(1)]
[Nullable(0)]
public class BulletDataExecution
{
	// Token: 0x1700215C RID: 8540
	// (get) Token: 0x06018938 RID: 100664 RVA: 0x00647B81 File Offset: 0x00645D81
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public List<LogicDataBase> GbDataList
	{
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		get
		{
			this.InitGbGroup();
			return this.GbDataListInternal;
		}
	}

	// Token: 0x1700215D RID: 8541
	// (get) Token: 0x06018939 RID: 100665 RVA: 0x00647B8F File Offset: 0x00645D8F
	public bool HasRebound
	{
		get
		{
			return this.HasReboundInternal;
		}
	}

	// Token: 0x1700215E RID: 8542
	// (get) Token: 0x0601893A RID: 100666 RVA: 0x00647B97 File Offset: 0x00645D97
	public bool HasCollision
	{
		get
		{
			return this.HasCollisionInternal;
		}
	}

	// Token: 0x0601893B RID: 100667 RVA: 0x00647BA0 File Offset: 0x00645DA0
	public void InitGbGroup()
	{
		if (this.GbGroupInternalInit)
		{
			return;
		}
		this.GbGroupInternalInit = true;
		FName assetPathName = this.Data.GB组.GetAssetPathName();
		if (assetPathName != FName.NAME_None)
		{
			this.ActionGroup = ResourceSystem.Instance.Load<UKuroBpDataAssetGroup>(assetPathName.ToString(), "js_undefined");
			UKuroBpDataAssetGroup actionGroup = this.ActionGroup;
			TArray<UKuroBpDataAsset> tarray = (actionGroup != null) ? actionGroup.Data : null;
			int num = (tarray != null) ? tarray.Num() : 0;
			if (num > 0)
			{
				this.GbDataListInternal = new List<LogicDataBase>();
				this.SupportCamp = new List<ECamp>();
				this.ReboundBitMask = 0;
				for (int i = 0; i < num; i++)
				{
					LogicDataBase logicDataBase = tarray.Get(i) as LogicDataBase;
					this.GbDataListInternal.Add(logicDataBase);
					if (!this.HasReboundInternal && logicDataBase is LogicDataRebound)
					{
						this.HasReboundInternal = true;
					}
					if (!this.HasCollisionInternal && logicDataBase is LogicDataBulletCollision)
					{
						this.HasCollisionInternal = true;
					}
				}
			}
		}
	}

	// Token: 0x1700215F RID: 8543
	// (get) Token: 0x0601893C RID: 100668 RVA: 0x00647C98 File Offset: 0x00645E98
	[Nullable(2)]
	public int[] TagIdOnVictimEnter
	{
		[NullableContext(2)]
		get
		{
			if (!this.TagIdOnVictimEnterInit)
			{
				this.TagIdOnVictimEnterInit = true;
				SReBulletDataExe data = this.Data;
				TArray<FGameplayTag> tarray = (data != null) ? data.受击对象进入添加Tag.GameplayTags : null;
				int num = (tarray != null) ? tarray.Num() : 0;
				if (num > 0)
				{
					this.TagIdOnVictimEnterInternal = new int[num];
					for (int i = 0; i < num; i++)
					{
						FGameplayTag tag = tarray.Get(i);
						this.TagIdOnVictimEnterInternal[i] = tag.TagId();
					}
				}
			}
			return this.TagIdOnVictimEnterInternal;
		}
	}

	// Token: 0x17002160 RID: 8544
	// (get) Token: 0x0601893D RID: 100669 RVA: 0x00647D14 File Offset: 0x00645F14
	public long[] GeIdApplyToVictim
	{
		get
		{
			if (this.GeIdApplyToVictimInternal == null)
			{
				TArray<long> 受击对象进入应用的GE的Id = this.Data.受击对象进入应用的GE的Id;
				this.GeIdApplyToVictimInternal = new long[受击对象进入应用的GE的Id.Count];
				受击对象进入应用的GE的Id.AsSpan<long>().CopyTo(this.GeIdApplyToVictimInternal);
			}
			return this.GeIdApplyToVictimInternal;
		}
	}

	// Token: 0x17002161 RID: 8545
	// (get) Token: 0x0601893E RID: 100670 RVA: 0x00647D65 File Offset: 0x00645F65
	public bool WaitEnterGeReply
	{
		get
		{
			if (this.WaitEnterGeReplyInternal == null)
			{
				this.WaitEnterGeReplyInternal = new bool?(this.Data.等待回包过程中不重复触发进入GE);
			}
			return this.WaitEnterGeReplyInternal.Value;
		}
	}

	// Token: 0x17002162 RID: 8546
	// (get) Token: 0x0601893F RID: 100671 RVA: 0x00647D95 File Offset: 0x00645F95
	public FGameplayTag SendGameplayEventTagToVictim
	{
		get
		{
			if (this.SendGameplayEventTagToVictimInternal == null)
			{
				this.SendGameplayEventTagToVictimInternal = new FGameplayTag?(this.Data.命中后对受击者发射GameplayEvent标签);
			}
			return this.SendGameplayEventTagToVictimInternal.Value;
		}
	}

	// Token: 0x17002163 RID: 8547
	// (get) Token: 0x06018940 RID: 100672 RVA: 0x00647DC8 File Offset: 0x00645FC8
	public long[] SendGeIdToVictim
	{
		get
		{
			if (this.SendGeIdToVictimInternal == null)
			{
				TArray<long> 命中后对受击者应用GE的Id = this.Data.命中后对受击者应用GE的Id;
				this.SendGeIdToVictimInternal = new long[命中后对受击者应用GE的Id.Num()];
				命中后对受击者应用GE的Id.AsSpan<long>().CopyTo(this.SendGeIdToVictimInternal);
			}
			return this.SendGeIdToVictimInternal;
		}
	}

	// Token: 0x17002164 RID: 8548
	// (get) Token: 0x06018941 RID: 100673 RVA: 0x00647E1C File Offset: 0x0064601C
	public long[] SendGeIdToRoleInGame
	{
		get
		{
			if (this.SendGeIdToRoleInGameInternal == null)
			{
				TArray<long> 命中后对在场上角色应用的GE的Id = this.Data.命中后对在场上角色应用的GE的Id;
				this.SendGeIdToRoleInGameInternal = new long[命中后对在场上角色应用的GE的Id.Num()];
				命中后对在场上角色应用的GE的Id.AsSpan<long>().CopyTo(this.SendGeIdToRoleInGameInternal);
			}
			return this.SendGeIdToRoleInGameInternal;
		}
	}

	// Token: 0x17002165 RID: 8549
	// (get) Token: 0x06018942 RID: 100674 RVA: 0x00647E6D File Offset: 0x0064606D
	public FGameplayTag SendGameplayEventTagToAttacker
	{
		get
		{
			if (this.SendGameplayEventTagToAttackerInternal == null)
			{
				this.SendGameplayEventTagToAttackerInternal = new FGameplayTag?(this.Data.命中后对攻击者发射GameplayEvent标签);
			}
			return this.SendGameplayEventTagToAttackerInternal.Value;
		}
	}

	// Token: 0x17002166 RID: 8550
	// (get) Token: 0x06018943 RID: 100675 RVA: 0x00647EA0 File Offset: 0x006460A0
	public long[] SendGeIdToAttacker
	{
		get
		{
			if (this.SendGeIdToAttackerInternal == null)
			{
				TArray<long> 命中后对攻击者应用GE的Id = this.Data.命中后对攻击者应用GE的Id;
				this.SendGeIdToAttackerInternal = new long[命中后对攻击者应用GE的Id.Num()];
				命中后对攻击者应用GE的Id.AsSpan<long>().CopyTo(this.SendGeIdToAttackerInternal);
			}
			return this.SendGeIdToAttackerInternal;
		}
	}

	// Token: 0x17002167 RID: 8551
	// (get) Token: 0x06018944 RID: 100676 RVA: 0x00647EF1 File Offset: 0x006460F1
	public FGameplayTag SendGameplayEventTagToAttackerOnEnd
	{
		get
		{
			if (this.SendGameplayEventTagToAttackerOnEndInternal == null)
			{
				this.SendGameplayEventTagToAttackerOnEndInternal = new FGameplayTag?(this.Data.结束时对攻击者发射GameplayEvent标签);
			}
			return this.SendGameplayEventTagToAttackerOnEndInternal.Value;
		}
	}

	// Token: 0x17002168 RID: 8552
	// (get) Token: 0x06018945 RID: 100677 RVA: 0x00647F24 File Offset: 0x00646124
	public long[] EnergyRecoverGeIds
	{
		get
		{
			if (this.EnergyRecoverGeIdsInternal == null)
			{
				TArray<long> 能量恢复类GE数组的Id = this.Data.能量恢复类GE数组的Id;
				this.EnergyRecoverGeIdsInternal = new long[能量恢复类GE数组的Id.Num()];
				能量恢复类GE数组的Id.AsSpan<long>().CopyTo(this.EnergyRecoverGeIdsInternal);
			}
			return this.EnergyRecoverGeIdsInternal;
		}
	}

	// Token: 0x17002169 RID: 8553
	// (get) Token: 0x06018946 RID: 100678 RVA: 0x00647F75 File Offset: 0x00646175
	public FGameplayTag SendGameplayEventTagToAttackerOnStart
	{
		get
		{
			if (this.SendGameplayEventTagToAttackerOnStartInternal == null)
			{
				this.SendGameplayEventTagToAttackerOnStartInternal = new FGameplayTag?(this.Data.生成时对攻击者发射GameplayEvent标签);
			}
			return this.SendGameplayEventTagToAttackerOnStartInternal.Value;
		}
	}

	// Token: 0x06018947 RID: 100679 RVA: 0x00647FA5 File Offset: 0x006461A5
	public BulletDataExecution(SReBulletDataExe data)
	{
		this.Data = data;
	}

	// Token: 0x06018948 RID: 100680 RVA: 0x00647FB4 File Offset: 0x006461B4
	public bool Preload()
	{
		this.InitGbGroup();
		return true;
	}

	// Token: 0x0400B652 RID: 46674
	[Nullable(2)]
	private readonly SReBulletDataExe Data;

	// Token: 0x0400B653 RID: 46675
	private bool GbGroupInternalInit;

	// Token: 0x0400B654 RID: 46676
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<LogicDataBase> GbDataListInternal;

	// Token: 0x0400B655 RID: 46677
	public bool MovementReplaced;

	// Token: 0x0400B656 RID: 46678
	public int ReboundBitMask;

	// Token: 0x0400B657 RID: 46679
	[Nullable(2)]
	public List<ECamp> SupportCamp;

	// Token: 0x0400B658 RID: 46680
	private bool HasReboundInternal;

	// Token: 0x0400B659 RID: 46681
	private bool HasCollisionInternal;

	// Token: 0x0400B65A RID: 46682
	[Nullable(2)]
	private UKuroBpDataAssetGroup ActionGroup;

	// Token: 0x0400B65B RID: 46683
	private bool TagIdOnVictimEnterInit;

	// Token: 0x0400B65C RID: 46684
	[Nullable(2)]
	private int[] TagIdOnVictimEnterInternal;

	// Token: 0x0400B65D RID: 46685
	[Nullable(2)]
	private long[] GeIdApplyToVictimInternal;

	// Token: 0x0400B65E RID: 46686
	private bool? WaitEnterGeReplyInternal;

	// Token: 0x0400B65F RID: 46687
	private FGameplayTag? SendGameplayEventTagToVictimInternal;

	// Token: 0x0400B660 RID: 46688
	[Nullable(2)]
	private long[] SendGeIdToVictimInternal;

	// Token: 0x0400B661 RID: 46689
	[Nullable(2)]
	private long[] SendGeIdToRoleInGameInternal;

	// Token: 0x0400B662 RID: 46690
	private FGameplayTag? SendGameplayEventTagToAttackerInternal;

	// Token: 0x0400B663 RID: 46691
	[Nullable(2)]
	private long[] SendGeIdToAttackerInternal;

	// Token: 0x0400B664 RID: 46692
	private FGameplayTag? SendGameplayEventTagToAttackerOnEndInternal;

	// Token: 0x0400B665 RID: 46693
	[Nullable(2)]
	private long[] EnergyRecoverGeIdsInternal;

	// Token: 0x0400B666 RID: 46694
	private FGameplayTag? SendGameplayEventTagToAttackerOnStartInternal;
}
