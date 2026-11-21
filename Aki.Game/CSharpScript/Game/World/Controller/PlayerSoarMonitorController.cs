using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.World.Controller
{
	// Token: 0x02003462 RID: 13410
	[NullableContext(1)]
	[Nullable(0)]
	[TickController(0)]
	public class PlayerSoarMonitorController : ControllerBase
	{
		// Token: 0x170047F9 RID: 18425
		// (get) Token: 0x06022396 RID: 140182 RVA: 0x009B1ACF File Offset: 0x009AFCCF
		// (set) Token: 0x06022397 RID: 140183 RVA: 0x009B1AD7 File Offset: 0x009AFCD7
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

		// Token: 0x170047FA RID: 18426
		// (get) Token: 0x06022398 RID: 140184 RVA: 0x009B1AFB File Offset: 0x009AFCFB
		public bool EnableSlowStreaming
		{
			get
			{
				return this.EnableSlowStreamingInternal;
			}
		}

		// Token: 0x06022399 RID: 140185 RVA: 0x009B1B03 File Offset: 0x009AFD03
		protected override bool OnInit()
		{
			this.PlayerSoarMonitorFilter = EntityToLoadFilter.Create();
			base.InitTickOptimize(60, -1);
			this.InitConsoleVariables();
			return base.OnInit();
		}

		// Token: 0x0602239A RID: 140186 RVA: 0x009B1B25 File Offset: 0x009AFD25
		private void InitConsoleVariables()
		{
			this.HeightThreshould = (float)UKismetSystemLibrary.GetConsoleVariableIntValue("wp.Runtime.SoraGridBlackListHeight");
			if (this.HeightThreshould <= 0f)
			{
				this.HeightThreshould = 1500f;
			}
		}

		// Token: 0x0602239B RID: 140187 RVA: 0x009B1B50 File Offset: 0x009AFD50
		protected override void OnTick(float deltaTime)
		{
			this.CheckPlayerMoveState();
			this.CheckEnableSlowStreaming();
		}

		// Token: 0x0602239C RID: 140188 RVA: 0x009B1B5E File Offset: 0x009AFD5E
		protected override bool OnClear()
		{
			this.PlayerSoarMonitorFilter.Cleanup();
			return base.OnClear();
		}

		// Token: 0x0602239D RID: 140189 RVA: 0x009B1B74 File Offset: 0x009AFD74
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

		// Token: 0x0602239E RID: 140190 RVA: 0x009B1BC0 File Offset: 0x009AFDC0
		private void CheckEnableSlowStreaming()
		{
			bool flag = this.IsPlayerSoar && this.CheckHeight();
			if (this.EnableSlowStreamingInternal != flag)
			{
				this.EnableSlowStreamingInternal = flag;
				EventSystem.Instance.Emit<bool>(EEventName.SlowStreamingBySoar, this.EnableSlowStreamingInternal);
			}
		}

		// Token: 0x0602239F RID: 140191 RVA: 0x009B1C08 File Offset: 0x009AFE08
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

		// Token: 0x170047FB RID: 18427
		// (get) Token: 0x060223A0 RID: 140192 RVA: 0x009B1C50 File Offset: 0x009AFE50
		public static PlayerSoarMonitorController Instance
		{
			get
			{
				return PlayerSoarMonitorController._Instance;
			}
		}

		// Token: 0x060223A1 RID: 140193 RVA: 0x009B1C57 File Offset: 0x009AFE57
		public static PlayerSoarMonitorController GetOrCreateInstance()
		{
			if (PlayerSoarMonitorController._Instance == null)
			{
				PlayerSoarMonitorController.CreateInstance();
			}
			return PlayerSoarMonitorController._Instance;
		}

		// Token: 0x060223A2 RID: 140194 RVA: 0x009B1C6B File Offset: 0x009AFE6B
		public static bool CreateInstance()
		{
			if (PlayerSoarMonitorController._Instance != null)
			{
				return true;
			}
			PlayerSoarMonitorController._Instance = new PlayerSoarMonitorController();
			return true;
		}

		// Token: 0x060223A3 RID: 140195 RVA: 0x009B1C81 File Offset: 0x009AFE81
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060223A4 RID: 140196 RVA: 0x009B1C83 File Offset: 0x009AFE83
		public static void ResetStaticDefaultValue()
		{
			PlayerSoarMonitorController._Instance = null;
		}

		// Token: 0x060223A5 RID: 140197 RVA: 0x009B1C8B File Offset: 0x009AFE8B
		static PlayerSoarMonitorController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(PlayerSoarMonitorController.CreateStaticDefaultValue), new Action(PlayerSoarMonitorController.ResetStaticDefaultValue));
		}

		// Token: 0x04012D87 RID: 77191
		public const int SLOW_STREAMING_HEIGHT_THRESHOULD = 1500;

		// Token: 0x04012D88 RID: 77192
		private const string SLOW_STREAMING_HEIGHT_THRESHOULD_CVAR = "wp.Runtime.SoraGridBlackListHeight";

		// Token: 0x04012D89 RID: 77193
		public const bool ENABLE_SLOW_STREAMING_ENTITY_FILTER = true;

		// Token: 0x04012D8A RID: 77194
		private bool IsPlayerSoarInternal;

		// Token: 0x04012D8B RID: 77195
		private bool EnableSlowStreamingInternal;

		// Token: 0x04012D8C RID: 77196
		private EntityToLoadFilter PlayerSoarMonitorFilter;

		// Token: 0x04012D8D RID: 77197
		public float HeightThreshould;

		// Token: 0x04012D8E RID: 77198
		[Nullable(2)]
		private static PlayerSoarMonitorController _Instance;
	}
}
