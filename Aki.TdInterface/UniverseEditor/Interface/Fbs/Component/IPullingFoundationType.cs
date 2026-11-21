using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DB8 RID: 23992
	public struct IPullingFoundationType : IFlatbufferObject
	{
		// Token: 0x1700B0BC RID: 45244
		// (get) Token: 0x06027FF6 RID: 163830 RVA: 0x00578933 File Offset: 0x00576B33
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027FF7 RID: 163831 RVA: 0x00578940 File Offset: 0x00576B40
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027FF8 RID: 163832 RVA: 0x00578948 File Offset: 0x00576B48
		public static IPullingFoundationType GetRootAsIPullingFoundationType(ByteBuffer _bb)
		{
			return IPullingFoundationType.GetRootAsIPullingFoundationType(_bb, default(IPullingFoundationType));
		}

		// Token: 0x06027FF9 RID: 163833 RVA: 0x00578964 File Offset: 0x00576B64
		public static IPullingFoundationType GetRootAsIPullingFoundationType(ByteBuffer _bb, IPullingFoundationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027FFA RID: 163834 RVA: 0x00578981 File Offset: 0x00576B81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027FFB RID: 163835 RVA: 0x00578990 File Offset: 0x00576B90
		public IPullingFoundationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0BD RID: 45245
		// (get) Token: 0x06027FFC RID: 163836 RVA: 0x005789A0 File Offset: 0x00576BA0
		public EPullingFoundation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPullingFoundation.CategoryMatching;
				}
				return (EPullingFoundation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027FFD RID: 163837 RVA: 0x005789DC File Offset: 0x00576BDC
		public static Offset<IPullingFoundationType> CreateIPullingFoundationType(FlatBufferBuilder builder, EPullingFoundation Type = EPullingFoundation.CategoryMatching)
		{
			builder.StartTable(1);
			IPullingFoundationType.AddType(builder, Type);
			return IPullingFoundationType.EndIPullingFoundationType(builder);
		}

		// Token: 0x06027FFE RID: 163838 RVA: 0x005789F2 File Offset: 0x00576BF2
		public static void StartIPullingFoundationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027FFF RID: 163839 RVA: 0x005789FB File Offset: 0x00576BFB
		public static void AddType(FlatBufferBuilder builder, EPullingFoundation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06028000 RID: 163840 RVA: 0x00578A06 File Offset: 0x00576C06
		public static Offset<IPullingFoundationType> EndIPullingFoundationType(FlatBufferBuilder builder)
		{
			return new Offset<IPullingFoundationType>(builder.EndTable());
		}

		// Token: 0x06028001 RID: 163841 RVA: 0x00578A14 File Offset: 0x00576C14
		public IPullingFoundationTypeT UnPack()
		{
			IPullingFoundationTypeT pullingFoundationTypeT = new IPullingFoundationTypeT();
			this.UnPackTo(pullingFoundationTypeT);
			return pullingFoundationTypeT;
		}

		// Token: 0x06028002 RID: 163842 RVA: 0x00578A2F File Offset: 0x00576C2F
		public void UnPackTo(IPullingFoundationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06028003 RID: 163843 RVA: 0x00578A40 File Offset: 0x00576C40
		public static Offset<IPullingFoundationType> Pack(FlatBufferBuilder builder, IPullingFoundationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPullingFoundationType>);
			}
			return IPullingFoundationType.CreateIPullingFoundationType(builder, _o.Type);
		}

		// Token: 0x0400F974 RID: 63860
		private Table __p;
	}
}
