using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200028A RID: 650
	[NetMessage(EMessageId.CheckPublicResourceVersionResponse)]
	public sealed class CheckPublicResourceVersionResponse : IMessage<CheckPublicResourceVersionResponse>, IMessage, IEquatable<CheckPublicResourceVersionResponse>, IDeepCloneable<CheckPublicResourceVersionResponse>, IBufferMessage
	{
		// Token: 0x06004421 RID: 17441 RVA: 0x000A733C File Offset: 0x000A553C
		[NullableContext(1)]
		public static CheckPublicResourceVersionResponse Create()
		{
			return new CheckPublicResourceVersionResponse();
		}

		// Token: 0x17000BA0 RID: 2976
		// (get) Token: 0x06004422 RID: 17442 RVA: 0x000A7343 File Offset: 0x000A5543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA1 RID: 2977
		// (get) Token: 0x06004423 RID: 17443 RVA: 0x000A7346 File Offset: 0x000A5546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheckPublicResourceVersionResponse.Descriptor;
			}
		}

		// Token: 0x06004424 RID: 17444 RVA: 0x000A734D File Offset: 0x000A554D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckPublicResourceVersionResponse()
		{
		}

		// Token: 0x06004425 RID: 17445 RVA: 0x000A7355 File Offset: 0x000A5555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckPublicResourceVersionResponse(CheckPublicResourceVersionResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this.tipLevel_ = other.tipLevel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004426 RID: 17446 RVA: 0x000A7386 File Offset: 0x000A5586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheckPublicResourceVersionResponse Clone()
		{
			return new CheckPublicResourceVersionResponse(this);
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x06004427 RID: 17447 RVA: 0x000A738E File Offset: 0x000A558E
		// (set) Token: 0x06004428 RID: 17448 RVA: 0x000A7396 File Offset: 0x000A5596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x06004429 RID: 17449 RVA: 0x000A739F File Offset: 0x000A559F
		// (set) Token: 0x0600442A RID: 17450 RVA: 0x000A73A7 File Offset: 0x000A55A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TipLevel
		{
			get
			{
				return this.tipLevel_;
			}
			set
			{
				this.tipLevel_ = value;
			}
		}

		// Token: 0x0600442B RID: 17451 RVA: 0x000A73B0 File Offset: 0x000A55B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheckPublicResourceVersionResponse);
		}

		// Token: 0x0600442C RID: 17452 RVA: 0x000A73BE File Offset: 0x000A55BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheckPublicResourceVersionResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && this.TipLevel == other.TipLevel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600442D RID: 17453 RVA: 0x000A73FC File Offset: 0x000A55FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this.TipLevel != 0)
			{
				num ^= this.TipLevel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600442E RID: 17454 RVA: 0x000A745A File Offset: 0x000A565A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600442F RID: 17455 RVA: 0x000A7467 File Offset: 0x000A5667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004430 RID: 17456 RVA: 0x000A7470 File Offset: 0x000A5670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this.TipLevel != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.TipLevel);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004431 RID: 17457 RVA: 0x000A74CC File Offset: 0x000A56CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this.TipLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TipLevel);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004432 RID: 17458 RVA: 0x000A7524 File Offset: 0x000A5724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheckPublicResourceVersionResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			if (other.TipLevel != 0)
			{
				this.TipLevel = other.TipLevel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004433 RID: 17459 RVA: 0x000A7574 File Offset: 0x000A5774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004434 RID: 17460 RVA: 0x000A7580 File Offset: 0x000A5780
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
				if (num != 48U)
				{
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TipLevel = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002EDA RID: 11994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EDB RID: 11995
		public const int ErrorIdFieldNumber = 6;

		// Token: 0x04002EDC RID: 11996
		private ErrorCode errorId_;

		// Token: 0x04002EDD RID: 11997
		public const int TipLevelFieldNumber = 8;

		// Token: 0x04002EDE RID: 11998
		private int tipLevel_;
	}
}
