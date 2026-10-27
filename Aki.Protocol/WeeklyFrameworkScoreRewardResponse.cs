using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200150F RID: 5391
	[NetMessage(EMessageId.WeeklyFrameworkScoreRewardResponse)]
	public sealed class WeeklyFrameworkScoreRewardResponse : IMessage<WeeklyFrameworkScoreRewardResponse>, IMessage, IEquatable<WeeklyFrameworkScoreRewardResponse>, IDeepCloneable<WeeklyFrameworkScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0601C7DB RID: 116699 RVA: 0x0041D5F1 File Offset: 0x0041B7F1
		[NullableContext(1)]
		public static WeeklyFrameworkScoreRewardResponse Create()
		{
			return new WeeklyFrameworkScoreRewardResponse();
		}

		// Token: 0x1700600A RID: 24586
		// (get) Token: 0x0601C7DC RID: 116700 RVA: 0x0041D5F8 File Offset: 0x0041B7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700600B RID: 24587
		// (get) Token: 0x0601C7DD RID: 116701 RVA: 0x0041D5FB File Offset: 0x0041B7FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeeklyFrameworkScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601C7DE RID: 116702 RVA: 0x0041D602 File Offset: 0x0041B802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkScoreRewardResponse()
		{
		}

		// Token: 0x0601C7DF RID: 116703 RVA: 0x0041D60A File Offset: 0x0041B80A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkScoreRewardResponse(WeeklyFrameworkScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C7E0 RID: 116704 RVA: 0x0041D62F File Offset: 0x0041B82F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkScoreRewardResponse Clone()
		{
			return new WeeklyFrameworkScoreRewardResponse(this);
		}

		// Token: 0x1700600C RID: 24588
		// (get) Token: 0x0601C7E1 RID: 116705 RVA: 0x0041D637 File Offset: 0x0041B837
		// (set) Token: 0x0601C7E2 RID: 116706 RVA: 0x0041D63F File Offset: 0x0041B83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x0601C7E3 RID: 116707 RVA: 0x0041D648 File Offset: 0x0041B848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeeklyFrameworkScoreRewardResponse);
		}

		// Token: 0x0601C7E4 RID: 116708 RVA: 0x0041D656 File Offset: 0x0041B856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeeklyFrameworkScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C7E5 RID: 116709 RVA: 0x0041D684 File Offset: 0x0041B884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C7E6 RID: 116710 RVA: 0x0041D6C9 File Offset: 0x0041B8C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C7E7 RID: 116711 RVA: 0x0041D6D6 File Offset: 0x0041B8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C7E8 RID: 116712 RVA: 0x0041D6DF File Offset: 0x0041B8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C7E9 RID: 116713 RVA: 0x0041D714 File Offset: 0x0041B914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C7EA RID: 116714 RVA: 0x0041D752 File Offset: 0x0041B952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeeklyFrameworkScoreRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C7EB RID: 116715 RVA: 0x0041D783 File Offset: 0x0041B983
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C7EC RID: 116716 RVA: 0x0041D78C File Offset: 0x0041B98C
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A30C RID: 41740
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A30D RID: 41741
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x0400A30E RID: 41742
		private ErrorCode errorCode_;
	}
}
