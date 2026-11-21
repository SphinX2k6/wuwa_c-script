using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.Input.Enum;

namespace CSharpScript.Game.Input
{
	// Token: 0x0200614A RID: 24906
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct EInputAction : IEquatable<EInputAction>
	{
		// Token: 0x0603BB53 RID: 244563 RVA: 0x010F3406 File Offset: 0x010F1606
		private EInputAction(string Name, byte Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x0603BB54 RID: 244564 RVA: 0x010F3416 File Offset: 0x010F1616
		public override string ToString()
		{
			return this.Name;
		}

		// Token: 0x0603BB55 RID: 244565 RVA: 0x010F341E File Offset: 0x010F161E
		public bool Equals(EInputAction other)
		{
			return this.Value == other.Value;
		}

		// Token: 0x0603BB56 RID: 244566 RVA: 0x010F3430 File Offset: 0x010F1630
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

		// Token: 0x0603BB57 RID: 244567 RVA: 0x010F3455 File Offset: 0x010F1655
		public override int GetHashCode()
		{
			string name = this.Name;
			if (name == null)
			{
				return 0;
			}
			return name.GetHashCode();
		}

		// Token: 0x0603BB58 RID: 244568 RVA: 0x010F3468 File Offset: 0x010F1668
		public static bool operator ==(EInputAction left, EInputAction right)
		{
			return left.Value == right.Value;
		}

		// Token: 0x0603BB59 RID: 244569 RVA: 0x010F3478 File Offset: 0x010F1678
		public static bool operator !=(EInputAction left, EInputAction right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0603BB5A RID: 244570 RVA: 0x010F3485 File Offset: 0x010F1685
		public static implicit operator byte(EInputAction action)
		{
			return action.Value;
		}

		// Token: 0x0603BB5B RID: 244571 RVA: 0x010F348D File Offset: 0x010F168D
		public static implicit operator EInputAction(EInputAction action)
		{
			return (EInputAction)action.Value;
		}

		// Token: 0x0603BB5C RID: 244572 RVA: 0x010F3498 File Offset: 0x010F1698
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

		// Token: 0x0603BB5D RID: 244573 RVA: 0x010F3574 File Offset: 0x010F1774
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

		// Token: 0x0401F7C2 RID: 128962
		public readonly string Name;

		// Token: 0x0401F7C3 RID: 128963
		public readonly byte Value;

		// Token: 0x0401F7C4 RID: 128964
		public const byte NoneValue = 0;

		// Token: 0x0401F7C5 RID: 128965
		public static readonly EInputAction None = new EInputAction("None", 0);

		// Token: 0x0401F7C6 RID: 128966
		public const byte 跳跃Value = 1;

		// Token: 0x0401F7C7 RID: 128967
		public static readonly EInputAction 跳跃 = new EInputAction("跳跃", 1);

		// Token: 0x0401F7C8 RID: 128968
		public const byte 攀爬Value = 2;

		// Token: 0x0401F7C9 RID: 128969
		public static readonly EInputAction 攀爬 = new EInputAction("攀爬", 2);

		// Token: 0x0401F7CA RID: 128970
		public const byte 走跑切换Value = 3;

		// Token: 0x0401F7CB RID: 128971
		public static readonly EInputAction 走跑切换 = new EInputAction("走跑切换", 3);

		// Token: 0x0401F7CC RID: 128972
		public const byte 攻击Value = 4;

		// Token: 0x0401F7CD RID: 128973
		public static readonly EInputAction 攻击 = new EInputAction("攻击", 4);

		// Token: 0x0401F7CE RID: 128974
		public const byte 闪避Value = 5;

		// Token: 0x0401F7CF RID: 128975
		public static readonly EInputAction 闪避 = new EInputAction("闪避", 5);

		// Token: 0x0401F7D0 RID: 128976
		public const byte 技能1Value = 6;

		// Token: 0x0401F7D1 RID: 128977
		public static readonly EInputAction 技能1 = new EInputAction("技能1", 6);

		// Token: 0x0401F7D2 RID: 128978
		public const byte 幻象1Value = 7;

		// Token: 0x0401F7D3 RID: 128979
		public static readonly EInputAction 幻象1 = new EInputAction("幻象1", 7);

		// Token: 0x0401F7D4 RID: 128980
		public const byte 大招Value = 8;

		// Token: 0x0401F7D5 RID: 128981
		public static readonly EInputAction 大招 = new EInputAction("大招", 8);

		// Token: 0x0401F7D6 RID: 128982
		public const byte 幻象2Value = 9;

		// Token: 0x0401F7D7 RID: 128983
		public static readonly EInputAction 幻象2 = new EInputAction("幻象2", 9);

		// Token: 0x0401F7D8 RID: 128984
		public const byte 切换角色1Value = 10;

		// Token: 0x0401F7D9 RID: 128985
		public static readonly EInputAction 切换角色1 = new EInputAction("切换角色1", 10);

		// Token: 0x0401F7DA RID: 128986
		public const byte 切换角色2Value = 11;

		// Token: 0x0401F7DB RID: 128987
		public static readonly EInputAction 切换角色2 = new EInputAction("切换角色2", 11);

		// Token: 0x0401F7DC RID: 128988
		public const byte 切换角色3Value = 12;

		// Token: 0x0401F7DD RID: 128989
		public static readonly EInputAction 切换角色3 = new EInputAction("切换角色3", 12);

		// Token: 0x0401F7DE RID: 128990
		public const byte 锁定目标Value = 13;

		// Token: 0x0401F7DF RID: 128991
		public static readonly EInputAction 锁定目标 = new EInputAction("锁定目标", 13);

		// Token: 0x0401F7E0 RID: 128992
		public const byte 瞄准Value = 14;

		// Token: 0x0401F7E1 RID: 128993
		public static readonly EInputAction 瞄准 = new EInputAction("瞄准", 14);

		// Token: 0x0401F7E2 RID: 128994
		public const byte 通用交互Value = 15;

		// Token: 0x0401F7E3 RID: 128995
		public static readonly EInputAction 通用交互 = new EInputAction("通用交互", 15);

		// Token: 0x0401F7E4 RID: 128996
		public const byte 下降Value = 16;

		// Token: 0x0401F7E5 RID: 128997
		public static readonly EInputAction 下降 = new EInputAction("下降", 16);

		// Token: 0x0401F7E6 RID: 128998
		public const byte 移动输入按键事件Value = 17;

		// Token: 0x0401F7E7 RID: 128999
		public static readonly EInputAction 移动输入按键事件 = new EInputAction("移动输入按键事件", 17);

		// Token: 0x0401F7E8 RID: 129000
		public const byte MaxCountValue = 18;

		// Token: 0x0401F7E9 RID: 129001
		public static readonly EInputAction MaxCount = new EInputAction("MaxCount", 18);

		// Token: 0x0401F7EA RID: 129002
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
