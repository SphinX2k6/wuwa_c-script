using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CDE RID: 23774
	public struct IPathDrivenActorMoveBase : IFlatbufferObject
	{
		// Token: 0x1700AEB0 RID: 44720
		// (get) Token: 0x0602777F RID: 161663 RVA: 0x00566C5E File Offset: 0x00564E5E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027780 RID: 161664 RVA: 0x00566C6B File Offset: 0x00564E6B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027781 RID: 161665 RVA: 0x00566C74 File Offset: 0x00564E74
		public static IPathDrivenActorMoveBase GetRootAsIPathDrivenActorMoveBase(ByteBuffer _bb)
		{
			return IPathDrivenActorMoveBase.GetRootAsIPathDrivenActorMoveBase(_bb, default(IPathDrivenActorMoveBase));
		}

		// Token: 0x06027782 RID: 161666 RVA: 0x00566C90 File Offset: 0x00564E90
		public static IPathDrivenActorMoveBase GetRootAsIPathDrivenActorMoveBase(ByteBuffer _bb, IPathDrivenActorMoveBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027783 RID: 161667 RVA: 0x00566CAD File Offset: 0x00564EAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027784 RID: 161668 RVA: 0x00566CBC File Offset: 0x00564EBC
		public IPathDrivenActorMoveBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEB1 RID: 44721
		// (get) Token: 0x06027785 RID: 161669 RVA: 0x00566CCC File Offset: 0x00564ECC
		public EPathDrivenActorMoveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPathDrivenActorMoveType.Spline;
				}
				return (EPathDrivenActorMoveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027786 RID: 161670 RVA: 0x00566D08 File Offset: 0x00564F08
		public static Offset<IPathDrivenActorMoveBase> CreateIPathDrivenActorMoveBase(FlatBufferBuilder builder, EPathDrivenActorMoveType Type = EPathDrivenActorMoveType.Spline)
		{
			builder.StartTable(1);
			IPathDrivenActorMoveBase.AddType(builder, Type);
			return IPathDrivenActorMoveBase.EndIPathDrivenActorMoveBase(builder);
		}

		// Token: 0x06027787 RID: 161671 RVA: 0x00566D1E File Offset: 0x00564F1E
		public static void StartIPathDrivenActorMoveBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027788 RID: 161672 RVA: 0x00566D27 File Offset: 0x00564F27
		public static void AddType(FlatBufferBuilder builder, EPathDrivenActorMoveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027789 RID: 161673 RVA: 0x00566D32 File Offset: 0x00564F32
		public static Offset<IPathDrivenActorMoveBase> EndIPathDrivenActorMoveBase(FlatBufferBuilder builder)
		{
			return new Offset<IPathDrivenActorMoveBase>(builder.EndTable());
		}

		// Token: 0x0602778A RID: 161674 RVA: 0x00566D40 File Offset: 0x00564F40
		public IPathDrivenActorMoveBaseT UnPack()
		{
			IPathDrivenActorMoveBaseT pathDrivenActorMoveBaseT = new IPathDrivenActorMoveBaseT();
			this.UnPackTo(pathDrivenActorMoveBaseT);
			return pathDrivenActorMoveBaseT;
		}

		// Token: 0x0602778B RID: 161675 RVA: 0x00566D5B File Offset: 0x00564F5B
		public void UnPackTo(IPathDrivenActorMoveBaseT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602778C RID: 161676 RVA: 0x00566D6C File Offset: 0x00564F6C
		public static Offset<IPathDrivenActorMoveBase> Pack(FlatBufferBuilder builder, IPathDrivenActorMoveBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathDrivenActorMoveBase>);
			}
			return IPathDrivenActorMoveBase.CreateIPathDrivenActorMoveBase(builder, _o.Type);
		}

		// Token: 0x0400F80D RID: 63501
		private Table __p;
	}
}
