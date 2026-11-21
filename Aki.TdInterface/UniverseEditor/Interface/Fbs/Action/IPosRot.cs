using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074E6 RID: 29926
	public struct IPosRot : IFlatbufferObject
	{
		// Token: 0x1700DC39 RID: 56377
		// (get) Token: 0x06034772 RID: 214898 RVA: 0x0071045C File Offset: 0x0070E65C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034773 RID: 214899 RVA: 0x00710469 File Offset: 0x0070E669
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06034774 RID: 214900 RVA: 0x00710470 File Offset: 0x0070E670
		public static IPosRot GetRootAsIPosRot(ByteBuffer _bb)
		{
			return IPosRot.GetRootAsIPosRot(_bb, default(IPosRot));
		}

		// Token: 0x06034775 RID: 214901 RVA: 0x0071048C File Offset: 0x0070E68C
		public static IPosRot GetRootAsIPosRot(ByteBuffer _bb, IPosRot obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06034776 RID: 214902 RVA: 0x007104A9 File Offset: 0x0070E6A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06034777 RID: 214903 RVA: 0x007104B8 File Offset: 0x0070E6B8
		public IPosRot __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC3A RID: 56378
		// (get) Token: 0x06034778 RID: 214904 RVA: 0x007104C8 File Offset: 0x0070E6C8
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

		// Token: 0x1700DC3B RID: 56379
		// (get) Token: 0x06034779 RID: 214905 RVA: 0x00710528 File Offset: 0x0070E728
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

		// Token: 0x0603477A RID: 214906 RVA: 0x00710585 File Offset: 0x0070E785
		public static Offset<IPosRot> CreateIPosRot(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(2);
			IPosRot.AddRot(builder, RotOffset);
			IPosRot.AddPos(builder, PosOffset);
			return IPosRot.EndIPosRot(builder);
		}

		// Token: 0x0603477B RID: 214907 RVA: 0x007105A2 File Offset: 0x0070E7A2
		public static void StartIPosRot(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603477C RID: 214908 RVA: 0x007105AB File Offset: 0x0070E7AB
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x0603477D RID: 214909 RVA: 0x007105BB File Offset: 0x0070E7BB
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(1, rotOffset.Value, 0);
		}

		// Token: 0x0603477E RID: 214910 RVA: 0x007105CB File Offset: 0x0070E7CB
		public static Offset<IPosRot> EndIPosRot(FlatBufferBuilder builder)
		{
			return new Offset<IPosRot>(builder.EndTable());
		}

		// Token: 0x0603477F RID: 214911 RVA: 0x007105D8 File Offset: 0x0070E7D8
		public IPosRotT UnPack()
		{
			IPosRotT posRotT = new IPosRotT();
			this.UnPackTo(posRotT);
			return posRotT;
		}

		// Token: 0x06034780 RID: 214912 RVA: 0x007105F4 File Offset: 0x0070E7F4
		public void UnPackTo(IPosRotT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
		}

		// Token: 0x06034781 RID: 214913 RVA: 0x00710660 File Offset: 0x0070E860
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

		// Token: 0x040126A5 RID: 75429
		private Table __p;
	}
}
