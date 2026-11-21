using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200022D RID: 557
	[NetMessage(EMessageId.CalabashSkinTakeOnResponse)]
	public sealed class CalabashSkinTakeOnResponse : IMessage<CalabashSkinTakeOnResponse>, IMessage, IEquatable<CalabashSkinTakeOnResponse>, IDeepCloneable<CalabashSkinTakeOnResponse>, IBufferMessage
	{
		// Token: 0x06003CB0 RID: 15536 RVA: 0x00096EF1 File Offset: 0x000950F1
		[NullableContext(1)]
		public static CalabashSkinTakeOnResponse Create()
		{
			return new CalabashSkinTakeOnResponse();
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06003CB1 RID: 15537 RVA: 0x00096EF8 File Offset: 0x000950F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06003CB2 RID: 15538 RVA: 0x00096EFB File Offset: 0x000950FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CalabashSkinTakeOnResponse.Descriptor;
			}
		}

		// Token: 0x06003CB3 RID: 15539 RVA: 0x00096F02 File Offset: 0x00095102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnResponse()
		{
		}

		// Token: 0x06003CB4 RID: 15540 RVA: 0x00096F0A File Offset: 0x0009510A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnResponse(CalabashSkinTakeOnResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.skinId_ = other.skinId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003CB5 RID: 15541 RVA: 0x00096F3B File Offset: 0x0009513B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CalabashSkinTakeOnResponse Clone()
		{
			return new CalabashSkinTakeOnResponse(this);
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06003CB6 RID: 15542 RVA: 0x00096F43 File Offset: 0x00095143
		// (set) Token: 0x06003CB7 RID: 15543 RVA: 0x00096F4B File Offset: 0x0009514B
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

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06003CB8 RID: 15544 RVA: 0x00096F54 File Offset: 0x00095154
		// (set) Token: 0x06003CB9 RID: 15545 RVA: 0x00096F5C File Offset: 0x0009515C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkinId
		{
			get
			{
				return this.skinId_;
			}
			set
			{
				this.skinId_ = value;
			}
		}

		// Token: 0x06003CBA RID: 15546 RVA: 0x00096F65 File Offset: 0x00095165
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CalabashSkinTakeOnResponse);
		}

		// Token: 0x06003CBB RID: 15547 RVA: 0x00096F73 File Offset: 0x00095173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CalabashSkinTakeOnResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.SkinId == other.SkinId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003CBC RID: 15548 RVA: 0x00096FB4 File Offset: 0x000951B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.SkinId != 0)
			{
				num ^= this.SkinId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003CBD RID: 15549 RVA: 0x00097012 File Offset: 0x00095212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003CBE RID: 15550 RVA: 0x0009701F File Offset: 0x0009521F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003CBF RID: 15551 RVA: 0x00097028 File Offset: 0x00095228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkinId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SkinId);
			}
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

		// Token: 0x06003CC0 RID: 15552 RVA: 0x00097084 File Offset: 0x00095284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.SkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkinId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003CC1 RID: 15553 RVA: 0x000970DC File Offset: 0x000952DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CalabashSkinTakeOnResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.SkinId != 0)
			{
				this.SkinId = other.SkinId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003CC2 RID: 15554 RVA: 0x0009712C File Offset: 0x0009532C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x00097138 File Offset: 0x00095338
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.SkinId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002CD0 RID: 11472
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CD1 RID: 11473
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04002CD2 RID: 11474
		private ErrorCode errorCode_;

		// Token: 0x04002CD3 RID: 11475
		public const int SkinIdFieldNumber = 4;

		// Token: 0x04002CD4 RID: 11476
		private int skinId_;
	}
}
