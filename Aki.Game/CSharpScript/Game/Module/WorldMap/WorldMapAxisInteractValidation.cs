using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x0200477C RID: 18300
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapAxisInteractValidation
	{
		// Token: 0x0602FDBC RID: 196028 RVA: 0x00B178A0 File Offset: 0x00B15AA0
		public void Reset()
		{
			this.ViewOpened = false;
			foreach (string axisName in new List<string>(this.AxisInValidationMap.Keys))
			{
				this.InitAxisLock(axisName);
			}
		}

		// Token: 0x0602FDBD RID: 196029 RVA: 0x00B17904 File Offset: 0x00B15B04
		public void InitAxisLock(string axisName)
		{
			bool value = InputDistributeModel.Instance.GetAxisValue(axisName) != 0f;
			this.AxisInValidationMap[axisName] = value;
		}

		// Token: 0x0602FDBE RID: 196030 RVA: 0x00B17934 File Offset: 0x00B15B34
		public void Init()
		{
			this.AddEventListener();
		}

		// Token: 0x0602FDBF RID: 196031 RVA: 0x00B1793C File Offset: 0x00B15B3C
		public void Clear()
		{
			this.RemoveEventListener();
			this.AxisInValidationMap.Clear();
			this.ViewOpened = false;
		}

		// Token: 0x0602FDC0 RID: 196032 RVA: 0x00B17956 File Offset: 0x00B15B56
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.WorldMapViewOpened, new Action(this.OnMapViewOpened));
		}

		// Token: 0x0602FDC1 RID: 196033 RVA: 0x00B17974 File Offset: 0x00B15B74
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.WorldMapViewOpened, new Action(this.OnMapViewOpened));
		}

		// Token: 0x0602FDC2 RID: 196034 RVA: 0x00B17994 File Offset: 0x00B15B94
		public void InputAxis(string axisName, float value)
		{
			if (this.IsAxisInValid(axisName) && this.ViewOpened && value == 0f)
			{
				foreach (string key in new List<string>(this.AxisInValidationMap.Keys))
				{
					this.AxisInValidationMap[key] = false;
				}
			}
		}

		// Token: 0x1700777C RID: 30588
		// (get) Token: 0x0602FDC3 RID: 196035 RVA: 0x00B17A10 File Offset: 0x00B15C10
		public bool IsInValid
		{
			get
			{
				using (Dictionary<string, bool>.ValueCollection.Enumerator enumerator = this.AxisInValidationMap.Values.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current)
						{
							return true;
						}
					}
				}
				return false;
			}
		}

		// Token: 0x0602FDC4 RID: 196036 RVA: 0x00B17A6C File Offset: 0x00B15C6C
		public bool IsAxisInValid(string axisName)
		{
			return this.AxisInValidationMap.GetValueOrDefault(axisName, false);
		}

		// Token: 0x0602FDC5 RID: 196037 RVA: 0x00B17A7B File Offset: 0x00B15C7B
		private void OnMapViewOpened()
		{
			this.ViewOpened = true;
		}

		// Token: 0x04019CFC RID: 105724
		private bool ViewOpened;

		// Token: 0x04019CFD RID: 105725
		private readonly Dictionary<string, bool> AxisInValidationMap = new Dictionary<string, bool>();
	}
}
