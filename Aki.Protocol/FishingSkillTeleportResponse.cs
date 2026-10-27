using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000589 RID: 1417
	[NetMessage(EMessageId.FishingSkillTeleportResponse)]
	public sealed class FishingSkillTeleportResponse : IMessage<FishingSkillTeleportResponse>, IMessage, IEquatable<FishingSkillTeleportResponse>, IDeepCloneable<FishingSkillTeleportResponse>, IBufferMessage
	{
		// Token: 0x06008374 RID: 33652 RVA: 0x0013CA92 File Offset: 0x0013AC92
		[NullableContext(1)]
		public static FishingSkillTeleportResponse Create()
		{
			return new FishingSkillTeleportResponse();
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x06008375 RID: 33653 RVA: 0x0013CA99 File Offset: 0x0013AC99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x06008376 RID: 33654 RVA: 0x0013CA9C File Offset: 0x0013AC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSkillTeleportResponse.Descriptor;
			}
		}

		// Token: 0x06008377 RID: 33655 RVA: 0x0013CAA3 File Offset: 0x0013ACA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillTeleportResponse()
		{
		}

		// Token: 0x06008378 RID: 33656 RVA: 0x0013CAAB File Offset: 0x0013ACAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillTeleportResponse(FishingSkillTeleportResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008379 RID: 33657 RVA: 0x0013CAD0 File Offset: 0x0013ACD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillTeleportResponse Clone()
		{
			return new FishingSkillTeleportResponse(this);
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x0600837A RID: 33658 RVA: 0x0013CAD8 File Offset: 0x0013ACD8
		// (set) Token: 0x0600837B RID: 33659 RVA: 0x0013CAE0 File Offset: 0x0013ACE0
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

		// Token: 0x0600837C RID: 33660 RVA: 0x0013CAE9 File Offset: 0x0013ACE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSkillTeleportResponse);
		}

		// Token: 0x0600837D RID: 33661 RVA: 0x0013CAF7 File Offset: 0x0013ACF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSkillTeleportResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600837E RID: 33662 RVA: 0x0013CB28 File Offset: 0x0013AD28
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

		// Token: 0x0600837F RID: 33663 RVA: 0x0013CB6D File Offset: 0x0013AD6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008380 RID: 33664 RVA: 0x0013CB7A File Offset: 0x0013AD7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008381 RID: 33665 RVA: 0x0013CB83 File Offset: 0x0013AD83
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

		// Token: 0x06008382 RID: 33666 RVA: 0x0013CBB8 File Offset: 0x0013ADB8
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

		// Token: 0x06008383 RID: 33667 RVA: 0x0013CBF6 File Offset: 0x0013ADF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSkillTeleportResponse other)
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

		// Token: 0x06008384 RID: 33668 RVA: 0x0013CC27 File Offset: 0x0013AE27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008385 RID: 33669 RVA: 0x0013CC30 File Offset: 0x0013AE30
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

		// Token: 0x04004179 RID: 16761
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400417A RID: 16762
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400417B RID: 16763
		private ErrorCode errorCode_;
	}
}
