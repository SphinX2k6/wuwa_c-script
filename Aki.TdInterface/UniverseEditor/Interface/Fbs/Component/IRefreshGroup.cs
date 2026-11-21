using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E2D RID: 24109
	public struct IRefreshGroup : IFlatbufferObject
	{
		// Token: 0x1700B1AB RID: 45483
		// (get) Token: 0x0602842E RID: 164910 RVA: 0x005813F0 File Offset: 0x0057F5F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602842F RID: 164911 RVA: 0x005813FD File Offset: 0x0057F5FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06028430 RID: 164912 RVA: 0x00581404 File Offset: 0x0057F604
		public static IRefreshGroup GetRootAsIRefreshGroup(ByteBuffer _bb)
		{
			return IRefreshGroup.GetRootAsIRefreshGroup(_bb, default(IRefreshGroup));
		}

		// Token: 0x06028431 RID: 164913 RVA: 0x00581420 File Offset: 0x0057F620
		public static IRefreshGroup GetRootAsIRefreshGroup(ByteBuffer _bb, IRefreshGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028432 RID: 164914 RVA: 0x0058143D File Offset: 0x0057F63D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028433 RID: 164915 RVA: 0x0058144C File Offset: 0x0057F64C
		public IRefreshGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B1AC RID: 45484
		// (get) Token: 0x06028434 RID: 164916 RVA: 0x0058145C File Offset: 0x0057F65C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B1AD RID: 45485
		// (get) Token: 0x06028435 RID: 164917 RVA: 0x0058149C File Offset: 0x0057F69C
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

		// Token: 0x1700B1AE RID: 45486
		// (get) Token: 0x06028436 RID: 164918 RVA: 0x005814D8 File Offset: 0x0057F6D8
		public bool DelayRefresh
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06028437 RID: 164919 RVA: 0x00581518 File Offset: 0x0057F718
		public int EntityIdList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B1AF RID: 45487
		// (get) Token: 0x06028438 RID: 164920 RVA: 0x00581558 File Offset: 0x0057F758
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

		// Token: 0x06028439 RID: 164921 RVA: 0x00581584 File Offset: 0x0057F784
		public Span<int> GetEntityIdListBytes()
		{
			return this.__p.__vector_as_span<int>(10, 4);
		}

		// Token: 0x0602843A RID: 164922 RVA: 0x00581594 File Offset: 0x0057F794
		public int[] GetEntityIdListArray()
		{
			return this.__p.__vector_as_array<int>(10);
		}

		// Token: 0x1700B1B0 RID: 45488
		// (get) Token: 0x0602843B RID: 164923 RVA: 0x005815A4 File Offset: 0x0057F7A4
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

		// Token: 0x1700B1B1 RID: 45489
		// (get) Token: 0x0602843C RID: 164924 RVA: 0x00581604 File Offset: 0x0057F804
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

		// Token: 0x0602843D RID: 164925 RVA: 0x00581641 File Offset: 0x0057F841
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

		// Token: 0x0602843E RID: 164926 RVA: 0x0058167D File Offset: 0x0057F87D
		public static void StartIRefreshGroup(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602843F RID: 164927 RVA: 0x00581686 File Offset: 0x0057F886
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028440 RID: 164928 RVA: 0x00581691 File Offset: 0x0057F891
		public static void AddRefreshInterval(FlatBufferBuilder builder, int refreshInterval)
		{
			builder.AddInt(1, refreshInterval, 0);
		}

		// Token: 0x06028441 RID: 164929 RVA: 0x0058169C File Offset: 0x0057F89C
		public static void AddDelayRefresh(FlatBufferBuilder builder, bool delayRefresh)
		{
			builder.AddBool(2, delayRefresh, false);
		}

		// Token: 0x06028442 RID: 164930 RVA: 0x005816A7 File Offset: 0x0057F8A7
		public static void AddEntityIdList(FlatBufferBuilder builder, VectorOffset entityIdListOffset)
		{
			builder.AddOffset(3, entityIdListOffset.Value, 0);
		}

		// Token: 0x06028443 RID: 164931 RVA: 0x005816B8 File Offset: 0x0057F8B8
		public static VectorOffset CreateEntityIdListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06028444 RID: 164932 RVA: 0x005816EF File Offset: 0x0057F8EF
		public static VectorOffset CreateEntityIdListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028445 RID: 164933 RVA: 0x00581709 File Offset: 0x0057F909
		public static VectorOffset CreateEntityIdListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06028446 RID: 164934 RVA: 0x00581727 File Offset: 0x0057F927
		public static VectorOffset CreateEntityIdListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06028447 RID: 164935 RVA: 0x00581740 File Offset: 0x0057F940
		public static void StartEntityIdListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06028448 RID: 164936 RVA: 0x0058174B File Offset: 0x0057F94B
		public static void AddIsUesCylinder(FlatBufferBuilder builder, Offset<ICylinder> isUesCylinderOffset)
		{
			builder.AddOffset(4, isUesCylinderOffset.Value, 0);
		}

		// Token: 0x06028449 RID: 164937 RVA: 0x0058175B File Offset: 0x0057F95B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602844A RID: 164938 RVA: 0x00581766 File Offset: 0x0057F966
		public static Offset<IRefreshGroup> EndIRefreshGroup(FlatBufferBuilder builder)
		{
			return new Offset<IRefreshGroup>(builder.EndTable());
		}

		// Token: 0x0602844B RID: 164939 RVA: 0x00581774 File Offset: 0x0057F974
		public IRefreshGroupT UnPack()
		{
			IRefreshGroupT refreshGroupT = new IRefreshGroupT();
			this.UnPackTo(refreshGroupT);
			return refreshGroupT;
		}

		// Token: 0x0602844C RID: 164940 RVA: 0x00581790 File Offset: 0x0057F990
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

		// Token: 0x0602844D RID: 164941 RVA: 0x0058182C File Offset: 0x0057FA2C
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

		// Token: 0x0400FA1C RID: 64028
		private Table __p;
	}
}
