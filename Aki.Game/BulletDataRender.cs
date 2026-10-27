using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using UnrealEngine;

// Token: 0x02002DB1 RID: 11697
[NullableContext(1)]
[Nullable(0)]
public class BulletDataRender
{
	// Token: 0x17002199 RID: 8601
	// (get) Token: 0x06018987 RID: 100743 RVA: 0x00649149 File Offset: 0x00647349
	public FName VictimCameraShakeOnHit
	{
		get
		{
			if (this.VictimCameraShakeOnHitInternal == null)
			{
				this.VictimCameraShakeOnHitInternal = new FName?(this.Data.命中时受击者震屏.GetAssetPathName());
			}
			return this.VictimCameraShakeOnHitInternal.Value;
		}
	}

	// Token: 0x1700219A RID: 8602
	// (get) Token: 0x06018988 RID: 100744 RVA: 0x0064917E File Offset: 0x0064737E
	public FName AttackerCameraShakeOnHit
	{
		get
		{
			if (this.AttackerCameraShakeOnHitInternal == null)
			{
				this.AttackerCameraShakeOnHitInternal = new FName?(this.Data.命中时攻击者震屏.GetAssetPathName());
			}
			return this.AttackerCameraShakeOnHitInternal.Value;
		}
	}

	// Token: 0x1700219B RID: 8603
	// (get) Token: 0x06018989 RID: 100745 RVA: 0x006491B4 File Offset: 0x006473B4
	public Dictionary<EBulletHitEffect, FName> EffectOnHit
	{
		get
		{
			if (this.EffectOnHitInternal == null)
			{
				this.EffectOnHitInternal = new Dictionary<EBulletHitEffect, FName>();
				foreach (KeyValuePair<TEnumAsByte<EBulletHitEffect>, TSoftObjectPtr<UObject>> keyValuePair in this.Data.命中特效DA)
				{
					TEnumAsByte<EBulletHitEffect> tenumAsByte;
					TSoftObjectPtr<UObject> tsoftObjectPtr;
					keyValuePair.Deconstruct(out tenumAsByte, out tsoftObjectPtr);
					TEnumAsByte<EBulletHitEffect> value = tenumAsByte;
					TSoftObjectPtr<UObject> tsoftObjectPtr2 = tsoftObjectPtr;
					this.EffectOnHitInternal.Add(value, tsoftObjectPtr2.GetAssetPathName());
				}
			}
			return this.EffectOnHitInternal;
		}
	}

	// Token: 0x1700219C RID: 8604
	// (get) Token: 0x0601898A RID: 100746 RVA: 0x00649240 File Offset: 0x00647440
	public string AudioOnHit
	{
		get
		{
			if (this.AudioOnHitInternal == null)
			{
				this.AudioOnHitInternal = this.Data.命中音效;
			}
			return this.AudioOnHitInternal;
		}
	}

	// Token: 0x1700219D RID: 8605
	// (get) Token: 0x0601898B RID: 100747 RVA: 0x00649264 File Offset: 0x00647464
	public Dictionary<global::EBulletEffectOnHitType, BulletHitEffectConf> EffectOnHitConf
	{
		get
		{
			if (this.EffectOnHitConfInternal == null)
			{
				this.EffectOnHitConfInternal = new Dictionary<global::EBulletEffectOnHitType, BulletHitEffectConf>();
				TArray<SBulletEffectOnHitConf> 命中特效配置 = this.Data.命中特效配置;
				int num = 命中特效配置.Num();
				for (int i = 0; i < num; i++)
				{
					SBulletEffectOnHitConf sbulletEffectOnHitConf = 命中特效配置.Get(i);
					BulletHitEffectConf value = new BulletHitEffectConf(sbulletEffectOnHitConf);
					this.EffectOnHitConfInternal.Add((global::EBulletEffectOnHitType)sbulletEffectOnHitConf.类型, value);
				}
			}
			return this.EffectOnHitConfInternal;
		}
	}

	// Token: 0x1700219E RID: 8606
	// (get) Token: 0x0601898C RID: 100748 RVA: 0x006492D1 File Offset: 0x006474D1
	public FName EffectBullet
	{
		get
		{
			if (this.EffectBulletInternal == null)
			{
				this.EffectBulletInternal = new FName?(this.Data.子弹特效DA.GetAssetPathName());
			}
			return this.EffectBulletInternal.Value;
		}
	}

