using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C4 RID: 964
	public sealed class DErrorResult : IMessage<DErrorResult>, IMessage, IEquatable<DErrorResult>, IDeepCloneable<DErrorResult>, IBufferMessage
	{
		// Token: 0x06005E39 RID: 24121 RVA: 0x000E4378 File Offset: 0x000E2578
		[NullableContext(1)]
		public static DErrorResult Create()
		{
			return new DErrorResult();
		}

		// Token: 0x1700117F RID: 4479
		// (get) Token: 0x06005E3A RID: 24122 RVA: 0x000E437F File Offset: 0x000E257F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x06005E3B RID: 24123 RVA: 0x000E4382 File Offset: 0x000E2582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DErrorResult.Descriptor;
			}
		}

		// Token: 0x06005E3C RID: 24124 RVA: 0x000E4389 File Offset: 0x000E2589
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult()
		{
		}

		// Token: 0x06005E3D RID: 24125 RVA: 0x000E439C File Offset: 0x000E259C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult(DErrorResult other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005E3E RID: 24126 RVA: 0x000E43D2 File Offset: 0x000E25D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult Clone()
		{
			return new DErrorResult(this);
		}

		// Token: 0x17001181 RID: 4481
		// (get) Token: 0x06005E3F RID: 24127 RVA: 0x000E43DA File Offset: 0x000E25DA
		// (set) Token: 0x06005E40 RID: 24128 RVA: 0x000E43E2 File Offset: 0x000E25E2
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

		// Token: 0x17001182 RID: 4482
		// (get) Token: 0x06005E41 RID: 24129 RVA: 0x000E43EB File Offset: 0x000E25EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x06005E42 RID: 24130 RVA: 0x000E43F3 File Offset: 0x000E25F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DErrorResult);
		}

		// Token: 0x06005E43 RID: 24131 RVA: 0x000E4404 File Offset: 0x000E2604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DErrorResult other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005E44 RID: 24132 RVA: 0x000E4454 File Offset: 0x000E2654
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

		// Token: 0x06005E45 RID: 24133 RVA: 0x000E44A7 File Offset: 0x000E26A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005E46 RID: 24134 RVA: 0x000E44B4 File Offset: 0x000E26B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005E47 RID: 24135 RVA: 0x000E44C0 File Offset: 0x000E26C0
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

		// Token: 0x06005E48 RID: 24136 RVA: 0x000E4510 File Offset: 0x000E2710
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

		// Token: 0x06005E49 RID: 24137 RVA: 0x000E4564 File Offset: 0x000E2764
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

		// Token: 0x06005E4A RID: 24138 RVA: 0x000E45B1 File Offset: 0x000E27B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005E4B RID: 24139 RVA: 0x000E45BC File Offset: 0x000E27BC
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

		// Token: 0x040036BB RID: 14011
		private UnknownFieldSet _unknownFields;

		// Token: 0x040036BC RID: 14012
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040036BD RID: 14013
		private ErrorCode errorCode_;

		// Token: 0x040036BE RID: 14014
		public const int ErrorParamsFieldNumber = 2;

		// Token: 0x040036BF RID: 14015
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(18U);

		// Token: 0x040036C0 RID: 14016
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
