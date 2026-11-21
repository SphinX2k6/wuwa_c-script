using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AFF RID: 2815
	[NetMessage(EMessageId.NewbieFetchScoreRewardResponse)]
	public sealed class NewbieFetchScoreRewardResponse : IMessage<NewbieFetchScoreRewardResponse>, IMessage, IEquatable<NewbieFetchScoreRewardResponse>, IDeepCloneable<NewbieFetchScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F4E0 RID: 62688 RVA: 0x0023BEBC File Offset: 0x0023A0BC
		[NullableContext(1)]
		public static NewbieFetchScoreRewardResponse Create()
		{
			return new NewbieFetchScoreRewardResponse();
		}

		// Token: 0x170031D9 RID: 12761
		// (get) Token: 0x0600F4E1 RID: 62689 RVA: 0x0023BEC3 File Offset: 0x0023A0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031DA RID: 12762
		// (get) Token: 0x0600F4E2 RID: 62690 RVA: 0x0023BEC6 File Offset: 0x0023A0C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewbieFetchScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F4E3 RID: 62691 RVA: 0x0023BECD File Offset: 0x0023A0CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieFetchScoreRewardResponse()
		{
		}

		// Token: 0x0600F4E4 RID: 62692 RVA: 0x0023BED5 File Offset: 0x0023A0D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieFetchScoreRewardResponse(NewbieFetchScoreRewardResponse other) : this()
		{
			this.code_ = other.code_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F4E5 RID: 62693 RVA: 0x0023BEFA File Offset: 0x0023A0FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewbieFetchScoreRewardResponse Clone()
		{
			return new NewbieFetchScoreRewardResponse(this);
		}

		// Token: 0x170031DB RID: 12763
		// (get) Token: 0x0600F4E6 RID: 62694 RVA: 0x0023BF02 File Offset: 0x0023A102
		// (set) Token: 0x0600F4E7 RID: 62695 RVA: 0x0023BF0A File Offset: 0x0023A10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x0600F4E8 RID: 62696 RVA: 0x0023BF13 File Offset: 0x0023A113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewbieFetchScoreRewardResponse);
		}

		// Token: 0x0600F4E9 RID: 62697 RVA: 0x0023BF21 File Offset: 0x0023A121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewbieFetchScoreRewardResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F4EA RID: 62698 RVA: 0x0023BF50 File Offset: 0x0023A150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F4EB RID: 62699 RVA: 0x0023BF95 File Offset: 0x0023A195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F4EC RID: 62700 RVA: 0x0023BFA2 File Offset: 0x0023A1A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F4ED RID: 62701 RVA: 0x0023BFAB File Offset: 0x0023A1AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F4EE RID: 62702 RVA: 0x0023BFE0 File Offset: 0x0023A1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F4EF RID: 62703 RVA: 0x0023C01E File Offset: 0x0023A21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewbieFetchScoreRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F4F0 RID: 62704 RVA: 0x0023C04F File Offset: 0x0023A24F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F4F1 RID: 62705 RVA: 0x0023C058 File Offset: 0x0023A258
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040062DE RID: 25310
		private UnknownFieldSet _unknownFields;

		// Token: 0x040062DF RID: 25311
		public const int CodeFieldNumber = 10;

		// Token: 0x040062E0 RID: 25312
		private ErrorCode code_;
	}
}
