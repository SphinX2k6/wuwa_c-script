using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004709 RID: 18185
	public struct IRunningQuests : IFlatbufferObject
	{
		// Token: 0x1700822D RID: 33325
		// (get) Token: 0x0601BE39 RID: 114233 RVA: 0x003F3EBD File Offset: 0x003F20BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BE3A RID: 114234 RVA: 0x003F3ECA File Offset: 0x003F20CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BE3B RID: 114235 RVA: 0x003F3ED4 File Offset: 0x003F20D4
		public static IRunningQuests GetRootAsIRunningQuests(ByteBuffer _bb)
		{
			return IRunningQuests.GetRootAsIRunningQuests(_bb, default(IRunningQuests));
		}

		// Token: 0x0601BE3C RID: 114236 RVA: 0x003F3EF0 File Offset: 0x003F20F0
		public static IRunningQuests GetRootAsIRunningQuests(ByteBuffer _bb, IRunningQuests obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BE3D RID: 114237 RVA: 0x003F3F0D File Offset: 0x003F210D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BE3E RID: 114238 RVA: 0x003F3F1C File Offset: 0x003F211C
		public IRunningQuests __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700822E RID: 33326
		// (get) Token: 0x0601BE3F RID: 114239 RVA: 0x003F3F2C File Offset: 0x003F212C
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

		// Token: 0x1700822F RID: 33327
		// (get) Token: 0x0601BE40 RID: 114240 RVA: 0x003F3F68 File Offset: 0x003F2168
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

		// Token: 0x0601BE41 RID: 114241 RVA: 0x003F3FC8 File Offset: 0x003F21C8
		public IRunningTree? Quests(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IRunningTree?(default(IRunningTree).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008230 RID: 33328
		// (get) Token: 0x0601BE42 RID: 114242 RVA: 0x003F4028 File Offset: 0x003F2228
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

		// Token: 0x0601BE43 RID: 114243 RVA: 0x003F4053 File Offset: 0x003F2253
		public static Offset<IRunningQuests> CreateIRunningQuests(FlatBufferBuilder builder, int TraceId = 0, Offset<IRunningTree> TraceTreeOffset = default(Offset<IRunningTree>), VectorOffset QuestsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IRunningQuests.AddQuests(builder, QuestsOffset);
			IRunningQuests.AddTraceTree(builder, TraceTreeOffset);
			IRunningQuests.AddTraceId(builder, TraceId);
			return IRunningQuests.EndIRunningQuests(builder);
		}

		// Token: 0x0601BE44 RID: 114244 RVA: 0x003F4077 File Offset: 0x003F2277
		public static void StartIRunningQuests(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601BE45 RID: 114245 RVA: 0x003F4080 File Offset: 0x003F2280
		public static void AddTraceId(FlatBufferBuilder builder, int traceId)
		{
			builder.AddInt(0, traceId, 0);
		}

		// Token: 0x0601BE46 RID: 114246 RVA: 0x003F408B File Offset: 0x003F228B
		public static void AddTraceTree(FlatBufferBuilder builder, Offset<IRunningTree> traceTreeOffset)
		{
			builder.AddOffset(1, traceTreeOffset.Value, 0);
		}

		// Token: 0x0601BE47 RID: 114247 RVA: 0x003F409B File Offset: 0x003F229B
		public static void AddQuests(FlatBufferBuilder builder, VectorOffset questsOffset)
		{
			builder.AddOffset(2, questsOffset.Value, 0);
		}

		// Token: 0x0601BE48 RID: 114248 RVA: 0x003F40AC File Offset: 0x003F22AC
		public static VectorOffset CreateQuestsVector(FlatBufferBuilder builder, Offset<IRunningTree>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BE49 RID: 114249 RVA: 0x003F40EC File Offset: 0x003F22EC
		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, Offset<IRunningTree>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IRunningTree>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BE4A RID: 114250 RVA: 0x003F4106 File Offset: 0x003F2306
		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IRunningTree>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IRunningTree>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BE4B RID: 114251 RVA: 0x003F4124 File Offset: 0x003F2324
		public static VectorOffset CreateQuestsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IRunningTree>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BE4C RID: 114252 RVA: 0x003F413D File Offset: 0x003F233D
		public static void StartQuestsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BE4D RID: 114253 RVA: 0x003F4148 File Offset: 0x003F2348
		public static Offset<IRunningQuests> EndIRunningQuests(FlatBufferBuilder builder)
		{
			return new Offset<IRunningQuests>(builder.EndTable());
		}

		// Token: 0x0601BE4E RID: 114254 RVA: 0x003F4158 File Offset: 0x003F2358
		public IRunningQuestsT UnPack()
		{
			IRunningQuestsT runningQuestsT = new IRunningQuestsT();
			this.UnPackTo(runningQuestsT);
			return runningQuestsT;
		}

		// Token: 0x0601BE4F RID: 114255 RVA: 0x003F4174 File Offset: 0x003F2374
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

		// Token: 0x0601BE50 RID: 114256 RVA: 0x003F4210 File Offset: 0x003F2410
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

		// Token: 0x0400C9CB RID: 51659
		private Table __p;
	}
}
