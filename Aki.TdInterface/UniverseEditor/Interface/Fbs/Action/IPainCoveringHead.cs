using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C4 RID: 29636
	public struct IPainCoveringHead : IFlatbufferObject
	{
		// Token: 0x1700D9B4 RID: 55732
		// (get) Token: 0x06033D60 RID: 212320 RVA: 0x006FDCFA File Offset: 0x006FBEFA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033D61 RID: 212321 RVA: 0x006FDD07 File Offset: 0x006FBF07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033D62 RID: 212322 RVA: 0x006FDD10 File Offset: 0x006FBF10
		public static IPainCoveringHead GetRootAsIPainCoveringHead(ByteBuffer _bb)
		{
			return IPainCoveringHead.GetRootAsIPainCoveringHead(_bb, default(IPainCoveringHead));
		}

		// Token: 0x06033D63 RID: 212323 RVA: 0x006FDD2C File Offset: 0x006FBF2C
		public static IPainCoveringHead GetRootAsIPainCoveringHead(ByteBuffer _bb, IPainCoveringHead obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033D64 RID: 212324 RVA: 0x006FDD49 File Offset: 0x006FBF49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033D65 RID: 212325 RVA: 0x006FDD58 File Offset: 0x006FBF58
		public IPainCoveringHead __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D9B5 RID: 55733
		// (get) Token: 0x06033D66 RID: 212326 RVA: 0x006FDD68 File Offset: 0x006FBF68
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

		// Token: 0x06033D67 RID: 212327 RVA: 0x006FDDA4 File Offset: 0x006FBFA4
		public static Offset<IPainCoveringHead> CreateIPainCoveringHead(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IPainCoveringHead.AddType(builder, Type);
			return IPainCoveringHead.EndIPainCoveringHead(builder);
		}

		// Token: 0x06033D68 RID: 212328 RVA: 0x006FDDBA File Offset: 0x006FBFBA
		public static void StartIPainCoveringHead(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033D69 RID: 212329 RVA: 0x006FDDC3 File Offset: 0x006FBFC3
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033D6A RID: 212330 RVA: 0x006FDDCE File Offset: 0x006FBFCE
		public static Offset<IPainCoveringHead> EndIPainCoveringHead(FlatBufferBuilder builder)
		{
			return new Offset<IPainCoveringHead>(builder.EndTable());
		}

		// Token: 0x06033D6B RID: 212331 RVA: 0x006FDDDC File Offset: 0x006FBFDC
		public IPainCoveringHeadT UnPack()
		{
			IPainCoveringHeadT painCoveringHeadT = new IPainCoveringHeadT();
			this.UnPackTo(painCoveringHeadT);
			return painCoveringHeadT;
		}

		// Token: 0x06033D6C RID: 212332 RVA: 0x006FDDF7 File Offset: 0x006FBFF7
		public void UnPackTo(IPainCoveringHeadT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033D6D RID: 212333 RVA: 0x006FDE08 File Offset: 0x006FC008
		public static Offset<IPainCoveringHead> Pack(FlatBufferBuilder builder, IPainCoveringHeadT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPainCoveringHead>);
			}
			return IPainCoveringHead.CreateIPainCoveringHead(builder, _o.Type);
		}

		// Token: 0x040124FA RID: 75002
		private Table __p;
	}
}
