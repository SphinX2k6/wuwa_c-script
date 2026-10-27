using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E4B RID: 3659
	[NetMessage(EMessageId.RacingBetsBulletScreenResponse)]
	public sealed class RacingBetsBulletScreenResponse : IMessage<RacingBetsBulletScreenResponse>, IMessage, IEquatable<RacingBetsBulletScreenResponse>, IDeepCloneable<RacingBetsBulletScreenResponse>, IBufferMessage
	{
		// Token: 0x06013A5C RID: 80476 RVA: 0x002DB580 File Offset: 0x002D9780
		[NullableContext(1)]
		public static RacingBetsBulletScreenResponse Create()
		{
			return new RacingBetsBulletScreenResponse();
		}

		// Token: 0x17004135 RID: 16693
		// (get) Token: 0x06013A5D RID: 80477 RVA: 0x002DB587 File Offset: 0x002D9787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004136 RID: 16694
		// (get) Token: 0x06013A5E RID: 80478 RVA: 0x002DB58A File Offset: 0x002D978A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsBulletScreenResponse.Descriptor;
			}
		}

		// Token: 0x06013A5F RID: 80479 RVA: 0x002DB591 File Offset: 0x002D9791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsBulletScreenResponse()
		{
		}

		// Token: 0x06013A60 RID: 80480 RVA: 0x002DB599 File Offset: 0x002D9799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsBulletScreenResponse(RacingBetsBulletScreenResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013A61 RID: 80481 RVA: 0x002DB5BE File Offset: 0x002D97BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsBulletScreenResponse Clone()
		{
			return new RacingBetsBulletScreenResponse(this);
		}

		// Token: 0x17004137 RID: 16695
		// (get) Token: 0x06013A62 RID: 80482 RVA: 0x002DB5C6 File Offset: 0x002D97C6
		// (set) Token: 0x06013A63 RID: 80483 RVA: 0x002DB5CE File Offset: 0x002D97CE
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

		// Token: 0x06013A64 RID: 80484 RVA: 0x002DB5D7 File Offset: 0x002D97D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsBulletScreenResponse);
		}

		// Token: 0x06013A65 RID: 80485 RVA: 0x002DB5E5 File Offset: 0x002D97E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsBulletScreenResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013A66 RID: 80486 RVA: 0x002DB614 File Offset: 0x002D9814
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

		// Token: 0x06013A67 RID: 80487 RVA: 0x002DB659 File Offset: 0x002D9859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013A68 RID: 80488 RVA: 0x002DB666 File Offset: 0x002D9866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013A69 RID: 80489 RVA: 0x002DB66F File Offset: 0x002D986F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013A6A RID: 80490 RVA: 0x002DB6A4 File Offset: 0x002D98A4
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

		// Token: 0x06013A6B RID: 80491 RVA: 0x002DB6E2 File Offset: 0x002D98E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsBulletScreenResponse other)
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

		// Token: 0x06013A6C RID: 80492 RVA: 0x002DB713 File Offset: 0x002D9913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013A6D RID: 80493 RVA: 0x002DB71C File Offset: 0x002D991C
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007847 RID: 30791
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007848 RID: 30792
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04007849 RID: 30793
		private ErrorCode errorCode_;
	}
}
