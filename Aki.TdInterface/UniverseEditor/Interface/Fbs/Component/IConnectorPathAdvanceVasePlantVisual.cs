using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005571 RID: 21873
	public struct IConnectorPathAdvanceVasePlantVisual : IFlatbufferObject
	{
		// Token: 0x17009C76 RID: 40054
		// (get) Token: 0x06022BD7 RID: 142295 RVA: 0x004C8E6C File Offset: 0x004C706C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022BD8 RID: 142296 RVA: 0x004C8E79 File Offset: 0x004C7079
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022BD9 RID: 142297 RVA: 0x004C8E80 File Offset: 0x004C7080
		public static IConnectorPathAdvanceVasePlantVisual GetRootAsIConnectorPathAdvanceVasePlantVisual(ByteBuffer _bb)
		{
			return IConnectorPathAdvanceVasePlantVisual.GetRootAsIConnectorPathAdvanceVasePlantVisual(_bb, default(IConnectorPathAdvanceVasePlantVisual));
		}

		// Token: 0x06022BDA RID: 142298 RVA: 0x004C8E9C File Offset: 0x004C709C
		public static IConnectorPathAdvanceVasePlantVisual GetRootAsIConnectorPathAdvanceVasePlantVisual(ByteBuffer _bb, IConnectorPathAdvanceVasePlantVisual obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022BDB RID: 142299 RVA: 0x004C8EB9 File Offset: 0x004C70B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022BDC RID: 142300 RVA: 0x004C8EC8 File Offset: 0x004C70C8
		public IConnectorPathAdvanceVasePlantVisual __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C77 RID: 40055
		// (get) Token: 0x06022BDD RID: 142301 RVA: 0x004C8ED8 File Offset: 0x004C70D8
		public EConnectorPathAdvanceVisualType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EConnectorPathAdvanceVisualType.VasePlant;
				}
				return (EConnectorPathAdvanceVisualType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009C78 RID: 40056
		// (get) Token: 0x06022BDE RID: 142302 RVA: 0x004C8F14 File Offset: 0x004C7114
		public float ScatterWidth
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

		// Token: 0x17009C79 RID: 40057
		// (get) Token: 0x06022BDF RID: 142303 RVA: 0x004C8F54 File Offset: 0x004C7154
		public float ScatterDensity
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009C7A RID: 40058
		// (get) Token: 0x06022BE0 RID: 142304 RVA: 0x004C8F94 File Offset: 0x004C7194
		public float Scale
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009C7B RID: 40059
		// (get) Token: 0x06022BE1 RID: 142305 RVA: 0x004C8FD8 File Offset: 0x004C71D8
		public bool SnapToSurface
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06022BE2 RID: 142306 RVA: 0x004C9018 File Offset: 0x004C7218
		public string PathRtList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009C7C RID: 40060
		// (get) Token: 0x06022BE3 RID: 142307 RVA: 0x004C9054 File Offset: 0x004C7254
		public int PathRtListLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17009C7D RID: 40061
		// (get) Token: 0x06022BE4 RID: 142308 RVA: 0x004C9080 File Offset: 0x004C7280
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022BE5 RID: 142309 RVA: 0x004C90C0 File Offset: 0x004C72C0
		public static Offset<IConnectorPathAdvanceVasePlantVisual> CreateIConnectorPathAdvanceVasePlantVisual(FlatBufferBuilder builder, EConnectorPathAdvanceVisualType Type = EConnectorPathAdvanceVisualType.VasePlant, float ScatterWidth = 0f, float ScatterDensity = 0f, float Scale = 0f, bool SnapToSurface = false, VectorOffset PathRtListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(7);
			IConnectorPathAdvanceVasePlantVisual.AddPathRtList(builder, PathRtListOffset);
			IConnectorPathAdvanceVasePlantVisual.AddScale(builder, Scale);
			IConnectorPathAdvanceVasePlantVisual.AddScatterDensity(builder, ScatterDensity);
			IConnectorPathAdvanceVasePlantVisual.AddScatterWidth(builder, ScatterWidth);
			IConnectorPathAdvanceVasePlantVisual.AddNullMask(builder, NullMask);
			IConnectorPathAdvanceVasePlantVisual.AddSnapToSurface(builder, SnapToSurface);
			IConnectorPathAdvanceVasePlantVisual.AddType(builder, Type);
			return IConnectorPathAdvanceVasePlantVisual.EndIConnectorPathAdvanceVasePlantVisual(builder);
		}

		// Token: 0x06022BE6 RID: 142310 RVA: 0x004C910F File Offset: 0x004C730F
		public static void StartIConnectorPathAdvanceVasePlantVisual(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06022BE7 RID: 142311 RVA: 0x004C9118 File Offset: 0x004C7318
		public static void AddType(FlatBufferBuilder builder, EConnectorPathAdvanceVisualType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022BE8 RID: 142312 RVA: 0x004C9123 File Offset: 0x004C7323
		public static void AddScatterWidth(FlatBufferBuilder builder, float scatterWidth)
		{
			builder.AddFloat(1, scatterWidth, 0.0);
		}

		// Token: 0x06022BE9 RID: 142313 RVA: 0x004C9136 File Offset: 0x004C7336
		public static void AddScatterDensity(FlatBufferBuilder builder, float scatterDensity)
		{
			builder.AddFloat(2, scatterDensity, 0.0);
		}

		// Token: 0x06022BEA RID: 142314 RVA: 0x004C9149 File Offset: 0x004C7349
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(3, scale, 0.0);
		}

		// Token: 0x06022BEB RID: 142315 RVA: 0x004C915C File Offset: 0x004C735C
		public static void AddSnapToSurface(FlatBufferBuilder builder, bool snapToSurface)
		{
			builder.AddBool(4, snapToSurface, false);
		}

		// Token: 0x06022BEC RID: 142316 RVA: 0x004C9167 File Offset: 0x004C7367
		public static void AddPathRtList(FlatBufferBuilder builder, VectorOffset pathRtListOffset)
		{
			builder.AddOffset(5, pathRtListOffset.Value, 0);
		}

		// Token: 0x06022BED RID: 142317 RVA: 0x004C9178 File Offset: 0x004C7378
		public static VectorOffset CreatePathRtListVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06022BEE RID: 142318 RVA: 0x004C91B8 File Offset: 0x004C73B8
		public static VectorOffset CreatePathRtListVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06022BEF RID: 142319 RVA: 0x004C91D2 File Offset: 0x004C73D2
		public static VectorOffset CreatePathRtListVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06022BF0 RID: 142320 RVA: 0x004C91F0 File Offset: 0x004C73F0
		public static VectorOffset CreatePathRtListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06022BF1 RID: 142321 RVA: 0x004C9209 File Offset: 0x004C7409
		public static void StartPathRtListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06022BF2 RID: 142322 RVA: 0x004C9214 File Offset: 0x004C7414
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06022BF3 RID: 142323 RVA: 0x004C921F File Offset: 0x004C741F
		public static Offset<IConnectorPathAdvanceVasePlantVisual> EndIConnectorPathAdvanceVasePlantVisual(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorPathAdvanceVasePlantVisual>(builder.EndTable());
		}

		// Token: 0x06022BF4 RID: 142324 RVA: 0x004C922C File Offset: 0x004C742C
		public IConnectorPathAdvanceVasePlantVisualT UnPack()
		{
			IConnectorPathAdvanceVasePlantVisualT connectorPathAdvanceVasePlantVisualT = new IConnectorPathAdvanceVasePlantVisualT();
			this.UnPackTo(connectorPathAdvanceVasePlantVisualT);
			return connectorPathAdvanceVasePlantVisualT;
		}

		// Token: 0x06022BF5 RID: 142325 RVA: 0x004C9248 File Offset: 0x004C7448
		public void UnPackTo(IConnectorPathAdvanceVasePlantVisualT _o)
		{
			_o.Type = this.Type;
			_o.ScatterWidth = this.ScatterWidth;
			_o.ScatterDensity = this.ScatterDensity;
			_o.Scale = this.Scale;
			_o.SnapToSurface = this.SnapToSurface;
			_o.PathRtList = new List<string>();
			for (int i = 0; i < this.PathRtListLength; i++)
			{
				_o.PathRtList.Add(this.PathRtList(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022BF6 RID: 142326 RVA: 0x004C92CC File Offset: 0x004C74CC
		public static Offset<IConnectorPathAdvanceVasePlantVisual> Pack(FlatBufferBuilder builder, IConnectorPathAdvanceVasePlantVisualT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConnectorPathAdvanceVasePlantVisual>);
			}
			VectorOffset pathRtListOffset = default(VectorOffset);
			if (_o.PathRtList != null)
			{
				StringOffset[] array = new StringOffset[_o.PathRtList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.PathRtList[i]);
				}
				pathRtListOffset = IConnectorPathAdvanceVasePlantVisual.CreatePathRtListVector(builder, array);
			}
			return IConnectorPathAdvanceVasePlantVisual.CreateIConnectorPathAdvanceVasePlantVisual(builder, _o.Type, _o.ScatterWidth, _o.ScatterDensity, _o.Scale, _o.SnapToSurface, pathRtListOffset, _o.NullMask);
		}

		// Token: 0x0400EBD4 RID: 60372
		private Table __p;
	}
}
