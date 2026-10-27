using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D6B RID: 28011
	public struct IPosRot : IFlatbufferObject
	{
		// Token: 0x1700D0F1 RID: 53489
		// (get) Token: 0x06031776 RID: 202614 RVA: 0x006B4D74 File Offset: 0x006B2F74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031777 RID: 202615 RVA: 0x006B4D81 File Offset: 0x006B2F81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031778 RID: 202616 RVA: 0x006B4D88 File Offset: 0x006B2F88
		public static IPosRot GetRootAsIPosRot(ByteBuffer _bb)
		{
			return IPosRot.GetRootAsIPosRot(_bb, default(IPosRot));
		}

		// Token: 0x06031779 RID: 202617 RVA: 0x006B4DA4 File Offset: 0x006B2FA4
		public static IPosRot GetRootAsIPosRot(ByteBuffer _bb, IPosRot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603177A RID: 202618 RVA: 0x006B4DC1 File Offset: 0x006B2FC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603177B RID: 202619 RVA: 0x006B4DD0 File Offset: 0x006B2FD0
		public IPosRot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0F2 RID: 53490
		// (get) Token: 0x0603177C RID: 202620 RVA: 0x006B4DE0 File Offset: 0x006B2FE0
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

		// Token: 0x1700D0F3 RID: 53491
		// (get) Token: 0x0603177D RID: 202621 RVA: 0x006B4E40 File Offset: 0x006B3040
		public IVectorInfo? Rot
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

		// Token: 0x0603177E RID: 202622 RVA: 0x006B4E9D File Offset: 0x006B309D
		public static Offset<IPosRot> CreateIPosRot(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPosRot.AddRot(builder, RotOffset);
			IPosRot.AddPos(builder, PosOffset);
			return IPosRot.EndIPosRot(builder);
		}

		// Token: 0x0603177F RID: 202623 RVA: 0x006B4EBA File Offset: 0x006B30BA
		public static void StartIPosRot(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06031780 RID: 202624 RVA: 0x006B4EC3 File Offset: 0x006B30C3
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x06031781 RID: 202625 RVA: 0x006B4ED3 File Offset: 0x006B30D3
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x06031782 RID: 202626 RVA: 0x006B4EE3 File Offset: 0x006B30E3
		public static Offset<IPosRot> EndIPosRot(FlatBufferBuilder builder)
		{
			return new Offset<IPosRot>(builder.EndTable());
		}

		// Token: 0x06031783 RID: 202627 RVA: 0x006B4EF0 File Offset: 0x006B30F0
		public IPosRotT UnPack()
		{
			IPosRotT posRotT = new IPosRotT();
			this.UnPackTo(posRotT);
			return posRotT;
		}

		// Token: 0x06031784 RID: 202628 RVA: 0x006B4F0C File Offset: 0x006B310C
		public void UnPackTo(IPosRotT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x06031785 RID: 202629 RVA: 0x006B4F78 File Offset: 0x006B3178
		public static Offset<IPosRot> Pack(FlatBufferBuilder builder, IPosRotT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPosRot>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			return IPosRot.CreateIPosRot(builder, posOffset, rotOffset);
		}

		// Token: 0x04011729 RID: 71465
		private Table __p;
	}
}
