using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007294 RID: 29332
	public struct IMoveOperationType : IFlatbufferObject
	{
		// Token: 0x1700D701 RID: 55041
		// (get) Token: 0x060331D0 RID: 209360 RVA: 0x006E5B37 File Offset: 0x006E3D37
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060331D1 RID: 209361 RVA: 0x006E5B44 File Offset: 0x006E3D44
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060331D2 RID: 209362 RVA: 0x006E5B4C File Offset: 0x006E3D4C
		public static IMoveOperationType GetRootAsIMoveOperationType(ByteBuffer _bb)
		{
			return IMoveOperationType.GetRootAsIMoveOperationType(_bb, default(IMoveOperationType));
		}

		// Token: 0x060331D3 RID: 209363 RVA: 0x006E5B68 File Offset: 0x006E3D68
		public static IMoveOperationType GetRootAsIMoveOperationType(ByteBuffer _bb, IMoveOperationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060331D4 RID: 209364 RVA: 0x006E5B85 File Offset: 0x006E3D85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060331D5 RID: 209365 RVA: 0x006E5B94 File Offset: 0x006E3D94
		public IMoveOperationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D702 RID: 55042
		// (get) Token: 0x060331D6 RID: 209366 RVA: 0x006E5BA4 File Offset: 0x006E3DA4
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

		// Token: 0x060331D7 RID: 209367 RVA: 0x006E5BE0 File Offset: 0x006E3DE0
		public static Offset<IMoveOperationType> CreateIMoveOperationType(FlatBufferBuilder builder, EMoveOperationType Type = EMoveOperationType.Enable)
		{
			builder.StartTable(1);
			IMoveOperationType.AddType(builder, Type);
			return IMoveOperationType.EndIMoveOperationType(builder);
		}

		// Token: 0x060331D8 RID: 209368 RVA: 0x006E5BF6 File Offset: 0x006E3DF6
		public static void StartIMoveOperationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060331D9 RID: 209369 RVA: 0x006E5BFF File Offset: 0x006E3DFF
		public static void AddType(FlatBufferBuilder builder, EMoveOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060331DA RID: 209370 RVA: 0x006E5C0A File Offset: 0x006E3E0A
		public static Offset<IMoveOperationType> EndIMoveOperationType(FlatBufferBuilder builder)
		{
			return new Offset<IMoveOperationType>(builder.EndTable());
		}

		// Token: 0x060331DB RID: 209371 RVA: 0x006E5C18 File Offset: 0x006E3E18
		public IMoveOperationTypeT UnPack()
		{
			IMoveOperationTypeT moveOperationTypeT = new IMoveOperationTypeT();
			this.UnPackTo(moveOperationTypeT);
			return moveOperationTypeT;
		}

		// Token: 0x060331DC RID: 209372 RVA: 0x006E5C33 File Offset: 0x006E3E33
		public void UnPackTo(IMoveOperationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060331DD RID: 209373 RVA: 0x006E5C44 File Offset: 0x006E3E44
		public static Offset<IMoveOperationType> Pack(FlatBufferBuilder builder, IMoveOperationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMoveOperationType>);
			}
			return IMoveOperationType.CreateIMoveOperationType(builder, _o.Type);
		}

		// Token: 0x04012316 RID: 74518
		private Table __p;
	}
}
