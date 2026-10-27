using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020030E4 RID: 12516
[NullableContext(1)]
[Nullable(0)]
public class RotateBonesToTargetManager : IClear
{
	// Token: 0x170024D4 RID: 9428
	// (get) Token: 0x0601ACCE RID: 109774 RVA: 0x0073B1E4 File Offset: 0x007393E4
	// (set) Token: 0x0601ACCF RID: 109775 RVA: 0x0073B1EC File Offset: 0x007393EC
	public CharacterActorComponent ActorComp { get; private set; }

	// Token: 0x0601ACD0 RID: 109776 RVA: 0x0073B1F8 File Offset: 0x007393F8
	public RotateBonesToTargetManager(CharacterActorComponent actorComp)
	{
		this.ActorComp = actorComp;
		this.SkillComp = this.ActorComp.Entity.GetComponent<CharacterSkillComponent>();
		this.AiComp = this.ActorComp.Entity.GetComponent<CharacterAiComponent>();
	}

	// Token: 0x0601ACD1 RID: 109777 RVA: 0x0073B2A3 File Offset: 0x007394A3
	public bool ClearObject()
	{
		this.Params.RemoveAllNodeWithoutHead();
		this.PauseParams.RemoveAllNodeWithoutHead();
		this.CurrentAlphaMap.Clear();
		this.PauseAlphaMap.Clear();
		this.DefaultTargetOffset.Reset();
		return true;
	}

	// Token: 0x0601ACD2 RID: 109778 RVA: 0x0073B2E0 File Offset: 0x007394E0
	public void SetDefaultTarget(FVector defaultTargetOffset, float lerpSpeed, float targetUpdateThreshold)
	{
		this.DefaultTargetOffset.FromUeVector(defaultTargetOffset);
		this.LerpSpeed = lerpSpeed;
		this.TargetUpdateThresholdSquared = targetUpdateThreshold * targetUpdateThreshold;
		if (this.Params.GetHeadNode() == this.Params.GetTailNode())
		{
			this.GetCurrentTargetOffset(this.CurrentTargetOffset);
			this.InTargetLerp = false;
		}
	}

	// Token: 0x0601ACD3 RID: 109779 RVA: 0x0073B338 File Offset: 0x00739538
	public long SetBoneToTarget(TArray<string> boneNames, float timeLength)
	{
		long num = this.HandleCount + 1L;
		this.HandleCount = num;
		RotateBonesParams rotateBonesParams = new RotateBonesParams(num, boneNames);
		rotateBonesParams.Set(timeLength, 1f, this.CurrentAlphaMap);
		this.Params.AddTail(rotateBonesParams);
		return rotateBonesParams.Handle;
	}

	// Token: 0x0601ACD4 RID: 109780 RVA: 0x0073B384 File Offset: 0x00739584
	public void StopBoneToTarget(long handle, float timeLength)
	{
		DoublyLinkedNode<RotateBonesParams> headNode = this.Params.GetHeadNode();
		for (DoublyLinkedNode<RotateBonesParams> doublyLinkedNode = (headNode != null) ? headNode.Next : null; doublyLinkedNode != null; doublyLinkedNode = doublyLinkedNode.Next)
		{
			RotateBonesParams element = doublyLinkedNode.Element;
			if (element != null && element.Handle == handle)
			{
				doublyLinkedNode.Element.Set(timeLength, 0f, this.CurrentAlphaMap);
				return;
			}
		}
	}

	// Token: 0x0601ACD5 RID: 109781 RVA: 0x0073B3E4 File Offset: 0x007395E4
	public long PauseByNames(TArray<string> boneNames, float startLerpTime)
	{
		long num = this.HandleCount + 1L;
		this.HandleCount = num;
		RotateBonesParams rotateBonesParams = new RotateBonesParams(num, boneNames);
		rotateBonesParams.Set(startLerpTime, 1f, this.PauseAlphaMap);
		this.PauseParams.AddTail(rotateBonesParams);
		return rotateBonesParams.Handle;
	}

