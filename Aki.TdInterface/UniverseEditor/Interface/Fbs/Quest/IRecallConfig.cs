using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004082 RID: 16514
	public struct IRecallConfig : IFlatbufferObject
	{
		// Token: 0x1700748D RID: 29837
		// (get) Token: 0x0601805B RID: 98395 RVA: 0x00377336 File Offset: 0x00375536
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601805C RID: 98396 RVA: 0x00377343 File Offset: 0x00375543
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601805D RID: 98397 RVA: 0x0037734C File Offset: 0x0037554C
		public static IRecallConfig GetRootAsIRecallConfig(ByteBuffer _bb)
		{
			return IRecallConfig.GetRootAsIRecallConfig(_bb, default(IRecallConfig));
		}

		// Token: 0x0601805E RID: 98398 RVA: 0x00377368 File Offset: 0x00375568
		public static IRecallConfig GetRootAsIRecallConfig(ByteBuffer _bb, IRecallConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601805F RID: 98399 RVA: 0x00377385 File Offset: 0x00375585
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018060 RID: 98400 RVA: 0x00377394 File Offset: 0x00375594
		public IRecallConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700748E RID: 29838
		// (get) Token: 0x06018061 RID: 98401 RVA: 0x003773A4 File Offset: 0x003755A4
		public int RecallId
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

		// Token: 0x06018062 RID: 98402 RVA: 0x003773E0 File Offset: 0x003755E0
		public static Offset<IRecallConfig> CreateIRecallConfig(FlatBufferBuilder builder, int RecallId = 0)
		{
			builder.StartTable(1);
			IRecallConfig.AddRecallId(builder, RecallId);
			return IRecallConfig.EndIRecallConfig(builder);
		}

		// Token: 0x06018063 RID: 98403 RVA: 0x003773F6 File Offset: 0x003755F6
		public static void StartIRecallConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06018064 RID: 98404 RVA: 0x003773FF File Offset: 0x003755FF
		public static void AddRecallId(FlatBufferBuilder builder, int recallId)
		{
			builder.AddInt(0, recallId, 0);
		}

		// Token: 0x06018065 RID: 98405 RVA: 0x0037740A File Offset: 0x0037560A
		public static Offset<IRecallConfig> EndIRecallConfig(FlatBufferBuilder builder)
		{
			return new Offset<IRecallConfig>(builder.EndTable());
		}

		// Token: 0x06018066 RID: 98406 RVA: 0x00377418 File Offset: 0x00375618
		public IRecallConfigT UnPack()
		{
			IRecallConfigT recallConfigT = new IRecallConfigT();
			this.UnPackTo(recallConfigT);
			return recallConfigT;
		}

		// Token: 0x06018067 RID: 98407 RVA: 0x00377433 File Offset: 0x00375633
		public void UnPackTo(IRecallConfigT _o)
		{
			_o.RecallId = this.RecallId;
		}

		// Token: 0x06018068 RID: 98408 RVA: 0x00377444 File Offset: 0x00375644
		public static Offset<IRecallConfig> Pack(FlatBufferBuilder builder, IRecallConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRecallConfig>);
			}
			return IRecallConfig.CreateIRecallConfig(builder, _o.RecallId);
		}

		// Token: 0x0400BC08 RID: 48136
		private Table __p;
	}
}
