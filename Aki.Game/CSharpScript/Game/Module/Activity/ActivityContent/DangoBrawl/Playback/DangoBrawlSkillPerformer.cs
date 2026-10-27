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
	// Token: 0x02006867 RID: 26727
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlSkillPerformer
	{
		// Token: 0x1700978F RID: 38799
		// (get) Token: 0x06042BE5 RID: 273381 RVA: 0x0103DE1C File Offset: 0x0103C01C
		public DangoBrawlBattleSkillManager Manager { get; }

		// Token: 0x17009790 RID: 38800
		// (get) Token: 0x06042BE6 RID: 273382 RVA: 0x0103DE24 File Offset: 0x0103C024
		public SDangoBrawlSkillEffectInfo Config { get; }

		// Token: 0x17009791 RID: 38801
		// (get) Token: 0x06042BE7 RID: 273383 RVA: 0x0103DE2C File Offset: 0x0103C02C
		public DangoBrawlFightActionSkillCastInfo SkillCast { get; }

		// Token: 0x17009792 RID: 38802
		// (get) Token: 0x06042BE8 RID: 273384 RVA: 0x0103DE34 File Offset: 0x0103C034
		// (set) Token: 0x06042BE9 RID: 273385 RVA: 0x0103DE3C File Offset: 0x0103C03C
		public FTransformDouble WeaponTransform { get; private set; } = new FTransformDouble();

		// Token: 0x17009793 RID: 38803
		// (get) Token: 0x06042BEA RID: 273386 RVA: 0x0103DE45 File Offset: 0x0103C045
		// (set) Token: 0x06042BEB RID: 273387 RVA: 0x0103DE4D File Offset: 0x0103C04D
		public FTransformDouble FlightStartTransform { get; private set; } = new FTransformDouble();

		// Token: 0x17009794 RID: 38804
		// (get) Token: 0x06042BEC RID: 273388 RVA: 0x0103DE56 File Offset: 0x0103C056
		// (set) Token: 0x06042BED RID: 273389 RVA: 0x0103DE5E File Offset: 0x0103C05E
		public FTransformDouble FlightEndTransform { get; private set; } = new FTransformDouble();

		// Token: 0x06042BEE RID: 273390 RVA: 0x0103DE68 File Offset: 0x0103C068
		public DangoBrawlSkillPerformer(DangoBrawlBattleSkillManager manager, SDangoBrawlSkillEffectInfo config, DangoBrawlFightActionSkillCastInfo skillCast)
		{
			this.Manager = manager;
			this.Config = config;
			this.SkillCast = skillCast;
		}

		// Token: 0x06042BEF RID: 273391 RVA: 0x0103DEC7 File Offset: 0x0103C0C7
		public void Start()
		{
			this.InitTransform();
			this.SpawnAllEffects();
		}

		// Token: 0x06042BF0 RID: 273392 RVA: 0x0103DED8 File Offset: 0x0103C0D8
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

		// Token: 0x06042BF1 RID: 273393 RVA: 0x0103E30B File Offset: 0x0103C50B
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

		// Token: 0x06042BF2 RID: 273394 RVA: 0x0103E348 File Offset: 0x0103C548
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

		// Token: 0x06042BF3 RID: 273395 RVA: 0x0103E41C File Offset: 0x0103C61C
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

		// Token: 0x06042BF4 RID: 273396 RVA: 0x0103E5B4 File Offset: 0x0103C7B4
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

		// Token: 0x06042BF5 RID: 273397 RVA: 0x0103E674 File Offset: 0x0103C874
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

		// Token: 0x06042BF6 RID: 273398 RVA: 0x0103E710 File Offset: 0x0103C910
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

		// Token: 0x06042BF7 RID: 273399 RVA: 0x0103E778 File Offset: 0x0103C978
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

		// Token: 0x06042BF8 RID: 273400 RVA: 0x0103E858 File Offset: 0x0103CA58
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

		// Token: 0x06042BF9 RID: 273401 RVA: 0x0103E904 File Offset: 0x0103CB04
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

		// Token: 0x06042BFA RID: 273402 RVA: 0x0103EA28 File Offset: 0x0103CC28
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

		// Token: 0x06042BFB RID: 273403 RVA: 0x0103EA98 File Offset: 0x0103CC98
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

		// Token: 0x06042BFC RID: 273404 RVA: 0x0103EAF0 File Offset: 0x0103CCF0
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

		// Token: 0x06042BFD RID: 273405 RVA: 0x0103EB60 File Offset: 0x0103CD60
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

		// Token: 0x06042BFE RID: 273406 RVA: 0x0103EB88 File Offset: 0x0103CD88
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

		// Token: 0x06042BFF RID: 273407 RVA: 0x0103EC18 File Offset: 0x0103CE18
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

		// Token: 0x06042C00 RID: 273408 RVA: 0x0103EC47 File Offset: 0x0103CE47
		[NullableContext(2)]
		private static bool IsValidPath(string path)
		{
			return !string.IsNullOrEmpty(path) && path != "None";
		}

		// Token: 0x06042C01 RID: 273409 RVA: 0x0103EC60 File Offset: 0x0103CE60
		private static string BuildOffsetGroupKey(bool isSelfCaster, [Nullable(2)] string groupName)
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<bool>(isSelfCaster);
			defaultInterpolatedStringHandler.AppendLiteral(":");
			defaultInterpolatedStringHandler.AppendFormatted(groupName ?? string.Empty);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06042C02 RID: 273410 RVA: 0x0103ECA2 File Offset: 0x0103CEA2
		private bool ResolveIsSelfCaster()
		{
			DangoBrawlBattleManager battleManager = DangoBrawlModel.Instance.GetBattleManager(true);
			return battleManager != null && battleManager.GetIsSelfByFighterUid(this.SkillCast.SourceFighterUId);
		}

		// Token: 0x06042C03 RID: 273411 RVA: 0x0103ECC8 File Offset: 0x0103CEC8
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

		// Token: 0x06042C04 RID: 273412 RVA: 0x0103EDC0 File Offset: 0x0103CFC0
		[return: Nullable(2)]
		private static AActor GetActorByTag(string tag)
		{
			return UKuroCollectActorComponent.GetActorWithTag(FNameUtil.GetDynamicFName(tag) ?? FName.NAME_None, ECollectActorType.Default);
		}

		// Token: 0x06042C05 RID: 273413 RVA: 0x0103EDF4 File Offset: 0x0103CFF4
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

		// Token: 0x06042C06 RID: 273414 RVA: 0x0103EE4C File Offset: 0x0103D04C
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

		// Token: 0x06042C07 RID: 273415 RVA: 0x0103EED0 File Offset: 0x0103D0D0
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

		// Token: 0x04022BD9 RID: 142297
		private const string TagBornPlayerEffect = "Born_PlayerEffect";

		// Token: 0x04022BDA RID: 142298
		private const string TagBornNpcEffect = "Born_NPCEffect";

		// Token: 0x04022BDB RID: 142299
		private const string TagBornPlayer = "Born_Player";

		// Token: 0x04022BDC RID: 142300
		private const string TagBornNpc = "Born_NPC";

		// Token: 0x04022BE3 RID: 142307
		private string OffsetGroupKey = string.Empty;

		// Token: 0x04022BE4 RID: 142308
		private bool HoldsOffsetOrigin;

		// Token: 0x04022BE5 RID: 142309
		[Nullable(2)]
		private global::Vector RegisteredOffset;

		// Token: 0x04022BE6 RID: 142310
		private float ElapsedMs;

		// Token: 0x04022BE7 RID: 142311
		private int NextSegmentIndex;

		// Token: 0x04022BE8 RID: 142312
		private int NextHitSegmentIndex;

		// Token: 0x04022BE9 RID: 142313
		private int HitTotalCount;

		// Token: 0x04022BEA RID: 142314
		private int WeaponFxHandle;

		// Token: 0x04022BEB RID: 142315
		private readonly List<int> HitFxHandles = new List<int>();

		// Token: 0x04022BEC RID: 142316
		private int SkillFxHandle;

		// Token: 0x04022BED RID: 142317
		private bool SkillFxSpawnRequested;

		// Token: 0x04022BEE RID: 142318
		private float SkillFxSpawnedAtMs;

		// Token: 0x04022BEF RID: 142319
		[Nullable(2)]
		private UCurveFloat FlightCurve;

		// Token: 0x04022BF0 RID: 142320
		private int PendingOneShotCount;

		// Token: 0x04022BF1 RID: 142321
		private bool LoopStopped;

		// Token: 0x04022BF2 RID: 142322
		private bool LoopStopRequested;

		// Token: 0x04022BF3 RID: 142323
		private bool HasStartedFx;

		// Token: 0x04022BF4 RID: 142324
		private bool IsDestroyed;
	}
}
