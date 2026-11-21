using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020038B7 RID: 14519
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct ESpecialPanelHandleDefine : IEquatable<ESpecialPanelHandleDefine>
	{
		// Token: 0x06025A2C RID: 154156 RVA: 0x00A97313 File Offset: 0x00A95513
		private ESpecialPanelHandleDefine(string value)
		{
			this._value = value;
		}

		// Token: 0x06025A2D RID: 154157 RVA: 0x00A9731C File Offset: 0x00A9551C
		public static ESpecialPanelHandleDefine FromString(string value)
		{
			return new ESpecialPanelHandleDefine(value);
		}

		// Token: 0x06025A2E RID: 154158 RVA: 0x00A97324 File Offset: 0x00A95524
		public override string ToString()
		{
			return this._value;
		}

		// Token: 0x06025A2F RID: 154159 RVA: 0x00A9732C File Offset: 0x00A9552C
		public bool Equals(ESpecialPanelHandleDefine other)
		{
			return this._value == other._value;
		}

		// Token: 0x06025A30 RID: 154160 RVA: 0x00A97340 File Offset: 0x00A95540
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

		// Token: 0x06025A31 RID: 154161 RVA: 0x00A97365 File Offset: 0x00A95565
		public override int GetHashCode()
		{
			string value = this._value;
			if (value == null)
			{
				return 0;
			}
			return value.GetHashCode();
		}

		// Token: 0x06025A32 RID: 154162 RVA: 0x00A97378 File Offset: 0x00A95578
		public static bool operator ==(ESpecialPanelHandleDefine left, ESpecialPanelHandleDefine right)
		{
			return left.Equals(right);
		}

		// Token: 0x06025A33 RID: 154163 RVA: 0x00A97382 File Offset: 0x00A95582
		public static bool operator !=(ESpecialPanelHandleDefine left, ESpecialPanelHandleDefine right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04014CA4 RID: 85156
		private readonly string _value;

		// Token: 0x04014CA5 RID: 85157
		public static readonly ESpecialPanelHandleDefine Default = new ESpecialPanelHandleDefine("Default");

		// Token: 0x04014CA6 RID: 85158
		public static readonly ESpecialPanelHandleDefine VisionChooseMain = new ESpecialPanelHandleDefine("VisionChooseMain");

		// Token: 0x04014CA7 RID: 85159
		public static readonly ESpecialPanelHandleDefine FunctionView = new ESpecialPanelHandleDefine("MainMenu");

		// Token: 0x04014CA8 RID: 85160
		public static readonly ESpecialPanelHandleDefine RoleSkill = new ESpecialPanelHandleDefine("RoleSkill");

		// Token: 0x04014CA9 RID: 85161
		public static readonly ESpecialPanelHandleDefine RoleResonance = new ESpecialPanelHandleDefine("RoleResonance");

		// Token: 0x04014CAA RID: 85162
		public static readonly ESpecialPanelHandleDefine Inventory = new ESpecialPanelHandleDefine("Inventory");

		// Token: 0x04014CAB RID: 85163
		public static readonly ESpecialPanelHandleDefine Roulette = new ESpecialPanelHandleDefine("Roulette");

		// Token: 0x04014CAC RID: 85164
		public static readonly ESpecialPanelHandleDefine ExploreReward = new ESpecialPanelHandleDefine("ExploreReward");

		// Token: 0x04014CAD RID: 85165
		public static readonly ESpecialPanelHandleDefine VisionAssemble = new ESpecialPanelHandleDefine("VisionAssemble");

		// Token: 0x04014CAE RID: 85166
		public static readonly ESpecialPanelHandleDefine PhantomArenaBattle = new ESpecialPanelHandleDefine("PhantomArenaBattle");

		// Token: 0x04014CAF RID: 85167
		public static readonly ESpecialPanelHandleDefine PhantomManageConfig = new ESpecialPanelHandleDefine("PhantomManageConfig");

		// Token: 0x04014CB0 RID: 85168
		public static readonly ESpecialPanelHandleDefine HonamiStoryBackpack = new ESpecialPanelHandleDefine("HonamiStoryBackpack");
	}
}
