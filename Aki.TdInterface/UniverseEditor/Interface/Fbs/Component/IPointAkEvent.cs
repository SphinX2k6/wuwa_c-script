using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200574B RID: 22347
	public struct IPointAkEvent : IFlatbufferObject
	{
		// Token: 0x1700A6B7 RID: 42679
		// (get) Token: 0x06025719 RID: 153369 RVA: 0x0052ABB5 File Offset: 0x00528DB5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602571A RID: 153370 RVA: 0x0052ABC2 File Offset: 0x00528DC2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602571B RID: 153371 RVA: 0x0052ABCC File Offset: 0x00528DCC
		public static IPointAkEvent GetRootAsIPointAkEvent(ByteBuffer _bb)
		{
			return IPointAkEvent.GetRootAsIPointAkEvent(_bb, default(IPointAkEvent));
		}

		// Token: 0x0602571C RID: 153372 RVA: 0x0052ABE8 File Offset: 0x00528DE8
		public static IPointAkEvent GetRootAsIPointAkEvent(ByteBuffer _bb, IPointAkEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602571D RID: 153373 RVA: 0x0052AC05 File Offset: 0x00528E05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602571E RID: 153374 RVA: 0x0052AC14 File Offset: 0x00528E14
		public IPointAkEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A6B8 RID: 42680
		// (get) Token: 0x0602571F RID: 153375 RVA: 0x0052AC24 File Offset: 0x00528E24
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

		// Token: 0x06025720 RID: 153376 RVA: 0x0052AC60 File Offset: 0x00528E60
		public int PointIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A6B9 RID: 42681
		// (get) Token: 0x06025721 RID: 153377 RVA: 0x0052ACA0 File Offset: 0x00528EA0
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

		// Token: 0x06025722 RID: 153378 RVA: 0x0052ACCB File Offset: 0x00528ECB
		public Span<int> GetPointIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06025723 RID: 153379 RVA: 0x0052ACDA File Offset: 0x00528EDA
		public int[] GetPointIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700A6BA RID: 42682
		// (get) Token: 0x06025724 RID: 153380 RVA: 0x0052ACE8 File Offset: 0x00528EE8
		public bool UseListenerCone
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A6BB RID: 42683
		// (get) Token: 0x06025725 RID: 153381 RVA: 0x0052AD28 File Offset: 0x00528F28
		public bool EnableOcclusion
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A6BC RID: 42684
		// (get) Token: 0x06025726 RID: 153382 RVA: 0x0052AD68 File Offset: 0x00528F68
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

		// Token: 0x06025727 RID: 153383 RVA: 0x0052ADA5 File Offset: 0x00528FA5
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

		// Token: 0x06025728 RID: 153384 RVA: 0x0052ADD9 File Offset: 0x00528FD9
		public static void StartIPointAkEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06025729 RID: 153385 RVA: 0x0052ADE2 File Offset: 0x00528FE2
		public static void AddType(FlatBufferBuilder builder, EAkEventType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602572A RID: 153386 RVA: 0x0052ADED File Offset: 0x00528FED
		public static void AddPointIds(FlatBufferBuilder builder, VectorOffset pointIdsOffset)
		{
			builder.AddOffset(1, pointIdsOffset.Value, 0);
		}

		// Token: 0x0602572B RID: 153387 RVA: 0x0052AE00 File Offset: 0x00529000
		public static VectorOffset CreatePointIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602572C RID: 153388 RVA: 0x0052AE37 File Offset: 0x00529037
		public static VectorOffset CreatePointIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602572D RID: 153389 RVA: 0x0052AE51 File Offset: 0x00529051
		public static VectorOffset CreatePointIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0602572E RID: 153390 RVA: 0x0052AE6F File Offset: 0x0052906F
		public static VectorOffset CreatePointIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602572F RID: 153391 RVA: 0x0052AE88 File Offset: 0x00529088
		public static void StartPointIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025730 RID: 153392 RVA: 0x0052AE93 File Offset: 0x00529093
		public static void AddUseListenerCone(FlatBufferBuilder builder, bool useListenerCone)
		{
			builder.AddBool(2, useListenerCone, false);
		}

		// Token: 0x06025731 RID: 153393 RVA: 0x0052AE9E File Offset: 0x0052909E
		public static void AddEnableOcclusion(FlatBufferBuilder builder, bool enableOcclusion)
		{
			builder.AddBool(3, enableOcclusion, false);
		}

		// Token: 0x06025732 RID: 153394 RVA: 0x0052AEA9 File Offset: 0x005290A9
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06025733 RID: 153395 RVA: 0x0052AEB4 File Offset: 0x005290B4
		public static Offset<IPointAkEvent> EndIPointAkEvent(FlatBufferBuilder builder)
		{
			return new Offset<IPointAkEvent>(builder.EndTable());
		}

		// Token: 0x06025734 RID: 153396 RVA: 0x0052AEC4 File Offset: 0x005290C4
		public IPointAkEventT UnPack()
		{
			IPointAkEventT pointAkEventT = new IPointAkEventT();
			this.UnPackTo(pointAkEventT);
			return pointAkEventT;
		}

		// Token: 0x06025735 RID: 153397 RVA: 0x0052AEE0 File Offset: 0x005290E0
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

		// Token: 0x06025736 RID: 153398 RVA: 0x0052AF4C File Offset: 0x0052914C
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

		// Token: 0x0400EBE7 RID: 60391
		private Table __p;
	}
}
