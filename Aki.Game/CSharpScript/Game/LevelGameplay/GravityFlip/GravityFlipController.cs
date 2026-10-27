using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.LevelGamePlay.GravityFlip
{
	// Token: 0x02006E19 RID: 28185
	[NullableContext(2)]
	[Nullable(0)]
	[Controller(0)]
	public class GravityFlipController : UiControllerBase
	{
		// Token: 0x06044B79 RID: 281465 RVA: 0x010F5F33 File Offset: 0x010F4133
		public void OnChangeGravityDirection(EGravityDirection offsetAngle)
		{
			SceneItemGravityFlipComponent gravityFlipComp = GravityFlipModel.Instance.GravityFlipComp;
			if (gravityFlipComp == null)
			{
				return;
			}
			gravityFlipComp.UpdatePrefabState(false);
		}

		// Token: 0x06044B7A RID: 281466 RVA: 0x010F5F4A File Offset: 0x010F414A
		public void ListenTeleportCompleteEvent(Action<int> callback)
		{
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
			this.TeleportCompleteCallback = callback;
		}

		// Token: 0x06044B7B RID: 281467 RVA: 0x010F5F6F File Offset: 0x010F416F
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

		// Token: 0x06044B7C RID: 281468 RVA: 0x010F5FA0 File Offset: 0x010F41A0
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

		// Token: 0x170099F6 RID: 39414
		// (get) Token: 0x06044B7D RID: 281469 RVA: 0x010F5FF7 File Offset: 0x010F41F7
		[Nullable(1)]
		public static GravityFlipController Instance
		{
			[NullableContext(1)]
			get
			{
				return GravityFlipController._Instance;
			}
		}

		// Token: 0x06044B7E RID: 281470 RVA: 0x010F5FFE File Offset: 0x010F41FE
		[NullableContext(1)]
		public static GravityFlipController GetOrCreateInstance()
		{
			if (GravityFlipController._Instance == null)
			{
				GravityFlipController.CreateInstance();
			}
			return GravityFlipController._Instance;
		}

		// Token: 0x06044B7F RID: 281471 RVA: 0x010F6012 File Offset: 0x010F4212
		public static bool CreateInstance()
		{
			if (GravityFlipController._Instance != null)
			{
				return true;
			}
			GravityFlipController._Instance = new GravityFlipController();
			return true;
		}

		// Token: 0x06044B80 RID: 281472 RVA: 0x010F6028 File Offset: 0x010F4228
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06044B81 RID: 281473 RVA: 0x010F602A File Offset: 0x010F422A
		public static void ResetStaticDefaultValue()
		{
			GravityFlipController._Instance = null;
		}

		// Token: 0x06044B82 RID: 281474 RVA: 0x010F6032 File Offset: 0x010F4232
		static GravityFlipController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GravityFlipController.CreateStaticDefaultValue), new Action(GravityFlipController.ResetStaticDefaultValue));
		}

		// Token: 0x04023BEC RID: 146412
		private Action<int> TeleportCompleteCallback;

		// Token: 0x04023BED RID: 146413
		private static GravityFlipController _Instance;
	}
}
