using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EA1 RID: 3745
	[NetMessage(EMessageId.RecallItemUseResponse)]
	public sealed class RecallItemUseResponse : IMessage<RecallItemUseResponse>, IMessage, IEquatable<RecallItemUseResponse>, IDeepCloneable<RecallItemUseResponse>, IBufferMessage
	{
		// Token: 0x06014206 RID: 82438 RVA: 0x002EE594 File Offset: 0x002EC794
		[NullableContext(1)]
		public static RecallItemUseResponse Create()
		{
			return new RecallItemUseResponse();
		}

		// Token: 0x170042F8 RID: 17144
		// (get) Token: 0x06014207 RID: 82439 RVA: 0x002EE59B File Offset: 0x002EC79B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170042F9 RID: 17145
		// (get) Token: 0x06014208 RID: 82440 RVA: 0x002EE59E File Offset: 0x002EC79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RecallItemUseResponse.Descriptor;
			}
		}

		// Token: 0x06014209 RID: 82441 RVA: 0x002EE5A5 File Offset: 0x002EC7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemUseResponse()
		{
		}

		// Token: 0x0601420A RID: 82442 RVA: 0x002EE5AD File Offset: 0x002EC7AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemUseResponse(RecallItemUseResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601420B RID: 82443 RVA: 0x002EE5D2 File Offset: 0x002EC7D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RecallItemUseResponse Clone()
		{
			return new RecallItemUseResponse(this);
		}

		// Token: 0x170042FA RID: 17146
		// (get) Token: 0x0601420C RID: 82444 RVA: 0x002EE5DA File Offset: 0x002EC7DA
		// (set) Token: 0x0601420D RID: 82445 RVA: 0x002EE5E2 File Offset: 0x002EC7E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0601420E RID: 82446 RVA: 0x002EE5EB File Offset: 0x002EC7EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RecallItemUseResponse);
		}

		// Token: 0x0601420F RID: 82447 RVA: 0x002EE5F9 File Offset: 0x002EC7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RecallItemUseResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014210 RID: 82448 RVA: 0x002EE628 File Offset: 0x002EC828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014211 RID: 82449 RVA: 0x002EE66D File Offset: 0x002EC86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014212 RID: 82450 RVA: 0x002EE67A File Offset: 0x002EC87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014213 RID: 82451 RVA: 0x002EE683 File Offset: 0x002EC883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014214 RID: 82452 RVA: 0x002EE6B8 File Offset: 0x002EC8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014215 RID: 82453 RVA: 0x002EE6F6 File Offset: 0x002EC8F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RecallItemUseResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014216 RID: 82454 RVA: 0x002EE727 File Offset: 0x002EC927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014217 RID: 82455 RVA: 0x002EE730 File Offset: 0x002EC930
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007B11 RID: 31505
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B12 RID: 31506
		public const int ErrCodeFieldNumber = 2;

		// Token: 0x04007B13 RID: 31507
		private ErrorCode errCode_;
	}
}
