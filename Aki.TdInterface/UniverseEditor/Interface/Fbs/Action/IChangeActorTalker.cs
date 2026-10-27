using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062C9 RID: 25289
	public struct IChangeActorTalker : IFlatbufferObject
	{
		// Token: 0x1700BCC5 RID: 48325
		// (get) Token: 0x0602BB4D RID: 179021 RVA: 0x00603CE0 File Offset: 0x00601EE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BB4E RID: 179022 RVA: 0x00603CED File Offset: 0x00601EED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BB4F RID: 179023 RVA: 0x00603CF4 File Offset: 0x00601EF4
		public static IChangeActorTalker GetRootAsIChangeActorTalker(ByteBuffer _bb)
		{
			return IChangeActorTalker.GetRootAsIChangeActorTalker(_bb, default(IChangeActorTalker));
		}

		// Token: 0x0602BB50 RID: 179024 RVA: 0x00603D10 File Offset: 0x00601F10
		public static IChangeActorTalker GetRootAsIChangeActorTalker(ByteBuffer _bb, IChangeActorTalker obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BB51 RID: 179025 RVA: 0x00603D2D File Offset: 0x00601F2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BB52 RID: 179026 RVA: 0x00603D3C File Offset: 0x00601F3C
		public IChangeActorTalker __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCC6 RID: 48326
		// (get) Token: 0x0602BB53 RID: 179027 RVA: 0x00603D4C File Offset: 0x00601F4C
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

		// Token: 0x1700BCC7 RID: 48327
		// (get) Token: 0x0602BB54 RID: 179028 RVA: 0x00603D88 File Offset: 0x00601F88
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

		// Token: 0x0602BB55 RID: 179029 RVA: 0x00603DC4 File Offset: 0x00601FC4
		public static Offset<IChangeActorTalker> CreateIChangeActorTalker(FlatBufferBuilder builder, int ActorIndex = 0, int Talker = 0)
		{
			builder.StartTable(2);
			IChangeActorTalker.AddTalker(builder, Talker);
			IChangeActorTalker.AddActorIndex(builder, ActorIndex);
			return IChangeActorTalker.EndIChangeActorTalker(builder);
		}

		// Token: 0x0602BB56 RID: 179030 RVA: 0x00603DE1 File Offset: 0x00601FE1
		public static void StartIChangeActorTalker(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BB57 RID: 179031 RVA: 0x00603DEA File Offset: 0x00601FEA
		public static void AddActorIndex(FlatBufferBuilder builder, int actorIndex)
		{
			builder.AddInt(0, actorIndex, 0);
		}

		// Token: 0x0602BB58 RID: 179032 RVA: 0x00603DF5 File Offset: 0x00601FF5
		public static void AddTalker(FlatBufferBuilder builder, int talker)
		{
			builder.AddInt(1, talker, 0);
		}

		// Token: 0x0602BB59 RID: 179033 RVA: 0x00603E00 File Offset: 0x00602000
		public static Offset<IChangeActorTalker> EndIChangeActorTalker(FlatBufferBuilder builder)
		{
			return new Offset<IChangeActorTalker>(builder.EndTable());
		}

		// Token: 0x0602BB5A RID: 179034 RVA: 0x00603E10 File Offset: 0x00602010
		public IChangeActorTalkerT UnPack()
		{
			IChangeActorTalkerT changeActorTalkerT = new IChangeActorTalkerT();
			this.UnPackTo(changeActorTalkerT);
			return changeActorTalkerT;
		}

		// Token: 0x0602BB5B RID: 179035 RVA: 0x00603E2B File Offset: 0x0060202B
		public void UnPackTo(IChangeActorTalkerT _o)
		{
			_o.ActorIndex = this.ActorIndex;
			_o.Talker = this.Talker;
		}

		// Token: 0x0602BB5C RID: 179036 RVA: 0x00603E48 File Offset: 0x00602048
		public static Offset<IChangeActorTalker> Pack(FlatBufferBuilder builder, IChangeActorTalkerT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeActorTalker>);
			}
			return IChangeActorTalker.CreateIChangeActorTalker(builder, _o.ActorIndex, _o.Talker);
		}

		// Token: 0x0401086F RID: 67695
		private Table __p;
	}
}
