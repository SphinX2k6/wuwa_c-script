using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006639 RID: 26169
	public struct IElementalBoxTargetRelativePos : IFlatbufferObject
	{
		// Token: 0x1700C266 RID: 49766
		// (get) Token: 0x0602D717 RID: 186135 RVA: 0x006398A5 File Offset: 0x00637AA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D718 RID: 186136 RVA: 0x006398B2 File Offset: 0x00637AB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D719 RID: 186137 RVA: 0x006398BC File Offset: 0x00637ABC
		public static IElementalBoxTargetRelativePos GetRootAsIElementalBoxTargetRelativePos(ByteBuffer _bb)
		{
			return IElementalBoxTargetRelativePos.GetRootAsIElementalBoxTargetRelativePos(_bb, default(IElementalBoxTargetRelativePos));
		}

		// Token: 0x0602D71A RID: 186138 RVA: 0x006398D8 File Offset: 0x00637AD8
		public static IElementalBoxTargetRelativePos GetRootAsIElementalBoxTargetRelativePos(ByteBuffer _bb, IElementalBoxTargetRelativePos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D71B RID: 186139 RVA: 0x006398F5 File Offset: 0x00637AF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D71C RID: 186140 RVA: 0x00639904 File Offset: 0x00637B04
		public IElementalBoxTargetRelativePos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C267 RID: 49767
		// (get) Token: 0x0602D71D RID: 186141 RVA: 0x00639914 File Offset: 0x00637B14
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

		// Token: 0x1700C268 RID: 49768
		// (get) Token: 0x0602D71E RID: 186142 RVA: 0x00639950 File Offset: 0x00637B50
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

		// Token: 0x0602D71F RID: 186143 RVA: 0x006399AD File Offset: 0x00637BAD
		public static Offset<IElementalBoxTargetRelativePos> CreateIElementalBoxTargetRelativePos(FlatBufferBuilder builder, EElementalBoxTargetPosType Type = EElementalBoxTargetPosType.PrefabElementalBoxTargetPos, Offset<IVectorInfo> RelativePosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IElementalBoxTargetRelativePos.AddRelativePos(builder, RelativePosOffset);
			IElementalBoxTargetRelativePos.AddType(builder, Type);
			return IElementalBoxTargetRelativePos.EndIElementalBoxTargetRelativePos(builder);
		}

		// Token: 0x0602D720 RID: 186144 RVA: 0x006399CA File Offset: 0x00637BCA
		public static void StartIElementalBoxTargetRelativePos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D721 RID: 186145 RVA: 0x006399D3 File Offset: 0x00637BD3
		public static void AddType(FlatBufferBuilder builder, EElementalBoxTargetPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D722 RID: 186146 RVA: 0x006399DE File Offset: 0x00637BDE
		public static void AddRelativePos(FlatBufferBuilder builder, Offset<IVectorInfo> relativePosOffset)
		{
			builder.AddOffset(1, relativePosOffset.Value, 0);
		}

		// Token: 0x0602D723 RID: 186147 RVA: 0x006399EE File Offset: 0x00637BEE
		public static Offset<IElementalBoxTargetRelativePos> EndIElementalBoxTargetRelativePos(FlatBufferBuilder builder)
		{
			return new Offset<IElementalBoxTargetRelativePos>(builder.EndTable());
		}

		// Token: 0x0602D724 RID: 186148 RVA: 0x006399FC File Offset: 0x00637BFC
		public IElementalBoxTargetRelativePosT UnPack()
		{
			IElementalBoxTargetRelativePosT elementalBoxTargetRelativePosT = new IElementalBoxTargetRelativePosT();
			this.UnPackTo(elementalBoxTargetRelativePosT);
			return elementalBoxTargetRelativePosT;
		}

		// Token: 0x0602D725 RID: 186149 RVA: 0x00639A18 File Offset: 0x00637C18
		public void UnPackTo(IElementalBoxTargetRelativePosT _o)
		{
			_o.Type = this.Type;
			_o.RelativePos = ((this.RelativePos != null) ? this.RelativePos.Value.UnPack() : null);
		}

		// Token: 0x0602D726 RID: 186150 RVA: 0x00639A60 File Offset: 0x00637C60
		public static Offset<IElementalBoxTargetRelativePos> Pack(FlatBufferBuilder builder, IElementalBoxTargetRelativePosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IElementalBoxTargetRelativePos>);
			}
			Offset<IVectorInfo> relativePosOffset = (_o.RelativePos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RelativePos);
			return IElementalBoxTargetRelativePos.CreateIElementalBoxTargetRelativePos(builder, _o.Type, relativePosOffset);
		}

		// Token: 0x04010CCF RID: 68815
		private Table __p;
	}
}
