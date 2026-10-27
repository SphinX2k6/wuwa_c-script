using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000304 RID: 772
	[NetMessage(EMessageId.CorniceChallengeTransResponse)]
	public sealed class CorniceChallengeTransResponse : IMessage<CorniceChallengeTransResponse>, IMessage, IEquatable<CorniceChallengeTransResponse>, IDeepCloneable<CorniceChallengeTransResponse>, IBufferMessage
	{
		// Token: 0x06004DF3 RID: 19955 RVA: 0x000BD6BD File Offset: 0x000BB8BD
		[NullableContext(1)]
		public static CorniceChallengeTransResponse Create()
		{
			return new CorniceChallengeTransResponse();
		}

		// Token: 0x17000DCE RID: 3534
		// (get) Token: 0x06004DF4 RID: 19956 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DCF RID: 3535
		// (get) Token: 0x06004DF5 RID: 19957 RVA: 0x000BD6C7 File Offset: 0x000BB8C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceChallengeTransResponse.Descriptor;
			}
		}

		// Token: 0x06004DF6 RID: 19958 RVA: 0x000BD6CE File Offset: 0x000BB8CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeTransResponse()
		{
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x000BD6D6 File Offset: 0x000BB8D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeTransResponse(CorniceChallengeTransResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004DF8 RID: 19960 RVA: 0x000BD6FB File Offset: 0x000BB8FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeTransResponse Clone()
		{
			return new CorniceChallengeTransResponse(this);
		}

		// Token: 0x17000DD0 RID: 3536
		// (get) Token: 0x06004DF9 RID: 19961 RVA: 0x000BD703 File Offset: 0x000BB903
		// (set) Token: 0x06004DFA RID: 19962 RVA: 0x000BD70B File Offset: 0x000BB90B
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

		// Token: 0x06004DFB RID: 19963 RVA: 0x000BD714 File Offset: 0x000BB914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceChallengeTransResponse);
		}

		// Token: 0x06004DFC RID: 19964 RVA: 0x000BD722 File Offset: 0x000BB922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceChallengeTransResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004DFD RID: 19965 RVA: 0x000BD750 File Offset: 0x000BB950
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

		// Token: 0x06004DFE RID: 19966 RVA: 0x000BD795 File Offset: 0x000BB995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004DFF RID: 19967 RVA: 0x000BD7A2 File Offset: 0x000BB9A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004E00 RID: 19968 RVA: 0x000BD7AB File Offset: 0x000BB9AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004E01 RID: 19969 RVA: 0x000BD7E0 File Offset: 0x000BB9E0
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

		// Token: 0x06004E02 RID: 19970 RVA: 0x000BD81E File Offset: 0x000BBA1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CorniceChallengeTransResponse other)
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

		// Token: 0x06004E03 RID: 19971 RVA: 0x000BD84F File Offset: 0x000BBA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004E04 RID: 19972 RVA: 0x000BD858 File Offset: 0x000BBA58
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003172 RID: 12658
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003173 RID: 12659
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04003174 RID: 12660
		private ErrorCode errorCode_;
	}
}
