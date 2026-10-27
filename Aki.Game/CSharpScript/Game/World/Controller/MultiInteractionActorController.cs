using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using UnrealEngine;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x02004539 RID: 17721
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class MultiInteractionActorController : ControllerBase
	{
		// Token: 0x0602DCA8 RID: 187560 RVA: 0x00A86170 File Offset: 0x00A84370
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

		// Token: 0x0602DCA9 RID: 187561 RVA: 0x00A861CA File Offset: 0x00A843CA
		protected override bool OnClear()
		{
			this.ProcessRemainingActor();
			return true;
		}

		// Token: 0x0602DCAA RID: 187562 RVA: 0x00A861D3 File Offset: 0x00A843D3
		protected override bool OnLeaveLevel()
		{
			this.ProcessRemainingActor();
			return true;
		}

		// Token: 0x0602DCAB RID: 187563 RVA: 0x00A861DC File Offset: 0x00A843DC
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

		// Token: 0x0602DCAC RID: 187564 RVA: 0x00A86216 File Offset: 0x00A84416
		public void AddWaitDestroyActor(SceneInteractionActor actor)
		{
			this.WaitDestroyActors.Push(actor);
			AttachToActorController.Instance.DetachActor(actor, false, "MultiInteractionActorController.AddWaitDestroyActor", EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
		}

		// Token: 0x17007541 RID: 30017
		// (get) Token: 0x0602DCAD RID: 187565 RVA: 0x00A86239 File Offset: 0x00A84439
		public static MultiInteractionActorController Instance
		{
			get
			{
				return MultiInteractionActorController._Instance;
			}
		}

		// Token: 0x0602DCAE RID: 187566 RVA: 0x00A86240 File Offset: 0x00A84440
		public static MultiInteractionActorController GetOrCreateInstance()
		{
			if (MultiInteractionActorController._Instance == null)
			{
				MultiInteractionActorController.CreateInstance();
			}
			return MultiInteractionActorController._Instance;
		}

		// Token: 0x0602DCAF RID: 187567 RVA: 0x00A86254 File Offset: 0x00A84454
		public static bool CreateInstance()
		{
			if (MultiInteractionActorController._Instance != null)
			{
				return true;
			}
			MultiInteractionActorController._Instance = new MultiInteractionActorController();
			return true;
		}

		// Token: 0x0602DCB0 RID: 187568 RVA: 0x00A8626A File Offset: 0x00A8446A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DCB1 RID: 187569 RVA: 0x00A8626C File Offset: 0x00A8446C
		public static void ResetStaticDefaultValue()
		{
			MultiInteractionActorController._Instance = null;
		}

		// Token: 0x0602DCB2 RID: 187570 RVA: 0x00A86274 File Offset: 0x00A84474
		static MultiInteractionActorController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MultiInteractionActorController.CreateStaticDefaultValue), new Action(MultiInteractionActorController.ResetStaticDefaultValue));
		}

		// Token: 0x0401874A RID: 100170
		private const int MAX_DESTROY_TIME = 3;

		// Token: 0x0401874B RID: 100171
		private readonly Queue<SceneInteractionActor> WaitDestroyActors = new Queue<SceneInteractionActor>(4);

		// Token: 0x0401874C RID: 100172
		[Nullable(2)]
		private static MultiInteractionActorController _Instance;
	}
}
