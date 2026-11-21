using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000628 RID: 1576
	[NetMessage(EMessageId.FoundationResponse)]
	public sealed class FoundationResponse : IMessage<FoundationResponse>, IMessage, IEquatable<FoundationResponse>, IDeepCloneable<FoundationResponse>, IBufferMessage
	{
		// Token: 0x060091B9 RID: 37305 RVA: 0x001613E0 File Offset: 0x0015F5E0
		[NullableContext(1)]
		public static FoundationResponse Create()
		{
			return new FoundationResponse();
		}

		// Token: 0x17001CFD RID: 7421
		// (get) Token: 0x060091BA RID: 37306 RVA: 0x001613E7 File Offset: 0x0015F5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CFE RID: 7422
		// (get) Token: 0x060091BB RID: 37307 RVA: 0x001613EA File Offset: 0x0015F5EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoundationResponse.Descriptor;
			}
		}

		// Token: 0x060091BC RID: 37308 RVA: 0x001613F1 File Offset: 0x0015F5F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationResponse()
		{
		}

		// Token: 0x060091BD RID: 37309 RVA: 0x001613F9 File Offset: 0x0015F5F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationResponse(FoundationResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.activeOperate_ = other.activeOperate_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091BE RID: 37310 RVA: 0x0016142A File Offset: 0x0015F62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationResponse Clone()
		{
			return new FoundationResponse(this);
		}

		// Token: 0x17001CFF RID: 7423
		// (get) Token: 0x060091BF RID: 37311 RVA: 0x00161432 File Offset: 0x0015F632
		// (set) Token: 0x060091C0 RID: 37312 RVA: 0x0016143A File Offset: 0x0015F63A
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

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x060091C1 RID: 37313 RVA: 0x00161443 File Offset: 0x0015F643
		// (set) Token: 0x060091C2 RID: 37314 RVA: 0x0016144B File Offset: 0x0015F64B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActiveOperate
		{
			get
			{
				return this.activeOperate_;
			}
			set
			{
				this.activeOperate_ = value;
			}
		}

		// Token: 0x060091C3 RID: 37315 RVA: 0x00161454 File Offset: 0x0015F654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoundationResponse);
		}

		// Token: 0x060091C4 RID: 37316 RVA: 0x00161462 File Offset: 0x0015F662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoundationResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ActiveOperate == other.ActiveOperate && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060091C5 RID: 37317 RVA: 0x001614A0 File Offset: 0x0015F6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ActiveOperate != 0)
			{
				num ^= this.ActiveOperate.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060091C6 RID: 37318 RVA: 0x001614FE File Offset: 0x0015F6FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060091C7 RID: 37319 RVA: 0x0016150B File Offset: 0x0015F70B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091C8 RID: 37320 RVA: 0x00161514 File Offset: 0x0015F714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ActiveOperate != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActiveOperate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060091C9 RID: 37321 RVA: 0x00161570 File Offset: 0x0015F770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ActiveOperate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveOperate);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060091CA RID: 37322 RVA: 0x001615C8 File Offset: 0x0015F7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FoundationResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ActiveOperate != 0)
			{
				this.ActiveOperate = other.ActiveOperate;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060091CB RID: 37323 RVA: 0x00161618 File Offset: 0x0015F818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091CC RID: 37324 RVA: 0x00161624 File Offset: 0x0015F824
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
				if (num != 64U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActiveOperate = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040046C7 RID: 18119
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046C8 RID: 18120
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x040046C9 RID: 18121
		private ErrorCode errorCode_;

		// Token: 0x040046CA RID: 18122
		public const int ActiveOperateFieldNumber = 14;

		// Token: 0x040046CB RID: 18123
		private int activeOperate_;
	}
}
