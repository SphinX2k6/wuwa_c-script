using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200516B RID: 20843
	public struct IEntityBundleComponent : IFlatbufferObject
	{
		// Token: 0x17009806 RID: 38918
		// (get) Token: 0x06021A74 RID: 137844 RVA: 0x004AB834 File Offset: 0x004A9A34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021A75 RID: 137845 RVA: 0x004AB841 File Offset: 0x004A9A41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021A76 RID: 137846 RVA: 0x004AB848 File Offset: 0x004A9A48
		public static IEntityBundleComponent GetRootAsIEntityBundleComponent(ByteBuffer _bb)
		{
			return IEntityBundleComponent.GetRootAsIEntityBundleComponent(_bb, default(IEntityBundleComponent));
		}

		// Token: 0x06021A77 RID: 137847 RVA: 0x004AB864 File Offset: 0x004A9A64
		public static IEntityBundleComponent GetRootAsIEntityBundleComponent(ByteBuffer _bb, IEntityBundleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021A78 RID: 137848 RVA: 0x004AB881 File Offset: 0x004A9A81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021A79 RID: 137849 RVA: 0x004AB890 File Offset: 0x004A9A90
		public IEntityBundleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009807 RID: 38919
		// (get) Token: 0x06021A7A RID: 137850 RVA: 0x004AB8A0 File Offset: 0x004A9AA0
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009808 RID: 38920
		// (get) Token: 0x06021A7B RID: 137851 RVA: 0x004AB8E0 File Offset: 0x004A9AE0
		public int BundleId
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

		// Token: 0x06021A7C RID: 137852 RVA: 0x004AB91C File Offset: 0x004A9B1C
		public IEntityBundleChildInfo? ChildInfos(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IEntityBundleChildInfo?(default(IEntityBundleChildInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009809 RID: 38921
		// (get) Token: 0x06021A7D RID: 137853 RVA: 0x004AB97C File Offset: 0x004A9B7C
		public int ChildInfosLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700980A RID: 38922
		// (get) Token: 0x06021A7E RID: 137854 RVA: 0x004AB9A8 File Offset: 0x004A9BA8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021A7F RID: 137855 RVA: 0x004AB9E5 File Offset: 0x004A9BE5
		public static Offset<IEntityBundleComponent> CreateIEntityBundleComponent(FlatBufferBuilder builder, bool Disabled = false, int BundleId = 0, VectorOffset ChildInfosOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityBundleComponent.AddChildInfos(builder, ChildInfosOffset);
			IEntityBundleComponent.AddBundleId(builder, BundleId);
			IEntityBundleComponent.AddNullMask(builder, NullMask);
			IEntityBundleComponent.AddDisabled(builder, Disabled);
			return IEntityBundleComponent.EndIEntityBundleComponent(builder);
		}

		// Token: 0x06021A80 RID: 137856 RVA: 0x004ABA11 File Offset: 0x004A9C11
		public static void StartIEntityBundleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06021A81 RID: 137857 RVA: 0x004ABA1A File Offset: 0x004A9C1A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021A82 RID: 137858 RVA: 0x004ABA25 File Offset: 0x004A9C25
		public static void AddBundleId(FlatBufferBuilder builder, int bundleId)
		{
			builder.AddInt(1, bundleId, 0);
		}

		// Token: 0x06021A83 RID: 137859 RVA: 0x004ABA30 File Offset: 0x004A9C30
		public static void AddChildInfos(FlatBufferBuilder builder, VectorOffset childInfosOffset)
		{
			builder.AddOffset(2, childInfosOffset.Value, 0);
		}

		// Token: 0x06021A84 RID: 137860 RVA: 0x004ABA40 File Offset: 0x004A9C40
		public static VectorOffset CreateChildInfosVector(FlatBufferBuilder builder, Offset<IEntityBundleChildInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021A85 RID: 137861 RVA: 0x004ABA80 File Offset: 0x004A9C80
		public static VectorOffset CreateChildInfosVectorBlock(FlatBufferBuilder builder, Offset<IEntityBundleChildInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityBundleChildInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021A86 RID: 137862 RVA: 0x004ABA9A File Offset: 0x004A9C9A
		public static VectorOffset CreateChildInfosVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityBundleChildInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityBundleChildInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021A87 RID: 137863 RVA: 0x004ABAB8 File Offset: 0x004A9CB8
		public static VectorOffset CreateChildInfosVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityBundleChildInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021A88 RID: 137864 RVA: 0x004ABAD1 File Offset: 0x004A9CD1
		public static void StartChildInfosVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021A89 RID: 137865 RVA: 0x004ABADC File Offset: 0x004A9CDC
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06021A8A RID: 137866 RVA: 0x004ABAE7 File Offset: 0x004A9CE7
		public static Offset<IEntityBundleComponent> EndIEntityBundleComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityBundleComponent>(builder.EndTable());
		}

		// Token: 0x06021A8B RID: 137867 RVA: 0x004ABAF4 File Offset: 0x004A9CF4
		public IEntityBundleComponentT UnPack()
		{
			IEntityBundleComponentT entityBundleComponentT = new IEntityBundleComponentT();
			this.UnPackTo(entityBundleComponentT);
			return entityBundleComponentT;
		}

		// Token: 0x06021A8C RID: 137868 RVA: 0x004ABB10 File Offset: 0x004A9D10
		public void UnPackTo(IEntityBundleComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.BundleId = this.BundleId;
			_o.ChildInfos = new List<IEntityBundleChildInfoT>();
			for (int i = 0; i < this.ChildInfosLength; i++)
			{
				_o.ChildInfos.Add((this.ChildInfos(i) != null) ? this.ChildInfos(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021A8D RID: 137869 RVA: 0x004ABB94 File Offset: 0x004A9D94
		public static Offset<IEntityBundleComponent> Pack(FlatBufferBuilder builder, IEntityBundleComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEntityBundleComponent>);
			}
			VectorOffset childInfosOffset = default(VectorOffset);
			if (_o.ChildInfos != null)
			{
				Offset<IEntityBundleChildInfo>[] array = new Offset<IEntityBundleChildInfo>[_o.ChildInfos.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityBundleChildInfo.Pack(builder, _o.ChildInfos[i]);
				}
				childInfosOffset = IEntityBundleComponent.CreateChildInfosVector(builder, array);
			}
			return IEntityBundleComponent.CreateIEntityBundleComponent(builder, _o.Disabled, _o.BundleId, childInfosOffset, _o.NullMask);
		}

		// Token: 0x0400E216 RID: 57878
		private Table __p;
	}
}
