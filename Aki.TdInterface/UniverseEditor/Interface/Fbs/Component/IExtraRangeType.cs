using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200577E RID: 22398
	public struct IExtraRangeType : IFlatbufferObject
	{
		// Token: 0x1700A1E9 RID: 41449
		// (get) Token: 0x06024200 RID: 147968 RVA: 0x004F7B67 File Offset: 0x004F5D67
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024201 RID: 147969 RVA: 0x004F7B74 File Offset: 0x004F5D74
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024202 RID: 147970 RVA: 0x004F7B7C File Offset: 0x004F5D7C
		public static IExtraRangeType GetRootAsIExtraRangeType(ByteBuffer _bb)
		{
			return IExtraRangeType.GetRootAsIExtraRangeType(_bb, default(IExtraRangeType));
		}

		// Token: 0x06024203 RID: 147971 RVA: 0x004F7B98 File Offset: 0x004F5D98
		public static IExtraRangeType GetRootAsIExtraRangeType(ByteBuffer _bb, IExtraRangeType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024204 RID: 147972 RVA: 0x004F7BB5 File Offset: 0x004F5DB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024205 RID: 147973 RVA: 0x004F7BC4 File Offset: 0x004F5DC4
		public IExtraRangeType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A1EA RID: 41450
		// (get) Token: 0x06024206 RID: 147974 RVA: 0x004F7BD4 File Offset: 0x004F5DD4
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

		// Token: 0x06024207 RID: 147975 RVA: 0x004F7C10 File Offset: 0x004F5E10
		public static Offset<IExtraRangeType> CreateIExtraRangeType(FlatBufferBuilder builder, EExtraRangeType Type = EExtraRangeType.SunSpiritBlock)
		{
			builder.StartTable(1);
			IExtraRangeType.AddType(builder, Type);
			return IExtraRangeType.EndIExtraRangeType(builder);
		}

		// Token: 0x06024208 RID: 147976 RVA: 0x004F7C26 File Offset: 0x004F5E26
		public static void StartIExtraRangeType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024209 RID: 147977 RVA: 0x004F7C2F File Offset: 0x004F5E2F
		public static void AddType(FlatBufferBuilder builder, EExtraRangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602420A RID: 147978 RVA: 0x004F7C3A File Offset: 0x004F5E3A
		public static Offset<IExtraRangeType> EndIExtraRangeType(FlatBufferBuilder builder)
		{
			return new Offset<IExtraRangeType>(builder.EndTable());
		}

		// Token: 0x0602420B RID: 147979 RVA: 0x004F7C48 File Offset: 0x004F5E48
		public IExtraRangeTypeT UnPack()
		{
			IExtraRangeTypeT extraRangeTypeT = new IExtraRangeTypeT();
			this.UnPackTo(extraRangeTypeT);
			return extraRangeTypeT;
		}

		// Token: 0x0602420C RID: 147980 RVA: 0x004F7C63 File Offset: 0x004F5E63
		public void UnPackTo(IExtraRangeTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602420D RID: 147981 RVA: 0x004F7C74 File Offset: 0x004F5E74
		public static Offset<IExtraRangeType> Pack(FlatBufferBuilder builder, IExtraRangeTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExtraRangeType>);
			}
			return IExtraRangeType.CreateIExtraRangeType(builder, _o.Type);
		}

		// Token: 0x0400EF54 RID: 61268
		private Table __p;
	}
}
