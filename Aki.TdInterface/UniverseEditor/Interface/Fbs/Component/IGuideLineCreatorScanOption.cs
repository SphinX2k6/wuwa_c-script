using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200535C RID: 21340
	public struct IGuideLineCreatorScanOption : IFlatbufferObject
	{
		// Token: 0x17009CCC RID: 40140
		// (get) Token: 0x06022E94 RID: 142996 RVA: 0x004D5E55 File Offset: 0x004D4055
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022E95 RID: 142997 RVA: 0x004D5E62 File Offset: 0x004D4062
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022E96 RID: 142998 RVA: 0x004D5E6C File Offset: 0x004D406C
		public static IGuideLineCreatorScanOption GetRootAsIGuideLineCreatorScanOption(ByteBuffer _bb)
		{
			return IGuideLineCreatorScanOption.GetRootAsIGuideLineCreatorScanOption(_bb, default(IGuideLineCreatorScanOption));
		}

		// Token: 0x06022E97 RID: 142999 RVA: 0x004D5E88 File Offset: 0x004D4088
		public static IGuideLineCreatorScanOption GetRootAsIGuideLineCreatorScanOption(ByteBuffer _bb, IGuideLineCreatorScanOption obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022E98 RID: 143000 RVA: 0x004D5EA5 File Offset: 0x004D40A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022E99 RID: 143001 RVA: 0x004D5EB4 File Offset: 0x004D40B4
		public IGuideLineCreatorScanOption __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CCD RID: 40141
		// (get) Token: 0x06022E9A RID: 143002 RVA: 0x004D5EC4 File Offset: 0x004D40C4
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

		// Token: 0x06022E9B RID: 143003 RVA: 0x004D5F00 File Offset: 0x004D4100
		public static Offset<IGuideLineCreatorScanOption> CreateIGuideLineCreatorScanOption(FlatBufferBuilder builder, int ResponseRange = 0)
		{
			builder.StartTable(1);
			IGuideLineCreatorScanOption.AddResponseRange(builder, ResponseRange);
			return IGuideLineCreatorScanOption.EndIGuideLineCreatorScanOption(builder);
		}

		// Token: 0x06022E9C RID: 143004 RVA: 0x004D5F16 File Offset: 0x004D4116
		public static void StartIGuideLineCreatorScanOption(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06022E9D RID: 143005 RVA: 0x004D5F1F File Offset: 0x004D411F
		public static void AddResponseRange(FlatBufferBuilder builder, int responseRange)
		{
			builder.AddInt(0, responseRange, 0);
		}

		// Token: 0x06022E9E RID: 143006 RVA: 0x004D5F2A File Offset: 0x004D412A
		public static Offset<IGuideLineCreatorScanOption> EndIGuideLineCreatorScanOption(FlatBufferBuilder builder)
		{
			return new Offset<IGuideLineCreatorScanOption>(builder.EndTable());
		}

		// Token: 0x06022E9F RID: 143007 RVA: 0x004D5F38 File Offset: 0x004D4138
		public IGuideLineCreatorScanOptionT UnPack()
		{
			IGuideLineCreatorScanOptionT guideLineCreatorScanOptionT = new IGuideLineCreatorScanOptionT();
			this.UnPackTo(guideLineCreatorScanOptionT);
			return guideLineCreatorScanOptionT;
		}

		// Token: 0x06022EA0 RID: 143008 RVA: 0x004D5F53 File Offset: 0x004D4153
		public void UnPackTo(IGuideLineCreatorScanOptionT _o)
		{
			_o.ResponseRange = this.ResponseRange;
		}

		// Token: 0x06022EA1 RID: 143009 RVA: 0x004D5F64 File Offset: 0x004D4164
		public static Offset<IGuideLineCreatorScanOption> Pack(FlatBufferBuilder builder, IGuideLineCreatorScanOptionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGuideLineCreatorScanOption>);
			}
			return IGuideLineCreatorScanOption.CreateIGuideLineCreatorScanOption(builder, _o.ResponseRange);
		}

		// Token: 0x0400E536 RID: 58678
		private Table __p;
	}
}
