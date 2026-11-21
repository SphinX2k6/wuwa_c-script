using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02003C62 RID: 15458
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EResourceId : IEquatable<EResourceId>
	{
		// Token: 0x06027918 RID: 162072 RVA: 0x00B19D8A File Offset: 0x00B17F8A
		private EResourceId(string value)
		{
			this._Value = value;
		}

		// Token: 0x06027919 RID: 162073 RVA: 0x00B19D93 File Offset: 0x00B17F93
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x0602791A RID: 162074 RVA: 0x00B19D9B File Offset: 0x00B17F9B
		public bool Equals(EResourceId other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x0602791B RID: 162075 RVA: 0x00B19DB0 File Offset: 0x00B17FB0
		public override bool Equals(object obj)
		{
			if (obj is EResourceId)
			{
				EResourceId other = (EResourceId)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x0602791C RID: 162076 RVA: 0x00B19DD5 File Offset: 0x00B17FD5
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x0602791D RID: 162077 RVA: 0x00B19DE8 File Offset: 0x00B17FE8
		public static bool operator ==(EResourceId left, EResourceId right)
		{
			return left.Equals(right);
		}

		// Token: 0x0602791E RID: 162078 RVA: 0x00B19DF2 File Offset: 0x00B17FF2
		public static bool operator !=(EResourceId left, EResourceId right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401596A RID: 88426
		private readonly string _Value;

		// Token: 0x0401596B RID: 88427
		public static readonly EResourceId PlanRole = new EResourceId("UiItem_PlanRole");

		// Token: 0x0401596C RID: 88428
		public static readonly EResourceId PlanWeapon = new EResourceId("UiItem_PlanWeapon");

		// Token: 0x0401596D RID: 88429
		public static readonly EResourceId PlanVision = new EResourceId("UiItem_PlanVision");

		// Token: 0x0401596E RID: 88430
		public static readonly EResourceId PlanSkill = new EResourceId("UiItem_PlanRoleSkill");
	}
}
