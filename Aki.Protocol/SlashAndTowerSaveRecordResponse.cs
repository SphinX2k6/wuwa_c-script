using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001252 RID: 4690
	[NetMessage(EMessageId.SlashAndTowerSaveRecordResponse)]
	public sealed class SlashAndTowerSaveRecordResponse : IMessage<SlashAndTowerSaveRecordResponse>, IMessage, IEquatable<SlashAndTowerSaveRecordResponse>, IDeepCloneable<SlashAndTowerSaveRecordResponse>, IBufferMessage
	{
		// Token: 0x06018FCF RID: 102351 RVA: 0x003A2BED File Offset: 0x003A0DED
		[NullableContext(1)]
		public static SlashAndTowerSaveRecordResponse Create()
		{
			return new SlashAndTowerSaveRecordResponse();
		}

		// Token: 0x17005444 RID: 21572
		// (get) Token: 0x06018FD0 RID: 102352 RVA: 0x003A2BF4 File Offset: 0x003A0DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005445 RID: 21573
		// (get) Token: 0x06018FD1 RID: 102353 RVA: 0x003A2BF7 File Offset: 0x003A0DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SlashAndTowerSaveRecordResponse.Descriptor;
			}
		}

		// Token: 0x06018FD2 RID: 102354 RVA: 0x003A2BFE File Offset: 0x003A0DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerSaveRecordResponse()
		{
		}

		// Token: 0x06018FD3 RID: 102355 RVA: 0x003A2C06 File Offset: 0x003A0E06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerSaveRecordResponse(SlashAndTowerSaveRecordResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018FD4 RID: 102356 RVA: 0x003A2C2B File Offset: 0x003A0E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SlashAndTowerSaveRecordResponse Clone()
		{
			return new SlashAndTowerSaveRecordResponse(this);
		}

		// Token: 0x17005446 RID: 21574
		// (get) Token: 0x06018FD5 RID: 102357 RVA: 0x003A2C33 File Offset: 0x003A0E33
		// (set) Token: 0x06018FD6 RID: 102358 RVA: 0x003A2C3B File Offset: 0x003A0E3B
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

		// Token: 0x06018FD7 RID: 102359 RVA: 0x003A2C44 File Offset: 0x003A0E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SlashAndTowerSaveRecordResponse);
		}

		// Token: 0x06018FD8 RID: 102360 RVA: 0x003A2C52 File Offset: 0x003A0E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SlashAndTowerSaveRecordResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018FD9 RID: 102361 RVA: 0x003A2C80 File Offset: 0x003A0E80
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

		// Token: 0x06018FDA RID: 102362 RVA: 0x003A2CC5 File Offset: 0x003A0EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018FDB RID: 102363 RVA: 0x003A2CD2 File Offset: 0x003A0ED2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018FDC RID: 102364 RVA: 0x003A2CDB File Offset: 0x003A0EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018FDD RID: 102365 RVA: 0x003A2D10 File Offset: 0x003A0F10
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

		// Token: 0x06018FDE RID: 102366 RVA: 0x003A2D4E File Offset: 0x003A0F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SlashAndTowerSaveRecordResponse other)
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

		// Token: 0x06018FDF RID: 102367 RVA: 0x003A2D7F File Offset: 0x003A0F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018FE0 RID: 102368 RVA: 0x003A2D88 File Offset: 0x003A0F88
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009346 RID: 37702
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009347 RID: 37703
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04009348 RID: 37704
		private ErrorCode errorCode_;
	}
}
