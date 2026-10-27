using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068F1 RID: 26865
	public struct IHideMapMark : IFlatbufferObject
	{
		// Token: 0x1700C754 RID: 51028
		// (get) Token: 0x0602EDDD RID: 191965 RVA: 0x00664C44 File Offset: 0x00662E44
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EDDE RID: 191966 RVA: 0x00664C51 File Offset: 0x00662E51
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EDDF RID: 191967 RVA: 0x00664C58 File Offset: 0x00662E58
		public static IHideMapMark GetRootAsIHideMapMark(ByteBuffer _bb)
		{
			return IHideMapMark.GetRootAsIHideMapMark(_bb, default(IHideMapMark));
		}

		// Token: 0x0602EDE0 RID: 191968 RVA: 0x00664C74 File Offset: 0x00662E74
		public static IHideMapMark GetRootAsIHideMapMark(ByteBuffer _bb, IHideMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EDE1 RID: 191969 RVA: 0x00664C91 File Offset: 0x00662E91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EDE2 RID: 191970 RVA: 0x00664CA0 File Offset: 0x00662EA0
		public IHideMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C755 RID: 51029
		// (get) Token: 0x0602EDE3 RID: 191971 RVA: 0x00664CB0 File Offset: 0x00662EB0
		public EMapMarkState Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMapMarkState.Show;
				}
				return (EMapMarkState)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C756 RID: 51030
		// (get) Token: 0x0602EDE4 RID: 191972 RVA: 0x00664CEC File Offset: 0x00662EEC
		public int MarkId
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

		// Token: 0x0602EDE5 RID: 191973 RVA: 0x00664D28 File Offset: 0x00662F28
		public static Offset<IHideMapMark> CreateIHideMapMark(FlatBufferBuilder builder, EMapMarkState Type = EMapMarkState.Show, int MarkId = 0)
		{
			builder.StartTable(2);
			IHideMapMark.AddMarkId(builder, MarkId);
			IHideMapMark.AddType(builder, Type);
			return IHideMapMark.EndIHideMapMark(builder);
		}

		// Token: 0x0602EDE6 RID: 191974 RVA: 0x00664D45 File Offset: 0x00662F45
		public static void StartIHideMapMark(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EDE7 RID: 191975 RVA: 0x00664D4E File Offset: 0x00662F4E
		public static void AddType(FlatBufferBuilder builder, EMapMarkState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EDE8 RID: 191976 RVA: 0x00664D59 File Offset: 0x00662F59
		public static void AddMarkId(FlatBufferBuilder builder, int markId)
		{
			builder.AddInt(1, markId, 0);
		}

		// Token: 0x0602EDE9 RID: 191977 RVA: 0x00664D64 File Offset: 0x00662F64
		public static Offset<IHideMapMark> EndIHideMapMark(FlatBufferBuilder builder)
		{
			return new Offset<IHideMapMark>(builder.EndTable());
		}

		// Token: 0x0602EDEA RID: 191978 RVA: 0x00664D74 File Offset: 0x00662F74
		public IHideMapMarkT UnPack()
		{
			IHideMapMarkT hideMapMarkT = new IHideMapMarkT();
			this.UnPackTo(hideMapMarkT);
			return hideMapMarkT;
		}

		// Token: 0x0602EDEB RID: 191979 RVA: 0x00664D8F File Offset: 0x00662F8F
		public void UnPackTo(IHideMapMarkT _o)
		{
			_o.Type = this.Type;
			_o.MarkId = this.MarkId;
		}

		// Token: 0x0602EDEC RID: 191980 RVA: 0x00664DAC File Offset: 0x00662FAC
		public static Offset<IHideMapMark> Pack(FlatBufferBuilder builder, IHideMapMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHideMapMark>);
			}
			return IHideMapMark.CreateIHideMapMark(builder, _o.Type, _o.MarkId);
		}

		// Token: 0x04011061 RID: 69729
		private Table __p;
	}
}
