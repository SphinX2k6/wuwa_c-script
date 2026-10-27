using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x020070B7 RID: 28855
	[NullableContext(1)]
	public interface IRailControlData
	{
		// Token: 0x17009C74 RID: 40052
		// (get) Token: 0x060465A1 RID: 288161
		// (set) Token: 0x060465A2 RID: 288162
		float Rad { get; set; }

		// Token: 0x17009C75 RID: 40053
		// (get) Token: 0x060465A3 RID: 288163
		// (set) Token: 0x060465A4 RID: 288164
		float AngularVelocity { get; set; }

		// Token: 0x17009C76 RID: 40054
		// (get) Token: 0x060465A5 RID: 288165
		// (set) Token: 0x060465A6 RID: 288166
		float Damping { get; set; }

		// Token: 0x17009C77 RID: 40055
		// (get) Token: 0x060465A7 RID: 288167
		// (set) Token: 0x060465A8 RID: 288168
		float MaxAngularVelocity { get; set; }

		// Token: 0x17009C78 RID: 40056
		// (get) Token: 0x060465A9 RID: 288169
		// (set) Token: 0x060465AA RID: 288170
		float MaxLinearVelocity { get; set; }

		// Token: 0x17009C79 RID: 40057
		// (get) Token: 0x060465AB RID: 288171
		// (set) Token: 0x060465AC RID: 288172
		bool IgnoreMaxAngle { get; set; }

		// Token: 0x17009C7A RID: 40058
		// (get) Token: 0x060465AD RID: 288173
		// (set) Token: 0x060465AE RID: 288174
		float RegressionSpeed { get; set; }

		// Token: 0x17009C7B RID: 40059
		// (get) Token: 0x060465AF RID: 288175
		// (set) Token: 0x060465B0 RID: 288176
		float InputCoefficient { get; set; }

		// Token: 0x17009C7C RID: 40060
		// (get) Token: 0x060465B1 RID: 288177
		// (set) Token: 0x060465B2 RID: 288178
		float MaxAngle { get; set; }

		// Token: 0x17009C7D RID: 40061
		// (get) Token: 0x060465B3 RID: 288179
		// (set) Token: 0x060465B4 RID: 288180
		float Radius { get; set; }

		// Token: 0x17009C7E RID: 40062
		// (get) Token: 0x060465B5 RID: 288181
		// (set) Token: 0x060465B6 RID: 288182
		bool InnerArc { get; set; }

		// Token: 0x17009C7F RID: 40063
		// (get) Token: 0x060465B7 RID: 288183
		// (set) Token: 0x060465B8 RID: 288184
		float HalfHeight { get; set; }

		// Token: 0x17009C80 RID: 40064
		// (get) Token: 0x060465B9 RID: 288185
		Vector ToCenterVector { get; }

		// Token: 0x17009C81 RID: 40065
		// (get) Token: 0x060465BA RID: 288186
		Vector SplineForwardVector { get; }

		// Token: 0x17009C82 RID: 40066
		// (get) Token: 0x060465BB RID: 288187
		Vector CenterLocation { get; }

		// Token: 0x17009C83 RID: 40067
		// (get) Token: 0x060465BC RID: 288188
		Vector DefaultLocation { get; }

		// Token: 0x060465BD RID: 288189
		float GetLimitLinearVelocity();
	}
}
