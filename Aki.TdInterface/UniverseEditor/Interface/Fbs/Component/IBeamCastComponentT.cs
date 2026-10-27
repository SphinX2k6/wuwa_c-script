using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F02 RID: 20226
	public class IBeamCastComponentT
	{
		// Token: 0x17009193 RID: 37267
		// (get) Token: 0x0601FF66 RID: 130918 RVA: 0x00472EA4 File Offset: 0x004710A4
		// (set) Token: 0x0601FF67 RID: 130919 RVA: 0x00472EAC File Offset: 0x004710AC
		public bool Disabled { get; set; }

		// Token: 0x17009194 RID: 37268
		// (get) Token: 0x0601FF68 RID: 130920 RVA: 0x00472EB5 File Offset: 0x004710B5
		// (set) Token: 0x0601FF69 RID: 130921 RVA: 0x00472EBD File Offset: 0x004710BD
		public string EffectPath { get; set; }

		// Token: 0x17009195 RID: 37269
		// (get) Token: 0x0601FF6A RID: 130922 RVA: 0x00472EC6 File Offset: 0x004710C6
		// (set) Token: 0x0601FF6B RID: 130923 RVA: 0x00472ECE File Offset: 0x004710CE
		public bool DelayDestroyEffect { get; set; }

		// Token: 0x17009196 RID: 37270
		// (get) Token: 0x0601FF6C RID: 130924 RVA: 0x00472ED7 File Offset: 0x004710D7
		// (set) Token: 0x0601FF6D RID: 130925 RVA: 0x00472EDF File Offset: 0x004710DF
		public string StartEffectPath { get; set; }

		// Token: 0x17009197 RID: 37271
		// (get) Token: 0x0601FF6E RID: 130926 RVA: 0x00472EE8 File Offset: 0x004710E8
		// (set) Token: 0x0601FF6F RID: 130927 RVA: 0x00472EF0 File Offset: 0x004710F0
		public string HitEffectPath { get; set; }

		// Token: 0x17009198 RID: 37272
		// (get) Token: 0x0601FF70 RID: 130928 RVA: 0x00472EF9 File Offset: 0x004710F9
		// (set) Token: 0x0601FF71 RID: 130929 RVA: 0x00472F01 File Offset: 0x00471101
		public ICylinderTriggerShapeT Range { get; set; }

		// Token: 0x17009199 RID: 37273
		// (get) Token: 0x0601FF72 RID: 130930 RVA: 0x00472F0A File Offset: 0x0047110A
		// (set) Token: 0x0601FF73 RID: 130931 RVA: 0x00472F12 File Offset: 0x00471112
		public IBeamReflectionConfigT Reflection { get; set; }

		// Token: 0x1700919A RID: 37274
		// (get) Token: 0x0601FF74 RID: 130932 RVA: 0x00472F1B File Offset: 0x0047111B
		// (set) Token: 0x0601FF75 RID: 130933 RVA: 0x00472F23 File Offset: 0x00471123
		public string TargetState { get; set; }

		// Token: 0x1700919B RID: 37275
		// (get) Token: 0x0601FF76 RID: 130934 RVA: 0x00472F2C File Offset: 0x0047112C
		// (set) Token: 0x0601FF77 RID: 130935 RVA: 0x00472F34 File Offset: 0x00471134
		public bool IgnoreMonsterCollision { get; set; }

		// Token: 0x1700919C RID: 37276
		// (get) Token: 0x0601FF78 RID: 130936 RVA: 0x00472F3D File Offset: 0x0047113D
		// (set) Token: 0x0601FF79 RID: 130937 RVA: 0x00472F45 File Offset: 0x00471145
		public IBeamLayoutConfigWallT BeamLayout { get; set; }

		// Token: 0x1700919D RID: 37277
		// (get) Token: 0x0601FF7A RID: 130938 RVA: 0x00472F4E File Offset: 0x0047114E
		// (set) Token: 0x0601FF7B RID: 130939 RVA: 0x00472F56 File Offset: 0x00471156
		public List<IActionInfoT> TriggerActions { get; set; }

		// Token: 0x1700919E RID: 37278
		// (get) Token: 0x0601FF7C RID: 130940 RVA: 0x00472F5F File Offset: 0x0047115F
		// (set) Token: 0x0601FF7D RID: 130941 RVA: 0x00472F67 File Offset: 0x00471167
		public bool DisableDynamicRange { get; set; }

		// Token: 0x1700919F RID: 37279
		// (get) Token: 0x0601FF7E RID: 130942 RVA: 0x00472F70 File Offset: 0x00471170
		// (set) Token: 0x0601FF7F RID: 130943 RVA: 0x00472F78 File Offset: 0x00471178
		public byte NullMask { get; set; }

		// Token: 0x0601FF80 RID: 130944 RVA: 0x00472F84 File Offset: 0x00471184
		public IBeamCastComponentT()
		{
			this.Disabled = false;
			this.EffectPath = null;
			this.DelayDestroyEffect = false;
			this.StartEffectPath = null;
			this.HitEffectPath = null;
			this.Range = null;
			this.Reflection = null;
			this.TargetState = null;
			this.IgnoreMonsterCollision = false;
			this.BeamLayout = null;
			this.TriggerActions = null;
			this.DisableDynamicRange = false;
			this.NullMask = 0;
		}
	}
}
