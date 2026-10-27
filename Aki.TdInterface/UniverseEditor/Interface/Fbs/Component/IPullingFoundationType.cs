using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057B1 RID: 22449
	public struct IPullingFoundationType : IFlatbufferObject
	{
		// Token: 0x1700A798 RID: 42904
		// (get) Token: 0x06025AD6 RID: 154326 RVA: 0x005327A7 File Offset: 0x005309A7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025AD7 RID: 154327 RVA: 0x005327B4 File Offset: 0x005309B4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025AD8 RID: 154328 RVA: 0x005327BC File Offset: 0x005309BC
		public static IPullingFoundationType GetRootAsIPullingFoundationType(ByteBuffer _bb)
		{
			return IPullingFoundationType.GetRootAsIPullingFoundationType(_bb, default(IPullingFoundationType));
		}

		// Token: 0x06025AD9 RID: 154329 RVA: 0x005327D8 File Offset: 0x005309D8
		public static IPullingFoundationType GetRootAsIPullingFoundationType(ByteBuffer _bb, IPullingFoundationType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025ADA RID: 154330 RVA: 0x005327F5 File Offset: 0x005309F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025ADB RID: 154331 RVA: 0x00532804 File Offset: 0x00530A04
		public IPullingFoundationType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A799 RID: 42905
		// (get) Token: 0x06025ADC RID: 154332 RVA: 0x00532814 File Offset: 0x00530A14
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

		// Token: 0x06025ADD RID: 154333 RVA: 0x00532850 File Offset: 0x00530A50
		public static Offset<IPullingFoundationType> CreateIPullingFoundationType(FlatBufferBuilder builder, EPullingFoundation Type = EPullingFoundation.CategoryMatching)
		{
			builder.StartTable(1);
			IPullingFoundationType.AddType(builder, Type);
			return IPullingFoundationType.EndIPullingFoundationType(builder);
		}

		// Token: 0x06025ADE RID: 154334 RVA: 0x00532866 File Offset: 0x00530A66
		public static void StartIPullingFoundationType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06025ADF RID: 154335 RVA: 0x0053286F File Offset: 0x00530A6F
		public static void AddType(FlatBufferBuilder builder, EPullingFoundation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025AE0 RID: 154336 RVA: 0x0053287A File Offset: 0x00530A7A
		public static Offset<IPullingFoundationType> EndIPullingFoundationType(FlatBufferBuilder builder)
		{
			return new Offset<IPullingFoundationType>(builder.EndTable());
		}

		// Token: 0x06025AE1 RID: 154337 RVA: 0x00532888 File Offset: 0x00530A88
		public IPullingFoundationTypeT UnPack()
		{
			IPullingFoundationTypeT pullingFoundationTypeT = new IPullingFoundationTypeT();
			this.UnPackTo(pullingFoundationTypeT);
			return pullingFoundationTypeT;
		}

		// Token: 0x06025AE2 RID: 154338 RVA: 0x005328A3 File Offset: 0x00530AA3
		public void UnPackTo(IPullingFoundationTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06025AE3 RID: 154339 RVA: 0x005328B4 File Offset: 0x00530AB4
		public static Offset<IPullingFoundationType> Pack(FlatBufferBuilder builder, IPullingFoundationTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPullingFoundationType>);
			}
			return IPullingFoundationType.CreateIPullingFoundationType(builder, _o.Type);
		}

		// Token: 0x0400EC89 RID: 60553
		private Table __p;
	}
}
