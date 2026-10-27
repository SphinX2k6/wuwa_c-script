using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006293 RID: 25235
	public struct ICameraOperationType : IFlatbufferObject
	{
		// Token: 0x1700BC56 RID: 48214
		// (get) Token: 0x0602B983 RID: 178563 RVA: 0x00600725 File Offset: 0x005FE925
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B984 RID: 178564 RVA: 0x00600732 File Offset: 0x005FE932
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B985 RID: 178565 RVA: 0x0060073C File Offset: 0x005FE93C
		public static ICameraOperationType GetRootAsICameraOperationType(ByteBuffer _bb)
		{
			return ICameraOperationType.GetRootAsICameraOperationType(_bb, default(ICameraOperationType));
		}

		// Token: 0x0602B986 RID: 178566 RVA: 0x00600758 File Offset: 0x005FE958
		public static ICameraOperationType GetRootAsICameraOperationType(ByteBuffer _bb, ICameraOperationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B987 RID: 178567 RVA: 0x00600775 File Offset: 0x005FE975
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B988 RID: 178568 RVA: 0x00600784 File Offset: 0x005FE984
		public ICameraOperationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BC57 RID: 48215
		// (get) Token: 0x0602B989 RID: 178569 RVA: 0x00600794 File Offset: 0x005FE994
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

		// Token: 0x0602B98A RID: 178570 RVA: 0x006007D0 File Offset: 0x005FE9D0
		public static Offset<ICameraOperationType> CreateICameraOperationType(FlatBufferBuilder builder, ECameraOperationType Type = ECameraOperationType.Enable)
		{
			builder.StartTable(1);
			ICameraOperationType.AddType(builder, Type);
			return ICameraOperationType.EndICameraOperationType(builder);
		}

		// Token: 0x0602B98B RID: 178571 RVA: 0x006007E6 File Offset: 0x005FE9E6
		public static void StartICameraOperationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B98C RID: 178572 RVA: 0x006007EF File Offset: 0x005FE9EF
		public static void AddType(FlatBufferBuilder builder, ECameraOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B98D RID: 178573 RVA: 0x006007FA File Offset: 0x005FE9FA
		public static Offset<ICameraOperationType> EndICameraOperationType(FlatBufferBuilder builder)
		{
			return new Offset<ICameraOperationType>(builder.EndTable());
		}

		// Token: 0x0602B98E RID: 178574 RVA: 0x00600808 File Offset: 0x005FEA08
		public ICameraOperationTypeT UnPack()
		{
			ICameraOperationTypeT cameraOperationTypeT = new ICameraOperationTypeT();
			this.UnPackTo(cameraOperationTypeT);
			return cameraOperationTypeT;
		}

		// Token: 0x0602B98F RID: 178575 RVA: 0x00600823 File Offset: 0x005FEA23
		public void UnPackTo(ICameraOperationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B990 RID: 178576 RVA: 0x00600834 File Offset: 0x005FEA34
		public static Offset<ICameraOperationType> Pack(FlatBufferBuilder builder, ICameraOperationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICameraOperationType>);
			}
			return ICameraOperationType.CreateICameraOperationType(builder, _o.Type);
		}

		// Token: 0x0401081C RID: 67612
		private Table __p;
	}
}
