using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E2 RID: 22754
	public struct IGuideLineCreatorScanOption : IFlatbufferObject
	{
		// Token: 0x1700A504 RID: 42244
		// (get) Token: 0x06024F48 RID: 151368 RVA: 0x00512D29 File Offset: 0x00510F29
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024F49 RID: 151369 RVA: 0x00512D36 File Offset: 0x00510F36
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024F4A RID: 151370 RVA: 0x00512D40 File Offset: 0x00510F40
		public static IGuideLineCreatorScanOption GetRootAsIGuideLineCreatorScanOption(ByteBuffer _bb)
		{
			return IGuideLineCreatorScanOption.GetRootAsIGuideLineCreatorScanOption(_bb, default(IGuideLineCreatorScanOption));
		}

		// Token: 0x06024F4B RID: 151371 RVA: 0x00512D5C File Offset: 0x00510F5C
		public static IGuideLineCreatorScanOption GetRootAsIGuideLineCreatorScanOption(ByteBuffer _bb, IGuideLineCreatorScanOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024F4C RID: 151372 RVA: 0x00512D79 File Offset: 0x00510F79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024F4D RID: 151373 RVA: 0x00512D88 File Offset: 0x00510F88
		public IGuideLineCreatorScanOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A505 RID: 42245
		// (get) Token: 0x06024F4E RID: 151374 RVA: 0x00512D98 File Offset: 0x00510F98
		public int ResponseRange
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024F4F RID: 151375 RVA: 0x00512DD4 File Offset: 0x00510FD4
		public static Offset<IGuideLineCreatorScanOption> CreateIGuideLineCreatorScanOption(FlatBufferBuilder builder, int ResponseRange = 0)
		{
			builder.StartTable(1);
			IGuideLineCreatorScanOption.AddResponseRange(builder, ResponseRange);
			return IGuideLineCreatorScanOption.EndIGuideLineCreatorScanOption(builder);
		}

		// Token: 0x06024F50 RID: 151376 RVA: 0x00512DEA File Offset: 0x00510FEA
		public static void StartIGuideLineCreatorScanOption(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06024F51 RID: 151377 RVA: 0x00512DF3 File Offset: 0x00510FF3
		public static void AddResponseRange(FlatBufferBuilder builder, int responseRange)
		{
			builder.AddInt(0, responseRange, 0);
		}

		// Token: 0x06024F52 RID: 151378 RVA: 0x00512DFE File Offset: 0x00510FFE
		public static Offset<IGuideLineCreatorScanOption> EndIGuideLineCreatorScanOption(FlatBufferBuilder builder)
		{
			return new Offset<IGuideLineCreatorScanOption>(builder.EndTable());
		}

		// Token: 0x06024F53 RID: 151379 RVA: 0x00512E0C File Offset: 0x0051100C
		public IGuideLineCreatorScanOptionT UnPack()
		{
			IGuideLineCreatorScanOptionT guideLineCreatorScanOptionT = new IGuideLineCreatorScanOptionT();
			this.UnPackTo(guideLineCreatorScanOptionT);
			return guideLineCreatorScanOptionT;
		}

		// Token: 0x06024F54 RID: 151380 RVA: 0x00512E27 File Offset: 0x00511027
		public void UnPackTo(IGuideLineCreatorScanOptionT _o)
		{
			_o.ResponseRange = this.ResponseRange;
		}

		// Token: 0x06024F55 RID: 151381 RVA: 0x00512E38 File Offset: 0x00511038
		public static Offset<IGuideLineCreatorScanOption> Pack(FlatBufferBuilder builder, IGuideLineCreatorScanOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGuideLineCreatorScanOption>);
			}
			return IGuideLineCreatorScanOption.CreateIGuideLineCreatorScanOption(builder, _o.ResponseRange);
		}

		// Token: 0x0400F166 RID: 61798
		private Table __p;
	}
}
