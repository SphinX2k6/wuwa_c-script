using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.DangoBrawl.Structure;
using CSharpScript.Game.Effect;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Playback
{
	// Token: 0x020057B7 RID: 22455
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlSkillPerformer
	{
		// Token: 0x17006AD0 RID: 27344
		// (get) Token: 0x0603773C RID: 227132 RVA: 0x00F7F2FC File Offset: 0x00F7D4FC
		public DangoBrawlBattleSkillManager Manager { get; }

		// Token: 0x17006AD1 RID: 27345
		// (get) Token: 0x0603773D RID: 227133 RVA: 0x00F7F304 File Offset: 0x00F7D504
		public SDangoBrawlSkillEffectInfo Config { get; }

		// Token: 0x17006AD2 RID: 27346
		// (get) Token: 0x0603773E RID: 227134 RVA: 0x00F7F30C File Offset: 0x00F7D50C
		public DangoBrawlFightActionSkillCastInfo SkillCast { get; }

		// Token: 0x17006AD3 RID: 27347
		// (get) Token: 0x0603773F RID: 227135 RVA: 0x00F7F314 File Offset: 0x00F7D514
		// (set) Token: 0x06037740 RID: 227136 RVA: 0x00F7F31C File Offset: 0x00F7D51C
		public FTransformDouble WeaponTransform { get; private set; } = new FTransformDouble();

		// Token: 0x17006AD4 RID: 27348
		// (get) Token: 0x06037741 RID: 227137 RVA: 0x00F7F325 File Offset: 0x00F7D525
		// (set) Token: 0x06037742 RID: 227138 RVA: 0x00F7F32D File Offset: 0x00F7D52D
		public FTransformDouble FlightStartTransform { get; private set; } = new FTransformDouble();

		// Token: 0x17006AD5 RID: 27349
		// (get) Token: 0x06037743 RID: 227139 RVA: 0x00F7F336 File Offset: 0x00F7D536
		// (set) Token: 0x06037744 RID: 227140 RVA: 0x00F7F33E File Offset: 0x00F7D53E
		public FTransformDouble FlightEndTransform { get; private set; } = new FTransformDouble();

		// Token: 0x06037745 RID: 227141 RVA: 0x00F7F348 File Offset: 0x00F7D548
		public DangoBrawlSkillPerformer(DangoBrawlBattleSkillManager manager, SDangoBrawlSkillEffectInfo config, DangoBrawlFightActionSkillCastInfo skillCast)
		{
			this.Manager = manager;
			this.Config = config;
			this.SkillCast = skillCast;
		}

		// Token: 0x06037746 RID: 227142 RVA: 0x00F7F3A7 File Offset: 0x00F7D5A7
		public void Start()
		{
			this.InitTransform();
			this.SpawnAllEffects();
		}

		// Token: 0x06037747 RID: 227143 RVA: 0x00F7F3B8 File Offset: 0x00F7D5B8
		private void InitTransform()
		{
			bool flag = this.ResolveIsSelfCaster();
			ValueTuple<global::Vector, global::Rotator> valueTuple = this.ResolveWeaponBase(flag, this.Config.WeaponTargetSelf);
			global::Vector item = valueTuple.Item1;
			global::Rotator item2 = valueTuple.Item2;
			this.OffsetGroupKey = DangoBrawlSkillPerformer.BuildOffsetGroupKey(flag, this.Config.OffsetGroupName);
			this.HoldsOffsetOrigin = this.Manager.TryClaimOffsetOrigin(this.OffsetGroupKey);
			global::Vector vector;
			if (this.HoldsOffsetOrigin)
			{
				vector = new global::Vector();
			}
			else
			{
				vector = DangoBrawlSkillPerformer.BestCandidateInRange(this.Config.OffsetMin, this.Config.OffsetMax, this.Config.RandomDistance, this.Manager.GetActiveOffsets(this.OffsetGroupKey));
			}
			this.Manager.RegisterOffset(this.OffsetGroupKey, vector);
			this.RegisteredOffset = vector;
			global::Vector vector2 = new global::Vector();
			global::Vector vector3 = vector2;
			FVector fvector = this.Config.WeaponOffset;
			vector3.FromUeVector(fvector);
			if (!flag)
			{
				vector2.X = -vector2.X;
			}
			vector2.AdditionEqual(vector);
			FRotator frotator = item2.ToUeRotator();
			FVectorDouble fvectorDouble = item.ToUeVector(false);
			fvector = global::Vector.OneVectorDouble;
			FTransformDouble ftransformDouble = new FTransformDouble(ref frotator, ref fvectorDouble, ref fvector);
			FVectorDouble fvectorDouble2 = UKismetMathLibrary.D_TransformLocation(ftransformDouble, vector2.ToUeVector(false));
			global::Vector vector4 = new global::Vector();
			vector4.FromUeVector(fvectorDouble2);
			global::Vector actorLocationByTag = DangoBrawlSkillPerformer.GetActorLocationByTag(flag ? "Born_NPC" : "Born_Player");
			bool towardOpposite = this.Config.TowardOpposite;
			global::Vector actorLocationByTag2 = DangoBrawlSkillPerformer.GetActorLocationByTag(flag ? "Born_Player" : "Born_NPC");
			global::Vector vector5 = new global::Vector();
			vector5.X = actorLocationByTag.X - actorLocationByTag2.X;
			vector5.Y = actorLocationByTag.Y - actorLocationByTag2.Y;
			vector5.Z = actorLocationByTag.Z - actorLocationByTag2.Z;
			vector5.GetSafeNormal(vector5, 9.99999993922529E-09);
			FRotator frotator2;
			if (towardOpposite)
			{
				global::Vector vector6 = new global::Vector();
				vector6.X = actorLocationByTag.X - vector4.X;
				vector6.Y = actorLocationByTag.Y - vector4.Y;
				vector6.Z = actorLocationByTag.Z - vector4.Z;
				vector6.GetSafeNormal(vector6, 9.99999993922529E-09);
				fvectorDouble = vector6.ToUeVector(false);
				frotator2 = UKismetMathLibrary.D_MakeRotFromYZ(fvectorDouble, global::Vector.UpVectorDouble);
			}
			else
			{
				fvectorDouble = vector5.ToUeVector(false);
				frotator2 = UKismetMathLibrary.D_MakeRotFromYZ(fvectorDouble, global::Vector.UpVectorDouble);
			}
			fvectorDouble = vector4.ToUeVector(false);
			fvector = global::Vector.OneVectorDouble;
			this.WeaponTransform = new FTransformDouble(ref frotator2, ref fvectorDouble, ref fvector);
			global::Vector vector7 = new global::Vector();
			global::Vector vector8 = vector7;
			fvector = this.Config.SkillOffset;
			vector8.FromUeVector(fvector);
			FTransformDouble weaponTransform = this.WeaponTransform;
			FVectorDouble fvectorDouble3 = UKismetMathLibrary.D_TransformLocation(weaponTransform, vector7.ToUeVector(false));
			global::Vector vector9 = new global::Vector();
			vector9.FromUeVector(fvectorDouble3);
			global::Vector vector10 = new global::Vector();
			FRotator frotator3;
			if (towardOpposite)
			{
				global::Vector vector11 = new global::Vector();
				vector11.X = actorLocationByTag.X - vector9.X;
				vector11.Y = actorLocationByTag.Y - vector9.Y;
				vector11.Z = actorLocationByTag.Z - vector9.Z;
				vector11.GetSafeNormal(vector11, 9.99999993922529E-09);
				fvectorDouble = vector11.ToUeVector(false);
				frotator3 = UKismetMathLibrary.D_MakeRotFromYZ(fvectorDouble, global::Vector.UpVectorDouble);
				vector10.DeepCopy(actorLocationByTag);
			}
			else
			{
				fvectorDouble = vector5.ToUeVector(false);
				frotator3 = UKismetMathLibrary.D_MakeRotFromYZ(fvectorDouble, global::Vector.UpVectorDouble);
				double num = vector5.DotProduct(actorLocationByTag.X - vector9.X, actorLocationByTag.Y - vector9.Y, actorLocationByTag.Z - vector9.Z);
				vector10.X = vector9.X + vector5.X * num;
				vector10.Y = vector9.Y + vector5.Y * num;
				vector10.Z = vector9.Z + vector5.Z * num;
			}
			fvectorDouble = vector9.ToUeVector(false);
			fvector = global::Vector.OneVectorDouble;
			this.FlightStartTransform = new FTransformDouble(ref frotator3, ref fvectorDouble, ref fvector);
			fvectorDouble = vector10.ToUeVector(false);
			fvector = global::Vector.OneVectorDouble;
			this.FlightEndTransform = new FTransformDouble(ref frotator3, ref fvectorDouble, ref fvector);
		}

		// Token: 0x06037748 RID: 227144 RVA: 0x00F7F7EB File Offset: 0x00F7D9EB
		public void Tick(float delta)
		{
			if (this.IsDestroyed)
			{
				return;
			}
			this.ElapsedMs += delta;
			this.TickDamageSegments();
			this.TickHitSpawn();
			this.TickSkillSpawn();
			this.TickFlightMove();
			this.TickLoopStop();
			this.TryFinishSelf();
		}

		// Token: 0x06037749 RID: 227145 RVA: 0x00F7F828 File Offset: 0x00F7DA28
		private void TickFlightMove()
		{
			if (this.SkillFxHandle == 0)
			{
				return;
			}
			if (this.Config.SkillMoveTime <= 0f)
			{
				return;
			}
			float num = (this.ElapsedMs - this.SkillFxSpawnedAtMs) / (this.Config.SkillMoveTime * 1000f);
			if (num < 0f)
			{
				num = 0f;
			}
			else if (num > 1f)
			{
				num = 1f;
			}
			float num2 = (this.FlightCurve != null) ? this.FlightCurve.GetFloatValue(num) : num;
			FVectorDouble fvectorDouble = UKismetMathLibrary.D_VLerp(this.FlightStartTransform.GetTranslation(), this.FlightEndTransform.GetTranslation(), (double)num2);
			OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.SkillFxHandle);
			if (effectActor.IsValid())
			{
				FHitResult fhitResult = new FHitResult();
				effectActor.D_K2_SetActorLocation(fvectorDouble, false, ref fhitResult, true);
			}
		}

		// Token: 0x0603774A RID: 227146 RVA: 0x00F7F8FC File Offset: 0x00F7DAFC
		private void TickDamageSegments()
		{
			DangoBrawlDamageInfo damageInfo = this.SkillCast.DamageInfo;
			RepeatedField<DangoBrawlDamageSegment> repeatedField = (damageInfo != null) ? damageInfo.Damages : null;
			if (repeatedField == null || repeatedField.Count == 0)
			{
				return;
			}
			if (this.NextSegmentIndex >= repeatedField.Count)
			{
				return;
			}
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			DangoBrawlDamageReporter dangoBrawlDamageReporter = (battleManager != null) ? battleManager.Damage : null;
			if (dangoBrawlDamageReporter == null)
			{
				return;
			}
			bool isCrit = this.SkillCast.DamageInfo.IsCrit;
			float elapsedMs = this.ElapsedMs;
			while (this.NextSegmentIndex < repeatedField.Count)
			{
				int segmentHitDelayMs = this.Manager.GetSegmentHitDelayMs(this.SkillCast.SkillConfigId, this.NextSegmentIndex);
				if (elapsedMs < (float)segmentHitDelayMs)
				{
					break;
				}
				DangoBrawlDamageSegment dangoBrawlDamageSegment = repeatedField[this.NextSegmentIndex];
				DangoBrawlBuff? dangoBrawlBuff;
				bool flag = dangoBrawlDamageSegment.BuffConfigId > 0 && DangoBrawlConfig.Instance.GetBuffConfigById(dangoBrawlDamageSegment.BuffConfigId) != null && dangoBrawlBuff.GetValueOrDefault().IsShow;
				dangoBrawlDamageReporter.Report(new DangoBrawlDamageEvent
				{
					Source = (flag ? EDangoBrawlDamageSource.BuffWeaponDamage : EDangoBrawlDamageSource.Weapon),
					SourceConfigId = (flag ? dangoBrawlDamageSegment.BuffConfigId : this.SkillCast.WeaponItemId),
					SourceFighterUid = this.SkillCast.SourceFighterUId,
					TargetFighterUid = this.SkillCast.TargetFighterUId,
					Value = dangoBrawlDamageSegment.Damage,
					IsCrit = isCrit,
					ShowType = dangoBrawlDamageSegment.ShowType,
					SourceItemUid = this.SkillCast.WeaponItemUId
				});
				this.NextSegmentIndex++;
			}
		}

		// Token: 0x0603774B RID: 227147 RVA: 0x00F7FA94 File Offset: 0x00F7DC94
		private void TickHitSpawn()
		{
			if (this.NextHitSegmentIndex >= this.HitTotalCount)
			{
				return;
			}
			float elapsedMs = this.ElapsedMs;
			while (this.NextHitSegmentIndex < this.HitTotalCount)
			{
				int segmentHitDelayMs = this.Manager.GetSegmentHitDelayMs(this.SkillCast.SkillConfigId, this.NextHitSegmentIndex);
				if (elapsedMs < (float)segmentHitDelayMs)
				{
					break;
				}
				string path = this.Config.HitAssetPath.ToAssetPathName();
				FTransformDouble flightEndTransform = this.FlightEndTransform;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(6, 1);
				defaultInterpolatedStringHandler.AppendLiteral("hitFx#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(this.NextHitSegmentIndex);
				int num = this.SpawnOneShot(path, flightEndTransform, defaultInterpolatedStringHandler.ToStringAndClear());
				if (num != 0)
				{
					this.HitFxHandles.Add(num);
				}
				this.NextHitSegmentIndex++;
			}
		}

		// Token: 0x0603774C RID: 227148 RVA: 0x00F7FB54 File Offset: 0x00F7DD54
		private void TickSkillSpawn()
		{
			if (this.SkillFxSpawnRequested)
			{
				return;
			}
			float num = (this.Config.PlayTimeDelay > 0f) ? (this.Config.PlayTimeDelay * 1000f) : 0f;
			if (this.ElapsedMs < num)
			{
				return;
			}
			this.SkillFxSpawnRequested = true;
			this.SkillFxHandle = this.SpawnLoop(this.Config.SkillAssetPath.ToAssetPathName(), this.FlightStartTransform, "skillFx");
			if (this.SkillFxHandle == 0)
			{
				this.LoopStopped = true;
				this.TryFinishSelf();
				return;
			}
			this.SkillFxSpawnedAtMs = this.ElapsedMs;
		}

		// Token: 0x0603774D RID: 227149 RVA: 0x00F7FBF0 File Offset: 0x00F7DDF0
		private void TickLoopStop()
		{
			if (this.LoopStopRequested || this.SkillFxHandle == 0)
			{
				return;
			}
			if (this.ElapsedMs - this.SkillFxSpawnedAtMs < this.Config.SkillMoveTime * 1000f)
			{
				return;
			}
			this.LoopStopRequested = true;
			EffectSystem.Instance.StopEffectById(this.SkillFxHandle, "[DangoBrawlSkillPerformer] loop end", true, null);
		}

		// Token: 0x0603774E RID: 227150 RVA: 0x00F7FC58 File Offset: 0x00F7DE58
		public void Destroy()
		{
			if (this.IsDestroyed)
			{
				return;
			}
			this.IsDestroyed = true;
			this.StopIfAlive(ref this.WeaponFxHandle, "[DangoBrawlSkillPerformer.Destroy] weapon");
			this.StopIfAlive(ref this.SkillFxHandle, "[DangoBrawlSkillPerformer.Destroy] skill");
			for (int i = 0; i < this.HitFxHandles.Count; i++)
			{
				int num = this.HitFxHandles[i];
				if (num != 0)
				{
					EffectSystem.Instance.StopEffectById(num, "[DangoBrawlSkillPerformer.Destroy] hit", true, null);
				}
			}
			this.HitFxHandles.Clear();
			if (this.HoldsOffsetOrigin)
			{
				this.Manager.ReleaseOffsetOrigin(this.OffsetGroupKey);
				this.HoldsOffsetOrigin = false;
			}
			if (this.RegisteredOffset != null)
			{
				this.Manager.UnregisterOffset(this.OffsetGroupKey, this.RegisteredOffset);
				this.RegisteredOffset = null;
			}
			this.Manager.Unregister(this);
		}

		// Token: 0x0603774F RID: 227151 RVA: 0x00F7FD38 File Offset: 0x00F7DF38
		private void SpawnAllEffects()
		{
			this.WeaponFxHandle = this.SpawnOneShot(this.Config.WeaponAssetPath.ToAssetPathName(), this.WeaponTransform, "weaponFx");
			bool flag = DangoBrawlSkillPerformer.IsValidPath(this.Config.HitAssetPath.ToAssetPathName());
			DangoBrawlDamageInfo damageInfo = this.SkillCast.DamageInfo;
			int? num;
			if (damageInfo == null)
			{
				num = null;
			}
			else
			{
				RepeatedField<DangoBrawlDamageSegment> damages = damageInfo.Damages;
				num = ((damages != null) ? new int?(damages.Count) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			this.HitTotalCount = (flag ? valueOrDefault : 0);
			this.ValidateAndPrepareSkill();
			this.HasStartedFx = true;
			this.TryFinishSelf();
		}

		// Token: 0x06037750 RID: 227152 RVA: 0x00F7FDE4 File Offset: 0x00F7DFE4
		private unsafe void ValidateAndPrepareSkill()
		{
			bool flag = DangoBrawlSkillPerformer.IsValidPath(this.Config.SkillAssetPath.ToAssetPathName());
			float skillMoveTime = this.Config.SkillMoveTime;
			if (flag && skillMoveTime > 0f)
			{
				this.FlightCurve = this.Config.SkillCurve;
				return;
			}
			if (!flag && skillMoveTime == 0f)
			{
				this.LoopStopped = true;
				this.SkillFxSpawnRequested = true;
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.DangoBrawl;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "[SkillPerformer] Skill DA / SkillMoveTime 配置非法组合, 跳过 Skill 起播";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("skillConfigId", this.SkillCast.SkillConfigId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("effectId", this.Config.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("hasSkillDa", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("skillMoveTime", skillMoveTime);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
			this.LoopStopped = true;
			this.SkillFxSpawnRequested = true;
		}

		// Token: 0x06037751 RID: 227153 RVA: 0x00F7FF08 File Offset: 0x00F7E108
		private int SpawnOneShot([Nullable(2)] string path, FTransformDouble transform, string tag)
		{
			if (!DangoBrawlSkillPerformer.IsValidPath(path))
			{
				return 0;
			}
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(transform);
			int num = instance.SpawnEffect(world, ftransformDouble, path, "[DangoBrawlSkillPerformer] " + tag, null, EEffectType.Fight, null, null, null, false, false);
			if (num == 0)
			{
				return 0;
			}
			this.PendingOneShotCount++;
			EffectSystem.Instance.AddFinishCallback(num, new Action<int>(this.OnOneShotFinish));
			return num;
		}

		// Token: 0x06037752 RID: 227154 RVA: 0x00F7FF78 File Offset: 0x00F7E178
		private int SpawnLoop(string path, FTransformDouble transform, string tag)
		{
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(transform);
			int num = instance.SpawnEffect(world, ftransformDouble, path, "[DangoBrawlSkillPerformer] " + tag, null, EEffectType.Fight, null, null, null, false, false);
			if (num == 0)
			{
				return 0;
			}
			EffectSystem.Instance.AddFinishCallback(num, new Action<int>(this.OnLoopStopped));
			return num;
		}

		// Token: 0x06037753 RID: 227155 RVA: 0x00F7FFD0 File Offset: 0x00F7E1D0
		private void OnOneShotFinish(int handle)
		{
			if (this.IsDestroyed)
			{
				return;
			}
			this.PendingOneShotCount--;
			if (handle == this.WeaponFxHandle)
			{
				this.WeaponFxHandle = 0;
			}
			else
			{
				for (int i = 0; i < this.HitFxHandles.Count; i++)
				{
					if (this.HitFxHandles[i] == handle)
					{
						this.HitFxHandles[i] = 0;
						break;
					}
				}
			}
			this.TryFinishSelf();
		}

		// Token: 0x06037754 RID: 227156 RVA: 0x00F80040 File Offset: 0x00F7E240
		private void OnLoopStopped(int handle)
		{
			if (this.IsDestroyed)
			{
				return;
			}
			this.LoopStopped = true;
			if (handle == this.SkillFxHandle)
			{
				this.SkillFxHandle = 0;
			}
			this.TryFinishSelf();
		}

		// Token: 0x06037755 RID: 227157 RVA: 0x00F80068 File Offset: 0x00F7E268
		private void TryFinishSelf()
		{
			if (this.IsDestroyed)
			{
				return;
			}
			if (!this.HasStartedFx || this.PendingOneShotCount > 0 || this.NextHitSegmentIndex < this.HitTotalCount || !this.LoopStopped)
			{
				return;
			}
			DangoBrawlDamageInfo damageInfo = this.SkillCast.DamageInfo;
			int? num;
			if (damageInfo == null)
			{
				num = null;
			}
			else
			{
				RepeatedField<DangoBrawlDamageSegment> damages = damageInfo.Damages;
				num = ((damages != null) ? new int?(damages.Count) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			if (this.NextSegmentIndex < valueOrDefault)
			{
				return;
			}
			this.Destroy();
		}

		// Token: 0x06037756 RID: 227158 RVA: 0x00F800F8 File Offset: 0x00F7E2F8
		private void StopIfAlive(ref int handle, string reason)
		{
			if (handle == 0)
			{
				return;
			}
			int handle2 = handle;
			handle = 0;
			EffectSystem.Instance.StopEffectById(handle2, reason, true, null);
		}

		// Token: 0x06037757 RID: 227159 RVA: 0x00F80127 File Offset: 0x00F7E327
		[NullableContext(2)]
		private static bool IsValidPath(string path)
		{
			return !string.IsNullOrEmpty(path) && path != "None";
		}

		// Token: 0x06037758 RID: 227160 RVA: 0x00F80140 File Offset: 0x00F7E340
		private static string BuildOffsetGroupKey(bool isSelfCaster, [Nullable(2)] string groupName)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<bool>(isSelfCaster);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(groupName ?? string.Empty);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06037759 RID: 227161 RVA: 0x00F80182 File Offset: 0x00F7E382
		private bool ResolveIsSelfCaster()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			return battleManager != null && battleManager.GetIsSelfByFighterUid(this.SkillCast.SourceFighterUId);
		}

		// Token: 0x0603775A RID: 227162 RVA: 0x00F801A8 File Offset: 0x00F7E3A8
		[return: TupleElementNames(new string[]
		{
			"loc",
			"rot"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		private ValueTuple<global::Vector, global::Rotator> ResolveWeaponBase(bool isSelfCaster, bool targetSelf)
		{
			string tag = isSelfCaster ? "Born_PlayerEffect" : "Born_NPCEffect";
			string tag2 = isSelfCaster ? "Born_NPCEffect" : "Born_PlayerEffect";
			AActor actorByTag = DangoBrawlSkillPerformer.GetActorByTag(tag);
			FTransformDouble? ftransformDouble = (actorByTag != null) ? new FTransformDouble?(actorByTag.D_GetTransformWithUpdate()) : null;
			global::Rotator rotator = new global::Rotator();
			global::Vector vector = new global::Vector();
			if (ftransformDouble != null)
			{
				global::Rotator rotator2 = rotator;
				FRotator frotator = ftransformDouble.Value.Rotator();
				rotator2.FromUeRotator(frotator);
				global::Vector vector2 = vector;
				FVectorDouble translation = ftransformDouble.Value.GetTranslation();
				vector2.FromUeVector(translation);
			}
			global::Vector vector3 = new global::Vector();
			if (targetSelf)
			{
				vector3.DeepCopy(vector);
			}
			else
			{
				AActor actorByTag2 = DangoBrawlSkillPerformer.GetActorByTag(tag2);
				FTransformDouble? ftransformDouble2 = (actorByTag2 != null) ? new FTransformDouble?(actorByTag2.D_GetTransformWithUpdate()) : null;
				if (ftransformDouble2 != null)
				{
					global::Vector vector4 = vector3;
					FVectorDouble translation = ftransformDouble2.Value.GetTranslation();
					vector4.FromUeVector(translation);
				}
			}
			return new ValueTuple<global::Vector, global::Rotator>(vector3, rotator);
		}

		// Token: 0x0603775B RID: 227163 RVA: 0x00F802A0 File Offset: 0x00F7E4A0
		[return: Nullable(2)]
		private static AActor GetActorByTag(string tag)
		{
			return UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(tag) ?? FName.NAME_None, ECollectActorType.Default);
		}

		// Token: 0x0603775C RID: 227164 RVA: 0x00F802D4 File Offset: 0x00F7E4D4
		private static global::Vector GetActorLocationByTag(string tag)
		{
			global::Vector vector = new global::Vector();
			AActor actorByTag = DangoBrawlSkillPerformer.GetActorByTag(tag);
			FTransformDouble? ftransformDouble = (actorByTag != null) ? new FTransformDouble?(actorByTag.D_GetTransformWithUpdate()) : null;
			if (ftransformDouble != null)
			{
				global::Vector vector2 = vector;
				FVectorDouble translation = ftransformDouble.Value.GetTranslation();
				vector2.FromUeVector(translation);
			}
			return vector;
		}

		// Token: 0x0603775D RID: 227165 RVA: 0x00F8032C File Offset: 0x00F7E52C
		private static global::Vector RandomInRange(FVector min, FVector max)
		{
			Random random = MathUtils.Instance.Random;
			return new global::Vector
			{
				X = (double)(min.X + (max.X - min.X) * random.NextSingle()),
				Y = (double)(min.Y + (max.Y - min.Y) * random.NextSingle()),
				Z = (double)(min.Z + (max.Z - min.Z) * random.NextSingle())
			};
		}

		// Token: 0x0603775E RID: 227166 RVA: 0x00F803B0 File Offset: 0x00F7E5B0
		private unsafe static global::Vector BestCandidateInRange(FVector min, FVector max, float minDistance, List<global::Vector> existing)
		{
			if (minDistance <= 0f || existing.Count == 0)
			{
				return DangoBrawlSkillPerformer.RandomInRange(min, max);
			}
			float num = minDistance * minDistance;
			global::Vector vector = DangoBrawlSkillPerformer.RandomInRange(min, max);
			float num2 = -1f;
			for (int i = 0; i < 20; i++)
			{
				global::Vector vector2 = (i == 0) ? vector : DangoBrawlSkillPerformer.RandomInRange(min, max);
				float num3 = float.MaxValue;
				for (int j = 0; j < existing.Count; j++)
				{
					global::Vector vector3 = existing[j];
					float num4 = (float)(vector2.X - vector3.X);
					float num5 = (float)(vector2.Y - vector3.Y);
					float num6 = (float)(vector2.Z - vector3.Z);
					float num7 = num4 * num4 + num5 * num5 + num6 * num6;
					if (num7 < num3)
					{
						num3 = num7;
					}
				}
				if (num3 >= num)
				{
					return vector2;
				}
				if (num3 > num2)
				{
					num2 = num3;
					vector = vector2;
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.DangoBrawl;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "[DangoRandom] k 次未达标, 返回最远兜底(可能挤/盒子太小)";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("k", 20);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("minDistance", minDistance);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("bestDist", (float)Math.Sqrt((double)Math.Max(num2, 0f)));
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3);
			string item = "box";
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(9, 6);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted<float>(min.X);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(min.Y);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(min.Z);
			defaultInterpolatedStringHandler.AppendLiteral(")~(");
			defaultInterpolatedStringHandler.AppendFormatted<float>(max.X);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(max.Y);
			defaultInterpolatedStringHandler.AppendLiteral(",");
			defaultInterpolatedStringHandler.AppendFormatted<float>(max.Z);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			ptr = new ValueTuple<string, object>(item, defaultInterpolatedStringHandler.ToStringAndClear());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("existingCount", existing.Count);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
			return vector;
		}

		// Token: 0x0401D436 RID: 119862
		private const string TagBornPlayerEffect = "Born_PlayerEffect";

		// Token: 0x0401D437 RID: 119863
		private const string TagBornNpcEffect = "Born_NPCEffect";

		// Token: 0x0401D438 RID: 119864
		private const string TagBornPlayer = "Born_Player";

		// Token: 0x0401D439 RID: 119865
		private const string TagBornNpc = "Born_NPC";

		// Token: 0x0401D440 RID: 119872
		private string OffsetGroupKey = string.Empty;

		// Token: 0x0401D441 RID: 119873
		private bool HoldsOffsetOrigin;

		// Token: 0x0401D442 RID: 119874
		[Nullable(2)]
		private global::Vector RegisteredOffset;

		// Token: 0x0401D443 RID: 119875
		private float ElapsedMs;

		// Token: 0x0401D444 RID: 119876
		private int NextSegmentIndex;

		// Token: 0x0401D445 RID: 119877
		private int NextHitSegmentIndex;

		// Token: 0x0401D446 RID: 119878
		private int HitTotalCount;

		// Token: 0x0401D447 RID: 119879
		private int WeaponFxHandle;

		// Token: 0x0401D448 RID: 119880
		private readonly List<int> HitFxHandles = new List<int>();

		// Token: 0x0401D449 RID: 119881
		private int SkillFxHandle;

		// Token: 0x0401D44A RID: 119882
		private bool SkillFxSpawnRequested;

		// Token: 0x0401D44B RID: 119883
		private float SkillFxSpawnedAtMs;

		// Token: 0x0401D44C RID: 119884
		[Nullable(2)]
		private UCurveFloat FlightCurve;

		// Token: 0x0401D44D RID: 119885
		private int PendingOneShotCount;

		// Token: 0x0401D44E RID: 119886
		private bool LoopStopped;

		// Token: 0x0401D44F RID: 119887
		private bool LoopStopRequested;

		// Token: 0x0401D450 RID: 119888
		private bool HasStartedFx;

		// Token: 0x0401D451 RID: 119889
		private bool IsDestroyed;
	}
}
