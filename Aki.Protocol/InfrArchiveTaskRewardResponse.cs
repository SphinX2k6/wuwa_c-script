using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007D7 RID: 2007
	[NetMessage(EMessageId.InfrArchiveTaskRewardResponse)]
	public sealed class InfrArchiveTaskRewardResponse : IMessage<InfrArchiveTaskRewardResponse>, IMessage, IEquatable<InfrArchiveTaskRewardResponse>, IDeepCloneable<InfrArchiveTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x0600B450 RID: 46160 RVA: 0x001AF2A5 File Offset: 0x001AD4A5
		[NullableContext(1)]
		public static InfrArchiveTaskRewardResponse Create()
		{
			return new InfrArchiveTaskRewardResponse();
		}

		// Token: 0x17002460 RID: 9312
		// (get) Token: 0x0600B451 RID: 46161 RVA: 0x001AF2AC File Offset: 0x001AD4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002461 RID: 9313
		// (get) Token: 0x0600B452 RID: 46162 RVA: 0x001AF2AF File Offset: 0x001AD4AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrArchiveTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600B453 RID: 46163 RVA: 0x001AF2B6 File Offset: 0x001AD4B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveTaskRewardResponse()
		{
		}

		// Token: 0x0600B454 RID: 46164 RVA: 0x001AF2BE File Offset: 0x001AD4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveTaskRewardResponse(InfrArchiveTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B455 RID: 46165 RVA: 0x001AF2E3 File Offset: 0x001AD4E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrArchiveTaskRewardResponse Clone()
		{
			return new InfrArchiveTaskRewardResponse(this);
		}

		// Token: 0x17002462 RID: 9314
		// (get) Token: 0x0600B456 RID: 46166 RVA: 0x001AF2EB File Offset: 0x001AD4EB
		// (set) Token: 0x0600B457 RID: 46167 RVA: 0x001AF2F3 File Offset: 0x001AD4F3
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

		// Token: 0x0600B458 RID: 46168 RVA: 0x001AF2FC File Offset: 0x001AD4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrArchiveTaskRewardResponse);
		}

		// Token: 0x0600B459 RID: 46169 RVA: 0x001AF30A File Offset: 0x001AD50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrArchiveTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B45A RID: 46170 RVA: 0x001AF338 File Offset: 0x001AD538
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

		// Token: 0x0600B45B RID: 46171 RVA: 0x001AF37D File Offset: 0x001AD57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B45C RID: 46172 RVA: 0x001AF38A File Offset: 0x001AD58A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B45D RID: 46173 RVA: 0x001AF393 File Offset: 0x001AD593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B45E RID: 46174 RVA: 0x001AF3C8 File Offset: 0x001AD5C8
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

		// Token: 0x0600B45F RID: 46175 RVA: 0x001AF406 File Offset: 0x001AD606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrArchiveTaskRewardResponse other)
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

		// Token: 0x0600B460 RID: 46176 RVA: 0x001AF437 File Offset: 0x001AD637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B461 RID: 46177 RVA: 0x001AF440 File Offset: 0x001AD640
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005045 RID: 20549
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005046 RID: 20550
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04005047 RID: 20551
		private ErrorCode errorCode_;
	}
}
