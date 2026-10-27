using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005216 RID: 21014
	public struct IExtraRangeType : IFlatbufferObject
	{
		// Token: 0x170099ED RID: 39405
		// (get) Token: 0x0602226A RID: 139882 RVA: 0x004BD0A3 File Offset: 0x004BB2A3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602226B RID: 139883 RVA: 0x004BD0B0 File Offset: 0x004BB2B0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602226C RID: 139884 RVA: 0x004BD0B8 File Offset: 0x004BB2B8
		public static IExtraRangeType GetRootAsIExtraRangeType(ByteBuffer _bb)
		{
			return IExtraRangeType.GetRootAsIExtraRangeType(_bb, default(IExtraRangeType));
		}

		// Token: 0x0602226D RID: 139885 RVA: 0x004BD0D4 File Offset: 0x004BB2D4
		public static IExtraRangeType GetRootAsIExtraRangeType(ByteBuffer _bb, IExtraRangeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602226E RID: 139886 RVA: 0x004BD0F1 File Offset: 0x004BB2F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602226F RID: 139887 RVA: 0x004BD100 File Offset: 0x004BB300
		public IExtraRangeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099EE RID: 39406
		// (get) Token: 0x06022270 RID: 139888 RVA: 0x004BD110 File Offset: 0x004BB310
		public EExtraRangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExtraRangeType.SunSpiritBlock;
				}
				return (EExtraRangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022271 RID: 139889 RVA: 0x004BD14C File Offset: 0x004BB34C
		public static Offset<IExtraRangeType> CreateIExtraRangeType(FlatBufferBuilder builder, EExtraRangeType Type = EExtraRangeType.SunSpiritBlock)
		{
			builder.StartTable(1);
			IExtraRangeType.AddType(builder, Type);
			return IExtraRangeType.EndIExtraRangeType(builder);
		}

		// Token: 0x06022272 RID: 139890 RVA: 0x004BD162 File Offset: 0x004BB362
		public static void StartIExtraRangeType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022273 RID: 139891 RVA: 0x004BD16B File Offset: 0x004BB36B
		public static void AddType(FlatBufferBuilder builder, EExtraRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022274 RID: 139892 RVA: 0x004BD176 File Offset: 0x004BB376
		public static Offset<IExtraRangeType> EndIExtraRangeType(FlatBufferBuilder builder)
		{
			return new Offset<IExtraRangeType>(builder.EndTable());
		}

		// Token: 0x06022275 RID: 139893 RVA: 0x004BD184 File Offset: 0x004BB384
		public IExtraRangeTypeT UnPack()
		{
			IExtraRangeTypeT extraRangeTypeT = new IExtraRangeTypeT();
			this.UnPackTo(extraRangeTypeT);
			return extraRangeTypeT;
		}

		// Token: 0x06022276 RID: 139894 RVA: 0x004BD19F File Offset: 0x004BB39F
		public void UnPackTo(IExtraRangeTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06022277 RID: 139895 RVA: 0x004BD1B0 File Offset: 0x004BB3B0
		public static Offset<IExtraRangeType> Pack(FlatBufferBuilder builder, IExtraRangeTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExtraRangeType>);
			}
			return IExtraRangeType.CreateIExtraRangeType(builder, _o.Type);
		}

		// Token: 0x0400E34E RID: 58190
		private Table __p;
	}
}