	// Token: 0x0601ACD6 RID: 109782 RVA: 0x0073B430 File Offset: 0x00739630
	public void ClearPause(long handle, float endLerpTime)
	{
		DoublyLinkedNode<RotateBonesParams> headNode = this.PauseParams.GetHeadNode();
		for (DoublyLinkedNode<RotateBonesParams> doublyLinkedNode = (headNode != null) ? headNode.Next : null; doublyLinkedNode != null; doublyLinkedNode = doublyLinkedNode.Next)
		{
			RotateBonesParams element = doublyLinkedNode.Element;
			if (element != null && element.Handle == handle)
			{
				doublyLinkedNode.Element.Set(endLerpTime, 0f, this.PauseAlphaMap);
				return;
			}
		}
	}

	// Token: 0x0601ACD7 RID: 109783 RVA: 0x0073B490 File Offset: 0x00739690
	public void Update(float deltaSeconds)
	{
		DoublyLinkedNode<RotateBonesParams> doublyLinkedNode = this.Params.GetTailNode();
		DoublyLinkedNode<RotateBonesParams> headNode = this.Params.GetHeadNode();
		this.CurrentAlphaMap.Clear();
		if (doublyLinkedNode == headNode)
		{
			return;
		}
		while (doublyLinkedNode != null && doublyLinkedNode != headNode)
		{
			RotateBonesParams element = doublyLinkedNode.Element;
			if (element != null)
			{
				element.GetAndUpdate(deltaSeconds, this.CurrentAlphaMap);
			}
			RotateBonesParams element2 = doublyLinkedNode.Element;
			if (element2 != null && element2.IsEnd())
			{
				this.Params.RemoveThis(doublyLinkedNode);
			}
			doublyLinkedNode = doublyLinkedNode.Pre;
		}
		DoublyLinkedNode<RotateBonesParams> doublyLinkedNode2 = this.PauseParams.GetTailNode();
		DoublyLinkedNode<RotateBonesParams> headNode2 = this.PauseParams.GetHeadNode();
		this.PauseAlphaMap.Clear();
		while (doublyLinkedNode2 != null && doublyLinkedNode2 != headNode2)
		{
			RotateBonesParams element3 = doublyLinkedNode2.Element;
			if (element3 != null)
			{
				element3.GetAndUpdate(deltaSeconds, this.PauseAlphaMap);
			}
			RotateBonesParams element4 = doublyLinkedNode2.Element;
			if (element4 != null && element4.IsEnd())
			{
				this.PauseParams.RemoveThis(doublyLinkedNode2);
			}
			doublyLinkedNode2 = doublyLinkedNode2.Pre;
		}
		this.GetCurrentTargetOffset(this.TmpTargetOffset);
		double num = Vector.DistSquared(this.TmpTargetOffset, this.CurrentTargetOffset);
		if (this.InTargetLerp)
		{
			if (num <= 100.0)
			{
				this.InTargetLerp = false;
			}
		}
		else if (num > (double)this.TargetUpdateThresholdSquared)
		{
			this.InTargetLerp = true;
		}
		if (this.InTargetLerp)
		{
			float num2 = (float)Math.Sqrt(num);
			float num3 = deltaSeconds * this.LerpSpeed;
			if (num3 > num2)
			{
				this.CurrentTargetOffset.DeepCopy(this.TmpTargetOffset);
				return;
			}
			RotateBonesToTargetManager.TmpVector.DeepCopy(this.CurrentTargetOffset);
			Vector.Lerp(RotateBonesToTargetManager.TmpVector, this.TmpTargetOffset, (double)(num3 / num2), this.CurrentTargetOffset);
		}
	}

	// Token: 0x0601ACD8 RID: 109784 RVA: 0x0073B628 File Offset: 0x00739828
	public void GetActivateBones(TMap<string, float> outMap)
	{
		outMap.Empty(0);
		foreach (KeyValuePair<string, float> keyValuePair in this.CurrentAlphaMap)
		{
			float num = keyValuePair.Value;
			float num2;
			if (this.PauseAlphaMap.TryGetValue(keyValuePair.Key, out num2))
			{
				num *= 1f - num2;
			}
			if (num != 0f)
			{
				outMap.Add(keyValuePair.Key, num);
			}
		}
	}

