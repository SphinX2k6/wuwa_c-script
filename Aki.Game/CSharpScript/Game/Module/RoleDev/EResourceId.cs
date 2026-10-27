using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RoleDev
{
	// Token: 0x02004CB1 RID: 19633
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EResourceId : IEquatable<EResourceId>
	{
		// Token: 0x06032B64 RID: 207716 RVA: 0x00BD4FF2 File Offset: 0x00BD31F2
		private EResourceId(string value)
		{
			this._Value = value;
		}

		// Token: 0x06032B65 RID: 207717 RVA: 0x00BD4FFB File Offset: 0x00BD31FB
		public override string ToString()
		{
			return this._Value;
		}

		// Token: 0x06032B66 RID: 207718 RVA: 0x00BD5003 File Offset: 0x00BD3203
		public bool Equals(EResourceId other)
		{
			return this._Value == other._Value;
		}

		// Token: 0x06032B67 RID: 207719 RVA: 0x00BD5018 File Offset: 0x00BD3218
		public override bool Equals(object obj)
		{
			if (obj is EResourceId)
			{
				EResourceId other = (EResourceId)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06032B68 RID: 207720 RVA: 0x00BD503D File Offset: 0x00BD323D
		public override int GetHashCode()
		{
			string value = this._Value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06032B69 RID: 207721 RVA: 0x00BD5050 File Offset: 0x00BD3250
		public static bool operator ==(EResourceId left, EResourceId right)
		{
			return left.Equals(right);
		}

		// Token: 0x06032B6A RID: 207722 RVA: 0x00BD505A File Offset: 0x00BD325A
		public static bool operator !=(EResourceId left, EResourceId right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401B009 RID: 110601
		private readonly string _Value;

		// Token: 0x0401B00A RID: 110602
		public static readonly EResourceId PlanRole = new EResourceId("UiItem_PlanRole");

		// Token: 0x0401B00B RID: 110603
		public static readonly EResourceId PlanWeapon = new EResourceId("UiItem_PlanWeapon");

		// Token: 0x0401B00C RID: 110604
		public static readonly EResourceId PlanVision = new EResourceId("UiItem_PlanVision");

		// Token: 0x0401B00D RID: 110605
		public static readonly EResourceId PlanSkill = new EResourceId("UiItem_PlanRoleSkill");
	}
}
