using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200566D RID: 22125
	public struct IEditCustomAoiComponent : IFlatbufferObject
	{
		// Token: 0x17009F12 RID: 40722
		// (get) Token: 0x0602360E RID: 144910 RVA: 0x004DDF5E File Offset: 0x004DC15E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602360F RID: 144911 RVA: 0x004DDF6B File Offset: 0x004DC16B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023610 RID: 144912 RVA: 0x004DDF74 File Offset: 0x004DC174
		public static IEditCustomAoiComponent GetRootAsIEditCustomAoiComponent(ByteBuffer _bb)
		{
			return IEditCustomAoiComponent.GetRootAsIEditCustomAoiComponent(_bb, default(IEditCustomAoiComponent));
		}

		// Token: 0x06023611 RID: 144913 RVA: 0x004DDF90 File Offset: 0x004DC190
		public static IEditCustomAoiComponent GetRootAsIEditCustomAoiComponent(ByteBuffer _bb, IEditCustomAoiComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023612 RID: 144914 RVA: 0x004DDFAD File Offset: 0x004DC1AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023613 RID: 144915 RVA: 0x004DDFBC File Offset: 0x004DC1BC
		public IEditCustomAoiComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009F13 RID: 40723
		// (get) Token: 0x06023614 RID: 144916 RVA: 0x004DDFCC File Offset: 0x004DC1CC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06023615 RID: 144917 RVA: 0x004DE00C File Offset: 0x004DC20C
		public int Entities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009F14 RID: 40724
		// (get) Token: 0x06023616 RID: 144918 RVA: 0x004DE04C File Offset: 0x004DC24C
		public int EntitiesLength
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

		// Token: 0x06023617 RID: 144919 RVA: 0x004DE077 File Offset: 0x004DC277
		public Span<int> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06023618 RID: 144920 RVA: 0x004DE086 File Offset: 0x004DC286
		public int[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17009F15 RID: 40725
		// (get) Token: 0x06023619 RID: 144921 RVA: 0x004DE094 File Offset: 0x004DC294
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602361A RID: 144922 RVA: 0x004DE0D0 File Offset: 0x004DC2D0
		public static Offset<IEditCustomAoiComponent> CreateIEditCustomAoiComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset EntitiesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IEditCustomAoiComponent.AddEntities(builder, EntitiesOffset);
			IEditCustomAoiComponent.AddNullMask(builder, NullMask);
			IEditCustomAoiComponent.AddDisabled(builder, Disabled);
			return IEditCustomAoiComponent.EndIEditCustomAoiComponent(builder);
		}

		// Token: 0x0602361B RID: 144923 RVA: 0x004DE0F4 File Offset: 0x004DC2F4
		public static void StartIEditCustomAoiComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602361C RID: 144924 RVA: 0x004DE0FD File Offset: 0x004DC2FD
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602361D RID: 144925 RVA: 0x004DE108 File Offset: 0x004DC308
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(1, entitiesOffset.Value, 0);
		}

		// Token: 0x0602361E RID: 144926 RVA: 0x004DE118 File Offset: 0x004DC318
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602361F RID: 144927 RVA: 0x004DE14F File Offset: 0x004DC34F
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023620 RID: 144928 RVA: 0x004DE169 File Offset: 0x004DC369
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06023621 RID: 144929 RVA: 0x004DE187 File Offset: 0x004DC387
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023622 RID: 144930 RVA: 0x004DE1A0 File Offset: 0x004DC3A0
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023623 RID: 144931 RVA: 0x004DE1AB File Offset: 0x004DC3AB
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x06023624 RID: 144932 RVA: 0x004DE1B6 File Offset: 0x004DC3B6
		public static Offset<IEditCustomAoiComponent> EndIEditCustomAoiComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEditCustomAoiComponent>(builder.EndTable());
		}

		// Token: 0x06023625 RID: 144933 RVA: 0x004DE1C4 File Offset: 0x004DC3C4
		public IEditCustomAoiComponentT UnPack()
		{
			IEditCustomAoiComponentT editCustomAoiComponentT = new IEditCustomAoiComponentT();
			this.UnPackTo(editCustomAoiComponentT);
			return editCustomAoiComponentT;
		}

		// Token: 0x06023626 RID: 144934 RVA: 0x004DE1E0 File Offset: 0x004DC3E0
		public void UnPackTo(IEditCustomAoiComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Entities = new List<int>();
			for (int i = 0; i < this.EntitiesLength; i++)
			{
				_o.Entities.Add(this.Entities(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06023627 RID: 144935 RVA: 0x004DE234 File Offset: 0x004DC434
		public static Offset<IEditCustomAoiComponent> Pack(FlatBufferBuilder builder, IEditCustomAoiComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEditCustomAoiComponent>);
			}
			VectorOffset entitiesOffset = default(VectorOffset);
			if (_o.Entities != null)
			{
				int[] data = _o.Entities.ToArray();
				entitiesOffset = IEditCustomAoiComponent.CreateEntitiesVector(builder, data);
			}
			return IEditCustomAoiComponent.CreateIEditCustomAoiComponent(builder, _o.Disabled, entitiesOffset, _o.NullMask);
		}

		// Token: 0x0400ED71 RID: 60785
		private Table __p;
	}
}
