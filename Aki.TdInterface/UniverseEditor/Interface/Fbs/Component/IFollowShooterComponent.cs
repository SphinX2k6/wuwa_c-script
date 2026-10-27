using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200529A RID: 21146
	public struct IFollowShooterComponent : IFlatbufferObject
	{
		// Token: 0x17009B0F RID: 39695
		// (get) Token: 0x06022776 RID: 141174 RVA: 0x004C753D File Offset: 0x004C573D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022777 RID: 141175 RVA: 0x004C754A File Offset: 0x004C574A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022778 RID: 141176 RVA: 0x004C7554 File Offset: 0x004C5754
		public static IFollowShooterComponent GetRootAsIFollowShooterComponent(ByteBuffer _bb)
		{
			return IFollowShooterComponent.GetRootAsIFollowShooterComponent(_bb, default(IFollowShooterComponent));
		}

		// Token: 0x06022779 RID: 141177 RVA: 0x004C7570 File Offset: 0x004C5770
		public static IFollowShooterComponent GetRootAsIFollowShooterComponent(ByteBuffer _bb, IFollowShooterComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602277A RID: 141178 RVA: 0x004C758D File Offset: 0x004C578D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602277B RID: 141179 RVA: 0x004C759C File Offset: 0x004C579C
		public IFollowShooterComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B10 RID: 39696
		// (get) Token: 0x0602277C RID: 141180 RVA: 0x004C75AC File Offset: 0x004C57AC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17009B11 RID: 39697
		// (get) Token: 0x0602277D RID: 141181 RVA: 0x004C75EC File Offset: 0x004C57EC
		public string Config
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602277E RID: 141182 RVA: 0x004C7623 File Offset: 0x004C5823
		public Span<byte> GetConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602277F RID: 141183 RVA: 0x004C7632 File Offset: 0x004C5832
		public byte[] GetConfigArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009B12 RID: 39698
		// (get) Token: 0x06022780 RID: 141184 RVA: 0x004C7640 File Offset: 0x004C5840
		public IFollowShooterJellyFishConfig? TypeConfig
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IFollowShooterJellyFishConfig?(default(IFollowShooterJellyFishConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06022781 RID: 141185 RVA: 0x004C76A0 File Offset: 0x004C58A0
		public IEntityCategory? LockableCategories(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IEntityCategory?(default(IEntityCategory).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B13 RID: 39699
		// (get) Token: 0x06022782 RID: 141186 RVA: 0x004C7704 File Offset: 0x004C5904
		public int LockableCategoriesLength
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

		// Token: 0x17009B14 RID: 39700
		// (get) Token: 0x06022783 RID: 141187 RVA: 0x004C7730 File Offset: 0x004C5930
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

		// Token: 0x06022784 RID: 141188 RVA: 0x004C776D File Offset: 0x004C596D
		public static Offset<IFollowShooterComponent> CreateIFollowShooterComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset ConfigOffset = default(StringOffset), Offset<IFollowShooterJellyFishConfig> TypeConfigOffset = default(Offset<IFollowShooterJellyFishConfig>), VectorOffset LockableCategoriesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IFollowShooterComponent.AddLockableCategories(builder, LockableCategoriesOffset);
			IFollowShooterComponent.AddTypeConfig(builder, TypeConfigOffset);
			IFollowShooterComponent.AddConfig(builder, ConfigOffset);
			IFollowShooterComponent.AddNullMask(builder, NullMask);
			IFollowShooterComponent.AddDisabled(builder, Disabled);
			return IFollowShooterComponent.EndIFollowShooterComponent(builder);
		}

		// Token: 0x06022785 RID: 141189 RVA: 0x004C77A1 File Offset: 0x004C59A1
		public static void StartIFollowShooterComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06022786 RID: 141190 RVA: 0x004C77AA File Offset: 0x004C59AA
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06022787 RID: 141191 RVA: 0x004C77B5 File Offset: 0x004C59B5
		public static void AddConfig(FlatBufferBuilder builder, StringOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x06022788 RID: 141192 RVA: 0x004C77C5 File Offset: 0x004C59C5
		public static void AddTypeConfig(FlatBufferBuilder builder, Offset<IFollowShooterJellyFishConfig> typeConfigOffset)
		{
			builder.AddOffset(2, typeConfigOffset.Value, 0);
		}

		// Token: 0x06022789 RID: 141193 RVA: 0x004C77D5 File Offset: 0x004C59D5
		public static void AddLockableCategories(FlatBufferBuilder builder, VectorOffset lockableCategoriesOffset)
		{
			builder.AddOffset(3, lockableCategoriesOffset.Value, 0);
		}

		// Token: 0x0602278A RID: 141194 RVA: 0x004C77E8 File Offset: 0x004C59E8
		public static VectorOffset CreateLockableCategoriesVector(FlatBufferBuilder builder, Offset<IEntityCategory>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602278B RID: 141195 RVA: 0x004C7828 File Offset: 0x004C5A28
		public static VectorOffset CreateLockableCategoriesVectorBlock(FlatBufferBuilder builder, Offset<IEntityCategory>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityCategory>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602278C RID: 141196 RVA: 0x004C7842 File Offset: 0x004C5A42
		public static VectorOffset CreateLockableCategoriesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityCategory>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityCategory>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602278D RID: 141197 RVA: 0x004C7860 File Offset: 0x004C5A60
		public static VectorOffset CreateLockableCategoriesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityCategory>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602278E RID: 141198 RVA: 0x004C7879 File Offset: 0x004C5A79
		public static void StartLockableCategoriesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602278F RID: 141199 RVA: 0x004C7884 File Offset: 0x004C5A84
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06022790 RID: 141200 RVA: 0x004C788F File Offset: 0x004C5A8F
		public static Offset<IFollowShooterComponent> EndIFollowShooterComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterComponent>(builder.EndTable());
		}

		// Token: 0x06022791 RID: 141201 RVA: 0x004C789C File Offset: 0x004C5A9C
		public IFollowShooterComponentT UnPack()
		{
			IFollowShooterComponentT followShooterComponentT = new IFollowShooterComponentT();
			this.UnPackTo(followShooterComponentT);
			return followShooterComponentT;
		}

		// Token: 0x06022792 RID: 141202 RVA: 0x004C78B8 File Offset: 0x004C5AB8
		public void UnPackTo(IFollowShooterComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.Config = this.Config;
			_o.TypeConfig = ((this.TypeConfig != null) ? this.TypeConfig.Value.UnPack() : null);
			_o.LockableCategories = new List<IEntityCategoryT>();
			for (int i = 0; i < this.LockableCategoriesLength; i++)
			{
				_o.LockableCategories.Add((this.LockableCategories(i) != null) ? this.LockableCategories(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06022793 RID: 141203 RVA: 0x004C796C File Offset: 0x004C5B6C
		public static Offset<IFollowShooterComponent> Pack(FlatBufferBuilder builder, IFollowShooterComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFollowShooterComponent>);
			}
			StringOffset configOffset = (_o.Config == null) ? default(StringOffset) : builder.CreateString(_o.Config);
			Offset<IFollowShooterJellyFishConfig> typeConfigOffset = (_o.TypeConfig == null) ? default(Offset<IFollowShooterJellyFishConfig>) : IFollowShooterJellyFishConfig.Pack(builder, _o.TypeConfig);
			VectorOffset lockableCategoriesOffset = default(VectorOffset);
			if (_o.LockableCategories != null)
			{
				Offset<IEntityCategory>[] array = new Offset<IEntityCategory>[_o.LockableCategories.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IEntityCategory.Pack(builder, _o.LockableCategories[i]);
				}
				lockableCategoriesOffset = IFollowShooterComponent.CreateLockableCategoriesVector(builder, array);
			}
			return IFollowShooterComponent.CreateIFollowShooterComponent(builder, _o.Disabled, configOffset, typeConfigOffset, lockableCategoriesOffset, _o.NullMask);
		}

		// Token: 0x0400E40D RID: 58381
		private Table __p;
	}
}
