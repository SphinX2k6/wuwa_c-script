using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E53 RID: 32339
	public class TAssistCharacterMoveTypeUnion
	{
		// Token: 0x1700F1FF RID: 61951
		// (get) Token: 0x0603A6C9 RID: 239305 RVA: 0x007DDECE File Offset: 0x007DC0CE
		// (set) Token: 0x0603A6CA RID: 239306 RVA: 0x007DDED6 File Offset: 0x007DC0D6
		public TAssistCharacterMoveType Type { get; set; }

		// Token: 0x1700F200 RID: 61952
		// (get) Token: 0x0603A6CB RID: 239307 RVA: 0x007DDEDF File Offset: 0x007DC0DF
		// (set) Token: 0x0603A6CC RID: 239308 RVA: 0x007DDEE7 File Offset: 0x007DC0E7
		public object Value { get; set; }

		// Token: 0x0603A6CD RID: 239309 RVA: 0x007DDEF0 File Offset: 0x007DC0F0
		public TAssistCharacterMoveTypeUnion()
		{
			this.Type = TAssistCharacterMoveType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A6CE RID: 239310 RVA: 0x007DDF06 File Offset: 0x007DC106
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A6CF RID: 239311 RVA: 0x007DDF18 File Offset: 0x007DC118
		public IAssistCharacterNavigationMoveT AsIAssistCharacterNavigationMove()
		{
			return this.As<IAssistCharacterNavigationMoveT>();
		}

		// Token: 0x0603A6D0 RID: 239312 RVA: 0x007DDF20 File Offset: 0x007DC120
		public static TAssistCharacterMoveTypeUnion FromIAssistCharacterNavigationMove(IAssistCharacterNavigationMoveT _iassistcharacternavigationmove)
		{
			return new TAssistCharacterMoveTypeUnion
			{
				Type = TAssistCharacterMoveType.IAssistCharacterNavigationMove,
				Value = _iassistcharacternavigationmove
			};
		}

		// Token: 0x0603A6D1 RID: 239313 RVA: 0x007DDF35 File Offset: 0x007DC135
		public IAssistCharacterSplineMoveT AsIAssistCharacterSplineMove()
		{
			return this.As<IAssistCharacterSplineMoveT>();
		}

		// Token: 0x0603A6D2 RID: 239314 RVA: 0x007DDF3D File Offset: 0x007DC13D
		public static TAssistCharacterMoveTypeUnion FromIAssistCharacterSplineMove(IAssistCharacterSplineMoveT _iassistcharactersplinemove)
		{
			return new TAssistCharacterMoveTypeUnion
			{
				Type = TAssistCharacterMoveType.IAssistCharacterSplineMove,
				Value = _iassistcharactersplinemove
			};
		}

		// Token: 0x0603A6D3 RID: 239315 RVA: 0x007DDF54 File Offset: 0x007DC154
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
