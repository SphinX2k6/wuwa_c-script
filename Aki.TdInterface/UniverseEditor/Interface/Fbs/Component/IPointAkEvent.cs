using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D52 RID: 23890
	public struct IPointAkEvent : IFlatbufferObject
	{
		// Token: 0x1700AFDB RID: 45019
		// (get) Token: 0x06027C39 RID: 162873 RVA: 0x00570D41 File Offset: 0x0056EF41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027C3A RID: 162874 RVA: 0x00570D4E File Offset: 0x0056EF4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027C3B RID: 162875 RVA: 0x00570D58 File Offset: 0x0056EF58
		public static IPointAkEvent GetRootAsIPointAkEvent(ByteBuffer _bb)
		{
			return IPointAkEvent.GetRootAsIPointAkEvent(_bb, default(IPointAkEvent));
		}

		// Token: 0x06027C3C RID: 162876 RVA: 0x00570D74 File Offset: 0x0056EF74
		public static IPointAkEvent GetRootAsIPointAkEvent(ByteBuffer _bb, IPointAkEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027C3D RID: 162877 RVA: 0x00570D91 File Offset: 0x0056EF91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027C3E RID: 162878 RVA: 0x00570DA0 File Offset: 0x0056EFA0
		public IPointAkEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AFDC RID: 45020
		// (get) Token: 0x06027C3F RID: 162879 RVA: 0x00570DB0 File Offset: 0x0056EFB0
		public EAkEventType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAkEventType.Point;
				}
				return (EAkEventType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027C40 RID: 162880 RVA: 0x00570DEC File Offset: 0x0056EFEC
		public int PointIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AFDD RID: 45021
		// (get) Token: 0x06027C41 RID: 162881 RVA: 0x00570E2C File Offset: 0x0056F02C
		public int PointIdsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06027C42 RID: 162882 RVA: 0x00570E57 File Offset: 0x0056F057
		public Span<int> GetPointIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06027C43 RID: 162883 RVA: 0x00570E66 File Offset: 0x0056F066
		public int[] GetPointIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700AFDE RID: 45022
		// (get) Token: 0x06027C44 RID: 162884 RVA: 0x00570E74 File Offset: 0x0056F074
		public bool UseListenerCone
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AFDF RID: 45023
		// (get) Token: 0x06027C45 RID: 162885 RVA: 0x00570EB4 File Offset: 0x0056F0B4
		public bool EnableOcclusion
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AFE0 RID: 45024
		// (get) Token: 0x06027C46 RID: 162886 RVA: 0x00570EF4 File Offset: 0x0056F0F4
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

		// Token: 0x06027C47 RID: 162887 RVA: 0x00570F31 File Offset: 0x0056F131
		public static Offset<IPointAkEvent> CreateIPointAkEvent(FlatBufferBuilder builder, EAkEventType Type = EAkEventType.Point, VectorOffset PointIdsOffset = default(VectorOffset), bool UseListenerCone = false, bool EnableOcclusion = false, byte NullMask = 0)
		{
			builder.StartTable(5);
			IPointAkEvent.AddPointIds(builder, PointIdsOffset);
			IPointAkEvent.AddNullMask(builder, NullMask);
			IPointAkEvent.AddEnableOcclusion(builder, EnableOcclusion);
			IPointAkEvent.AddUseListenerCone(builder, UseListenerCone);
			IPointAkEvent.AddType(builder, Type);
			return IPointAkEvent.EndIPointAkEvent(builder);
		}

		// Token: 0x06027C48 RID: 162888 RVA: 0x00570F65 File Offset: 0x0056F165
		public static void StartIPointAkEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027C49 RID: 162889 RVA: 0x00570F6E File Offset: 0x0056F16E
		public static void AddType(FlatBufferBuilder builder, EAkEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027C4A RID: 162890 RVA: 0x00570F79 File Offset: 0x0056F179
		public static void AddPointIds(FlatBufferBuilder builder, VectorOffset pointIdsOffset)
		{
			builder.AddOffset(1, pointIdsOffset.Value, 0);
		}

		// Token: 0x06027C4B RID: 162891 RVA: 0x00570F8C File Offset: 0x0056F18C
		public static VectorOffset CreatePointIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027C4C RID: 162892 RVA: 0x00570FC3 File Offset: 0x0056F1C3
		public static VectorOffset CreatePointIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027C4D RID: 162893 RVA: 0x00570FDD File Offset: 0x0056F1DD
		public static VectorOffset CreatePointIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027C4E RID: 162894 RVA: 0x00570FFB File Offset: 0x0056F1FB
		public static VectorOffset CreatePointIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027C4F RID: 162895 RVA: 0x00571014 File Offset: 0x0056F214
		public static void StartPointIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027C50 RID: 162896 RVA: 0x0057101F File Offset: 0x0056F21F
		public static void AddUseListenerCone(FlatBufferBuilder builder, bool useListenerCone)
		{
			builder.AddBool(2, useListenerCone, false);
		}

		// Token: 0x06027C51 RID: 162897 RVA: 0x0057102A File Offset: 0x0056F22A
		public static void AddEnableOcclusion(FlatBufferBuilder builder, bool enableOcclusion)
		{
			builder.AddBool(3, enableOcclusion, false);
		}

		// Token: 0x06027C52 RID: 162898 RVA: 0x00571035 File Offset: 0x0056F235
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06027C53 RID: 162899 RVA: 0x00571040 File Offset: 0x0056F240
		public static Offset<IPointAkEvent> EndIPointAkEvent(FlatBufferBuilder builder)
		{
			return new Offset<IPointAkEvent>(builder.EndTable());
		}

		// Token: 0x06027C54 RID: 162900 RVA: 0x00571050 File Offset: 0x0056F250
		public IPointAkEventT UnPack()
		{
			IPointAkEventT pointAkEventT = new IPointAkEventT();
			this.UnPackTo(pointAkEventT);
			return pointAkEventT;
		}

		// Token: 0x06027C55 RID: 162901 RVA: 0x0057106C File Offset: 0x0056F26C
		public void UnPackTo(IPointAkEventT _o)
		{
			_o.Type = this.Type;
			_o.PointIds = new List<int>();
			for (int i = 0; i < this.PointIdsLength; i++)
			{
				_o.PointIds.Add(this.PointIds(i));
			}
			_o.UseListenerCone = this.UseListenerCone;
			_o.EnableOcclusion = this.EnableOcclusion;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027C56 RID: 162902 RVA: 0x005710D8 File Offset: 0x0056F2D8
		public static Offset<IPointAkEvent> Pack(FlatBufferBuilder builder, IPointAkEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPointAkEvent>);
			}
			VectorOffset pointIdsOffset = default(VectorOffset);
			if (_o.PointIds != null)
			{
				int[] data = _o.PointIds.ToArray();
				pointIdsOffset = IPointAkEvent.CreatePointIdsVector(builder, data);
			}
			return IPointAkEvent.CreateIPointAkEvent(builder, _o.Type, pointIdsOffset, _o.UseListenerCone, _o.EnableOcclusion, _o.NullMask);
		}

		// Token: 0x0400F8D2 RID: 63698
		private Table __p;
	}
}
