using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E4E RID: 28238
	public struct IFixedPos : IFlatbufferObject
	{
		// Token: 0x1700CEFF RID: 52991
		// (get) Token: 0x06030C77 RID: 199799 RVA: 0x0069EC32 File Offset: 0x0069CE32
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030C78 RID: 199800 RVA: 0x0069EC3F File Offset: 0x0069CE3F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030C79 RID: 199801 RVA: 0x0069EC48 File Offset: 0x0069CE48
		public static IFixedPos GetRootAsIFixedPos(ByteBuffer _bb)
		{
			return IFixedPos.GetRootAsIFixedPos(_bb, default(IFixedPos));
		}

		// Token: 0x06030C7A RID: 199802 RVA: 0x0069EC64 File Offset: 0x0069CE64
		public static IFixedPos GetRootAsIFixedPos(ByteBuffer _bb, IFixedPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030C7B RID: 199803 RVA: 0x0069EC81 File Offset: 0x0069CE81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030C7C RID: 199804 RVA: 0x0069EC90 File Offset: 0x0069CE90
		public IFixedPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF00 RID: 52992
		// (get) Token: 0x06030C7D RID: 199805 RVA: 0x0069ECA0 File Offset: 0x0069CEA0
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

		// Token: 0x1700CF01 RID: 52993
		// (get) Token: 0x06030C7E RID: 199806 RVA: 0x0069ECDC File Offset: 0x0069CEDC
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

		// Token: 0x06030C7F RID: 199807 RVA: 0x0069ED39 File Offset: 0x0069CF39
		public static Offset<IFixedPos> CreateIFixedPos(FlatBufferBuilder builder, ETeleportType Type = ETeleportType.FixedPos, Offset<IPosA> TargetPosOffset = default(Offset<IPosA>))
		{
			builder.StartTable(2);
			IFixedPos.AddTargetPos(builder, TargetPosOffset);
			IFixedPos.AddType(builder, Type);
			return IFixedPos.EndIFixedPos(builder);
		}

		// Token: 0x06030C80 RID: 199808 RVA: 0x0069ED56 File Offset: 0x0069CF56
		public static void StartIFixedPos(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030C81 RID: 199809 RVA: 0x0069ED5F File Offset: 0x0069CF5F
		public static void AddType(FlatBufferBuilder builder, ETeleportType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030C82 RID: 199810 RVA: 0x0069ED6A File Offset: 0x0069CF6A
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IPosA> targetPosOffset)
		{
			builder.AddOffset(1, targetPosOffset.Value, 0);
		}

		// Token: 0x06030C83 RID: 199811 RVA: 0x0069ED7A File Offset: 0x0069CF7A
		public static Offset<IFixedPos> EndIFixedPos(FlatBufferBuilder builder)
		{
			return new Offset<IFixedPos>(builder.EndTable());
		}

		// Token: 0x06030C84 RID: 199812 RVA: 0x0069ED88 File Offset: 0x0069CF88
		public IFixedPosT UnPack()
		{
			IFixedPosT fixedPosT = new IFixedPosT();
			this.UnPackTo(fixedPosT);
			return fixedPosT;
		}

		// Token: 0x06030C85 RID: 199813 RVA: 0x0069EDA4 File Offset: 0x0069CFA4
		public void UnPackTo(IFixedPosT _o)
		{
			_o.Type = this.Type;
			_o.TargetPos = ((this.TargetPos != null) ? this.TargetPos.Value.UnPack() : null);
		}

		// Token: 0x06030C86 RID: 199814 RVA: 0x0069EDEC File Offset: 0x0069CFEC
		public static Offset<IFixedPos> Pack(FlatBufferBuilder builder, IFixedPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFixedPos>);
			}
			Offset<IPosA> targetPosOffset = (_o.TargetPos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.TargetPos);
			return IFixedPos.CreateIFixedPos(builder, _o.Type, targetPosOffset);
		}

		// Token: 0x04011D1E RID: 72990
		private Table __p;
	}
}
