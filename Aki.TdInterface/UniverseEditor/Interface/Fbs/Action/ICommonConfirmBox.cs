using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AE2 RID: 27362
	public struct ICommonConfirmBox : IFlatbufferObject
	{
		// Token: 0x1700C8EC RID: 51436
		// (get) Token: 0x0602F051 RID: 192593 RVA: 0x00669E1F File Offset: 0x0066801F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F052 RID: 192594 RVA: 0x00669E2C File Offset: 0x0066802C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F053 RID: 192595 RVA: 0x00669E34 File Offset: 0x00668034
		public static ICommonConfirmBox GetRootAsICommonConfirmBox(ByteBuffer _bb)
		{
			return ICommonConfirmBox.GetRootAsICommonConfirmBox(_bb, default(ICommonConfirmBox));
		}

		// Token: 0x0602F054 RID: 192596 RVA: 0x00669E50 File Offset: 0x00668050
		public static ICommonConfirmBox GetRootAsICommonConfirmBox(ByteBuffer _bb, ICommonConfirmBox obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F055 RID: 192597 RVA: 0x00669E6D File Offset: 0x0066806D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F056 RID: 192598 RVA: 0x00669E7C File Offset: 0x0066807C
		public ICommonConfirmBox __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C8ED RID: 51437
		// (get) Token: 0x0602F057 RID: 192599 RVA: 0x00669E8C File Offset: 0x0066808C
		public EInteractionConfirmBoxType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractionConfirmBoxType.Common;
				}
				return (EInteractionConfirmBoxType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C8EE RID: 51438
		// (get) Token: 0x0602F058 RID: 192600 RVA: 0x00669EC8 File Offset: 0x006680C8
		public int Id
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F059 RID: 192601 RVA: 0x00669F04 File Offset: 0x00668104
		public static Offset<ICommonConfirmBox> CreateICommonConfirmBox(FlatBufferBuilder builder, EInteractionConfirmBoxType Type = EInteractionConfirmBoxType.Common, int Id = 0)
		{
			builder.StartTable(2);
			ICommonConfirmBox.AddId(builder, Id);
			ICommonConfirmBox.AddType(builder, Type);
			return ICommonConfirmBox.EndICommonConfirmBox(builder);
		}

		// Token: 0x0602F05A RID: 192602 RVA: 0x00669F21 File Offset: 0x00668121
		public static void StartICommonConfirmBox(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602F05B RID: 192603 RVA: 0x00669F2A File Offset: 0x0066812A
		public static void AddType(FlatBufferBuilder builder, EInteractionConfirmBoxType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F05C RID: 192604 RVA: 0x00669F35 File Offset: 0x00668135
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x0602F05D RID: 192605 RVA: 0x00669F40 File Offset: 0x00668140
		public static Offset<ICommonConfirmBox> EndICommonConfirmBox(FlatBufferBuilder builder)
		{
			return new Offset<ICommonConfirmBox>(builder.EndTable());
		}

		// Token: 0x0602F05E RID: 192606 RVA: 0x00669F50 File Offset: 0x00668150
		public ICommonConfirmBoxT UnPack()
		{
			ICommonConfirmBoxT commonConfirmBoxT = new ICommonConfirmBoxT();
			this.UnPackTo(commonConfirmBoxT);
			return commonConfirmBoxT;
		}

		// Token: 0x0602F05F RID: 192607 RVA: 0x00669F6B File Offset: 0x0066816B
		public void UnPackTo(ICommonConfirmBoxT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
		}

		// Token: 0x0602F060 RID: 192608 RVA: 0x00669F88 File Offset: 0x00668188
		public static Offset<ICommonConfirmBox> Pack(FlatBufferBuilder builder, ICommonConfirmBoxT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonConfirmBox>);
			}
			return ICommonConfirmBox.CreateICommonConfirmBox(builder, _o.Type, _o.Id);
		}

		// Token: 0x0401188A RID: 71818
		private Table __p;
	}
}
