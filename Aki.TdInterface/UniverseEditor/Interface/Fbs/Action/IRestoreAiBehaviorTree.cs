using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007636 RID: 30262
	public struct IRestoreAiBehaviorTree : IFlatbufferObject
	{
		// Token: 0x1700DE4D RID: 56909
		// (get) Token: 0x060351A3 RID: 217507 RVA: 0x00721A3B File Offset: 0x0071FC3B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060351A4 RID: 217508 RVA: 0x00721A48 File Offset: 0x0071FC48
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060351A5 RID: 217509 RVA: 0x00721A50 File Offset: 0x0071FC50
		public static IRestoreAiBehaviorTree GetRootAsIRestoreAiBehaviorTree(ByteBuffer _bb)
		{
			return IRestoreAiBehaviorTree.GetRootAsIRestoreAiBehaviorTree(_bb, default(IRestoreAiBehaviorTree));
		}

		// Token: 0x060351A6 RID: 217510 RVA: 0x00721A6C File Offset: 0x0071FC6C
		public static IRestoreAiBehaviorTree GetRootAsIRestoreAiBehaviorTree(ByteBuffer _bb, IRestoreAiBehaviorTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060351A7 RID: 217511 RVA: 0x00721A89 File Offset: 0x0071FC89
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060351A8 RID: 217512 RVA: 0x00721A98 File Offset: 0x0071FC98
		public IRestoreAiBehaviorTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DE4E RID: 56910
		// (get) Token: 0x060351A9 RID: 217513 RVA: 0x00721AA8 File Offset: 0x0071FCA8
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060351AA RID: 217514 RVA: 0x00721ADF File Offset: 0x0071FCDF
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060351AB RID: 217515 RVA: 0x00721AEE File Offset: 0x0071FCEE
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x060351AC RID: 217516 RVA: 0x00721AFC File Offset: 0x0071FCFC
		public static Offset<IRestoreAiBehaviorTree> CreateIRestoreAiBehaviorTree(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IRestoreAiBehaviorTree.AddKey(builder, KeyOffset);
			return IRestoreAiBehaviorTree.EndIRestoreAiBehaviorTree(builder);
		}

		// Token: 0x060351AD RID: 217517 RVA: 0x00721B12 File Offset: 0x0071FD12
		public static void StartIRestoreAiBehaviorTree(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060351AE RID: 217518 RVA: 0x00721B1B File Offset: 0x0071FD1B
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x060351AF RID: 217519 RVA: 0x00721B2B File Offset: 0x0071FD2B
		public static Offset<IRestoreAiBehaviorTree> EndIRestoreAiBehaviorTree(FlatBufferBuilder builder)
		{
			return new Offset<IRestoreAiBehaviorTree>(builder.EndTable());
		}

		// Token: 0x060351B0 RID: 217520 RVA: 0x00721B38 File Offset: 0x0071FD38
		public IRestoreAiBehaviorTreeT UnPack()
		{
			IRestoreAiBehaviorTreeT restoreAiBehaviorTreeT = new IRestoreAiBehaviorTreeT();
			this.UnPackTo(restoreAiBehaviorTreeT);
			return restoreAiBehaviorTreeT;
		}

		// Token: 0x060351B1 RID: 217521 RVA: 0x00721B53 File Offset: 0x0071FD53
		public void UnPackTo(IRestoreAiBehaviorTreeT _o)
		{
			_o.Key = this.Key;
		}

		// Token: 0x060351B2 RID: 217522 RVA: 0x00721B64 File Offset: 0x0071FD64
		public static Offset<IRestoreAiBehaviorTree> Pack(FlatBufferBuilder builder, IRestoreAiBehaviorTreeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRestoreAiBehaviorTree>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IRestoreAiBehaviorTree.CreateIRestoreAiBehaviorTree(builder, keyOffset);
		}

		// Token: 0x0401282D RID: 75821
		private Table __p;
	}
}
