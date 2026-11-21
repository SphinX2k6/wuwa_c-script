using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B39 RID: 2873
	[NetMessage(EMessageId.NewTowerSeasonRewardResponse)]
	public sealed class NewTowerSeasonRewardResponse : IMessage<NewTowerSeasonRewardResponse>, IMessage, IEquatable<NewTowerSeasonRewardResponse>, IDeepCloneable<NewTowerSeasonRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F995 RID: 63893 RVA: 0x002469A4 File Offset: 0x00244BA4
		[NullableContext(1)]
		public static NewTowerSeasonRewardResponse Create()
		{
			return new NewTowerSeasonRewardResponse();
		}

		// Token: 0x170032E0 RID: 13024
		// (get) Token: 0x0600F996 RID: 63894 RVA: 0x002469AB File Offset: 0x00244BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170032E1 RID: 13025
		// (get) Token: 0x0600F997 RID: 63895 RVA: 0x002469AE File Offset: 0x00244BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewTowerSeasonRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F998 RID: 63896 RVA: 0x002469B5 File Offset: 0x00244BB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonRewardResponse()
		{
		}

		// Token: 0x0600F999 RID: 63897 RVA: 0x002469BD File Offset: 0x00244BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonRewardResponse(NewTowerSeasonRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F99A RID: 63898 RVA: 0x002469E2 File Offset: 0x00244BE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewTowerSeasonRewardResponse Clone()
		{
			return new NewTowerSeasonRewardResponse(this);
		}

		// Token: 0x170032E2 RID: 13026
		// (get) Token: 0x0600F99B RID: 63899 RVA: 0x002469EA File Offset: 0x00244BEA
		// (set) Token: 0x0600F99C RID: 63900 RVA: 0x002469F2 File Offset: 0x00244BF2
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

		// Token: 0x0600F99D RID: 63901 RVA: 0x002469FB File Offset: 0x00244BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewTowerSeasonRewardResponse);
		}

		// Token: 0x0600F99E RID: 63902 RVA: 0x00246A09 File Offset: 0x00244C09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewTowerSeasonRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F99F RID: 63903 RVA: 0x00246A38 File Offset: 0x00244C38
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

		// Token: 0x0600F9A0 RID: 63904 RVA: 0x00246A7D File Offset: 0x00244C7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F9A1 RID: 63905 RVA: 0x00246A8A File Offset: 0x00244C8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F9A2 RID: 63906 RVA: 0x00246A93 File Offset: 0x00244C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F9A3 RID: 63907 RVA: 0x00246AC8 File Offset: 0x00244CC8
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

		// Token: 0x0600F9A4 RID: 63908 RVA: 0x00246B06 File Offset: 0x00244D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewTowerSeasonRewardResponse other)
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

		// Token: 0x0600F9A5 RID: 63909 RVA: 0x00246B37 File Offset: 0x00244D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F9A6 RID: 63910 RVA: 0x00246B40 File Offset: 0x00244D40
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400645C RID: 25692
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400645D RID: 25693
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400645E RID: 25694
		private ErrorCode errorCode_;
	}
}
