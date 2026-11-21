using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02006196 RID: 24982
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class TouchUiEditController : ControllerBase
	{
		// Token: 0x0603BEF7 RID: 245495 RVA: 0x01107F50 File Offset: 0x01106150
		protected override bool OnInit()
		{
			this.AddDataFacade(typeof(CommonTouchUiEditDataFacade));
			foreach (ITouchUiEditDataFacade touchUiEditDataFacade in this.DataFacadeMap.Values)
			{
				touchUiEditDataFacade.Init();
			}
			return true;
		}

		// Token: 0x0603BEF8 RID: 245496 RVA: 0x01107FB8 File Offset: 0x011061B8
		protected override bool OnClear()
		{
			foreach (ITouchUiEditDataFacade touchUiEditDataFacade in this.DataFacadeMap.Values)
			{
				touchUiEditDataFacade.Clear();
			}
			this.DataFacadeMap.Clear();
			return true;
		}

		// Token: 0x0603BEF9 RID: 245497 RVA: 0x0110801C File Offset: 0x0110621C
		private void AddDataFacade(Type type)
		{
			ITouchUiEditDataFacade touchUiEditDataFacade = Activator.CreateInstance(type) as ITouchUiEditDataFacade;
			if (touchUiEditDataFacade != null)
			{
				this.DataFacadeMap[type.Name] = touchUiEditDataFacade;
			}
		}

		// Token: 0x0603BEFA RID: 245498 RVA: 0x0110804C File Offset: 0x0110624C
		[NullableContext(0)]
		[return: Nullable(2)]
		public T GetDataFacade<T>() where T : ITouchUiEditDataFacade
		{
			ITouchUiEditDataFacade touchUiEditDataFacade;
			if (this.DataFacadeMap.TryGetValue(typeof(T).Name, out touchUiEditDataFacade))
			{
				return (T)((object)touchUiEditDataFacade);
			}
			return default(T);
		}

		// Token: 0x0603BEFB RID: 245499 RVA: 0x01108088 File Offset: 0x01106288
		public void OpenCommonTouchUiEditView(int group)
		{
			CommonTouchUiEditContainer container = new CommonTouchUiEditContainer();
			CommonTouchUiEditDataFacade dataFacade = this.GetDataFacade<CommonTouchUiEditDataFacade>();
			if (dataFacade == null)
			{
				return;
			}
			dataFacade.SetGroup(group);
			TouchUiEditProxy param = new TouchUiEditProxy(container, dataFacade, (UUIItem item, [Nullable(2)] ITouchUiEditData data) => new CommonTouchUiEditItem(item, data));
			UiManager.Instance.OpenView(EUiViewName.CommonTouchUiEditView, param, null);
		}

		// Token: 0x0603BEFC RID: 245500 RVA: 0x011080E8 File Offset: 0x011062E8
		[NullableContext(2)]
		public TouchUiEditProxy CreateProxyForFunction(EFunction functionId)
		{
			if (functionId == EFunction.MotorMobileButtonCustom)
			{
				int group = 2;
				int? currentValue = GameSettingsManager.Instance.GetCurrentValue(EFunction.MotorMobileButtonLayout, true, true);
				if (currentValue != null)
				{
					int? num = currentValue;
					int num2 = 0;
					if (num.GetValueOrDefault() == num2 & num != null)
					{
						group = 3;
					}
				}
				return this.CreateCommonProxy(group);
			}
			return null;
		}

		// Token: 0x0603BEFD RID: 245501 RVA: 0x01108140 File Offset: 0x01106340
		[NullableContext(2)]
		private TouchUiEditProxy CreateCommonProxy(int group)
		{
			CommonTouchUiEditContainer container = new CommonTouchUiEditContainer();
			CommonTouchUiEditDataFacade dataFacade = this.GetDataFacade<CommonTouchUiEditDataFacade>();
			if (dataFacade == null)
			{
				return null;
			}
			dataFacade.SetGroup(group);
			return new TouchUiEditProxy(container, dataFacade, (UUIItem item, [Nullable(2)] ITouchUiEditData data) => new CommonTouchUiEditItem(item, data));
		}

		// Token: 0x170070E3 RID: 28899
		// (get) Token: 0x0603BEFE RID: 245502 RVA: 0x0110818C File Offset: 0x0110638C
		public static TouchUiEditController Instance
		{
			get
			{
				return TouchUiEditController._Instance;
			}
		}

		// Token: 0x0603BEFF RID: 245503 RVA: 0x01108193 File Offset: 0x01106393
		public static TouchUiEditController GetOrCreateInstance()
		{
			if (TouchUiEditController._Instance == null)
			{
				TouchUiEditController.CreateInstance();
			}
			return TouchUiEditController._Instance;
		}

		// Token: 0x0603BF00 RID: 245504 RVA: 0x011081A7 File Offset: 0x011063A7
		public static bool CreateInstance()
		{
			if (TouchUiEditController._Instance != null)
			{
				return true;
			}
			TouchUiEditController._Instance = new TouchUiEditController();
			return true;
		}

		// Token: 0x0603BF01 RID: 245505 RVA: 0x011081BD File Offset: 0x011063BD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603BF02 RID: 245506 RVA: 0x011081BF File Offset: 0x011063BF
		public static void ResetStaticDefaultValue()
		{
			TouchUiEditController._Instance = null;
		}

		// Token: 0x0603BF03 RID: 245507 RVA: 0x011081C7 File Offset: 0x011063C7
		static TouchUiEditController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TouchUiEditController.CreateStaticDefaultValue), new Action(TouchUiEditController.ResetStaticDefaultValue));
		}

		// Token: 0x0401FADA RID: 129754
		private readonly Dictionary<string, ITouchUiEditDataFacade> DataFacadeMap = new Dictionary<string, ITouchUiEditDataFacade>();

		// Token: 0x0401FADB RID: 129755
		[Nullable(2)]
		private static TouchUiEditController _Instance;
	}
}
