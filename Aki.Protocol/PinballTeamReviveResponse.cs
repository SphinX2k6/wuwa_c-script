using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D58 RID: 3416
	[NetMessage(EMessageId.PinballTeamReviveResponse)]
	public sealed class PinballTeamReviveResponse : IMessage<PinballTeamReviveResponse>, IMessage, IEquatable<PinballTeamReviveResponse>, IDeepCloneable<PinballTeamReviveResponse>, IBufferMessage
	{
		// Token: 0x06012716 RID: 75542 RVA: 0x002B13A6 File Offset: 0x002AF5A6
		[NullableContext(1)]
		public static PinballTeamReviveResponse Create()
		{
			return new PinballTeamReviveResponse();
		}

		// Token: 0x17003D1F RID: 15647
		// (get) Token: 0x06012717 RID: 75543 RVA: 0x002B13AD File Offset: 0x002AF5AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D20 RID: 15648
		// (get) Token: 0x06012718 RID: 75544 RVA: 0x002B13B0 File Offset: 0x002AF5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballTeamReviveResponse.Descriptor;
			}
		}

		// Token: 0x06012719 RID: 75545 RVA: 0x002B13B7 File Offset: 0x002AF5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamReviveResponse()
		{
		}

		// Token: 0x0601271A RID: 75546 RVA: 0x002B13BF File Offset: 0x002AF5BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamReviveResponse(PinballTeamReviveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601271B RID: 75547 RVA: 0x002B13E4 File Offset: 0x002AF5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamReviveResponse Clone()
		{
			return new PinballTeamReviveResponse(this);
		}

		// Token: 0x17003D21 RID: 15649
		// (get) Token: 0x0601271C RID: 75548 RVA: 0x002B13EC File Offset: 0x002AF5EC
		// (set) Token: 0x0601271D RID: 75549 RVA: 0x002B13F4 File Offset: 0x002AF5F4
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

		// Token: 0x0601271E RID: 75550 RVA: 0x002B13FD File Offset: 0x002AF5FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballTeamReviveResponse);
		}

		// Token: 0x0601271F RID: 75551 RVA: 0x002B140B File Offset: 0x002AF60B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballTeamReviveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012720 RID: 75552 RVA: 0x002B143C File Offset: 0x002AF63C
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

		// Token: 0x06012721 RID: 75553 RVA: 0x002B1481 File Offset: 0x002AF681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012722 RID: 75554 RVA: 0x002B148E File Offset: 0x002AF68E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012723 RID: 75555 RVA: 0x002B1497 File Offset: 0x002AF697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012724 RID: 75556 RVA: 0x002B14CC File Offset: 0x002AF6CC
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

		// Token: 0x06012725 RID: 75557 RVA: 0x002B150A File Offset: 0x002AF70A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballTeamReviveResponse other)
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

		// Token: 0x06012726 RID: 75558 RVA: 0x002B153B File Offset: 0x002AF73B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012727 RID: 75559 RVA: 0x002B1544 File Offset: 0x002AF744
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400731D RID: 29469
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400731E RID: 29470
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400731F RID: 29471
		private ErrorCode errorCode_;
	}
}
