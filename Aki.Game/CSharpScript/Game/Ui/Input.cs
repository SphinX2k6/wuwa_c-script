using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.UI.Framework;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035D7 RID: 13783
	[NullableContext(1)]
	[Nullable(0)]
	public class Input : Singleton
	{
		// Token: 0x06023168 RID: 143720 RVA: 0x009FA5C8 File Offset: 0x009F87C8
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

		// Token: 0x06023169 RID: 143721 RVA: 0x009FA638 File Offset: 0x009F8838
		public bool IsKeyPress(string key)
		{
			bool flag;
			return this.KeyMap.TryGetValue(key, out flag) && flag;
		}

		// Token: 0x0602316A RID: 143722 RVA: 0x009FA658 File Offset: 0x009F8858
		public float GetAxisValue()
		{
			return this.AxisValue;
		}

		// Token: 0x0602316B RID: 143723 RVA: 0x009FA660 File Offset: 0x009F8860
		public IReadOnlyDictionary<int, TouchData> GetTouchMap()
		{
			return this.TouchMap;
		}

		// Token: 0x0602316C RID: 143724 RVA: 0x009FA668 File Offset: 0x009F8868
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

		// Token: 0x0602316D RID: 143725 RVA: 0x009FA6E2 File Offset: 0x009F88E2
		private void OnMiddleMouseScroll(float axisValue)
		{
			if (this.Enable)
			{
				this.AxisValue = axisValue;
			}
		}

		// Token: 0x0602316E RID: 143726 RVA: 0x009FA6F4 File Offset: 0x009F88F4
		private void OnTouch(bool isPress, int touchId, FVector touchPosition)
		{
			TouchData value;
			if (this.Enable && !this.TouchMap.TryGetValue(touchId, out value))
			{
				value = new TouchData(isPress, touchId, touchPosition);
				this.TouchMap[touchId] = value;
			}
		}

		// Token: 0x0602316F RID: 143727 RVA: 0x009FA730 File Offset: 0x009F8930
		private void OnTouchMove(int touchId, FVector touchPosition)
		{
			TouchData touchData;
			if (this.Enable && this.TouchMap.TryGetValue(touchId, out touchData))
			{
				touchData.TouchPosition = touchPosition;
			}
		}

		// Token: 0x170048F6 RID: 18678
		// (get) Token: 0x06023170 RID: 143728 RVA: 0x009FA75C File Offset: 0x009F895C
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

		// Token: 0x06023171 RID: 143729 RVA: 0x009FA77F File Offset: 0x009F897F
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06023172 RID: 143730 RVA: 0x009FA781 File Offset: 0x009F8981
		public static void ResetStaticDefaultValue()
		{
			Input instance = Input._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			Input._instance = null;
		}

		// Token: 0x06023173 RID: 143731 RVA: 0x009FA79A File Offset: 0x009F899A
		static Input()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(Input.CreateStaticDefaultValue), new Action(Input.ResetStaticDefaultValue));
		}

		// Token: 0x04013D17 RID: 81175
		private readonly Dictionary<string, bool> KeyMap = new Dictionary<string, bool>();

		// Token: 0x04013D18 RID: 81176
		private readonly Dictionary<int, TouchData> TouchMap = new Dictionary<int, TouchData>();

		// Token: 0x04013D19 RID: 81177
		private float AxisValue;

		// Token: 0x04013D1A RID: 81178
		public string OnlyRespondToKey = "";

		// Token: 0x04013D1B RID: 81179
		public bool Enable = true;

		// Token: 0x04013D1C RID: 81180
		[Nullable(2)]
		private static Input _instance;
	}
}
