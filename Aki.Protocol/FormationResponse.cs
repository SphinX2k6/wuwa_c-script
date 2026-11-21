using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200061C RID: 1564
	[NetMessage(EMessageId.FormationResponse)]
	public sealed class FormationResponse : IMessage<FormationResponse>, IMessage, IEquatable<FormationResponse>, IDeepCloneable<FormationResponse>, IBufferMessage
	{
		// Token: 0x060090A9 RID: 37033 RVA: 0x0015E872 File Offset: 0x0015CA72
		[NullableContext(1)]
		public static FormationResponse Create()
		{
			return new FormationResponse();
		}

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x060090AA RID: 37034 RVA: 0x0015E879 File Offset: 0x0015CA79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x060090AB RID: 37035 RVA: 0x0015E87C File Offset: 0x0015CA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationResponse.Descriptor;
			}
		}

		// Token: 0x060090AC RID: 37036 RVA: 0x0015E883 File Offset: 0x0015CA83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationResponse()
		{
		}

		// Token: 0x060090AD RID: 37037 RVA: 0x0015E896 File Offset: 0x0015CA96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationResponse(FormationResponse other) : this()
		{
			this.formation_ = other.formation_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060090AE RID: 37038 RVA: 0x0015E8CC File Offset: 0x0015CACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationResponse Clone()
		{
			return new FormationResponse(this);
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x060090AF RID: 37039 RVA: 0x0015E8D4 File Offset: 0x0015CAD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<Formation> Formation
		{
			get
			{
				return this.formation_;
			}
		}

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x060090B0 RID: 37040 RVA: 0x0015E8DC File Offset: 0x0015CADC
		// (set) Token: 0x060090B1 RID: 37041 RVA: 0x0015E8E4 File Offset: 0x0015CAE4
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

		// Token: 0x060090B2 RID: 37042 RVA: 0x0015E8ED File Offset: 0x0015CAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationResponse);
		}

		// Token: 0x060090B3 RID: 37043 RVA: 0x0015E8FC File Offset: 0x0015CAFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationResponse other)
		{
			return other != null && (other == this || (this.formation_.Equals(other.formation_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060090B4 RID: 37044 RVA: 0x0015E94C File Offset: 0x0015CB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.formation_.GetHashCode();
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

		// Token: 0x060090B5 RID: 37045 RVA: 0x0015E99F File Offset: 0x0015CB9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060090B6 RID: 37046 RVA: 0x0015E9AC File Offset: 0x0015CBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060090B7 RID: 37047 RVA: 0x0015E9B8 File Offset: 0x0015CBB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.formation_.WriteTo(ref output, FormationResponse._repeated_formation_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060090B8 RID: 37048 RVA: 0x0015EA08 File Offset: 0x0015CC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.formation_.CalculateSize(FormationResponse._repeated_formation_codec);
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

		// Token: 0x060090B9 RID: 37049 RVA: 0x0015EA5C File Offset: 0x0015CC5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.formation_.Add(other.formation_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060090BA RID: 37050 RVA: 0x0015EAA9 File Offset: 0x0015CCA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060090BB RID: 37051 RVA: 0x0015EAB4 File Offset: 0x0015CCB4
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
					if (num != 34U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.formation_.AddEntriesFrom(ref input, FormationResponse._repeated_formation_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004666 RID: 18022
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004667 RID: 18023
		public const int FormationFieldNumber = 4;

		// Token: 0x04004668 RID: 18024
		private static readonly FieldCodec<Formation> _repeated_formation_codec = FieldCodec.ForMessage<Formation>(34U, Aki.Protocol.Formation.Parser);

		// Token: 0x04004669 RID: 18025
		private readonly RepeatedField<Formation> formation_ = new RepeatedField<Formation>();

		// Token: 0x0400466A RID: 18026
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x0400466B RID: 18027
		private ErrorCode errorCode_;
	}
}
