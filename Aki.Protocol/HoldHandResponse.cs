using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000759 RID: 1881
	[NetMessage(EMessageId.HoldHandResponse)]
	public sealed class HoldHandResponse : IMessage<HoldHandResponse>, IMessage, IEquatable<HoldHandResponse>, IDeepCloneable<HoldHandResponse>, IBufferMessage
	{
		// Token: 0x0600AA54 RID: 43604 RVA: 0x00199ED1 File Offset: 0x001980D1
		[NullableContext(1)]
		public static HoldHandResponse Create()
		{
			return new HoldHandResponse();
		}

		// Token: 0x1700224E RID: 8782
		// (get) Token: 0x0600AA55 RID: 43605 RVA: 0x00199ED8 File Offset: 0x001980D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700224F RID: 8783
		// (get) Token: 0x0600AA56 RID: 43606 RVA: 0x00199EDB File Offset: 0x001980DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HoldHandResponse.Descriptor;
			}
		}

		// Token: 0x0600AA57 RID: 43607 RVA: 0x00199EE2 File Offset: 0x001980E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandResponse()
		{
		}

		// Token: 0x0600AA58 RID: 43608 RVA: 0x00199EEA File Offset: 0x001980EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandResponse(HoldHandResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA59 RID: 43609 RVA: 0x00199F0F File Offset: 0x0019810F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HoldHandResponse Clone()
		{
			return new HoldHandResponse(this);
		}

		// Token: 0x17002250 RID: 8784
		// (get) Token: 0x0600AA5A RID: 43610 RVA: 0x00199F17 File Offset: 0x00198117
		// (set) Token: 0x0600AA5B RID: 43611 RVA: 0x00199F1F File Offset: 0x0019811F
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

		// Token: 0x0600AA5C RID: 43612 RVA: 0x00199F28 File Offset: 0x00198128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HoldHandResponse);
		}

		// Token: 0x0600AA5D RID: 43613 RVA: 0x00199F36 File Offset: 0x00198136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HoldHandResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA5E RID: 43614 RVA: 0x00199F64 File Offset: 0x00198164
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

		// Token: 0x0600AA5F RID: 43615 RVA: 0x00199FA9 File Offset: 0x001981A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA60 RID: 43616 RVA: 0x00199FB6 File Offset: 0x001981B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA61 RID: 43617 RVA: 0x00199FBF File Offset: 0x001981BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA62 RID: 43618 RVA: 0x00199FF4 File Offset: 0x001981F4
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

		// Token: 0x0600AA63 RID: 43619 RVA: 0x0019A032 File Offset: 0x00198232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HoldHandResponse other)
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

		// Token: 0x0600AA64 RID: 43620 RVA: 0x0019A063 File Offset: 0x00198263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AA65 RID: 43621 RVA: 0x0019A06C File Offset: 0x0019826C
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004D75 RID: 19829
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004D76 RID: 19830
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04004D77 RID: 19831
		private ErrorCode errorCode_;
	}
}
