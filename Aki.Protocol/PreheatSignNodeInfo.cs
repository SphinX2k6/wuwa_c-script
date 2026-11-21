using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DBD RID: 3517
	public sealed class PreheatSignNodeInfo : IMessage<PreheatSignNodeInfo>, IMessage, IEquatable<PreheatSignNodeInfo>, IDeepCloneable<PreheatSignNodeInfo>, IBufferMessage
	{
		// Token: 0x06012F6A RID: 77674 RVA: 0x002C43FD File Offset: 0x002C25FD
		[NullableContext(1)]
		public static PreheatSignNodeInfo Create()
		{
			return new PreheatSignNodeInfo();
		}

		// Token: 0x17003EF1 RID: 16113
		// (get) Token: 0x06012F6B RID: 77675 RVA: 0x002C4404 File Offset: 0x002C2604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PreheatSignNodeInfo> Parser
		{
			get
			{
				return PreheatSignNodeInfo._parser;
			}
		}

		// Token: 0x17003EF2 RID: 16114
		// (get) Token: 0x06012F6C RID: 77676 RVA: 0x002C440B File Offset: 0x002C260B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EF3 RID: 16115
		// (get) Token: 0x06012F6D RID: 77677 RVA: 0x002C440E File Offset: 0x002C260E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreheatSignNodeInfo.Descriptor;
			}
		}

		// Token: 0x06012F6E RID: 77678 RVA: 0x002C4415 File Offset: 0x002C2615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignNodeInfo()
		{
		}

		// Token: 0x06012F6F RID: 77679 RVA: 0x002C441D File Offset: 0x002C261D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignNodeInfo(PreheatSignNodeInfo other) : this()
		{
			this.preheatNodeId_ = other.preheatNodeId_;
			this.unlockTime_ = other.unlockTime_;
			this.rewarded_ = other.rewarded_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012F70 RID: 77680 RVA: 0x002C445A File Offset: 0x002C265A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignNodeInfo Clone()
		{
			return new PreheatSignNodeInfo(this);
		}

		// Token: 0x17003EF4 RID: 16116
		// (get) Token: 0x06012F71 RID: 77681 RVA: 0x002C4462 File Offset: 0x002C2662
		// (set) Token: 0x06012F72 RID: 77682 RVA: 0x002C446A File Offset: 0x002C266A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PreheatNodeId
		{
			get
			{
				return this.preheatNodeId_;
			}
			set
			{
				this.preheatNodeId_ = value;
			}
		}

		// Token: 0x17003EF5 RID: 16117
		// (get) Token: 0x06012F73 RID: 77683 RVA: 0x002C4473 File Offset: 0x002C2673
		// (set) Token: 0x06012F74 RID: 77684 RVA: 0x002C447B File Offset: 0x002C267B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long UnlockTime
		{
			get
			{
				return this.unlockTime_;
			}
			set
			{
				this.unlockTime_ = value;
			}
		}

		// Token: 0x17003EF6 RID: 16118
		// (get) Token: 0x06012F75 RID: 77685 RVA: 0x002C4484 File Offset: 0x002C2684
		// (set) Token: 0x06012F76 RID: 77686 RVA: 0x002C448C File Offset: 0x002C268C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Rewarded
		{
			get
			{
				return this.rewarded_;
			}
			set
			{
				this.rewarded_ = value;
			}
		}

		// Token: 0x06012F77 RID: 77687 RVA: 0x002C4495 File Offset: 0x002C2695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreheatSignNodeInfo);
		}

		// Token: 0x06012F78 RID: 77688 RVA: 0x002C44A4 File Offset: 0x002C26A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreheatSignNodeInfo other)
		{
			return other != null && (other == this || (this.PreheatNodeId == other.PreheatNodeId && this.UnlockTime == other.UnlockTime && this.Rewarded == other.Rewarded && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012F79 RID: 77689 RVA: 0x002C4500 File Offset: 0x002C2700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PreheatNodeId != 0)
			{
				num ^= this.PreheatNodeId.GetHashCode();
			}
			if (this.UnlockTime != 0L)
			{
				num ^= this.UnlockTime.GetHashCode();
			}
			if (this.Rewarded)
			{
				num ^= this.Rewarded.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012F7A RID: 77690 RVA: 0x002C4571 File Offset: 0x002C2771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012F7B RID: 77691 RVA: 0x002C457E File Offset: 0x002C277E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012F7C RID: 77692 RVA: 0x002C4588 File Offset: 0x002C2788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PreheatNodeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PreheatNodeId);
			}
			if (this.UnlockTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.UnlockTime);
			}
			if (this.Rewarded)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.Rewarded);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012F7D RID: 77693 RVA: 0x002C45FC File Offset: 0x002C27FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PreheatNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PreheatNodeId);
			}
			if (this.UnlockTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.UnlockTime);
			}
			if (this.Rewarded)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012F7E RID: 77694 RVA: 0x002C4660 File Offset: 0x002C2860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PreheatSignNodeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PreheatNodeId != 0)
			{
				this.PreheatNodeId = other.PreheatNodeId;
			}
			if (other.UnlockTime != 0L)
			{
				this.UnlockTime = other.UnlockTime;
			}
			if (other.Rewarded)
			{
				this.Rewarded = other.Rewarded;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012F7F RID: 77695 RVA: 0x002C46C4 File Offset: 0x002C28C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012F80 RID: 77696 RVA: 0x002C46D0 File Offset: 0x002C28D0
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Rewarded = input.ReadBool();
						}
					}
					else
					{
						this.UnlockTime = input.ReadInt64();
					}
				}
				else
				{
					this.PreheatNodeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400759A RID: 30106
		private static readonly MessageParser<PreheatSignNodeInfo> _parser = new MessageParser<PreheatSignNodeInfo>(() => new PreheatSignNodeInfo());

		// Token: 0x0400759B RID: 30107
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400759C RID: 30108
		public const int PreheatNodeIdFieldNumber = 1;

		// Token: 0x0400759D RID: 30109
		private int preheatNodeId_;

		// Token: 0x0400759E RID: 30110
		public const int UnlockTimeFieldNumber = 2;

		// Token: 0x0400759F RID: 30111
		private long unlockTime_;

		// Token: 0x040075A0 RID: 30112
		public const int RewardedFieldNumber = 3;

		// Token: 0x040075A1 RID: 30113
		private bool rewarded_;
	}
}
