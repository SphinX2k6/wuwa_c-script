using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004187 RID: 16775
	public struct ICheckSpringFestivalMixDrinksCompleted : IFlatbufferObject
	{
		// Token: 0x170071A7 RID: 29095
		// (get) Token: 0x06017177 RID: 94583 RVA: 0x0034A930 File Offset: 0x00348B30
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017178 RID: 94584 RVA: 0x0034A93D File Offset: 0x00348B3D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017179 RID: 94585 RVA: 0x0034A944 File Offset: 0x00348B44
		public static ICheckSpringFestivalMixDrinksCompleted GetRootAsICheckSpringFestivalMixDrinksCompleted(ByteBuffer _bb)
		{
			return ICheckSpringFestivalMixDrinksCompleted.GetRootAsICheckSpringFestivalMixDrinksCompleted(_bb, default(ICheckSpringFestivalMixDrinksCompleted));
		}

		// Token: 0x0601717A RID: 94586 RVA: 0x0034A960 File Offset: 0x00348B60
		public static ICheckSpringFestivalMixDrinksCompleted GetRootAsICheckSpringFestivalMixDrinksCompleted(ByteBuffer _bb, ICheckSpringFestivalMixDrinksCompleted obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601717B RID: 94587 RVA: 0x0034A97D File Offset: 0x00348B7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601717C RID: 94588 RVA: 0x0034A98C File Offset: 0x00348B8C
		public ICheckSpringFestivalMixDrinksCompleted __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170071A8 RID: 29096
		// (get) Token: 0x0601717D RID: 94589 RVA: 0x0034A99C File Offset: 0x00348B9C
		public ESpringFestivalGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESpringFestivalGameplayType.MixDrinks;
				}
				return (ESpringFestivalGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170071A9 RID: 29097
		// (get) Token: 0x0601717E RID: 94590 RVA: 0x0034A9D8 File Offset: 0x00348BD8
		public int Id
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

		// Token: 0x170071AA RID: 29098
		// (get) Token: 0x0601717F RID: 94591 RVA: 0x0034AA14 File Offset: 0x00348C14
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017180 RID: 94592 RVA: 0x0034AA50 File Offset: 0x00348C50
		public static Offset<ICheckSpringFestivalMixDrinksCompleted> CreateICheckSpringFestivalMixDrinksCompleted(FlatBufferBuilder builder, ESpringFestivalGameplayType Type = ESpringFestivalGameplayType.MixDrinks, int Id = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ICheckSpringFestivalMixDrinksCompleted.AddId(builder, Id);
			ICheckSpringFestivalMixDrinksCompleted.AddNullMask(builder, NullMask);
			ICheckSpringFestivalMixDrinksCompleted.AddType(builder, Type);
			return ICheckSpringFestivalMixDrinksCompleted.EndICheckSpringFestivalMixDrinksCompleted(builder);
		}

		// Token: 0x06017181 RID: 94593 RVA: 0x0034AA74 File Offset: 0x00348C74
		public static void StartICheckSpringFestivalMixDrinksCompleted(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017182 RID: 94594 RVA: 0x0034AA7D File Offset: 0x00348C7D
		public static void AddType(FlatBufferBuilder builder, ESpringFestivalGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017183 RID: 94595 RVA: 0x0034AA88 File Offset: 0x00348C88
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(1, id, 0);
		}

		// Token: 0x06017184 RID: 94596 RVA: 0x0034AA93 File Offset: 0x00348C93
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06017185 RID: 94597 RVA: 0x0034AA9E File Offset: 0x00348C9E
		public static Offset<ICheckSpringFestivalMixDrinksCompleted> EndICheckSpringFestivalMixDrinksCompleted(FlatBufferBuilder builder)
		{
			return new Offset<ICheckSpringFestivalMixDrinksCompleted>(builder.EndTable());
		}

		// Token: 0x06017186 RID: 94598 RVA: 0x0034AAAC File Offset: 0x00348CAC
		public ICheckSpringFestivalMixDrinksCompletedT UnPack()
		{
			ICheckSpringFestivalMixDrinksCompletedT checkSpringFestivalMixDrinksCompletedT = new ICheckSpringFestivalMixDrinksCompletedT();
			this.UnPackTo(checkSpringFestivalMixDrinksCompletedT);
			return checkSpringFestivalMixDrinksCompletedT;
		}

		// Token: 0x06017187 RID: 94599 RVA: 0x0034AAC7 File Offset: 0x00348CC7
		public void UnPackTo(ICheckSpringFestivalMixDrinksCompletedT _o)
		{
			_o.Type = this.Type;
			_o.Id = this.Id;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06017188 RID: 94600 RVA: 0x0034AAF0 File Offset: 0x00348CF0
		public static Offset<ICheckSpringFestivalMixDrinksCompleted> Pack(FlatBufferBuilder builder, ICheckSpringFestivalMixDrinksCompletedT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckSpringFestivalMixDrinksCompleted>);
			}
			return ICheckSpringFestivalMixDrinksCompleted.CreateICheckSpringFestivalMixDrinksCompleted(builder, _o.Type, _o.Id, _o.NullMask);
		}

		// Token: 0x0400C003 RID: 49155
		private Table __p;
	}
}
