using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002E6 RID: 742
	[NetMessage(EMessageId.ConstructTrapResponse)]
	public sealed class ConstructTrapResponse : IMessage<ConstructTrapResponse>, IMessage, IEquatable<ConstructTrapResponse>, IDeepCloneable<ConstructTrapResponse>, IBufferMessage
	{
		// Token: 0x06004BCC RID: 19404 RVA: 0x000B910B File Offset: 0x000B730B
		[NullableContext(1)]
		public static ConstructTrapResponse Create()
		{
			return new ConstructTrapResponse();
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06004BCD RID: 19405 RVA: 0x000B9112 File Offset: 0x000B7312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06004BCE RID: 19406 RVA: 0x000B9115 File Offset: 0x000B7315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConstructTrapResponse.Descriptor;
			}
		}

		// Token: 0x06004BCF RID: 19407 RVA: 0x000B911C File Offset: 0x000B731C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstructTrapResponse()
		{
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x000B9124 File Offset: 0x000B7324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstructTrapResponse(ConstructTrapResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x000B9155 File Offset: 0x000B7355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConstructTrapResponse Clone()
		{
			return new ConstructTrapResponse(this);
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06004BD2 RID: 19410 RVA: 0x000B915D File Offset: 0x000B735D
		// (set) Token: 0x06004BD3 RID: 19411 RVA: 0x000B9165 File Offset: 0x000B7365
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

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06004BD4 RID: 19412 RVA: 0x000B916E File Offset: 0x000B736E
		// (set) Token: 0x06004BD5 RID: 19413 RVA: 0x000B9176 File Offset: 0x000B7376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06004BD6 RID: 19414 RVA: 0x000B917F File Offset: 0x000B737F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConstructTrapResponse);
		}

		// Token: 0x06004BD7 RID: 19415 RVA: 0x000B918D File Offset: 0x000B738D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConstructTrapResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004BD8 RID: 19416 RVA: 0x000B91CC File Offset: 0x000B73CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004BD9 RID: 19417 RVA: 0x000B922A File Offset: 0x000B742A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004BDA RID: 19418 RVA: 0x000B9237 File Offset: 0x000B7437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x000B9240 File Offset: 0x000B7440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004BDC RID: 19420 RVA: 0x000B929C File Offset: 0x000B749C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x000B92F4 File Offset: 0x000B74F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConstructTrapResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x000B9344 File Offset: 0x000B7544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BDF RID: 19423 RVA: 0x000B9350 File Offset: 0x000B7550
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Id = input.ReadInt64();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400312E RID: 12590
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400312F RID: 12591
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003130 RID: 12592
		private ErrorCode errorCode_;

		// Token: 0x04003131 RID: 12593
		public const int IdFieldNumber = 10;

		// Token: 0x04003132 RID: 12594
		private long id_;
	}
}
