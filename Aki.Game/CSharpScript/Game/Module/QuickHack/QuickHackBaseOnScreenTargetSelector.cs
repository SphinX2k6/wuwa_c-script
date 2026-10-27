using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F7C RID: 20348
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class QuickHackBaseOnScreenTargetSelector : QuickHackTargetSelector
	{
		// Token: 0x060341C6 RID: 213446 RVA: 0x00C3AE76 File Offset: 0x00C39076
		public override void Init(int selectRange, int selectScreenRadius)
		{
			base.Init(selectRange, selectScreenRadius);
			this.OnInit();
		}

		// Token: 0x060341C7 RID: 213447 RVA: 0x00C3AE86 File Offset: 0x00C39086
		public override void Clear()
		{
			this.EntitiesInRange.Clear();
			this.TargetSet.Clear();
			this.LockTargetInfo = null;
			this.OnScreenTargetInfo = null;
			this.LockIgnoreCheckOnScreen = false;
		}

		// Token: 0x060341C8 RID: 213448 RVA: 0x00C3AEB4 File Offset: 0x00C390B4
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

		// Token: 0x060341C9 RID: 213449 RVA: 0x00C3B1B8 File Offset: 0x00C393B8
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

		// Token: 0x060341CA RID: 213450 RVA: 0x00C3B1FC File Offset: 0x00C393FC
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

		// Token: 0x060341CB RID: 213451 RVA: 0x00C3B24E File Offset: 0x00C3944E
		public override void OnExecuteExtraEffect(EQuickHackSkillExtraEffect type)
		{
			if (type == EQuickHackSkillExtraEffect.SelectTargetIgnoreCheckOnScreen)
			{
				this.LockIgnoreCheckOnScreen = true;
			}
		}

		// Token: 0x060341CC RID: 213452
		protected abstract void OnInit();

		// Token: 0x060341CD RID: 213453
		protected abstract bool CheckEntityValid(EntityHandle entityHandle);

		// Token: 0x060341CE RID: 213454
		protected abstract bool CheckEntityRendered(EntityHandle entityHandle);

		// Token: 0x060341CF RID: 213455
		protected abstract FVectorDouble GetEntityLocation(EntityHandle entityHandle);

		// Token: 0x0401BB5B RID: 113499
		protected EEntityTypeQuery EntityTypeQuery = EEntityTypeQuery.PasserbyNPC | EEntityTypeQuery.Boss;

		// Token: 0x0401BB5C RID: 113500
		protected EQuickHackTargetType TargetHackType;

		// Token: 0x0401BB5D RID: 113501
		private readonly List<EntityHandle> EntitiesInRange = new List<EntityHandle>();

		// Token: 0x0401BB5E RID: 113502
		private readonly HashSet<EntityHandle> TargetSet = new HashSet<EntityHandle>();

		// Token: 0x0401BB5F RID: 113503
		[Nullable(2)]
		private IQuickHackOnScreenTargetInfo OnScreenTargetInfo;

		// Token: 0x0401BB60 RID: 113504
		[Nullable(2)]
		private IQuickHackLockTargetInfo LockTargetInfo;

		// Token: 0x0401BB61 RID: 113505
		private bool LockIgnoreCheckOnScreen;

		// Token: 0x0401BB62 RID: 113506
		private readonly Vector StartLocation = Vector.Create();

		// Token: 0x0401BB63 RID: 113507
		private readonly Vector2D ScreenPos = Vector2D.Create();

		// Token: 0x0401BB64 RID: 113508
		private readonly Vector TempVector = Vector.Create();
	}
}
