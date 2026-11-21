using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DBE RID: 23998
	public struct IPulseDeviceFoundation : IFlatbufferObject
	{
		// Token: 0x1700B0C1 RID: 45249
		// (get) Token: 0x06028014 RID: 163860 RVA: 0x00578BA6 File Offset: 0x00576DA6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06028015 RID: 163861 RVA: 0x00578BB3 File Offset: 0x00576DB3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028016 RID: 163862 RVA: 0x00578BBC File Offset: 0x00576DBC
		public static IPulseDeviceFoundation GetRootAsIPulseDeviceFoundation(ByteBuffer _bb)
		{
			return IPulseDeviceFoundation.GetRootAsIPulseDeviceFoundation(_bb, default(IPulseDeviceFoundation));
		}

		// Token: 0x06028017 RID: 163863 RVA: 0x00578BD8 File Offset: 0x00576DD8
		public static IPulseDeviceFoundation GetRootAsIPulseDeviceFoundation(ByteBuffer _bb, IPulseDeviceFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028018 RID: 163864 RVA: 0x00578BF5 File Offset: 0x00576DF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028019 RID: 163865 RVA: 0x00578C04 File Offset: 0x00576E04
		public IPulseDeviceFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0C2 RID: 45250
		// (get) Token: 0x0602801A RID: 163866 RVA: 0x00578C14 File Offset: 0x00576E14
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

		// Token: 0x0602801B RID: 163867 RVA: 0x00578C50 File Offset: 0x00576E50
		public static Offset<IPulseDeviceFoundation> CreateIPulseDeviceFoundation(FlatBufferBuilder builder, EItemFoundation Type = EItemFoundation.CategoryMatching)
		{
			builder.StartTable(1);
			IPulseDeviceFoundation.AddType(builder, Type);
			return IPulseDeviceFoundation.EndIPulseDeviceFoundation(builder);
		}

		// Token: 0x0602801C RID: 163868 RVA: 0x00578C66 File Offset: 0x00576E66
		public static void StartIPulseDeviceFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602801D RID: 163869 RVA: 0x00578C6F File Offset: 0x00576E6F
		public static void AddType(FlatBufferBuilder builder, EItemFoundation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602801E RID: 163870 RVA: 0x00578C7A File Offset: 0x00576E7A
		public static Offset<IPulseDeviceFoundation> EndIPulseDeviceFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IPulseDeviceFoundation>(builder.EndTable());
		}

		// Token: 0x0602801F RID: 163871 RVA: 0x00578C88 File Offset: 0x00576E88
		public IPulseDeviceFoundationT UnPack()
		{
			IPulseDeviceFoundationT pulseDeviceFoundationT = new IPulseDeviceFoundationT();
			this.UnPackTo(pulseDeviceFoundationT);
			return pulseDeviceFoundationT;
		}

		// Token: 0x06028020 RID: 163872 RVA: 0x00578CA3 File Offset: 0x00576EA3
		public void UnPackTo(IPulseDeviceFoundationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028021 RID: 163873 RVA: 0x00578CB4 File Offset: 0x00576EB4
		public static Offset<IPulseDeviceFoundation> Pack(FlatBufferBuilder builder, IPulseDeviceFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPulseDeviceFoundation>);
			}
			return IPulseDeviceFoundation.CreateIPulseDeviceFoundation(builder, _o.Type);
		}

		// Token: 0x0400F97C RID: 63868
		private Table __p;
	}
}
