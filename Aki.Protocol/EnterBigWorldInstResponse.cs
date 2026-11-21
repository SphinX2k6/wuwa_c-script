using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200043A RID: 1082
	[NetMessage(EMessageId.EnterBigWorldInstResponse)]
	public sealed class EnterBigWorldInstResponse : IMessage<EnterBigWorldInstResponse>, IMessage, IEquatable<EnterBigWorldInstResponse>, IDeepCloneable<EnterBigWorldInstResponse>, IBufferMessage
	{
		// Token: 0x060067ED RID: 26605 RVA: 0x000F9E38 File Offset: 0x000F8038
		[NullableContext(1)]
		public static EnterBigWorldInstResponse Create()
		{
			return new EnterBigWorldInstResponse();
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x060067EE RID: 26606 RVA: 0x000F9E3F File Offset: 0x000F803F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x060067EF RID: 26607 RVA: 0x000F9E42 File Offset: 0x000F8042
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterBigWorldInstResponse.Descriptor;
			}
		}

		// Token: 0x060067F0 RID: 26608 RVA: 0x000F9E49 File Offset: 0x000F8049
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstResponse()
		{
		}

		// Token: 0x060067F1 RID: 26609 RVA: 0x000F9E51 File Offset: 0x000F8051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstResponse(EnterBigWorldInstResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067F2 RID: 26610 RVA: 0x000F9E76 File Offset: 0x000F8076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstResponse Clone()
		{
			return new EnterBigWorldInstResponse(this);
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x060067F3 RID: 26611 RVA: 0x000F9E7E File Offset: 0x000F807E
		// (set) Token: 0x060067F4 RID: 26612 RVA: 0x000F9E86 File Offset: 0x000F8086
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

		// Token: 0x060067F5 RID: 26613 RVA: 0x000F9E8F File Offset: 0x000F808F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterBigWorldInstResponse);
		}

		// Token: 0x060067F6 RID: 26614 RVA: 0x000F9E9D File Offset: 0x000F809D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterBigWorldInstResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060067F7 RID: 26615 RVA: 0x000F9ECC File Offset: 0x000F80CC
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

		// Token: 0x060067F8 RID: 26616 RVA: 0x000F9F11 File Offset: 0x000F8111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060067F9 RID: 26617 RVA: 0x000F9F1E File Offset: 0x000F811E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067FA RID: 26618 RVA: 0x000F9F27 File Offset: 0x000F8127
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

		// Token: 0x060067FB RID: 26619 RVA: 0x000F9F5C File Offset: 0x000F815C
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

		// Token: 0x060067FC RID: 26620 RVA: 0x000F9F9A File Offset: 0x000F819A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterBigWorldInstResponse other)
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

		// Token: 0x060067FD RID: 26621 RVA: 0x000F9FCB File Offset: 0x000F81CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067FE RID: 26622 RVA: 0x000F9FD4 File Offset: 0x000F81D4
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

		// Token: 0x040039E3 RID: 14819
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039E4 RID: 14820
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040039E5 RID: 14821
		private ErrorCode errorCode_;
	}
}
