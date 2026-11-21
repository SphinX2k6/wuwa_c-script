using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C9B RID: 3227
	[NetMessage(EMessageId.PhantomBattleRoleRewardResponse)]
	public sealed class PhantomBattleRoleRewardResponse : IMessage<PhantomBattleRoleRewardResponse>, IMessage, IEquatable<PhantomBattleRoleRewardResponse>, IDeepCloneable<PhantomBattleRoleRewardResponse>, IBufferMessage
	{
		// Token: 0x06011825 RID: 71717 RVA: 0x002910F5 File Offset: 0x0028F2F5
		[NullableContext(1)]
		public static PhantomBattleRoleRewardResponse Create()
		{
			return new PhantomBattleRoleRewardResponse();
		}

		// Token: 0x17003A01 RID: 14849
		// (get) Token: 0x06011826 RID: 71718 RVA: 0x002910FC File Offset: 0x0028F2FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A02 RID: 14850
		// (get) Token: 0x06011827 RID: 71719 RVA: 0x002910FF File Offset: 0x0028F2FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRoleRewardResponse.Descriptor;
			}
		}

		// Token: 0x06011828 RID: 71720 RVA: 0x00291106 File Offset: 0x0028F306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleRewardResponse()
		{
		}

		// Token: 0x06011829 RID: 71721 RVA: 0x0029110E File Offset: 0x0028F30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleRewardResponse(PhantomBattleRoleRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601182A RID: 71722 RVA: 0x00291133 File Offset: 0x0028F333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoleRewardResponse Clone()
		{
			return new PhantomBattleRoleRewardResponse(this);
		}

		// Token: 0x17003A03 RID: 14851
		// (get) Token: 0x0601182B RID: 71723 RVA: 0x0029113B File Offset: 0x0028F33B
		// (set) Token: 0x0601182C RID: 71724 RVA: 0x00291143 File Offset: 0x0028F343
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

		// Token: 0x0601182D RID: 71725 RVA: 0x0029114C File Offset: 0x0028F34C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRoleRewardResponse);
		}

		// Token: 0x0601182E RID: 71726 RVA: 0x0029115A File Offset: 0x0028F35A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRoleRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601182F RID: 71727 RVA: 0x00291188 File Offset: 0x0028F388
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

		// Token: 0x06011830 RID: 71728 RVA: 0x002911CD File Offset: 0x0028F3CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011831 RID: 71729 RVA: 0x002911DA File Offset: 0x0028F3DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011832 RID: 71730 RVA: 0x002911E3 File Offset: 0x0028F3E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011833 RID: 71731 RVA: 0x00291218 File Offset: 0x0028F418
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

		// Token: 0x06011834 RID: 71732 RVA: 0x00291256 File Offset: 0x0028F456
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRoleRewardResponse other)
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

		// Token: 0x06011835 RID: 71733 RVA: 0x00291287 File Offset: 0x0028F487
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011836 RID: 71734 RVA: 0x00291290 File Offset: 0x0028F490
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006ED1 RID: 28369
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006ED2 RID: 28370
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04006ED3 RID: 28371
		private ErrorCode errorCode_;
	}
}