	// Token: 0x0601ACD9 RID: 109785 RVA: 0x0073B6BC File Offset: 0x007398BC
	public void GetTargetOffset(ref FVector outVector)
	{
		outVector.Set((float)this.CurrentTargetOffset.X, (float)this.CurrentTargetOffset.Y, (float)this.CurrentTargetOffset.Z);
	}

	// Token: 0x0601ACDA RID: 109786 RVA: 0x0073B6E8 File Offset: 0x007398E8
	private void GetCurrentTargetOffset(Vector @out)
	{
		bool flag = false;
		if (this.SkillComp != null && this.SkillComp.SkillTarget != null)
		{
			Vector tmpVector = RotateBonesToTargetManager.TmpVector;
			FTransformDouble ftransformDouble = this.SkillComp.GetTargetTransform();
			FVectorDouble location = ftransformDouble.GetLocation();
			tmpVector.FromUeVector(location);
			flag = true;
		}
		if (!flag && this.AiComp != null)
		{
			EntityHandle currentTarget = this.AiComp.AiController.AiHateList.GetCurrentTarget();
			BaseActorComponent baseActorComponent;
			if (currentTarget == null)
			{
				baseActorComponent = null;
			}
			else
			{
				WorldEntity entity = currentTarget.Entity;
				baseActorComponent = ((entity != null) ? entity.GetComponent<BaseActorComponent>() : null);
			}
			BaseActorComponent baseActorComponent2 = baseActorComponent;
			if (baseActorComponent2 != null)
			{
				RotateBonesToTargetManager.TmpVector.DeepCopy(baseActorComponent2.ActorLocationProxy);
				flag = true;
			}
		}
		if (flag)
		{
			Transform tmpTransform = RotateBonesToTargetManager.TmpTransform;
			FTransformDouble ftransformDouble = this.ActorComp.Actor.Mesh.D_K2_GetComponentToWorld();
			tmpTransform.FromUeTransform(ftransformDouble);
			RotateBonesToTargetManager.TmpTransform.InverseTransformPosition(RotateBonesToTargetManager.TmpVector, @out);
			return;
		}
		@out.DeepCopy(this.DefaultTargetOffset);
	}

	// Token: 0x0400CF00 RID: 52992
	private long HandleCount;

	// Token: 0x0400CF01 RID: 52993
	[Nullable(2)]
	private readonly CharacterSkillComponent SkillComp;

	// Token: 0x0400CF02 RID: 52994
	[Nullable(2)]
	private readonly CharacterAiComponent AiComp;

	// Token: 0x0400CF03 RID: 52995
	private readonly DoublyLinkedList<RotateBonesParams> Params = new DoublyLinkedList<RotateBonesParams>(null);

	// Token: 0x0400CF04 RID: 52996
	private readonly DoublyLinkedList<RotateBonesParams> PauseParams = new DoublyLinkedList<RotateBonesParams>(null);

	// Token: 0x0400CF05 RID: 52997
	private readonly Dictionary<string, float> CurrentAlphaMap = new Dictionary<string, float>();

	// Token: 0x0400CF06 RID: 52998
	private readonly Dictionary<string, float> PauseAlphaMap = new Dictionary<string, float>();

	// Token: 0x0400CF07 RID: 52999
	private readonly Vector CurrentTargetOffset = Vector.Create();

	// Token: 0x0400CF08 RID: 53000
	private bool InTargetLerp;

	// Token: 0x0400CF09 RID: 53001
	private readonly Vector DefaultTargetOffset = Vector.Create();

	// Token: 0x0400CF0A RID: 53002
	private float LerpSpeed = 100f;

	// Token: 0x0400CF0B RID: 53003
	private float TargetUpdateThresholdSquared = 100f;

	// Token: 0x0400CF0C RID: 53004
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400CF0D RID: 53005
	private readonly Vector TmpTargetOffset = Vector.Create();

	// Token: 0x0400CF0E RID: 53006
	[StaticVariableRuleIgnore]
	private static readonly Transform TmpTransform = Transform.Create();
}
