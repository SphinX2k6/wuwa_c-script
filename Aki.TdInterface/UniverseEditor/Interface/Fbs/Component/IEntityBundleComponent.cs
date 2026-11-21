using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056D0 RID: 22224
	public struct IEntityBundleComponent : IFlatbufferObject
	{
		// Token: 0x17009FF3 RID: 40947
		// (get) Token: 0x060239C8 RID: 145864 RVA: 0x004E57C0 File Offset: 0x004E39C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060239C9 RID: 145865 RVA: 0x004E57CD File Offset: 0x004E39CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060239CA RID: 145866 RVA: 0x004E57D4 File Offset: 0x004E39D4
		public static IEntityBundleComponent GetRootAsIEntityBundleComponent(ByteBuffer _bb)
		{
			return IEntityBundleComponent.GetRootAsIEntityBundleComponent(_bb, default(IEntityBundleComponent));
		}

		// Token: 0x060239CB RID: 145867 RVA: 0x004E57F0 File Offset: 0x004E39F0
		public static IEntityBundleComponent GetRootAsIEntityBundleComponent(ByteBuffer _bb, IEntityBundleComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060239CC RID: 145868 RVA: 0x004E580D File Offset: 0x004E3A0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060239CD RID: 145869 RVA: 0x004E581C File Offset: 0x004E3A1C
		public IEntityBundleComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009FF4 RID: 40948
		// (get) Token: 0x060239CE RID: 145870 RVA: 0x004E582C File Offset: 0x004E3A2C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009FF5 RID: 40949
		// (get) Token: 0x060239CF RID: 145871 RVA: 0x004E586C File Offset: 0x004E3A6C
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

		// Token: 0x060239D0 RID: 145872 RVA: 0x004E58A8 File Offset: 0x004E3AA8
		public IEntityBundleChildInfo? ChildInfos(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IEntityBundleChildInfo?(default(IEntityBundleChildInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009FF6 RID: 40950
		// (get) Token: 0x060239D1 RID: 145873 RVA: 0x004E5908 File Offset: 0x004E3B08
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

		// Token: 0x17009FF7 RID: 40951
		// (get) Token: 0x060239D2 RID: 145874 RVA: 0x004E5934 File Offset: 0x004E3B34
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

		// Token: 0x060239D3 RID: 145875 RVA: 0x004E5971 File Offset: 0x004E3B71
		public static Offset<IEntityBundleComponent> CreateIEntityBundleComponent(FlatBufferBuilder builder, bool Disabled = false, int BundleId = 0, VectorOffset ChildInfosOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			IEntityBundleComponent.AddChildInfos(builder, ChildInfosOffset);
			IEntityBundleComponent.AddBundleId(builder, BundleId);
			IEntityBundleComponent.AddNullMask(builder, NullMask);
			IEntityBundleComponent.AddDisabled(builder, Disabled);
			return IEntityBundleComponent.EndIEntityBundleComponent(builder);
		}

		// Token: 0x060239D4 RID: 145876 RVA: 0x004E599D File Offset: 0x004E3B9D
		public static void StartIEntityBundleComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060239D5 RID: 145877 RVA: 0x004E59A6 File Offset: 0x004E3BA6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060239D6 RID: 145878 RVA: 0x004E59B1 File Offset: 0x004E3BB1
		public static void AddBundleId(FlatBufferBuilder builder, int bundleId)
		{
			builder.AddInt(1, bundleId, 0);
		}

		// Token: 0x060239D7 RID: 145879 RVA: 0x004E59BC File Offset: 0x004E3BBC
		public static void AddChildInfos(FlatBufferBuilder builder, VectorOffset childInfosOffset)
		{
			builder.AddOffset(2, childInfosOffset.Value, 0);
		}

		// Token: 0x060239D8 RID: 145880 RVA: 0x004E59CC File Offset: 0x004E3BCC
		public static VectorOffset CreateChildInfosVector(FlatBufferBuilder builder, Offset<IEntityBundleChildInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060239D9 RID: 145881 RVA: 0x004E5A0C File Offset: 0x004E3C0C
		public static VectorOffset CreateChildInfosVectorBlock(FlatBufferBuilder builder, Offset<IEntityBundleChildInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityBundleChildInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060239DA RID: 145882 RVA: 0x004E5A26 File Offset: 0x004E3C26
		public static VectorOffset CreateChildInfosVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityBundleChildInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityBundleChildInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060239DB RID: 145883 RVA: 0x004E5A44 File Offset: 0x004E3C44
		public static VectorOffset CreateChildInfosVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityBundleChildInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060239DC RID: 145884 RVA: 0x004E5A5D File Offset: 0x004E3C5D
		public static void StartChildInfosVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060239DD RID: 145885 RVA: 0x004E5A68 File Offset: 0x004E3C68
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x060239DE RID: 145886 RVA: 0x004E5A73 File Offset: 0x004E3C73
		public static Offset<IEntityBundleComponent> EndIEntityBundleComponent(FlatBufferBuilder builder)
		{
			return new Offset<IEntityBundleComponent>(builder.EndTable());
		}

		// Token: 0x060239DF RID: 145887 RVA: 0x004E5A80 File Offset: 0x004E3C80
		public IEntityBundleComponentT UnPack()
		{
			IEntityBundleComponentT entityBundleComponentT = new IEntityBundleComponentT();
			this.UnPackTo(entityBundleComponentT);
			return entityBundleComponentT;
		}

		// Token: 0x060239E0 RID: 145888 RVA: 0x004E5A9C File Offset: 0x004E3C9C
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

		// Token: 0x060239E1 RID: 145889 RVA: 0x004E5B20 File Offset: 0x004E3D20
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

		// Token: 0x0400EE13 RID: 60947
		private Table __p;
	}
}
