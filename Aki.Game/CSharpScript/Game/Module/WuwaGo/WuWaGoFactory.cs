using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02003648 RID: 13896
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoFactory : IStaticVariableResetter
	{
		// Token: 0x060240A0 RID: 147616 RVA: 0x00A3368A File Offset: 0x00A3188A
		static WuWaGoFactory()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuWaGoFactory.CreateStaticDefaultValue), new Action(WuWaGoFactory.ResetStaticDefaultValue));
		}

		// Token: 0x060240A1 RID: 147617 RVA: 0x00A336A9 File Offset: 0x00A318A9
		public static void CreateStaticDefaultValue()
		{
			WuWaGoFactory._attackHitListeners = new Dictionary<AActor, Action>();
		}

		// Token: 0x060240A2 RID: 147618 RVA: 0x00A336B5 File Offset: 0x00A318B5
		public static void ResetStaticDefaultValue()
		{
			WuWaGoFactory._attackHitListeners = null;
		}

		// Token: 0x060240A3 RID: 147619 RVA: 0x00A336BD File Offset: 0x00A318BD
		public static void RegisterAttackHitListener([Nullable(2)] AActor actor, Action listener)
		{
			if (actor == null || !actor.IsValid())
			{
				return;
			}
			WuWaGoFactory._attackHitListeners[actor] = listener;
		}

		// Token: 0x060240A4 RID: 147620 RVA: 0x00A336DD File Offset: 0x00A318DD
		[NullableContext(2)]
		public static void UnregisterAttackHitListener(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				return;
			}
			Dictionary<AActor, Action> attackHitListeners = WuWaGoFactory._attackHitListeners;
			if (attackHitListeners == null)
			{
				return;
			}
			attackHitListeners.Remove(actor);
		}

		// Token: 0x060240A5 RID: 147621 RVA: 0x00A33704 File Offset: 0x00A31904
		[NullableContext(2)]
		public static void DispatchAttackHit(AActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				return;
			}
			Action action;
			if (WuWaGoFactory._attackHitListeners != null && WuWaGoFactory._attackHitListeners.TryGetValue(actor, out action))
			{
				action();
			}
		}

		// Token: 0x060240A6 RID: 147622 RVA: 0x00A33740 File Offset: 0x00A31940
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static UniTask<TsBaseCharacter> CreateRole(EWuWaGoRoleType type, Vector position, Rotator rotator)
		{
			WuWaGoFactory.<CreateRole>d__7 <CreateRole>d__;
			<CreateRole>d__.<>t__builder = AsyncUniTaskMethodBuilder<TsBaseCharacter>.Create();
			<CreateRole>d__.type = type;
			<CreateRole>d__.position = position;
			<CreateRole>d__.rotator = rotator;
			<CreateRole>d__.<>1__state = -1;
			<CreateRole>d__.<>t__builder.Start<WuWaGoFactory.<CreateRole>d__7>(ref <CreateRole>d__);
			return <CreateRole>d__.<>t__builder.Task;
		}

		// Token: 0x060240A7 RID: 147623 RVA: 0x00A33793 File Offset: 0x00A31993
		public static bool DestroyRole(AActor actor)
		{
			CharRenderingComponent charRenderingComponent = ((TsBaseCharacter)actor).CharRenderingComponent;
			if (charRenderingComponent != null)
			{
				charRenderingComponent.Destroy();
			}
			UObjectPool.DespawnActor(actor, false);
			return true;
		}

		// Token: 0x060240A8 RID: 147624 RVA: 0x00A337B4 File Offset: 0x00A319B4
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static UniTask<AActor> CreateGridLinkApplique(EWuWaGoGridLinkType gridLinkType, Vector position, Rotator rotator, [Nullable(2)] UStaticMesh mesh)
		{
			WuWaGoFactory.<CreateGridLinkApplique>d__9 <CreateGridLinkApplique>d__;
			<CreateGridLinkApplique>d__.<>t__builder = AsyncUniTaskMethodBuilder<AActor>.Create();
			<CreateGridLinkApplique>d__.gridLinkType = gridLinkType;
			<CreateGridLinkApplique>d__.position = position;
			<CreateGridLinkApplique>d__.rotator = rotator;
			<CreateGridLinkApplique>d__.mesh = mesh;
			<CreateGridLinkApplique>d__.<>1__state = -1;
			<CreateGridLinkApplique>d__.<>t__builder.Start<WuWaGoFactory.<CreateGridLinkApplique>d__9>(ref <CreateGridLinkApplique>d__);
			return <CreateGridLinkApplique>d__.<>t__builder.Task;
		}

		// Token: 0x060240A9 RID: 147625 RVA: 0x00A33810 File Offset: 0x00A31A10
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public static UniTask<AActor> CreateCanMoveTipsApplique(Vector position, Rotator rotator, [Nullable(2)] UStaticMesh mesh)
		{
			WuWaGoFactory.<CreateCanMoveTipsApplique>d__10 <CreateCanMoveTipsApplique>d__;
			<CreateCanMoveTipsApplique>d__.<>t__builder = AsyncUniTaskMethodBuilder<AActor>.Create();
			<CreateCanMoveTipsApplique>d__.position = position;
			<CreateCanMoveTipsApplique>d__.rotator = rotator;
			<CreateCanMoveTipsApplique>d__.mesh = mesh;
			<CreateCanMoveTipsApplique>d__.<>1__state = -1;
			<CreateCanMoveTipsApplique>d__.<>t__builder.Start<WuWaGoFactory.<CreateCanMoveTipsApplique>d__10>(ref <CreateCanMoveTipsApplique>d__);
			return <CreateCanMoveTipsApplique>d__.<>t__builder.Task;
		}

		// Token: 0x060240AA RID: 147626 RVA: 0x00A33864 File Offset: 0x00A31A64
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		private static UniTask<AActor> CreateApplique(string materialPath, Vector position, Rotator rotator, [Nullable(2)] UStaticMesh mesh)
		{
			WuWaGoFactory.<CreateApplique>d__11 <CreateApplique>d__;
			<CreateApplique>d__.<>t__builder = AsyncUniTaskMethodBuilder<AActor>.Create();
			<CreateApplique>d__.materialPath = materialPath;
			<CreateApplique>d__.position = position;
			<CreateApplique>d__.rotator = rotator;
			<CreateApplique>d__.mesh = mesh;
			<CreateApplique>d__.<>1__state = -1;
			<CreateApplique>d__.<>t__builder.Start<WuWaGoFactory.<CreateApplique>d__11>(ref <CreateApplique>d__);
			return <CreateApplique>d__.<>t__builder.Task;
		}

		// Token: 0x060240AB RID: 147627 RVA: 0x00A338BF File Offset: 0x00A31ABF
		public static bool DestroyApplique(AActor actor)
		{
			return ActorSystem.Instance.Put("WuWaGoFactory.DestroyApplique", actor, null);
		}

		// Token: 0x040141AF RID: 82351
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<AActor, Action> _attackHitListeners;
	}
}
