using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.StreamingTrigger
{
	// Token: 0x020071A1 RID: 29089
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SceneItemStreamingTriggerController : ControllerBase
	{
		// Token: 0x060472EA RID: 291562 RVA: 0x01216E84 File Offset: 0x01215084
		public void Register(SceneItemStreamingTriggerComponent trigger)
		{
			SceneItemStreamingTriggerModel instance;
			SceneItemStreamingTriggerModel sceneItemStreamingTriggerModel = instance = SceneItemStreamingTriggerModel.Instance;
			if (instance.Triggers == null)
			{
				instance.Triggers = new HashSet<SceneItemStreamingTriggerComponent>();
			}
			if (!sceneItemStreamingTriggerModel.Triggers.Add(trigger))
			{
				return;
			}
			this.RefreshTimer();
			this.OnRefresh();
		}

		// Token: 0x060472EB RID: 291563 RVA: 0x01216EC8 File Offset: 0x012150C8
		public void Unregister(SceneItemStreamingTriggerComponent trigger)
		{
			SceneItemStreamingTriggerModel instance = SceneItemStreamingTriggerModel.Instance;
			if (instance.Triggers == null || !instance.Triggers.Remove(trigger))
			{
				return;
			}
			this.OnRefresh();
			this.RefreshTimer();
		}

		// Token: 0x060472EC RID: 291564 RVA: 0x01216F00 File Offset: 0x01215100
		private void RefreshTimer()
		{
			SceneItemStreamingTriggerModel instance = SceneItemStreamingTriggerModel.Instance;
			HashSet<SceneItemStreamingTriggerComponent> triggers = instance.Triggers;
			bool flag = ((triggers != null) ? triggers.Count : 0) > 1;
			if (flag == (instance.TimerHandle != null))
			{
				return;
			}
			if (flag)
			{
				instance.TimerHandle = TimerSystem.Instance.Forever(delegate(float _)
				{
					this.OnRefresh();
				}, 100f, 1f, null, "SceneItemStreamingTriggerArbitrate", true);
				return;
			}
			instance.TimerHandle.Remove();
			instance.TimerHandle = null;
		}

		// Token: 0x060472ED RID: 291565 RVA: 0x01216F7C File Offset: 0x0121517C
		private void OnRefresh()
		{
			HashSet<SceneItemStreamingTriggerComponent> triggers = SceneItemStreamingTriggerModel.Instance.Triggers;
			if (triggers == null || triggers.Count == 0)
			{
				return;
			}
			if (triggers.Count == 1)
			{
				foreach (SceneItemStreamingTriggerComponent sceneItemStreamingTriggerComponent in triggers)
				{
					sceneItemStreamingTriggerComponent.NotifyApplyStreamingSource(true);
				}
				return;
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			Vector vector;
			if (baseCharacter == null)
			{
				vector = null;
			}
			else
			{
				CharacterActorComponent characterActorComponent = baseCharacter.CharacterActorComponent;
				vector = ((characterActorComponent != null) ? characterActorComponent.ActorLocationProxy : null);
			}
			Vector vector2 = vector;
			if (vector2 == null)
			{
				return;
			}
			SceneItemStreamingTriggerComponent sceneItemStreamingTriggerComponent2 = null;
			double num = double.MaxValue;
			foreach (SceneItemStreamingTriggerComponent sceneItemStreamingTriggerComponent3 in triggers)
			{
				Vector worldLocation = sceneItemStreamingTriggerComponent3.GetWorldLocation();
				if (worldLocation != null)
				{
					double num2 = Vector.DistSquared(worldLocation, vector2);
					if (num2 < num)
					{
						num = num2;
						sceneItemStreamingTriggerComponent2 = sceneItemStreamingTriggerComponent3;
					}
				}
			}
			foreach (SceneItemStreamingTriggerComponent sceneItemStreamingTriggerComponent4 in triggers)
			{
				if (sceneItemStreamingTriggerComponent4 != sceneItemStreamingTriggerComponent2)
				{
					sceneItemStreamingTriggerComponent4.NotifyApplyStreamingSource(false);
				}
			}
			if (sceneItemStreamingTriggerComponent2 != null)
			{
				sceneItemStreamingTriggerComponent2.NotifyApplyStreamingSource(true);
			}
		}

		// Token: 0x17009D9C RID: 40348
		// (get) Token: 0x060472EE RID: 291566 RVA: 0x012170C4 File Offset: 0x012152C4
		public static SceneItemStreamingTriggerController Instance
		{
			get
			{
				return SceneItemStreamingTriggerController._Instance;
			}
		}

		// Token: 0x060472EF RID: 291567 RVA: 0x012170CB File Offset: 0x012152CB
		public static SceneItemStreamingTriggerController GetOrCreateInstance()
		{
			if (SceneItemStreamingTriggerController._Instance == null)
			{
				SceneItemStreamingTriggerController.CreateInstance();
			}
			return SceneItemStreamingTriggerController._Instance;
		}

		// Token: 0x060472F0 RID: 291568 RVA: 0x012170DF File Offset: 0x012152DF
		public static bool CreateInstance()
		{
			if (SceneItemStreamingTriggerController._Instance != null)
			{
				return true;
			}
			SceneItemStreamingTriggerController._Instance = new SceneItemStreamingTriggerController();
			return true;
		}

		// Token: 0x060472F1 RID: 291569 RVA: 0x012170F5 File Offset: 0x012152F5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060472F2 RID: 291570 RVA: 0x012170F7 File Offset: 0x012152F7
		public static void ResetStaticDefaultValue()
		{
			SceneItemStreamingTriggerController._Instance = null;
		}

		// Token: 0x060472F3 RID: 291571 RVA: 0x012170FF File Offset: 0x012152FF
		static SceneItemStreamingTriggerController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemStreamingTriggerController.CreateStaticDefaultValue), new Action(SceneItemStreamingTriggerController.ResetStaticDefaultValue));
		}

		// Token: 0x040256DE RID: 153310
		private const int ARBITRATE_INTERVAL = 100;

		// Token: 0x040256DF RID: 153311
		[Nullable(2)]
		private static SceneItemStreamingTriggerController _Instance;
	}
}
