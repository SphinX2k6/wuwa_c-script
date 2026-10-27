using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.UI.Framework;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046A6 RID: 18086
	[NullableContext(1)]
	[Nullable(0)]
	public class Input : Singleton
	{
		// Token: 0x0602EA1C RID: 191004 RVA: 0x00ACBCF4 File Offset: 0x00AC9EF4
		public void Initialize(LGUIEventSystemActor_C eventActor)
		{
			if (eventActor == null)
			{
				return;
			}
			eventActor.OnClickKey.Add(new Action<FKey, bool>(this.OnKeyClick));
			eventActor.OnMiddleMouseScroll.Add(new Action<float>(this.OnMiddleMouseScroll));
			eventActor.OnTouch.Add(new Action<bool, int, FVector>(this.OnTouch));
			eventActor.OnTouchMove.Add(new Action<int, FVector>(this.OnTouchMove));
		}

		// Token: 0x0602EA1D RID: 191005 RVA: 0x00ACBD64 File Offset: 0x00AC9F64
		public bool IsKeyPress(string key)
		{
			bool flag;
			return this.KeyMap.TryGetValue(key, out flag) && flag;
		}

		// Token: 0x0602EA1E RID: 191006 RVA: 0x00ACBD84 File Offset: 0x00AC9F84
		public float GetAxisValue()
		{
			return this.AxisValue;
		}

		// Token: 0x0602EA1F RID: 191007 RVA: 0x00ACBD8C File Offset: 0x00AC9F8C
		public IReadOnlyDictionary<int, TouchData> GetTouchMap()
		{
			return this.TouchMap;
		}

		// Token: 0x0602EA20 RID: 191008 RVA: 0x00ACBD94 File Offset: 0x00AC9F94
		private void OnKeyClick(FKey key, bool isPress)
		{
			string text = key.KeyName.ToString();
			this.KeyMap[text] = isPress;
			if ((StringUtils.IsEmpty(this.OnlyRespondToKey) || text == this.OnlyRespondToKey || text.Contains("Mouse")) && this.Enable)
			{
				this.KeyMap[text] = isPress;
				EventSystem.Instance.Emit<bool, FKey>(EEventName.KeyClick, isPress, key);
			}
		}

		// Token: 0x0602EA21 RID: 191009 RVA: 0x00ACBE0E File Offset: 0x00ACA00E
		private void OnMiddleMouseScroll(float axisValue)
		{
			if (this.Enable)
			{
				this.AxisValue = axisValue;
			}
		}

		// Token: 0x0602EA22 RID: 191010 RVA: 0x00ACBE20 File Offset: 0x00ACA020
		private void OnTouch(bool isPress, int touchId, FVector touchPosition)
		{
			TouchData value;
			if (this.Enable && !this.TouchMap.TryGetValue(touchId, out value))
			{
				value = new TouchData(isPress, touchId, touchPosition);
				this.TouchMap[touchId] = value;
			}
		}

		// Token: 0x0602EA23 RID: 191011 RVA: 0x00ACBE5C File Offset: 0x00ACA05C
		private void OnTouchMove(int touchId, FVector touchPosition)
		{
			TouchData touchData;
			if (this.Enable && this.TouchMap.TryGetValue(touchId, out touchData))
			{
				touchData.TouchPosition = touchPosition;
			}
		}

		// Token: 0x1700763A RID: 30266
		// (get) Token: 0x0602EA24 RID: 191012 RVA: 0x00ACBE88 File Offset: 0x00ACA088
		public static Input Instance
		{
			get
			{
				if (Input._instance == null)
				{
					Input._instance = new Input();
					Input._instance.OnInit();
				}
				return Input._instance;
			}
		}

		// Token: 0x0602EA25 RID: 191013 RVA: 0x00ACBEAB File Offset: 0x00ACA0AB
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EA26 RID: 191014 RVA: 0x00ACBEAD File Offset: 0x00ACA0AD
		public static void ResetStaticDefaultValue()
		{
			Input instance = Input._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			Input._instance = null;
		}

		// Token: 0x0602EA27 RID: 191015 RVA: 0x00ACBEC6 File Offset: 0x00ACA0C6
		static Input()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(Input.CreateStaticDefaultValue), new Action(Input.ResetStaticDefaultValue));
		}

		// Token: 0x04019672 RID: 104050
		private readonly Dictionary<string, bool> KeyMap = new Dictionary<string, bool>();

		// Token: 0x04019673 RID: 104051
		private readonly Dictionary<int, TouchData> TouchMap = new Dictionary<int, TouchData>();

		// Token: 0x04019674 RID: 104052
		private float AxisValue;

		// Token: 0x04019675 RID: 104053
		public string OnlyRespondToKey = "";

		// Token: 0x04019676 RID: 104054
		public bool Enable = true;

		// Token: 0x04019677 RID: 104055
		[Nullable(2)]
		private static Input _instance;
	}
}
