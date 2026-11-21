using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005802 RID: 22530
	public struct IFollowShooterComponent : IFlatbufferObject
	{
		// Token: 0x1700A30D RID: 41741
		// (get) Token: 0x06024710 RID: 149264 RVA: 0x005020AD File Offset: 0x005002AD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024711 RID: 149265 RVA: 0x005020BA File Offset: 0x005002BA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024712 RID: 149266 RVA: 0x005020C4 File Offset: 0x005002C4
		public static IFollowShooterComponent GetRootAsIFollowShooterComponent(ByteBuffer _bb)
		{
			return IFollowShooterComponent.GetRootAsIFollowShooterComponent(_bb, default(IFollowShooterComponent));
		}

		// Token: 0x06024713 RID: 149267 RVA: 0x005020E0 File Offset: 0x005002E0
		public static IFollowShooterComponent GetRootAsIFollowShooterComponent(ByteBuffer _bb, IFollowShooterComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024714 RID: 149268 RVA: 0x005020FD File Offset: 0x005002FD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024715 RID: 149269 RVA: 0x0050210C File Offset: 0x0050030C
		public IFollowShooterComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A30E RID: 41742
		// (get) Token: 0x06024716 RID: 149270 RVA: 0x0050211C File Offset: 0x0050031C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A30F RID: 41743
		// (get) Token: 0x06024717 RID: 149271 RVA: 0x0050215C File Offset: 0x0050035C
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

		// Token: 0x06024718 RID: 149272 RVA: 0x00502193 File Offset: 0x00500393
		public Span<byte> GetConfigBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024719 RID: 149273 RVA: 0x005021A2 File Offset: 0x005003A2
		public byte[] GetConfigArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A310 RID: 41744
		// (get) Token: 0x0602471A RID: 149274 RVA: 0x005021B0 File Offset: 0x005003B0
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

		// Token: 0x0602471B RID: 149275 RVA: 0x00502210 File Offset: 0x00500410
		public IEntityCategory? LockableCategories(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IEntityCategory?(default(IEntityCategory).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A311 RID: 41745
		// (get) Token: 0x0602471C RID: 149276 RVA: 0x00502274 File Offset: 0x00500474
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

		// Token: 0x1700A312 RID: 41746
		// (get) Token: 0x0602471D RID: 149277 RVA: 0x005022A0 File Offset: 0x005004A0
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

		// Token: 0x0602471E RID: 149278 RVA: 0x005022DD File Offset: 0x005004DD
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

		// Token: 0x0602471F RID: 149279 RVA: 0x00502311 File Offset: 0x00500511
		public static void StartIFollowShooterComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06024720 RID: 149280 RVA: 0x0050231A File Offset: 0x0050051A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06024721 RID: 149281 RVA: 0x00502325 File Offset: 0x00500525
		public static void AddConfig(FlatBufferBuilder builder, StringOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x06024722 RID: 149282 RVA: 0x00502335 File Offset: 0x00500535
		public static void AddTypeConfig(FlatBufferBuilder builder, Offset<IFollowShooterJellyFishConfig> typeConfigOffset)
		{
			builder.AddOffset(2, typeConfigOffset.Value, 0);
		}

		// Token: 0x06024723 RID: 149283 RVA: 0x00502345 File Offset: 0x00500545
		public static void AddLockableCategories(FlatBufferBuilder builder, VectorOffset lockableCategoriesOffset)
		{
			builder.AddOffset(3, lockableCategoriesOffset.Value, 0);
		}

		// Token: 0x06024724 RID: 149284 RVA: 0x00502358 File Offset: 0x00500558
		public static VectorOffset CreateLockableCategoriesVector(FlatBufferBuilder builder, Offset<IEntityCategory>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024725 RID: 149285 RVA: 0x00502398 File Offset: 0x00500598
		public static VectorOffset CreateLockableCategoriesVectorBlock(FlatBufferBuilder builder, Offset<IEntityCategory>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IEntityCategory>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024726 RID: 149286 RVA: 0x005023B2 File Offset: 0x005005B2
		public static VectorOffset CreateLockableCategoriesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IEntityCategory>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IEntityCategory>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024727 RID: 149287 RVA: 0x005023D0 File Offset: 0x005005D0
		public static VectorOffset CreateLockableCategoriesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IEntityCategory>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024728 RID: 149288 RVA: 0x005023E9 File Offset: 0x005005E9
		public static void StartLockableCategoriesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024729 RID: 149289 RVA: 0x005023F4 File Offset: 0x005005F4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602472A RID: 149290 RVA: 0x005023FF File Offset: 0x005005FF
		public static Offset<IFollowShooterComponent> EndIFollowShooterComponent(FlatBufferBuilder builder)
		{
			return new Offset<IFollowShooterComponent>(builder.EndTable());
		}

		// Token: 0x0602472B RID: 149291 RVA: 0x0050240C File Offset: 0x0050060C
		public IFollowShooterComponentT UnPack()
		{
			IFollowShooterComponentT followShooterComponentT = new IFollowShooterComponentT();
			this.UnPackTo(followShooterComponentT);
			return followShooterComponentT;
		}

		// Token: 0x0602472C RID: 149292 RVA: 0x00502428 File Offset: 0x00500628
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

		// Token: 0x0602472D RID: 149293 RVA: 0x005024DC File Offset: 0x005006DC
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

		// Token: 0x0400F014 RID: 61460
		private Table __p;
	}
}
