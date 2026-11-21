using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.GravityFlip
{
	// Token: 0x02005F99 RID: 24473
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class GravityFlipController : UiControllerBase
	{
		// Token: 0x0603ACE2 RID: 240866 RVA: 0x010A046F File Offset: 0x0109E66F
		public void OnChangeGravityDirection(EGravityDirection offsetAngle)
		{
			SceneItemGravityFlipComponent gravityFlipComp = GravityFlipModel.Instance.GravityFlipComp;
			if (gravityFlipComp == null)
			{
				return;
			}
			gravityFlipComp.UpdatePrefabState(false);
		}

		// Token: 0x0603ACE3 RID: 240867 RVA: 0x010A0486 File Offset: 0x0109E686
		public void ListenTeleportCompleteEvent(Action<int> callback)
		{
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
			this.TeleportCompleteCallback = callback;
		}

		// Token: 0x0603ACE4 RID: 240868 RVA: 0x010A04AB File Offset: 0x0109E6AB
		private void OnTeleportComplete(TeleportContext context = null)
		{
			EventSystem.Instance.Remove(EEventName.TeleportComplete, new <>f__AnonymousDelegate11<TeleportContext>(this.OnTeleportComplete));
			Action<int> teleportCompleteCallback = this.TeleportCompleteCallback;
			if (teleportCompleteCallback == null)
			{
				return;
			}
			teleportCompleteCallback(3);
		}

		// Token: 0x0603ACE5 RID: 240869 RVA: 0x010A04DC File Offset: 0x0109E6DC
		public void CancelWaitTeleport()
		{
			if (EventSystem.Instance.Has(EEventName.TeleportComplete, new <>f__AnonymousDelegate11<TeleportContext>(this.OnTeleportComplete)))
			{
				EventSystem.Instance.Remove(EEventName.TeleportComplete, new <>f__AnonymousDelegate11<TeleportContext>(this.OnTeleportComplete));
			}
			Action<int> teleportCompleteCallback = this.TeleportCompleteCallback;
			if (teleportCompleteCallback == null)
			{
				return;
			}
			teleportCompleteCallback(3);
		}

		// Token: 0x17006EF9 RID: 28409
		// (get) Token: 0x0603ACE6 RID: 240870 RVA: 0x010A0533 File Offset: 0x0109E733
		[Nullable(1)]
		public static GravityFlipController Instance
		{
			[NullableContext(1)]
			get
			{
				return GravityFlipController._Instance;
			}
		}

		// Token: 0x0603ACE7 RID: 240871 RVA: 0x010A053A File Offset: 0x0109E73A
		[NullableContext(1)]
		public static GravityFlipController GetOrCreateInstance()
		{
			if (GravityFlipController._Instance == null)
			{
				GravityFlipController.CreateInstance();
			}
			return GravityFlipController._Instance;
		}

		// Token: 0x0603ACE8 RID: 240872 RVA: 0x010A054E File Offset: 0x0109E74E
		public static bool CreateInstance()
		{
			if (GravityFlipController._Instance != null)
			{
				return true;
			}
			GravityFlipController._Instance = new GravityFlipController();
			return true;
		}

		// Token: 0x0603ACE9 RID: 240873 RVA: 0x010A0564 File Offset: 0x0109E764
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603ACEA RID: 240874 RVA: 0x010A0566 File Offset: 0x0109E766
		public static void ResetStaticDefaultValue()
		{
			GravityFlipController._Instance = null;
		}

		// Token: 0x0603ACEB RID: 240875 RVA: 0x010A056E File Offset: 0x0109E76E
		static GravityFlipController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GravityFlipController.CreateStaticDefaultValue), new Action(GravityFlipController.ResetStaticDefaultValue));
		}

		// Token: 0x0401EE8F RID: 126607
		private Action<int> TeleportCompleteCallback;

		// Token: 0x0401EE90 RID: 126608
		private static GravityFlipController _Instance;
	}
}
