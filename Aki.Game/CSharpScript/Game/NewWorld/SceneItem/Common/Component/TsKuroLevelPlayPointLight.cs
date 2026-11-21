using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x020062C5 RID: 25285
	[NullableContext(1)]
	[Nullable(0)]
	internal class TsKuroLevelPlayPointLight : IKuroLevelPlayPointLight
	{
		// Token: 0x1700738C RID: 29580
		// (get) Token: 0x0603D0BE RID: 250046 RVA: 0x0118E706 File Offset: 0x0118C906
		// (set) Token: 0x0603D0BF RID: 250047 RVA: 0x0118E70E File Offset: 0x0118C90E
		public float Radius { get; set; }

		// Token: 0x1700738D RID: 29581
		// (get) Token: 0x0603D0C0 RID: 250048 RVA: 0x0118E717 File Offset: 0x0118C917
		// (set) Token: 0x0603D0C1 RID: 250049 RVA: 0x0118E71F File Offset: 0x0118C91F
		public bool IsLit { get; set; }

		// Token: 0x1700738E RID: 29582
		// (get) Token: 0x0603D0C2 RID: 250050 RVA: 0x0118E728 File Offset: 0x0118C928
		// (set) Token: 0x0603D0C3 RID: 250051 RVA: 0x0118E730 File Offset: 0x0118C930
		public Vector Position { get; set; } = Vector.Create();

		// Token: 0x0603D0C4 RID: 250052 RVA: 0x0118E739 File Offset: 0x0118C939
		public TsKuroLevelPlayPointLight(float radius, bool isLit, Vector position)
		{
			this.Radius = radius;
			this.IsLit = isLit;
			this.Position.FromUeVector(position);
		}

		// Token: 0x0603D0C5 RID: 250053 RVA: 0x0118E766 File Offset: 0x0118C966
		public bool Equals(IKuroLevelPlayPointLight b)
		{
			return this.Radius == b.Radius && this.IsLit == b.IsLit && this.Position.Equals(b.Position, 0.10000000149011612);
		}

		// Token: 0x0603D0C6 RID: 250054 RVA: 0x0118E7A0 File Offset: 0x0118C9A0
		public FKuroLevelPlayPointLight ToUe()
		{
			return new FKuroLevelPlayPointLight
			{
				Radius = this.Radius,
				bLit = this.IsLit,
				Position = this.Position.ToUeVector(false)
			};
		}
	}
}
