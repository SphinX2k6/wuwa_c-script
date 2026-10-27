using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200624E RID: 25166
	public struct IBvbPlayerOperationType : IFlatbufferObject
	{
		// Token: 0x1700BB91 RID: 48017
		// (get) Token: 0x0602B66A RID: 177770 RVA: 0x005F9800 File Offset: 0x005F7A00
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B66B RID: 177771 RVA: 0x005F980D File Offset: 0x005F7A0D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B66C RID: 177772 RVA: 0x005F9814 File Offset: 0x005F7A14
		public static IBvbPlayerOperationType GetRootAsIBvbPlayerOperationType(ByteBuffer _bb)
		{
			return IBvbPlayerOperationType.GetRootAsIBvbPlayerOperationType(_bb, default(IBvbPlayerOperationType));
		}

		// Token: 0x0602B66D RID: 177773 RVA: 0x005F9830 File Offset: 0x005F7A30
		public static IBvbPlayerOperationType GetRootAsIBvbPlayerOperationType(ByteBuffer _bb, IBvbPlayerOperationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B66E RID: 177774 RVA: 0x005F984D File Offset: 0x005F7A4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B66F RID: 177775 RVA: 0x005F985C File Offset: 0x005F7A5C
		public IBvbPlayerOperationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BB92 RID: 48018
		// (get) Token: 0x0602B670 RID: 177776 RVA: 0x005F986C File Offset: 0x005F7A6C
		public EBvbPlayerOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBvbPlayerOperationType.BvbDeploy;
				}
				return (EBvbPlayerOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B671 RID: 177777 RVA: 0x005F98A8 File Offset: 0x005F7AA8
		public static Offset<IBvbPlayerOperationType> CreateIBvbPlayerOperationType(FlatBufferBuilder builder, EBvbPlayerOperationType Type = EBvbPlayerOperationType.BvbDeploy)
		{
			builder.StartTable(1);
			IBvbPlayerOperationType.AddType(builder, Type);
			return IBvbPlayerOperationType.EndIBvbPlayerOperationType(builder);
		}

		// Token: 0x0602B672 RID: 177778 RVA: 0x005F98BE File Offset: 0x005F7ABE
		public static void StartIBvbPlayerOperationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B673 RID: 177779 RVA: 0x005F98C7 File Offset: 0x005F7AC7
		public static void AddType(FlatBufferBuilder builder, EBvbPlayerOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B674 RID: 177780 RVA: 0x005F98D2 File Offset: 0x005F7AD2
		public static Offset<IBvbPlayerOperationType> EndIBvbPlayerOperationType(FlatBufferBuilder builder)
		{
			return new Offset<IBvbPlayerOperationType>(builder.EndTable());
		}

		// Token: 0x0602B675 RID: 177781 RVA: 0x005F98E0 File Offset: 0x005F7AE0
		public IBvbPlayerOperationTypeT UnPack()
		{
			IBvbPlayerOperationTypeT bvbPlayerOperationTypeT = new IBvbPlayerOperationTypeT();
			this.UnPackTo(bvbPlayerOperationTypeT);
			return bvbPlayerOperationTypeT;
		}

		// Token: 0x0602B676 RID: 177782 RVA: 0x005F98FB File Offset: 0x005F7AFB
		public void UnPackTo(IBvbPlayerOperationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B677 RID: 177783 RVA: 0x005F990C File Offset: 0x005F7B0C
		public static Offset<IBvbPlayerOperationType> Pack(FlatBufferBuilder builder, IBvbPlayerOperationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBvbPlayerOperationType>);
			}
			return IBvbPlayerOperationType.CreateIBvbPlayerOperationType(builder, _o.Type);
		}

		// Token: 0x0401079C RID: 67484
		private Table __p;
	}
}
