using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200094B RID: 2379
	[NetMessage(EMessageId.LordGymBeginResponse)]
	public sealed class LordGymBeginResponse : IMessage<LordGymBeginResponse>, IMessage, IEquatable<LordGymBeginResponse>, IDeepCloneable<LordGymBeginResponse>, IBufferMessage
	{
		// Token: 0x0600D207 RID: 53767 RVA: 0x001EFA80 File Offset: 0x001EDC80
		[NullableContext(1)]
		public static LordGymBeginResponse Create()
		{
			return new LordGymBeginResponse();
		}

		// Token: 0x17002A82 RID: 10882
		// (get) Token: 0x0600D208 RID: 53768 RVA: 0x001EFA87 File Offset: 0x001EDC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A83 RID: 10883
		// (get) Token: 0x0600D209 RID: 53769 RVA: 0x001EFA8A File Offset: 0x001EDC8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymBeginResponse.Descriptor;
			}
		}

		// Token: 0x0600D20A RID: 53770 RVA: 0x001EFA91 File Offset: 0x001EDC91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymBeginResponse()
		{
		}

		// Token: 0x0600D20B RID: 53771 RVA: 0x001EFA99 File Offset: 0x001EDC99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymBeginResponse(LordGymBeginResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D20C RID: 53772 RVA: 0x001EFABE File Offset: 0x001EDCBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymBeginResponse Clone()
		{
			return new LordGymBeginResponse(this);
		}

		// Token: 0x17002A84 RID: 10884
		// (get) Token: 0x0600D20D RID: 53773 RVA: 0x001EFAC6 File Offset: 0x001EDCC6
		// (set) Token: 0x0600D20E RID: 53774 RVA: 0x001EFACE File Offset: 0x001EDCCE
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

		// Token: 0x0600D20F RID: 53775 RVA: 0x001EFAD7 File Offset: 0x001EDCD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymBeginResponse);
		}

		// Token: 0x0600D210 RID: 53776 RVA: 0x001EFAE5 File Offset: 0x001EDCE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymBeginResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D211 RID: 53777 RVA: 0x001EFB14 File Offset: 0x001EDD14
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

		// Token: 0x0600D212 RID: 53778 RVA: 0x001EFB59 File Offset: 0x001EDD59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D213 RID: 53779 RVA: 0x001EFB66 File Offset: 0x001EDD66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D214 RID: 53780 RVA: 0x001EFB6F File Offset: 0x001EDD6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D215 RID: 53781 RVA: 0x001EFBA4 File Offset: 0x001EDDA4
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

		// Token: 0x0600D216 RID: 53782 RVA: 0x001EFBE2 File Offset: 0x001EDDE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymBeginResponse other)
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

		// Token: 0x0600D217 RID: 53783 RVA: 0x001EFC13 File Offset: 0x001EDE13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D218 RID: 53784 RVA: 0x001EFC1C File Offset: 0x001EDE1C
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040058CB RID: 22731
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058CC RID: 22732
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040058CD RID: 22733
		private ErrorCode errorCode_;
	}
}
