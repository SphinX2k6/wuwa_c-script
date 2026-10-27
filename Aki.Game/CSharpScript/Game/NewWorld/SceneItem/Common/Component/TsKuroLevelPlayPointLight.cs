using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x02007210 RID: 29200
	[NullableContext(1)]
	[Nullable(0)]
	internal class TsKuroLevelPlayPointLight : IKuroLevelPlayPointLight
	{
		// Token: 0x17009E20 RID: 40480
		// (get) Token: 0x060477A7 RID: 292775 RVA: 0x01234C95 File Offset: 0x01232E95
		// (set) Token: 0x060477A8 RID: 292776 RVA: 0x01234C9D File Offset: 0x01232E9D
		public float Radius { get; set; }

		// Token: 0x17009E21 RID: 40481
		// (get) Token: 0x060477A9 RID: 292777 RVA: 0x01234CA6 File Offset: 0x01232EA6
		// (set) Token: 0x060477AA RID: 292778 RVA: 0x01234CAE File Offset: 0x01232EAE
		public bool IsLit { get; set; }

		// Token: 0x17009E22 RID: 40482
		// (get) Token: 0x060477AB RID: 292779 RVA: 0x01234CB7 File Offset: 0x01232EB7
		// (set) Token: 0x060477AC RID: 292780 RVA: 0x01234CBF File Offset: 0x01232EBF
		public Vector Position { get; set; } = Vector.Create();

		// Token: 0x060477AD RID: 292781 RVA: 0x01234CC8 File Offset: 0x01232EC8
		public TsKuroLevelPlayPointLight(float radius, bool isLit, Vector position)
		{
			this.Radius = radius;
			this.IsLit = isLit;
			this.Position.FromUeVector(position);
		}

		// Token: 0x060477AE RID: 292782 RVA: 0x01234CF5 File Offset: 0x01232EF5
		public bool Equals(IKuroLevelPlayPointLight b)
		{
			return this.Radius == b.Radius && this.IsLit == b.IsLit && this.Position.Equals(b.Position, 0.10000000149011612);
		}

		// Token: 0x060477AF RID: 292783 RVA: 0x01234D2F File Offset: 0x01232F2F
		public FKuroLevelPlayPointLight ToUe()
		{
			return new FKuroLevelPlayPointLight(this.Radius, this.IsLit, this.Position.ToUeVector(false));
		}
	}
}
