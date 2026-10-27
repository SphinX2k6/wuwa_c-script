using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EB2 RID: 28338
	public struct IRestoreAiBehaviorTree : IFlatbufferObject
	{
		// Token: 0x1700D2F6 RID: 54006
		// (get) Token: 0x06032163 RID: 205155 RVA: 0x006C5D07 File Offset: 0x006C3F07
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06032164 RID: 205156 RVA: 0x006C5D14 File Offset: 0x006C3F14
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06032165 RID: 205157 RVA: 0x006C5D1C File Offset: 0x006C3F1C
		public static IRestoreAiBehaviorTree GetRootAsIRestoreAiBehaviorTree(ByteBuffer _bb)
		{
			return IRestoreAiBehaviorTree.GetRootAsIRestoreAiBehaviorTree(_bb, default(IRestoreAiBehaviorTree));
		}

		// Token: 0x06032166 RID: 205158 RVA: 0x006C5D38 File Offset: 0x006C3F38
		public static IRestoreAiBehaviorTree GetRootAsIRestoreAiBehaviorTree(ByteBuffer _bb, IRestoreAiBehaviorTree obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06032167 RID: 205159 RVA: 0x006C5D55 File Offset: 0x006C3F55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06032168 RID: 205160 RVA: 0x006C5D64 File Offset: 0x006C3F64
		public IRestoreAiBehaviorTree __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D2F7 RID: 54007
		// (get) Token: 0x06032169 RID: 205161 RVA: 0x006C5D74 File Offset: 0x006C3F74
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

		// Token: 0x0603216A RID: 205162 RVA: 0x006C5DAB File Offset: 0x006C3FAB
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0603216B RID: 205163 RVA: 0x006C5DBA File Offset: 0x006C3FBA
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x0603216C RID: 205164 RVA: 0x006C5DC8 File Offset: 0x006C3FC8
		public static Offset<IRestoreAiBehaviorTree> CreateIRestoreAiBehaviorTree(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IRestoreAiBehaviorTree.AddKey(builder, KeyOffset);
			return IRestoreAiBehaviorTree.EndIRestoreAiBehaviorTree(builder);
		}

		// Token: 0x0603216D RID: 205165 RVA: 0x006C5DDE File Offset: 0x006C3FDE
		public static void StartIRestoreAiBehaviorTree(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0603216E RID: 205166 RVA: 0x006C5DE7 File Offset: 0x006C3FE7
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0603216F RID: 205167 RVA: 0x006C5DF7 File Offset: 0x006C3FF7
		public static Offset<IRestoreAiBehaviorTree> EndIRestoreAiBehaviorTree(FlatBufferBuilder builder)
		{
			return new Offset<IRestoreAiBehaviorTree>(builder.EndTable());
		}

		// Token: 0x06032170 RID: 205168 RVA: 0x006C5E04 File Offset: 0x006C4004
		public IRestoreAiBehaviorTreeT UnPack()
		{
			IRestoreAiBehaviorTreeT restoreAiBehaviorTreeT = new IRestoreAiBehaviorTreeT();
			this.UnPackTo(restoreAiBehaviorTreeT);
			return restoreAiBehaviorTreeT;
		}

		// Token: 0x06032171 RID: 205169 RVA: 0x006C5E1F File Offset: 0x006C401F
		public void UnPackTo(IRestoreAiBehaviorTreeT _o)
		{
			_o.Key = this.Key;
		}

		// Token: 0x06032172 RID: 205170 RVA: 0x006C5E30 File Offset: 0x006C4030
		public static Offset<IRestoreAiBehaviorTree> Pack(FlatBufferBuilder builder, IRestoreAiBehaviorTreeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRestoreAiBehaviorTree>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			return IRestoreAiBehaviorTree.CreateIRestoreAiBehaviorTree(builder, keyOffset);
		}

		// Token: 0x040118A8 RID: 71848
		private Table __p;
	}
}
