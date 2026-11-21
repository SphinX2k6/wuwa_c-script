using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.InputSetting;

namespace CSharpScript.Game.Input.BattleInputData
{
	// Token: 0x0200615F RID: 24927
	[NullableContext(1)]
	[Nullable(0)]
	public class NormalWorldInputData : BattleInputData
	{
		// Token: 0x0603BBE6 RID: 244710 RVA: 0x010F4D10 File Offset: 0x010F2F10
		public NormalWorldInputData()
		{
			Dictionary<string, EInputAction> dictionary = new Dictionary<string, EInputAction>();
			dictionary["跳跃"] = EInputAction.跳跃;
			dictionary["攀爬"] = EInputAction.攀爬;
			dictionary["走跑切换"] = EInputAction.走跑切换;
			dictionary["攻击"] = EInputAction.攻击;
			dictionary["闪避"] = EInputAction.闪避;
			dictionary["技能1"] = EInputAction.技能1;
			dictionary["幻象1"] = EInputAction.幻象1;
			dictionary["大招"] = EInputAction.大招;
			dictionary["幻象2"] = EInputAction.幻象2;
			dictionary["通用交互"] = EInputAction.通用交互;
			dictionary["锁定目标"] = EInputAction.锁定目标;
			dictionary["瞄准"] = EInputAction.瞄准;
			dictionary["下降"] = EInputAction.下降;
			this.ActionMap = dictionary;
			Dictionary<string, EInputAxis> dictionary2 = new Dictionary<string, EInputAxis>();
			dictionary2["LookUp"] = EInputAxis.LookUp;
			dictionary2["Turn"] = EInputAxis.Turn;
			dictionary2["MoveForward"] = EInputAxis.MoveForward;
			dictionary2["MoveRight"] = EInputAxis.MoveRight;
			dictionary2["Zoom"] = EInputAxis.Zoom;
			dictionary2["WheelAxis"] = EInputAxis.WheelAxis;
			this.AxisMap = dictionary2;
			base..ctor(EInputDataType.NormalWorld, EInputBindingType.Original);
		}

		// Token: 0x0603BBE7 RID: 244711 RVA: 0x010F4E6B File Offset: 0x010F306B
		protected override Dictionary<string, EInputAction> OnGetActionMap()
		{
			return this.ActionMap;
		}

		// Token: 0x0603BBE8 RID: 244712 RVA: 0x010F4E73 File Offset: 0x010F3073
		protected override Dictionary<string, EInputAxis> OnGetAxisMap()
		{
			return this.AxisMap;
		}

		// Token: 0x0401F837 RID: 129079
		private readonly Dictionary<string, EInputAction> ActionMap;

		// Token: 0x0401F838 RID: 129080
		private readonly Dictionary<string, EInputAxis> AxisMap;
	}
}
