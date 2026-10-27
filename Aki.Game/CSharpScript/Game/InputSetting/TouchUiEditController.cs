using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.InputSetting
{
	// Token: 0x02007015 RID: 28693
	[NullableContext(1)]
	[Nullable(0)]
	[Controller(0)]
	public class TouchUiEditController : ControllerBase
	{
		// Token: 0x06045D41 RID: 286017 RVA: 0x0115DB54 File Offset: 0x0115BD54
		protected override bool OnInit()
		{
			this.AddDataFacade(typeof(CommonTouchUiEditDataFacade));
			foreach (ITouchUiEditDataFacade touchUiEditDataFacade in this.DataFacadeMap.Values)
			{
				touchUiEditDataFacade.Init();
			}
			return true;
		}

		// Token: 0x06045D42 RID: 286018 RVA: 0x0115DBBC File Offset: 0x0115BDBC
		protected override bool OnClear()
		{
			foreach (ITouchUiEditDataFacade touchUiEditDataFacade in this.DataFacadeMap.Values)
			{
				touchUiEditDataFacade.Clear();
			}
			this.DataFacadeMap.Clear();
			return true;
		}

		// Token: 0x06045D43 RID: 286019 RVA: 0x0115DC20 File Offset: 0x0115BE20
		private void AddDataFacade(Type type)
		{
			ITouchUiEditDataFacade touchUiEditDataFacade = Activator.CreateInstance(type) as ITouchUiEditDataFacade;
			if (touchUiEditDataFacade != null)
			{
				this.DataFacadeMap[type.Name] = touchUiEditDataFacade;
			}
		}

		// Token: 0x06045D44 RID: 286020 RVA: 0x0115DC50 File Offset: 0x0115BE50
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

		// Token: 0x06045D45 RID: 286021 RVA: 0x0115DC8C File Offset: 0x0115BE8C
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

		// Token: 0x06045D46 RID: 286022 RVA: 0x0115DCEC File Offset: 0x0115BEEC
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

		// Token: 0x06045D47 RID: 286023 RVA: 0x0115DD44 File Offset: 0x0115BF44
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

		// Token: 0x17009BA3 RID: 39843
		// (get) Token: 0x06045D48 RID: 286024 RVA: 0x0115DD90 File Offset: 0x0115BF90
		public static TouchUiEditController Instance
		{
			get
			{
				return TouchUiEditController._Instance;
			}
		}

		// Token: 0x06045D49 RID: 286025 RVA: 0x0115DD97 File Offset: 0x0115BF97
		public static TouchUiEditController GetOrCreateInstance()
		{
			if (TouchUiEditController._Instance == null)
			{
				TouchUiEditController.CreateInstance();
			}
			return TouchUiEditController._Instance;
		}

		// Token: 0x06045D4A RID: 286026 RVA: 0x0115DDAB File Offset: 0x0115BFAB
		public static bool CreateInstance()
		{
			if (TouchUiEditController._Instance != null)
			{
				return true;
			}
			TouchUiEditController._Instance = new TouchUiEditController();
			return true;
		}

		// Token: 0x06045D4B RID: 286027 RVA: 0x0115DDC1 File Offset: 0x0115BFC1
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06045D4C RID: 286028 RVA: 0x0115DDC3 File Offset: 0x0115BFC3
		public static void ResetStaticDefaultValue()
		{
			TouchUiEditController._Instance = null;
		}

		// Token: 0x06045D4D RID: 286029 RVA: 0x0115DDCB File Offset: 0x0115BFCB
		static TouchUiEditController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TouchUiEditController.CreateStaticDefaultValue), new Action(TouchUiEditController.ResetStaticDefaultValue));
		}

		// Token: 0x04024824 RID: 149540
		private readonly Dictionary<string, ITouchUiEditDataFacade> DataFacadeMap = new Dictionary<string, ITouchUiEditDataFacade>();

		// Token: 0x04024825 RID: 149541
		[Nullable(2)]
		private static TouchUiEditController _Instance;
	}
}
