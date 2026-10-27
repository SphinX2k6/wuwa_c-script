using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005826 RID: 22566
	public struct IRefreshGroup : IFlatbufferObject
	{
		// Token: 0x1700A887 RID: 43143
		// (get) Token: 0x06025F0E RID: 155406 RVA: 0x0053B264 File Offset: 0x00539464
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025F0F RID: 155407 RVA: 0x0053B271 File Offset: 0x00539471
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025F10 RID: 155408 RVA: 0x0053B278 File Offset: 0x00539478
		public static IRefreshGroup GetRootAsIRefreshGroup(ByteBuffer _bb)
		{
			return IRefreshGroup.GetRootAsIRefreshGroup(_bb, default(IRefreshGroup));
		}

		// Token: 0x06025F11 RID: 155409 RVA: 0x0053B294 File Offset: 0x00539494
		public static IRefreshGroup GetRootAsIRefreshGroup(ByteBuffer _bb, IRefreshGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025F12 RID: 155410 RVA: 0x0053B2B1 File Offset: 0x005394B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025F13 RID: 155411 RVA: 0x0053B2C0 File Offset: 0x005394C0
		public IRefreshGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A888 RID: 43144
		// (get) Token: 0x06025F14 RID: 155412 RVA: 0x0053B2D0 File Offset: 0x005394D0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A889 RID: 43145
		// (get) Token: 0x06025F15 RID: 155413 RVA: 0x0053B310 File Offset: 0x00539510
		public int RefreshInterval
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A88A RID: 43146
		// (get) Token: 0x06025F16 RID: 155414 RVA: 0x0053B34C File Offset: 0x0053954C
		public bool DelayRefresh
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06025F17 RID: 155415 RVA: 0x0053B38C File Offset: 0x0053958C
		public int EntityIdList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700A88B RID: 43147
		// (get) Token: 0x06025F18 RID: 155416 RVA: 0x0053B3CC File Offset: 0x005395CC
		public int EntityIdListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06025F19 RID: 155417 RVA: 0x0053B3F8 File Offset: 0x005395F8
		public Span<int> GetEntityIdListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x06025F1A RID: 155418 RVA: 0x0053B408 File Offset: 0x00539608
		public int[] GetEntityIdListArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700A88C RID: 43148
		// (get) Token: 0x06025F1B RID: 155419 RVA: 0x0053B418 File Offset: 0x00539618
		public ICylinder? IsUesCylinder
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ICylinder?(default(ICylinder).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A88D RID: 43149
		// (get) Token: 0x06025F1C RID: 155420 RVA: 0x0053B478 File Offset: 0x00539678
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025F1D RID: 155421 RVA: 0x0053B4B5 File Offset: 0x005396B5
		public static Offset<IRefreshGroup> CreateIRefreshGroup(FlatBufferBuilder builder, bool Disabled = false, int RefreshInterval = 0, bool DelayRefresh = false, VectorOffset EntityIdListOffset = default(VectorOffset), Offset<ICylinder> IsUesCylinderOffset = default(Offset<ICylinder>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IRefreshGroup.AddIsUesCylinder(builder, IsUesCylinderOffset);
			IRefreshGroup.AddEntityIdList(builder, EntityIdListOffset);
			IRefreshGroup.AddRefreshInterval(builder, RefreshInterval);
			IRefreshGroup.AddNullMask(builder, NullMask);
			IRefreshGroup.AddDelayRefresh(builder, DelayRefresh);
			IRefreshGroup.AddDisabled(builder, Disabled);
			return IRefreshGroup.EndIRefreshGroup(builder);
		}

		// Token: 0x06025F1E RID: 155422 RVA: 0x0053B4F1 File Offset: 0x005396F1
		public static void StartIRefreshGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06025F1F RID: 155423 RVA: 0x0053B4FA File Offset: 0x005396FA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025F20 RID: 155424 RVA: 0x0053B505 File Offset: 0x00539705
		public static void AddRefreshInterval(FlatBufferBuilder builder, int refreshInterval)
		{
			builder.AddInt(1, refreshInterval, 0);
		}

		// Token: 0x06025F21 RID: 155425 RVA: 0x0053B510 File Offset: 0x00539710
		public static void AddDelayRefresh(FlatBufferBuilder builder, bool delayRefresh)
		{
			builder.AddBool(2, delayRefresh, false);
		}

		// Token: 0x06025F22 RID: 155426 RVA: 0x0053B51B File Offset: 0x0053971B
		public static void AddEntityIdList(FlatBufferBuilder builder, VectorOffset entityIdListOffset)
		{
			builder.AddOffset(3, entityIdListOffset.Value, 0);
		}

		// Token: 0x06025F23 RID: 155427 RVA: 0x0053B52C File Offset: 0x0053972C
		public static VectorOffset CreateEntityIdListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06025F24 RID: 155428 RVA: 0x0053B563 File Offset: 0x00539763
		public static VectorOffset CreateEntityIdListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06025F25 RID: 155429 RVA: 0x0053B57D File Offset: 0x0053977D
		public static VectorOffset CreateEntityIdListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06025F26 RID: 155430 RVA: 0x0053B59B File Offset: 0x0053979B
		public static VectorOffset CreateEntityIdListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06025F27 RID: 155431 RVA: 0x0053B5B4 File Offset: 0x005397B4
		public static void StartEntityIdListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06025F28 RID: 155432 RVA: 0x0053B5BF File Offset: 0x005397BF
		public static void AddIsUesCylinder(FlatBufferBuilder builder, Offset<ICylinder> isUesCylinderOffset)
		{
			builder.AddOffset(4, isUesCylinderOffset.Value, 0);
		}

		// Token: 0x06025F29 RID: 155433 RVA: 0x0053B5CF File Offset: 0x005397CF
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06025F2A RID: 155434 RVA: 0x0053B5DA File Offset: 0x005397DA
		public static Offset<IRefreshGroup> EndIRefreshGroup(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshGroup>(builder.EndTable());
		}

		// Token: 0x06025F2B RID: 155435 RVA: 0x0053B5E8 File Offset: 0x005397E8
		public IRefreshGroupT UnPack()
		{
			IRefreshGroupT refreshGroupT = new IRefreshGroupT();
			this.UnPackTo(refreshGroupT);
			return refreshGroupT;
		}

		// Token: 0x06025F2C RID: 155436 RVA: 0x0053B604 File Offset: 0x00539804
		public void UnPackTo(IRefreshGroupT _o)
		{
			_o.Disabled = this.Disabled;
			_o.RefreshInterval = this.RefreshInterval;
			_o.DelayRefresh = this.DelayRefresh;
			_o.EntityIdList = new List<int>();
			for (int i = 0; i < this.EntityIdListLength; i++)
			{
				_o.EntityIdList.Add(this.EntityIdList(i));
			}
			_o.IsUesCylinder = ((this.IsUesCylinder != null) ? this.IsUesCylinder.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025F2D RID: 155437 RVA: 0x0053B6A0 File Offset: 0x005398A0
		public static Offset<IRefreshGroup> Pack(FlatBufferBuilder builder, IRefreshGroupT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRefreshGroup>);
			}
			VectorOffset entityIdListOffset = default(VectorOffset);
			if (_o.EntityIdList != null)
			{
				int[] data = _o.EntityIdList.ToArray();
				entityIdListOffset = IRefreshGroup.CreateEntityIdListVector(builder, data);
			}
			Offset<ICylinder> isUesCylinderOffset = (_o.IsUesCylinder == null) ? default(Offset<ICylinder>) : ICylinder.Pack(builder, _o.IsUesCylinder);
			return IRefreshGroup.CreateIRefreshGroup(builder, _o.Disabled, _o.RefreshInterval, _o.DelayRefresh, entityIdListOffset, isUesCylinderOffset, _o.NullMask);
		}

		// Token: 0x0400ED31 RID: 60721
		private Table __p;
	}
}