	// Token: 0x1700219F RID: 8607
	// (get) Token: 0x0601898D RID: 100749 RVA: 0x00649308 File Offset: 0x00647508
	public Dictionary<int, string> EffectBulletParams
	{
		get
		{
			if (this.EffectBulletParamsInternal == null)
			{
				this.EffectBulletParamsInternal = new Dictionary<int, string>();
				foreach (KeyValuePair<TEnumAsByte<AkiClient.Game.Aki.Core.Fight.EBulletEffectParam>, string> keyValuePair in this.Data.子弹特效DA参数)
				{
					TEnumAsByte<AkiClient.Game.Aki.Core.Fight.EBulletEffectParam> tenumAsByte;
					string text;
					keyValuePair.Deconstruct(out tenumAsByte, out text);
					TEnumAsByte<AkiClient.Game.Aki.Core.Fight.EBulletEffectParam> value = tenumAsByte;
					string value2 = text;
					this.EffectBulletParamsInternal.Add((int)value, value2);
				}
			}
			return this.EffectBulletParamsInternal;
		}
	}

	// Token: 0x170021A0 RID: 8608
	// (get) Token: 0x0601898E RID: 100750 RVA: 0x00649390 File Offset: 0x00647590
	public bool EffectStopInsteadDestroy
	{
		get
		{
			if (this.EffectStopInsteadDestroyInternal == null)
			{
				this.EffectStopInsteadDestroyInternal = new bool?(this.Data.子弹销毁调用子弹停止特效);
			}
			return this.EffectStopInsteadDestroyInternal.Value;
		}
	}

	// Token: 0x170021A1 RID: 8609
	// (get) Token: 0x0601898F RID: 100751 RVA: 0x006493C0 File Offset: 0x006475C0
	public bool HandOverParentEffect
	{
		get
		{
			if (this.HandOverParentEffectInternal == null)
			{
				this.HandOverParentEffectInternal = new bool?(this.Data.接手父子弹的特效);
			}
			return this.HandOverParentEffectInternal.Value;
		}
	}

	// Token: 0x170021A2 RID: 8610
	// (get) Token: 0x06018990 RID: 100752 RVA: 0x006493F0 File Offset: 0x006475F0
	public int CameraShakeCountMax
	{
		get
		{
			if (this.CameraShakeCountMaxInternal == null)
			{
				this.CameraShakeCountMaxInternal = new int?(this.Data.最大震动次数);
			}
			return this.CameraShakeCountMaxInternal.Value;
		}
	}

	// Token: 0x170021A3 RID: 8611
	// (get) Token: 0x06018991 RID: 100753 RVA: 0x00649420 File Offset: 0x00647620
	public Dictionary<EBulletSpecificEffect, FName> SpecialEffect
	{
		get
		{
			if (this.SpecialEffectInternal == null)
			{
				this.SpecialEffectInternal = new Dictionary<EBulletSpecificEffect, FName>();
				foreach (KeyValuePair<TEnumAsByte<EBulletSpecificEffect>, TSoftObjectPtr<UObject>> keyValuePair in this.Data.特殊特效DA)
				{
					TEnumAsByte<EBulletSpecificEffect> tenumAsByte;
					TSoftObjectPtr<UObject> tsoftObjectPtr;
					keyValuePair.Deconstruct(out tenumAsByte, out tsoftObjectPtr);
					TEnumAsByte<EBulletSpecificEffect> value = tenumAsByte;
					TSoftObjectPtr<UObject> tsoftObjectPtr2 = tsoftObjectPtr;
					this.SpecialEffectInternal.Add(value, tsoftObjectPtr2.GetAssetPathName());
				}
			}
			return this.SpecialEffectInternal;
		}
	}

	// Token: 0x170021A4 RID: 8612
	// (get) Token: 0x06018992 RID: 100754 RVA: 0x006494AC File Offset: 0x006476AC
	public FName AttackerCameraShakeOnStart
	{
		get
		{
			if (this.AttackerCameraShakeOnStartInternal == null)
			{
				this.AttackerCameraShakeOnStartInternal = new FName?(this.Data.生成时攻击者震屏.GetAssetPathName());
			}
			return this.AttackerCameraShakeOnStartInternal.Value;
		}
	}

	// Token: 0x170021A5 RID: 8613
	// (get) Token: 0x06018993 RID: 100755 RVA: 0x006494E1 File Offset: 0x006476E1
	public bool CameraShakeToSummonOwner
	{
		get
		{
			if (this.CameraShakeToSummonOwnerInternal == null)
			{
				this.CameraShakeToSummonOwnerInternal = new bool?(this.Data.震屏关联到召唤兽主人);
			}
			return this.CameraShakeToSummonOwnerInternal.Value;
		}
	}

