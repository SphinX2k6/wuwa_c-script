using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FDA RID: 32730
	public class TSplineMoveTargetUnion
	{
		// Token: 0x1700F309 RID: 62217
		// (get) Token: 0x0603AED3 RID: 241363 RVA: 0x007EA5A8 File Offset: 0x007E87A8
		// (set) Token: 0x0603AED4 RID: 241364 RVA: 0x007EA5B0 File Offset: 0x007E87B0
		public TSplineMoveTarget Type { get; set; }

		// Token: 0x1700F30A RID: 62218
		// (get) Token: 0x0603AED5 RID: 241365 RVA: 0x007EA5B9 File Offset: 0x007E87B9
		// (set) Token: 0x0603AED6 RID: 241366 RVA: 0x007EA5C1 File Offset: 0x007E87C1
		public object Value { get; set; }

		// Token: 0x0603AED7 RID: 241367 RVA: 0x007EA5CA File Offset: 0x007E87CA
		public TSplineMoveTargetUnion()
		{
			this.Type = TSplineMoveTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0603AED8 RID: 241368 RVA: 0x007EA5E0 File Offset: 0x007E87E0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AED9 RID: 241369 RVA: 0x007EA5F2 File Offset: 0x007E87F2
		public IAssistCharacterSplineMoveTargetT AsIAssistCharacterSplineMoveTarget()
		{
			return this.As<IAssistCharacterSplineMoveTargetT>();
		}

		// Token: 0x0603AEDA RID: 241370 RVA: 0x007EA5FA File Offset: 0x007E87FA
		public static TSplineMoveTargetUnion FromIAssistCharacterSplineMoveTarget(IAssistCharacterSplineMoveTargetT _iassistcharactersplinemovetarget)
		{
			return new TSplineMoveTargetUnion
			{
				Type = TSplineMoveTarget.IAssistCharacterSplineMoveTarget,
				Value = _iassistcharactersplinemovetarget
			};
		}

		// Token: 0x0603AEDB RID: 241371 RVA: 0x007EA60F File Offset: 0x007E880F
		public IEntitySplineMoveTargetT AsIEntitySplineMoveTarget()
		{
			return this.As<IEntitySplineMoveTargetT>();
		}

		// Token: 0x0603AEDC RID: 241372 RVA: 0x007EA617 File Offset: 0x007E8817
		public static TSplineMoveTargetUnion FromIEntitySplineMoveTarget(IEntitySplineMoveTargetT _ientitysplinemovetarget)
		{
			return new TSplineMoveTargetUnion
			{
				Type = TSplineMoveTarget.IEntitySplineMoveTarget,
				Value = _ientitysplinemovetarget
			};
		}

		// Token: 0x0603AEDD RID: 241373 RVA: 0x007EA62C File Offset: 0x007E882C
		public IPlayerSplineMoveTargetT AsIPlayerSplineMoveTarget()
		{
			return this.As<IPlayerSplineMoveTargetT>();
		}

		// Token: 0x0603AEDE RID: 241374 RVA: 0x007EA634 File Offset: 0x007E8834
		public static TSplineMoveTargetUnion FromIPlayerSplineMoveTarget(IPlayerSplineMoveTargetT _iplayersplinemovetarget)
		{
			return new TSplineMoveTargetUnion
			{
				Type = TSplineMoveTarget.IPlayerSplineMoveTarget,
				Value = _iplayersplinemovetarget
			};
		}

		// Token: 0x0603AEDF RID: 241375 RVA: 0x007EA64C File Offset: 0x007E884C
		public static int Pack(FlatBufferBuilder builder, TSplineMoveTargetUnion _o)
		{
			switch (_o.Type)
			{
			case TSplineMoveTarget.IAssistCharacterSplineMoveTarget:
				return IAssistCharacterSplineMoveTarget.Pack(builder, _o.AsIAssistCharacterSplineMoveTarget()).Value;
			case TSplineMoveTarget.IEntitySplineMoveTarget:
				return IEntitySplineMoveTarget.Pack(builder, _o.AsIEntitySplineMoveTarget()).Value;
			case TSplineMoveTarget.IPlayerSplineMoveTarget:
				return IPlayerSplineMoveTarget.Pack(builder, _o.AsIPlayerSplineMoveTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
