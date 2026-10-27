using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritPerform;
using CSharpScript.Game.LevelGamePlay.SunSpirit.SunSpiritState;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SunSpirit
{
	// Token: 0x020069EE RID: 27118
	[NullableContext(2)]
	[Nullable(0)]
	public class SunSpiritData
	{
		// Token: 0x06043771 RID: 276337 RVA: 0x0107DE26 File Offset: 0x0107C026
		public SunSpiritData(int sunSpiritId)
		{
			this.SunSpiritId = sunSpiritId;
			this.State = new SunSpiritNoneState(this);
			this.Perform = new SunSpiritNonePerform(this, MathUtils.Instance.DefaultTransformProxy);
		}

		// Token: 0x17009885 RID: 39045
		// (get) Token: 0x06043772 RID: 276338 RVA: 0x0107DE63 File Offset: 0x0107C063
		public ESunSpiritStateType StateType
		{
			get
			{
				return this.State.StateType;
			}
		}

		// Token: 0x06043773 RID: 276339 RVA: 0x0107DE70 File Offset: 0x0107C070
		public void StopCurrentSunSpiritState()
		{
			this.State.IsFinished = true;
		}

		// Token: 0x06043774 RID: 276340 RVA: 0x0107DE7E File Offset: 0x0107C07E
		public void StopAllSunSpiritState()
		{
			this.State.IsFinished = true;
			this.PendingStateQueue.Clear();
		}

		// Token: 0x06043775 RID: 276341 RVA: 0x0107DE97 File Offset: 0x0107C097
		[NullableContext(1)]
		public void SetNextSunSpiritState(SunSpiritBaseState newState)
		{
			this.PendingStateQueue.Push(newState);
		}

		// Token: 0x06043776 RID: 276342 RVA: 0x0107DEA8 File Offset: 0x0107C0A8
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

		// Token: 0x06043777 RID: 276343 RVA: 0x0107DF00 File Offset: 0x0107C100
		[NullableContext(1)]
		public SunSpiritBaseState GetSunSpiritState()
		{
			return this.State;
		}

		// Token: 0x06043778 RID: 276344 RVA: 0x0107DF08 File Offset: 0x0107C108
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

		// Token: 0x06043779 RID: 276345 RVA: 0x0107DF8C File Offset: 0x0107C18C
		[NullableContext(1)]
		public SunSpiritBasePerform GetSunSpiritPerform()
		{
			return this.Perform;
		}

		// Token: 0x0604377A RID: 276346 RVA: 0x0107DF94 File Offset: 0x0107C194
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

		// Token: 0x0604377B RID: 276347 RVA: 0x0107DFEC File Offset: 0x0107C1EC
		[NullableContext(1)]
		public void SetOrUpdateSunSpiritBasicDataByProto(SunSpiritPb sunSpiritPb)
		{
			this.PbData = sunSpiritPb;
			this.ConfigId = sunSpiritPb.EntityConfigId;
			this.PlayerId = CreatureModel.Instance.GetPlayerId();
			this.InstId = sunSpiritPb.InstId;
			this.AreaId = SunSpiritModel.Instance.GetSunSpiritAreaIdByConfigId(this.InstId, this.ConfigId);
		}

		// Token: 0x0604377C RID: 276348 RVA: 0x0107E044 File Offset: 0x0107C244
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

		// Token: 0x17009886 RID: 39046
		// (get) Token: 0x0604377D RID: 276349 RVA: 0x0107E0D8 File Offset: 0x0107C2D8
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

		// Token: 0x17009887 RID: 39047
		// (get) Token: 0x0604377E RID: 276350 RVA: 0x0107E13C File Offset: 0x0107C33C
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

		// Token: 0x17009888 RID: 39048
		// (get) Token: 0x0604377F RID: 276351 RVA: 0x0107E1EC File Offset: 0x0107C3EC
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

		// Token: 0x17009889 RID: 39049
		// (get) Token: 0x06043780 RID: 276352 RVA: 0x0107E208 File Offset: 0x0107C408
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

		// Token: 0x1700988A RID: 39050
		// (get) Token: 0x06043781 RID: 276353 RVA: 0x0107E26C File Offset: 0x0107C46C
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

		// Token: 0x06043782 RID: 276354 RVA: 0x0107E2D0 File Offset: 0x0107C4D0
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

		// Token: 0x06043783 RID: 276355 RVA: 0x0107E328 File Offset: 0x0107C528
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

		// Token: 0x06043784 RID: 276356 RVA: 0x0107E3FC File Offset: 0x0107C5FC
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

		// Token: 0x06043785 RID: 276357 RVA: 0x0107E4F4 File Offset: 0x0107C6F4
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

		// Token: 0x06043786 RID: 276358 RVA: 0x0107E54C File Offset: 0x0107C74C
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

		// Token: 0x06043787 RID: 276359 RVA: 0x0107E5B0 File Offset: 0x0107C7B0
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

		// Token: 0x04023364 RID: 144228
		public readonly int SunSpiritId;

		// Token: 0x04023365 RID: 144229
		public int InstId;

		// Token: 0x04023366 RID: 144230
		public int ConfigId;

		// Token: 0x04023367 RID: 144231
		public int AreaId;

		// Token: 0x04023368 RID: 144232
		public int PlayerId;

		// Token: 0x04023369 RID: 144233
		public SunSpiritPb PbData;

		// Token: 0x0402336A RID: 144234
		[Nullable(1)]
		private SunSpiritBaseState State;

		// Token: 0x0402336B RID: 144235
		[Nullable(1)]
		private readonly Queue<SunSpiritBaseState> PendingStateQueue = new Queue<SunSpiritBaseState>(4);

		// Token: 0x0402336C RID: 144236
		[Nullable(1)]
		private SunSpiritBasePerform Perform;

		// Token: 0x0402336D RID: 144237
		private global::Vector LocationCache;

		// Token: 0x0402336E RID: 144238
		private int LocationCachedTime;

		// Token: 0x0402336F RID: 144239
		private Quat QuaternionCache;

		// Token: 0x04023370 RID: 144240
		private global::Rotator RotatorCache;

		// Token: 0x04023371 RID: 144241
		private int RotationCachedTime;

		// Token: 0x04023372 RID: 144242
		private global::Vector ScaleCache;

		// Token: 0x04023373 RID: 144243
		private int ScaleCachedTime;

		// Token: 0x04023374 RID: 144244
		private global::Transform TransformCache;

		// Token: 0x04023375 RID: 144245
		private int TransformCacheTime;
	}
}
