using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000427 RID: 1063
	[NetMessage(EMessageId.EdgeRunnerScoreRewardRequest)]
	public sealed class EdgeRunnerScoreRewardRequest : IMessage<EdgeRunnerScoreRewardRequest>, IMessage, IEquatable<EdgeRunnerScoreRewardRequest>, IDeepCloneable<EdgeRunnerScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x06006623 RID: 26147 RVA: 0x000F5C1D File Offset: 0x000F3E1D
		[NullableContext(1)]
		public static EdgeRunnerScoreRewardRequest Create()
		{
			return new EdgeRunnerScoreRewardRequest();
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06006624 RID: 26148 RVA: 0x000F5C24 File Offset: 0x000F3E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06006625 RID: 26149 RVA: 0x000F5C27 File Offset: 0x000F3E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdgeRunnerScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x06006626 RID: 26150 RVA: 0x000F5C2E File Offset: 0x000F3E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerScoreRewardRequest()
		{
		}

		// Token: 0x06006627 RID: 26151 RVA: 0x000F5C36 File Offset: 0x000F3E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerScoreRewardRequest(EdgeRunnerScoreRewardRequest other) : this()
		{
			this.scoreId_ = other.scoreId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006628 RID: 26152 RVA: 0x000F5C5B File Offset: 0x000F3E5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdgeRunnerScoreRewardRequest Clone()
		{
			return new EdgeRunnerScoreRewardRequest(this);
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06006629 RID: 26153 RVA: 0x000F5C63 File Offset: 0x000F3E63
		// (set) Token: 0x0600662A RID: 26154 RVA: 0x000F5C6B File Offset: 0x000F3E6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ScoreId
		{
			get
			{
				return this.scoreId_;
			}
			set
			{
				this.scoreId_ = value;
			}
		}

		// Token: 0x0600662B RID: 26155 RVA: 0x000F5C74 File Offset: 0x000F3E74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdgeRunnerScoreRewardRequest);
		}

		// Token: 0x0600662C RID: 26156 RVA: 0x000F5C82 File Offset: 0x000F3E82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdgeRunnerScoreRewardRequest other)
		{
			return other != null && (other == this || (this.ScoreId == other.ScoreId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600662D RID: 26157 RVA: 0x000F5CB0 File Offset: 0x000F3EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ScoreId != 0)
			{
				num ^= this.ScoreId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600662E RID: 26158 RVA: 0x000F5CEF File Offset: 0x000F3EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600662F RID: 26159 RVA: 0x000F5CFC File Offset: 0x000F3EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006630 RID: 26160 RVA: 0x000F5D05 File Offset: 0x000F3F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ScoreId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ScoreId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006631 RID: 26161 RVA: 0x000F5D38 File Offset: 0x000F3F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ScoreId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ScoreId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006632 RID: 26162 RVA: 0x000F5D76 File Offset: 0x000F3F76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdgeRunnerScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ScoreId != 0)
			{
				this.ScoreId = other.ScoreId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006633 RID: 26163 RVA: 0x000F5DA7 File Offset: 0x000F3FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006634 RID: 26164 RVA: 0x000F5DB0 File Offset: 0x000F3FB0
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ScoreId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003913 RID: 14611
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003914 RID: 14612
		public const int ScoreIdFieldNumber = 5;

		// Token: 0x04003915 RID: 14613
		private int scoreId_;
	}
}
