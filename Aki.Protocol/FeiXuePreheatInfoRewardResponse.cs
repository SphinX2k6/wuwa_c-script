using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200051F RID: 1311
	[NetMessage(EMessageId.FeiXuePreheatInfoRewardResponse)]
	public sealed class FeiXuePreheatInfoRewardResponse : IMessage<FeiXuePreheatInfoRewardResponse>, IMessage, IEquatable<FeiXuePreheatInfoRewardResponse>, IDeepCloneable<FeiXuePreheatInfoRewardResponse>, IBufferMessage
	{
		// Token: 0x06007B58 RID: 31576 RVA: 0x0012B5DC File Offset: 0x001297DC
		[NullableContext(1)]
		public static FeiXuePreheatInfoRewardResponse Create()
		{
			return new FeiXuePreheatInfoRewardResponse();
		}

		// Token: 0x170017E9 RID: 6121
		// (get) Token: 0x06007B59 RID: 31577 RVA: 0x0012B5E3 File Offset: 0x001297E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017EA RID: 6122
		// (get) Token: 0x06007B5A RID: 31578 RVA: 0x0012B5E6 File Offset: 0x001297E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FeiXuePreheatInfoRewardResponse.Descriptor;
			}
		}

		// Token: 0x06007B5B RID: 31579 RVA: 0x0012B5ED File Offset: 0x001297ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoRewardResponse()
		{
		}

		// Token: 0x06007B5C RID: 31580 RVA: 0x0012B5F5 File Offset: 0x001297F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoRewardResponse(FeiXuePreheatInfoRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007B5D RID: 31581 RVA: 0x0012B61A File Offset: 0x0012981A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FeiXuePreheatInfoRewardResponse Clone()
		{
			return new FeiXuePreheatInfoRewardResponse(this);
		}

		// Token: 0x170017EB RID: 6123
		// (get) Token: 0x06007B5E RID: 31582 RVA: 0x0012B622 File Offset: 0x00129822
		// (set) Token: 0x06007B5F RID: 31583 RVA: 0x0012B62A File Offset: 0x0012982A
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

		// Token: 0x06007B60 RID: 31584 RVA: 0x0012B633 File Offset: 0x00129833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FeiXuePreheatInfoRewardResponse);
		}

		// Token: 0x06007B61 RID: 31585 RVA: 0x0012B641 File Offset: 0x00129841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FeiXuePreheatInfoRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007B62 RID: 31586 RVA: 0x0012B670 File Offset: 0x00129870
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

		// Token: 0x06007B63 RID: 31587 RVA: 0x0012B6B5 File Offset: 0x001298B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007B64 RID: 31588 RVA: 0x0012B6C2 File Offset: 0x001298C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007B65 RID: 31589 RVA: 0x0012B6CB File Offset: 0x001298CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007B66 RID: 31590 RVA: 0x0012B700 File Offset: 0x00129900
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

		// Token: 0x06007B67 RID: 31591 RVA: 0x0012B73E File Offset: 0x0012993E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FeiXuePreheatInfoRewardResponse other)
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

		// Token: 0x06007B68 RID: 31592 RVA: 0x0012B76F File Offset: 0x0012996F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007B69 RID: 31593 RVA: 0x0012B778 File Offset: 0x00129978
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003F7B RID: 16251
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F7C RID: 16252
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04003F7D RID: 16253
		private ErrorCode errorCode_;
	}
}
