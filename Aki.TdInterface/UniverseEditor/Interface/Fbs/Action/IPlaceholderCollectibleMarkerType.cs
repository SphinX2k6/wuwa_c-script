using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD2 RID: 27858
	public struct IPlaceholderCollectibleMarkerType : IFlatbufferObject
	{
		// Token: 0x1700CF67 RID: 53095
		// (get) Token: 0x06031197 RID: 201111 RVA: 0x006A99E2 File Offset: 0x006A7BE2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031198 RID: 201112 RVA: 0x006A99EF File Offset: 0x006A7BEF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031199 RID: 201113 RVA: 0x006A99F8 File Offset: 0x006A7BF8
		public static IPlaceholderCollectibleMarkerType GetRootAsIPlaceholderCollectibleMarkerType(ByteBuffer _bb)
		{
			return IPlaceholderCollectibleMarkerType.GetRootAsIPlaceholderCollectibleMarkerType(_bb, default(IPlaceholderCollectibleMarkerType));
		}

		// Token: 0x0603119A RID: 201114 RVA: 0x006A9A14 File Offset: 0x006A7C14
		public static IPlaceholderCollectibleMarkerType GetRootAsIPlaceholderCollectibleMarkerType(ByteBuffer _bb, IPlaceholderCollectibleMarkerType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603119B RID: 201115 RVA: 0x006A9A31 File Offset: 0x006A7C31
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603119C RID: 201116 RVA: 0x006A9A40 File Offset: 0x006A7C40
		public IPlaceholderCollectibleMarkerType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CF68 RID: 53096
		// (get) Token: 0x0603119D RID: 201117 RVA: 0x006A9A50 File Offset: 0x006A7C50
		public ECollectibleMarkerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECollectibleMarkerType.Placeholder;
				}
				return (ECollectibleMarkerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603119E RID: 201118 RVA: 0x006A9A8C File Offset: 0x006A7C8C
		public static Offset<IPlaceholderCollectibleMarkerType> CreateIPlaceholderCollectibleMarkerType(FlatBufferBuilder builder, ECollectibleMarkerType Type = ECollectibleMarkerType.Placeholder)
		{
			builder.StartTable(1);
			IPlaceholderCollectibleMarkerType.AddType(builder, Type);
			return IPlaceholderCollectibleMarkerType.EndIPlaceholderCollectibleMarkerType(builder);
		}

		// Token: 0x0603119F RID: 201119 RVA: 0x006A9AA2 File Offset: 0x006A7CA2
		public static void StartIPlaceholderCollectibleMarkerType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060311A0 RID: 201120 RVA: 0x006A9AAB File Offset: 0x006A7CAB
		public static void AddType(FlatBufferBuilder builder, ECollectibleMarkerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060311A1 RID: 201121 RVA: 0x006A9AB6 File Offset: 0x006A7CB6
		public static Offset<IPlaceholderCollectibleMarkerType> EndIPlaceholderCollectibleMarkerType(FlatBufferBuilder builder)
		{
			return new Offset<IPlaceholderCollectibleMarkerType>(builder.EndTable());
		}

		// Token: 0x060311A2 RID: 201122 RVA: 0x006A9AC4 File Offset: 0x006A7CC4
		public IPlaceholderCollectibleMarkerTypeT UnPack()
		{
			IPlaceholderCollectibleMarkerTypeT placeholderCollectibleMarkerTypeT = new IPlaceholderCollectibleMarkerTypeT();
			this.UnPackTo(placeholderCollectibleMarkerTypeT);
			return placeholderCollectibleMarkerTypeT;
		}

		// Token: 0x060311A3 RID: 201123 RVA: 0x006A9ADF File Offset: 0x006A7CDF
		public void UnPackTo(IPlaceholderCollectibleMarkerTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060311A4 RID: 201124 RVA: 0x006A9AF0 File Offset: 0x006A7CF0
		public static Offset<IPlaceholderCollectibleMarkerType> Pack(FlatBufferBuilder builder, IPlaceholderCollectibleMarkerTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlaceholderCollectibleMarkerType>);
			}
			return IPlaceholderCollectibleMarkerType.CreateIPlaceholderCollectibleMarkerType(builder, _o.Type);
		}

		// Token: 0x04011639 RID: 71225
		private Table __p;
	}
}
