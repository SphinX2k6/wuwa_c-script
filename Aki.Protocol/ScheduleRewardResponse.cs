using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D3 RID: 4563
	[NetMessage(EMessageId.ScheduleRewardResponse)]
	public sealed class ScheduleRewardResponse : IMessage<ScheduleRewardResponse>, IMessage, IEquatable<ScheduleRewardResponse>, IDeepCloneable<ScheduleRewardResponse>, IBufferMessage
	{
		// Token: 0x060185C0 RID: 99776 RVA: 0x0038BB50 File Offset: 0x00389D50
		[NullableContext(1)]
		public static ScheduleRewardResponse Create()
		{
			return new ScheduleRewardResponse();
		}

		// Token: 0x17005219 RID: 21017
		// (get) Token: 0x060185C1 RID: 99777 RVA: 0x0038BB57 File Offset: 0x00389D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700521A RID: 21018
		// (get) Token: 0x060185C2 RID: 99778 RVA: 0x0038BB5A File Offset: 0x00389D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScheduleRewardResponse.Descriptor;
			}
		}

		// Token: 0x060185C3 RID: 99779 RVA: 0x0038BB61 File Offset: 0x00389D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardResponse()
		{
		}

		// Token: 0x060185C4 RID: 99780 RVA: 0x0038BB69 File Offset: 0x00389D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardResponse(ScheduleRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060185C5 RID: 99781 RVA: 0x0038BB8E File Offset: 0x00389D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScheduleRewardResponse Clone()
		{
			return new ScheduleRewardResponse(this);
		}

		// Token: 0x1700521B RID: 21019
		// (get) Token: 0x060185C6 RID: 99782 RVA: 0x0038BB96 File Offset: 0x00389D96
		// (set) Token: 0x060185C7 RID: 99783 RVA: 0x0038BB9E File Offset: 0x00389D9E
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

		// Token: 0x060185C8 RID: 99784 RVA: 0x0038BBA7 File Offset: 0x00389DA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScheduleRewardResponse);
		}

		// Token: 0x060185C9 RID: 99785 RVA: 0x0038BBB5 File Offset: 0x00389DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScheduleRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060185CA RID: 99786 RVA: 0x0038BBE4 File Offset: 0x00389DE4
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

		// Token: 0x060185CB RID: 99787 RVA: 0x0038BC29 File Offset: 0x00389E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060185CC RID: 99788 RVA: 0x0038BC36 File Offset: 0x00389E36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060185CD RID: 99789 RVA: 0x0038BC3F File Offset: 0x00389E3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060185CE RID: 99790 RVA: 0x0038BC74 File Offset: 0x00389E74
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

		// Token: 0x060185CF RID: 99791 RVA: 0x0038BCB2 File Offset: 0x00389EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScheduleRewardResponse other)
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

		// Token: 0x060185D0 RID: 99792 RVA: 0x0038BCE3 File Offset: 0x00389EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060185D1 RID: 99793 RVA: 0x0038BCEC File Offset: 0x00389EEC
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040090BE RID: 37054
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090BF RID: 37055
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x040090C0 RID: 37056
		private ErrorCode errorCode_;
	}
}
