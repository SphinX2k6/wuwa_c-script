using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200136B RID: 4971
	[NetMessage(EMessageId.SwitchCharacterStateResponse)]
	public sealed class SwitchCharacterStateResponse : IMessage<SwitchCharacterStateResponse>, IMessage, IEquatable<SwitchCharacterStateResponse>, IDeepCloneable<SwitchCharacterStateResponse>, IBufferMessage
	{
		// Token: 0x0601A79E RID: 108446 RVA: 0x003DBB47 File Offset: 0x003D9D47
		[NullableContext(1)]
		public static SwitchCharacterStateResponse Create()
		{
			return new SwitchCharacterStateResponse();
		}

		// Token: 0x170059A5 RID: 22949
		// (get) Token: 0x0601A79F RID: 108447 RVA: 0x003DBB4E File Offset: 0x003D9D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059A6 RID: 22950
		// (get) Token: 0x0601A7A0 RID: 108448 RVA: 0x003DBB51 File Offset: 0x003D9D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SwitchCharacterStateResponse.Descriptor;
			}
		}

		// Token: 0x0601A7A1 RID: 108449 RVA: 0x003DBB58 File Offset: 0x003D9D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateResponse()
		{
		}

		// Token: 0x0601A7A2 RID: 108450 RVA: 0x003DBB60 File Offset: 0x003D9D60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateResponse(SwitchCharacterStateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A7A3 RID: 108451 RVA: 0x003DBB85 File Offset: 0x003D9D85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SwitchCharacterStateResponse Clone()
		{
			return new SwitchCharacterStateResponse(this);
		}

		// Token: 0x170059A7 RID: 22951
		// (get) Token: 0x0601A7A4 RID: 108452 RVA: 0x003DBB8D File Offset: 0x003D9D8D
		// (set) Token: 0x0601A7A5 RID: 108453 RVA: 0x003DBB95 File Offset: 0x003D9D95
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

		// Token: 0x0601A7A6 RID: 108454 RVA: 0x003DBB9E File Offset: 0x003D9D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SwitchCharacterStateResponse);
		}

		// Token: 0x0601A7A7 RID: 108455 RVA: 0x003DBBAC File Offset: 0x003D9DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SwitchCharacterStateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A7A8 RID: 108456 RVA: 0x003DBBDC File Offset: 0x003D9DDC
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

		// Token: 0x0601A7A9 RID: 108457 RVA: 0x003DBC21 File Offset: 0x003D9E21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A7AA RID: 108458 RVA: 0x003DBC2E File Offset: 0x003D9E2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A7AB RID: 108459 RVA: 0x003DBC37 File Offset: 0x003D9E37
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

		// Token: 0x0601A7AC RID: 108460 RVA: 0x003DBC6C File Offset: 0x003D9E6C
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

		// Token: 0x0601A7AD RID: 108461 RVA: 0x003DBCAA File Offset: 0x003D9EAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SwitchCharacterStateResponse other)
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

		// Token: 0x0601A7AE RID: 108462 RVA: 0x003DBCDB File Offset: 0x003D9EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A7AF RID: 108463 RVA: 0x003DBCE4 File Offset: 0x003D9EE4
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

		// Token: 0x04009B51 RID: 39761
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B52 RID: 39762
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04009B53 RID: 39763
		private ErrorCode errorCode_;
	}
}
