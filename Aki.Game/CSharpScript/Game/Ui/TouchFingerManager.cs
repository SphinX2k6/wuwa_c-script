using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046C4 RID: 18116
	public class TouchFingerManager : Singleton
	{
		// Token: 0x0602EB7F RID: 191359 RVA: 0x00ACFB98 File Offset: 0x00ACDD98
		public void Initialize()
		{
			foreach (object obj in Enum.GetValues(typeof(EFingerIndex)))
			{
				EFingerIndex fingerIndex = (EFingerIndex)obj;
				this.NewTouchFingerData(fingerIndex);
			}
		}

		// Token: 0x0602EB80 RID: 191360 RVA: 0x00ACFBFC File Offset: 0x00ACDDFC
		private void NewTouchFingerData(EFingerIndex fingerIndex)
		{
			TouchFingerData value = new TouchFingerData(fingerIndex);
			this.TouchFingerDataMap[fingerIndex] = value;
		}

		// Token: 0x0602EB81 RID: 191361 RVA: 0x00ACFC20 File Offset: 0x00ACDE20
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

		// Token: 0x0602EB82 RID: 191362 RVA: 0x00ACFC40 File Offset: 0x00ACDE40
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

		// Token: 0x0602EB83 RID: 191363 RVA: 0x00ACFC78 File Offset: 0x00ACDE78
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

		// Token: 0x0602EB84 RID: 191364 RVA: 0x00ACFCB4 File Offset: 0x00ACDEB4
		public void MoveTouch(EFingerIndex fingerIndex, FVector touchPosition)
		{
			TouchFingerData touchFingerData = this.GetTouchFingerData(fingerIndex);
			if (touchFingerData == null)
			{
				return;
			}
			touchFingerData.MoveTouch(touchPosition);
		}

		// Token: 0x0602EB85 RID: 191365 RVA: 0x00ACFCD4 File Offset: 0x00ACDED4
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

		// Token: 0x0602EB86 RID: 191366 RVA: 0x00ACFD10 File Offset: 0x00ACDF10
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

		// Token: 0x0602EB87 RID: 191367 RVA: 0x00ACFD4A File Offset: 0x00ACDF4A
		public int GetTouchFingerCount()
		{
			return this.CurrentTouchFingerCount;
		}

		// Token: 0x0602EB88 RID: 191368 RVA: 0x00ACFD54 File Offset: 0x00ACDF54
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

		// Token: 0x0602EB89 RID: 191369 RVA: 0x00ACFEA8 File Offset: 0x00ACE0A8
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

		// Token: 0x0602EB8A RID: 191370 RVA: 0x00ACFFA4 File Offset: 0x00ACE1A4
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

		// Token: 0x1700766A RID: 30314
		// (get) Token: 0x0602EB8B RID: 191371 RVA: 0x00AD0049 File Offset: 0x00ACE249
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

		// Token: 0x0602EB8C RID: 191372 RVA: 0x00AD006C File Offset: 0x00ACE26C
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602EB8D RID: 191373 RVA: 0x00AD006E File Offset: 0x00ACE26E
		public static void ResetStaticDefaultValue()
		{
			TouchFingerManager instance = TouchFingerManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			TouchFingerManager._instance = null;
		}

		// Token: 0x0602EB8E RID: 191374 RVA: 0x00AD0087 File Offset: 0x00ACE287
		static TouchFingerManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(TouchFingerManager.CreateStaticDefaultValue), new Action(TouchFingerManager.ResetStaticDefaultValue));
		}

		// Token: 0x040196F4 RID: 104180
		[Nullable(1)]
		private readonly Dictionary<EFingerIndex, TouchFingerData> TouchFingerDataMap = new Dictionary<EFingerIndex, TouchFingerData>();

		// Token: 0x040196F5 RID: 104181
		public int CurrentTouchFingerCount;

		// Token: 0x040196F6 RID: 104182
		[Nullable(2)]
		private static TouchFingerManager _instance;
	}
}
