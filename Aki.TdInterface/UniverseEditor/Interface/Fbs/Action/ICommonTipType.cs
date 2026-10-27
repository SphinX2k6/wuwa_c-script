using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020064B0 RID: 25776
	public struct ICommonTipType : IFlatbufferObject
	{
		// Token: 0x1700BFCF RID: 49103
		// (get) Token: 0x0602CADE RID: 183006 RVA: 0x00621EC9 File Offset: 0x006200C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CADF RID: 183007 RVA: 0x00621ED6 File Offset: 0x006200D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CAE0 RID: 183008 RVA: 0x00621EE0 File Offset: 0x006200E0
		public static ICommonTipType GetRootAsICommonTipType(ByteBuffer _bb)
		{
			return ICommonTipType.GetRootAsICommonTipType(_bb, default(ICommonTipType));
		}

		// Token: 0x0602CAE1 RID: 183009 RVA: 0x00621EFC File Offset: 0x006200FC
		public static ICommonTipType GetRootAsICommonTipType(ByteBuffer _bb, ICommonTipType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CAE2 RID: 183010 RVA: 0x00621F19 File Offset: 0x00620119
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CAE3 RID: 183011 RVA: 0x00621F28 File Offset: 0x00620128
		public ICommonTipType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BFD0 RID: 49104
		// (get) Token: 0x0602CAE4 RID: 183012 RVA: 0x00621F38 File Offset: 0x00620138
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602CAE5 RID: 183013 RVA: 0x00621F74 File Offset: 0x00620174
		public static Offset<ICommonTipType> CreateICommonTipType(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition)
		{
			builder.StartTable(1);
			ICommonTipType.AddType(builder, Type);
			return ICommonTipType.EndICommonTipType(builder);
		}

		// Token: 0x0602CAE6 RID: 183014 RVA: 0x00621F8A File Offset: 0x0062018A
		public static void StartICommonTipType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602CAE7 RID: 183015 RVA: 0x00621F93 File Offset: 0x00620193
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CAE8 RID: 183016 RVA: 0x00621F9E File Offset: 0x0062019E
		public static Offset<ICommonTipType> EndICommonTipType(FlatBufferBuilder builder)
		{
			return new Offset<ICommonTipType>(builder.EndTable());
		}

		// Token: 0x0602CAE9 RID: 183017 RVA: 0x00621FAC File Offset: 0x006201AC
		public ICommonTipTypeT UnPack()
		{
			ICommonTipTypeT commonTipTypeT = new ICommonTipTypeT();
			this.UnPackTo(commonTipTypeT);
			return commonTipTypeT;
		}

		// Token: 0x0602CAEA RID: 183018 RVA: 0x00621FC7 File Offset: 0x006201C7
		public void UnPackTo(ICommonTipTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602CAEB RID: 183019 RVA: 0x00621FD8 File Offset: 0x006201D8
		public static Offset<ICommonTipType> Pack(FlatBufferBuilder builder, ICommonTipTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonTipType>);
			}
			return ICommonTipType.CreateICommonTipType(builder, _o.Type);
		}

		// Token: 0x04010ABF RID: 68287
		private Table __p;
	}
}
