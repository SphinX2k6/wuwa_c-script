using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A66 RID: 2662
	[NetMessage(EMessageId.MotorLinkTaskResponse)]
	public sealed class MotorLinkTaskResponse : IMessage<MotorLinkTaskResponse>, IMessage, IEquatable<MotorLinkTaskResponse>, IDeepCloneable<MotorLinkTaskResponse>, IBufferMessage
	{
		// Token: 0x0600E86B RID: 59499 RVA: 0x0021F651 File Offset: 0x0021D851
		[NullableContext(1)]
		public static MotorLinkTaskResponse Create()
		{
			return new MotorLinkTaskResponse();
		}

		// Token: 0x17002F24 RID: 12068
		// (get) Token: 0x0600E86C RID: 59500 RVA: 0x0021F658 File Offset: 0x0021D858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F25 RID: 12069
		// (get) Token: 0x0600E86D RID: 59501 RVA: 0x0021F65B File Offset: 0x0021D85B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorLinkTaskResponse.Descriptor;
			}
		}

		// Token: 0x0600E86E RID: 59502 RVA: 0x0021F662 File Offset: 0x0021D862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLinkTaskResponse()
		{
		}

		// Token: 0x0600E86F RID: 59503 RVA: 0x0021F675 File Offset: 0x0021D875
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLinkTaskResponse(MotorLinkTaskResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E870 RID: 59504 RVA: 0x0021F6AB File Offset: 0x0021D8AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLinkTaskResponse Clone()
		{
			return new MotorLinkTaskResponse(this);
		}

		// Token: 0x17002F26 RID: 12070
		// (get) Token: 0x0600E871 RID: 59505 RVA: 0x0021F6B3 File Offset: 0x0021D8B3
		// (set) Token: 0x0600E872 RID: 59506 RVA: 0x0021F6BB File Offset: 0x0021D8BB
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

		// Token: 0x17002F27 RID: 12071
		// (get) Token: 0x0600E873 RID: 59507 RVA: 0x0021F6C4 File Offset: 0x0021D8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600E874 RID: 59508 RVA: 0x0021F6CC File Offset: 0x0021D8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorLinkTaskResponse);
		}

		// Token: 0x0600E875 RID: 59509 RVA: 0x0021F6DC File Offset: 0x0021D8DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorLinkTaskResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E876 RID: 59510 RVA: 0x0021F72C File Offset: 0x0021D92C
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

		// Token: 0x0600E877 RID: 59511 RVA: 0x0021F77F File Offset: 0x0021D97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E878 RID: 59512 RVA: 0x0021F78C File Offset: 0x0021D98C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E879 RID: 59513 RVA: 0x0021F798 File Offset: 0x0021D998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.ids_.WriteTo(ref output, MotorLinkTaskResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E87A RID: 59514 RVA: 0x0021F7E8 File Offset: 0x0021D9E8
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

		// Token: 0x0600E87B RID: 59515 RVA: 0x0021F83C File Offset: 0x0021DA3C
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

		// Token: 0x0600E87C RID: 59516 RVA: 0x0021F889 File Offset: 0x0021DA89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E87D RID: 59517 RVA: 0x0021F894 File Offset: 0x0021DA94
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
					if (num != 56U && num != 58U)
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

		// Token: 0x04005EF7 RID: 24311
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EF8 RID: 24312
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005EF9 RID: 24313
		private ErrorCode errorCode_;

		// Token: 0x04005EFA RID: 24314
		public const int IdsFieldNumber = 7;

		// Token: 0x04005EFB RID: 24315
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04005EFC RID: 24316
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
