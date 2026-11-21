using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007941 RID: 31041
	public struct ISpecialCustomLoadingOption : IFlatbufferObject
	{
		// Token: 0x1700E3B9 RID: 58297
		// (get) Token: 0x06036AC1 RID: 223937 RVA: 0x00750E81 File Offset: 0x0074F081
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036AC2 RID: 223938 RVA: 0x00750E8E File Offset: 0x0074F08E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036AC3 RID: 223939 RVA: 0x00750E98 File Offset: 0x0074F098
		public static ISpecialCustomLoadingOption GetRootAsISpecialCustomLoadingOption(ByteBuffer _bb)
		{
			return ISpecialCustomLoadingOption.GetRootAsISpecialCustomLoadingOption(_bb, default(ISpecialCustomLoadingOption));
		}

		// Token: 0x06036AC4 RID: 223940 RVA: 0x00750EB4 File Offset: 0x0074F0B4
		public static ISpecialCustomLoadingOption GetRootAsISpecialCustomLoadingOption(ByteBuffer _bb, ISpecialCustomLoadingOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036AC5 RID: 223941 RVA: 0x00750ED1 File Offset: 0x0074F0D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036AC6 RID: 223942 RVA: 0x00750EE0 File Offset: 0x0074F0E0
		public ISpecialCustomLoadingOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3BA RID: 58298
		// (get) Token: 0x06036AC7 RID: 223943 RVA: 0x00750EF0 File Offset: 0x0074F0F0
		public ESpecialCustomLoadingType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpecialCustomLoadingType.HonamiStory;
				}
				return (ESpecialCustomLoadingType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036AC8 RID: 223944 RVA: 0x00750F2C File Offset: 0x0074F12C
		public static Offset<ISpecialCustomLoadingOption> CreateISpecialCustomLoadingOption(FlatBufferBuilder builder, ESpecialCustomLoadingType Type = ESpecialCustomLoadingType.HonamiStory)
		{
			builder.StartTable(1);
			ISpecialCustomLoadingOption.AddType(builder, Type);
			return ISpecialCustomLoadingOption.EndISpecialCustomLoadingOption(builder);
		}

		// Token: 0x06036AC9 RID: 223945 RVA: 0x00750F42 File Offset: 0x0074F142
		public static void StartISpecialCustomLoadingOption(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036ACA RID: 223946 RVA: 0x00750F4B File Offset: 0x0074F14B
		public static void AddType(FlatBufferBuilder builder, ESpecialCustomLoadingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036ACB RID: 223947 RVA: 0x00750F56 File Offset: 0x0074F156
		public static Offset<ISpecialCustomLoadingOption> EndISpecialCustomLoadingOption(FlatBufferBuilder builder)
		{
			return new Offset<ISpecialCustomLoadingOption>(builder.EndTable());
		}

		// Token: 0x06036ACC RID: 223948 RVA: 0x00750F64 File Offset: 0x0074F164
		public ISpecialCustomLoadingOptionT UnPack()
		{
			ISpecialCustomLoadingOptionT specialCustomLoadingOptionT = new ISpecialCustomLoadingOptionT();
			this.UnPackTo(specialCustomLoadingOptionT);
			return specialCustomLoadingOptionT;
		}

		// Token: 0x06036ACD RID: 223949 RVA: 0x00750F7F File Offset: 0x0074F17F
		public void UnPackTo(ISpecialCustomLoadingOptionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036ACE RID: 223950 RVA: 0x00750F90 File Offset: 0x0074F190
		public static Offset<ISpecialCustomLoadingOption> Pack(FlatBufferBuilder builder, ISpecialCustomLoadingOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecialCustomLoadingOption>);
			}
			return ISpecialCustomLoadingOption.CreateISpecialCustomLoadingOption(builder, _o.Type);
		}

		// Token: 0x04012C0C RID: 76812
		private Table __p;
	}
}
