using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.Pawn.Component;

namespace Aki.Game.NewWorld.Character.Common.Component.Abilities.Follow
{
	// Token: 0x020044BE RID: 17598
	[NullableContext(1)]
	[Nullable(0)]
	public class ChairRemotePresenter
	{
		// Token: 0x0602D5CA RID: 185802 RVA: 0x00A3B65E File Offset: 0x00A3985E
		public ChairRemotePresenter(IChairPresentationHost host)
		{
		}

		// Token: 0x0602D5CB RID: 185803 RVA: 0x00A3B670 File Offset: 0x00A39870
		public unsafe void TryStartRemoteVisibilityByChairEntity(Entity chairEntity)
		{
			DecorationFollowerComponent component = chairEntity.GetComponent<DecorationFollowerComponent>();
			if (component == null || !component.IsChair)
			{
				return;
			}
			CreatureDataComponent component2 = chairEntity.GetComponent<CreatureDataComponent>();
			long? num = (component2 != null) ? new long?(component2.GetCreatureDataId()) : null;
			bool flag = !(num > 0L);
			if (flag)
			{
				return;
			}
			long chairCreatureDataId = this.<host>P.ChairCreatureDataId;
			long? num2 = num;
			if ((chairCreatureDataId == num2.GetValueOrDefault() & num2 != null) && this.RemoteSitListenChairEntity == chairEntity && chairEntity.Valid)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[PlayerFollowerChairHandler.Remote] 椅子到达远端, 启动可见性";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("ChairCreatureDataId", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OwnerPlayerId", this.<host>P.OwnerPlayerId);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.EnsureRemoteChairSetup(chairEntity, num.Value);
		}

		// Token: 0x0602D5CC RID: 185804 RVA: 0x00A3B77C File Offset: 0x00A3997C
		private void EnsureRemoteChairSetup(Entity chairEntity, long chairCreatureDataId)
		{
			if (this.<host>P.ChairCreatureDataId > 0L && this.<host>P.ChairCreatureDataId != chairCreatureDataId)
			{
				this.<host>P.CleanupCurrentChair();
			}
			this.<host>P.IsChairShown = false;
			this.<host>P.ChairCreatureDataId = chairCreatureDataId;
			this.<host>P.SetChairPerformanceControlledExternally(chairEntity, true);
			this.<host>P.ChangeChairPerformanceState(chairEntity, EChairPerformanceState.Init);
			CreatureController.Instance.SetEntityEnable(chairEntity, false, "PlayerFollowerChairHandler.RemoteInitHide", false);
			this.StartRemoteVisibility(chairEntity);
		}

		// Token: 0x0602D5CD RID: 185805 RVA: 0x00A3B80C File Offset: 0x00A39A0C
		[return: Nullable(2)]
		private Entity GetSummonerRoleEntity(Entity chairEntity)
		{
			CreatureDataComponent component = chairEntity.GetComponent<CreatureDataComponent>();
			long? num = (component != null) ? new long?(component.GetSummonerId()) : null;
			if (!(num > 0L))
			{
				return ChairRemotePresenter.GetPlayerControlledRoleEntity(this.<host>P.OwnerPlayerId);
			}
			EntityHandle entity = CreatureModel.Instance.GetEntity(num.Value);
			WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
			if (worldEntity == null || !worldEntity.Valid)
			{
				return ChairRemotePresenter.GetPlayerControlledRoleEntity(this.<host>P.OwnerPlayerId);
			}
			return worldEntity;
		}

		// Token: 0x0602D5CE RID: 185806 RVA: 0x00A3B89C File Offset: 0x00A39A9C
		[NullableContext(2)]
		private static Entity GetPlayerControlledRoleEntity(int playerId)
		{
			if (playerId <= 0)
			{
				return null;
			}
			return (from item in SceneTeamModel.Instance.GetTeamItemsByPlayer(playerId)
			where item.IsControl()
			select item).Select(delegate(SceneTeamItem item)
			{
				EntityHandle entityHandle = item.EntityHandle;
				if (entityHandle == null)
				{
					return null;
				}
				return entityHandle.Entity;
			}).FirstOrDefault((WorldEntity entity) => entity != null && entity.Valid);
		}

