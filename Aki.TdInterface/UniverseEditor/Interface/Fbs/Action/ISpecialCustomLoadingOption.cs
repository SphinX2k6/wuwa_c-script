using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007172 RID: 29042
	public struct ISpecialCustomLoadingOption : IFlatbufferObject
	{
		// Token: 0x1700D7C7 RID: 55239
		// (get) Token: 0x060337E7 RID: 210919 RVA: 0x006EFEF3 File Offset: 0x006EE0F3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060337E8 RID: 210920 RVA: 0x006EFF00 File Offset: 0x006EE100
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060337E9 RID: 210921 RVA: 0x006EFF08 File Offset: 0x006EE108
		public static ISpecialCustomLoadingOption GetRootAsISpecialCustomLoadingOption(ByteBuffer _bb)
		{
			return ISpecialCustomLoadingOption.GetRootAsISpecialCustomLoadingOption(_bb, default(ISpecialCustomLoadingOption));
		}

		// Token: 0x060337EA RID: 210922 RVA: 0x006EFF24 File Offset: 0x006EE124
		public static ISpecialCustomLoadingOption GetRootAsISpecialCustomLoadingOption(ByteBuffer _bb, ISpecialCustomLoadingOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060337EB RID: 210923 RVA: 0x006EFF41 File Offset: 0x006EE141
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060337EC RID: 210924 RVA: 0x006EFF50 File Offset: 0x006EE150
		public ISpecialCustomLoadingOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7C8 RID: 55240
		// (get) Token: 0x060337ED RID: 210925 RVA: 0x006EFF60 File Offset: 0x006EE160
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

		// Token: 0x060337EE RID: 210926 RVA: 0x006EFF9C File Offset: 0x006EE19C
		public static Offset<ISpecialCustomLoadingOption> CreateISpecialCustomLoadingOption(FlatBufferBuilder builder, ESpecialCustomLoadingType Type = ESpecialCustomLoadingType.HonamiStory)
		{
			builder.StartTable(1);
			ISpecialCustomLoadingOption.AddType(builder, Type);
			return ISpecialCustomLoadingOption.EndISpecialCustomLoadingOption(builder);
		}

		// Token: 0x060337EF RID: 210927 RVA: 0x006EFFB2 File Offset: 0x006EE1B2
		public static void StartISpecialCustomLoadingOption(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060337F0 RID: 210928 RVA: 0x006EFFBB File Offset: 0x006EE1BB
		public static void AddType(FlatBufferBuilder builder, ESpecialCustomLoadingType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060337F1 RID: 210929 RVA: 0x006EFFC6 File Offset: 0x006EE1C6
		public static Offset<ISpecialCustomLoadingOption> EndISpecialCustomLoadingOption(FlatBufferBuilder builder)
		{
			return new Offset<ISpecialCustomLoadingOption>(builder.EndTable());
		}

		// Token: 0x060337F2 RID: 210930 RVA: 0x006EFFD4 File Offset: 0x006EE1D4
		public ISpecialCustomLoadingOptionT UnPack()
		{
			ISpecialCustomLoadingOptionT specialCustomLoadingOptionT = new ISpecialCustomLoadingOptionT();
			this.UnPackTo(specialCustomLoadingOptionT);
			return specialCustomLoadingOptionT;
		}

		// Token: 0x060337F3 RID: 210931 RVA: 0x006EFFEF File Offset: 0x006EE1EF
		public void UnPackTo(ISpecialCustomLoadingOptionT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060337F4 RID: 210932 RVA: 0x006F0000 File Offset: 0x006EE200
		public static Offset<ISpecialCustomLoadingOption> Pack(FlatBufferBuilder builder, ISpecialCustomLoadingOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISpecialCustomLoadingOption>);
			}
			return ISpecialCustomLoadingOption.CreateISpecialCustomLoadingOption(builder, _o.Type);
		}

		// Token: 0x04011C16 RID: 72726
		private Table __p;
	}
}
