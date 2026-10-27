using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C34 RID: 3124
	[NetMessage(EMessageId.PhantomBattleBadgeRewardResponse)]
	public sealed class PhantomBattleBadgeRewardResponse : IMessage<PhantomBattleBadgeRewardResponse>, IMessage, IEquatable<PhantomBattleBadgeRewardResponse>, IDeepCloneable<PhantomBattleBadgeRewardResponse>, IBufferMessage
	{
		// Token: 0x06010F1E RID: 69406 RVA: 0x0027B1A4 File Offset: 0x002793A4
		[NullableContext(1)]
		public static PhantomBattleBadgeRewardResponse Create()
		{
			return new PhantomBattleBadgeRewardResponse();
		}

		// Token: 0x170037F5 RID: 14325
		// (get) Token: 0x06010F1F RID: 69407 RVA: 0x0027B1AB File Offset: 0x002793AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x06010F20 RID: 69408 RVA: 0x0027B1AE File Offset: 0x002793AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleBadgeRewardResponse.Descriptor;
			}
		}

		// Token: 0x06010F21 RID: 69409 RVA: 0x0027B1B5 File Offset: 0x002793B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardResponse()
		{
		}

		// Token: 0x06010F22 RID: 69410 RVA: 0x0027B1BD File Offset: 0x002793BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardResponse(PhantomBattleBadgeRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010F23 RID: 69411 RVA: 0x0027B1E2 File Offset: 0x002793E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleBadgeRewardResponse Clone()
		{
			return new PhantomBattleBadgeRewardResponse(this);
		}

		// Token: 0x170037F7 RID: 14327
		// (get) Token: 0x06010F24 RID: 69412 RVA: 0x0027B1EA File Offset: 0x002793EA
		// (set) Token: 0x06010F25 RID: 69413 RVA: 0x0027B1F2 File Offset: 0x002793F2
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

		// Token: 0x06010F26 RID: 69414 RVA: 0x0027B1FB File Offset: 0x002793FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleBadgeRewardResponse);
		}

		// Token: 0x06010F27 RID: 69415 RVA: 0x0027B209 File Offset: 0x00279409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleBadgeRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010F28 RID: 69416 RVA: 0x0027B238 File Offset: 0x00279438
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

		// Token: 0x06010F29 RID: 69417 RVA: 0x0027B27D File Offset: 0x0027947D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010F2A RID: 69418 RVA: 0x0027B28A File Offset: 0x0027948A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010F2B RID: 69419 RVA: 0x0027B293 File Offset: 0x00279493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06010F2C RID: 69420 RVA: 0x0027B2C8 File Offset: 0x002794C8
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

		// Token: 0x06010F2D RID: 69421 RVA: 0x0027B306 File Offset: 0x00279506
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

		// Token: 0x06010F2E RID: 69422 RVA: 0x0027B337 File Offset: 0x00279537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010F2F RID: 69423 RVA: 0x0027B340 File Offset: 0x00279540
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006B75 RID: 27509
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006B76 RID: 27510
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04006B77 RID: 27511
		private ErrorCode errorCode_;
	}
}
