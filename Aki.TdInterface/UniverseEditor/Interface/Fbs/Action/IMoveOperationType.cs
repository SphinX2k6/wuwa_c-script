using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B4E RID: 27470
	public struct IMoveOperationType : IFlatbufferObject
	{
		// Token: 0x1700CC1C RID: 52252
		// (get) Token: 0x06030379 RID: 197497 RVA: 0x0068D57B File Offset: 0x0068B77B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603037A RID: 197498 RVA: 0x0068D588 File Offset: 0x0068B788
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603037B RID: 197499 RVA: 0x0068D590 File Offset: 0x0068B790
		public static IMoveOperationType GetRootAsIMoveOperationType(ByteBuffer _bb)
		{
			return IMoveOperationType.GetRootAsIMoveOperationType(_bb, default(IMoveOperationType));
		}

		// Token: 0x0603037C RID: 197500 RVA: 0x0068D5AC File Offset: 0x0068B7AC
		public static IMoveOperationType GetRootAsIMoveOperationType(ByteBuffer _bb, IMoveOperationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603037D RID: 197501 RVA: 0x0068D5C9 File Offset: 0x0068B7C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603037E RID: 197502 RVA: 0x0068D5D8 File Offset: 0x0068B7D8
		public IMoveOperationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC1D RID: 52253
		// (get) Token: 0x0603037F RID: 197503 RVA: 0x0068D5E8 File Offset: 0x0068B7E8
		public EMoveOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMoveOperationType.Enable;
				}
				return (EMoveOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030380 RID: 197504 RVA: 0x0068D624 File Offset: 0x0068B824
		public static Offset<IMoveOperationType> CreateIMoveOperationType(FlatBufferBuilder builder, EMoveOperationType Type = EMoveOperationType.Enable)
		{
			builder.StartTable(1);
			IMoveOperationType.AddType(builder, Type);
			return IMoveOperationType.EndIMoveOperationType(builder);
		}

		// Token: 0x06030381 RID: 197505 RVA: 0x0068D63A File Offset: 0x0068B83A
		public static void StartIMoveOperationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030382 RID: 197506 RVA: 0x0068D643 File Offset: 0x0068B843
		public static void AddType(FlatBufferBuilder builder, EMoveOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030383 RID: 197507 RVA: 0x0068D64E File Offset: 0x0068B84E
		public static Offset<IMoveOperationType> EndIMoveOperationType(FlatBufferBuilder builder)
		{
			return new Offset<IMoveOperationType>(builder.EndTable());
		}

		// Token: 0x06030384 RID: 197508 RVA: 0x0068D65C File Offset: 0x0068B85C
		public IMoveOperationTypeT UnPack()
		{
			IMoveOperationTypeT moveOperationTypeT = new IMoveOperationTypeT();
			this.UnPackTo(moveOperationTypeT);
			return moveOperationTypeT;
		}

		// Token: 0x06030385 RID: 197509 RVA: 0x0068D677 File Offset: 0x0068B877
		public void UnPackTo(IMoveOperationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030386 RID: 197510 RVA: 0x0068D688 File Offset: 0x0068B888
		public static Offset<IMoveOperationType> Pack(FlatBufferBuilder builder, IMoveOperationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveOperationType>);
			}
			return IMoveOperationType.CreateIMoveOperationType(builder, _o.Type);
		}

		// Token: 0x040113ED RID: 70637
		private Table __p;
	}
}
