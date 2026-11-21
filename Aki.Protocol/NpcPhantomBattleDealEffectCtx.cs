using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B5E RID: 2910
	public sealed class NpcPhantomBattleDealEffectCtx : IMessage<NpcPhantomBattleDealEffectCtx>, IMessage, IEquatable<NpcPhantomBattleDealEffectCtx>, IDeepCloneable<NpcPhantomBattleDealEffectCtx>, IBufferMessage
	{
		// Token: 0x0600FC84 RID: 64644 RVA: 0x0024CF2B File Offset: 0x0024B12B
		[NullableContext(1)]
		public static NpcPhantomBattleDealEffectCtx Create()
		{
			return new NpcPhantomBattleDealEffectCtx();
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0600FC85 RID: 64645 RVA: 0x0024CF32 File Offset: 0x0024B132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x0600FC86 RID: 64646 RVA: 0x0024CF35 File Offset: 0x0024B135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleDealEffectCtx.Descriptor;
			}
		}

		// Token: 0x0600FC87 RID: 64647 RVA: 0x0024CF3C File Offset: 0x0024B13C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDealEffectCtx()
		{
		}

		// Token: 0x0600FC88 RID: 64648 RVA: 0x0024CF44 File Offset: 0x0024B144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDealEffectCtx(NpcPhantomBattleDealEffectCtx other) : this()
		{
			this.curHandNum_ = other.curHandNum_;
			this.cardLibraryNum_ = other.cardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FC89 RID: 64649 RVA: 0x0024CF75 File Offset: 0x0024B175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDealEffectCtx Clone()
		{
			return new NpcPhantomBattleDealEffectCtx(this);
		}

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x0600FC8A RID: 64650 RVA: 0x0024CF7D File Offset: 0x0024B17D
		// (set) Token: 0x0600FC8B RID: 64651 RVA: 0x0024CF85 File Offset: 0x0024B185
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

		// Token: 0x1700337F RID: 13183
		// (get) Token: 0x0600FC8C RID: 64652 RVA: 0x0024CF8E File Offset: 0x0024B18E
		// (set) Token: 0x0600FC8D RID: 64653 RVA: 0x0024CF96 File Offset: 0x0024B196
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

		// Token: 0x0600FC8E RID: 64654 RVA: 0x0024CF9F File Offset: 0x0024B19F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleDealEffectCtx);
		}

		// Token: 0x0600FC8F RID: 64655 RVA: 0x0024CFAD File Offset: 0x0024B1AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleDealEffectCtx other)
		{
			return other != null && (other == this || (this.CurHandNum == other.CurHandNum && this.CardLibraryNum == other.CardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FC90 RID: 64656 RVA: 0x0024CFEC File Offset: 0x0024B1EC
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

		// Token: 0x0600FC91 RID: 64657 RVA: 0x0024D044 File Offset: 0x0024B244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC92 RID: 64658 RVA: 0x0024D051 File Offset: 0x0024B251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC93 RID: 64659 RVA: 0x0024D05C File Offset: 0x0024B25C
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

		// Token: 0x0600FC94 RID: 64660 RVA: 0x0024D0B4 File Offset: 0x0024B2B4
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

		// Token: 0x0600FC95 RID: 64661 RVA: 0x0024D10C File Offset: 0x0024B30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleDealEffectCtx other)
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

		// Token: 0x0600FC96 RID: 64662 RVA: 0x0024D15C File Offset: 0x0024B35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FC97 RID: 64663 RVA: 0x0024D168 File Offset: 0x0024B368
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

		// Token: 0x04006533 RID: 25907
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006534 RID: 25908
		public const int CurHandNumFieldNumber = 1;

		// Token: 0x04006535 RID: 25909
		private int curHandNum_;

		// Token: 0x04006536 RID: 25910
		public const int CardLibraryNumFieldNumber = 2;

		// Token: 0x04006537 RID: 25911
		private int cardLibraryNum_;
	}
}
