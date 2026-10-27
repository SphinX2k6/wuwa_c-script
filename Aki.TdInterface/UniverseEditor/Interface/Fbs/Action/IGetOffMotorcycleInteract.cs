using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006885 RID: 26757
	public struct IGetOffMotorcycleInteract : IFlatbufferObject
	{
		// Token: 0x1700C6B6 RID: 50870
		// (get) Token: 0x0602EAA7 RID: 191143 RVA: 0x0065D0E2 File Offset: 0x0065B2E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EAA8 RID: 191144 RVA: 0x0065D0EF File Offset: 0x0065B2EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EAA9 RID: 191145 RVA: 0x0065D0F8 File Offset: 0x0065B2F8
		public static IGetOffMotorcycleInteract GetRootAsIGetOffMotorcycleInteract(ByteBuffer _bb)
		{
			return IGetOffMotorcycleInteract.GetRootAsIGetOffMotorcycleInteract(_bb, default(IGetOffMotorcycleInteract));
		}

		// Token: 0x0602EAAA RID: 191146 RVA: 0x0065D114 File Offset: 0x0065B314
		public static IGetOffMotorcycleInteract GetRootAsIGetOffMotorcycleInteract(ByteBuffer _bb, IGetOffMotorcycleInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EAAB RID: 191147 RVA: 0x0065D131 File Offset: 0x0065B331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EAAC RID: 191148 RVA: 0x0065D140 File Offset: 0x0065B340
		public IGetOffMotorcycleInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C6B7 RID: 50871
		// (get) Token: 0x0602EAAD RID: 191149 RVA: 0x0065D150 File Offset: 0x0065B350
		public ELeisureInteract Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELeisureInteract.CustomSkill;
				}
				return (ELeisureInteract)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602EAAE RID: 191150 RVA: 0x0065D18C File Offset: 0x0065B38C
		public static Offset<IGetOffMotorcycleInteract> CreateIGetOffMotorcycleInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IGetOffMotorcycleInteract.AddType(builder, Type);
			return IGetOffMotorcycleInteract.EndIGetOffMotorcycleInteract(builder);
		}

		// Token: 0x0602EAAF RID: 191151 RVA: 0x0065D1A2 File Offset: 0x0065B3A2
		public static void StartIGetOffMotorcycleInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602EAB0 RID: 191152 RVA: 0x0065D1AB File Offset: 0x0065B3AB
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EAB1 RID: 191153 RVA: 0x0065D1B6 File Offset: 0x0065B3B6
		public static Offset<IGetOffMotorcycleInteract> EndIGetOffMotorcycleInteract(FlatBufferBuilder builder)
		{
			return new Offset<IGetOffMotorcycleInteract>(builder.EndTable());
		}

		// Token: 0x0602EAB2 RID: 191154 RVA: 0x0065D1C4 File Offset: 0x0065B3C4
		public IGetOffMotorcycleInteractT UnPack()
		{
			IGetOffMotorcycleInteractT getOffMotorcycleInteractT = new IGetOffMotorcycleInteractT();
			this.UnPackTo(getOffMotorcycleInteractT);
			return getOffMotorcycleInteractT;
		}

		// Token: 0x0602EAB3 RID: 191155 RVA: 0x0065D1DF File Offset: 0x0065B3DF
		public void UnPackTo(IGetOffMotorcycleInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602EAB4 RID: 191156 RVA: 0x0065D1F0 File Offset: 0x0065B3F0
		public static Offset<IGetOffMotorcycleInteract> Pack(FlatBufferBuilder builder, IGetOffMotorcycleInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGetOffMotorcycleInteract>);
			}
			return IGetOffMotorcycleInteract.CreateIGetOffMotorcycleInteract(builder, _o.Type);
		}

		// Token: 0x04010FDB RID: 69595
		private Table __p;
	}
}