		// Token: 0x0602D5CF RID: 185807 RVA: 0x00A3B926 File Offset: 0x00A39B26
		private void StartRemoteVisibility(Entity chairEntity)
		{
			this.StopInitialRestoreRetry();
			this.StartRemoteSitListen(chairEntity);
		}

		// Token: 0x0602D5D0 RID: 185808 RVA: 0x00A3B935 File Offset: 0x00A39B35
		public void TryRestoreFromEntityState(Entity chairEntity)
		{
			if (!ChairRemotePresenter.IsChairInteracting(chairEntity))
			{
				return;
			}
			if (!this.TryShowInitialSeatedChair(chairEntity))
			{
				this.StartInitialRestoreRetry(chairEntity);
			}
		}

		// Token: 0x0602D5D1 RID: 185809 RVA: 0x00A3B950 File Offset: 0x00A39B50
		private void StartRemoteSitListen(Entity chairEntity)
		{
			this.StopRemoteSitListen();
			if (!chairEntity.Valid)
			{
				return;
			}
			EventSystem.Instance.AddWithTarget<IReadOnlyList<int>, IReadOnlyList<int>>(chairEntity, EEventName.OnLevelTagChanged, new Action<IReadOnlyList<int>, IReadOnlyList<int>>(this.OnChairInteractTagChanged));
			this.RemoteSitListenChairEntity = chairEntity;
		}

		// Token: 0x0602D5D2 RID: 185810 RVA: 0x00A3B985 File Offset: 0x00A39B85
		private void StopRemoteSitListen()
		{
			if (this.RemoteSitListenChairEntity == null)
			{
				return;
			}
			EventSystem.Instance.RemoveWithTarget<IReadOnlyList<int>, IReadOnlyList<int>>(this.RemoteSitListenChairEntity, EEventName.OnLevelTagChanged, new Action<IReadOnlyList<int>, IReadOnlyList<int>>(this.OnChairInteractTagChanged));
			this.RemoteSitListenChairEntity = null;
		}

		// Token: 0x0602D5D3 RID: 185811 RVA: 0x00A3B9BC File Offset: 0x00A39BBC
		private unsafe void OnChairInteractTagChanged(IReadOnlyList<int> addedTags, IReadOnlyList<int> removedTags)
		{
			Entity remoteSitListenChairEntity = this.RemoteSitListenChairEntity;
			if (remoteSitListenChairEntity == null || !remoteSitListenChairEntity.Valid)
			{
				return;
			}
			bool flag = addedTags.Contains(ChairRemotePresenter.ChairInteractingTagId);
			bool flag2 = removedTags.Contains(ChairRemotePresenter.ChairInteractingTagId);
			if (!flag && !flag2)
			{
				return;
			}
			if (!this.<host>P.IsChairShown)
			{
				return;
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[PlayerFollowerChairHandler.Remote] 交互 tag 变化, 切换椅子坐下/起身表现态";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Added", flag);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Removed", flag2);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			this.<host>P.ChangeChairPerformanceState(remoteSitListenChairEntity, flag ? EChairPerformanceState.Seated : EChairPerformanceState.StoodUp);
		}

		// Token: 0x0602D5D4 RID: 185812 RVA: 0x00A3BA84 File Offset: 0x00A39C84
		private bool TryShowInitialSeatedChair(Entity chairEntity)
		{
			if (!chairEntity.Valid || this.<host>P.ChairCreatureDataId <= 0L || this.<host>P.IsChairShown)
			{
				return false;
			}
			if (!ChairRemotePresenter.IsChairInteracting(chairEntity))
			{
				return false;
			}
			Entity summonerRoleEntity = this.GetSummonerRoleEntity(chairEntity);
			if (summonerRoleEntity == null || !summonerRoleEntity.Valid)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[PlayerFollowerChairHandler.Remote] 初始带交互 tag 但召唤者角色未就绪, 等广播协议接管";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChairCreatureDataId", this.<host>P.ChairCreatureDataId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SceneItem;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "[PlayerFollowerChairHandler.Remote] 椅子初始即带交互 tag, 反推摆放并显示";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ChairCreatureDataId", this.<host>P.ChairCreatureDataId);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			ChairRemotePresenter.PlaceChairRemoteBySeatedRole(chairEntity, summonerRoleEntity);
			this.ShowChairRemote(chairEntity);
			return true;
		}

