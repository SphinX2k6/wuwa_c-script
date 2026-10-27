using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006759 RID: 26457
	public struct IFaceToPos : IFlatbufferObject
	{
		// Token: 0x1700C469 RID: 50281
		// (get) Token: 0x0602E061 RID: 188513 RVA: 0x0064A13C File Offset: 0x0064833C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E062 RID: 188514 RVA: 0x0064A149 File Offset: 0x00648349
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E063 RID: 188515 RVA: 0x0064A150 File Offset: 0x00648350
		public static IFaceToPos GetRootAsIFaceToPos(ByteBuffer _bb)
		{
			return IFaceToPos.GetRootAsIFaceToPos(_bb, default(IFaceToPos));
		}

		// Token: 0x0602E064 RID: 188516 RVA: 0x0064A16C File Offset: 0x0064836C
		public static IFaceToPos GetRootAsIFaceToPos(ByteBuffer _bb, IFaceToPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E065 RID: 188517 RVA: 0x0064A189 File Offset: 0x00648389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E066 RID: 188518 RVA: 0x0064A198 File Offset: 0x00648398
		public IFaceToPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C46A RID: 50282
		// (get) Token: 0x0602E067 RID: 188519 RVA: 0x0064A1A8 File Offset: 0x006483A8
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602E068 RID: 188520 RVA: 0x0064A205 File Offset: 0x00648405
		public static Offset<IFaceToPos> CreateIFaceToPos(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(1);
			IFaceToPos.AddPos(builder, PosOffset);
			return IFaceToPos.EndIFaceToPos(builder);
		}

		// Token: 0x0602E069 RID: 188521 RVA: 0x0064A21B File Offset: 0x0064841B
		public static void StartIFaceToPos(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E06A RID: 188522 RVA: 0x0064A224 File Offset: 0x00648424
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x0602E06B RID: 188523 RVA: 0x0064A234 File Offset: 0x00648434
		public static Offset<IFaceToPos> EndIFaceToPos(FlatBufferBuilder builder)
		{
			return new Offset<IFaceToPos>(builder.EndTable());
		}

		// Token: 0x0602E06C RID: 188524 RVA: 0x0064A244 File Offset: 0x00648444
		public IFaceToPosT UnPack()
		{
			IFaceToPosT faceToPosT = new IFaceToPosT();
			this.UnPackTo(faceToPosT);
			return faceToPosT;
		}

		// Token: 0x0602E06D RID: 188525 RVA: 0x0064A260 File Offset: 0x00648460
		public void UnPackTo(IFaceToPosT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
		}

		// Token: 0x0602E06E RID: 188526 RVA: 0x0064A29C File Offset: 0x0064849C
		public static Offset<IFaceToPos> Pack(FlatBufferBuilder builder, IFaceToPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFaceToPos>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IFaceToPos.CreateIFaceToPos(builder, posOffset);
		}

		// Token: 0x04010E4C RID: 69196
		private Table __p;
	}
}
