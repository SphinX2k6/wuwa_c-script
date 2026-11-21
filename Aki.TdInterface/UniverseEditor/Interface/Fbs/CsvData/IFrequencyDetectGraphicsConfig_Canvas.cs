using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D85 RID: 19845
	public struct IFrequencyDetectGraphicsConfig_Canvas : IFlatbufferObject
	{
		// Token: 0x17008DFC RID: 36348
		// (get) Token: 0x0601EC41 RID: 126017 RVA: 0x0044D59B File Offset: 0x0044B79B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601EC42 RID: 126018 RVA: 0x0044D5A8 File Offset: 0x0044B7A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601EC43 RID: 126019 RVA: 0x0044D5B0 File Offset: 0x0044B7B0
		public static IFrequencyDetectGraphicsConfig_Canvas GetRootAsIFrequencyDetectGraphicsConfig_Canvas(ByteBuffer _bb)
		{
			return IFrequencyDetectGraphicsConfig_Canvas.GetRootAsIFrequencyDetectGraphicsConfig_Canvas(_bb, default(IFrequencyDetectGraphicsConfig_Canvas));
		}

		// Token: 0x0601EC44 RID: 126020 RVA: 0x0044D5CC File Offset: 0x0044B7CC
		public static IFrequencyDetectGraphicsConfig_Canvas GetRootAsIFrequencyDetectGraphicsConfig_Canvas(ByteBuffer _bb, IFrequencyDetectGraphicsConfig_Canvas obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601EC45 RID: 126021 RVA: 0x0044D5E9 File Offset: 0x0044B7E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601EC46 RID: 126022 RVA: 0x0044D5F8 File Offset: 0x0044B7F8
		public IFrequencyDetectGraphicsConfig_Canvas __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008DFD RID: 36349
		// (get) Token: 0x0601EC47 RID: 126023 RVA: 0x0044D608 File Offset: 0x0044B808
		public float Width
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008DFE RID: 36350
		// (get) Token: 0x0601EC48 RID: 126024 RVA: 0x0044D648 File Offset: 0x0044B848
		public float Height
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601EC49 RID: 126025 RVA: 0x0044D688 File Offset: 0x0044B888
		public static Offset<IFrequencyDetectGraphicsConfig_Canvas> CreateIFrequencyDetectGraphicsConfig_Canvas(FlatBufferBuilder builder, float Width = 0f, float Height = 0f)
		{
			builder.StartTable(2);
			IFrequencyDetectGraphicsConfig_Canvas.AddHeight(builder, Height);
			IFrequencyDetectGraphicsConfig_Canvas.AddWidth(builder, Width);
			return IFrequencyDetectGraphicsConfig_Canvas.EndIFrequencyDetectGraphicsConfig_Canvas(builder);
		}

		// Token: 0x0601EC4A RID: 126026 RVA: 0x0044D6A5 File Offset: 0x0044B8A5
		public static void StartIFrequencyDetectGraphicsConfig_Canvas(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601EC4B RID: 126027 RVA: 0x0044D6AE File Offset: 0x0044B8AE
		public static void AddWidth(FlatBufferBuilder builder, float width)
		{
			builder.AddFloat(0, width, 0.0);
		}

		// Token: 0x0601EC4C RID: 126028 RVA: 0x0044D6C1 File Offset: 0x0044B8C1
		public static void AddHeight(FlatBufferBuilder builder, float height)
		{
			builder.AddFloat(1, height, 0.0);
		}

		// Token: 0x0601EC4D RID: 126029 RVA: 0x0044D6D4 File Offset: 0x0044B8D4
		public static Offset<IFrequencyDetectGraphicsConfig_Canvas> EndIFrequencyDetectGraphicsConfig_Canvas(FlatBufferBuilder builder)
		{
			return new Offset<IFrequencyDetectGraphicsConfig_Canvas>(builder.EndTable());
		}

		// Token: 0x0601EC4E RID: 126030 RVA: 0x0044D6E4 File Offset: 0x0044B8E4
		public IFrequencyDetectGraphicsConfig_CanvasT UnPack()
		{
			IFrequencyDetectGraphicsConfig_CanvasT frequencyDetectGraphicsConfig_CanvasT = new IFrequencyDetectGraphicsConfig_CanvasT();
			this.UnPackTo(frequencyDetectGraphicsConfig_CanvasT);
			return frequencyDetectGraphicsConfig_CanvasT;
		}

		// Token: 0x0601EC4F RID: 126031 RVA: 0x0044D6FF File Offset: 0x0044B8FF
		public void UnPackTo(IFrequencyDetectGraphicsConfig_CanvasT _o)
		{
			_o.Width = this.Width;
			_o.Height = this.Height;
		}

		// Token: 0x0601EC50 RID: 126032 RVA: 0x0044D71C File Offset: 0x0044B91C
		public static Offset<IFrequencyDetectGraphicsConfig_Canvas> Pack(FlatBufferBuilder builder, IFrequencyDetectGraphicsConfig_CanvasT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFrequencyDetectGraphicsConfig_Canvas>);
			}
			return IFrequencyDetectGraphicsConfig_Canvas.CreateIFrequencyDetectGraphicsConfig_Canvas(builder, _o.Width, _o.Height);
		}

		// Token: 0x0400D9D9 RID: 55769
		private Table __p;
	}
}
