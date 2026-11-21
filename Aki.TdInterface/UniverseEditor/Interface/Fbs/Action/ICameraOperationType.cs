using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006904 RID: 26884
	public struct ICameraOperationType : IFlatbufferObject
	{
		// Token: 0x1700C5DE RID: 50654
		// (get) Token: 0x0602E0E4 RID: 188644 RVA: 0x0064B52D File Offset: 0x0064972D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E0E5 RID: 188645 RVA: 0x0064B53A File Offset: 0x0064973A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E0E6 RID: 188646 RVA: 0x0064B544 File Offset: 0x00649744
		public static ICameraOperationType GetRootAsICameraOperationType(ByteBuffer _bb)
		{
			return ICameraOperationType.GetRootAsICameraOperationType(_bb, default(ICameraOperationType));
		}

		// Token: 0x0602E0E7 RID: 188647 RVA: 0x0064B560 File Offset: 0x00649760
		public static ICameraOperationType GetRootAsICameraOperationType(ByteBuffer _bb, ICameraOperationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E0E8 RID: 188648 RVA: 0x0064B57D File Offset: 0x0064977D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E0E9 RID: 188649 RVA: 0x0064B58C File Offset: 0x0064978C
		public ICameraOperationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C5DF RID: 50655
		// (get) Token: 0x0602E0EA RID: 188650 RVA: 0x0064B59C File Offset: 0x0064979C
		public ECameraOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECameraOperationType.Enable;
				}
				return (ECameraOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E0EB RID: 188651 RVA: 0x0064B5D8 File Offset: 0x006497D8
		public static Offset<ICameraOperationType> CreateICameraOperationType(FlatBufferBuilder builder, ECameraOperationType Type = ECameraOperationType.Enable)
		{
			builder.StartTable(1);
			ICameraOperationType.AddType(builder, Type);
			return ICameraOperationType.EndICameraOperationType(builder);
		}

		// Token: 0x0602E0EC RID: 188652 RVA: 0x0064B5EE File Offset: 0x006497EE
		public static void StartICameraOperationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602E0ED RID: 188653 RVA: 0x0064B5F7 File Offset: 0x006497F7
		public static void AddType(FlatBufferBuilder builder, ECameraOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E0EE RID: 188654 RVA: 0x0064B602 File Offset: 0x00649802
		public static Offset<ICameraOperationType> EndICameraOperationType(FlatBufferBuilder builder)
		{
			return new Offset<ICameraOperationType>(builder.EndTable());
		}

		// Token: 0x0602E0EF RID: 188655 RVA: 0x0064B610 File Offset: 0x00649810
		public ICameraOperationTypeT UnPack()
		{
			ICameraOperationTypeT cameraOperationTypeT = new ICameraOperationTypeT();
			this.UnPackTo(cameraOperationTypeT);
			return cameraOperationTypeT;
		}

		// Token: 0x0602E0F0 RID: 188656 RVA: 0x0064B62B File Offset: 0x0064982B
		public void UnPackTo(ICameraOperationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602E0F1 RID: 188657 RVA: 0x0064B63C File Offset: 0x0064983C
		public static Offset<ICameraOperationType> Pack(FlatBufferBuilder builder, ICameraOperationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraOperationType>);
			}
			return ICameraOperationType.CreateICameraOperationType(builder, _o.Type);
		}

		// Token: 0x04011631 RID: 71217
		private Table __p;
	}
}
