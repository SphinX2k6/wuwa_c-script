using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using UnrealEngine;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x02003461 RID: 13409
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class MultiInteractionActorController : ControllerBase
	{
		// Token: 0x0602238A RID: 140170 RVA: 0x009B1998 File Offset: 0x009AFB98
		protected override void OnTick(float delta)
		{
			if (this.WaitDestroyActors.Size <= 0)
			{
				return;
			}
			int i = 0;
			while (i < 3)
			{
				if (this.WaitDestroyActors.Size <= 0)
				{
					return;
				}
				SceneInteractionActor sceneInteractionActor = this.WaitDestroyActors.Pop();
				if (sceneInteractionActor != null && sceneInteractionActor.IsValid())
				{
					sceneInteractionActor.DestroySelf();
					i++;
				}
			}
		}

		// Token: 0x0602238B RID: 140171 RVA: 0x009B19F2 File Offset: 0x009AFBF2
		protected override bool OnClear()
		{
			this.ProcessRemainingActor();
			return true;
		}

		// Token: 0x0602238C RID: 140172 RVA: 0x009B19FB File Offset: 0x009AFBFB
		protected override bool OnLeaveLevel()
		{
			this.ProcessRemainingActor();
			return true;
		}

		// Token: 0x0602238D RID: 140173 RVA: 0x009B1A04 File Offset: 0x009AFC04
		private void ProcessRemainingActor()
		{
			while (this.WaitDestroyActors.Size > 0)
			{
				SceneInteractionActor sceneInteractionActor = this.WaitDestroyActors.Pop();
				if (sceneInteractionActor != null && sceneInteractionActor.IsValid())
				{
					sceneInteractionActor.DestroySelf();
				}
			}
		}

		// Token: 0x0602238E RID: 140174 RVA: 0x009B1A3E File Offset: 0x009AFC3E
		public void AddWaitDestroyActor(SceneInteractionActor actor)
		{
			this.WaitDestroyActors.Push(actor);
			AttachToActorController.Instance.DetachActor(actor, false, "MultiInteractionActorController.AddWaitDestroyActor", EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		}

		// Token: 0x170047F8 RID: 18424
		// (get) Token: 0x0602238F RID: 140175 RVA: 0x009B1A61 File Offset: 0x009AFC61
		public static MultiInteractionActorController Instance
		{
			get
			{
				return MultiInteractionActorController._Instance;
			}
		}

		// Token: 0x06022390 RID: 140176 RVA: 0x009B1A68 File Offset: 0x009AFC68
		public static MultiInteractionActorController GetOrCreateInstance()
		{
			if (MultiInteractionActorController._Instance == null)
			{
				MultiInteractionActorController.CreateInstance();
			}
			return MultiInteractionActorController._Instance;
		}

		// Token: 0x06022391 RID: 140177 RVA: 0x009B1A7C File Offset: 0x009AFC7C
		public static bool CreateInstance()
		{
			if (MultiInteractionActorController._Instance != null)
			{
				return true;
			}
			MultiInteractionActorController._Instance = new MultiInteractionActorController();
			return true;
		}

		// Token: 0x06022392 RID: 140178 RVA: 0x009B1A92 File Offset: 0x009AFC92
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022393 RID: 140179 RVA: 0x009B1A94 File Offset: 0x009AFC94
		public static void ResetStaticDefaultValue()
		{
			MultiInteractionActorController._Instance = null;
		}

		// Token: 0x06022394 RID: 140180 RVA: 0x009B1A9C File Offset: 0x009AFC9C
		static MultiInteractionActorController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MultiInteractionActorController.CreateStaticDefaultValue), new Action(MultiInteractionActorController.ResetStaticDefaultValue));
		}

		// Token: 0x04012D84 RID: 77188
		private const int MAX_DESTROY_TIME = 3;

		// Token: 0x04012D85 RID: 77189
		private readonly Queue<SceneInteractionActor> WaitDestroyActors = new Queue<SceneInteractionActor>(4);

		// Token: 0x04012D86 RID: 77190
		[Nullable(2)]
		private static MultiInteractionActorController _Instance;
	}
}
