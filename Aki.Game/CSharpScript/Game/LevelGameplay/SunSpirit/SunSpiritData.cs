using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform;
using CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit
{
	// Token: 0x02005B4B RID: 23371
	[NullableContext(2)]
	[Nullable(0)]
	public class SunSpiritData
	{
		// Token: 0x060397BA RID: 235450 RVA: 0x010224DA File Offset: 0x010206DA
		public SunSpiritData(int sunSpiritId)
		{
			this.SunSpiritId = sunSpiritId;
			this.State = new SunSpiritNoneState(this);
			this.Perform = new SunSpiritNonePerform(this, MathUtils.Instance.DefaultTransformProxy);
		}

		// Token: 0x17006D66 RID: 28006
		// (get) Token: 0x060397BB RID: 235451 RVA: 0x01022517 File Offset: 0x01020717
		public ESunSpiritStateType StateType
		{
			get
			{
				return this.State.StateType;
			}
		}

		// Token: 0x060397BC RID: 235452 RVA: 0x01022524 File Offset: 0x01020724
		public void StopCurrentSunSpiritState()
		{
			this.State.IsFinished = true;
		}

		// Token: 0x060397BD RID: 235453 RVA: 0x01022532 File Offset: 0x01020732
		public void StopAllSunSpiritState()
		{
			this.State.IsFinished = true;
			this.PendingStateQueue.Clear();
		}

		// Token: 0x060397BE RID: 235454 RVA: 0x0102254B File Offset: 0x0102074B
		[NullableContext(1)]
		public void SetNextSunSpiritState(SunSpiritBaseState newState)
		{
			this.PendingStateQueue.Push(newState);
		}

		// Token: 0x060397BF RID: 235455 RVA: 0x0102255C File Offset: 0x0102075C
		[NullableContext(1)]
		public void StopAllAndSetNextSunSpiritState(SunSpiritBaseState newState, bool bDoIfSameState = false)
		{
			if (!bDoIfSameState && this.PendingStateQueue.Size == 0 && this.State.IsSameState(newState))
			{
				Log.Instance.Info(ELogModule.SunSpirit, ELogAuthor.ZYL, "日灵: 当前状态和目标状态相同，不执行切换", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			this.StopAllSunSpiritState();
			this.SetNextSunSpiritState(newState);
		}

		// Token: 0x060397C0 RID: 235456 RVA: 0x010225B4 File Offset: 0x010207B4
		[NullableContext(1)]
		public SunSpiritBaseState GetSunSpiritState()
		{
			return this.State;
		}

		// Token: 0x060397C1 RID: 235457 RVA: 0x010225BC File Offset: 0x010207BC
		public void TickState(float deltaSeconds)
		{
			if (this.State.IsFinished)
			{
				this.State.Exit();
				if (this.PendingStateQueue.Size > 0)
				{
					this.State = this.PendingStateQueue.Pop();
				}
				else
				{
					this.State = new SunSpiritNoneState(this);
				}
				if (!this.State.Enter())
				{
					this.State.IsFinished = true;
				}
			}
			if (!this.State.IsFinished)
			{
				this.State.Tick(deltaSeconds);
			}
		}

		// Token: 0x060397C2 RID: 235458 RVA: 0x01022640 File Offset: 0x01020840
		[NullableContext(1)]
		public SunSpiritBasePerform GetSunSpiritPerform()
		{
			return this.Perform;
		}

		// Token: 0x060397C3 RID: 235459 RVA: 0x01022648 File Offset: 0x01020848
		[NullableContext(1)]
		public void ChangeSunSpiritPerform(SunSpiritBasePerform newPerform)
		{
			SunSpiritBasePerform perform = this.Perform;
			this.Perform = newPerform;
			global::Transform transform = global::Transform.Create();
			((ISunSpiritScenePerform)perform).GetTransform(transform);
			perform.Destroy();
			if (!this.Perform.Init())
			{
				this.Perform = new SunSpiritNonePerform(this, transform);
				this.Perform.Init();
			}
		}

		// Token: 0x060397C4 RID: 235460 RVA: 0x010226A0 File Offset: 0x010208A0
		[NullableContext(1)]
		public void SetOrUpdateSunSpiritBasicDataByProto(SunSpiritPb sunSpiritPb)
		{
			this.PbData = sunSpiritPb;
			this.ConfigId = sunSpiritPb.EntityConfigId;
			this.PlayerId = CreatureModel.Instance.GetPlayerId();
			this.InstId = sunSpiritPb.InstId;
			this.AreaId = SunSpiritModel.Instance.GetSunSpiritAreaIdByConfigId(this.InstId, this.ConfigId);
		}

		// Token: 0x060397C5 RID: 235461 RVA: 0x010226F8 File Offset: 0x010208F8
		public void RefreshSunSpiritStateByCachedProto(bool bDoIfSameState)
		{
			if (this.PbData == null)
			{
				return;
			}
			if (!SunSpiritModel.Instance.GetIsSunSpiritEnable())
			{
				this.StopAllAndSetNextSunSpiritState(new SunSpiritNoneState(this), bDoIfSameState);
				return;
			}
			SunSpiritTakeUpPb takeUpData = this.PbData.TakeUpData;
			if (takeUpData != null && takeUpData.TrapEntityConfigId != 0)
			{
				SunSpiritTakeUpPb takeUpData2 = this.PbData.TakeUpData;
				int gearConfigId = (takeUpData2 != null) ? takeUpData2.TrapEntityConfigId : 0;
				SunSpiritTakeUpPb takeUpData3 = this.PbData.TakeUpData;
				this.StopAllAndSetNextSunSpiritState(new SunSpiritOccupiedByGearState(this, gearConfigId, (takeUpData3 != null) ? takeUpData3.Index : 0), bDoIfSameState);
				return;
			}
			this.StopAllAndSetNextSunSpiritState(new SunSpiritOccupiedByPlayerState(this), bDoIfSameState);
		}

		// Token: 0x17006D67 RID: 28007
		// (get) Token: 0x060397C6 RID: 235462 RVA: 0x0102278C File Offset: 0x0102098C
		public global::Vector Location
		{
			get
			{
				if (this.LocationCachedTime < Time.Instance.Frame)
				{
					if (this.LocationCache == null)
					{
						this.LocationCache = global::Vector.Create();
					}
					if (!((ISunSpiritScenePerform)this.Perform).GetTransformData(this.LocationCache, null, null))
					{
						return null;
					}
					this.LocationCachedTime = Time.Instance.Frame;
				}
				return this.LocationCache;
			}
		}

		// Token: 0x17006D68 RID: 28008
		// (get) Token: 0x060397C7 RID: 235463 RVA: 0x010227F0 File Offset: 0x010209F0
		public global::Rotator Rotator
		{
			get
			{
				if (this.RotationCachedTime < Time.Instance.Frame)
				{
					if (this.RotatorCache == null)
					{
						this.RotatorCache = global::Rotator.Create();
					}
					if (this.QuaternionCache == null)
					{
						this.QuaternionCache = Quat.Create(0.0, 0.0, 0.0, 1.0);
					}
					if (!((ISunSpiritScenePerform)this.Perform).GetTransformData(null, this.RotatorCache, null))
					{
						return null;
					}
					this.RotatorCache.Quaternion(this.QuaternionCache);
					this.RotationCachedTime = Time.Instance.Frame;
				}
				return this.RotatorCache;
			}
		}

		// Token: 0x17006D69 RID: 28009
		// (get) Token: 0x060397C8 RID: 235464 RVA: 0x010228A0 File Offset: 0x01020AA0
		public Quat Quaternion
		{
			get
			{
				global::Rotator rotator = this.Rotator;
				if (rotator == null)
				{
					return null;
				}
				return rotator.Quaternion(this.QuaternionCache);
			}
		}

		// Token: 0x17006D6A RID: 28010
		// (get) Token: 0x060397C9 RID: 235465 RVA: 0x010228BC File Offset: 0x01020ABC
		public global::Vector Scale3D
		{
			get
			{
				if (this.ScaleCachedTime < Time.Instance.Frame)
				{
					if (this.ScaleCache == null)
					{
						this.ScaleCache = global::Vector.Create();
					}
					if (!((ISunSpiritScenePerform)this.Perform).GetTransformData(null, null, this.ScaleCache))
					{
						return null;
					}
					this.ScaleCachedTime = Time.Instance.Frame;
				}
				return this.ScaleCache;
			}
		}

		// Token: 0x17006D6B RID: 28011
		// (get) Token: 0x060397CA RID: 235466 RVA: 0x01022920 File Offset: 0x01020B20
		public global::Transform Transform
		{
			get
			{
				if (this.TransformCacheTime < Time.Instance.Frame)
				{
					if (this.TransformCache == null)
					{
						this.TransformCache = global::Transform.Create();
					}
					if (!((ISunSpiritScenePerform)this.Perform).GetTransform(this.TransformCache))
					{
						return null;
					}
					this.TransformCacheTime = Time.Instance.Frame;
				}
				return this.TransformCache;
			}
		}

		// Token: 0x060397CB RID: 235467 RVA: 0x01022984 File Offset: 0x01020B84
		[NullableContext(1)]
		public void SetLocation(global::Vector value)
		{
			if (this.LocationCache == null)
			{
				this.LocationCache = global::Vector.Create();
			}
			this.LocationCache.FromUeVector(value);
			this.LocationCachedTime = Time.Instance.Frame;
			((ISunSpiritScenePerform)this.Perform).SetTransformData(this.LocationCache, null, null);
		}

		// Token: 0x060397CC RID: 235468 RVA: 0x010229DC File Offset: 0x01020BDC
		public void SetRotation(object value)
		{
			if (this.RotatorCache == null)
			{
				this.RotatorCache = global::Rotator.Create();
			}
			if (this.QuaternionCache == null)
			{
				this.QuaternionCache = Quat.Create(0.0, 0.0, 0.0, 1.0);
			}
			IQuat quat = value as IQuat;
			if (quat != null)
			{
				this.QuaternionCache.FromUeQuat(quat);
				this.QuaternionCache.Rotator(this.RotatorCache);
			}
			else
			{
				IRotator rotator = value as IRotator;
				if (rotator != null)
				{
					this.RotatorCache.FromUeRotator(rotator);
				}
			}
			this.RotatorCache.Quaternion(this.QuaternionCache);
			this.RotationCachedTime = Time.Instance.Frame;
			((ISunSpiritScenePerform)this.Perform).SetTransformData(null, this.RotatorCache, null);
		}

		// Token: 0x060397CD RID: 235469 RVA: 0x01022AB0 File Offset: 0x01020CB0
		[NullableContext(1)]
		public void SetLocationAndRotation(global::Vector location, [Nullable(2)] object rotation)
		{
			if (this.RotatorCache == null)
			{
				this.RotatorCache = global::Rotator.Create();
			}
			if (this.QuaternionCache == null)
			{
				this.QuaternionCache = Quat.Create(0.0, 0.0, 0.0, 1.0);
			}
			if (this.LocationCache == null)
			{
				this.LocationCache = global::Vector.Create();
			}
			this.LocationCache.FromUeVector(location);
			IQuat quat = rotation as IQuat;
			if (quat != null)
			{
				this.QuaternionCache.FromUeQuat(quat);
				this.QuaternionCache.Rotator(this.RotatorCache);
			}
			else
			{
				IRotator rotator = rotation as IRotator;
				if (rotator != null)
				{
					this.RotatorCache.FromUeRotator(rotator);
				}
			}
			this.RotatorCache.Quaternion(this.QuaternionCache);
			this.RotationCachedTime = Time.Instance.Frame;
			((ISunSpiritScenePerform)this.Perform).SetTransformData(this.LocationCache, this.RotatorCache, null);
		}

		// Token: 0x060397CE RID: 235470 RVA: 0x01022BA8 File Offset: 0x01020DA8
		[NullableContext(1)]
		public void SetScale3D(global::Vector value)
		{
			if (this.ScaleCache == null)
			{
				this.ScaleCache = global::Vector.Create();
			}
			this.ScaleCache.FromUeVector(value);
			this.ScaleCachedTime = Time.Instance.Frame;
			((ISunSpiritScenePerform)this.Perform).SetTransformData(null, null, this.ScaleCache);
		}

		// Token: 0x060397CF RID: 235471 RVA: 0x01022C00 File Offset: 0x01020E00
		[NullableContext(1)]
		public void SetTransform(global::Transform transform)
		{
			if (this.TransformCache == null)
			{
				this.TransformCache = global::Transform.Create();
			}
			this.TransformCache.Set(transform.GetLocation(), transform.GetRotation(), transform.GetScale3D());
			this.TransformCacheTime = Time.Instance.Frame;
			((ISunSpiritScenePerform)this.Perform).SetTransform(this.TransformCache);
		}

		// Token: 0x060397D0 RID: 235472 RVA: 0x01022C64 File Offset: 0x01020E64
		public void SetTransform(FTransform transform)
		{
			if (this.TransformCache == null)
			{
				this.TransformCache = global::Transform.Create();
			}
			this.TransformCache.Set(transform.GetLocation(), transform.GetRotation(), transform.GetScale3D());
			this.TransformCacheTime = Time.Instance.Frame;
			((ISunSpiritScenePerform)this.Perform).SetTransform(this.TransformCache);
		}

		// Token: 0x0401E556 RID: 124246
		public readonly int SunSpiritId;

		// Token: 0x0401E557 RID: 124247
		public int InstId;

		// Token: 0x0401E558 RID: 124248
		public int ConfigId;

		// Token: 0x0401E559 RID: 124249
		public int AreaId;

		// Token: 0x0401E55A RID: 124250
		public int PlayerId;

		// Token: 0x0401E55B RID: 124251
		public SunSpiritPb PbData;

		// Token: 0x0401E55C RID: 124252
		[Nullable(1)]
		private SunSpiritBaseState State;

		// Token: 0x0401E55D RID: 124253
		[Nullable(1)]
		private readonly Queue<SunSpiritBaseState> PendingStateQueue = new Queue<SunSpiritBaseState>(4);

		// Token: 0x0401E55E RID: 124254
		[Nullable(1)]
		private SunSpiritBasePerform Perform;

		// Token: 0x0401E55F RID: 124255
		private global::Vector LocationCache;

		// Token: 0x0401E560 RID: 124256
		private int LocationCachedTime;

		// Token: 0x0401E561 RID: 124257
		private Quat QuaternionCache;

		// Token: 0x0401E562 RID: 124258
		private global::Rotator RotatorCache;

		// Token: 0x0401E563 RID: 124259
		private int RotationCachedTime;

		// Token: 0x0401E564 RID: 124260
		private global::Vector ScaleCache;

		// Token: 0x0401E565 RID: 124261
		private int ScaleCachedTime;

		// Token: 0x0401E566 RID: 124262
		private global::Transform TransformCache;

		// Token: 0x0401E567 RID: 124263
		private int TransformCacheTime;
	}
}
