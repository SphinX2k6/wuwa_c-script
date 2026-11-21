using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CE9 RID: 27881
	public struct IEnableMoveOperation : IFlatbufferObject
	{
		// Token: 0x1700CC7B RID: 52347
		// (get) Token: 0x060300FE RID: 196862 RVA: 0x00689E52 File Offset: 0x00688052
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060300FF RID: 196863 RVA: 0x00689E5F File Offset: 0x0068805F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030100 RID: 196864 RVA: 0x00689E68 File Offset: 0x00688068
		public static IEnableMoveOperation GetRootAsIEnableMoveOperation(ByteBuffer _bb)
		{
			return IEnableMoveOperation.GetRootAsIEnableMoveOperation(_bb, default(IEnableMoveOperation));
		}

		// Token: 0x06030101 RID: 196865 RVA: 0x00689E84 File Offset: 0x00688084
		public static IEnableMoveOperation GetRootAsIEnableMoveOperation(ByteBuffer _bb, IEnableMoveOperation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030102 RID: 196866 RVA: 0x00689EA1 File Offset: 0x006880A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030103 RID: 196867 RVA: 0x00689EB0 File Offset: 0x006880B0
		public IEnableMoveOperation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC7C RID: 52348
		// (get) Token: 0x06030104 RID: 196868 RVA: 0x00689EC0 File Offset: 0x006880C0
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

		// Token: 0x06030105 RID: 196869 RVA: 0x00689EFC File Offset: 0x006880FC
		public static Offset<IEnableMoveOperation> CreateIEnableMoveOperation(FlatBufferBuilder builder, EMoveOperationType Type = EMoveOperationType.Enable)
		{
			builder.StartTable(1);
			IEnableMoveOperation.AddType(builder, Type);
			return IEnableMoveOperation.EndIEnableMoveOperation(builder);
		}

		// Token: 0x06030106 RID: 196870 RVA: 0x00689F12 File Offset: 0x00688112
		public static void StartIEnableMoveOperation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030107 RID: 196871 RVA: 0x00689F1B File Offset: 0x0068811B
		public static void AddType(FlatBufferBuilder builder, EMoveOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030108 RID: 196872 RVA: 0x00689F26 File Offset: 0x00688126
		public static Offset<IEnableMoveOperation> EndIEnableMoveOperation(FlatBufferBuilder builder)
		{
			return new Offset<IEnableMoveOperation>(builder.EndTable());
		}

		// Token: 0x06030109 RID: 196873 RVA: 0x00689F34 File Offset: 0x00688134
		public IEnableMoveOperationT UnPack()
		{
			IEnableMoveOperationT enableMoveOperationT = new IEnableMoveOperationT();
			this.UnPackTo(enableMoveOperationT);
			return enableMoveOperationT;
		}

		// Token: 0x0603010A RID: 196874 RVA: 0x00689F4F File Offset: 0x0068814F
		public void UnPackTo(IEnableMoveOperationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603010B RID: 196875 RVA: 0x00689F60 File Offset: 0x00688160
		public static Offset<IEnableMoveOperation> Pack(FlatBufferBuilder builder, IEnableMoveOperationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableMoveOperation>);
			}
			return IEnableMoveOperation.CreateIEnableMoveOperation(builder, _o.Type);
		}

		// Token: 0x04011B3B RID: 72507
		private Table __p;
	}
}
