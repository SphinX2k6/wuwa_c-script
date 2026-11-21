using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001384 RID: 4996
	[NetMessage(EMessageId.SysErrorNotify)]
	public sealed class SysErrorNotify : IMessage<SysErrorNotify>, IMessage, IEquatable<SysErrorNotify>, IDeepCloneable<SysErrorNotify>, IBufferMessage
	{
		// Token: 0x0601A9A1 RID: 108961 RVA: 0x003E03E2 File Offset: 0x003DE5E2
		[NullableContext(1)]
		public static SysErrorNotify Create()
		{
			return new SysErrorNotify();
		}

		// Token: 0x17005A12 RID: 23058
		// (get) Token: 0x0601A9A2 RID: 108962 RVA: 0x003E03E9 File Offset: 0x003DE5E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A13 RID: 23059
		// (get) Token: 0x0601A9A3 RID: 108963 RVA: 0x003E03EC File Offset: 0x003DE5EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SysErrorNotify.Descriptor;
			}
		}

		// Token: 0x0601A9A4 RID: 108964 RVA: 0x003E03F3 File Offset: 0x003DE5F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysErrorNotify()
		{
		}

		// Token: 0x0601A9A5 RID: 108965 RVA: 0x003E0406 File Offset: 0x003DE606
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysErrorNotify(SysErrorNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A9A6 RID: 108966 RVA: 0x003E043C File Offset: 0x003DE63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysErrorNotify Clone()
		{
			return new SysErrorNotify(this);
		}

		// Token: 0x17005A14 RID: 23060
		// (get) Token: 0x0601A9A7 RID: 108967 RVA: 0x003E0444 File Offset: 0x003DE644
		// (set) Token: 0x0601A9A8 RID: 108968 RVA: 0x003E044C File Offset: 0x003DE64C
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

		// Token: 0x17005A15 RID: 23061
		// (get) Token: 0x0601A9A9 RID: 108969 RVA: 0x003E0455 File Offset: 0x003DE655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x0601A9AA RID: 108970 RVA: 0x003E045D File Offset: 0x003DE65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SysErrorNotify);
		}

		// Token: 0x0601A9AB RID: 108971 RVA: 0x003E046C File Offset: 0x003DE66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SysErrorNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A9AC RID: 108972 RVA: 0x003E04BC File Offset: 0x003DE6BC
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

		// Token: 0x0601A9AD RID: 108973 RVA: 0x003E050F File Offset: 0x003DE70F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A9AE RID: 108974 RVA: 0x003E051C File Offset: 0x003DE71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A9AF RID: 108975 RVA: 0x003E0528 File Offset: 0x003DE728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.errorParams_.WriteTo(ref output, SysErrorNotify._repeated_errorParams_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A9B0 RID: 108976 RVA: 0x003E0578 File Offset: 0x003DE778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(SysErrorNotify._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A9B1 RID: 108977 RVA: 0x003E05CC File Offset: 0x003DE7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SysErrorNotify other)
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

		// Token: 0x0601A9B2 RID: 108978 RVA: 0x003E0619 File Offset: 0x003DE819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A9B3 RID: 108979 RVA: 0x003E0624 File Offset: 0x003DE824
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
				if (num != 50U)
				{
					if (num != 96U)
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
					this.errorParams_.AddEntriesFrom(ref input, SysErrorNotify._repeated_errorParams_codec);
				}
			}
		}

		// Token: 0x04009BE7 RID: 39911
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BE8 RID: 39912
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04009BE9 RID: 39913
		private ErrorCode errorCode_;

		// Token: 0x04009BEA RID: 39914
		public const int ErrorParamsFieldNumber = 6;

		// Token: 0x04009BEB RID: 39915
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(50U);

		// Token: 0x04009BEC RID: 39916
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();
	}
}
