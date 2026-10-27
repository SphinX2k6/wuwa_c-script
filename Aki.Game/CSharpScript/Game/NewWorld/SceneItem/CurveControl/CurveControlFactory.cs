using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.CurveControl
{
	// Token: 0x0200720B RID: 29195
	[NullableContext(1)]
	[Nullable(0)]
	public class CurveControlFactory : Singleton
	{
		// Token: 0x06047789 RID: 292745 RVA: 0x012344A0 File Offset: 0x012326A0
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

		// Token: 0x17009E1C RID: 40476
		// (get) Token: 0x0604778A RID: 292746 RVA: 0x012344D6 File Offset: 0x012326D6
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

		// Token: 0x0604778B RID: 292747 RVA: 0x012344F9 File Offset: 0x012326F9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0604778C RID: 292748 RVA: 0x012344FB File Offset: 0x012326FB
		public static void ResetStaticDefaultValue()
		{
			CurveControlFactory instance = CurveControlFactory._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			CurveControlFactory._instance = null;
		}

		// Token: 0x0604778D RID: 292749 RVA: 0x01234514 File Offset: 0x01232714
		static CurveControlFactory()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(CurveControlFactory.CreateStaticDefaultValue), new Action(CurveControlFactory.ResetStaticDefaultValue));
		}

		// Token: 0x0604778E RID: 292750 RVA: 0x01234533 File Offset: 0x01232733
		public CurveControlFactory()
		{
			Dictionary<ECurveControlType, Func<CurveControlBase>> dictionary = new Dictionary<ECurveControlType, Func<CurveControlBase>>();
			dictionary.Add(ECurveControlType.ChargeSlash, () => new ChargeSlashCurveControl());
			this.CurveControlTypeMap = dictionary;
			base..ctor();
		}

		// Token: 0x0402597E RID: 153982
		private readonly Dictionary<ECurveControlType, Func<CurveControlBase>> CurveControlTypeMap;

		// Token: 0x0402597F RID: 153983
		[Nullable(2)]
		private static CurveControlFactory _instance;
	}
}
