using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Ai
{
	// Token: 0x02001733 RID: 5939
	[NetMessage(EMessageId.AiInformationResponse)]
	public sealed class AiInformationResponse : IMessage<AiInformationResponse>, IMessage, IEquatable<AiInformationResponse>, IDeepCloneable<AiInformationResponse>, IBufferMessage
	{
		// Token: 0x0601DCEA RID: 122090 RVA: 0x0045ECC0 File Offset: 0x0045CEC0
		[NullableContext(1)]
		public static AiInformationResponse Create()
		{
			return new AiInformationResponse();
		}

		// Token: 0x17006576 RID: 25974
		// (get) Token: 0x0601DCEB RID: 122091 RVA: 0x0045ECC7 File Offset: 0x0045CEC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006577 RID: 25975
		// (get) Token: 0x0601DCEC RID: 122092 RVA: 0x0045ECCA File Offset: 0x0045CECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AiInformationResponse.Descriptor;
			}
		}

		// Token: 0x0601DCED RID: 122093 RVA: 0x0045ECD1 File Offset: 0x0045CED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationResponse()
		{
		}

		// Token: 0x0601DCEE RID: 122094 RVA: 0x0045ECD9 File Offset: 0x0045CED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationResponse(AiInformationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DCEF RID: 122095 RVA: 0x0045ECFE File Offset: 0x0045CEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AiInformationResponse Clone()
		{
			return new AiInformationResponse(this);
		}

		// Token: 0x17006578 RID: 25976
		// (get) Token: 0x0601DCF0 RID: 122096 RVA: 0x0045ED06 File Offset: 0x0045CF06
		// (set) Token: 0x0601DCF1 RID: 122097 RVA: 0x0045ED0E File Offset: 0x0045CF0E
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

		// Token: 0x0601DCF2 RID: 122098 RVA: 0x0045ED17 File Offset: 0x0045CF17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AiInformationResponse);
		}

		// Token: 0x0601DCF3 RID: 122099 RVA: 0x0045ED25 File Offset: 0x0045CF25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AiInformationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DCF4 RID: 122100 RVA: 0x0045ED54 File Offset: 0x0045CF54
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

		// Token: 0x0601DCF5 RID: 122101 RVA: 0x0045ED99 File Offset: 0x0045CF99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DCF6 RID: 122102 RVA: 0x0045EDA6 File Offset: 0x0045CFA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DCF7 RID: 122103 RVA: 0x0045EDAF File Offset: 0x0045CFAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DCF8 RID: 122104 RVA: 0x0045EDE4 File Offset: 0x0045CFE4
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

		// Token: 0x0601DCF9 RID: 122105 RVA: 0x0045EE22 File Offset: 0x0045D022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AiInformationResponse other)
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

		// Token: 0x0601DCFA RID: 122106 RVA: 0x0045EE53 File Offset: 0x0045D053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DCFB RID: 122107 RVA: 0x0045EE5C File Offset: 0x0045D05C
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400C992 RID: 51602
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C993 RID: 51603
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400C994 RID: 51604
		private ErrorCode errorCode_;
	}
}
