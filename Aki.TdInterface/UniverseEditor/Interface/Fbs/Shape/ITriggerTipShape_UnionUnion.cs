using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004080 RID: 16512
	public class ITriggerTipShape_UnionUnion
	{
		// Token: 0x17007068 RID: 28776
		// (get) Token: 0x06016BB5 RID: 93109 RVA: 0x0033F67D File Offset: 0x0033D87D
		// (set) Token: 0x06016BB6 RID: 93110 RVA: 0x0033F685 File Offset: 0x0033D885
		public ITriggerTipShape_Union Type { get; set; }

		// Token: 0x17007069 RID: 28777
		// (get) Token: 0x06016BB7 RID: 93111 RVA: 0x0033F68E File Offset: 0x0033D88E
		// (set) Token: 0x06016BB8 RID: 93112 RVA: 0x0033F696 File Offset: 0x0033D896
		public object Value { get; set; }

		// Token: 0x06016BB9 RID: 93113 RVA: 0x0033F69F File Offset: 0x0033D89F
		public ITriggerTipShape_UnionUnion()
		{
			this.Type = ITriggerTipShape_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016BBA RID: 93114 RVA: 0x0033F6B5 File Offset: 0x0033D8B5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016BBB RID: 93115 RVA: 0x0033F6C7 File Offset: 0x0033D8C7
		public ITriggerTipShapeT AsITriggerTipShape()
		{
			return this.As<ITriggerTipShapeT>();
		}

		// Token: 0x06016BBC RID: 93116 RVA: 0x0033F6CF File Offset: 0x0033D8CF
		public static ITriggerTipShape_UnionUnion FromITriggerTipShape(ITriggerTipShapeT _itriggertipshape)
		{
			return new ITriggerTipShape_UnionUnion
			{
				Type = ITriggerTipShape_Union.ITriggerTipShape,
				Value = _itriggertipshape
			};
		}

		// Token: 0x06016BBD RID: 93117 RVA: 0x0033F6E4 File Offset: 0x0033D8E4
		public IBoxTriggerTipShapeT AsIBoxTriggerTipShape()
		{
			return this.As<IBoxTriggerTipShapeT>();
		}

		// Token: 0x06016BBE RID: 93118 RVA: 0x0033F6EC File Offset: 0x0033D8EC
		public static ITriggerTipShape_UnionUnion FromIBoxTriggerTipShape(IBoxTriggerTipShapeT _iboxtriggertipshape)
		{
			return new ITriggerTipShape_UnionUnion
			{
				Type = ITriggerTipShape_Union.IBoxTriggerTipShape,
				Value = _iboxtriggertipshape
			};
		}

		// Token: 0x06016BBF RID: 93119 RVA: 0x0033F701 File Offset: 0x0033D901
		public ISphereTriggerTipShapeT AsISphereTriggerTipShape()
		{
			return this.As<ISphereTriggerTipShapeT>();
		}

		// Token: 0x06016BC0 RID: 93120 RVA: 0x0033F709 File Offset: 0x0033D909
		public static ITriggerTipShape_UnionUnion FromISphereTriggerTipShape(ISphereTriggerTipShapeT _ispheretriggertipshape)
		{
			return new ITriggerTipShape_UnionUnion
			{
				Type = ITriggerTipShape_Union.ISphereTriggerTipShape,
				Value = _ispheretriggertipshape
			};
		}

		// Token: 0x06016BC1 RID: 93121 RVA: 0x0033F720 File Offset: 0x0033D920
		public static int Pack(FlatBufferBuilder builder, ITriggerTipShape_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITriggerTipShape_Union.ITriggerTipShape:
				return ITriggerTipShape.Pack(builder, _o.AsITriggerTipShape()).Value;
			case ITriggerTipShape_Union.IBoxTriggerTipShape:
				return IBoxTriggerTipShape.Pack(builder, _o.AsIBoxTriggerTipShape()).Value;
			case ITriggerTipShape_Union.ISphereTriggerTipShape:
				return ISphereTriggerTipShape.Pack(builder, _o.AsISphereTriggerTipShape()).Value;
			default:
				return 0;
			}
		}
	}
}