	// Token: 0x170021A6 RID: 8614
	// (get) Token: 0x06018994 RID: 100756 RVA: 0x00649511 File Offset: 0x00647711
	public FName AttackerCameraShakeOnHitWeakPoint
	{
		get
		{
			if (this.AttackerCameraShakeOnHitWeakPointInternal == null)
			{
				this.AttackerCameraShakeOnHitWeakPointInternal = new FName?(this.Data.命中弱点时攻击者震屏.GetAssetPathName());
			}
			return this.AttackerCameraShakeOnHitWeakPointInternal.Value;
		}
	}

	// Token: 0x170021A7 RID: 8615
	// (get) Token: 0x06018995 RID: 100757 RVA: 0x00649546 File Offset: 0x00647746
	public FName OnHitMaterialEffect
	{
		get
		{
			if (this.OnHitMaterialEffectInternal == null)
			{
				this.OnHitMaterialEffectInternal = new FName?(this.Data.受击闪白.GetAssetPathName());
			}
			return this.OnHitMaterialEffectInternal.Value;
		}
	}

	// Token: 0x06018996 RID: 100758 RVA: 0x0064957B File Offset: 0x0064777B
	public BulletDataRender(SReBulletDataPerformance data)
	{
		this.Data = data;
	}

	// Token: 0x06018997 RID: 100759 RVA: 0x0064958C File Offset: 0x0064778C
	public bool Preload()
	{
		FName effectBullet = this.EffectBullet;
		bool handOverParentEffect = this.HandOverParentEffect;
		int cameraShakeCountMax = this.CameraShakeCountMax;
		Dictionary<EBulletSpecificEffect, FName> specialEffect = this.SpecialEffect;
		FName attackerCameraShakeOnStart = this.AttackerCameraShakeOnStart;
		string audioOnHit = this.AudioOnHit;
		Dictionary<int, string> effectBulletParams = this.EffectBulletParams;
		Dictionary<EBulletHitEffect, FName> effectOnHit = this.EffectOnHit;
		Dictionary<global::EBulletEffectOnHitType, BulletHitEffectConf> effectOnHitConf = this.EffectOnHitConf;
		FName victimCameraShakeOnHit = this.VictimCameraShakeOnHit;
		FName attackerCameraShakeOnHit = this.AttackerCameraShakeOnHit;
		bool effectStopInsteadDestroy = this.EffectStopInsteadDestroy;
		bool cameraShakeToSummonOwner = this.CameraShakeToSummonOwner;
		FName attackerCameraShakeOnHitWeakPoint = this.AttackerCameraShakeOnHitWeakPoint;
		FName onHitMaterialEffect = this.OnHitMaterialEffect;
		return true;
	}

	// Token: 0x0400B6B3 RID: 46771
	[Nullable(2)]
	private readonly SReBulletDataPerformance Data;

	// Token: 0x0400B6B4 RID: 46772
	private FName? VictimCameraShakeOnHitInternal;

	// Token: 0x0400B6B5 RID: 46773
	private FName? AttackerCameraShakeOnHitInternal;

	// Token: 0x0400B6B6 RID: 46774
	[Nullable(2)]
	private Dictionary<EBulletHitEffect, FName> EffectOnHitInternal;

	// Token: 0x0400B6B7 RID: 46775
	[Nullable(2)]
	private string AudioOnHitInternal;

	// Token: 0x0400B6B8 RID: 46776
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<global::EBulletEffectOnHitType, BulletHitEffectConf> EffectOnHitConfInternal;

	// Token: 0x0400B6B9 RID: 46777
	private FName? EffectBulletInternal;

	// Token: 0x0400B6BA RID: 46778
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private Dictionary<int, string> EffectBulletParamsInternal;

	// Token: 0x0400B6BB RID: 46779
	private bool? EffectStopInsteadDestroyInternal;

	// Token: 0x0400B6BC RID: 46780
	private bool? HandOverParentEffectInternal;

	// Token: 0x0400B6BD RID: 46781
	private int? CameraShakeCountMaxInternal;

	// Token: 0x0400B6BE RID: 46782
	[Nullable(2)]
	private Dictionary<EBulletSpecificEffect, FName> SpecialEffectInternal;

	// Token: 0x0400B6BF RID: 46783
	private FName? AttackerCameraShakeOnStartInternal;

	// Token: 0x0400B6C0 RID: 46784
	private bool? CameraShakeToSummonOwnerInternal;

	// Token: 0x0400B6C1 RID: 46785
	private FName? AttackerCameraShakeOnHitWeakPointInternal;

	// Token: 0x0400B6C2 RID: 46786
	private FName? OnHitMaterialEffectInternal;
}
