using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020030EE RID: 12526
[NullableContext(1)]
[Nullable(0)]
public class CharacterCatapultComponent : EntityComponent, IComponentDependency, IStaticVariableResetter
{
	// Token: 0x0601AD88 RID: 109960 RVA: 0x00740A75 File Offset: 0x0073EC75
	static CharacterCatapultComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterCatapultComponent.CreateStaticDefaultValue), new Action(CharacterCatapultComponent.ResetStaticDefaultValue));
	}

	// Token: 0x0601AD89 RID: 109961 RVA: 0x00740A94 File Offset: 0x0073EC94
	public static void CreateStaticDefaultValue()
	{
		CharacterCatapultComponent._tmpVector = Vector.Create();
	}

	// Token: 0x0601AD8A RID: 109962 RVA: 0x00740AA0 File Offset: 0x0073ECA0
	public static void ResetStaticDefaultValue()
	{
		CharacterCatapultComponent._tmpVector = null;
	}

	// Token: 0x170024F3 RID: 9459
	// (get) Token: 0x0601AD8B RID: 109963 RVA: 0x00740AA8 File Offset: 0x0073ECA8
	public static Type[] Dependencies
	{
		get
		{
			return new Type[]
			{
				typeof(CharacterActorComponent),
				typeof(CharacterMoveComponent)
			};
		}
	}

	// Token: 0x170024F4 RID: 9460
	// (get) Token: 0x0601AD8C RID: 109964 RVA: 0x00740ACA File Offset: 0x0073ECCA
	private static Vector TmpVector
	{
		get
		{
			return CharacterCatapultComponent._tmpVector;
		}
	}

	// Token: 0x0601AD8D RID: 109965 RVA: 0x00740AD4 File Offset: 0x0073ECD4
	private void OnCustomMoveCatapult(float deltaSeconds)
	{
		if ((double)deltaSeconds < 1E-08)
		{
			return;
		}
		this.CatapultUnit.GetOffset(this.RunTime, deltaSeconds, CharacterCatapultComponent.TmpVector);
		this.RunTime += deltaSeconds;
		this.MoveComp.MoveCharacter(CharacterCatapultComponent.TmpVector, deltaSeconds, "");
		if (this.LockRotator)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.SetInputRotator(this.CatapultUnit.GetEndRotator());
			}
		}
		if (this.RunTime > this.CatapultUnit.TimeLength)
		{
			CharacterActorComponent actorComp2 = this.ActorComp;
			if (actorComp2 != null)
			{
				actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Falling,
					Context = "[CharacterCatapultComponent.OnCustomMoveCatapult]"
				});
			}
			this.CatapultUnit.GetSpeed(this.RunTime, CharacterCatapultComponent.TmpVector);
			this.MoveComp.SetForceSpeed(CharacterCatapultComponent.TmpVector);
		}
	}

	// Token: 0x0601AD8E RID: 109966 RVA: 0x00740BB4 File Offset: 0x0073EDB4
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.CatapultUnit = new BigJumpUnit();
		return true;
	}

	// Token: 0x0601AD8F RID: 109967 RVA: 0x00740BC4 File Offset: 0x0073EDC4
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CustomMoveCatapult, new Action<float>(this.OnCustomMoveCatapult));
		return true;
	}

	// Token: 0x0601AD90 RID: 109968 RVA: 0x00740C13 File Offset: 0x0073EE13
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CustomMoveCatapult, new Action<float>(this.OnCustomMoveCatapult));
		return true;
	}

	// Token: 0x0601AD91 RID: 109969 RVA: 0x00740C38 File Offset: 0x0073EE38
	public void SetConfig(float time1, Vector startPoint, Vector middlePoint, Vector endPoint, string curvePath = "", float gravity2 = 1960f, [Nullable(2)] Rotator endRotator = null, [Nullable(2)] Vector gravityDirect = null, bool isSuperCatapult = false)
	{
		this.IsSuperCatapult = isSuperCatapult;
		this.LockRotator = (gravity2 > 0f);
		this.CatapultUnit.SetAll(time1, startPoint, middlePoint, endPoint, curvePath, gravity2, endRotator, gravityDirect, "", null);
	}

	// Token: 0x0601AD92 RID: 109970 RVA: 0x00740C7C File Offset: 0x0073EE7C
	public unsafe void StartCatapult()
	{
		this.CatapultUnit.SetStartPoint(this.ActorComp.ActorLocationProxy);
		this.CatapultUnit.Init();
		this.RunTime = 0f;
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Custom,
				CustomMode = 6,
				Context = "[CharacterCatapultComponent.StartCatapult]"
			});
		}
		CharacterAnimationComponent component = base.Entity.GetComponent<CharacterAnimationComponent>();
		if (component != null)
		{
			component.SetLocationAndRotatorWithModelBuffer(this.ActorComp.ActorLocationProxy.ToUeVector(false), this.CatapultUnit.GetEndRotator().ToUeRotator(), 200f, "Catapult Start", ESetRotationPriority.Anim, true);
		}
		if (this.IsSuperCatapult)
		{
			UAnimMontage skillMontageInstance = base.Entity.GetComponent<CharacterSkillComponent>().GetSkillMontageInstance(400107, 0);
			if (((component != null) ? component.MainAnimInstance : null) != null && skillMontageInstance != null && skillMontageInstance.IsValid())
			{
				float num = component.MainAnimInstance.Montage_GetPosition(skillMontageInstance);
				float newPlayRate = (skillMontageInstance.SequenceLength - num) / this.CatapultUnit.RisingTime;
				component.MainAnimInstance.Montage_SetPlayRate(skillMontageInstance, newPlayRate);
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Movement;
		ELogAuthor author = ELogAuthor.LCZ;
		string message = "StartCatapult";
		<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this.ActorComp.Actor.GetName());
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CatapultUnit", this.CatapultUnit);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("IsSuperCatapult", this.IsSuperCatapult);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
	}

	// Token: 0x0601AD93 RID: 109971 RVA: 0x00740E1C File Offset: 0x0073F01C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterCatapultComponent characterCatapultComponent = (CharacterCatapultComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (characterCatapultComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (characterCatapultComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("RunTime"))
		{
			this.RunTime = characterCatapultComponent.RunTime;
		}
		if (base.CanResetComponentProperty("CatapultUnit"))
		{
			if (characterCatapultComponent.CatapultUnit == null)
			{
				this.CatapultUnit = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BigJumpUnit>(this.CatapultUnit), "CatapultUnit"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("LockRotator"))
		{
			this.LockRotator = characterCatapultComponent.LockRotator;
		}
		if (base.CanResetComponentProperty("IsSuperCatapult"))
		{
			this.IsSuperCatapult = characterCatapultComponent.IsSuperCatapult;
		}
		return true;
	}

	// Token: 0x0400CFAB RID: 53163
	public const int MODEL_BUFFER_TIME_LENGTH = 200;

	// Token: 0x0400CFAC RID: 53164
	public const int SUPER_CATAPULT_SKILL_ID = 400107;

	// Token: 0x0400CFAD RID: 53165
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400CFAE RID: 53166
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400CFAF RID: 53167
	private float RunTime;

	// Token: 0x0400CFB0 RID: 53168
	[Nullable(2)]
	private BigJumpUnit CatapultUnit;

	// Token: 0x0400CFB1 RID: 53169
	public bool LockRotator;

	// Token: 0x0400CFB2 RID: 53170
	private bool IsSuperCatapult;

	// Token: 0x0400CFB3 RID: 53171
	[Nullable(2)]
	private static Vector _tmpVector;
}
