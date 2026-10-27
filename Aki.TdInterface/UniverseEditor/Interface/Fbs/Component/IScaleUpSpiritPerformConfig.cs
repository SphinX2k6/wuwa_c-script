using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005897 RID: 22679
	public struct IScaleUpSpiritPerformConfig : IFlatbufferObject
	{
		// Token: 0x1700A9B9 RID: 43449
		// (get) Token: 0x060263BE RID: 156606 RVA: 0x005452FA File Offset: 0x005434FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060263BF RID: 156607 RVA: 0x00545307 File Offset: 0x00543507
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060263C0 RID: 156608 RVA: 0x00545310 File Offset: 0x00543510
		public static IScaleUpSpiritPerformConfig GetRootAsIScaleUpSpiritPerformConfig(ByteBuffer _bb)
		{
			return IScaleUpSpiritPerformConfig.GetRootAsIScaleUpSpiritPerformConfig(_bb, default(IScaleUpSpiritPerformConfig));
		}

		// Token: 0x060263C1 RID: 156609 RVA: 0x0054532C File Offset: 0x0054352C
		public static IScaleUpSpiritPerformConfig GetRootAsIScaleUpSpiritPerformConfig(ByteBuffer _bb, IScaleUpSpiritPerformConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060263C2 RID: 156610 RVA: 0x00545349 File Offset: 0x00543549
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060263C3 RID: 156611 RVA: 0x00545358 File Offset: 0x00543558
		public IScaleUpSpiritPerformConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9BA RID: 43450
		// (get) Token: 0x060263C4 RID: 156612 RVA: 0x00545368 File Offset: 0x00543568
		public bool IsInitHide
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A9BB RID: 43451
		// (get) Token: 0x060263C5 RID: 156613 RVA: 0x005453A8 File Offset: 0x005435A8
		public string AppearEffectDa
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060263C6 RID: 156614 RVA: 0x005453DF File Offset: 0x005435DF
		public Span<byte> GetAppearEffectDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060263C7 RID: 156615 RVA: 0x005453EE File Offset: 0x005435EE
		public byte[] GetAppearEffectDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A9BC RID: 43452
		// (get) Token: 0x060263C8 RID: 156616 RVA: 0x005453FC File Offset: 0x005435FC
		public string ScaleUpEffectDa
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060263C9 RID: 156617 RVA: 0x00545433 File Offset: 0x00543633
		public Span<byte> GetScaleUpEffectDaBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060263CA RID: 156618 RVA: 0x00545442 File Offset: 0x00543642
		public byte[] GetScaleUpEffectDaArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A9BD RID: 43453
		// (get) Token: 0x060263CB RID: 156619 RVA: 0x00545450 File Offset: 0x00543650
		public int ScaleUpPerformTag
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A9BE RID: 43454
		// (get) Token: 0x060263CC RID: 156620 RVA: 0x00545490 File Offset: 0x00543690
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060263CD RID: 156621 RVA: 0x005454CD File Offset: 0x005436CD
		public static Offset<IScaleUpSpiritPerformConfig> CreateIScaleUpSpiritPerformConfig(FlatBufferBuilder builder, bool IsInitHide = false, StringOffset AppearEffectDaOffset = default(StringOffset), StringOffset ScaleUpEffectDaOffset = default(StringOffset), int ScaleUpPerformTag = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IScaleUpSpiritPerformConfig.AddScaleUpPerformTag(builder, ScaleUpPerformTag);
			IScaleUpSpiritPerformConfig.AddScaleUpEffectDa(builder, ScaleUpEffectDaOffset);
			IScaleUpSpiritPerformConfig.AddAppearEffectDa(builder, AppearEffectDaOffset);
			IScaleUpSpiritPerformConfig.AddNullMask(builder, NullMask);
			IScaleUpSpiritPerformConfig.AddIsInitHide(builder, IsInitHide);
			return IScaleUpSpiritPerformConfig.EndIScaleUpSpiritPerformConfig(builder);
		}

		// Token: 0x060263CE RID: 156622 RVA: 0x00545501 File Offset: 0x00543701
		public static void StartIScaleUpSpiritPerformConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060263CF RID: 156623 RVA: 0x0054550A File Offset: 0x0054370A
		public static void AddIsInitHide(FlatBufferBuilder builder, bool isInitHide)
		{
			builder.AddBool(0, isInitHide, false);
		}

		// Token: 0x060263D0 RID: 156624 RVA: 0x00545515 File Offset: 0x00543715
		public static void AddAppearEffectDa(FlatBufferBuilder builder, StringOffset appearEffectDaOffset)
		{
			builder.AddOffset(1, appearEffectDaOffset.Value, 0);
		}

		// Token: 0x060263D1 RID: 156625 RVA: 0x00545525 File Offset: 0x00543725
		public static void AddScaleUpEffectDa(FlatBufferBuilder builder, StringOffset scaleUpEffectDaOffset)
		{
			builder.AddOffset(2, scaleUpEffectDaOffset.Value, 0);
		}

		// Token: 0x060263D2 RID: 156626 RVA: 0x00545535 File Offset: 0x00543735
		public static void AddScaleUpPerformTag(FlatBufferBuilder builder, int scaleUpPerformTag)
		{
			builder.AddInt(3, scaleUpPerformTag, 0);
		}

		// Token: 0x060263D3 RID: 156627 RVA: 0x00545540 File Offset: 0x00543740
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060263D4 RID: 156628 RVA: 0x0054554B File Offset: 0x0054374B
		public static Offset<IScaleUpSpiritPerformConfig> EndIScaleUpSpiritPerformConfig(FlatBufferBuilder builder)
		{
			return new Offset<IScaleUpSpiritPerformConfig>(builder.EndTable());
		}

		// Token: 0x060263D5 RID: 156629 RVA: 0x00545558 File Offset: 0x00543758
		public IScaleUpSpiritPerformConfigT UnPack()
		{
			IScaleUpSpiritPerformConfigT scaleUpSpiritPerformConfigT = new IScaleUpSpiritPerformConfigT();
			this.UnPackTo(scaleUpSpiritPerformConfigT);
			return scaleUpSpiritPerformConfigT;
		}

		// Token: 0x060263D6 RID: 156630 RVA: 0x00545573 File Offset: 0x00543773
		public void UnPackTo(IScaleUpSpiritPerformConfigT _o)
		{
			_o.IsInitHide = this.IsInitHide;
			_o.AppearEffectDa = this.AppearEffectDa;
			_o.ScaleUpEffectDa = this.ScaleUpEffectDa;
			_o.ScaleUpPerformTag = this.ScaleUpPerformTag;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060263D7 RID: 156631 RVA: 0x005455B4 File Offset: 0x005437B4
		public static Offset<IScaleUpSpiritPerformConfig> Pack(FlatBufferBuilder builder, IScaleUpSpiritPerformConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IScaleUpSpiritPerformConfig>);
			}
			StringOffset appearEffectDaOffset = (_o.AppearEffectDa == null) ? default(StringOffset) : builder.CreateString(_o.AppearEffectDa);
			StringOffset scaleUpEffectDaOffset = (_o.ScaleUpEffectDa == null) ? default(StringOffset) : builder.CreateString(_o.ScaleUpEffectDa);
			return IScaleUpSpiritPerformConfig.CreateIScaleUpSpiritPerformConfig(builder, _o.IsInitHide, appearEffectDaOffset, scaleUpEffectDaOffset, _o.ScaleUpPerformTag, _o.NullMask);
		}

		// Token: 0x0400EDF4 RID: 60916
		private Table __p;
	}
}
