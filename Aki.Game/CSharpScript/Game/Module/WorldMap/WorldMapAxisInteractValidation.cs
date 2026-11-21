using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036AD RID: 13997
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapAxisInteractValidation
	{
		// Token: 0x06024586 RID: 148870 RVA: 0x00A47900 File Offset: 0x00A45B00
		public void Reset()
		{
			this.ViewOpened = false;
			foreach (string axisName in new List<string>(this.AxisInValidationMap.Keys))
			{
				this.InitAxisLock(axisName);
			}
		}

		// Token: 0x06024587 RID: 148871 RVA: 0x00A47964 File Offset: 0x00A45B64
		public void InitAxisLock(string axisName)
		{
			bool value = InputDistributeModel.Instance.GetAxisValue(axisName) != 0f;
			this.AxisInValidationMap[axisName] = value;
		}

		// Token: 0x06024588 RID: 148872 RVA: 0x00A47994 File Offset: 0x00A45B94
		public void Init()
		{
			this.AddEventListener();
		}

		// Token: 0x06024589 RID: 148873 RVA: 0x00A4799C File Offset: 0x00A45B9C
		public void Clear()
		{
			this.RemoveEventListener();
			this.AxisInValidationMap.Clear();
			this.ViewOpened = false;
		}

		// Token: 0x0602458A RID: 148874 RVA: 0x00A479B6 File Offset: 0x00A45BB6
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.WorldMapViewOpened, new Action(this.OnMapViewOpened));
		}

		// Token: 0x0602458B RID: 148875 RVA: 0x00A479D4 File Offset: 0x00A45BD4
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.WorldMapViewOpened, new Action(this.OnMapViewOpened));
		}

		// Token: 0x0602458C RID: 148876 RVA: 0x00A479F4 File Offset: 0x00A45BF4
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

		// Token: 0x17004A38 RID: 19000
		// (get) Token: 0x0602458D RID: 148877 RVA: 0x00A47A70 File Offset: 0x00A45C70
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

		// Token: 0x0602458E RID: 148878 RVA: 0x00A47ACC File Offset: 0x00A45CCC
		public bool IsAxisInValid(string axisName)
		{
			return this.AxisInValidationMap.GetValueOrDefault(axisName, false);
		}

		// Token: 0x0602458F RID: 148879 RVA: 0x00A47ADB File Offset: 0x00A45CDB
		private void OnMapViewOpened()
		{
			this.ViewOpened = true;
		}

		// Token: 0x040143AC RID: 82860
		private bool ViewOpened;

		// Token: 0x040143AD RID: 82861
		private readonly Dictionary<string, bool> AxisInValidationMap = new Dictionary<string, bool>();
	}
}
