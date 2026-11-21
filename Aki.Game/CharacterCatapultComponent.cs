using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x02002646 RID: 9798
[NullableContext(1)]
[Nullable(0)]
public class CharacterCatapultComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x060187A7 RID: 100263 RVA: 0x00766461 File Offset: 0x00764661
	static CharacterCatapultComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterCatapultComponent.CreateStaticDefaultValue), new Action(CharacterCatapultComponent.ResetStaticDefaultValue));
	}

	// Token: 0x060187A8 RID: 100264 RVA: 0x00766480 File Offset: 0x00764680
	public static void CreateStaticDefaultValue()
	{
		CharacterCatapultComponent._tmpVector = Vector.Create();
	}

	// Token: 0x060187A9 RID: 100265 RVA: 0x0076648C File Offset: 0x0076468C
	public static void ResetStaticDefaultValue()
	{
		CharacterCatapultComponent._tmpVector = null;
	}

	// Token: 0x1700267F RID: 9855
	// (get) Token: 0x060187AA RID: 100266 RVA: 0x00766494 File Offset: 0x00764694
	public override Type[] Dependencies
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

	// Token: 0x17002680 RID: 9856
	// (get) Token: 0x060187AB RID: 100267 RVA: 0x007664B6 File Offset: 0x007646B6
	private static Vector TmpVector
	{
		get
		{
			return CharacterCatapultComponent._tmpVector;
		}
	}

	// Token: 0x060187AC RID: 100268 RVA: 0x007664C0 File Offset: 0x007646C0
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

	// Token: 0x060187AD RID: 100269 RVA: 0x007665A0 File Offset: 0x007647A0
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.CatapultUnit = new BigJumpUnit();
		return true;
	}

	// Token: 0x060187AE RID: 100270 RVA: 0x007665B0 File Offset: 0x007647B0
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<CharacterActorComponent>();
		this.MoveComp = base.Entity.GetComponent<CharacterMoveComponent>();
		EventSystem.Instance.AddWithTarget(base.Entity, EEventName.CustomMoveCatapult, new Action<float>(this.OnCustomMoveCatapult));
		return true;
	}

	// Token: 0x060187AF RID: 100271 RVA: 0x007665FF File Offset: 0x007647FF
	protected override bool OnEnd()
	{
		EventSystem.Instance.RemoveWithTarget(base.Entity, EEventName.CustomMoveCatapult, new Action<float>(this.OnCustomMoveCatapult));
		return true;
	}

	// Token: 0x060187B0 RID: 100272 RVA: 0x00766624 File Offset: 0x00764824
	public void SetConfig(float time1, Vector startPoint, Vector middlePoint, Vector endPoint, string curvePath = "", float gravity2 = 1960f, [Nullable(2)] Rotator endRotator = null, [Nullable(2)] Vector gravityDirect = null, bool isSuperCatapult = false)
	{
		this.IsSuperCatapult = isSuperCatapult;
		this.LockRotator = (gravity2 > 0f);
		this.CatapultUnit.SetAll(time1, startPoint, middlePoint, endPoint, curvePath, gravity2, endRotator, gravityDirect, "", null);
	}

	// Token: 0x060187B1 RID: 100273 RVA: 0x00766668 File Offset: 0x00764868
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

	// Token: 0x060187B2 RID: 100274 RVA: 0x00766808 File Offset: 0x00764A08
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterCatapultComponent characterCatapultComponent = (CharacterCatapultComponent)componentTemplate;
		if (characterCatapultComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (characterCatapultComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		this.RunTime = characterCatapultComponent.RunTime;
		if (characterCatapultComponent.CatapultUnit == null)
		{
			this.CatapultUnit = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CatapultUnit), "CatapultUnit"))
		{
			return false;
		}
		this.LockRotator = characterCatapultComponent.LockRotator;
		this.IsSuperCatapult = characterCatapultComponent.IsSuperCatapult;
		return true;
	}

	// Token: 0x17002681 RID: 9857
	// (get) Token: 0x060187B3 RID: 100275 RVA: 0x007668CD File Offset: 0x00764ACD
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002682 RID: 9858
	// (get) Token: 0x060187B4 RID: 100276 RVA: 0x007668D0 File Offset: 0x00764AD0
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400D39C RID: 54172
	public const int MODEL_BUFFER_TIME_LENGTH = 200;

	// Token: 0x0400D39D RID: 54173
	public const int SUPER_CATAPULT_SKILL_ID = 400107;

	// Token: 0x0400D39E RID: 54174
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D39F RID: 54175
	[Nullable(2)]
	private CharacterMoveComponent MoveComp;

	// Token: 0x0400D3A0 RID: 54176
	private float RunTime;

	// Token: 0x0400D3A1 RID: 54177
	[Nullable(2)]
	private BigJumpUnit CatapultUnit;

	// Token: 0x0400D3A2 RID: 54178
	public bool LockRotator;

	// Token: 0x0400D3A3 RID: 54179
	private bool IsSuperCatapult;

	// Token: 0x0400D3A4 RID: 54180
	[Nullable(2)]
	private static Vector _tmpVector;
}
