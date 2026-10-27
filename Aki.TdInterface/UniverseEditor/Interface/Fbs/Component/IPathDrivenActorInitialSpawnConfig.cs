using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E9 RID: 22249
	public struct IPathDrivenActorInitialSpawnConfig : IFlatbufferObject
	{
		// Token: 0x1700A5A1 RID: 42401
		// (get) Token: 0x060252E2 RID: 152290 RVA: 0x00521BD9 File Offset: 0x0051FDD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060252E3 RID: 152291 RVA: 0x00521BE6 File Offset: 0x0051FDE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060252E4 RID: 152292 RVA: 0x00521BF0 File Offset: 0x0051FDF0
		public static IPathDrivenActorInitialSpawnConfig GetRootAsIPathDrivenActorInitialSpawnConfig(ByteBuffer _bb)
		{
			return IPathDrivenActorInitialSpawnConfig.GetRootAsIPathDrivenActorInitialSpawnConfig(_bb, default(IPathDrivenActorInitialSpawnConfig));
		}

		// Token: 0x060252E5 RID: 152293 RVA: 0x00521C0C File Offset: 0x0051FE0C
		public static IPathDrivenActorInitialSpawnConfig GetRootAsIPathDrivenActorInitialSpawnConfig(ByteBuffer _bb, IPathDrivenActorInitialSpawnConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060252E6 RID: 152294 RVA: 0x00521C29 File Offset: 0x0051FE29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060252E7 RID: 152295 RVA: 0x00521C38 File Offset: 0x0051FE38
		public IPathDrivenActorInitialSpawnConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5A2 RID: 42402
		// (get) Token: 0x060252E8 RID: 152296 RVA: 0x00521C48 File Offset: 0x0051FE48
		public bool EnableInitialSpawn
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060252E9 RID: 152297 RVA: 0x00521C88 File Offset: 0x0051FE88
		public IPathDrivenActorInitialSpawnHandle? InitialSpawnHandles(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IPathDrivenActorInitialSpawnHandle?(default(IPathDrivenActorInitialSpawnHandle).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A5A3 RID: 42403
		// (get) Token: 0x060252EA RID: 152298 RVA: 0x00521CE8 File Offset: 0x0051FEE8
		public int InitialSpawnHandlesLength
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

		// Token: 0x1700A5A4 RID: 42404
		// (get) Token: 0x060252EB RID: 152299 RVA: 0x00521D14 File Offset: 0x0051FF14
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

		// Token: 0x060252EC RID: 152300 RVA: 0x00521D50 File Offset: 0x0051FF50
		public static Offset<IPathDrivenActorInitialSpawnConfig> CreateIPathDrivenActorInitialSpawnConfig(FlatBufferBuilder builder, bool EnableInitialSpawn = false, VectorOffset InitialSpawnHandlesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IPathDrivenActorInitialSpawnConfig.AddInitialSpawnHandles(builder, InitialSpawnHandlesOffset);
			IPathDrivenActorInitialSpawnConfig.AddNullMask(builder, NullMask);
			IPathDrivenActorInitialSpawnConfig.AddEnableInitialSpawn(builder, EnableInitialSpawn);
			return IPathDrivenActorInitialSpawnConfig.EndIPathDrivenActorInitialSpawnConfig(builder);
		}

		// Token: 0x060252ED RID: 152301 RVA: 0x00521D74 File Offset: 0x0051FF74
		public static void StartIPathDrivenActorInitialSpawnConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060252EE RID: 152302 RVA: 0x00521D7D File Offset: 0x0051FF7D
		public static void AddEnableInitialSpawn(FlatBufferBuilder builder, bool enableInitialSpawn)
		{
			builder.AddBool(0, enableInitialSpawn, false);
		}

		// Token: 0x060252EF RID: 152303 RVA: 0x00521D88 File Offset: 0x0051FF88
		public static void AddInitialSpawnHandles(FlatBufferBuilder builder, VectorOffset initialSpawnHandlesOffset)
		{
			builder.AddOffset(1, initialSpawnHandlesOffset.Value, 0);
		}

		// Token: 0x060252F0 RID: 152304 RVA: 0x00521D98 File Offset: 0x0051FF98
		public static VectorOffset CreateInitialSpawnHandlesVector(FlatBufferBuilder builder, Offset<IPathDrivenActorInitialSpawnHandle>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060252F1 RID: 152305 RVA: 0x00521DD8 File Offset: 0x0051FFD8
		public static VectorOffset CreateInitialSpawnHandlesVectorBlock(FlatBufferBuilder builder, Offset<IPathDrivenActorInitialSpawnHandle>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPathDrivenActorInitialSpawnHandle>>(data);
			return builder.EndVector();
		}

		// Token: 0x060252F2 RID: 152306 RVA: 0x00521DF2 File Offset: 0x0051FFF2
		public static VectorOffset CreateInitialSpawnHandlesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPathDrivenActorInitialSpawnHandle>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPathDrivenActorInitialSpawnHandle>>(data);
			return builder.EndVector();
		}

		// Token: 0x060252F3 RID: 152307 RVA: 0x00521E10 File Offset: 0x00520010
		public static VectorOffset CreateInitialSpawnHandlesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPathDrivenActorInitialSpawnHandle>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060252F4 RID: 152308 RVA: 0x00521E29 File Offset: 0x00520029
		public static void StartInitialSpawnHandlesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060252F5 RID: 152309 RVA: 0x00521E34 File Offset: 0x00520034
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060252F6 RID: 152310 RVA: 0x00521E3F File Offset: 0x0052003F
		public static Offset<IPathDrivenActorInitialSpawnConfig> EndIPathDrivenActorInitialSpawnConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPathDrivenActorInitialSpawnConfig>(builder.EndTable());
		}

		// Token: 0x060252F7 RID: 152311 RVA: 0x00521E4C File Offset: 0x0052004C
		public IPathDrivenActorInitialSpawnConfigT UnPack()
		{
			IPathDrivenActorInitialSpawnConfigT pathDrivenActorInitialSpawnConfigT = new IPathDrivenActorInitialSpawnConfigT();
			this.UnPackTo(pathDrivenActorInitialSpawnConfigT);
			return pathDrivenActorInitialSpawnConfigT;
		}

		// Token: 0x060252F8 RID: 152312 RVA: 0x00521E68 File Offset: 0x00520068
		public void UnPackTo(IPathDrivenActorInitialSpawnConfigT _o)
		{
			_o.EnableInitialSpawn = this.EnableInitialSpawn;
			_o.InitialSpawnHandles = new List<IPathDrivenActorInitialSpawnHandleT>();
			for (int i = 0; i < this.InitialSpawnHandlesLength; i++)
			{
				_o.InitialSpawnHandles.Add((this.InitialSpawnHandles(i) != null) ? this.InitialSpawnHandles(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060252F9 RID: 152313 RVA: 0x00521EE0 File Offset: 0x005200E0
		public static Offset<IPathDrivenActorInitialSpawnConfig> Pack(FlatBufferBuilder builder, IPathDrivenActorInitialSpawnConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathDrivenActorInitialSpawnConfig>);
			}
			VectorOffset initialSpawnHandlesOffset = default(VectorOffset);
			if (_o.InitialSpawnHandles != null)
			{
				Offset<IPathDrivenActorInitialSpawnHandle>[] array = new Offset<IPathDrivenActorInitialSpawnHandle>[_o.InitialSpawnHandles.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPathDrivenActorInitialSpawnHandle.Pack(builder, _o.InitialSpawnHandles[i]);
				}
				initialSpawnHandlesOffset = IPathDrivenActorInitialSpawnConfig.CreateInitialSpawnHandlesVector(builder, array);
			}
			return IPathDrivenActorInitialSpawnConfig.CreateIPathDrivenActorInitialSpawnConfig(builder, _o.EnableInitialSpawn, initialSpawnHandlesOffset, _o.NullMask);
		}

		// Token: 0x0400EB39 RID: 60217
		private Table __p;
	}
}
