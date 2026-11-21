using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200693A RID: 26938
	public struct IChangeActorTalker : IFlatbufferObject
	{
		// Token: 0x1700C64F RID: 50767
		// (get) Token: 0x0602E2B6 RID: 189110 RVA: 0x0064ECEC File Offset: 0x0064CEEC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E2B7 RID: 189111 RVA: 0x0064ECF9 File Offset: 0x0064CEF9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E2B8 RID: 189112 RVA: 0x0064ED00 File Offset: 0x0064CF00
		public static IChangeActorTalker GetRootAsIChangeActorTalker(ByteBuffer _bb)
		{
			return IChangeActorTalker.GetRootAsIChangeActorTalker(_bb, default(IChangeActorTalker));
		}

		// Token: 0x0602E2B9 RID: 189113 RVA: 0x0064ED1C File Offset: 0x0064CF1C
		public static IChangeActorTalker GetRootAsIChangeActorTalker(ByteBuffer _bb, IChangeActorTalker obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E2BA RID: 189114 RVA: 0x0064ED39 File Offset: 0x0064CF39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E2BB RID: 189115 RVA: 0x0064ED48 File Offset: 0x0064CF48
		public IChangeActorTalker __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C650 RID: 50768
		// (get) Token: 0x0602E2BC RID: 189116 RVA: 0x0064ED58 File Offset: 0x0064CF58
		public int ActorIndex
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

		// Token: 0x1700C651 RID: 50769
		// (get) Token: 0x0602E2BD RID: 189117 RVA: 0x0064ED94 File Offset: 0x0064CF94
		public int Talker
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

		// Token: 0x0602E2BE RID: 189118 RVA: 0x0064EDD0 File Offset: 0x0064CFD0
		public static Offset<IChangeActorTalker> CreateIChangeActorTalker(FlatBufferBuilder builder, int ActorIndex = 0, int Talker = 0)
		{
			builder.StartTable(2);
			IChangeActorTalker.AddTalker(builder, Talker);
			IChangeActorTalker.AddActorIndex(builder, ActorIndex);
			return IChangeActorTalker.EndIChangeActorTalker(builder);
		}

		// Token: 0x0602E2BF RID: 189119 RVA: 0x0064EDED File Offset: 0x0064CFED
		public static void StartIChangeActorTalker(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E2C0 RID: 189120 RVA: 0x0064EDF6 File Offset: 0x0064CFF6
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x0602E2C1 RID: 189121 RVA: 0x0064EE01 File Offset: 0x0064D001
		public static void AddTalker(FlatBufferBuilder builder, int talker)
		{
			builder.AddInt(1, talker, 0);
		}

		// Token: 0x0602E2C2 RID: 189122 RVA: 0x0064EE0C File Offset: 0x0064D00C
		public static Offset<IChangeActorTalker> EndIChangeActorTalker(FlatBufferBuilder builder)
		{
			return new Offset<IChangeActorTalker>(builder.EndTable());
		}

		// Token: 0x0602E2C3 RID: 189123 RVA: 0x0064EE1C File Offset: 0x0064D01C
		public IChangeActorTalkerT UnPack()
		{
			IChangeActorTalkerT changeActorTalkerT = new IChangeActorTalkerT();
			this.UnPackTo(changeActorTalkerT);
			return changeActorTalkerT;
		}

		// Token: 0x0602E2C4 RID: 189124 RVA: 0x0064EE37 File Offset: 0x0064D037
		public void UnPackTo(IChangeActorTalkerT _o)
		{
			_o.ActorIndex = this.ActorIndex;
			_o.Talker = this.Talker;
		}

		// Token: 0x0602E2C5 RID: 189125 RVA: 0x0064EE54 File Offset: 0x0064D054
		public static Offset<IChangeActorTalker> Pack(FlatBufferBuilder builder, IChangeActorTalkerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeActorTalker>);
			}
			return IChangeActorTalker.CreateIChangeActorTalker(builder, _o.ActorIndex, _o.Talker);
		}

		// Token: 0x04011685 RID: 71301
		private Table __p;
	}
}
