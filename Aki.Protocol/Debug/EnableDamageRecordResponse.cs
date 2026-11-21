using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001714 RID: 5908
	[NetMessage(EMessageId.EnableDamageRecordResponse)]
	public sealed class EnableDamageRecordResponse : IMessage<EnableDamageRecordResponse>, IMessage, IEquatable<EnableDamageRecordResponse>, IDeepCloneable<EnableDamageRecordResponse>, IBufferMessage
	{
		// Token: 0x0601DAAC RID: 121516 RVA: 0x0045A5CC File Offset: 0x004587CC
		[NullableContext(1)]
		public static EnableDamageRecordResponse Create()
		{
			return new EnableDamageRecordResponse();
		}

		// Token: 0x17006507 RID: 25863
		// (get) Token: 0x0601DAAD RID: 121517 RVA: 0x0045A5D3 File Offset: 0x004587D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006508 RID: 25864
		// (get) Token: 0x0601DAAE RID: 121518 RVA: 0x0045A5D6 File Offset: 0x004587D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnableDamageRecordResponse.Descriptor;
			}
		}

		// Token: 0x0601DAAF RID: 121519 RVA: 0x0045A5DD File Offset: 0x004587DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableDamageRecordResponse()
		{
		}

		// Token: 0x0601DAB0 RID: 121520 RVA: 0x0045A5E5 File Offset: 0x004587E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableDamageRecordResponse(EnableDamageRecordResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DAB1 RID: 121521 RVA: 0x0045A60A File Offset: 0x0045880A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableDamageRecordResponse Clone()
		{
			return new EnableDamageRecordResponse(this);
		}

		// Token: 0x17006509 RID: 25865
		// (get) Token: 0x0601DAB2 RID: 121522 RVA: 0x0045A612 File Offset: 0x00458812
		// (set) Token: 0x0601DAB3 RID: 121523 RVA: 0x0045A61A File Offset: 0x0045881A
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

		// Token: 0x0601DAB4 RID: 121524 RVA: 0x0045A623 File Offset: 0x00458823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnableDamageRecordResponse);
		}

		// Token: 0x0601DAB5 RID: 121525 RVA: 0x0045A631 File Offset: 0x00458831
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnableDamageRecordResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DAB6 RID: 121526 RVA: 0x0045A660 File Offset: 0x00458860
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

		// Token: 0x0601DAB7 RID: 121527 RVA: 0x0045A6A5 File Offset: 0x004588A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DAB8 RID: 121528 RVA: 0x0045A6B2 File Offset: 0x004588B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DAB9 RID: 121529 RVA: 0x0045A6BB File Offset: 0x004588BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DABA RID: 121530 RVA: 0x0045A6F0 File Offset: 0x004588F0
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

		// Token: 0x0601DABB RID: 121531 RVA: 0x0045A72E File Offset: 0x0045892E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnableDamageRecordResponse other)
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

		// Token: 0x0601DABC RID: 121532 RVA: 0x0045A75F File Offset: 0x0045895F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DABD RID: 121533 RVA: 0x0045A768 File Offset: 0x00458968
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400C8F9 RID: 51449
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C8FA RID: 51450
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400C8FB RID: 51451
		private ErrorCode errorCode_;
	}
}
