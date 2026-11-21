using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C24 RID: 3108
	[NetMessage(EMessageId.PhantomBattleBadgeRewardResponse)]
	public sealed class PhantomBattleBadgeRewardResponse : IMessage<PhantomBattleBadgeRewardResponse>, IMessage, IEquatable<PhantomBattleBadgeRewardResponse>, IDeepCloneable<PhantomBattleBadgeRewardResponse>, IBufferMessage
	{
		// Token: 0x06010E1E RID: 69150 RVA: 0x00279440 File Offset: 0x00277640
		[NullableContext(1)]
		public static PhantomBattleBadgeRewardResponse Create()
		{
			return new PhantomBattleBadgeRewardResponse();
		}

		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x06010E1F RID: 69151 RVA: 0x00279447 File Offset: 0x00277647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x06010E20 RID: 69152 RVA: 0x0027944A File Offset: 0x0027764A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBadgeRewardResponse.Descriptor;
			}
		}

		// Token: 0x06010E21 RID: 69153 RVA: 0x00279451 File Offset: 0x00277651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardResponse()
		{
		}

		// Token: 0x06010E22 RID: 69154 RVA: 0x00279459 File Offset: 0x00277659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardResponse(PhantomBattleBadgeRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010E23 RID: 69155 RVA: 0x0027947E File Offset: 0x0027767E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardResponse Clone()
		{
			return new PhantomBattleBadgeRewardResponse(this);
		}

		// Token: 0x170037C0 RID: 14272
		// (get) Token: 0x06010E24 RID: 69156 RVA: 0x00279486 File Offset: 0x00277686
		// (set) Token: 0x06010E25 RID: 69157 RVA: 0x0027948E File Offset: 0x0027768E
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

		// Token: 0x06010E26 RID: 69158 RVA: 0x00279497 File Offset: 0x00277697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBadgeRewardResponse);
		}

		// Token: 0x06010E27 RID: 69159 RVA: 0x002794A5 File Offset: 0x002776A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBadgeRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010E28 RID: 69160 RVA: 0x002794D4 File Offset: 0x002776D4
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

		// Token: 0x06010E29 RID: 69161 RVA: 0x00279519 File Offset: 0x00277719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010E2A RID: 69162 RVA: 0x00279526 File Offset: 0x00277726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010E2B RID: 69163 RVA: 0x0027952F File Offset: 0x0027772F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010E2C RID: 69164 RVA: 0x00279564 File Offset: 0x00277764
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

		// Token: 0x06010E2D RID: 69165 RVA: 0x002795A2 File Offset: 0x002777A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleBadgeRewardResponse other)
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

		// Token: 0x06010E2E RID: 69166 RVA: 0x002795D3 File Offset: 0x002777D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010E2F RID: 69167 RVA: 0x002795DC File Offset: 0x002777DC
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006B89 RID: 27529
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B8A RID: 27530
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006B8B RID: 27531
		private ErrorCode errorCode_;
	}
}
