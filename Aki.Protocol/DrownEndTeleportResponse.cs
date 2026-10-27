using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000414 RID: 1044
	[NetMessage(EMessageId.DrownEndTeleportResponse)]
	public sealed class DrownEndTeleportResponse : IMessage<DrownEndTeleportResponse>, IMessage, IEquatable<DrownEndTeleportResponse>, IDeepCloneable<DrownEndTeleportResponse>, IBufferMessage
	{
		// Token: 0x06006478 RID: 25720 RVA: 0x000F13AE File Offset: 0x000EF5AE
		[NullableContext(1)]
		public static DrownEndTeleportResponse Create()
		{
			return new DrownEndTeleportResponse();
		}

		// Token: 0x170012C3 RID: 4803
		// (get) Token: 0x06006479 RID: 25721 RVA: 0x000F13B5 File Offset: 0x000EF5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012C4 RID: 4804
		// (get) Token: 0x0600647A RID: 25722 RVA: 0x000F13B8 File Offset: 0x000EF5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DrownEndTeleportResponse.Descriptor;
			}
		}

		// Token: 0x0600647B RID: 25723 RVA: 0x000F13BF File Offset: 0x000EF5BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportResponse()
		{
		}

		// Token: 0x0600647C RID: 25724 RVA: 0x000F13C7 File Offset: 0x000EF5C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportResponse(DrownEndTeleportResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600647D RID: 25725 RVA: 0x000F13EC File Offset: 0x000EF5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DrownEndTeleportResponse Clone()
		{
			return new DrownEndTeleportResponse(this);
		}

		// Token: 0x170012C5 RID: 4805
		// (get) Token: 0x0600647E RID: 25726 RVA: 0x000F13F4 File Offset: 0x000EF5F4
		// (set) Token: 0x0600647F RID: 25727 RVA: 0x000F13FC File Offset: 0x000EF5FC
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

		// Token: 0x06006480 RID: 25728 RVA: 0x000F1405 File Offset: 0x000EF605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DrownEndTeleportResponse);
		}

		// Token: 0x06006481 RID: 25729 RVA: 0x000F1413 File Offset: 0x000EF613
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DrownEndTeleportResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006482 RID: 25730 RVA: 0x000F1444 File Offset: 0x000EF644
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

		// Token: 0x06006483 RID: 25731 RVA: 0x000F1489 File Offset: 0x000EF689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006484 RID: 25732 RVA: 0x000F1496 File Offset: 0x000EF696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006485 RID: 25733 RVA: 0x000F149F File Offset: 0x000EF69F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006486 RID: 25734 RVA: 0x000F14D0 File Offset: 0x000EF6D0
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

		// Token: 0x06006487 RID: 25735 RVA: 0x000F150E File Offset: 0x000EF70E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DrownEndTeleportResponse other)
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

		// Token: 0x06006488 RID: 25736 RVA: 0x000F153F File Offset: 0x000EF73F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006489 RID: 25737 RVA: 0x000F1548 File Offset: 0x000EF748
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003867 RID: 14439
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003868 RID: 14440
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04003869 RID: 14441
		private ErrorCode errorCode_;
	}
}
