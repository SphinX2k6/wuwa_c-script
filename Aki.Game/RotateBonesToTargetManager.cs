using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200263C RID: 9788
[NullableContext(1)]
[Nullable(0)]
public class RotateBonesToTargetManager : IClear
{
	// Token: 0x1700265E RID: 9822
	// (get) Token: 0x060186EA RID: 100074 RVA: 0x00760C20 File Offset: 0x0075EE20
	// (set) Token: 0x060186EB RID: 100075 RVA: 0x00760C28 File Offset: 0x0075EE28
	public CharacterActorComponent ActorComp { get; private set; }

	// Token: 0x060186EC RID: 100076 RVA: 0x00760C34 File Offset: 0x0075EE34
	public RotateBonesToTargetManager(CharacterActorComponent actorComp)
	{
		this.ActorComp = actorComp;
		this.SkillComp = this.ActorComp.Entity.GetComponent<CharacterSkillComponent>();
		this.AiComp = this.ActorComp.Entity.GetComponent<CharacterAiComponent>();
	}

	// Token: 0x060186ED RID: 100077 RVA: 0x00760CDF File Offset: 0x0075EEDF
	public bool ClearObject()
	{
		this.Params.RemoveAllNodeWithoutHead();
		this.PauseParams.RemoveAllNodeWithoutHead();
		this.CurrentAlphaMap.Clear();
		this.PauseAlphaMap.Clear();
		this.DefaultTargetOffset.Reset();
		return true;
	}

	// Token: 0x060186EE RID: 100078 RVA: 0x00760D1C File Offset: 0x0075EF1C
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

	// Token: 0x060186EF RID: 100079 RVA: 0x00760D74 File Offset: 0x0075EF74
	public long SetBoneToTarget(TArray<string> boneNames, float timeLength)
	{
		long num = this.HandleCount + 1L;
		this.HandleCount = num;
		RotateBonesParams rotateBonesParams = new RotateBonesParams(num, boneNames);
		rotateBonesParams.Set(timeLength, 1f, this.CurrentAlphaMap);
		this.Params.AddTail(rotateBonesParams);
		return rotateBonesParams.Handle;
	}

	// Token: 0x060186F0 RID: 100080 RVA: 0x00760DC0 File Offset: 0x0075EFC0
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

	// Token: 0x060186F1 RID: 100081 RVA: 0x00760E20 File Offset: 0x0075F020
	public long PauseByNames(TArray<string> boneNames, float startLerpTime)
	{
		long num = this.HandleCount + 1L;
		this.HandleCount = num;
		RotateBonesParams rotateBonesParams = new RotateBonesParams(num, boneNames);
		rotateBonesParams.Set(startLerpTime, 1f, this.PauseAlphaMap);
		this.PauseParams.AddTail(rotateBonesParams);
		return rotateBonesParams.Handle;
	}

	// Token: 0x060186F2 RID: 100082 RVA: 0x00760E6C File Offset: 0x0075F06C
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

	// Token: 0x060186F3 RID: 100083 RVA: 0x00760ECC File Offset: 0x0075F0CC
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

	// Token: 0x060186F4 RID: 100084 RVA: 0x00761064 File Offset: 0x0075F264
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

	// Token: 0x060186F5 RID: 100085 RVA: 0x007610F8 File Offset: 0x0075F2F8
	public void GetTargetOffset(ref FVector outVector)
	{
		outVector.Set((float)this.CurrentTargetOffset.X, (float)this.CurrentTargetOffset.Y, (float)this.CurrentTargetOffset.Z);
	}

	// Token: 0x060186F6 RID: 100086 RVA: 0x00761124 File Offset: 0x0075F324
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

	// Token: 0x0400D2F0 RID: 54000
	private long HandleCount;

	// Token: 0x0400D2F1 RID: 54001
	[Nullable(2)]
	private readonly CharacterSkillComponent SkillComp;

	// Token: 0x0400D2F2 RID: 54002
	[Nullable(2)]
	private readonly CharacterAiComponent AiComp;

	// Token: 0x0400D2F3 RID: 54003
	private readonly DoublyLinkedList<RotateBonesParams> Params = new DoublyLinkedList<RotateBonesParams>(null);

	// Token: 0x0400D2F4 RID: 54004
	private readonly DoublyLinkedList<RotateBonesParams> PauseParams = new DoublyLinkedList<RotateBonesParams>(null);

	// Token: 0x0400D2F5 RID: 54005
	private readonly Dictionary<string, float> CurrentAlphaMap = new Dictionary<string, float>();

	// Token: 0x0400D2F6 RID: 54006
	private readonly Dictionary<string, float> PauseAlphaMap = new Dictionary<string, float>();

	// Token: 0x0400D2F7 RID: 54007
	private readonly Vector CurrentTargetOffset = Vector.Create();

	// Token: 0x0400D2F8 RID: 54008
	private bool InTargetLerp;

	// Token: 0x0400D2F9 RID: 54009
	private readonly Vector DefaultTargetOffset = Vector.Create();

	// Token: 0x0400D2FA RID: 54010
	private float LerpSpeed = 100f;

	// Token: 0x0400D2FB RID: 54011
	private float TargetUpdateThresholdSquared = 100f;

	// Token: 0x0400D2FC RID: 54012
	[StaticVariableRuleIgnore]
	private static readonly Vector TmpVector = Vector.Create();

	// Token: 0x0400D2FD RID: 54013
	private readonly Vector TmpTargetOffset = Vector.Create();

	// Token: 0x0400D2FE RID: 54014
	[StaticVariableRuleIgnore]
	private static readonly Transform TmpTransform = Transform.Create();
}
