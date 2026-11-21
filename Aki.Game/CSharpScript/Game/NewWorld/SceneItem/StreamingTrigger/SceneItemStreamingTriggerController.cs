using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.StreamingTrigger
{
	// Token: 0x02006256 RID: 25174
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class SceneItemStreamingTriggerController : ControllerBase
	{
		// Token: 0x0603CBE2 RID: 248802 RVA: 0x01170DE8 File Offset: 0x0116EFE8
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

		// Token: 0x0603CBE3 RID: 248803 RVA: 0x01170E2C File Offset: 0x0116F02C
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

		// Token: 0x0603CBE4 RID: 248804 RVA: 0x01170E64 File Offset: 0x0116F064
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

		// Token: 0x0603CBE5 RID: 248805 RVA: 0x01170EE0 File Offset: 0x0116F0E0
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

		// Token: 0x170072E9 RID: 29417
		// (get) Token: 0x0603CBE6 RID: 248806 RVA: 0x01171028 File Offset: 0x0116F228
		public static SceneItemStreamingTriggerController Instance
		{
			get
			{
				return SceneItemStreamingTriggerController._Instance;
			}
		}

		// Token: 0x0603CBE7 RID: 248807 RVA: 0x0117102F File Offset: 0x0116F22F
		public static SceneItemStreamingTriggerController GetOrCreateInstance()
		{
			if (SceneItemStreamingTriggerController._Instance == null)
			{
				SceneItemStreamingTriggerController.CreateInstance();
			}
			return SceneItemStreamingTriggerController._Instance;
		}

		// Token: 0x0603CBE8 RID: 248808 RVA: 0x01171043 File Offset: 0x0116F243
		public static bool CreateInstance()
		{
			if (SceneItemStreamingTriggerController._Instance != null)
			{
				return true;
			}
			SceneItemStreamingTriggerController._Instance = new SceneItemStreamingTriggerController();
			return true;
		}

		// Token: 0x0603CBE9 RID: 248809 RVA: 0x01171059 File Offset: 0x0116F259
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603CBEA RID: 248810 RVA: 0x0117105B File Offset: 0x0116F25B
		public static void ResetStaticDefaultValue()
		{
			SceneItemStreamingTriggerController._Instance = null;
		}

		// Token: 0x0603CBEB RID: 248811 RVA: 0x01171063 File Offset: 0x0116F263
		static SceneItemStreamingTriggerController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(SceneItemStreamingTriggerController.CreateStaticDefaultValue), new Action(SceneItemStreamingTriggerController.ResetStaticDefaultValue));
		}

		// Token: 0x0402034D RID: 131917
		private const int ARBITRATE_INTERVAL = 100;

		// Token: 0x0402034E RID: 131918
		[Nullable(2)]
		private static SceneItemStreamingTriggerController _Instance;
	}
}
