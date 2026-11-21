using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005739 RID: 22329
	public struct IExhibitItemType : IFlatbufferObject
	{
		// Token: 0x1700A141 RID: 41281
		// (get) Token: 0x06023EDC RID: 147164 RVA: 0x004F06E3 File Offset: 0x004EE8E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023EDD RID: 147165 RVA: 0x004F06F0 File Offset: 0x004EE8F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023EDE RID: 147166 RVA: 0x004F06F8 File Offset: 0x004EE8F8
		public static IExhibitItemType GetRootAsIExhibitItemType(ByteBuffer _bb)
		{
			return IExhibitItemType.GetRootAsIExhibitItemType(_bb, default(IExhibitItemType));
		}

		// Token: 0x06023EDF RID: 147167 RVA: 0x004F0714 File Offset: 0x004EE914
		public static IExhibitItemType GetRootAsIExhibitItemType(ByteBuffer _bb, IExhibitItemType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023EE0 RID: 147168 RVA: 0x004F0731 File Offset: 0x004EE931
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023EE1 RID: 147169 RVA: 0x004F0740 File Offset: 0x004EE940
		public IExhibitItemType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A142 RID: 41282
		// (get) Token: 0x06023EE2 RID: 147170 RVA: 0x004F0750 File Offset: 0x004EE950
		public EExhibitItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExhibitItemType.Phantom;
				}
				return (EExhibitItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023EE3 RID: 147171 RVA: 0x004F078C File Offset: 0x004EE98C
		public static Offset<IExhibitItemType> CreateIExhibitItemType(FlatBufferBuilder builder, EExhibitItemType Type = EExhibitItemType.Phantom)
		{
			builder.StartTable(1);
			IExhibitItemType.AddType(builder, Type);
			return IExhibitItemType.EndIExhibitItemType(builder);
		}

		// Token: 0x06023EE4 RID: 147172 RVA: 0x004F07A2 File Offset: 0x004EE9A2
		public static void StartIExhibitItemType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06023EE5 RID: 147173 RVA: 0x004F07AB File Offset: 0x004EE9AB
		public static void AddType(FlatBufferBuilder builder, EExhibitItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023EE6 RID: 147174 RVA: 0x004F07B6 File Offset: 0x004EE9B6
		public static Offset<IExhibitItemType> EndIExhibitItemType(FlatBufferBuilder builder)
		{
			return new Offset<IExhibitItemType>(builder.EndTable());
		}

		// Token: 0x06023EE7 RID: 147175 RVA: 0x004F07C4 File Offset: 0x004EE9C4
		public IExhibitItemTypeT UnPack()
		{
			IExhibitItemTypeT exhibitItemTypeT = new IExhibitItemTypeT();
			this.UnPackTo(exhibitItemTypeT);
			return exhibitItemTypeT;
		}

		// Token: 0x06023EE8 RID: 147176 RVA: 0x004F07DF File Offset: 0x004EE9DF
		public void UnPackTo(IExhibitItemTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06023EE9 RID: 147177 RVA: 0x004F07F0 File Offset: 0x004EE9F0
		public static Offset<IExhibitItemType> Pack(FlatBufferBuilder builder, IExhibitItemTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IExhibitItemType>);
			}
			return IExhibitItemType.CreateIExhibitItemType(builder, _o.Type);
		}

		// Token: 0x0400EED8 RID: 61144
		private Table __p;
	}
}
