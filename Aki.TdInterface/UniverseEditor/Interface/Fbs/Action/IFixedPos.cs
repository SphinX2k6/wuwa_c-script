using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067CE RID: 26574
	public struct IFixedPos : IFlatbufferObject
	{
		// Token: 0x1700C549 RID: 50505
		// (get) Token: 0x0602E431 RID: 189489 RVA: 0x006514EE File Offset: 0x0064F6EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E432 RID: 189490 RVA: 0x006514FB File Offset: 0x0064F6FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E433 RID: 189491 RVA: 0x00651504 File Offset: 0x0064F704
		public static IFixedPos GetRootAsIFixedPos(ByteBuffer _bb)
		{
			return IFixedPos.GetRootAsIFixedPos(_bb, default(IFixedPos));
		}

		// Token: 0x0602E434 RID: 189492 RVA: 0x00651520 File Offset: 0x0064F720
		public static IFixedPos GetRootAsIFixedPos(ByteBuffer _bb, IFixedPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E435 RID: 189493 RVA: 0x0065153D File Offset: 0x0064F73D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E436 RID: 189494 RVA: 0x0065154C File Offset: 0x0064F74C
		public IFixedPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C54A RID: 50506
		// (get) Token: 0x0602E437 RID: 189495 RVA: 0x0065155C File Offset: 0x0064F75C
		public ETeleportType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETeleportType.FixedPos;
				}
				return (ETeleportType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C54B RID: 50507
		// (get) Token: 0x0602E438 RID: 189496 RVA: 0x00651598 File Offset: 0x0064F798
		public IPosA? TargetPos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602E439 RID: 189497 RVA: 0x006515F5 File Offset: 0x0064F7F5
		public static Offset<IFixedPos> CreateIFixedPos(FlatBufferBuilder builder, ETeleportType Type = ETeleportType.FixedPos, Offset<IPosA> TargetPosOffset = default(Offset<IPosA>))
		{
			builder.StartTable(2);
			IFixedPos.AddTargetPos(builder, TargetPosOffset);
			IFixedPos.AddType(builder, Type);
			return IFixedPos.EndIFixedPos(builder);
		}

		// Token: 0x0602E43A RID: 189498 RVA: 0x00651612 File Offset: 0x0064F812
		public static void StartIFixedPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E43B RID: 189499 RVA: 0x0065161B File Offset: 0x0064F81B
		public static void AddType(FlatBufferBuilder builder, ETeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E43C RID: 189500 RVA: 0x00651626 File Offset: 0x0064F826
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IPosA> targetPosOffset)
		{
			builder.AddOffset(1, targetPosOffset.Value, 0);
		}

		// Token: 0x0602E43D RID: 189501 RVA: 0x00651636 File Offset: 0x0064F836
		public static Offset<IFixedPos> EndIFixedPos(FlatBufferBuilder builder)
		{
			return new Offset<IFixedPos>(builder.EndTable());
		}

		// Token: 0x0602E43E RID: 189502 RVA: 0x00651644 File Offset: 0x0064F844
		public IFixedPosT UnPack()
		{
			IFixedPosT fixedPosT = new IFixedPosT();
			this.UnPackTo(fixedPosT);
			return fixedPosT;
		}

		// Token: 0x0602E43F RID: 189503 RVA: 0x00651660 File Offset: 0x0064F860
		public void UnPackTo(IFixedPosT _o)
		{
			_o.Type = this.Type;
			_o.TargetPos = ((this.TargetPos != null) ? this.TargetPos.Value.UnPack() : null);
		}

		// Token: 0x0602E440 RID: 189504 RVA: 0x006516A8 File Offset: 0x0064F8A8
		public static Offset<IFixedPos> Pack(FlatBufferBuilder builder, IFixedPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedPos>);
			}
			Offset<IPosA> targetPosOffset = (_o.TargetPos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.TargetPos);
			return IFixedPos.CreateIFixedPos(builder, _o.Type, targetPosOffset);
		}

		// Token: 0x04010EEC RID: 69356
		private Table __p;
	}
}
