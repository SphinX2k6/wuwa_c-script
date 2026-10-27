using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065E5 RID: 26085
	public struct IDisableMapMark : IFlatbufferObject
	{
		// Token: 0x1700C1AB RID: 49579
		// (get) Token: 0x0602D414 RID: 185364 RVA: 0x00633BA6 File Offset: 0x00631DA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D415 RID: 185365 RVA: 0x00633BB3 File Offset: 0x00631DB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D416 RID: 185366 RVA: 0x00633BBC File Offset: 0x00631DBC
		public static IDisableMapMark GetRootAsIDisableMapMark(ByteBuffer _bb)
		{
			return IDisableMapMark.GetRootAsIDisableMapMark(_bb, default(IDisableMapMark));
		}

		// Token: 0x0602D417 RID: 185367 RVA: 0x00633BD8 File Offset: 0x00631DD8
		public static IDisableMapMark GetRootAsIDisableMapMark(ByteBuffer _bb, IDisableMapMark obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D418 RID: 185368 RVA: 0x00633BF5 File Offset: 0x00631DF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D419 RID: 185369 RVA: 0x00633C04 File Offset: 0x00631E04
		public IDisableMapMark __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C1AC RID: 49580
		// (get) Token: 0x0602D41A RID: 185370 RVA: 0x00633C14 File Offset: 0x00631E14
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

		// Token: 0x1700C1AD RID: 49581
		// (get) Token: 0x0602D41B RID: 185371 RVA: 0x00633C50 File Offset: 0x00631E50
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

		// Token: 0x0602D41C RID: 185372 RVA: 0x00633C8C File Offset: 0x00631E8C
		public static Offset<IDisableMapMark> CreateIDisableMapMark(FlatBufferBuilder builder, EMapMarkState Type = EMapMarkState.Show, int MarkId = 0)
		{
			builder.StartTable(2);
			IDisableMapMark.AddMarkId(builder, MarkId);
			IDisableMapMark.AddType(builder, Type);
			return IDisableMapMark.EndIDisableMapMark(builder);
		}

		// Token: 0x0602D41D RID: 185373 RVA: 0x00633CA9 File Offset: 0x00631EA9
		public static void StartIDisableMapMark(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602D41E RID: 185374 RVA: 0x00633CB2 File Offset: 0x00631EB2
		public static void AddType(FlatBufferBuilder builder, EMapMarkState type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D41F RID: 185375 RVA: 0x00633CBD File Offset: 0x00631EBD
		public static void AddMarkId(FlatBufferBuilder builder, int markId)
		{
			builder.AddInt(1, markId, 0);
		}

		// Token: 0x0602D420 RID: 185376 RVA: 0x00633CC8 File Offset: 0x00631EC8
		public static Offset<IDisableMapMark> EndIDisableMapMark(FlatBufferBuilder builder)
		{
			return new Offset<IDisableMapMark>(builder.EndTable());
		}

		// Token: 0x0602D421 RID: 185377 RVA: 0x00633CD8 File Offset: 0x00631ED8
		public IDisableMapMarkT UnPack()
		{
			IDisableMapMarkT disableMapMarkT = new IDisableMapMarkT();
			this.UnPackTo(disableMapMarkT);
			return disableMapMarkT;
		}

		// Token: 0x0602D422 RID: 185378 RVA: 0x00633CF3 File Offset: 0x00631EF3
		public void UnPackTo(IDisableMapMarkT _o)
		{
			_o.Type = this.Type;
			_o.MarkId = this.MarkId;
		}

		// Token: 0x0602D423 RID: 185379 RVA: 0x00633D10 File Offset: 0x00631F10
		public static Offset<IDisableMapMark> Pack(FlatBufferBuilder builder, IDisableMapMarkT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDisableMapMark>);
			}
			return IDisableMapMark.CreateIDisableMapMark(builder, _o.Type, _o.MarkId);
		}

		// Token: 0x04010C54 RID: 68692
		private Table __p;
	}
}
