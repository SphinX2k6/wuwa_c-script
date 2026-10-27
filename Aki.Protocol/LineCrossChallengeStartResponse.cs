using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000925 RID: 2341
	[NetMessage(EMessageId.LineCrossChallengeStartResponse)]
	public sealed class LineCrossChallengeStartResponse : IMessage<LineCrossChallengeStartResponse>, IMessage, IEquatable<LineCrossChallengeStartResponse>, IDeepCloneable<LineCrossChallengeStartResponse>, IBufferMessage
	{
		// Token: 0x0600CE84 RID: 52868 RVA: 0x001E6BE9 File Offset: 0x001E4DE9
		[NullableContext(1)]
		public static LineCrossChallengeStartResponse Create()
		{
			return new LineCrossChallengeStartResponse();
		}

		// Token: 0x170029B9 RID: 10681
		// (get) Token: 0x0600CE85 RID: 52869 RVA: 0x001E6BF0 File Offset: 0x001E4DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029BA RID: 10682
		// (get) Token: 0x0600CE86 RID: 52870 RVA: 0x001E6BF3 File Offset: 0x001E4DF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LineCrossChallengeStartResponse.Descriptor;
			}
		}

		// Token: 0x0600CE87 RID: 52871 RVA: 0x001E6BFA File Offset: 0x001E4DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeStartResponse()
		{
		}

		// Token: 0x0600CE88 RID: 52872 RVA: 0x001E6C02 File Offset: 0x001E4E02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeStartResponse(LineCrossChallengeStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE89 RID: 52873 RVA: 0x001E6C27 File Offset: 0x001E4E27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LineCrossChallengeStartResponse Clone()
		{
			return new LineCrossChallengeStartResponse(this);
		}

		// Token: 0x170029BB RID: 10683
		// (get) Token: 0x0600CE8A RID: 52874 RVA: 0x001E6C2F File Offset: 0x001E4E2F
		// (set) Token: 0x0600CE8B RID: 52875 RVA: 0x001E6C37 File Offset: 0x001E4E37
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

		// Token: 0x0600CE8C RID: 52876 RVA: 0x001E6C40 File Offset: 0x001E4E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LineCrossChallengeStartResponse);
		}

		// Token: 0x0600CE8D RID: 52877 RVA: 0x001E6C4E File Offset: 0x001E4E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LineCrossChallengeStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CE8E RID: 52878 RVA: 0x001E6C7C File Offset: 0x001E4E7C
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

		// Token: 0x0600CE8F RID: 52879 RVA: 0x001E6CC1 File Offset: 0x001E4EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CE90 RID: 52880 RVA: 0x001E6CCE File Offset: 0x001E4ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CE91 RID: 52881 RVA: 0x001E6CD7 File Offset: 0x001E4ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CE92 RID: 52882 RVA: 0x001E6D0C File Offset: 0x001E4F0C
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

		// Token: 0x0600CE93 RID: 52883 RVA: 0x001E6D4A File Offset: 0x001E4F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LineCrossChallengeStartResponse other)
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

		// Token: 0x0600CE94 RID: 52884 RVA: 0x001E6D7B File Offset: 0x001E4F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CE95 RID: 52885 RVA: 0x001E6D84 File Offset: 0x001E4F84
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005745 RID: 22341
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005746 RID: 22342
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005747 RID: 22343
		private ErrorCode errorCode_;
	}
}
