using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E87 RID: 3719
	[NetMessage(EMessageId.ReadCardResponse)]
	public sealed class ReadCardResponse : IMessage<ReadCardResponse>, IMessage, IEquatable<ReadCardResponse>, IDeepCloneable<ReadCardResponse>, IBufferMessage
	{
		// Token: 0x06013FF7 RID: 81911 RVA: 0x002EA065 File Offset: 0x002E8265
		[NullableContext(1)]
		public static ReadCardResponse Create()
		{
			return new ReadCardResponse();
		}

		// Token: 0x1700428A RID: 17034
		// (get) Token: 0x06013FF8 RID: 81912 RVA: 0x002EA06C File Offset: 0x002E826C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700428B RID: 17035
		// (get) Token: 0x06013FF9 RID: 81913 RVA: 0x002EA06F File Offset: 0x002E826F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReadCardResponse.Descriptor;
			}
		}

		// Token: 0x06013FFA RID: 81914 RVA: 0x002EA076 File Offset: 0x002E8276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadCardResponse()
		{
		}

		// Token: 0x06013FFB RID: 81915 RVA: 0x002EA07E File Offset: 0x002E827E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadCardResponse(ReadCardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013FFC RID: 81916 RVA: 0x002EA0A3 File Offset: 0x002E82A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReadCardResponse Clone()
		{
			return new ReadCardResponse(this);
		}

		// Token: 0x1700428C RID: 17036
		// (get) Token: 0x06013FFD RID: 81917 RVA: 0x002EA0AB File Offset: 0x002E82AB
		// (set) Token: 0x06013FFE RID: 81918 RVA: 0x002EA0B3 File Offset: 0x002E82B3
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

		// Token: 0x06013FFF RID: 81919 RVA: 0x002EA0BC File Offset: 0x002E82BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReadCardResponse);
		}

		// Token: 0x06014000 RID: 81920 RVA: 0x002EA0CA File Offset: 0x002E82CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReadCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014001 RID: 81921 RVA: 0x002EA0F8 File Offset: 0x002E82F8
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

		// Token: 0x06014002 RID: 81922 RVA: 0x002EA13D File Offset: 0x002E833D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014003 RID: 81923 RVA: 0x002EA14A File Offset: 0x002E834A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014004 RID: 81924 RVA: 0x002EA153 File Offset: 0x002E8353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014005 RID: 81925 RVA: 0x002EA188 File Offset: 0x002E8388
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

		// Token: 0x06014006 RID: 81926 RVA: 0x002EA1C6 File Offset: 0x002E83C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReadCardResponse other)
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

		// Token: 0x06014007 RID: 81927 RVA: 0x002EA1F7 File Offset: 0x002E83F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014008 RID: 81928 RVA: 0x002EA200 File Offset: 0x002E8400
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007A81 RID: 31361
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A82 RID: 31362
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04007A83 RID: 31363
		private ErrorCode errorCode_;
	}
}
