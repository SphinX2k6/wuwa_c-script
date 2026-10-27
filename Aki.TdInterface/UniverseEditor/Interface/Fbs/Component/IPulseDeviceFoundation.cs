using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B7 RID: 22455
	public struct IPulseDeviceFoundation : IFlatbufferObject
	{
		// Token: 0x1700A79D RID: 42909
		// (get) Token: 0x06025AF4 RID: 154356 RVA: 0x00532A1A File Offset: 0x00530C1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025AF5 RID: 154357 RVA: 0x00532A27 File Offset: 0x00530C27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025AF6 RID: 154358 RVA: 0x00532A30 File Offset: 0x00530C30
		public static IPulseDeviceFoundation GetRootAsIPulseDeviceFoundation(ByteBuffer _bb)
		{
			return IPulseDeviceFoundation.GetRootAsIPulseDeviceFoundation(_bb, default(IPulseDeviceFoundation));
		}

		// Token: 0x06025AF7 RID: 154359 RVA: 0x00532A4C File Offset: 0x00530C4C
		public static IPulseDeviceFoundation GetRootAsIPulseDeviceFoundation(ByteBuffer _bb, IPulseDeviceFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025AF8 RID: 154360 RVA: 0x00532A69 File Offset: 0x00530C69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025AF9 RID: 154361 RVA: 0x00532A78 File Offset: 0x00530C78
		public IPulseDeviceFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A79E RID: 42910
		// (get) Token: 0x06025AFA RID: 154362 RVA: 0x00532A88 File Offset: 0x00530C88
		public EItemFoundation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EItemFoundation.CategoryMatching;
				}
				return (EItemFoundation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025AFB RID: 154363 RVA: 0x00532AC4 File Offset: 0x00530CC4
		public static Offset<IPulseDeviceFoundation> CreateIPulseDeviceFoundation(FlatBufferBuilder builder, EItemFoundation Type = EItemFoundation.CategoryMatching)
		{
			builder.StartTable(1);
			IPulseDeviceFoundation.AddType(builder, Type);
			return IPulseDeviceFoundation.EndIPulseDeviceFoundation(builder);
		}

		// Token: 0x06025AFC RID: 154364 RVA: 0x00532ADA File Offset: 0x00530CDA
		public static void StartIPulseDeviceFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025AFD RID: 154365 RVA: 0x00532AE3 File Offset: 0x00530CE3
		public static void AddType(FlatBufferBuilder builder, EItemFoundation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025AFE RID: 154366 RVA: 0x00532AEE File Offset: 0x00530CEE
		public static Offset<IPulseDeviceFoundation> EndIPulseDeviceFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IPulseDeviceFoundation>(builder.EndTable());
		}

		// Token: 0x06025AFF RID: 154367 RVA: 0x00532AFC File Offset: 0x00530CFC
		public IPulseDeviceFoundationT UnPack()
		{
			IPulseDeviceFoundationT pulseDeviceFoundationT = new IPulseDeviceFoundationT();
			this.UnPackTo(pulseDeviceFoundationT);
			return pulseDeviceFoundationT;
		}

		// Token: 0x06025B00 RID: 154368 RVA: 0x00532B17 File Offset: 0x00530D17
		public void UnPackTo(IPulseDeviceFoundationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025B01 RID: 154369 RVA: 0x00532B28 File Offset: 0x00530D28
		public static Offset<IPulseDeviceFoundation> Pack(FlatBufferBuilder builder, IPulseDeviceFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPulseDeviceFoundation>);
			}
			return IPulseDeviceFoundation.CreateIPulseDeviceFoundation(builder, _o.Type);
		}

		// Token: 0x0400EC91 RID: 60561
		private Table __p;
	}
}
