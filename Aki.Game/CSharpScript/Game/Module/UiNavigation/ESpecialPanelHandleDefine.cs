using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02004940 RID: 18752
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ESpecialPanelHandleDefine : IEquatable<ESpecialPanelHandleDefine>
	{
		// Token: 0x06030EFF RID: 200447 RVA: 0x00B5C4A3 File Offset: 0x00B5A6A3
		private ESpecialPanelHandleDefine(string value)
		{
			this._value = value;
		}

		// Token: 0x06030F00 RID: 200448 RVA: 0x00B5C4AC File Offset: 0x00B5A6AC
		public static ESpecialPanelHandleDefine FromString(string value)
		{
			return new ESpecialPanelHandleDefine(value);
		}

		// Token: 0x06030F01 RID: 200449 RVA: 0x00B5C4B4 File Offset: 0x00B5A6B4
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x06030F02 RID: 200450 RVA: 0x00B5C4BC File Offset: 0x00B5A6BC
		public bool Equals(ESpecialPanelHandleDefine other)
		{
			return this._value == other._value;
		}

		// Token: 0x06030F03 RID: 200451 RVA: 0x00B5C4D0 File Offset: 0x00B5A6D0
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is ESpecialPanelHandleDefine)
			{
				ESpecialPanelHandleDefine other = (ESpecialPanelHandleDefine)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06030F04 RID: 200452 RVA: 0x00B5C4F5 File Offset: 0x00B5A6F5
		public override int GetHashCode()
		{
			string value = this._value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06030F05 RID: 200453 RVA: 0x00B5C508 File Offset: 0x00B5A708
		public static bool operator ==(ESpecialPanelHandleDefine left, ESpecialPanelHandleDefine right)
		{
			return left.Equals(right);
		}

		// Token: 0x06030F06 RID: 200454 RVA: 0x00B5C512 File Offset: 0x00B5A712
		public static bool operator !=(ESpecialPanelHandleDefine left, ESpecialPanelHandleDefine right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401A431 RID: 107569
		private readonly string _value;

		// Token: 0x0401A432 RID: 107570
		public static readonly ESpecialPanelHandleDefine Default = new ESpecialPanelHandleDefine("Default");

		// Token: 0x0401A433 RID: 107571
		public static readonly ESpecialPanelHandleDefine VisionChooseMain = new ESpecialPanelHandleDefine("VisionChooseMain");

		// Token: 0x0401A434 RID: 107572
		public static readonly ESpecialPanelHandleDefine FunctionView = new ESpecialPanelHandleDefine("MainMenu");

		// Token: 0x0401A435 RID: 107573
		public static readonly ESpecialPanelHandleDefine RoleSkill = new ESpecialPanelHandleDefine("RoleSkill");

		// Token: 0x0401A436 RID: 107574
		public static readonly ESpecialPanelHandleDefine RoleResonance = new ESpecialPanelHandleDefine("RoleResonance");

		// Token: 0x0401A437 RID: 107575
		public static readonly ESpecialPanelHandleDefine Inventory = new ESpecialPanelHandleDefine("Inventory");

		// Token: 0x0401A438 RID: 107576
		public static readonly ESpecialPanelHandleDefine Roulette = new ESpecialPanelHandleDefine("Roulette");

		// Token: 0x0401A439 RID: 107577
		public static readonly ESpecialPanelHandleDefine ExploreReward = new ESpecialPanelHandleDefine("ExploreReward");

		// Token: 0x0401A43A RID: 107578
		public static readonly ESpecialPanelHandleDefine VisionAssemble = new ESpecialPanelHandleDefine("VisionAssemble");

		// Token: 0x0401A43B RID: 107579
		public static readonly ESpecialPanelHandleDefine PhantomArenaBattle = new ESpecialPanelHandleDefine("PhantomArenaBattle");

		// Token: 0x0401A43C RID: 107580
		public static readonly ESpecialPanelHandleDefine PhantomManageConfig = new ESpecialPanelHandleDefine("PhantomManageConfig");

		// Token: 0x0401A43D RID: 107581
		public static readonly ESpecialPanelHandleDefine HonamiStoryBackpack = new ESpecialPanelHandleDefine("HonamiStoryBackpack");
	}
}
