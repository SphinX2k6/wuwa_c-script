using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001144 RID: 4420
	[NetMessage(EMessageId.RoverRogueInsListResponse)]
	public sealed class RoverRogueInsListResponse : IMessage<RoverRogueInsListResponse>, IMessage, IEquatable<RoverRogueInsListResponse>, IDeepCloneable<RoverRogueInsListResponse>, IBufferMessage
	{
		// Token: 0x060179E3 RID: 96739 RVA: 0x003701F1 File Offset: 0x0036E3F1
		[NullableContext(1)]
		public static RoverRogueInsListResponse Create()
		{
			return new RoverRogueInsListResponse();
		}

		// Token: 0x17004F72 RID: 20338
		// (get) Token: 0x060179E4 RID: 96740 RVA: 0x003701F8 File Offset: 0x0036E3F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004F73 RID: 20339
		// (get) Token: 0x060179E5 RID: 96741 RVA: 0x003701FB File Offset: 0x0036E3FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueInsListResponse.Descriptor;
			}
		}

		// Token: 0x060179E6 RID: 96742 RVA: 0x00370202 File Offset: 0x0036E402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsListResponse()
		{
		}

		// Token: 0x060179E7 RID: 96743 RVA: 0x00370215 File Offset: 0x0036E415
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsListResponse(RoverRogueInsListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.list_ = other.list_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060179E8 RID: 96744 RVA: 0x0037024B File Offset: 0x0036E44B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueInsListResponse Clone()
		{
			return new RoverRogueInsListResponse(this);
		}

		// Token: 0x17004F74 RID: 20340
		// (get) Token: 0x060179E9 RID: 96745 RVA: 0x00370253 File Offset: 0x0036E453
		// (set) Token: 0x060179EA RID: 96746 RVA: 0x0037025B File Offset: 0x0036E45B
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

		// Token: 0x17004F75 RID: 20341
		// (get) Token: 0x060179EB RID: 96747 RVA: 0x00370264 File Offset: 0x0036E464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueInsEntry> List
		{
			get
			{
				return this.list_;
			}
		}

		// Token: 0x060179EC RID: 96748 RVA: 0x0037026C File Offset: 0x0036E46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueInsListResponse);
		}

		// Token: 0x060179ED RID: 96749 RVA: 0x0037027C File Offset: 0x0036E47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueInsListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.list_.Equals(other.list_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060179EE RID: 96750 RVA: 0x003702CC File Offset: 0x0036E4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.list_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060179EF RID: 96751 RVA: 0x0037031F File Offset: 0x0036E51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060179F0 RID: 96752 RVA: 0x0037032C File Offset: 0x0036E52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060179F1 RID: 96753 RVA: 0x00370338 File Offset: 0x0036E538
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.list_.WriteTo(ref output, RoverRogueInsListResponse._repeated_list_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060179F2 RID: 96754 RVA: 0x00370388 File Offset: 0x0036E588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.list_.CalculateSize(RoverRogueInsListResponse._repeated_list_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060179F3 RID: 96755 RVA: 0x003703DC File Offset: 0x0036E5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueInsListResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.list_.Add(other.list_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060179F4 RID: 96756 RVA: 0x00370429 File Offset: 0x0036E629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060179F5 RID: 96757 RVA: 0x00370434 File Offset: 0x0036E634
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.list_.AddEntriesFrom(ref input, RoverRogueInsListResponse._repeated_list_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008D02 RID: 36098
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D03 RID: 36099
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04008D04 RID: 36100
		private ErrorCode errorCode_;

		// Token: 0x04008D05 RID: 36101
		public const int ListFieldNumber = 15;

		// Token: 0x04008D06 RID: 36102
		private static readonly FieldCodec<RoverRogueInsEntry> _repeated_list_codec = FieldCodec.ForMessage<RoverRogueInsEntry>(122U, RoverRogueInsEntry.Parser);

		// Token: 0x04008D07 RID: 36103
		private readonly RepeatedField<RoverRogueInsEntry> list_ = new RepeatedField<RoverRogueInsEntry>();
	}
}
