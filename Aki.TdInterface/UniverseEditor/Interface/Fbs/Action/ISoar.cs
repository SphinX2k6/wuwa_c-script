using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007929 RID: 31017
	public struct ISoar : IFlatbufferObject
	{
		// Token: 0x1700E38D RID: 58253
		// (get) Token: 0x060369F6 RID: 223734 RVA: 0x0074F519 File Offset: 0x0074D719
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060369F7 RID: 223735 RVA: 0x0074F526 File Offset: 0x0074D726
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060369F8 RID: 223736 RVA: 0x0074F530 File Offset: 0x0074D730
		public static ISoar GetRootAsISoar(ByteBuffer _bb)
		{
			return ISoar.GetRootAsISoar(_bb, default(ISoar));
		}

		// Token: 0x060369F9 RID: 223737 RVA: 0x0074F54C File Offset: 0x0074D74C
		public static ISoar GetRootAsISoar(ByteBuffer _bb, ISoar obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060369FA RID: 223738 RVA: 0x0074F569 File Offset: 0x0074D769
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060369FB RID: 223739 RVA: 0x0074F578 File Offset: 0x0074D778
		public ISoar __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E38E RID: 58254
		// (get) Token: 0x060369FC RID: 223740 RVA: 0x0074F588 File Offset: 0x0074D788
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

		// Token: 0x060369FD RID: 223741 RVA: 0x0074F5C4 File Offset: 0x0074D7C4
		public static Offset<ISoar> CreateISoar(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			ISoar.AddType(builder, Type);
			return ISoar.EndISoar(builder);
		}

		// Token: 0x060369FE RID: 223742 RVA: 0x0074F5DA File Offset: 0x0074D7DA
		public static void StartISoar(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060369FF RID: 223743 RVA: 0x0074F5E3 File Offset: 0x0074D7E3
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036A00 RID: 223744 RVA: 0x0074F5EE File Offset: 0x0074D7EE
		public static Offset<ISoar> EndISoar(FlatBufferBuilder builder)
		{
			return new Offset<ISoar>(builder.EndTable());
		}

		// Token: 0x06036A01 RID: 223745 RVA: 0x0074F5FC File Offset: 0x0074D7FC
		public ISoarT UnPack()
		{
			ISoarT soarT = new ISoarT();
			this.UnPackTo(soarT);
			return soarT;
		}

		// Token: 0x06036A02 RID: 223746 RVA: 0x0074F617 File Offset: 0x0074D817
		public void UnPackTo(ISoarT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036A03 RID: 223747 RVA: 0x0074F628 File Offset: 0x0074D828
		public static Offset<ISoar> Pack(FlatBufferBuilder builder, ISoarT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISoar>);
			}
			return ISoar.CreateISoar(builder, _o.Type);
		}

		// Token: 0x04012BF2 RID: 76786
		private Table __p;
	}
}
