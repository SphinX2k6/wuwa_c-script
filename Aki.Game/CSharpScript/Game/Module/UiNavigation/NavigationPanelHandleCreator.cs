using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003875 RID: 14453
	[NullableContext(1)]
	[Nullable(0)]
	public class NavigationPanelHandleCreator : IStaticVariableResetter
	{
		// Token: 0x060258DA RID: 153818 RVA: 0x00A936F8 File Offset: 0x00A918F8
		static NavigationPanelHandleCreator()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(NavigationPanelHandleCreator.CreateStaticDefaultValue), new Action(NavigationPanelHandleCreator.ResetStaticDefaultValue));
		}

		// Token: 0x17004D28 RID: 19752
		// (get) Token: 0x060258DB RID: 153819 RVA: 0x00A93717 File Offset: 0x00A91917
		private static Dictionary<string, Type> SpecialPanelHandleMap
		{
			get
			{
				return NavigationPanelHandleCreator._specialPanelHandleMap;
			}
		}

		// Token: 0x060258DC RID: 153820 RVA: 0x00A9371E File Offset: 0x00A9191E
		public static void RegisterSpecialPanelHandle(string tag, Type ctor)
		{
			NavigationPanelHandleCreator.SpecialPanelHandleMap[tag] = ctor;
		}

		// Token: 0x060258DD RID: 153821 RVA: 0x00A9372C File Offset: 0x00A9192C
		[return: Nullable(2)]
		public static SpecialPanelHandleBase GetPanelHandle(string tag)
		{
			Type type;
			if (!NavigationPanelHandleCreator.SpecialPanelHandleMap.TryGetValue(tag, out type))
			{
				type = NavigationPanelHandleCreator.SpecialPanelHandleMap["Default"];
				tag = "Default";
			}
			return Activator.CreateInstance(type, new object[]
			{
				tag
			}) as SpecialPanelHandleBase;
		}

		// Token: 0x060258DE RID: 153822 RVA: 0x00A93774 File Offset: 0x00A91974
		public static void CreateStaticDefaultValue()
		{
			NavigationPanelHandleCreator._specialPanelHandleMap = new Dictionary<string, Type>();
		}

		// Token: 0x060258DF RID: 153823 RVA: 0x00A93780 File Offset: 0x00A91980
		public static void ResetStaticDefaultValue()
		{
			NavigationPanelHandleCreator._specialPanelHandleMap = null;
		}

		// Token: 0x04014C2C RID: 85036
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private static Dictionary<string, Type> _specialPanelHandleMap;
	}
}
