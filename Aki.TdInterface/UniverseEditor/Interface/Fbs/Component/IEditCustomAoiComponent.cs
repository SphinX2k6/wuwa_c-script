using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005108 RID: 20744
	public struct IEditCustomAoiComponent : IFlatbufferObject
	{
		// Token: 0x17009725 RID: 38693
		// (get) Token: 0x060216BA RID: 136890 RVA: 0x004A3FD2 File Offset: 0x004A21D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060216BB RID: 136891 RVA: 0x004A3FDF File Offset: 0x004A21DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060216BC RID: 136892 RVA: 0x004A3FE8 File Offset: 0x004A21E8
		public static IEditCustomAoiComponent GetRootAsIEditCustomAoiComponent(ByteBuffer _bb)
		{
			return IEditCustomAoiComponent.GetRootAsIEditCustomAoiComponent(_bb, default(IEditCustomAoiComponent));
		}

		// Token: 0x060216BD RID: 136893 RVA: 0x004A4004 File Offset: 0x004A2204
		public static IEditCustomAoiComponent GetRootAsIEditCustomAoiComponent(ByteBuffer _bb, IEditCustomAoiComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060216BE RID: 136894 RVA: 0x004A4021 File Offset: 0x004A2221
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060216BF RID: 136895 RVA: 0x004A4030 File Offset: 0x004A2230
		public IEditCustomAoiComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009726 RID: 38694
		// (get) Token: 0x060216C0 RID: 136896 RVA: 0x004A4040 File Offset: 0x004A2240
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060216C1 RID: 136897 RVA: 0x004A4080 File Offset: 0x004A2280
		public int Entities(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17009727 RID: 38695
		// (get) Token: 0x060216C2 RID: 136898 RVA: 0x004A40C0 File Offset: 0x004A22C0
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

		// Token: 0x060216C3 RID: 136899 RVA: 0x004A40EB File Offset: 0x004A22EB
		public Span<int> GetEntitiesBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x060216C4 RID: 136900 RVA: 0x004A40FA File Offset: 0x004A22FA
		public int[] GetEntitiesArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x17009728 RID: 38696
		// (get) Token: 0x060216C5 RID: 136901 RVA: 0x004A4108 File Offset: 0x004A2308
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

		// Token: 0x060216C6 RID: 136902 RVA: 0x004A4144 File Offset: 0x004A2344
		public static Offset<IEditCustomAoiComponent> CreateIEditCustomAoiComponent(FlatBufferBuilder builder, bool Disabled = false, VectorOffset EntitiesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IEditCustomAoiComponent.AddEntities(builder, EntitiesOffset);
			IEditCustomAoiComponent.AddNullMask(builder, NullMask);
			IEditCustomAoiComponent.AddDisabled(builder, Disabled);
			return IEditCustomAoiComponent.EndIEditCustomAoiComponent(builder);
		}

		// Token: 0x060216C7 RID: 136903 RVA: 0x004A4168 File Offset: 0x004A2368
		public static void StartIEditCustomAoiComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060216C8 RID: 136904 RVA: 0x004A4171 File Offset: 0x004A2371
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060216C9 RID: 136905 RVA: 0x004A417C File Offset: 0x004A237C
		public static void AddEntities(FlatBufferBuilder builder, VectorOffset entitiesOffset)
		{
			builder.AddOffset(1, entitiesOffset.Value, 0);
		}

		// Token: 0x060216CA RID: 136906 RVA: 0x004A418C File Offset: 0x004A238C
		public static VectorOffset CreateEntitiesVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060216CB RID: 136907 RVA: 0x004A41C3 File Offset: 0x004A23C3
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060216CC RID: 136908 RVA: 0x004A41DD File Offset: 0x004A23DD
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060216CD RID: 136909 RVA: 0x004A41FB File Offset: 0x004A23FB
		public static VectorOffset CreateEntitiesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060216CE RID: 136910 RVA: 0x004A4214 File Offset: 0x004A2414
		public static void StartEntitiesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060216CF RID: 136911 RVA: 0x004A421F File Offset: 0x004A241F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060216D0 RID: 136912 RVA: 0x004A422A File Offset: 0x004A242A
		public static Offset<IEditCustomAoiComponent> EndIEditCustomAoiComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEditCustomAoiComponent>(builder.EndTable());
		}

		// Token: 0x060216D1 RID: 136913 RVA: 0x004A4238 File Offset: 0x004A2438
		public IEditCustomAoiComponentT UnPack()
		{
			IEditCustomAoiComponentT editCustomAoiComponentT = new IEditCustomAoiComponentT();
			this.UnPackTo(editCustomAoiComponentT);
			return editCustomAoiComponentT;
		}

		// Token: 0x060216D2 RID: 136914 RVA: 0x004A4254 File Offset: 0x004A2454
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

		// Token: 0x060216D3 RID: 136915 RVA: 0x004A42A8 File Offset: 0x004A24A8
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

		// Token: 0x0400E174 RID: 57716
		private Table __p;
	}
}
