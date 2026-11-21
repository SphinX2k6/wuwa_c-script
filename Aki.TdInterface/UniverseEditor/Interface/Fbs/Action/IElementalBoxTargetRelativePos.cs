using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CAA RID: 27818
	public struct IElementalBoxTargetRelativePos : IFlatbufferObject
	{
		// Token: 0x1700CC04 RID: 52228
		// (get) Token: 0x0602FEE8 RID: 196328 RVA: 0x0068640D File Offset: 0x0068460D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FEE9 RID: 196329 RVA: 0x0068641A File Offset: 0x0068461A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FEEA RID: 196330 RVA: 0x00686424 File Offset: 0x00684624
		public static IElementalBoxTargetRelativePos GetRootAsIElementalBoxTargetRelativePos(ByteBuffer _bb)
		{
			return IElementalBoxTargetRelativePos.GetRootAsIElementalBoxTargetRelativePos(_bb, default(IElementalBoxTargetRelativePos));
		}

		// Token: 0x0602FEEB RID: 196331 RVA: 0x00686440 File Offset: 0x00684640
		public static IElementalBoxTargetRelativePos GetRootAsIElementalBoxTargetRelativePos(ByteBuffer _bb, IElementalBoxTargetRelativePos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FEEC RID: 196332 RVA: 0x0068645D File Offset: 0x0068465D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FEED RID: 196333 RVA: 0x0068646C File Offset: 0x0068466C
		public IElementalBoxTargetRelativePos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC05 RID: 52229
		// (get) Token: 0x0602FEEE RID: 196334 RVA: 0x0068647C File Offset: 0x0068467C
		public EElementalBoxTargetPosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
				}
				return (EElementalBoxTargetPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CC06 RID: 52230
		// (get) Token: 0x0602FEEF RID: 196335 RVA: 0x006864B8 File Offset: 0x006846B8
		public IVectorInfo? RelativePos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602FEF0 RID: 196336 RVA: 0x00686515 File Offset: 0x00684715
		public static Offset<IElementalBoxTargetRelativePos> CreateIElementalBoxTargetRelativePos(FlatBufferBuilder builder, EElementalBoxTargetPosType Type = EElementalBoxTargetPosType.PrefabElementalBoxTargetPos, Offset<IVectorInfo> RelativePosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IElementalBoxTargetRelativePos.AddRelativePos(builder, RelativePosOffset);
			IElementalBoxTargetRelativePos.AddType(builder, Type);
			return IElementalBoxTargetRelativePos.EndIElementalBoxTargetRelativePos(builder);
		}

		// Token: 0x0602FEF1 RID: 196337 RVA: 0x00686532 File Offset: 0x00684732
		public static void StartIElementalBoxTargetRelativePos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602FEF2 RID: 196338 RVA: 0x0068653B File Offset: 0x0068473B
		public static void AddType(FlatBufferBuilder builder, EElementalBoxTargetPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FEF3 RID: 196339 RVA: 0x00686546 File Offset: 0x00684746
		public static void AddRelativePos(FlatBufferBuilder builder, Offset<IVectorInfo> relativePosOffset)
		{
			builder.AddOffset(1, relativePosOffset.Value, 0);
		}

		// Token: 0x0602FEF4 RID: 196340 RVA: 0x00686556 File Offset: 0x00684756
		public static Offset<IElementalBoxTargetRelativePos> EndIElementalBoxTargetRelativePos(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxTargetRelativePos>(builder.EndTable());
		}

		// Token: 0x0602FEF5 RID: 196341 RVA: 0x00686564 File Offset: 0x00684764
		public IElementalBoxTargetRelativePosT UnPack()
		{
			IElementalBoxTargetRelativePosT elementalBoxTargetRelativePosT = new IElementalBoxTargetRelativePosT();
			this.UnPackTo(elementalBoxTargetRelativePosT);
			return elementalBoxTargetRelativePosT;
		}

		// Token: 0x0602FEF6 RID: 196342 RVA: 0x00686580 File Offset: 0x00684780
		public void UnPackTo(IElementalBoxTargetRelativePosT _o)
		{
			_o.Type = this.Type;
			_o.RelativePos = ((this.RelativePos != null) ? this.RelativePos.Value.UnPack() : null);
		}

		// Token: 0x0602FEF7 RID: 196343 RVA: 0x006865C8 File Offset: 0x006847C8
		public static Offset<IElementalBoxTargetRelativePos> Pack(FlatBufferBuilder builder, IElementalBoxTargetRelativePosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxTargetRelativePos>);
			}
			Offset<IVectorInfo> relativePosOffset = (_o.RelativePos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RelativePos);
			return IElementalBoxTargetRelativePos.CreateIElementalBoxTargetRelativePos(builder, _o.Type, relativePosOffset);
		}

		// Token: 0x04011AEA RID: 72426
		private Table __p;
	}
}
