using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058DF RID: 22751
	public struct IGuideLineCreatorComponent : IFlatbufferObject
	{
		// Token: 0x1700A4F9 RID: 42233
		// (get) Token: 0x06024F26 RID: 151334 RVA: 0x00512878 File Offset: 0x00510A78
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024F27 RID: 151335 RVA: 0x00512885 File Offset: 0x00510A85
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024F28 RID: 151336 RVA: 0x0051288C File Offset: 0x00510A8C
		public static IGuideLineCreatorComponent GetRootAsIGuideLineCreatorComponent(ByteBuffer _bb)
		{
			return IGuideLineCreatorComponent.GetRootAsIGuideLineCreatorComponent(_bb, default(IGuideLineCreatorComponent));
		}

		// Token: 0x06024F29 RID: 151337 RVA: 0x005128A8 File Offset: 0x00510AA8
		public static IGuideLineCreatorComponent GetRootAsIGuideLineCreatorComponent(ByteBuffer _bb, IGuideLineCreatorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024F2A RID: 151338 RVA: 0x005128C5 File Offset: 0x00510AC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024F2B RID: 151339 RVA: 0x005128D4 File Offset: 0x00510AD4
		public IGuideLineCreatorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4FA RID: 42234
		// (get) Token: 0x06024F2C RID: 151340 RVA: 0x005128E4 File Offset: 0x00510AE4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A4FB RID: 42235
		// (get) Token: 0x06024F2D RID: 151341 RVA: 0x00512924 File Offset: 0x00510B24
		public IColorChangeStrategyOfRGB? ColorChangeOption
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IColorChangeStrategyOfRGB?(default(IColorChangeStrategyOfRGB).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A4FC RID: 42236
		// (get) Token: 0x06024F2E RID: 151342 RVA: 0x00512984 File Offset: 0x00510B84
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A4FD RID: 42237
		// (get) Token: 0x06024F2F RID: 151343 RVA: 0x005129C0 File Offset: 0x00510BC0
		public IGuideLineCreatorScanOption? ScanOption
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IGuideLineCreatorScanOption?(default(IGuideLineCreatorScanOption).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A4FE RID: 42238
		// (get) Token: 0x06024F30 RID: 151344 RVA: 0x00512A20 File Offset: 0x00510C20
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

		// Token: 0x06024F31 RID: 151345 RVA: 0x00512A5D File Offset: 0x00510C5D
		public static Offset<IGuideLineCreatorComponent> CreateIGuideLineCreatorComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IColorChangeStrategyOfRGB> ColorChangeOptionOffset = default(Offset<IColorChangeStrategyOfRGB>), int SplineEntityId = 0, Offset<IGuideLineCreatorScanOption> ScanOptionOffset = default(Offset<IGuideLineCreatorScanOption>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IGuideLineCreatorComponent.AddScanOption(builder, ScanOptionOffset);
			IGuideLineCreatorComponent.AddSplineEntityId(builder, SplineEntityId);
			IGuideLineCreatorComponent.AddColorChangeOption(builder, ColorChangeOptionOffset);
			IGuideLineCreatorComponent.AddNullMask(builder, NullMask);
			IGuideLineCreatorComponent.AddDisabled(builder, Disabled);
			return IGuideLineCreatorComponent.EndIGuideLineCreatorComponent(builder);
		}

		// Token: 0x06024F32 RID: 151346 RVA: 0x00512A91 File Offset: 0x00510C91
		public static void StartIGuideLineCreatorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06024F33 RID: 151347 RVA: 0x00512A9A File Offset: 0x00510C9A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024F34 RID: 151348 RVA: 0x00512AA5 File Offset: 0x00510CA5
		public static void AddColorChangeOption(FlatBufferBuilder builder, Offset<IColorChangeStrategyOfRGB> colorChangeOptionOffset)
		{
			builder.AddOffset(1, colorChangeOptionOffset.Value, 0);
		}

		// Token: 0x06024F35 RID: 151349 RVA: 0x00512AB5 File Offset: 0x00510CB5
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x06024F36 RID: 151350 RVA: 0x00512AC0 File Offset: 0x00510CC0
		public static void AddScanOption(FlatBufferBuilder builder, Offset<IGuideLineCreatorScanOption> scanOptionOffset)
		{
			builder.AddOffset(3, scanOptionOffset.Value, 0);
		}

		// Token: 0x06024F37 RID: 151351 RVA: 0x00512AD0 File Offset: 0x00510CD0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06024F38 RID: 151352 RVA: 0x00512ADB File Offset: 0x00510CDB
		public static Offset<IGuideLineCreatorComponent> EndIGuideLineCreatorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGuideLineCreatorComponent>(builder.EndTable());
		}

		// Token: 0x06024F39 RID: 151353 RVA: 0x00512AE8 File Offset: 0x00510CE8
		public IGuideLineCreatorComponentT UnPack()
		{
			IGuideLineCreatorComponentT guideLineCreatorComponentT = new IGuideLineCreatorComponentT();
			this.UnPackTo(guideLineCreatorComponentT);
			return guideLineCreatorComponentT;
		}

		// Token: 0x06024F3A RID: 151354 RVA: 0x00512B04 File Offset: 0x00510D04
		public void UnPackTo(IGuideLineCreatorComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ColorChangeOption = ((this.ColorChangeOption != null) ? this.ColorChangeOption.Value.UnPack() : null);
			_o.SplineEntityId = this.SplineEntityId;
			_o.ScanOption = ((this.ScanOption != null) ? this.ScanOption.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06024F3B RID: 151355 RVA: 0x00512B94 File Offset: 0x00510D94
		public static Offset<IGuideLineCreatorComponent> Pack(FlatBufferBuilder builder, IGuideLineCreatorComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGuideLineCreatorComponent>);
			}
			Offset<IColorChangeStrategyOfRGB> colorChangeOptionOffset = (_o.ColorChangeOption == null) ? default(Offset<IColorChangeStrategyOfRGB>) : IColorChangeStrategyOfRGB.Pack(builder, _o.ColorChangeOption);
			Offset<IGuideLineCreatorScanOption> scanOptionOffset = (_o.ScanOption == null) ? default(Offset<IGuideLineCreatorScanOption>) : IGuideLineCreatorScanOption.Pack(builder, _o.ScanOption);
			return IGuideLineCreatorComponent.CreateIGuideLineCreatorComponent(builder, _o.Disabled, colorChangeOptionOffset, _o.SplineEntityId, scanOptionOffset, _o.NullMask);
		}

		// Token: 0x0400F160 RID: 61792
		private Table __p;
	}
}
