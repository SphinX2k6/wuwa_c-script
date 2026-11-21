using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200594F RID: 22863
	public class IHookLockPointT
	{
		// Token: 0x1700A5FB RID: 42491
		// (get) Token: 0x060253CD RID: 152525 RVA: 0x0051CF20 File Offset: 0x0051B120
		// (set) Token: 0x060253CE RID: 152526 RVA: 0x0051CF28 File Offset: 0x0051B128
		public bool Disabled { get; set; }

		// Token: 0x1700A5FC RID: 42492
		// (get) Token: 0x060253CF RID: 152527 RVA: 0x0051CF31 File Offset: 0x0051B131
		// (set) Token: 0x060253D0 RID: 152528 RVA: 0x0051CF39 File Offset: 0x0051B139
		public ISphereTriggerShapeT Range { get; set; }

		// Token: 0x1700A5FD RID: 42493
		// (get) Token: 0x060253D1 RID: 152529 RVA: 0x0051CF42 File Offset: 0x0051B142
		// (set) Token: 0x060253D2 RID: 152530 RVA: 0x0051CF4A File Offset: 0x0051B14A
		public float NonInteractiveInnerRadius { get; set; }

		// Token: 0x1700A5FE RID: 42494
		// (get) Token: 0x060253D3 RID: 152531 RVA: 0x0051CF53 File Offset: 0x0051B153
		// (set) Token: 0x060253D4 RID: 152532 RVA: 0x0051CF5B File Offset: 0x0051B15B
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x1700A5FF RID: 42495
		// (get) Token: 0x060253D5 RID: 152533 RVA: 0x0051CF64 File Offset: 0x0051B164
		// (set) Token: 0x060253D6 RID: 152534 RVA: 0x0051CF6C File Offset: 0x0051B16C
		public bool IgnorePlayCollision { get; set; }

		// Token: 0x1700A600 RID: 42496
		// (get) Token: 0x060253D7 RID: 152535 RVA: 0x0051CF75 File Offset: 0x0051B175
		// (set) Token: 0x060253D8 RID: 152536 RVA: 0x0051CF7D File Offset: 0x0051B17D
		public bool UseRangeComponent { get; set; }

		// Token: 0x1700A601 RID: 42497
		// (get) Token: 0x060253D9 RID: 152537 RVA: 0x0051CF86 File Offset: 0x0051B186
		// (set) Token: 0x060253DA RID: 152538 RVA: 0x0051CF8E File Offset: 0x0051B18E
		public ICameraGazeT CameraGaze { get; set; }

		// Token: 0x1700A602 RID: 42498
		// (get) Token: 0x060253DB RID: 152539 RVA: 0x0051CF97 File Offset: 0x0051B197
		// (set) Token: 0x060253DC RID: 152540 RVA: 0x0051CF9F File Offset: 0x0051B19F
		public IGazeNextPointAfterInteractT GazeNextPointAfterInteract { get; set; }

		// Token: 0x1700A603 RID: 42499
		// (get) Token: 0x060253DD RID: 152541 RVA: 0x0051CFA8 File Offset: 0x0051B1A8
		// (set) Token: 0x060253DE RID: 152542 RVA: 0x0051CFB0 File Offset: 0x0051B1B0
		public bool InheritSpeed { get; set; }

		// Token: 0x1700A604 RID: 42500
		// (get) Token: 0x060253DF RID: 152543 RVA: 0x0051CFB9 File Offset: 0x0051B1B9
		// (set) Token: 0x060253E0 RID: 152544 RVA: 0x0051CFC1 File Offset: 0x0051B1C1
		public string NormalEffect { get; set; }

		// Token: 0x1700A605 RID: 42501
		// (get) Token: 0x060253E1 RID: 152545 RVA: 0x0051CFCA File Offset: 0x0051B1CA
		// (set) Token: 0x060253E2 RID: 152546 RVA: 0x0051CFD2 File Offset: 0x0051B1D2
		public bool IsClimb { get; set; }

		// Token: 0x1700A606 RID: 42502
		// (get) Token: 0x060253E3 RID: 152547 RVA: 0x0051CFDB File Offset: 0x0051B1DB
		// (set) Token: 0x060253E4 RID: 152548 RVA: 0x0051CFE3 File Offset: 0x0051B1E3
		public int PlayerStateRestritionId { get; set; }

		// Token: 0x1700A607 RID: 42503
		// (get) Token: 0x060253E5 RID: 152549 RVA: 0x0051CFEC File Offset: 0x0051B1EC
		// (set) Token: 0x060253E6 RID: 152550 RVA: 0x0051CFF4 File Offset: 0x0051B1F4
		public IConditionGroupT HookEnableCondition { get; set; }

		// Token: 0x1700A608 RID: 42504
		// (get) Token: 0x060253E7 RID: 152551 RVA: 0x0051CFFD File Offset: 0x0051B1FD
		// (set) Token: 0x060253E8 RID: 152552 RVA: 0x0051D005 File Offset: 0x0051B205
		public float HookLockCd { get; set; }

		// Token: 0x1700A609 RID: 42505
		// (get) Token: 0x060253E9 RID: 152553 RVA: 0x0051D00E File Offset: 0x0051B20E
		// (set) Token: 0x060253EA RID: 152554 RVA: 0x0051D016 File Offset: 0x0051B216
		public bool IsDestroyedSelf { get; set; }

		// Token: 0x1700A60A RID: 42506
		// (get) Token: 0x060253EB RID: 152555 RVA: 0x0051D01F File Offset: 0x0051B21F
		// (set) Token: 0x060253EC RID: 152556 RVA: 0x0051D027 File Offset: 0x0051B227
		public bool IsHideSelf { get; set; }

		// Token: 0x1700A60B RID: 42507
		// (get) Token: 0x060253ED RID: 152557 RVA: 0x0051D030 File Offset: 0x0051B230
		// (set) Token: 0x060253EE RID: 152558 RVA: 0x0051D038 File Offset: 0x0051B238
		public THookLockScreenDetectTypeUnion ScreenDetectType { get; set; }

		// Token: 0x1700A60C RID: 42508
		// (get) Token: 0x060253EF RID: 152559 RVA: 0x0051D041 File Offset: 0x0051B241
		// (set) Token: 0x060253F0 RID: 152560 RVA: 0x0051D049 File Offset: 0x0051B249
		public THookInteractConfigUnion HookInteractConfig { get; set; }

		// Token: 0x1700A60D RID: 42509
		// (get) Token: 0x060253F1 RID: 152561 RVA: 0x0051D052 File Offset: 0x0051B252
		// (set) Token: 0x060253F2 RID: 152562 RVA: 0x0051D05A File Offset: 0x0051B25A
		public IMechHookInteractConfigT MechHookInteractConfig { get; set; }

		// Token: 0x1700A60E RID: 42510
		// (get) Token: 0x060253F3 RID: 152563 RVA: 0x0051D063 File Offset: 0x0051B263
		// (set) Token: 0x060253F4 RID: 152564 RVA: 0x0051D06B File Offset: 0x0051B26B
		public IMotorHookConfigT MotorHookConfig { get; set; }

		// Token: 0x1700A60F RID: 42511
		// (get) Token: 0x060253F5 RID: 152565 RVA: 0x0051D074 File Offset: 0x0051B274
		// (set) Token: 0x060253F6 RID: 152566 RVA: 0x0051D07C File Offset: 0x0051B27C
		public IHookGravityConfigT GravityConfig { get; set; }

		// Token: 0x1700A610 RID: 42512
		// (get) Token: 0x060253F7 RID: 152567 RVA: 0x0051D085 File Offset: 0x0051B285
		// (set) Token: 0x060253F8 RID: 152568 RVA: 0x0051D08D File Offset: 0x0051B28D
		public bool DisableAtCreateStage { get; set; }

		// Token: 0x1700A611 RID: 42513
		// (get) Token: 0x060253F9 RID: 152569 RVA: 0x0051D096 File Offset: 0x0051B296
		// (set) Token: 0x060253FA RID: 152570 RVA: 0x0051D09E File Offset: 0x0051B29E
		public IHookPerformanceConfigT HookPerformanceConfig { get; set; }

		// Token: 0x1700A612 RID: 42514
		// (get) Token: 0x060253FB RID: 152571 RVA: 0x0051D0A7 File Offset: 0x0051B2A7
		// (set) Token: 0x060253FC RID: 152572 RVA: 0x0051D0AF File Offset: 0x0051B2AF
		public ushort NullMask { get; set; }

		// Token: 0x060253FD RID: 152573 RVA: 0x0051D0B8 File Offset: 0x0051B2B8
		public IHookLockPointT()
		{
			this.Disabled = false;
			this.Range = null;
			this.NonInteractiveInnerRadius = 0f;
			this.MatchRoleOption = null;
			this.IgnorePlayCollision = false;
			this.UseRangeComponent = false;
			this.CameraGaze = null;
			this.GazeNextPointAfterInteract = null;
			this.InheritSpeed = false;
			this.NormalEffect = null;
			this.IsClimb = false;
			this.PlayerStateRestritionId = 0;
			this.HookEnableCondition = null;
			this.HookLockCd = 0f;
			this.IsDestroyedSelf = false;
			this.IsHideSelf = false;
			this.ScreenDetectType = null;
			this.HookInteractConfig = null;
			this.MechHookInteractConfig = null;
			this.MotorHookConfig = null;
			this.GravityConfig = null;
			this.DisableAtCreateStage = false;
			this.HookPerformanceConfig = null;
			this.NullMask = 0;
		}
	}
}
