using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F98 RID: 32664
	public class TResetPlayerFocusTypeUnion
	{
		// Token: 0x1700F2DD RID: 62173
		// (get) Token: 0x0603ADAD RID: 241069 RVA: 0x007E8BD6 File Offset: 0x007E6DD6
		// (set) Token: 0x0603ADAE RID: 241070 RVA: 0x007E8BDE File Offset: 0x007E6DDE
		public TResetPlayerFocusType Type { get; set; }

		// Token: 0x1700F2DE RID: 62174
		// (get) Token: 0x0603ADAF RID: 241071 RVA: 0x007E8BE7 File Offset: 0x007E6DE7
		// (set) Token: 0x0603ADB0 RID: 241072 RVA: 0x007E8BEF File Offset: 0x007E6DEF
		public object Value { get; set; }

		// Token: 0x0603ADB1 RID: 241073 RVA: 0x007E8BF8 File Offset: 0x007E6DF8
		public TResetPlayerFocusTypeUnion()
		{
			this.Type = TResetPlayerFocusType.NONE;
			this.Value = null;
		}

		// Token: 0x0603ADB2 RID: 241074 RVA: 0x007E8C0E File Offset: 0x007E6E0E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ADB3 RID: 241075 RVA: 0x007E8C20 File Offset: 0x007E6E20
		public IResetPlayerFocusToDefaultDirectionT AsIResetPlayerFocusToDefaultDirection()
		{
			return this.As<IResetPlayerFocusToDefaultDirectionT>();
		}

		// Token: 0x0603ADB4 RID: 241076 RVA: 0x007E8C28 File Offset: 0x007E6E28
		public static TResetPlayerFocusTypeUnion FromIResetPlayerFocusToDefaultDirection(IResetPlayerFocusToDefaultDirectionT _iresetplayerfocustodefaultdirection)
		{
			return new TResetPlayerFocusTypeUnion
			{
				Type = TResetPlayerFocusType.IResetPlayerFocusToDefaultDirection,
				Value = _iresetplayerfocustodefaultdirection
			};
		}

		// Token: 0x0603ADB5 RID: 241077 RVA: 0x007E8C3D File Offset: 0x007E6E3D
		public IResetPlayerFocusToFixedDirectionT AsIResetPlayerFocusToFixedDirection()
		{
			return this.As<IResetPlayerFocusToFixedDirectionT>();
		}

		// Token: 0x0603ADB6 RID: 241078 RVA: 0x007E8C45 File Offset: 0x007E6E45
		public static TResetPlayerFocusTypeUnion FromIResetPlayerFocusToFixedDirection(IResetPlayerFocusToFixedDirectionT _iresetplayerfocustofixeddirection)
		{
			return new TResetPlayerFocusTypeUnion
			{
				Type = TResetPlayerFocusType.IResetPlayerFocusToFixedDirection,
				Value = _iresetplayerfocustofixeddirection
			};
		}

		// Token: 0x0603ADB7 RID: 241079 RVA: 0x007E8C5C File Offset: 0x007E6E5C
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
