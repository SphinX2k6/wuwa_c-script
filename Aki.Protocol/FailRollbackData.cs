using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000503 RID: 1283
	public sealed class FailRollbackData : IMessage<FailRollbackData>, IMessage, IEquatable<FailRollbackData>, IDeepCloneable<FailRollbackData>, IBufferMessage
	{
		// Token: 0x06007929 RID: 31017 RVA: 0x00126F00 File Offset: 0x00125100
		[NullableContext(1)]
		public static FailRollbackData Create()
		{
			return new FailRollbackData();
		}

		// Token: 0x17001779 RID: 6009
		// (get) Token: 0x0600792A RID: 31018 RVA: 0x00126F07 File Offset: 0x00125107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x0600792B RID: 31019 RVA: 0x00126F0A File Offset: 0x0012510A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FailRollbackData.Descriptor;
			}
		}

		// Token: 0x0600792C RID: 31020 RVA: 0x00126F11 File Offset: 0x00125111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FailRollbackData()
		{
		}

		// Token: 0x0600792D RID: 31021 RVA: 0x00126F19 File Offset: 0x00125119
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FailRollbackData(FailRollbackData other) : this()
		{
			this.failNodeId_ = other.failNodeId_;
			this.failReason_ = other.failReason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600792E RID: 31022 RVA: 0x00126F4A File Offset: 0x0012514A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FailRollbackData Clone()
		{
			return new FailRollbackData(this);
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x0600792F RID: 31023 RVA: 0x00126F52 File Offset: 0x00125152
		// (set) Token: 0x06007930 RID: 31024 RVA: 0x00126F5A File Offset: 0x0012515A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FailNodeId
		{
			get
			{
				return this.failNodeId_;
			}
			set
			{
				this.failNodeId_ = value;
			}
		}

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06007931 RID: 31025 RVA: 0x00126F63 File Offset: 0x00125163
		// (set) Token: 0x06007932 RID: 31026 RVA: 0x00126F6B File Offset: 0x0012516B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FailReason FailReason
		{
			get
			{
				return this.failReason_;
			}
			set
			{
				this.failReason_ = value;
			}
		}

		// Token: 0x06007933 RID: 31027 RVA: 0x00126F74 File Offset: 0x00125174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FailRollbackData);
		}

		// Token: 0x06007934 RID: 31028 RVA: 0x00126F82 File Offset: 0x00125182
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FailRollbackData other)
		{
			return other != null && (other == this || (this.FailNodeId == other.FailNodeId && this.FailReason == other.FailReason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007935 RID: 31029 RVA: 0x00126FC0 File Offset: 0x001251C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FailNodeId != 0)
			{
				num ^= this.FailNodeId.GetHashCode();
			}
			if (this.FailReason != FailReason.DefaultFail)
			{
				num ^= this.FailReason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007936 RID: 31030 RVA: 0x0012701E File Offset: 0x0012521E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007937 RID: 31031 RVA: 0x0012702B File Offset: 0x0012522B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007938 RID: 31032 RVA: 0x00127034 File Offset: 0x00125234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FailNodeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FailNodeId);
			}
			if (this.FailReason != FailReason.DefaultFail)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.FailReason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007939 RID: 31033 RVA: 0x0012708C File Offset: 0x0012528C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FailNodeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FailNodeId);
			}
			if (this.FailReason != FailReason.DefaultFail)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.FailReason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600793A RID: 31034 RVA: 0x001270E4 File Offset: 0x001252E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FailRollbackData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FailNodeId != 0)
			{
				this.FailNodeId = other.FailNodeId;
			}
			if (other.FailReason != FailReason.DefaultFail)
			{
				this.FailReason = other.FailReason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600793B RID: 31035 RVA: 0x00127134 File Offset: 0x00125334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600793C RID: 31036 RVA: 0x00127140 File Offset: 0x00125340
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
						this.FailReason = (FailReason)input.ReadEnum();
					}
				}
				else
				{
					this.FailNodeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003EEA RID: 16106
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EEB RID: 16107
		public const int FailNodeIdFieldNumber = 1;

		// Token: 0x04003EEC RID: 16108
		private int failNodeId_;

		// Token: 0x04003EED RID: 16109
		public const int FailReasonFieldNumber = 2;

		// Token: 0x04003EEE RID: 16110
		private FailReason failReason_;
	}
}
