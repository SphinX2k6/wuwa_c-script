using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003B4B RID: 15179
	public class TBlackBoardUnion
	{
		// Token: 0x1700681B RID: 26651
		// (get) Token: 0x06014BF9 RID: 84985 RVA: 0x003040AC File Offset: 0x003022AC
		// (set) Token: 0x06014BFA RID: 84986 RVA: 0x003040B4 File Offset: 0x003022B4
		public TBlackBoard Type { get; set; }

		// Token: 0x1700681C RID: 26652
		// (get) Token: 0x06014BFB RID: 84987 RVA: 0x003040BD File Offset: 0x003022BD
		// (set) Token: 0x06014BFC RID: 84988 RVA: 0x003040C5 File Offset: 0x003022C5
		public object Value { get; set; }

		// Token: 0x06014BFD RID: 84989 RVA: 0x003040CE File Offset: 0x003022CE
		public TBlackBoardUnion()
		{
			this.Type = TBlackBoard.NONE;
			this.Value = null;
		}

		// Token: 0x06014BFE RID: 84990 RVA: 0x003040E4 File Offset: 0x003022E4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06014BFF RID: 84991 RVA: 0x003040F6 File Offset: 0x003022F6
		public IBlackBoardBooleanT AsIBlackBoardBoolean()
		{
			return this.As<IBlackBoardBooleanT>();
		}

		// Token: 0x06014C00 RID: 84992 RVA: 0x003040FE File Offset: 0x003022FE
		public static TBlackBoardUnion FromIBlackBoardBoolean(IBlackBoardBooleanT _iblackboardboolean)
		{
			return new TBlackBoardUnion
			{
				Type = TBlackBoard.IBlackBoardBoolean,
				Value = _iblackboardboolean
			};
		}

		// Token: 0x06014C01 RID: 84993 RVA: 0x00304113 File Offset: 0x00302313
		public IBlackBoardEntityIdT AsIBlackBoardEntityId()
		{
			return this.As<IBlackBoardEntityIdT>();
		}

		// Token: 0x06014C02 RID: 84994 RVA: 0x0030411B File Offset: 0x0030231B
		public static TBlackBoardUnion FromIBlackBoardEntityId(IBlackBoardEntityIdT _iblackboardentityid)
		{
			return new TBlackBoardUnion
			{
				Type = TBlackBoard.IBlackBoardEntityId,
				Value = _iblackboardentityid
			};
		}

		// Token: 0x06014C03 RID: 84995 RVA: 0x00304130 File Offset: 0x00302330
		public IBlackBoardEntityPosT AsIBlackBoardEntityPos()
		{
			return this.As<IBlackBoardEntityPosT>();
		}

		// Token: 0x06014C04 RID: 84996 RVA: 0x00304138 File Offset: 0x00302338
		public static TBlackBoardUnion FromIBlackBoardEntityPos(IBlackBoardEntityPosT _iblackboardentitypos)
		{
			return new TBlackBoardUnion
			{
				Type = TBlackBoard.IBlackBoardEntityPos,
				Value = _iblackboardentitypos
			};
		}

		// Token: 0x06014C05 RID: 84997 RVA: 0x0030414D File Offset: 0x0030234D
		public IBlackBoardFloatT AsIBlackBoardFloat()
		{
			return this.As<IBlackBoardFloatT>();
		}

		// Token: 0x06014C06 RID: 84998 RVA: 0x00304155 File Offset: 0x00302355
		public static TBlackBoardUnion FromIBlackBoardFloat(IBlackBoardFloatT _iblackboardfloat)
		{
			return new TBlackBoardUnion
			{
				Type = TBlackBoard.IBlackBoardFloat,
				Value = _iblackboardfloat
			};
		}

		// Token: 0x06014C07 RID: 84999 RVA: 0x0030416A File Offset: 0x0030236A
		public IBlackBoardIntT AsIBlackBoardInt()
		{
			return this.As<IBlackBoardIntT>();
		}

		// Token: 0x06014C08 RID: 85000 RVA: 0x00304172 File Offset: 0x00302372
		public static TBlackBoardUnion FromIBlackBoardInt(IBlackBoardIntT _iblackboardint)
		{
			return new TBlackBoardUnion
			{
				Type = TBlackBoard.IBlackBoardInt,
				Value = _iblackboardint
			};
		}

		// Token: 0x06014C09 RID: 85001 RVA: 0x00304187 File Offset: 0x00302387
		public IBlackBoardStringT AsIBlackBoardString()
		{
			return this.As<IBlackBoardStringT>();
		}

		// Token: 0x06014C0A RID: 85002 RVA: 0x0030418F File Offset: 0x0030238F
		public static TBlackBoardUnion FromIBlackBoardString(IBlackBoardStringT _iblackboardstring)
		{
			return new TBlackBoardUnion
			{
				Type = TBlackBoard.IBlackBoardString,
				Value = _iblackboardstring
			};
		}

		// Token: 0x06014C0B RID: 85003 RVA: 0x003041A4 File Offset: 0x003023A4
		public IBlackBoardVectorT AsIBlackBoardVector()
		{
			return this.As<IBlackBoardVectorT>();
		}

		// Token: 0x06014C0C RID: 85004 RVA: 0x003041AC File Offset: 0x003023AC
		public static TBlackBoardUnion FromIBlackBoardVector(IBlackBoardVectorT _iblackboardvector)
		{
			return new TBlackBoardUnion
			{
				Type = TBlackBoard.IBlackBoardVector,
				Value = _iblackboardvector
			};
		}

		// Token: 0x06014C0D RID: 85005 RVA: 0x003041C4 File Offset: 0x003023C4
		public static int Pack(FlatBufferBuilder builder, TBlackBoardUnion _o)
		{
			switch (_o.Type)
			{
			case TBlackBoard.IBlackBoardBoolean:
				return IBlackBoardBoolean.Pack(builder, _o.AsIBlackBoardBoolean()).Value;
			case TBlackBoard.IBlackBoardEntityId:
				return IBlackBoardEntityId.Pack(builder, _o.AsIBlackBoardEntityId()).Value;
			case TBlackBoard.IBlackBoardEntityPos:
				return IBlackBoardEntityPos.Pack(builder, _o.AsIBlackBoardEntityPos()).Value;
			case TBlackBoard.IBlackBoardFloat:
				return IBlackBoardFloat.Pack(builder, _o.AsIBlackBoardFloat()).Value;
			case TBlackBoard.IBlackBoardInt:
				return IBlackBoardInt.Pack(builder, _o.AsIBlackBoardInt()).Value;
			case TBlackBoard.IBlackBoardString:
				return IBlackBoardString.Pack(builder, _o.AsIBlackBoardString()).Value;
			case TBlackBoard.IBlackBoardVector:
				return IBlackBoardVector.Pack(builder, _o.AsIBlackBoardVector()).Value;
			default:
				return 0;
			}
		}
	}
}
