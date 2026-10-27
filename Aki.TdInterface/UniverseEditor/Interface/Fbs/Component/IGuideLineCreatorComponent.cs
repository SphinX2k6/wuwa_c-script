using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005359 RID: 21337
	public struct IGuideLineCreatorComponent : IFlatbufferObject
	{
		// Token: 0x17009CC1 RID: 40129
		// (get) Token: 0x06022E72 RID: 142962 RVA: 0x004D59A4 File Offset: 0x004D3BA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022E73 RID: 142963 RVA: 0x004D59B1 File Offset: 0x004D3BB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022E74 RID: 142964 RVA: 0x004D59B8 File Offset: 0x004D3BB8
		public static IGuideLineCreatorComponent GetRootAsIGuideLineCreatorComponent(ByteBuffer _bb)
		{
			return IGuideLineCreatorComponent.GetRootAsIGuideLineCreatorComponent(_bb, default(IGuideLineCreatorComponent));
		}

		// Token: 0x06022E75 RID: 142965 RVA: 0x004D59D4 File Offset: 0x004D3BD4
		public static IGuideLineCreatorComponent GetRootAsIGuideLineCreatorComponent(ByteBuffer _bb, IGuideLineCreatorComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022E76 RID: 142966 RVA: 0x004D59F1 File Offset: 0x004D3BF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022E77 RID: 142967 RVA: 0x004D5A00 File Offset: 0x004D3C00
		public IGuideLineCreatorComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009CC2 RID: 40130
		// (get) Token: 0x06022E78 RID: 142968 RVA: 0x004D5A10 File Offset: 0x004D3C10
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009CC3 RID: 40131
		// (get) Token: 0x06022E79 RID: 142969 RVA: 0x004D5A50 File Offset: 0x004D3C50
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

		// Token: 0x17009CC4 RID: 40132
		// (get) Token: 0x06022E7A RID: 142970 RVA: 0x004D5AB0 File Offset: 0x004D3CB0
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

		// Token: 0x17009CC5 RID: 40133
		// (get) Token: 0x06022E7B RID: 142971 RVA: 0x004D5AEC File Offset: 0x004D3CEC
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

		// Token: 0x17009CC6 RID: 40134
		// (get) Token: 0x06022E7C RID: 142972 RVA: 0x004D5B4C File Offset: 0x004D3D4C
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

		// Token: 0x06022E7D RID: 142973 RVA: 0x004D5B89 File Offset: 0x004D3D89
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

		// Token: 0x06022E7E RID: 142974 RVA: 0x004D5BBD File Offset: 0x004D3DBD
		public static void StartIGuideLineCreatorComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06022E7F RID: 142975 RVA: 0x004D5BC6 File Offset: 0x004D3DC6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022E80 RID: 142976 RVA: 0x004D5BD1 File Offset: 0x004D3DD1
		public static void AddColorChangeOption(FlatBufferBuilder builder, Offset<IColorChangeStrategyOfRGB> colorChangeOptionOffset)
		{
			builder.AddOffset(1, colorChangeOptionOffset.Value, 0);
		}

		// Token: 0x06022E81 RID: 142977 RVA: 0x004D5BE1 File Offset: 0x004D3DE1
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x06022E82 RID: 142978 RVA: 0x004D5BEC File Offset: 0x004D3DEC
		public static void AddScanOption(FlatBufferBuilder builder, Offset<IGuideLineCreatorScanOption> scanOptionOffset)
		{
			builder.AddOffset(3, scanOptionOffset.Value, 0);
		}

		// Token: 0x06022E83 RID: 142979 RVA: 0x004D5BFC File Offset: 0x004D3DFC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06022E84 RID: 142980 RVA: 0x004D5C07 File Offset: 0x004D3E07
		public static Offset<IGuideLineCreatorComponent> EndIGuideLineCreatorComponent(FlatBufferBuilder builder)
		{
			return new Offset<IGuideLineCreatorComponent>(builder.EndTable());
		}

		// Token: 0x06022E85 RID: 142981 RVA: 0x004D5C14 File Offset: 0x004D3E14
		public IGuideLineCreatorComponentT UnPack()
		{
			IGuideLineCreatorComponentT guideLineCreatorComponentT = new IGuideLineCreatorComponentT();
			this.UnPackTo(guideLineCreatorComponentT);
			return guideLineCreatorComponentT;
		}

		// Token: 0x06022E86 RID: 142982 RVA: 0x004D5C30 File Offset: 0x004D3E30
		public void UnPackTo(IGuideLineCreatorComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ColorChangeOption = ((this.ColorChangeOption != null) ? this.ColorChangeOption.Value.UnPack() : null);
			_o.SplineEntityId = this.SplineEntityId;
			_o.ScanOption = ((this.ScanOption != null) ? this.ScanOption.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022E87 RID: 142983 RVA: 0x004D5CC0 File Offset: 0x004D3EC0
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

		// Token: 0x0400E530 RID: 58672
		private Table __p;
	}
}
