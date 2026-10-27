using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077D5 RID: 30677
	public class TTeleportConfigUnion
	{
		// Token: 0x1700E6D1 RID: 59089
		// (get) Token: 0x06037A54 RID: 227924 RVA: 0x00786818 File Offset: 0x00784A18
		// (set) Token: 0x06037A55 RID: 227925 RVA: 0x00786820 File Offset: 0x00784A20
		public TTeleportConfig Type { get; set; }

		// Token: 0x1700E6D2 RID: 59090
		// (get) Token: 0x06037A56 RID: 227926 RVA: 0x00786829 File Offset: 0x00784A29
		// (set) Token: 0x06037A57 RID: 227927 RVA: 0x00786831 File Offset: 0x00784A31
		public object Value { get; set; }

		// Token: 0x06037A58 RID: 227928 RVA: 0x0078683A File Offset: 0x00784A3A
		public TTeleportConfigUnion()
		{
			this.Type = TTeleportConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06037A59 RID: 227929 RVA: 0x00786850 File Offset: 0x00784A50
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037A5A RID: 227930 RVA: 0x00786862 File Offset: 0x00784A62
		public IFixedPosT AsIFixedPos()
		{
			return this.As<IFixedPosT>();
		}

		// Token: 0x06037A5B RID: 227931 RVA: 0x0078686A File Offset: 0x00784A6A
		public static TTeleportConfigUnion FromIFixedPos(IFixedPosT _ifixedpos)
		{
			return new TTeleportConfigUnion
			{
				Type = TTeleportConfig.IFixedPos,
				Value = _ifixedpos
			};
		}

		// Token: 0x06037A5C RID: 227932 RVA: 0x0078687F File Offset: 0x00784A7F
		public IGravityFlipFixedPosT AsIGravityFlipFixedPos()
		{
			return this.As<IGravityFlipFixedPosT>();
		}

		// Token: 0x06037A5D RID: 227933 RVA: 0x00786887 File Offset: 0x00784A87
		public static TTeleportConfigUnion FromIGravityFlipFixedPos(IGravityFlipFixedPosT _igravityflipfixedpos)
		{
			return new TTeleportConfigUnion
			{
				Type = TTeleportConfig.IGravityFlipFixedPos,
				Value = _igravityflipfixedpos
			};
		}

		// Token: 0x06037A5E RID: 227934 RVA: 0x0078689C File Offset: 0x00784A9C
		public INearestEntityT AsINearestEntity()
		{
			return this.As<INearestEntityT>();
		}

		// Token: 0x06037A5F RID: 227935 RVA: 0x007868A4 File Offset: 0x00784AA4
		public static TTeleportConfigUnion FromINearestEntity(INearestEntityT _inearestentity)
		{
			return new TTeleportConfigUnion
			{
				Type = TTeleportConfig.INearestEntity,
				Value = _inearestentity
			};
		}

		// Token: 0x06037A60 RID: 227936 RVA: 0x007868B9 File Offset: 0x00784AB9
		public ISafePosT AsISafePos()
		{
			return this.As<ISafePosT>();
		}

		// Token: 0x06037A61 RID: 227937 RVA: 0x007868C1 File Offset: 0x00784AC1
		public static TTeleportConfigUnion FromISafePos(ISafePosT _isafepos)
		{
			return new TTeleportConfigUnion
			{
				Type = TTeleportConfig.ISafePos,
				Value = _isafepos
			};
		}

		// Token: 0x06037A62 RID: 227938 RVA: 0x007868D8 File Offset: 0x00784AD8
		public static int Pack(FlatBufferBuilder builder, TTeleportConfigUnion _o)
		{
			switch (_o.Type)
			{
			case TTeleportConfig.IFixedPos:
				return IFixedPos.Pack(builder, _o.AsIFixedPos()).Value;
			case TTeleportConfig.IGravityFlipFixedPos:
				return IGravityFlipFixedPos.Pack(builder, _o.AsIGravityFlipFixedPos()).Value;
			case TTeleportConfig.INearestEntity:
				return INearestEntity.Pack(builder, _o.AsINearestEntity()).Value;
			case TTeleportConfig.ISafePos:
				return ISafePos.Pack(builder, _o.AsISafePos()).Value;
			default:
				return 0;
			}
		}
	}
}
