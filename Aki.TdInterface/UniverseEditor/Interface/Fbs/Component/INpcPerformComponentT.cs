using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005633 RID: 22067
	public class INpcPerformComponentT
	{
		// Token: 0x1700A363 RID: 41827
		// (get) Token: 0x06024A9F RID: 150175 RVA: 0x0050FA7A File Offset: 0x0050DC7A
		// (set) Token: 0x06024AA0 RID: 150176 RVA: 0x0050FA82 File Offset: 0x0050DC82
		public bool Disabled { get; set; }

		// Token: 0x1700A364 RID: 41828
		// (get) Token: 0x06024AA1 RID: 150177 RVA: 0x0050FA8B File Offset: 0x0050DC8B
		// (set) Token: 0x06024AA2 RID: 150178 RVA: 0x0050FA93 File Offset: 0x0050DC93
		public IBaseRoleNpcPerformT SpecialNpcPerformConfig { get; set; }

		// Token: 0x1700A365 RID: 41829
		// (get) Token: 0x06024AA3 RID: 150179 RVA: 0x0050FA9C File Offset: 0x0050DC9C
		// (set) Token: 0x06024AA4 RID: 150180 RVA: 0x0050FAA4 File Offset: 0x0050DCA4
		public bool IsStare { get; set; }

		// Token: 0x1700A366 RID: 41830
		// (get) Token: 0x06024AA5 RID: 150181 RVA: 0x0050FAAD File Offset: 0x0050DCAD
		// (set) Token: 0x06024AA6 RID: 150182 RVA: 0x0050FAB5 File Offset: 0x0050DCB5
		public INpcHitShowT NpcHitShow { get; set; }

		// Token: 0x1700A367 RID: 41831
		// (get) Token: 0x06024AA7 RID: 150183 RVA: 0x0050FABE File Offset: 0x0050DCBE
		// (set) Token: 0x06024AA8 RID: 150184 RVA: 0x0050FAC6 File Offset: 0x0050DCC6
		public bool IsShowStrike { get; set; }

		// Token: 0x1700A368 RID: 41832
		// (get) Token: 0x06024AA9 RID: 150185 RVA: 0x0050FACF File Offset: 0x0050DCCF
		// (set) Token: 0x06024AAA RID: 150186 RVA: 0x0050FAD7 File Offset: 0x0050DCD7
		public INpcBumpShowT NpcBumpShow { get; set; }

		// Token: 0x1700A369 RID: 41833
		// (get) Token: 0x06024AAB RID: 150187 RVA: 0x0050FAE0 File Offset: 0x0050DCE0
		// (set) Token: 0x06024AAC RID: 150188 RVA: 0x0050FAE8 File Offset: 0x0050DCE8
		public INpcAwakeShowT ShowOnAwake { get; set; }

		// Token: 0x1700A36A RID: 41834
		// (get) Token: 0x06024AAD RID: 150189 RVA: 0x0050FAF1 File Offset: 0x0050DCF1
		// (set) Token: 0x06024AAE RID: 150190 RVA: 0x0050FAF9 File Offset: 0x0050DCF9
		public TNpcStandbyShowOptionUnion ShowOnStandby { get; set; }

		// Token: 0x1700A36B RID: 41835
		// (get) Token: 0x06024AAF RID: 150191 RVA: 0x0050FB02 File Offset: 0x0050DD02
		// (set) Token: 0x06024AB0 RID: 150192 RVA: 0x0050FB0A File Offset: 0x0050DD0A
		public INpcPerformOnInteractT ShowOnInteract { get; set; }

		// Token: 0x1700A36C RID: 41836
		// (get) Token: 0x06024AB1 RID: 150193 RVA: 0x0050FB13 File Offset: 0x0050DD13
		// (set) Token: 0x06024AB2 RID: 150194 RVA: 0x0050FB1B File Offset: 0x0050DD1B
		public List<IConditionalNpcPerformOnInteractT> ConditionalShowOnInteracts { get; set; }

		// Token: 0x1700A36D RID: 41837
		// (get) Token: 0x06024AB3 RID: 150195 RVA: 0x0050FB24 File Offset: 0x0050DD24
		// (set) Token: 0x06024AB4 RID: 150196 RVA: 0x0050FB2C File Offset: 0x0050DD2C
		public TNpcUiInteractOptionUnion ShowOnUiInteract { get; set; }

		// Token: 0x1700A36E RID: 41838
		// (get) Token: 0x06024AB5 RID: 150197 RVA: 0x0050FB35 File Offset: 0x0050DD35
		// (set) Token: 0x06024AB6 RID: 150198 RVA: 0x0050FB3D File Offset: 0x0050DD3D
		public List<TNpcRideInVehiclePerformTypeUnion> ShowOnRideInVehicle { get; set; }

		// Token: 0x1700A36F RID: 41839
		// (get) Token: 0x06024AB7 RID: 150199 RVA: 0x0050FB46 File Offset: 0x0050DD46
		// (set) Token: 0x06024AB8 RID: 150200 RVA: 0x0050FB4E File Offset: 0x0050DD4E
		public INpcPerformOnMonsterClosebyT NpcMonsterClosePerform { get; set; }

		// Token: 0x1700A370 RID: 41840
		// (get) Token: 0x06024AB9 RID: 150201 RVA: 0x0050FB57 File Offset: 0x0050DD57
		// (set) Token: 0x06024ABA RID: 150202 RVA: 0x0050FB5F File Offset: 0x0050DD5F
		public INpcPerformStateT NpcPerformState { get; set; }

		// Token: 0x1700A371 RID: 41841
		// (get) Token: 0x06024ABB RID: 150203 RVA: 0x0050FB68 File Offset: 0x0050DD68
		// (set) Token: 0x06024ABC RID: 150204 RVA: 0x0050FB70 File Offset: 0x0050DD70
		public INpcDeathInteractT DeathInteract { get; set; }

		// Token: 0x1700A372 RID: 41842
		// (get) Token: 0x06024ABD RID: 150205 RVA: 0x0050FB79 File Offset: 0x0050DD79
		// (set) Token: 0x06024ABE RID: 150206 RVA: 0x0050FB81 File Offset: 0x0050DD81
		public bool FixedPosition { get; set; }

		// Token: 0x1700A373 RID: 41843
		// (get) Token: 0x06024ABF RID: 150207 RVA: 0x0050FB8A File Offset: 0x0050DD8A
		// (set) Token: 0x06024AC0 RID: 150208 RVA: 0x0050FB92 File Offset: 0x0050DD92
		public string DefaultAbpState { get; set; }

		// Token: 0x1700A374 RID: 41844
		// (get) Token: 0x06024AC1 RID: 150209 RVA: 0x0050FB9B File Offset: 0x0050DD9B
		// (set) Token: 0x06024AC2 RID: 150210 RVA: 0x0050FBA3 File Offset: 0x0050DDA3
		public int DefaultFaceExpressionId { get; set; }

		// Token: 0x1700A375 RID: 41845
		// (get) Token: 0x06024AC3 RID: 150211 RVA: 0x0050FBAC File Offset: 0x0050DDAC
		// (set) Token: 0x06024AC4 RID: 150212 RVA: 0x0050FBB4 File Offset: 0x0050DDB4
		public INpcDefaultPerformT DefaultPerform { get; set; }

		// Token: 0x1700A376 RID: 41846
		// (get) Token: 0x06024AC5 RID: 150213 RVA: 0x0050FBBD File Offset: 0x0050DDBD
		// (set) Token: 0x06024AC6 RID: 150214 RVA: 0x0050FBC5 File Offset: 0x0050DDC5
		public List<TNpcSpecialMarkUnion> NpcSpecialMarks { get; set; }

		// Token: 0x1700A377 RID: 41847
		// (get) Token: 0x06024AC7 RID: 150215 RVA: 0x0050FBCE File Offset: 0x0050DDCE
		// (set) Token: 0x06024AC8 RID: 150216 RVA: 0x0050FBD6 File Offset: 0x0050DDD6
		public byte NullMask { get; set; }

		// Token: 0x06024AC9 RID: 150217 RVA: 0x0050FBE0 File Offset: 0x0050DDE0
		public INpcPerformComponentT()
		{
			this.Disabled = false;
			this.SpecialNpcPerformConfig = null;
			this.IsStare = false;
			this.NpcHitShow = null;
			this.IsShowStrike = false;
			this.NpcBumpShow = null;
			this.ShowOnAwake = null;
			this.ShowOnStandby = null;
			this.ShowOnInteract = null;
			this.ConditionalShowOnInteracts = null;
			this.ShowOnUiInteract = null;
			this.ShowOnRideInVehicle = null;
			this.NpcMonsterClosePerform = null;
			this.NpcPerformState = null;
			this.DeathInteract = null;
			this.FixedPosition = false;
			this.DefaultAbpState = null;
			this.DefaultFaceExpressionId = 0;
			this.DefaultPerform = null;
			this.NpcSpecialMarks = null;
			this.NullMask = 0;
		}
	}
}
