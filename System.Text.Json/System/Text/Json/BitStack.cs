using System;
using System.Runtime.CompilerServices;

namespace System.Text.Json
{
	// Token: 0x0200001D RID: 29
	internal struct BitStack
	{
		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000211 RID: 529 RVA: 0x000066F2 File Offset: 0x000048F2
		public int CurrentDepth
		{
			get
			{
				return this._currentDepth;
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000066FA File Offset: 0x000048FA
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PushTrue()
		{
			if (this._currentDepth < 64)
			{
				this._allocationFreeContainer = (this._allocationFreeContainer << 1 | 1UL);
			}
			else
			{
				this.PushToArray(true);
			}
			this._currentDepth++;
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0000672E File Offset: 0x0000492E
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void PushFalse()
		{
			if (this._currentDepth < 64)
			{
				this._allocationFreeContainer <<= 1;
			}
			else
			{
				this.PushToArray(false);
			}
			this._currentDepth++;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00006760 File Offset: 0x00004960
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void PushToArray(bool value)
		{
			if (this._array == null)
			{
				this._array = new int[2];
			}
			int num2;
			int num = BitStack.Div32Rem(this._currentDepth - 64, out num2);
			if (num >= this._array.Length)
			{
				this.DoubleArray(num);
			}
			int num3 = this._array[num];
			if (value)
			{
				num3 |= 1 << num2;
			}
			else
			{
				num3 &= ~(1 << num2);
			}
			this._array[num] = num3;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000067D0 File Offset: 0x000049D0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool Pop()
		{
			this._currentDepth--;
			bool result;
			if (this._currentDepth < 64)
			{
				this._allocationFreeContainer >>= 1;
				result = ((this._allocationFreeContainer & 1UL) > 0UL);
			}
			else if (this._currentDepth == 64)
			{
				result = ((this._allocationFreeContainer & 1UL) > 0UL);
			}
			else
			{
				result = this.PopFromArray();
			}
			return result;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00006838 File Offset: 0x00004A38
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool PopFromArray()
		{
			int num2;
			int num = BitStack.Div32Rem(this._currentDepth - 64 - 1, out num2);
			return (this._array[num] & 1 << num2) != 0;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x0000686C File Offset: 0x00004A6C
		private void DoubleArray(int minSize)
		{
			int newSize = Math.Max(minSize + 1, this._array.Length * 2);
			Array.Resize<int>(ref this._array, newSize);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00006898 File Offset: 0x00004A98
		public void SetFirstBit()
		{
			this._currentDepth++;
			this._allocationFreeContainer = 1UL;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x000068B0 File Offset: 0x00004AB0
		public void ResetFirstBit()
		{
			this._currentDepth++;
			this._allocationFreeContainer = 0UL;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x000068C8 File Offset: 0x00004AC8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int Div32Rem(int number, out int remainder)
		{
			int result = number / 32;
			remainder = (number & 31);
			return result;
		}

		// Token: 0x04000035 RID: 53
		private int[] _array;

		// Token: 0x04000036 RID: 54
		private ulong _allocationFreeContainer;

		// Token: 0x04000037 RID: 55
		private int _currentDepth;
	}
}
