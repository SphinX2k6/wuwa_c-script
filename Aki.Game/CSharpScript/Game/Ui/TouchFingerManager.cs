using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035F5 RID: 13813
	public class TouchFingerManager : Singleton
	{
		// Token: 0x060232CB RID: 144075 RVA: 0x009FE52C File Offset: 0x009FC72C
		public void Initialize()
		{
			foreach (object obj in Enum.GetValues(typeof(EFingerIndex)))
			{
				EFingerIndex fingerIndex = (EFingerIndex)obj;
				this.NewTouchFingerData(fingerIndex);
			}
		}

		// Token: 0x060232CC RID: 144076 RVA: 0x009FE590 File Offset: 0x009FC790
		private void NewTouchFingerData(EFingerIndex fingerIndex)
		{
			TouchFingerData value = new TouchFingerData(fingerIndex);
			this.TouchFingerDataMap[fingerIndex] = value;
		}

		// Token: 0x060232CD RID: 144077 RVA: 0x009FE5B4 File Offset: 0x009FC7B4
		[NullableContext(2)]
		public TouchFingerData GetTouchFingerData(EFingerIndex fingerIndex)
		{
			TouchFingerData result;
			if (this.TouchFingerDataMap.TryGetValue(fingerIndex, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x060232CE RID: 144078 RVA: 0x009FE5D4 File Offset: 0x009FC7D4
		public void StartTouch(EFingerIndex fingerIndex, FVector touchPosition)
		{
			TouchFingerData touchFingerData = this.GetTouchFingerData(fingerIndex);
			if (touchFingerData == null)
			{
				return;
			}
			if (touchFingerData.IsInTouch())
			{
				return;
			}
			this.CurrentTouchFingerCount++;
			touchFingerData.StartTouch(touchPosition);
		}

		// Token: 0x060232CF RID: 144079 RVA: 0x009FE60C File Offset: 0x009FC80C
		public void EndTouch(EFingerIndex fingerIndex)
		{
			TouchFingerData touchFingerData = this.GetTouchFingerData(fingerIndex);
			if (touchFingerData == null)
			{
				return;
			}
			if (!touchFingerData.IsInTouch())
			{
				return;
			}
			this.CurrentTouchFingerCount = Math.Max(this.CurrentTouchFingerCount - 1, 0);
			touchFingerData.EndTouch();
		}

		// Token: 0x060232D0 RID: 144080 RVA: 0x009FE648 File Offset: 0x009FC848
		public void MoveTouch(EFingerIndex fingerIndex, FVector touchPosition)
		{
			TouchFingerData touchFingerData = this.GetTouchFingerData(fingerIndex);
			if (touchFingerData == null)
			{
				return;
			}
			touchFingerData.MoveTouch(touchPosition);
		}

		// Token: 0x060232D1 RID: 144081 RVA: 0x009FE668 File Offset: 0x009FC868
		public FVector? GetTouchPosition(EFingerIndex fingerIndex)
		{
			TouchFingerData touchFingerData = this.GetTouchFingerData(fingerIndex);
			if (touchFingerData == null)
			{
				return null;
			}
			if (!touchFingerData.IsInTouch())
			{
				return null;
			}
			return touchFingerData.GetTouchPosition();
		}

		// Token: 0x060232D2 RID: 144082 RVA: 0x009FE6A4 File Offset: 0x009FC8A4
		public FVector? GetLastTouchPosition(EFingerIndex fingerIndex)
		{
			TouchFingerData touchFingerData = this.GetTouchFingerData(fingerIndex);
			if (touchFingerData == null)
			{
				return null;
			}
			if (!touchFingerData.IsInTouch())
			{
				return null;
			}
			return touchFingerData.GetLastTouchPosition();
		}

		// Token: 0x060232D3 RID: 144083 RVA: 0x009FE6DE File Offset: 0x009FC8DE
		public int GetTouchFingerCount()
		{
			return this.CurrentTouchFingerCount;
		}

		// Token: 0x060232D4 RID: 144084 RVA: 0x009FE6E8 File Offset: 0x009FC8E8
		public float GetFingerExpandCloseValue(EFingerIndex aFingerIndex, EFingerIndex bFingerIndex)
		{
			TouchFingerData touchFingerData = this.GetTouchFingerData(aFingerIndex);
			TouchFingerData touchFingerData2 = this.GetTouchFingerData(bFingerIndex);
			if (touchFingerData == null || touchFingerData2 == null)
			{
				return 0f;
			}
			if (!touchFingerData2.IsInTouch() || !touchFingerData.IsInTouch())
			{
				return 0f;
			}
			FVector? lastTouchPosition = touchFingerData.GetLastTouchPosition();
			FVector? lastTouchPosition2 = touchFingerData2.GetLastTouchPosition();
			if (lastTouchPosition == null || lastTouchPosition2 == null)
			{
				return 0f;
			}
			FVector? touchPosition = touchFingerData.GetTouchPosition();
			FVector? touchPosition2 = touchFingerData2.GetTouchPosition();
			if (touchPosition == null || touchPosition2 == null)
			{
				return 0f;
			}
			float num = touchPosition.Value.X - touchPosition2.Value.X;
			float num2 = touchPosition.Value.Y - touchPosition2.Value.Y;
			float num3 = touchPosition.Value.Z - touchPosition2.Value.Z;
			float num4 = lastTouchPosition.Value.X - lastTouchPosition2.Value.X;
			float num5 = lastTouchPosition.Value.Y - lastTouchPosition2.Value.Y;
			float num6 = lastTouchPosition.Value.Z - lastTouchPosition2.Value.Z;
			float num7 = num * num + num2 * num2 + num3 * num3;
			float num8 = num4 * num4 + num5 * num5 + num6 * num6;
			return num7 - num8;
		}

		// Token: 0x060232D5 RID: 144085 RVA: 0x009FE83C File Offset: 0x009FCA3C
		[return: TupleElementNames(new string[]
		{
			"State",
			"ChangeRate"
		})]
		public ValueTuple<EFingerExpandCloseType, float> GetFingerExpandCloseType(EFingerIndex aFingerIndex, EFingerIndex bFingerIndex)
		{
			float num = 0f;
			TouchFingerData touchFingerData = this.GetTouchFingerData(aFingerIndex);
			TouchFingerData touchFingerData2 = this.GetTouchFingerData(bFingerIndex);
			EFingerExpandCloseType item;
			if (touchFingerData == null || touchFingerData2 == null)
			{
				item = EFingerExpandCloseType.None;
				return new ValueTuple<EFingerExpandCloseType, float>(item, num);
			}
			if (!touchFingerData2.IsInTouch() || !touchFingerData.IsInTouch())
			{
				item = EFingerExpandCloseType.None;
				return new ValueTuple<EFingerExpandCloseType, float>(item, num);
			}
			FVector? lastTouchPosition = touchFingerData.GetLastTouchPosition();
			FVector? lastTouchPosition2 = touchFingerData2.GetLastTouchPosition();
			if (lastTouchPosition == null || lastTouchPosition2 == null)
			{
				item = EFingerExpandCloseType.None;
				return new ValueTuple<EFingerExpandCloseType, float>(item, num);
			}
			FVector? touchPosition = touchFingerData.GetTouchPosition();
			FVector? touchPosition2 = touchFingerData2.GetTouchPosition();
			if (touchPosition == null || touchPosition2 == null)
			{
				item = EFingerExpandCloseType.None;
				return new ValueTuple<EFingerExpandCloseType, float>(item, num);
			}
			float num2 = UKismetMathLibrary.Vector_DistanceSquared(touchPosition.Value, touchPosition2.Value);
			float num3 = UKismetMathLibrary.Vector_DistanceSquared(lastTouchPosition.Value, lastTouchPosition2.Value);
			num = (num2 - num3) / num3;
			if (Math.Abs(num) <= 0.001f)
			{
				item = EFingerExpandCloseType.None;
			}
			else if (num > 0f)
			{
				item = EFingerExpandCloseType.Expand;
			}
			else
			{
				item = EFingerExpandCloseType.Close;
			}
			return new ValueTuple<EFingerExpandCloseType, float>(item, num);
		}

		// Token: 0x060232D6 RID: 144086 RVA: 0x009FE938 File Offset: 0x009FCB38
		[return: TupleElementNames(new string[]
		{
			"X",
			"Y"
		})]
		public ValueTuple<float, float>? GetFingerDirection(EFingerIndex fingerIndex)
		{
			TouchFingerData touchFingerData = this.GetTouchFingerData(fingerIndex);
			if (touchFingerData == null)
			{
				return null;
			}
			if (!touchFingerData.IsInTouch())
			{
				return null;
			}
			FVector? lastTouchPosition = touchFingerData.GetLastTouchPosition();
			FVector? touchPosition = touchFingerData.GetTouchPosition();
			if (lastTouchPosition == null || touchPosition == null)
			{
				return new ValueTuple<float, float>?(new ValueTuple<float, float>(0f, 0f));
			}
			return new ValueTuple<float, float>?(new ValueTuple<float, float>(touchPosition.Value.X - lastTouchPosition.Value.X, touchPosition.Value.Y - lastTouchPosition.Value.Y));
		}

		// Token: 0x17004926 RID: 18726
		// (get) Token: 0x060232D7 RID: 144087 RVA: 0x009FE9DD File Offset: 0x009FCBDD
		[Nullable(1)]
		public static TouchFingerManager Instance
		{
			[NullableContext(1)]
			get
			{
				if (TouchFingerManager._instance == null)
				{
					TouchFingerManager._instance = new TouchFingerManager();
					TouchFingerManager._instance.OnInit();
				}
				return TouchFingerManager._instance;
			}
		}

		// Token: 0x060232D8 RID: 144088 RVA: 0x009FEA00 File Offset: 0x009FCC00
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060232D9 RID: 144089 RVA: 0x009FEA02 File Offset: 0x009FCC02
		public static void ResetStaticDefaultValue()
		{
			TouchFingerManager instance = TouchFingerManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			TouchFingerManager._instance = null;
		}

		// Token: 0x060232DA RID: 144090 RVA: 0x009FEA1B File Offset: 0x009FCC1B
		static TouchFingerManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TouchFingerManager.CreateStaticDefaultValue), new Action(TouchFingerManager.ResetStaticDefaultValue));
		}

		// Token: 0x04013D9B RID: 81307
		[Nullable(1)]
		private readonly Dictionary<EFingerIndex, TouchFingerData> TouchFingerDataMap = new Dictionary<EFingerIndex, TouchFingerData>();

		// Token: 0x04013D9C RID: 81308
		public int CurrentTouchFingerCount;

		// Token: 0x04013D9D RID: 81309
		[Nullable(2)]
		private static TouchFingerManager _instance;
	}
}
