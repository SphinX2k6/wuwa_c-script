using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A77 RID: 2679
	[NetMessage(EMessageId.MotorLinkTaskResponse)]
	public sealed class MotorLinkTaskResponse : IMessage<MotorLinkTaskResponse>, IMessage, IEquatable<MotorLinkTaskResponse>, IDeepCloneable<MotorLinkTaskResponse>, IBufferMessage
	{
		// Token: 0x0600E985 RID: 59781 RVA: 0x00221845 File Offset: 0x0021FA45
		[NullableContext(1)]
		public static MotorLinkTaskResponse Create()
		{
			return new MotorLinkTaskResponse();
		}

		// Token: 0x17002F62 RID: 12130
		// (get) Token: 0x0600E986 RID: 59782 RVA: 0x0022184C File Offset: 0x0021FA4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F63 RID: 12131
		// (get) Token: 0x0600E987 RID: 59783 RVA: 0x0022184F File Offset: 0x0021FA4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorLinkTaskResponse.Descriptor;
			}
		}

		// Token: 0x0600E988 RID: 59784 RVA: 0x00221856 File Offset: 0x0021FA56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLinkTaskResponse()
		{
		}

		// Token: 0x0600E989 RID: 59785 RVA: 0x00221869 File Offset: 0x0021FA69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLinkTaskResponse(MotorLinkTaskResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E98A RID: 59786 RVA: 0x0022189F File Offset: 0x0021FA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLinkTaskResponse Clone()
		{
			return new MotorLinkTaskResponse(this);
		}

		// Token: 0x17002F64 RID: 12132
		// (get) Token: 0x0600E98B RID: 59787 RVA: 0x002218A7 File Offset: 0x0021FAA7
		// (set) Token: 0x0600E98C RID: 59788 RVA: 0x002218AF File Offset: 0x0021FAAF
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

		// Token: 0x17002F65 RID: 12133
		// (get) Token: 0x0600E98D RID: 59789 RVA: 0x002218B8 File Offset: 0x0021FAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600E98E RID: 59790 RVA: 0x002218C0 File Offset: 0x0021FAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorLinkTaskResponse);
		}

		// Token: 0x0600E98F RID: 59791 RVA: 0x002218D0 File Offset: 0x0021FAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorLinkTaskResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E990 RID: 59792 RVA: 0x00221920 File Offset: 0x0021FB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E991 RID: 59793 RVA: 0x00221973 File Offset: 0x0021FB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E992 RID: 59794 RVA: 0x00221980 File Offset: 0x0021FB80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E993 RID: 59795 RVA: 0x0022198C File Offset: 0x0021FB8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.ids_.WriteTo(ref output, MotorLinkTaskResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E994 RID: 59796 RVA: 0x002219DC File Offset: 0x0021FBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.ids_.CalculateSize(MotorLinkTaskResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E995 RID: 59797 RVA: 0x00221A30 File Offset: 0x0021FC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorLinkTaskResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E996 RID: 59798 RVA: 0x00221A7D File Offset: 0x0021FC7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E997 RID: 59799 RVA: 0x00221A88 File Offset: 0x0021FC88
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
					if (num != 120U && num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ids_.AddEntriesFrom(ref input, MotorLinkTaskResponse._repeated_ids_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005EEE RID: 24302
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EEF RID: 24303
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04005EF0 RID: 24304
		private ErrorCode errorCode_;

		// Token: 0x04005EF1 RID: 24305
		public const int IdsFieldNumber = 15;

		// Token: 0x04005EF2 RID: 24306
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04005EF3 RID: 24307
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
