using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A1D RID: 2589
	[NetMessage(EMessageId.MotorDecalTaskResponse)]
	public sealed class MotorDecalTaskResponse : IMessage<MotorDecalTaskResponse>, IMessage, IEquatable<MotorDecalTaskResponse>, IDeepCloneable<MotorDecalTaskResponse>, IBufferMessage
	{
		// Token: 0x0600E292 RID: 58002 RVA: 0x00212CED File Offset: 0x00210EED
		[NullableContext(1)]
		public static MotorDecalTaskResponse Create()
		{
			return new MotorDecalTaskResponse();
		}

		// Token: 0x17002DE9 RID: 11753
		// (get) Token: 0x0600E293 RID: 58003 RVA: 0x00212CF4 File Offset: 0x00210EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DEA RID: 11754
		// (get) Token: 0x0600E294 RID: 58004 RVA: 0x00212CF7 File Offset: 0x00210EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDecalTaskResponse.Descriptor;
			}
		}

		// Token: 0x0600E295 RID: 58005 RVA: 0x00212CFE File Offset: 0x00210EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalTaskResponse()
		{
		}

		// Token: 0x0600E296 RID: 58006 RVA: 0x00212D11 File Offset: 0x00210F11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalTaskResponse(MotorDecalTaskResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E297 RID: 58007 RVA: 0x00212D47 File Offset: 0x00210F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalTaskResponse Clone()
		{
			return new MotorDecalTaskResponse(this);
		}

		// Token: 0x17002DEB RID: 11755
		// (get) Token: 0x0600E298 RID: 58008 RVA: 0x00212D4F File Offset: 0x00210F4F
		// (set) Token: 0x0600E299 RID: 58009 RVA: 0x00212D57 File Offset: 0x00210F57
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

		// Token: 0x17002DEC RID: 11756
		// (get) Token: 0x0600E29A RID: 58010 RVA: 0x00212D60 File Offset: 0x00210F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0600E29B RID: 58011 RVA: 0x00212D68 File Offset: 0x00210F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDecalTaskResponse);
		}

		// Token: 0x0600E29C RID: 58012 RVA: 0x00212D78 File Offset: 0x00210F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDecalTaskResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E29D RID: 58013 RVA: 0x00212DC8 File Offset: 0x00210FC8
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

		// Token: 0x0600E29E RID: 58014 RVA: 0x00212E1B File Offset: 0x0021101B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E29F RID: 58015 RVA: 0x00212E28 File Offset: 0x00211028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E2A0 RID: 58016 RVA: 0x00212E34 File Offset: 0x00211034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, MotorDecalTaskResponse._repeated_ids_codec);
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

		// Token: 0x0600E2A1 RID: 58017 RVA: 0x00212E84 File Offset: 0x00211084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.ids_.CalculateSize(MotorDecalTaskResponse._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E2A2 RID: 58018 RVA: 0x00212ED8 File Offset: 0x002110D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDecalTaskResponse other)
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

		// Token: 0x0600E2A3 RID: 58019 RVA: 0x00212F25 File Offset: 0x00211125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E2A4 RID: 58020 RVA: 0x00212F30 File Offset: 0x00211130
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
				if (num != 80U && num != 82U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, MotorDecalTaskResponse._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04005D47 RID: 23879
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D48 RID: 23880
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04005D49 RID: 23881
		private ErrorCode errorCode_;

		// Token: 0x04005D4A RID: 23882
		public const int IdsFieldNumber = 10;

		// Token: 0x04005D4B RID: 23883
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04005D4C RID: 23884
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
