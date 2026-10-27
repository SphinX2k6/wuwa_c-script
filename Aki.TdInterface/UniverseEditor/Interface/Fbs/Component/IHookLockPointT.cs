using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C9 RID: 21449
	public class IHookLockPointT
	{
		// Token: 0x17009DC2 RID: 40386
		// (get) Token: 0x06023317 RID: 144151 RVA: 0x004DFF38 File Offset: 0x004DE138
		// (set) Token: 0x06023318 RID: 144152 RVA: 0x004DFF40 File Offset: 0x004DE140
		public bool Disabled { get; set; }

		// Token: 0x17009DC3 RID: 40387
		// (get) Token: 0x06023319 RID: 144153 RVA: 0x004DFF49 File Offset: 0x004DE149
		// (set) Token: 0x0602331A RID: 144154 RVA: 0x004DFF51 File Offset: 0x004DE151
		public ISphereTriggerShapeT Range { get; set; }

		// Token: 0x17009DC4 RID: 40388
		// (get) Token: 0x0602331B RID: 144155 RVA: 0x004DFF5A File Offset: 0x004DE15A
		// (set) Token: 0x0602331C RID: 144156 RVA: 0x004DFF62 File Offset: 0x004DE162
		public float NonInteractiveInnerRadius { get; set; }

		// Token: 0x17009DC5 RID: 40389
		// (get) Token: 0x0602331D RID: 144157 RVA: 0x004DFF6B File Offset: 0x004DE16B
		// (set) Token: 0x0602331E RID: 144158 RVA: 0x004DFF73 File Offset: 0x004DE173
		public List<TMatchRoleOptionUnion> MatchRoleOption { get; set; }

		// Token: 0x17009DC6 RID: 40390
		// (get) Token: 0x0602331F RID: 144159 RVA: 0x004DFF7C File Offset: 0x004DE17C
		// (set) Token: 0x06023320 RID: 144160 RVA: 0x004DFF84 File Offset: 0x004DE184
		public bool IgnorePlayCollision { get; set; }

		// Token: 0x17009DC7 RID: 40391
		// (get) Token: 0x06023321 RID: 144161 RVA: 0x004DFF8D File Offset: 0x004DE18D
		// (set) Token: 0x06023322 RID: 144162 RVA: 0x004DFF95 File Offset: 0x004DE195
		public bool UseRangeComponent { get; set; }

		// Token: 0x17009DC8 RID: 40392
		// (get) Token: 0x06023323 RID: 144163 RVA: 0x004DFF9E File Offset: 0x004DE19E
		// (set) Token: 0x06023324 RID: 144164 RVA: 0x004DFFA6 File Offset: 0x004DE1A6
		public ICameraGazeT CameraGaze { get; set; }

		// Token: 0x17009DC9 RID: 40393
		// (get) Token: 0x06023325 RID: 144165 RVA: 0x004DFFAF File Offset: 0x004DE1AF
		// (set) Token: 0x06023326 RID: 144166 RVA: 0x004DFFB7 File Offset: 0x004DE1B7
		public IGazeNextPointAfterInteractT GazeNextPointAfterInteract { get; set; }

		// Token: 0x17009DCA RID: 40394
		// (get) Token: 0x06023327 RID: 144167 RVA: 0x004DFFC0 File Offset: 0x004DE1C0
		// (set) Token: 0x06023328 RID: 144168 RVA: 0x004DFFC8 File Offset: 0x004DE1C8
		public bool InheritSpeed { get; set; }

		// Token: 0x17009DCB RID: 40395
		// (get) Token: 0x06023329 RID: 144169 RVA: 0x004DFFD1 File Offset: 0x004DE1D1
		// (set) Token: 0x0602332A RID: 144170 RVA: 0x004DFFD9 File Offset: 0x004DE1D9
		public string NormalEffect { get; set; }

		// Token: 0x17009DCC RID: 40396
		// (get) Token: 0x0602332B RID: 144171 RVA: 0x004DFFE2 File Offset: 0x004DE1E2
		// (set) Token: 0x0602332C RID: 144172 RVA: 0x004DFFEA File Offset: 0x004DE1EA
		public bool IsClimb { get; set; }

		// Token: 0x17009DCD RID: 40397
		// (get) Token: 0x0602332D RID: 144173 RVA: 0x004DFFF3 File Offset: 0x004DE1F3
		// (set) Token: 0x0602332E RID: 144174 RVA: 0x004DFFFB File Offset: 0x004DE1FB
		public int PlayerStateRestritionId { get; set; }

		// Token: 0x17009DCE RID: 40398
		// (get) Token: 0x0602332F RID: 144175 RVA: 0x004E0004 File Offset: 0x004DE204
		// (set) Token: 0x06023330 RID: 144176 RVA: 0x004E000C File Offset: 0x004DE20C
		public IConditionGroupT HookEnableCondition { get; set; }

		// Token: 0x17009DCF RID: 40399
		// (get) Token: 0x06023331 RID: 144177 RVA: 0x004E0015 File Offset: 0x004DE215
		// (set) Token: 0x06023332 RID: 144178 RVA: 0x004E001D File Offset: 0x004DE21D
		public float HookLockCd { get; set; }

		// Token: 0x17009DD0 RID: 40400
		// (get) Token: 0x06023333 RID: 144179 RVA: 0x004E0026 File Offset: 0x004DE226
		// (set) Token: 0x06023334 RID: 144180 RVA: 0x004E002E File Offset: 0x004DE22E
		public bool IsDestroyedSelf { get; set; }

		// Token: 0x17009DD1 RID: 40401
		// (get) Token: 0x06023335 RID: 144181 RVA: 0x004E0037 File Offset: 0x004DE237
		// (set) Token: 0x06023336 RID: 144182 RVA: 0x004E003F File Offset: 0x004DE23F
		public bool IsHideSelf { get; set; }

		// Token: 0x17009DD2 RID: 40402
		// (get) Token: 0x06023337 RID: 144183 RVA: 0x004E0048 File Offset: 0x004DE248
		// (set) Token: 0x06023338 RID: 144184 RVA: 0x004E0050 File Offset: 0x004DE250
		public THookLockScreenDetectTypeUnion ScreenDetectType { get; set; }

		// Token: 0x17009DD3 RID: 40403
		// (get) Token: 0x06023339 RID: 144185 RVA: 0x004E0059 File Offset: 0x004DE259
		// (set) Token: 0x0602333A RID: 144186 RVA: 0x004E0061 File Offset: 0x004DE261
		public THookInteractConfigUnion HookInteractConfig { get; set; }

		// Token: 0x17009DD4 RID: 40404
		// (get) Token: 0x0602333B RID: 144187 RVA: 0x004E006A File Offset: 0x004DE26A
		// (set) Token: 0x0602333C RID: 144188 RVA: 0x004E0072 File Offset: 0x004DE272
		public IMotorHookConfigT MotorHookConfig { get; set; }

		// Token: 0x17009DD5 RID: 40405
		// (get) Token: 0x0602333D RID: 144189 RVA: 0x004E007B File Offset: 0x004DE27B
		// (set) Token: 0x0602333E RID: 144190 RVA: 0x004E0083 File Offset: 0x004DE283
		public IHookGravityConfigT GravityConfig { get; set; }

		// Token: 0x17009DD6 RID: 40406
		// (get) Token: 0x0602333F RID: 144191 RVA: 0x004E008C File Offset: 0x004DE28C
		// (set) Token: 0x06023340 RID: 144192 RVA: 0x004E0094 File Offset: 0x004DE294
		public bool DisableAtCreateStage { get; set; }

		// Token: 0x17009DD7 RID: 40407
		// (get) Token: 0x06023341 RID: 144193 RVA: 0x004E009D File Offset: 0x004DE29D
		// (set) Token: 0x06023342 RID: 144194 RVA: 0x004E00A5 File Offset: 0x004DE2A5
		public IHookPerformanceConfigT HookPerformanceConfig { get; set; }

		// Token: 0x17009DD8 RID: 40408
		// (get) Token: 0x06023343 RID: 144195 RVA: 0x004E00AE File Offset: 0x004DE2AE
		// (set) Token: 0x06023344 RID: 144196 RVA: 0x004E00B6 File Offset: 0x004DE2B6
		public ushort NullMask { get; set; }

		// Token: 0x06023345 RID: 144197 RVA: 0x004E00C0 File Offset: 0x004DE2C0
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
			this.MotorHookConfig = null;
			this.GravityConfig = null;
			this.DisableAtCreateStage = false;
			this.HookPerformanceConfig = null;
			this.NullMask = 0;
		}
	}
}
