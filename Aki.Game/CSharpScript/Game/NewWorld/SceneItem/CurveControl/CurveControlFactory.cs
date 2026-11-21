using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.CurveControl
{
	// Token: 0x020062C0 RID: 25280
	[NullableContext(1)]
	[Nullable(0)]
	public class CurveControlFactory : Singleton
	{
		// Token: 0x0603D09A RID: 250010 RVA: 0x0118DF30 File Offset: 0x0118C130
		[NullableContext(2)]
		public CurveControlBase CreateCurveControl(ECurveControlType? type)
		{
			if (type == null)
			{
				return null;
			}
			Func<CurveControlBase> func;
			if (this.CurveControlTypeMap.TryGetValue(type.Value, out func))
			{
				return func();
			}
			return null;
		}

		// Token: 0x17007382 RID: 29570
		// (get) Token: 0x0603D09B RID: 250011 RVA: 0x0118DF66 File Offset: 0x0118C166
		public static CurveControlFactory Instance
		{
			get
			{
				if (CurveControlFactory._instance == null)
				{
					CurveControlFactory._instance = new CurveControlFactory();
					CurveControlFactory._instance.OnInit();
				}
				return CurveControlFactory._instance;
			}
		}

		// Token: 0x0603D09C RID: 250012 RVA: 0x0118DF89 File Offset: 0x0118C189
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603D09D RID: 250013 RVA: 0x0118DF8B File Offset: 0x0118C18B
		public static void ResetStaticDefaultValue()
		{
			CurveControlFactory instance = CurveControlFactory._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			CurveControlFactory._instance = null;
		}

		// Token: 0x0603D09E RID: 250014 RVA: 0x0118DFA4 File Offset: 0x0118C1A4
		static CurveControlFactory()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CurveControlFactory.CreateStaticDefaultValue), new Action(CurveControlFactory.ResetStaticDefaultValue));
		}

		// Token: 0x0603D09F RID: 250015 RVA: 0x0118DFC3 File Offset: 0x0118C1C3
		public CurveControlFactory()
		{
			Dictionary<ECurveControlType, Func<CurveControlBase>> dictionary = new Dictionary<ECurveControlType, Func<CurveControlBase>>();
			dictionary.Add(ECurveControlType.ChargeSlash, () => new ChargeSlashCurveControl());
			this.CurveControlTypeMap = dictionary;
			base..ctor();
		}

		// Token: 0x040205ED RID: 132589
		private readonly Dictionary<ECurveControlType, Func<CurveControlBase>> CurveControlTypeMap;

		// Token: 0x040205EE RID: 132590
		[Nullable(2)]
		private static CurveControlFactory _instance;
	}
}
