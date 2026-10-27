using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007645 RID: 30277
	public class TAssistCharacterMoveTypeUnion
	{
		// Token: 0x1700E5C1 RID: 58817
		// (get) Token: 0x06037224 RID: 225828 RVA: 0x00779DD2 File Offset: 0x00777FD2
		// (set) Token: 0x06037225 RID: 225829 RVA: 0x00779DDA File Offset: 0x00777FDA
		public TAssistCharacterMoveType Type { get; set; }

		// Token: 0x1700E5C2 RID: 58818
		// (get) Token: 0x06037226 RID: 225830 RVA: 0x00779DE3 File Offset: 0x00777FE3
		// (set) Token: 0x06037227 RID: 225831 RVA: 0x00779DEB File Offset: 0x00777FEB
		public object Value { get; set; }

		// Token: 0x06037228 RID: 225832 RVA: 0x00779DF4 File Offset: 0x00777FF4
		public TAssistCharacterMoveTypeUnion()
		{
			this.Type = TAssistCharacterMoveType.NONE;
			this.Value = null;
		}

		// Token: 0x06037229 RID: 225833 RVA: 0x00779E0A File Offset: 0x0077800A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603722A RID: 225834 RVA: 0x00779E1C File Offset: 0x0077801C
		public IAssistCharacterNavigationMoveT AsIAssistCharacterNavigationMove()
		{
			return this.As<IAssistCharacterNavigationMoveT>();
		}

		// Token: 0x0603722B RID: 225835 RVA: 0x00779E24 File Offset: 0x00778024
		public static TAssistCharacterMoveTypeUnion FromIAssistCharacterNavigationMove(IAssistCharacterNavigationMoveT _iassistcharacternavigationmove)
		{
			return new TAssistCharacterMoveTypeUnion
			{
				Type = TAssistCharacterMoveType.IAssistCharacterNavigationMove,
				Value = _iassistcharacternavigationmove
			};
		}

		// Token: 0x0603722C RID: 225836 RVA: 0x00779E39 File Offset: 0x00778039
		public IAssistCharacterSplineMoveT AsIAssistCharacterSplineMove()
		{
			return this.As<IAssistCharacterSplineMoveT>();
		}

		// Token: 0x0603722D RID: 225837 RVA: 0x00779E41 File Offset: 0x00778041
		public static TAssistCharacterMoveTypeUnion FromIAssistCharacterSplineMove(IAssistCharacterSplineMoveT _iassistcharactersplinemove)
		{
			return new TAssistCharacterMoveTypeUnion
			{
				Type = TAssistCharacterMoveType.IAssistCharacterSplineMove,
				Value = _iassistcharactersplinemove
			};
		}

		// Token: 0x0603722E RID: 225838 RVA: 0x00779E58 File Offset: 0x00778058
		public static int Pack(FlatBufferBuilder builder, TAssistCharacterMoveTypeUnion _o)
		{
			TAssistCharacterMoveType type = _o.Type;
			if (type == TAssistCharacterMoveType.IAssistCharacterNavigationMove)
			{
				return IAssistCharacterNavigationMove.Pack(builder, _o.AsIAssistCharacterNavigationMove()).Value;
			}
			if (type != TAssistCharacterMoveType.IAssistCharacterSplineMove)
			{
				return 0;
			}
			return IAssistCharacterSplineMove.Pack(builder, _o.AsIAssistCharacterSplineMove()).Value;
		}
	}
}
