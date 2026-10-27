using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068D3 RID: 26835
	public struct IHeadStyleVoiceOnly : IFlatbufferObject
	{
		// Token: 0x1700C71C RID: 50972
		// (get) Token: 0x0602ECDC RID: 191708 RVA: 0x0066302A File Offset: 0x0066122A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602ECDD RID: 191709 RVA: 0x00663037 File Offset: 0x00661237
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602ECDE RID: 191710 RVA: 0x00663040 File Offset: 0x00661240
		public static IHeadStyleVoiceOnly GetRootAsIHeadStyleVoiceOnly(ByteBuffer _bb)
		{
			return IHeadStyleVoiceOnly.GetRootAsIHeadStyleVoiceOnly(_bb, default(IHeadStyleVoiceOnly));
		}

		// Token: 0x0602ECDF RID: 191711 RVA: 0x0066305C File Offset: 0x0066125C
		public static IHeadStyleVoiceOnly GetRootAsIHeadStyleVoiceOnly(ByteBuffer _bb, IHeadStyleVoiceOnly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602ECE0 RID: 191712 RVA: 0x00663079 File Offset: 0x00661279
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602ECE1 RID: 191713 RVA: 0x00663088 File Offset: 0x00661288
		public IHeadStyleVoiceOnly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C71D RID: 50973
		// (get) Token: 0x0602ECE2 RID: 191714 RVA: 0x00663098 File Offset: 0x00661298
		public EHeadStyle Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHeadStyle.Normal;
				}
				return (EHeadStyle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C71E RID: 50974
		// (get) Token: 0x0602ECE3 RID: 191715 RVA: 0x006630D4 File Offset: 0x006612D4
		public int WhoId
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

		// Token: 0x0602ECE4 RID: 191716 RVA: 0x00663110 File Offset: 0x00661310
		public static Offset<IHeadStyleVoiceOnly> CreateIHeadStyleVoiceOnly(FlatBufferBuilder builder, EHeadStyle Type = EHeadStyle.Normal, int WhoId = 0)
		{
			builder.StartTable(2);
			IHeadStyleVoiceOnly.AddWhoId(builder, WhoId);
			IHeadStyleVoiceOnly.AddType(builder, Type);
			return IHeadStyleVoiceOnly.EndIHeadStyleVoiceOnly(builder);
		}

		// Token: 0x0602ECE5 RID: 191717 RVA: 0x0066312D File Offset: 0x0066132D
		public static void StartIHeadStyleVoiceOnly(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602ECE6 RID: 191718 RVA: 0x00663136 File Offset: 0x00661336
		public static void AddType(FlatBufferBuilder builder, EHeadStyle type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602ECE7 RID: 191719 RVA: 0x00663141 File Offset: 0x00661341
		public static void AddWhoId(FlatBufferBuilder builder, int whoId)
		{
			builder.AddInt(1, whoId, 0);
		}

		// Token: 0x0602ECE8 RID: 191720 RVA: 0x0066314C File Offset: 0x0066134C
		public static Offset<IHeadStyleVoiceOnly> EndIHeadStyleVoiceOnly(FlatBufferBuilder builder)
		{
			return new Offset<IHeadStyleVoiceOnly>(builder.EndTable());
		}

		// Token: 0x0602ECE9 RID: 191721 RVA: 0x0066315C File Offset: 0x0066135C
		public IHeadStyleVoiceOnlyT UnPack()
		{
			IHeadStyleVoiceOnlyT headStyleVoiceOnlyT = new IHeadStyleVoiceOnlyT();
			this.UnPackTo(headStyleVoiceOnlyT);
			return headStyleVoiceOnlyT;
		}

		// Token: 0x0602ECEA RID: 191722 RVA: 0x00663177 File Offset: 0x00661377
		public void UnPackTo(IHeadStyleVoiceOnlyT _o)
		{
			_o.Type = this.Type;
			_o.WhoId = this.WhoId;
		}

		// Token: 0x0602ECEB RID: 191723 RVA: 0x00663194 File Offset: 0x00661394
		public static Offset<IHeadStyleVoiceOnly> Pack(FlatBufferBuilder builder, IHeadStyleVoiceOnlyT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHeadStyleVoiceOnly>);
			}
			return IHeadStyleVoiceOnly.CreateIHeadStyleVoiceOnly(builder, _o.Type, _o.WhoId);
		}

		// Token: 0x0401102F RID: 69679
		private Table __p;
	}
}
