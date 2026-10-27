using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005012 RID: 20498
	public struct IConnectorPathAdvanceVasePlantVisual : IFlatbufferObject
	{
		// Token: 0x17009495 RID: 38037
		// (get) Token: 0x06020CB7 RID: 134327 RVA: 0x0048F41C File Offset: 0x0048D61C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020CB8 RID: 134328 RVA: 0x0048F429 File Offset: 0x0048D629
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020CB9 RID: 134329 RVA: 0x0048F430 File Offset: 0x0048D630
		public static IConnectorPathAdvanceVasePlantVisual GetRootAsIConnectorPathAdvanceVasePlantVisual(ByteBuffer _bb)
		{
			return IConnectorPathAdvanceVasePlantVisual.GetRootAsIConnectorPathAdvanceVasePlantVisual(_bb, default(IConnectorPathAdvanceVasePlantVisual));
		}

		// Token: 0x06020CBA RID: 134330 RVA: 0x0048F44C File Offset: 0x0048D64C
		public static IConnectorPathAdvanceVasePlantVisual GetRootAsIConnectorPathAdvanceVasePlantVisual(ByteBuffer _bb, IConnectorPathAdvanceVasePlantVisual obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020CBB RID: 134331 RVA: 0x0048F469 File Offset: 0x0048D669
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020CBC RID: 134332 RVA: 0x0048F478 File Offset: 0x0048D678
		public IConnectorPathAdvanceVasePlantVisual __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009496 RID: 38038
		// (get) Token: 0x06020CBD RID: 134333 RVA: 0x0048F488 File Offset: 0x0048D688
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

		// Token: 0x17009497 RID: 38039
		// (get) Token: 0x06020CBE RID: 134334 RVA: 0x0048F4C4 File Offset: 0x0048D6C4
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

		// Token: 0x17009498 RID: 38040
		// (get) Token: 0x06020CBF RID: 134335 RVA: 0x0048F504 File Offset: 0x0048D704
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

		// Token: 0x17009499 RID: 38041
		// (get) Token: 0x06020CC0 RID: 134336 RVA: 0x0048F544 File Offset: 0x0048D744
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

		// Token: 0x1700949A RID: 38042
		// (get) Token: 0x06020CC1 RID: 134337 RVA: 0x0048F588 File Offset: 0x0048D788
		public bool SnapToSurface
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06020CC2 RID: 134338 RVA: 0x0048F5C8 File Offset: 0x0048D7C8
		public string PathRtList(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700949B RID: 38043
		// (get) Token: 0x06020CC3 RID: 134339 RVA: 0x0048F604 File Offset: 0x0048D804
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

		// Token: 0x1700949C RID: 38044
		// (get) Token: 0x06020CC4 RID: 134340 RVA: 0x0048F630 File Offset: 0x0048D830
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

		// Token: 0x06020CC5 RID: 134341 RVA: 0x0048F670 File Offset: 0x0048D870
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

		// Token: 0x06020CC6 RID: 134342 RVA: 0x0048F6BF File Offset: 0x0048D8BF
		public static void StartIConnectorPathAdvanceVasePlantVisual(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06020CC7 RID: 134343 RVA: 0x0048F6C8 File Offset: 0x0048D8C8
		public static void AddType(FlatBufferBuilder builder, EConnectorPathAdvanceVisualType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06020CC8 RID: 134344 RVA: 0x0048F6D3 File Offset: 0x0048D8D3
		public static void AddScatterWidth(FlatBufferBuilder builder, float scatterWidth)
		{
			builder.AddFloat(1, scatterWidth, 0.0);
		}

		// Token: 0x06020CC9 RID: 134345 RVA: 0x0048F6E6 File Offset: 0x0048D8E6
		public static void AddScatterDensity(FlatBufferBuilder builder, float scatterDensity)
		{
			builder.AddFloat(2, scatterDensity, 0.0);
		}

		// Token: 0x06020CCA RID: 134346 RVA: 0x0048F6F9 File Offset: 0x0048D8F9
		public static void AddScale(FlatBufferBuilder builder, float scale)
		{
			builder.AddFloat(3, scale, 0.0);
		}

		// Token: 0x06020CCB RID: 134347 RVA: 0x0048F70C File Offset: 0x0048D90C
		public static void AddSnapToSurface(FlatBufferBuilder builder, bool snapToSurface)
		{
			builder.AddBool(4, snapToSurface, false);
		}

		// Token: 0x06020CCC RID: 134348 RVA: 0x0048F717 File Offset: 0x0048D917
		public static void AddPathRtList(FlatBufferBuilder builder, VectorOffset pathRtListOffset)
		{
			builder.AddOffset(5, pathRtListOffset.Value, 0);
		}

		// Token: 0x06020CCD RID: 134349 RVA: 0x0048F728 File Offset: 0x0048D928
		public static VectorOffset CreatePathRtListVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06020CCE RID: 134350 RVA: 0x0048F768 File Offset: 0x0048D968
		public static VectorOffset CreatePathRtListVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06020CCF RID: 134351 RVA: 0x0048F782 File Offset: 0x0048D982
		public static VectorOffset CreatePathRtListVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06020CD0 RID: 134352 RVA: 0x0048F7A0 File Offset: 0x0048D9A0
		public static VectorOffset CreatePathRtListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06020CD1 RID: 134353 RVA: 0x0048F7B9 File Offset: 0x0048D9B9
		public static void StartPathRtListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06020CD2 RID: 134354 RVA: 0x0048F7C4 File Offset: 0x0048D9C4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06020CD3 RID: 134355 RVA: 0x0048F7CF File Offset: 0x0048D9CF
		public static Offset<IConnectorPathAdvanceVasePlantVisual> EndIConnectorPathAdvanceVasePlantVisual(FlatBufferBuilder builder)
		{
			return new Offset<IConnectorPathAdvanceVasePlantVisual>(builder.EndTable());
		}

		// Token: 0x06020CD4 RID: 134356 RVA: 0x0048F7DC File Offset: 0x0048D9DC
		public IConnectorPathAdvanceVasePlantVisualT UnPack()
		{
			IConnectorPathAdvanceVasePlantVisualT connectorPathAdvanceVasePlantVisualT = new IConnectorPathAdvanceVasePlantVisualT();
			this.UnPackTo(connectorPathAdvanceVasePlantVisualT);
			return connectorPathAdvanceVasePlantVisualT;
		}

		// Token: 0x06020CD5 RID: 134357 RVA: 0x0048F7F8 File Offset: 0x0048D9F8
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

		// Token: 0x06020CD6 RID: 134358 RVA: 0x0048F87C File Offset: 0x0048DA7C
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

		// Token: 0x0400DFDE RID: 57310
		private Table __p;
	}
}
