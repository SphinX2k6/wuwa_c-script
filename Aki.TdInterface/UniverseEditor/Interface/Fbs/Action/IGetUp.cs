using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F2C RID: 28460
	public struct IGetUp : IFlatbufferObject
	{
		// Token: 0x1700D0A0 RID: 53408
		// (get) Token: 0x06031400 RID: 201728 RVA: 0x006AC3C2 File Offset: 0x006AA5C2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06031401 RID: 201729 RVA: 0x006AC3CF File Offset: 0x006AA5CF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06031402 RID: 201730 RVA: 0x006AC3D8 File Offset: 0x006AA5D8
		public static IGetUp GetRootAsIGetUp(ByteBuffer _bb)
		{
			return IGetUp.GetRootAsIGetUp(_bb, default(IGetUp));
		}

		// Token: 0x06031403 RID: 201731 RVA: 0x006AC3F4 File Offset: 0x006AA5F4
		public static IGetUp GetRootAsIGetUp(ByteBuffer _bb, IGetUp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06031404 RID: 201732 RVA: 0x006AC411 File Offset: 0x006AA611
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06031405 RID: 201733 RVA: 0x006AC420 File Offset: 0x006AA620
		public IGetUp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0A1 RID: 53409
		// (get) Token: 0x06031406 RID: 201734 RVA: 0x006AC430 File Offset: 0x006AA630
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

		// Token: 0x06031407 RID: 201735 RVA: 0x006AC46C File Offset: 0x006AA66C
		public static Offset<IGetUp> CreateIGetUp(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IGetUp.AddType(builder, Type);
			return IGetUp.EndIGetUp(builder);
		}

		// Token: 0x06031408 RID: 201736 RVA: 0x006AC482 File Offset: 0x006AA682
		public static void StartIGetUp(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06031409 RID: 201737 RVA: 0x006AC48B File Offset: 0x006AA68B
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603140A RID: 201738 RVA: 0x006AC496 File Offset: 0x006AA696
		public static Offset<IGetUp> EndIGetUp(FlatBufferBuilder builder)
		{
			return new Offset<IGetUp>(builder.EndTable());
		}

		// Token: 0x0603140B RID: 201739 RVA: 0x006AC4A4 File Offset: 0x006AA6A4
		public IGetUpT UnPack()
		{
			IGetUpT getUpT = new IGetUpT();
			this.UnPackTo(getUpT);
			return getUpT;
		}

		// Token: 0x0603140C RID: 201740 RVA: 0x006AC4BF File Offset: 0x006AA6BF
		public void UnPackTo(IGetUpT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0603140D RID: 201741 RVA: 0x006AC4D0 File Offset: 0x006AA6D0
		public static Offset<IGetUp> Pack(FlatBufferBuilder builder, IGetUpT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGetUp>);
			}
			return IGetUp.CreateIGetUp(builder, _o.Type);
		}

		// Token: 0x04011E33 RID: 73267
		private Table __p;
	}
}