		// Token: 0x0602D5D5 RID: 185813 RVA: 0x00A3BB57 File Offset: 0x00A39D57
		private static bool IsChairInteracting(Entity chairEntity)
		{
			LevelTagComponent component = chairEntity.GetComponent<LevelTagComponent>();
			return component != null && component.HasTag(ChairRemotePresenter.ChairInteractingTagId);
		}

		// Token: 0x0602D5D6 RID: 185814 RVA: 0x00A3BB70 File Offset: 0x00A39D70
		private unsafe static void PlaceChairRemoteBySeatedRole(Entity chairEntity, Entity roleEntity)
		{
			BaseActorComponent component = chairEntity.GetComponent<BaseActorComponent>();
			PawnInteractNewComponent component2 = chairEntity.GetComponent<PawnInteractNewComponent>();
			BaseActorComponent component3 = roleEntity.GetComponent<BaseActorComponent>();
			BaseCharacterComponent component4 = roleEntity.GetComponent<BaseCharacterComponent>();
			if (component == null || component2 == null || component3 == null || component4 == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[PlayerFollowerChairHandler.Remote] PlaceChairRemoteBySeatedRole: 组件缺失, 跳过摆放";
				<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HasChairActor", component != null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("HasInteractComp", component2 != null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HasRoleActor", component3 != null);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("HasRoleCharComp", component4 != null);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
				return;
			}
			float yaw = component3.ActorRotationProxy.Yaw - 90f;
			global::Rotator rotator = global::Rotator.Create(0f, yaw, 0f);
			global::Vector vector = global::Vector.Create(component3.ActorLocationProxy);
			vector.Z -= (double)component4.ScaledHalfHeight;
			component.SetActorLocationAndRotation(vector.ToUeVector(false), rotator.ToUeRotator(), "PlayerFollowerChairHandler.RemotePlacePre", false, null);
			global::Vector interactPoint = component2.GetInteractPoint();
			global::Vector vector2 = global::Vector.Create(vector);
			if (interactPoint == null)
			{
				return;
			}
			vector2.X += vector.X - interactPoint.X;
			vector2.Y += vector.Y - interactPoint.Y;
			vector2.Z += vector.Z - interactPoint.Z;
			component.SetActorLocationAndRotation(vector2.ToUeVector(false), rotator.ToUeRotator(), "PlayerFollowerChairHandler.RemotePlace", false, null);
		}

		// Token: 0x0602D5D7 RID: 185815 RVA: 0x00A3BD50 File Offset: 0x00A39F50
		[NullableContext(2)]
		public unsafe void OnRemotePresentationNotify(long chairCreatureDataId, bool isShow, Aki.Protocol.Vector location, Aki.Protocol.Rotator rotation)
		{
			if (this.<host>P.IsLocalOwner())
			{
				return;
			}
			if (this.<host>P.ChairCreatureDataId <= 0L || this.<host>P.ChairCreatureDataId != chairCreatureDataId)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[PlayerFollowerChairHandler.Remote] 椅子表现 Notify id 不匹配, 忽略";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("NotifyChairId", chairCreatureDataId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CurrentChairId", this.<host>P.ChairCreatureDataId);
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.StopInitialRestoreRetry();
			EntityHandle entity = CreatureModel.Instance.GetEntity(this.<host>P.ChairCreatureDataId);
			WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
			if (worldEntity == null || !worldEntity.Valid)
			{
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.SceneItem;
			ELogAuthor author2 = ELogAuthor.CK;
			string message2 = "[PlayerFollowerChairHandler.Remote] 收到椅子表现 Notify";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("ChairCreatureDataId", chairCreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("IsShow", isShow);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			if (!isShow)
			{
				this.HideChairRemote("PlayerFollowerChairHandler.RemotePresentationHide");
				return;
			}
			if (!this.<host>P.IsChairShown || ChairRemotePresenter.NeedReapplyChairTransform(worldEntity, location, rotation))
			{
				this.PlaceChairRemoteByProtocol(worldEntity, location, rotation);
				this.ShowChairRemote(worldEntity);
				return;
			}
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.SceneItem;
			ELogAuthor author3 = ELogAuthor.CK;
			string message3 = "[PlayerFollowerChairHandler.Remote] 椅子已显示且位置基本一致, 跳过重设";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChairCreatureDataId", chairCreatureDataId);
			instance3.Info(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			CreatureController.Instance.SetEntityEnable(worldEntity, true, "PlayerFollowerChairHandler.RemoteEnsureShown", false);
		}

		// Token: 0x0602D5D8 RID: 185816 RVA: 0x00A3BF08 File Offset: 0x00A3A108
		[NullableContext(2)]
		private static bool NeedReapplyChairTransform([Nullable(1)] Entity chairEntity, Aki.Protocol.Vector location, Aki.Protocol.Rotator rotation)
		{
			if (location == null || rotation == null)
			{
				return false;
			}
			BaseActorComponent component = chairEntity.GetComponent<BaseActorComponent>();
			if (component == null)
			{
				return false;
			}
			global::Vector v = global::Vector.Create((double)location.X, (double)location.Y, (double)location.Z);
			return global::Vector.DistSquared(component.ActorLocationProxy, v) > 625.0 || Math.Abs(global::Rotator.NormalizeAxis(rotation.Yaw - component.ActorRotationProxy.Yaw)) > 5f;
		}

		// Token: 0x0602D5D9 RID: 185817 RVA: 0x00A3BF80 File Offset: 0x00A3A180
		[NullableContext(2)]
		private void PlaceChairRemoteByProtocol([Nullable(1)] Entity chairEntity, Aki.Protocol.Vector location, Aki.Protocol.Rotator rotation)
		{
			if (location == null || rotation == null)
			{
				return;
			}
			BaseActorComponent component = chairEntity.GetComponent<BaseActorComponent>();
			if (component == null)
			{
				return;
			}
			global::Vector vector = global::Vector.Create((double)location.X, (double)location.Y, (double)location.Z);
			global::Rotator rotator = global::Rotator.Create(rotation.Pitch, rotation.Yaw, rotation.Roll);
			component.SetActorLocationAndRotation(vector.ToUeVector(false), rotator.ToUeRotator(), "PlayerFollowerChairHandler.RemotePresentationPlace", false, null);
		}

		// Token: 0x0602D5DA RID: 185818 RVA: 0x00A3BFF8 File Offset: 0x00A3A1F8
		private void ShowChairRemote(Entity chairEntity)
		{
			this.StopInitialRestoreRetry();
			if (!this.<host>P.IsChairShown)
			{
				this.<host>P.ChangeChairPerformanceState(chairEntity, EChairPerformanceState.Init);
				this.<host>P.IsChairShown = true;
				Log instance = Log.Instance;
				ELogModule module = ELogModule.SceneItem;
				ELogAuthor author = ELogAuthor.CK;
				string message = "[PlayerFollowerChairHandler.Remote] 远端显示椅子";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ChairId", chairEntity.Id);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			CreatureController.Instance.SetEntityEnable(chairEntity, true, "PlayerFollowerChairHandler.ShowChairRemote", false);
			long chairCreatureDataId = this.<host>P.ChairCreatureDataId;
			TimerSystem.Instance.Next(delegate(float _)
			{
				if (!chairEntity.Valid || !this.<host>P.IsChairShown || this.<host>P.ChairCreatureDataId != chairCreatureDataId || this.RemoteSitListenChairEntity != chairEntity)
				{
					return;
				}
				LevelTagComponent component = chairEntity.GetComponent<LevelTagComponent>();
				bool flag = component != null && component.HasTag(ChairRemotePresenter.ChairInteractingTagId);
				this.<host>P.ChangeChairPerformanceState(chairEntity, flag ? EChairPerformanceState.Seated : EChairPerformanceState.StoodUp);
			}, null, null);
		}

		// Token: 0x0602D5DB RID: 185819 RVA: 0x00A3C0C8 File Offset: 0x00A3A2C8
		private unsafe void HideChairRemote(string reason)
		{
			this.StopInitialRestoreRetry();
			EntityHandle entity = CreatureModel.Instance.GetEntity(this.<host>P.ChairCreatureDataId);
			WorldEntity worldEntity = (entity != null) ? entity.Entity : null;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.SceneItem;
			ELogAuthor author = ELogAuthor.CK;
			string message = "[PlayerFollowerChairHandler.Remote] 远端隐藏椅子";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Reason", reason);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ChairCreatureDataId", this.<host>P.ChairCreatureDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("HasEntity", worldEntity != null);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			if (worldEntity != null)
			{
				this.<host>P.ChangeChairPerformanceState(worldEntity, EChairPerformanceState.Init);
				CreatureController.Instance.SetEntityEnable(worldEntity, false, reason, false);
			}
			this.<host>P.IsChairShown = false;
		}

		// Token: 0x0602D5DC RID: 185820 RVA: 0x00A3C1B0 File Offset: 0x00A3A3B0
		private void StartInitialRestoreRetry(Entity chairEntity)
		{
			if (this.InitialRestoreRetryTimer != null && this.InitialRestoreRetryTimer.Valid())
			{
				return;
			}
			this.InitialRestoreRetryTimer = TimerSystem.Instance.Forever(delegate(float _)
			{
				if (!chairEntity.Valid || this.RemoteSitListenChairEntity != chairEntity || !ChairRemotePresenter.IsChairInteracting(chairEntity))
				{
					this.StopInitialRestoreRetry();
					return;
				}
				if (this.TryShowInitialSeatedChair(chairEntity))
				{
					this.StopInitialRestoreRetry();
				}
			}, 500f, 1f, null, null, true);
		}

		// Token: 0x0602D5DD RID: 185821 RVA: 0x00A3C210 File Offset: 0x00A3A410
		private void StopInitialRestoreRetry()
		{
			if (this.InitialRestoreRetryTimer == null)
			{
				return;
			}
			TimerSystem.Instance.Remove(this.InitialRestoreRetryTimer);
			this.InitialRestoreRetryTimer = null;
		}

		// Token: 0x0602D5DE RID: 185822 RVA: 0x00A3C233 File Offset: 0x00A3A433
		public void StopRemoteVisibility()
		{
			this.StopRemoteSitListen();
			this.StopInitialRestoreRetry();
		}

		// Token: 0x040183EC RID: 99308
		[CompilerGenerated]
		private IChairPresentationHost <host>P = host;

		// Token: 0x040183ED RID: 99309
		private const float INITIAL_RESTORE_RETRY_INTERVAL_MS = 500f;

		// Token: 0x040183EE RID: 99310
		private const double CHAIR_REAPPLY_DIST_SQUARED_THRESHOLD = 625.0;

		// Token: 0x040183EF RID: 99311
		private const float CHAIR_REAPPLY_YAW_THRESHOLD_DEG = 5f;

		// Token: 0x040183F0 RID: 99312
		private static readonly int ChairInteractingTagId = GameplayTagDefine.EGameplayTagId["关卡.Common.状态.场景物件交互中"];

		// Token: 0x040183F1 RID: 99313
		[Nullable(2)]
		private TimerHandle InitialRestoreRetryTimer;

		// Token: 0x040183F2 RID: 99314
		[Nullable(2)]
		private Entity RemoteSitListenChairEntity;
	}
}
