using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200776C RID: 30572
	public class TResetPlayerFocusTypeUnion
	{
		// Token: 0x1700E68B RID: 59019
		// (get) Token: 0x06037864 RID: 227428 RVA: 0x00783B06 File Offset: 0x00781D06
		// (set) Token: 0x06037865 RID: 227429 RVA: 0x00783B0E File Offset: 0x00781D0E
		public TResetPlayerFocusType Type { get; set; }

		// Token: 0x1700E68C RID: 59020
		// (get) Token: 0x06037866 RID: 227430 RVA: 0x00783B17 File Offset: 0x00781D17
		// (set) Token: 0x06037867 RID: 227431 RVA: 0x00783B1F File Offset: 0x00781D1F
		public object Value { get; set; }

		// Token: 0x06037868 RID: 227432 RVA: 0x00783B28 File Offset: 0x00781D28
		public TResetPlayerFocusTypeUnion()
		{
			this.Type = TResetPlayerFocusType.NONE;
			this.Value = null;
		}

		// Token: 0x06037869 RID: 227433 RVA: 0x00783B3E File Offset: 0x00781D3E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603786A RID: 227434 RVA: 0x00783B50 File Offset: 0x00781D50
		public IResetPlayerFocusToDefaultDirectionT AsIResetPlayerFocusToDefaultDirection()
		{
			return this.As<IResetPlayerFocusToDefaultDirectionT>();
		}

		// Token: 0x0603786B RID: 227435 RVA: 0x00783B58 File Offset: 0x00781D58
		public static TResetPlayerFocusTypeUnion FromIResetPlayerFocusToDefaultDirection(IResetPlayerFocusToDefaultDirectionT _iresetplayerfocustodefaultdirection)
		{
			return new TResetPlayerFocusTypeUnion
			{
				Type = TResetPlayerFocusType.IResetPlayerFocusToDefaultDirection,
				Value = _iresetplayerfocustodefaultdirection
			};
		}

		// Token: 0x0603786C RID: 227436 RVA: 0x00783B6D File Offset: 0x00781D6D
		public IResetPlayerFocusToFixedDirectionT AsIResetPlayerFocusToFixedDirection()
		{
			return this.As<IResetPlayerFocusToFixedDirectionT>();
		}

		// Token: 0x0603786D RID: 227437 RVA: 0x00783B75 File Offset: 0x00781D75
		public static TResetPlayerFocusTypeUnion FromIResetPlayerFocusToFixedDirection(IResetPlayerFocusToFixedDirectionT _iresetplayerfocustofixeddirection)
		{
			return new TResetPlayerFocusTypeUnion
			{
				Type = TResetPlayerFocusType.IResetPlayerFocusToFixedDirection,
				Value = _iresetplayerfocustofixeddirection
			};
		}

		// Token: 0x0603786E RID: 227438 RVA: 0x00783B8C File Offset: 0x00781D8C
		public static int Pack(FlatBufferBuilder builder, TResetPlayerFocusTypeUnion _o)
		{
			TResetPlayerFocusType type = _o.Type;
			if (type == TResetPlayerFocusType.IResetPlayerFocusToDefaultDirection)
			{
				return IResetPlayerFocusToDefaultDirection.Pack(builder, _o.AsIResetPlayerFocusToDefaultDirection()).Value;
			}
			if (type != TResetPlayerFocusType.IResetPlayerFocusToFixedDirection)
			{
				return 0;
			}
			return IResetPlayerFocusToFixedDirection.Pack(builder, _o.AsIResetPlayerFocusToFixedDirection()).Value;
		}
	}
}
