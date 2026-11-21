using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003AD RID: 941
	public sealed class DErrorResult : IMessage<DErrorResult>, IMessage, IEquatable<DErrorResult>, IDeepCloneable<DErrorResult>, IBufferMessage
	{
		// Token: 0x06005CA9 RID: 23721 RVA: 0x000E11F4 File Offset: 0x000DF3F4
		[NullableContext(1)]
		public static DErrorResult Create()
		{
			return new DErrorResult();
		}

		// Token: 0x1700112A RID: 4394
		// (get) Token: 0x06005CAA RID: 23722 RVA: 0x000E11FB File Offset: 0x000DF3FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700112B RID: 4395
		// (get) Token: 0x06005CAB RID: 23723 RVA: 0x000E11FE File Offset: 0x000DF3FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DErrorResult.Descriptor;
			}
		}

		// Token: 0x06005CAC RID: 23724 RVA: 0x000E1205 File Offset: 0x000DF405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult()
		{
		}

		// Token: 0x06005CAD RID: 23725 RVA: 0x000E1218 File Offset: 0x000DF418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult(DErrorResult other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005CAE RID: 23726 RVA: 0x000E124E File Offset: 0x000DF44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult Clone()
		{
			return new DErrorResult(this);
		}

		// Token: 0x1700112C RID: 4396
		// (get) Token: 0x06005CAF RID: 23727 RVA: 0x000E1256 File Offset: 0x000DF456
		// (set) Token: 0x06005CB0 RID: 23728 RVA: 0x000E125E File Offset: 0x000DF45E
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

		// Token: 0x1700112D RID: 4397
		// (get) Token: 0x06005CB1 RID: 23729 RVA: 0x000E1267 File Offset: 0x000DF467
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x06005CB2 RID: 23730 RVA: 0x000E126F File Offset: 0x000DF46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DErrorResult);
		}

		// Token: 0x06005CB3 RID: 23731 RVA: 0x000E1280 File Offset: 0x000DF480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DErrorResult other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005CB4 RID: 23732 RVA: 0x000E12D0 File Offset: 0x000DF4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.errorParams_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005CB5 RID: 23733 RVA: 0x000E1323 File Offset: 0x000DF523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005CB6 RID: 23734 RVA: 0x000E1330 File Offset: 0x000DF530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CB7 RID: 23735 RVA: 0x000E133C File Offset: 0x000DF53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.errorParams_.WriteTo(ref output, DErrorResult._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CB8 RID: 23736 RVA: 0x000E138C File Offset: 0x000DF58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(DErrorResult._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005CB9 RID: 23737 RVA: 0x000E13E0 File Offset: 0x000DF5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DErrorResult other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.errorParams_.Add(other.errorParams_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005CBA RID: 23738 RVA: 0x000E142D File Offset: 0x000DF62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005CBB RID: 23739 RVA: 0x000E1438 File Offset: 0x000DF638
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.errorParams_.AddEntriesFrom(ref input, DErrorResult._repeated_errorParams_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040036A8 RID: 13992
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036A9 RID: 13993
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040036AA RID: 13994
		private ErrorCode errorCode_;

		// Token: 0x040036AB RID: 13995
		public const int ErrorParamsFieldNumber = 2;

		// Token: 0x040036AC RID: 13996
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(18U);

		// Token: 0x040036AD RID: 13997
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
