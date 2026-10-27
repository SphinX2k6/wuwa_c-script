using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WuwaGo
{
	// Token: 0x02004718 RID: 18200
	[NullableContext(1)]
	[Nullable(0)]
	public class WuWaGoFactory : IStaticVariableResetter
	{
		// Token: 0x0602F8DA RID: 194778 RVA: 0x00B039BA File Offset: 0x00B01BBA
		static WuWaGoFactory()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(WuWaGoFactory.CreateStaticDefaultValue), new Action(WuWaGoFactory.ResetStaticDefaultValue));
		}

		// Token: 0x0602F8DB RID: 194779 RVA: 0x00B039D9 File Offset: 0x00B01BD9
		public static void CreateStaticDefaultValue()
		{
			WuWaGoFactory._attackHitListeners = new Dictionary<AActor, Action>();
		}

		// Token: 0x0602F8DC RID: 194780 RVA: 0x00B039E5 File Offset: 0x00B01BE5
		public static void ResetStaticDefaultValue()
		{
			WuWaGoFactory._attackHitListeners = null;
		}

		// Token: 0x0602F8DD RID: 194781 RVA: 0x00B039ED File Offset: 0x00B01BED
		public static void RegisterAttackHitListener([Nullable(2)] AActor actor, Action listener)
		{
			if (actor == null || !actor.IsValid())
			{
				return;
			}
			WuWaGoFactory._attackHitListeners[actor] = listener;
		}

		// Token: 0x0602F8DE RID: 194782 RVA: 0x00B03A0D File Offset: 0x00B01C0D
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

		// Token: 0x0602F8DF RID: 194783 RVA: 0x00B03A34 File Offset: 0x00B01C34
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

		// Token: 0x0602F8E0 RID: 194784 RVA: 0x00B03A70 File Offset: 0x00B01C70
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

		// Token: 0x0602F8E1 RID: 194785 RVA: 0x00B03AC3 File Offset: 0x00B01CC3
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

		// Token: 0x0602F8E2 RID: 194786 RVA: 0x00B03AE4 File Offset: 0x00B01CE4
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

		// Token: 0x0602F8E3 RID: 194787 RVA: 0x00B03B40 File Offset: 0x00B01D40
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

		// Token: 0x0602F8E4 RID: 194788 RVA: 0x00B03B94 File Offset: 0x00B01D94
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

		// Token: 0x0602F8E5 RID: 194789 RVA: 0x00B03BEF File Offset: 0x00B01DEF
		public static bool DestroyApplique(AActor actor)
		{
			return ActorSystem.Instance.Put("WuWaGoFactory.DestroyApplique", actor, null);
		}

		// Token: 0x04019B00 RID: 105216
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<AActor, Action> _attackHitListeners;
	}
}
