using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;

namespace CSharpScript.Game.Input
{
	// Token: 0x02006FC9 RID: 28617
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EInputAction : IEquatable<EInputAction>
	{
		// Token: 0x060459A3 RID: 285091 RVA: 0x0114960E File Offset: 0x0114780E
		private EInputAction(string Name, byte Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x060459A4 RID: 285092 RVA: 0x0114961E File Offset: 0x0114781E
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x060459A5 RID: 285093 RVA: 0x01149626 File Offset: 0x01147826
		public bool Equals(EInputAction other)
		{
			return this.Value == other.Value;
		}

		// Token: 0x060459A6 RID: 285094 RVA: 0x01149638 File Offset: 0x01147838
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is EInputAction)
			{
				EInputAction other = (EInputAction)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060459A7 RID: 285095 RVA: 0x0114965D File Offset: 0x0114785D
		public override int GetHashCode()
		{
			string name = this.Name;
			if (name == null)
			{
				return 0;
			}
			return name.GetHashCode();
		}

		// Token: 0x060459A8 RID: 285096 RVA: 0x01149670 File Offset: 0x01147870
		public static bool operator ==(EInputAction left, EInputAction right)
		{
			return left.Value == right.Value;
		}

		// Token: 0x060459A9 RID: 285097 RVA: 0x01149680 File Offset: 0x01147880
		public static bool operator !=(EInputAction left, EInputAction right)
		{
			return !left.Equals(right);
		}

		// Token: 0x060459AA RID: 285098 RVA: 0x0114968D File Offset: 0x0114788D
		public static implicit operator byte(EInputAction action)
		{
			return action.Value;
		}

		// Token: 0x060459AB RID: 285099 RVA: 0x01149695 File Offset: 0x01147895
		public static implicit operator EInputAction(EInputAction action)
		{
			return (EInputAction)action.Value;
		}

		// Token: 0x060459AC RID: 285100 RVA: 0x011496A0 File Offset: 0x011478A0
		public static explicit operator EInputAction(byte value)
		{
			switch (value)
			{
			case 0:
				return EInputAction.None;
			case 1:
				return EInputAction.跳跃;
			case 2:
				return EInputAction.攀爬;
			case 3:
				return EInputAction.走跑切换;
			case 4:
				return EInputAction.攻击;
			case 5:
				return EInputAction.闪避;
			case 6:
				return EInputAction.技能1;
			case 7:
				return EInputAction.幻象1;
			case 8:
				return EInputAction.大招;
			case 9:
				return EInputAction.幻象2;
			case 10:
				return EInputAction.切换角色1;
			case 11:
				return EInputAction.切换角色2;
			case 12:
				return EInputAction.切换角色3;
			case 13:
				return EInputAction.锁定目标;
			case 14:
				return EInputAction.瞄准;
			case 15:
				return EInputAction.通用交互;
			case 16:
				return EInputAction.下降;
			case 17:
				return EInputAction.移动输入按键事件;
			case 18:
				return EInputAction.MaxCount;
			default:
				return default(EInputAction);
			}
		}

		// Token: 0x060459AD RID: 285101 RVA: 0x0114977C File Offset: 0x0114797C
		public static implicit operator EInputAction(EInputAction action)
		{
			switch (action)
			{
			case EInputAction.None:
				return EInputAction.None;
			case EInputAction.跳跃:
				return EInputAction.跳跃;
			case EInputAction.攀爬:
				return EInputAction.攀爬;
			case EInputAction.走跑切换:
				return EInputAction.走跑切换;
			case EInputAction.攻击:
				return EInputAction.攻击;
			case EInputAction.闪避:
				return EInputAction.闪避;
			case EInputAction.技能1:
				return EInputAction.技能1;
			case EInputAction.幻象1:
				return EInputAction.幻象1;
			case EInputAction.大招:
				return EInputAction.大招;
			case EInputAction.幻象2:
				return EInputAction.幻象2;
			case EInputAction.切换角色1:
				return EInputAction.切换角色1;
			case EInputAction.切换角色2:
				return EInputAction.切换角色2;
			case EInputAction.切换角色3:
				return EInputAction.切换角色3;
			case EInputAction.锁定目标:
				return EInputAction.锁定目标;
			case EInputAction.瞄准:
				return EInputAction.瞄准;
			case EInputAction.通用交互:
				return EInputAction.通用交互;
			case EInputAction.下降:
				return EInputAction.下降;
			case EInputAction.移动输入按键事件:
				return EInputAction.移动输入按键事件;
			default:
				return default(EInputAction);
			}
		}

		// Token: 0x0402450D RID: 148749
		public readonly string Name;

		// Token: 0x0402450E RID: 148750
		public readonly byte Value;

		// Token: 0x0402450F RID: 148751
		public const byte NoneValue = 0;

		// Token: 0x04024510 RID: 148752
		public static readonly EInputAction None = new EInputAction("None", 0);

		// Token: 0x04024511 RID: 148753
		public const byte 跳跃Value = 1;

		// Token: 0x04024512 RID: 148754
		public static readonly EInputAction 跳跃 = new EInputAction("跳跃", 1);

		// Token: 0x04024513 RID: 148755
		public const byte 攀爬Value = 2;

		// Token: 0x04024514 RID: 148756
		public static readonly EInputAction 攀爬 = new EInputAction("攀爬", 2);

		// Token: 0x04024515 RID: 148757
		public const byte 走跑切换Value = 3;

		// Token: 0x04024516 RID: 148758
		public static readonly EInputAction 走跑切换 = new EInputAction("走跑切换", 3);

		// Token: 0x04024517 RID: 148759
		public const byte 攻击Value = 4;

		// Token: 0x04024518 RID: 148760
		public static readonly EInputAction 攻击 = new EInputAction("攻击", 4);

		// Token: 0x04024519 RID: 148761
		public const byte 闪避Value = 5;

		// Token: 0x0402451A RID: 148762
		public static readonly EInputAction 闪避 = new EInputAction("闪避", 5);

		// Token: 0x0402451B RID: 148763
		public const byte 技能1Value = 6;

		// Token: 0x0402451C RID: 148764
		public static readonly EInputAction 技能1 = new EInputAction("技能1", 6);

		// Token: 0x0402451D RID: 148765
		public const byte 幻象1Value = 7;

		// Token: 0x0402451E RID: 148766
		public static readonly EInputAction 幻象1 = new EInputAction("幻象1", 7);

		// Token: 0x0402451F RID: 148767
		public const byte 大招Value = 8;

		// Token: 0x04024520 RID: 148768
		public static readonly EInputAction 大招 = new EInputAction("大招", 8);

		// Token: 0x04024521 RID: 148769
		public const byte 幻象2Value = 9;

		// Token: 0x04024522 RID: 148770
		public static readonly EInputAction 幻象2 = new EInputAction("幻象2", 9);

		// Token: 0x04024523 RID: 148771
		public const byte 切换角色1Value = 10;

		// Token: 0x04024524 RID: 148772
		public static readonly EInputAction 切换角色1 = new EInputAction("切换角色1", 10);

		// Token: 0x04024525 RID: 148773
		public const byte 切换角色2Value = 11;

		// Token: 0x04024526 RID: 148774
		public static readonly EInputAction 切换角色2 = new EInputAction("切换角色2", 11);

		// Token: 0x04024527 RID: 148775
		public const byte 切换角色3Value = 12;

		// Token: 0x04024528 RID: 148776
		public static readonly EInputAction 切换角色3 = new EInputAction("切换角色3", 12);

		// Token: 0x04024529 RID: 148777
		public const byte 锁定目标Value = 13;

		// Token: 0x0402452A RID: 148778
		public static readonly EInputAction 锁定目标 = new EInputAction("锁定目标", 13);

		// Token: 0x0402452B RID: 148779
		public const byte 瞄准Value = 14;

		// Token: 0x0402452C RID: 148780
		public static readonly EInputAction 瞄准 = new EInputAction("瞄准", 14);

		// Token: 0x0402452D RID: 148781
		public const byte 通用交互Value = 15;

		// Token: 0x0402452E RID: 148782
		public static readonly EInputAction 通用交互 = new EInputAction("通用交互", 15);

		// Token: 0x0402452F RID: 148783
		public const byte 下降Value = 16;

		// Token: 0x04024530 RID: 148784
		public static readonly EInputAction 下降 = new EInputAction("下降", 16);

		// Token: 0x04024531 RID: 148785
		public const byte 移动输入按键事件Value = 17;

		// Token: 0x04024532 RID: 148786
		public static readonly EInputAction 移动输入按键事件 = new EInputAction("移动输入按键事件", 17);

		// Token: 0x04024533 RID: 148787
		public const byte MaxCountValue = 18;

		// Token: 0x04024534 RID: 148788
		public static readonly EInputAction MaxCount = new EInputAction("MaxCount", 18);

		// Token: 0x04024535 RID: 148789
		[StaticVariableRuleIgnore]
		public static IReadOnlyList<EInputAction> Defines = new List<EInputAction>
		{
			EInputAction.None,
			EInputAction.跳跃,
			EInputAction.攀爬,
			EInputAction.走跑切换,
			EInputAction.攻击,
			EInputAction.闪避,
			EInputAction.技能1,
			EInputAction.幻象1,
			EInputAction.大招,
			EInputAction.幻象2,
			EInputAction.切换角色1,
			EInputAction.切换角色2,
			EInputAction.切换角色3,
			EInputAction.锁定目标,
			EInputAction.瞄准,
			EInputAction.通用交互,
			EInputAction.下降,
			EInputAction.移动输入按键事件,
			EInputAction.MaxCount
		};
	}
}
