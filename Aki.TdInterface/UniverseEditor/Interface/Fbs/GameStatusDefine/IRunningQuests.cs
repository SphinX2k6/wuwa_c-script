using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B71 RID: 19313
	public struct IRunningQuests : IFlatbufferObject
	{
		// Token: 0x1700886E RID: 34926
		// (get) Token: 0x0601D60E RID: 120334 RVA: 0x00420159 File Offset: 0x0041E359
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D60F RID: 120335 RVA: 0x00420166 File Offset: 0x0041E366
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D610 RID: 120336 RVA: 0x00420170 File Offset: 0x0041E370
		public static IRunningQuests GetRootAsIRunningQuests(ByteBuffer _bb)
		{
			return IRunningQuests.GetRootAsIRunningQuests(_bb, default(IRunningQuests));
		}

		// Token: 0x0601D611 RID: 120337 RVA: 0x0042018C File Offset: 0x0041E38C
		public static IRunningQuests GetRootAsIRunningQuests(ByteBuffer _bb, IRunningQuests obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D612 RID: 120338 RVA: 0x004201A9 File Offset: 0x0041E3A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D613 RID: 120339 RVA: 0x004201B8 File Offset: 0x0041E3B8
		public IRunningQuests __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700886F RID: 34927
		// (get) Token: 0x0601D614 RID: 120340 RVA: 0x004201C8 File Offset: 0x0041E3C8
		public int TraceId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008870 RID: 34928
		// (get) Token: 0x0601D615 RID: 120341 RVA: 0x00420204 File Offset: 0x0041E404
		public IRunningTree? TraceTree
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IRunningTree?(default(IRunningTree).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601D616 RID: 120342 RVA: 0x00420264 File Offset: 0x0041E464
		public IRunningTree? Quests(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IRunningTree?(default(IRunningTree).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008871 RID: 34929
		// (get) Token: 0x0601D617 RID: 120343 RVA: 0x004202C4 File Offset: 0x0041E4C4
		public int QuestsLength
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

		// Token: 0x0601D618 RID: 120344 RVA: 0x004202EF File Offset: 0x0041E4EF
		public static Offset<IRunningQuests> CreateIRunningQuests(FlatBufferBuilder builder, int TraceId = 0, Offset<IRunningTree> TraceTreeOffset = default(Offset<IRunningTree>), VectorOffset QuestsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IRunningQuests.AddQuests(builder, QuestsOffset);
			IRunningQuests.AddTraceTree(builder, TraceTreeOffset);
			IRunningQuests.AddTraceId(builder, TraceId);
			return IRunningQuests.EndIRunningQuests(builder);
		}

		// Token: 0x0601D619 RID: 120345 RVA: 0x00420313 File Offset: 0x0041E513
		public static void StartIRunningQuests(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601D61A RID: 120346 RVA: 0x0042031C File Offset: 0x0041E51C
		public static void AddTraceId(FlatBufferBuilder builder, int traceId)
		{
			builder.AddInt(0, traceId, 0);
		}

		// Token: 0x0601D61B RID: 120347 RVA: 0x00420327 File Offset: 0x0041E527
		public static void AddTraceTree(FlatBufferBuilder builder, Offset<IRunningTree> traceTreeOffset)
		{
			builder.AddOffset(1, traceTreeOffset.Value, 0);
		}

		// Token: 0x0601D61C RID: 120348 RVA: 0x00420337 File Offset: 0x0041E537
		public static void AddQuests(FlatBufferBuilder builder, VectorOffset questsOffset)
		{
			builder.AddOffset(2, questsOffset.Value, 0);
		}

		// Token: 0x0601D61D RID: 120349 RVA: 0x00420348 File Offset: 0x0041E548
		public static VectorOffset CreateQuestsVector(FlatBufferBuilder builder, Offset<IRunningTree>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D61E RID: 120350 RVA: 0x00420388 File Offset: 0x0041E588
		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, Offset<IRunningTree>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRunningTree>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D61F RID: 120351 RVA: 0x004203A2 File Offset: 0x0041E5A2
		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRunningTree>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRunningTree>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D620 RID: 120352 RVA: 0x004203C0 File Offset: 0x0041E5C0
		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRunningTree>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D621 RID: 120353 RVA: 0x004203D9 File Offset: 0x0041E5D9
		public static void StartQuestsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D622 RID: 120354 RVA: 0x004203E4 File Offset: 0x0041E5E4
		public static Offset<IRunningQuests> EndIRunningQuests(FlatBufferBuilder builder)
		{
			return new Offset<IRunningQuests>(builder.EndTable());
		}

		// Token: 0x0601D623 RID: 120355 RVA: 0x004203F4 File Offset: 0x0041E5F4
		public IRunningQuestsT UnPack()
		{
			IRunningQuestsT runningQuestsT = new IRunningQuestsT();
			this.UnPackTo(runningQuestsT);
			return runningQuestsT;
		}

		// Token: 0x0601D624 RID: 120356 RVA: 0x00420410 File Offset: 0x0041E610
		public void UnPackTo(IRunningQuestsT _o)
		{
			_o.TraceId = this.TraceId;
			_o.TraceTree = ((this.TraceTree != null) ? this.TraceTree.Value.UnPack() : null);
			_o.Quests = new List<IRunningTreeT>();
			for (int i = 0; i < this.QuestsLength; i++)
			{
				_o.Quests.Add((this.Quests(i) != null) ? this.Quests(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601D625 RID: 120357 RVA: 0x004204AC File Offset: 0x0041E6AC
		public static Offset<IRunningQuests> Pack(FlatBufferBuilder builder, IRunningQuestsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRunningQuests>);
			}
			Offset<IRunningTree> traceTreeOffset = (_o.TraceTree == null) ? default(Offset<IRunningTree>) : IRunningTree.Pack(builder, _o.TraceTree);
			VectorOffset questsOffset = default(VectorOffset);
			if (_o.Quests != null)
			{
				Offset<IRunningTree>[] array = new Offset<IRunningTree>[_o.Quests.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IRunningTree.Pack(builder, _o.Quests[i]);
				}
				questsOffset = IRunningQuests.CreateQuestsVector(builder, array);
			}
			return IRunningQuests.CreateIRunningQuests(builder, _o.TraceId, traceTreeOffset, questsOffset);
		}

		// Token: 0x0400D3FA RID: 54266
		private Table __p;
	}
}
