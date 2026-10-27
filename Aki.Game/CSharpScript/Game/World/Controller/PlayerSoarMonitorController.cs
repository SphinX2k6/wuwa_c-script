using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x0200453A RID: 17722
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class PlayerSoarMonitorController : ControllerBase
	{
		// Token: 0x17007542 RID: 30018
		// (get) Token: 0x0602DCB4 RID: 187572 RVA: 0x00A862A7 File Offset: 0x00A844A7
		// (set) Token: 0x0602DCB5 RID: 187573 RVA: 0x00A862AF File Offset: 0x00A844AF
		public bool IsPlayerSoar
		{
			get
			{
				return this.IsPlayerSoarInternal;
			}
			set
			{
				if (this.IsPlayerSoarInternal == value)
				{
					return;
				}
				this.IsPlayerSoarInternal = value;
				EventSystem.Instance.Emit<bool>(EEventName.PlayerSoarChanged, value);
			}
		}

		// Token: 0x17007543 RID: 30019
		// (get) Token: 0x0602DCB6 RID: 187574 RVA: 0x00A862D3 File Offset: 0x00A844D3
		public bool EnableSlowStreaming
		{
			get
			{
				return this.EnableSlowStreamingInternal;
			}
		}

		// Token: 0x0602DCB7 RID: 187575 RVA: 0x00A862DB File Offset: 0x00A844DB
		protected override bool OnInit()
		{
			this.PlayerSoarMonitorFilter = EntityToLoadFilter.Create();
			base.InitTickOptimize(60, -1);
			this.InitConsoleVariables();
			return base.OnInit();
		}

		// Token: 0x0602DCB8 RID: 187576 RVA: 0x00A862FD File Offset: 0x00A844FD
		private void InitConsoleVariables()
		{
			this.HeightThreshould = (float)UKismetSystemLibrary.GetConsoleVariableIntValue("wp.Runtime.SoraGridBlackListHeight");
			if (this.HeightThreshould <= 0f)
			{
				this.HeightThreshould = 1500f;
			}
		}

		// Token: 0x0602DCB9 RID: 187577 RVA: 0x00A86328 File Offset: 0x00A84528
		protected override void OnTick(float deltaTime)
		{
			this.CheckPlayerMoveState();
			this.CheckEnableSlowStreaming();
		}

		// Token: 0x0602DCBA RID: 187578 RVA: 0x00A86336 File Offset: 0x00A84536
		protected override bool OnClear()
		{
			this.PlayerSoarMonitorFilter.Cleanup();
			return base.OnClear();
		}

		// Token: 0x0602DCBB RID: 187579 RVA: 0x00A8634C File Offset: 0x00A8454C
		private void CheckPlayerMoveState()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null)
			{
				this.IsPlayerSoar = false;
				return;
			}
			CharacterUnifiedStateComponent component = getCurrentEntity.Entity.GetComponent<CharacterUnifiedStateComponent>();
			if (component == null)
			{
				this.IsPlayerSoar = false;
				return;
			}
			this.IsPlayerSoar = (component.MoveState == ECharMoveState.Soar);
		}

		// Token: 0x0602DCBC RID: 187580 RVA: 0x00A86398 File Offset: 0x00A84598
		private void CheckEnableSlowStreaming()
		{
			bool flag = this.IsPlayerSoar && this.CheckHeight();
			if (this.EnableSlowStreamingInternal != flag)
			{
				this.EnableSlowStreamingInternal = flag;
				EventSystem.Instance.Emit<bool>(EEventName.SlowStreamingBySoar, this.EnableSlowStreamingInternal);
			}
		}

		// Token: 0x0602DCBD RID: 187581 RVA: 0x00A863E0 File Offset: 0x00A845E0
		private bool CheckHeight()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null)
			{
				return false;
			}
			CharacterMoveComponent component = getCurrentEntity.Entity.GetComponent<CharacterMoveComponent>();
			return component != null && component.GetHeightAboveGround(this.HeightThreshould + 1f) > this.HeightThreshould;
		}

		// Token: 0x17007544 RID: 30020
		// (get) Token: 0x0602DCBE RID: 187582 RVA: 0x00A86428 File Offset: 0x00A84628
		public static PlayerSoarMonitorController Instance
		{
			get
			{
				return PlayerSoarMonitorController._Instance;
			}
		}

		// Token: 0x0602DCBF RID: 187583 RVA: 0x00A8642F File Offset: 0x00A8462F
		public static PlayerSoarMonitorController GetOrCreateInstance()
		{
			if (PlayerSoarMonitorController._Instance == null)
			{
				PlayerSoarMonitorController.CreateInstance();
			}
			return PlayerSoarMonitorController._Instance;
		}

		// Token: 0x0602DCC0 RID: 187584 RVA: 0x00A86443 File Offset: 0x00A84643
		public static bool CreateInstance()
		{
			if (PlayerSoarMonitorController._Instance != null)
			{
				return true;
			}
			PlayerSoarMonitorController._Instance = new PlayerSoarMonitorController();
			return true;
		}

		// Token: 0x0602DCC1 RID: 187585 RVA: 0x00A86459 File Offset: 0x00A84659
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DCC2 RID: 187586 RVA: 0x00A8645B File Offset: 0x00A8465B
		public static void ResetStaticDefaultValue()
		{
			PlayerSoarMonitorController._Instance = null;
		}

		// Token: 0x0602DCC3 RID: 187587 RVA: 0x00A86463 File Offset: 0x00A84663
		static PlayerSoarMonitorController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlayerSoarMonitorController.CreateStaticDefaultValue), new Action(PlayerSoarMonitorController.ResetStaticDefaultValue));
		}

		// Token: 0x0401874D RID: 100173
		public const int SLOW_STREAMING_HEIGHT_THRESHOULD = 1500;

		// Token: 0x0401874E RID: 100174
		private const string SLOW_STREAMING_HEIGHT_THRESHOULD_CVAR = "wp.Runtime.SoraGridBlackListHeight";

		// Token: 0x0401874F RID: 100175
		public const bool ENABLE_SLOW_STREAMING_ENTITY_FILTER = true;

		// Token: 0x04018750 RID: 100176
		private bool IsPlayerSoarInternal;

		// Token: 0x04018751 RID: 100177
		private bool EnableSlowStreamingInternal;

		// Token: 0x04018752 RID: 100178
		private EntityToLoadFilter PlayerSoarMonitorFilter;

		// Token: 0x04018753 RID: 100179
		public float HeightThreshould;

		// Token: 0x04018754 RID: 100180
		[Nullable(2)]
		private static PlayerSoarMonitorController _Instance;
	}
}
