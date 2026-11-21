using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F26 RID: 28454
	public struct IGetOffMotorcycleInteract : IFlatbufferObject
	{
		// Token: 0x1700D09C RID: 53404
		// (get) Token: 0x060313E1 RID: 201697 RVA: 0x006AC162 File Offset: 0x006AA362
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060313E2 RID: 201698 RVA: 0x006AC16F File Offset: 0x006AA36F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060313E3 RID: 201699 RVA: 0x006AC178 File Offset: 0x006AA378
		public static IGetOffMotorcycleInteract GetRootAsIGetOffMotorcycleInteract(ByteBuffer _bb)
		{
			return IGetOffMotorcycleInteract.GetRootAsIGetOffMotorcycleInteract(_bb, default(IGetOffMotorcycleInteract));
		}

		// Token: 0x060313E4 RID: 201700 RVA: 0x006AC194 File Offset: 0x006AA394
		public static IGetOffMotorcycleInteract GetRootAsIGetOffMotorcycleInteract(ByteBuffer _bb, IGetOffMotorcycleInteract obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060313E5 RID: 201701 RVA: 0x006AC1B1 File Offset: 0x006AA3B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060313E6 RID: 201702 RVA: 0x006AC1C0 File Offset: 0x006AA3C0
		public IGetOffMotorcycleInteract __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D09D RID: 53405
		// (get) Token: 0x060313E7 RID: 201703 RVA: 0x006AC1D0 File Offset: 0x006AA3D0
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

		// Token: 0x060313E8 RID: 201704 RVA: 0x006AC20C File Offset: 0x006AA40C
		public static Offset<IGetOffMotorcycleInteract> CreateIGetOffMotorcycleInteract(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IGetOffMotorcycleInteract.AddType(builder, Type);
			return IGetOffMotorcycleInteract.EndIGetOffMotorcycleInteract(builder);
		}

		// Token: 0x060313E9 RID: 201705 RVA: 0x006AC222 File Offset: 0x006AA422
		public static void StartIGetOffMotorcycleInteract(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060313EA RID: 201706 RVA: 0x006AC22B File Offset: 0x006AA42B
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060313EB RID: 201707 RVA: 0x006AC236 File Offset: 0x006AA436
		public static Offset<IGetOffMotorcycleInteract> EndIGetOffMotorcycleInteract(FlatBufferBuilder builder)
		{
			return new Offset<IGetOffMotorcycleInteract>(builder.EndTable());
		}

		// Token: 0x060313EC RID: 201708 RVA: 0x006AC244 File Offset: 0x006AA444
		public IGetOffMotorcycleInteractT UnPack()
		{
			IGetOffMotorcycleInteractT getOffMotorcycleInteractT = new IGetOffMotorcycleInteractT();
			this.UnPackTo(getOffMotorcycleInteractT);
			return getOffMotorcycleInteractT;
		}

		// Token: 0x060313ED RID: 201709 RVA: 0x006AC25F File Offset: 0x006AA45F
		public void UnPackTo(IGetOffMotorcycleInteractT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060313EE RID: 201710 RVA: 0x006AC270 File Offset: 0x006AA470
		public static Offset<IGetOffMotorcycleInteract> Pack(FlatBufferBuilder builder, IGetOffMotorcycleInteractT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGetOffMotorcycleInteract>);
			}
			return IGetOffMotorcycleInteract.CreateIGetOffMotorcycleInteract(builder, _o.Type);
		}

		// Token: 0x04011E30 RID: 73264
		private Table __p;
	}
}
