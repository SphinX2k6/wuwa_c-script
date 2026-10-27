using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B6C RID: 2924
	public sealed class NpcPhantomBattleCardSelectEffectCtx : IMessage<NpcPhantomBattleCardSelectEffectCtx>, IMessage, IEquatable<NpcPhantomBattleCardSelectEffectCtx>, IDeepCloneable<NpcPhantomBattleCardSelectEffectCtx>, IBufferMessage
	{
		// Token: 0x0600FD56 RID: 64854 RVA: 0x0024E530 File Offset: 0x0024C730
		[NullableContext(1)]
		public static NpcPhantomBattleCardSelectEffectCtx Create()
		{
			return new NpcPhantomBattleCardSelectEffectCtx();
		}

		// Token: 0x170033A8 RID: 13224
		// (get) Token: 0x0600FD57 RID: 64855 RVA: 0x0024E537 File Offset: 0x0024C737
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033A9 RID: 13225
		// (get) Token: 0x0600FD58 RID: 64856 RVA: 0x0024E53A File Offset: 0x0024C73A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleCardSelectEffectCtx.Descriptor;
			}
		}

		// Token: 0x0600FD59 RID: 64857 RVA: 0x0024E541 File Offset: 0x0024C741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardSelectEffectCtx()
		{
		}

		// Token: 0x0600FD5A RID: 64858 RVA: 0x0024E549 File Offset: 0x0024C749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardSelectEffectCtx(NpcPhantomBattleCardSelectEffectCtx other) : this()
		{
			this.curHandNum_ = other.curHandNum_;
			this.cardLibraryNum_ = other.cardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FD5B RID: 64859 RVA: 0x0024E57A File Offset: 0x0024C77A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleCardSelectEffectCtx Clone()
		{
			return new NpcPhantomBattleCardSelectEffectCtx(this);
		}

		// Token: 0x170033AA RID: 13226
		// (get) Token: 0x0600FD5C RID: 64860 RVA: 0x0024E582 File Offset: 0x0024C782
		// (set) Token: 0x0600FD5D RID: 64861 RVA: 0x0024E58A File Offset: 0x0024C78A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurHandNum
		{
			get
			{
				return this.curHandNum_;
			}
			set
			{
				this.curHandNum_ = value;
			}
		}

		// Token: 0x170033AB RID: 13227
		// (get) Token: 0x0600FD5E RID: 64862 RVA: 0x0024E593 File Offset: 0x0024C793
		// (set) Token: 0x0600FD5F RID: 64863 RVA: 0x0024E59B File Offset: 0x0024C79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardLibraryNum
		{
			get
			{
				return this.cardLibraryNum_;
			}
			set
			{
				this.cardLibraryNum_ = value;
			}
		}

		// Token: 0x0600FD60 RID: 64864 RVA: 0x0024E5A4 File Offset: 0x0024C7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleCardSelectEffectCtx);
		}

		// Token: 0x0600FD61 RID: 64865 RVA: 0x0024E5B2 File Offset: 0x0024C7B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleCardSelectEffectCtx other)
		{
			return other != null && (other == this || (this.CurHandNum == other.CurHandNum && this.CardLibraryNum == other.CardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FD62 RID: 64866 RVA: 0x0024E5F0 File Offset: 0x0024C7F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurHandNum != 0)
			{
				num ^= this.CurHandNum.GetHashCode();
			}
			if (this.CardLibraryNum != 0)
			{
				num ^= this.CardLibraryNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FD63 RID: 64867 RVA: 0x0024E648 File Offset: 0x0024C848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FD64 RID: 64868 RVA: 0x0024E655 File Offset: 0x0024C855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FD65 RID: 64869 RVA: 0x0024E660 File Offset: 0x0024C860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurHandNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurHandNum);
			}
			if (this.CardLibraryNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FD66 RID: 64870 RVA: 0x0024E6B8 File Offset: 0x0024C8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurHandNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurHandNum);
			}
			if (this.CardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FD67 RID: 64871 RVA: 0x0024E710 File Offset: 0x0024C910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleCardSelectEffectCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurHandNum != 0)
			{
				this.CurHandNum = other.CurHandNum;
			}
			if (other.CardLibraryNum != 0)
			{
				this.CardLibraryNum = other.CardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FD68 RID: 64872 RVA: 0x0024E760 File Offset: 0x0024C960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FD69 RID: 64873 RVA: 0x0024E76C File Offset: 0x0024C96C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CardLibraryNum = input.ReadInt32();
					}
				}
				else
				{
					this.CurHandNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400650E RID: 25870
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400650F RID: 25871
		public const int CurHandNumFieldNumber = 1;

		// Token: 0x04006510 RID: 25872
		private int curHandNum_;

		// Token: 0x04006511 RID: 25873
		public const int CardLibraryNumFieldNumber = 2;

		// Token: 0x04006512 RID: 25874
		private int cardLibraryNum_;
	}
}
