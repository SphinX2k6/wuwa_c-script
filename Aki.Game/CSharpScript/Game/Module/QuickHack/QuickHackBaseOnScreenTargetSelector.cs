using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F45 RID: 16197
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class QuickHackBaseOnScreenTargetSelector : QuickHackTargetSelector
	{
		// Token: 0x06029034 RID: 167988 RVA: 0x00B84622 File Offset: 0x00B82822
		public override void Init(int selectRange, int selectScreenRadius)
		{
			base.Init(selectRange, selectScreenRadius);
			this.OnInit();
		}

		// Token: 0x06029035 RID: 167989 RVA: 0x00B84632 File Offset: 0x00B82832
		public override void Clear()
		{
			this.EntitiesInRange.Clear();
			this.TargetSet.Clear();
			this.LockTargetInfo = null;
			this.OnScreenTargetInfo = null;
			this.LockIgnoreCheckOnScreen = false;
		}

		// Token: 0x06029036 RID: 167990 RVA: 0x00B84660 File Offset: 0x00B82860
		public override bool UpdateTargetInfo(float delta)
		{
			if (this.LockTargetInfo == null)
			{
				this.LockTargetInfo = new QuickHackLockTargetInfo
				{
					HackType = null,
					Targets = this.TargetSet
				};
			}
			if (this.OnScreenTargetInfo == null)
			{
				this.OnScreenTargetInfo = new QuickHackOnScreenTargetInfo
				{
					TargetIdToIndexMap = new Dictionary<int, int>(),
					Targets = new List<EntityHandle>(),
					SignedScreenDistSquaredList = new List<double>(),
					DistSquaredList = new List<double>()
				};
			}
			Dictionary<int, int> targetIdToIndexMap = this.OnScreenTargetInfo.TargetIdToIndexMap;
			List<EntityHandle> targets = this.OnScreenTargetInfo.Targets;
			List<double> signedScreenDistSquaredList = this.OnScreenTargetInfo.SignedScreenDistSquaredList;
			List<double> distSquaredList = this.OnScreenTargetInfo.DistSquaredList;
			targetIdToIndexMap.Clear();
			targets.Clear();
			signedScreenDistSquaredList.Clear();
			distSquaredList.Clear();
			FVectorDouble fvectorDouble = Global.CharacterCameraManager.D_GetCameraLocation();
			bool result = false;
			foreach (EntityHandle entityHandle in new HashSet<EntityHandle>(this.TargetSet))
			{
				if (!this.CheckEntityValid(entityHandle))
				{
					this.TargetSet.Remove(entityHandle);
					result = true;
				}
			}
			this.StartLocation.FromUeVector(fvectorDouble);
			CreatureModel.Instance.GetEntitiesInRangeWithLocation(this.StartLocation, (float)this.SelectRange, this.EntityTypeQuery, this.EntitiesInRange, true);
			bool lockIgnoreCheckOnScreen = this.LockIgnoreCheckOnScreen;
			foreach (EntityHandle entityHandle2 in this.EntitiesInRange)
			{
				if (this.CheckEntityValid(entityHandle2))
				{
					FVectorDouble entityLocation = this.GetEntityLocation(entityHandle2);
					bool flag = base.ProjectWorldToScreen(entityLocation, this.ScreenPos, 0.1f);
					double num = this.ScreenPos.SizeSquared();
					bool flag2 = this.CheckEntityRendered(entityHandle2);
					if ((lockIgnoreCheckOnScreen || (flag2 && num < (double)this.ScreenRadiusSquared && flag)) && !this.TargetSet.Contains(entityHandle2))
					{
						this.TargetSet.Add(entityHandle2);
						result = true;
					}
					if (flag2 && flag)
					{
						bool flag3 = this.ScreenPos.X <= 0.0;
						this.TempVector.FromUeVector(entityLocation);
						this.TempVector.SubtractionEqual(this.StartLocation);
						double item = this.TempVector.SizeSquared();
						int count = targets.Count;
						targetIdToIndexMap[entityHandle2.Id] = count;
						targets.Add(entityHandle2);
						signedScreenDistSquaredList.Add(flag3 ? (-num) : num);
						distSquaredList.Add(item);
					}
				}
			}
			this.LockTargetInfo.HackType = ((this.TargetSet.Count > 0) ? new EQuickHackTargetType?(this.TargetHackType) : null);
			return result;
		}

		// Token: 0x06029037 RID: 167991 RVA: 0x00B84964 File Offset: 0x00B82B64
		public override IQuickHackLockTargetInfo GetLockTargetInfo()
		{
			if (this.LockTargetInfo == null)
			{
				this.LockTargetInfo = new QuickHackLockTargetInfo
				{
					HackType = null,
					Targets = this.TargetSet
				};
			}
			return this.LockTargetInfo;
		}

		// Token: 0x06029038 RID: 167992 RVA: 0x00B849A8 File Offset: 0x00B82BA8
		public override IQuickHackOnScreenTargetInfo GetOnScreenTargetInfo()
		{
			if (this.OnScreenTargetInfo == null)
			{
				this.OnScreenTargetInfo = new QuickHackOnScreenTargetInfo
				{
					TargetIdToIndexMap = new Dictionary<int, int>(),
					Targets = new List<EntityHandle>(),
					SignedScreenDistSquaredList = new List<double>(),
					DistSquaredList = new List<double>()
				};
			}
			return this.OnScreenTargetInfo;
		}

		// Token: 0x06029039 RID: 167993 RVA: 0x00B849FA File Offset: 0x00B82BFA
		public override void OnExecuteExtraEffect(EQuickHackSkillExtraEffect type)
		{
			if (type == EQuickHackSkillExtraEffect.SelectTargetIgnoreCheckOnScreen)
			{
				this.LockIgnoreCheckOnScreen = true;
			}
		}

		// Token: 0x0602903A RID: 167994
		protected abstract void OnInit();

		// Token: 0x0602903B RID: 167995
		protected abstract bool CheckEntityValid(EntityHandle entityHandle);

		// Token: 0x0602903C RID: 167996
		protected abstract bool CheckEntityRendered(EntityHandle entityHandle);

		// Token: 0x0602903D RID: 167997
		protected abstract FVectorDouble GetEntityLocation(EntityHandle entityHandle);

		// Token: 0x04016530 RID: 91440
		protected EEntityTypeQuery EntityTypeQuery = EEntityTypeQuery.PasserbyNPC | EEntityTypeQuery.Boss;

		// Token: 0x04016531 RID: 91441
		protected EQuickHackTargetType TargetHackType;

		// Token: 0x04016532 RID: 91442
		private readonly List<EntityHandle> EntitiesInRange = new List<EntityHandle>();

		// Token: 0x04016533 RID: 91443
		private readonly HashSet<EntityHandle> TargetSet = new HashSet<EntityHandle>();

		// Token: 0x04016534 RID: 91444
		[Nullable(2)]
		private IQuickHackOnScreenTargetInfo OnScreenTargetInfo;

		// Token: 0x04016535 RID: 91445
		[Nullable(2)]
		private IQuickHackLockTargetInfo LockTargetInfo;

		// Token: 0x04016536 RID: 91446
		private bool LockIgnoreCheckOnScreen;

		// Token: 0x04016537 RID: 91447
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x04016538 RID: 91448
		private readonly Vector2D ScreenPos = Vector2D.Create();

		// Token: 0x04016539 RID: 91449
		private readonly Vector TempVector = Vector.Create();
	}
}
