using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E5F RID: 20063
	public struct IAdsorbAddBuff : IFlatbufferObject
	{
		// Token: 0x17008F92 RID: 36754
		// (get) Token: 0x0601F7F0 RID: 129008 RVA: 0x00463142 File Offset: 0x00461342
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601F7F1 RID: 129009 RVA: 0x0046314F File Offset: 0x0046134F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601F7F2 RID: 129010 RVA: 0x00463158 File Offset: 0x00461358
		public static IAdsorbAddBuff GetRootAsIAdsorbAddBuff(ByteBuffer _bb)
		{
			return IAdsorbAddBuff.GetRootAsIAdsorbAddBuff(_bb, default(IAdsorbAddBuff));
		}

		// Token: 0x0601F7F3 RID: 129011 RVA: 0x00463174 File Offset: 0x00461374
		public static IAdsorbAddBuff GetRootAsIAdsorbAddBuff(ByteBuffer _bb, IAdsorbAddBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601F7F4 RID: 129012 RVA: 0x00463191 File Offset: 0x00461391
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601F7F5 RID: 129013 RVA: 0x004631A0 File Offset: 0x004613A0
		public IAdsorbAddBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008F93 RID: 36755
		// (get) Token: 0x0601F7F6 RID: 129014 RVA: 0x004631B0 File Offset: 0x004613B0
		public EBuffProducerMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBuffProducerMode.Immediate;
				}
				return (EBuffProducerMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008F94 RID: 36756
		// (get) Token: 0x0601F7F7 RID: 129015 RVA: 0x004631EC File Offset: 0x004613EC
		public int Speed
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

		// Token: 0x0601F7F8 RID: 129016 RVA: 0x00463228 File Offset: 0x00461428
		public static Offset<IAdsorbAddBuff> CreateIAdsorbAddBuff(FlatBufferBuilder builder, EBuffProducerMode Type = EBuffProducerMode.Immediate, int Speed = 0)
		{
			builder.StartTable(2);
			IAdsorbAddBuff.AddSpeed(builder, Speed);
			IAdsorbAddBuff.AddType(builder, Type);
			return IAdsorbAddBuff.EndIAdsorbAddBuff(builder);
		}

		// Token: 0x0601F7F9 RID: 129017 RVA: 0x00463245 File Offset: 0x00461445
		public static void StartIAdsorbAddBuff(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601F7FA RID: 129018 RVA: 0x0046324E File Offset: 0x0046144E
		public static void AddType(FlatBufferBuilder builder, EBuffProducerMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601F7FB RID: 129019 RVA: 0x00463259 File Offset: 0x00461459
		public static void AddSpeed(FlatBufferBuilder builder, int speed)
		{
			builder.AddInt(1, speed, 0);
		}

		// Token: 0x0601F7FC RID: 129020 RVA: 0x00463264 File Offset: 0x00461464
		public static Offset<IAdsorbAddBuff> EndIAdsorbAddBuff(FlatBufferBuilder builder)
		{
			return new Offset<IAdsorbAddBuff>(builder.EndTable());
		}

		// Token: 0x0601F7FD RID: 129021 RVA: 0x00463274 File Offset: 0x00461474
		public IAdsorbAddBuffT UnPack()
		{
			IAdsorbAddBuffT adsorbAddBuffT = new IAdsorbAddBuffT();
			this.UnPackTo(adsorbAddBuffT);
			return adsorbAddBuffT;
		}

		// Token: 0x0601F7FE RID: 129022 RVA: 0x0046328F File Offset: 0x0046148F
		public void UnPackTo(IAdsorbAddBuffT _o)
		{
			_o.Type = this.Type;
			_o.Speed = this.Speed;
		}

		// Token: 0x0601F7FF RID: 129023 RVA: 0x004632AC File Offset: 0x004614AC
		public static Offset<IAdsorbAddBuff> Pack(FlatBufferBuilder builder, IAdsorbAddBuffT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAdsorbAddBuff>);
			}
			return IAdsorbAddBuff.CreateIAdsorbAddBuff(builder, _o.Type, _o.Speed);
		}

		// Token: 0x0400DC01 RID: 56321
		private Table __p;
	}
}
