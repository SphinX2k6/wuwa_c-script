using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CD8 RID: 23768
	public struct IPathDrivenActorInitialSpawnConfig : IFlatbufferObject
	{
		// Token: 0x1700AEA4 RID: 44708
		// (get) Token: 0x06027749 RID: 161609 RVA: 0x00566625 File Offset: 0x00564825
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602774A RID: 161610 RVA: 0x00566632 File Offset: 0x00564832
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602774B RID: 161611 RVA: 0x0056663C File Offset: 0x0056483C
		public static IPathDrivenActorInitialSpawnConfig GetRootAsIPathDrivenActorInitialSpawnConfig(ByteBuffer _bb)
		{
			return IPathDrivenActorInitialSpawnConfig.GetRootAsIPathDrivenActorInitialSpawnConfig(_bb, default(IPathDrivenActorInitialSpawnConfig));
		}

		// Token: 0x0602774C RID: 161612 RVA: 0x00566658 File Offset: 0x00564858
		public static IPathDrivenActorInitialSpawnConfig GetRootAsIPathDrivenActorInitialSpawnConfig(ByteBuffer _bb, IPathDrivenActorInitialSpawnConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602774D RID: 161613 RVA: 0x00566675 File Offset: 0x00564875
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602774E RID: 161614 RVA: 0x00566684 File Offset: 0x00564884
		public IPathDrivenActorInitialSpawnConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEA5 RID: 44709
		// (get) Token: 0x0602774F RID: 161615 RVA: 0x00566694 File Offset: 0x00564894
		public bool EnableInitialSpawn
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06027750 RID: 161616 RVA: 0x005666D4 File Offset: 0x005648D4
		public IPathDrivenActorInitialSpawnHandle? InitialSpawnHandles(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IPathDrivenActorInitialSpawnHandle?(default(IPathDrivenActorInitialSpawnHandle).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AEA6 RID: 44710
		// (get) Token: 0x06027751 RID: 161617 RVA: 0x00566734 File Offset: 0x00564934
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

		// Token: 0x1700AEA7 RID: 44711
		// (get) Token: 0x06027752 RID: 161618 RVA: 0x00566760 File Offset: 0x00564960
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

		// Token: 0x06027753 RID: 161619 RVA: 0x0056679C File Offset: 0x0056499C
		public static Offset<IPathDrivenActorInitialSpawnConfig> CreateIPathDrivenActorInitialSpawnConfig(FlatBufferBuilder builder, bool EnableInitialSpawn = false, VectorOffset InitialSpawnHandlesOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IPathDrivenActorInitialSpawnConfig.AddInitialSpawnHandles(builder, InitialSpawnHandlesOffset);
			IPathDrivenActorInitialSpawnConfig.AddNullMask(builder, NullMask);
			IPathDrivenActorInitialSpawnConfig.AddEnableInitialSpawn(builder, EnableInitialSpawn);
			return IPathDrivenActorInitialSpawnConfig.EndIPathDrivenActorInitialSpawnConfig(builder);
		}

		// Token: 0x06027754 RID: 161620 RVA: 0x005667C0 File Offset: 0x005649C0
		public static void StartIPathDrivenActorInitialSpawnConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06027755 RID: 161621 RVA: 0x005667C9 File Offset: 0x005649C9
		public static void AddEnableInitialSpawn(FlatBufferBuilder builder, bool enableInitialSpawn)
		{
			builder.AddBool(0, enableInitialSpawn, false);
		}

		// Token: 0x06027756 RID: 161622 RVA: 0x005667D4 File Offset: 0x005649D4
		public static void AddInitialSpawnHandles(FlatBufferBuilder builder, VectorOffset initialSpawnHandlesOffset)
		{
			builder.AddOffset(1, initialSpawnHandlesOffset.Value, 0);
		}

		// Token: 0x06027757 RID: 161623 RVA: 0x005667E4 File Offset: 0x005649E4
		public static VectorOffset CreateInitialSpawnHandlesVector(FlatBufferBuilder builder, Offset<IPathDrivenActorInitialSpawnHandle>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06027758 RID: 161624 RVA: 0x00566824 File Offset: 0x00564A24
		public static VectorOffset CreateInitialSpawnHandlesVectorBlock(FlatBufferBuilder builder, Offset<IPathDrivenActorInitialSpawnHandle>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPathDrivenActorInitialSpawnHandle>>(data);
			return builder.EndVector();
		}

		// Token: 0x06027759 RID: 161625 RVA: 0x0056683E File Offset: 0x00564A3E
		public static VectorOffset CreateInitialSpawnHandlesVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPathDrivenActorInitialSpawnHandle>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPathDrivenActorInitialSpawnHandle>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602775A RID: 161626 RVA: 0x0056685C File Offset: 0x00564A5C
		public static VectorOffset CreateInitialSpawnHandlesVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPathDrivenActorInitialSpawnHandle>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602775B RID: 161627 RVA: 0x00566875 File Offset: 0x00564A75
		public static void StartInitialSpawnHandlesVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602775C RID: 161628 RVA: 0x00566880 File Offset: 0x00564A80
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602775D RID: 161629 RVA: 0x0056688B File Offset: 0x00564A8B
		public static Offset<IPathDrivenActorInitialSpawnConfig> EndIPathDrivenActorInitialSpawnConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPathDrivenActorInitialSpawnConfig>(builder.EndTable());
		}

		// Token: 0x0602775E RID: 161630 RVA: 0x00566898 File Offset: 0x00564A98
		public IPathDrivenActorInitialSpawnConfigT UnPack()
		{
			IPathDrivenActorInitialSpawnConfigT pathDrivenActorInitialSpawnConfigT = new IPathDrivenActorInitialSpawnConfigT();
			this.UnPackTo(pathDrivenActorInitialSpawnConfigT);
			return pathDrivenActorInitialSpawnConfigT;
		}

		// Token: 0x0602775F RID: 161631 RVA: 0x005668B4 File Offset: 0x00564AB4
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

		// Token: 0x06027760 RID: 161632 RVA: 0x0056692C File Offset: 0x00564B2C
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

		// Token: 0x0400F806 RID: 63494
		private Table __p;
	}
}
