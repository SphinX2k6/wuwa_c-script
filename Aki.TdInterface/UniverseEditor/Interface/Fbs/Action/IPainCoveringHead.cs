using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C5D RID: 27741
	public struct IPainCoveringHead : IFlatbufferObject
	{
		// Token: 0x1700CE99 RID: 52889
		// (get) Token: 0x06030E05 RID: 200197 RVA: 0x006A37FA File Offset: 0x006A19FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030E06 RID: 200198 RVA: 0x006A3807 File Offset: 0x006A1A07
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030E07 RID: 200199 RVA: 0x006A3810 File Offset: 0x006A1A10
		public static IPainCoveringHead GetRootAsIPainCoveringHead(ByteBuffer _bb)
		{
			return IPainCoveringHead.GetRootAsIPainCoveringHead(_bb, default(IPainCoveringHead));
		}

		// Token: 0x06030E08 RID: 200200 RVA: 0x006A382C File Offset: 0x006A1A2C
		public static IPainCoveringHead GetRootAsIPainCoveringHead(ByteBuffer _bb, IPainCoveringHead obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030E09 RID: 200201 RVA: 0x006A3849 File Offset: 0x006A1A49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030E0A RID: 200202 RVA: 0x006A3858 File Offset: 0x006A1A58
		public IPainCoveringHead __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CE9A RID: 52890
		// (get) Token: 0x06030E0B RID: 200203 RVA: 0x006A3868 File Offset: 0x006A1A68
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

		// Token: 0x06030E0C RID: 200204 RVA: 0x006A38A4 File Offset: 0x006A1AA4
		public static Offset<IPainCoveringHead> CreateIPainCoveringHead(FlatBufferBuilder builder, ELeisureInteract Type = ELeisureInteract.CustomSkill)
		{
			builder.StartTable(1);
			IPainCoveringHead.AddType(builder, Type);
			return IPainCoveringHead.EndIPainCoveringHead(builder);
		}

		// Token: 0x06030E0D RID: 200205 RVA: 0x006A38BA File Offset: 0x006A1ABA
		public static void StartIPainCoveringHead(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030E0E RID: 200206 RVA: 0x006A38C3 File Offset: 0x006A1AC3
		public static void AddType(FlatBufferBuilder builder, ELeisureInteract type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030E0F RID: 200207 RVA: 0x006A38CE File Offset: 0x006A1ACE
		public static Offset<IPainCoveringHead> EndIPainCoveringHead(FlatBufferBuilder builder)
		{
			return new Offset<IPainCoveringHead>(builder.EndTable());
		}

		// Token: 0x06030E10 RID: 200208 RVA: 0x006A38DC File Offset: 0x006A1ADC
		public IPainCoveringHeadT UnPack()
		{
			IPainCoveringHeadT painCoveringHeadT = new IPainCoveringHeadT();
			this.UnPackTo(painCoveringHeadT);
			return painCoveringHeadT;
		}

		// Token: 0x06030E11 RID: 200209 RVA: 0x006A38F7 File Offset: 0x006A1AF7
		public void UnPackTo(IPainCoveringHeadT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030E12 RID: 200210 RVA: 0x006A3908 File Offset: 0x006A1B08
		public static Offset<IPainCoveringHead> Pack(FlatBufferBuilder builder, IPainCoveringHeadT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPainCoveringHead>);
			}
			return IPainCoveringHead.CreateIPainCoveringHead(builder, _o.Type);
		}

		// Token: 0x040115A2 RID: 71074
		private Table __p;
	}
}
