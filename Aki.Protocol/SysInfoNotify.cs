using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001318 RID: 4888
	[NetMessage(EMessageId.SysInfoNotify)]
	public sealed class SysInfoNotify : IMessage<SysInfoNotify>, IMessage, IEquatable<SysInfoNotify>, IDeepCloneable<SysInfoNotify>, IBufferMessage
	{
		// Token: 0x06019FA5 RID: 106405 RVA: 0x003C63D3 File Offset: 0x003C45D3
		[NullableContext(1)]
		public static SysInfoNotify Create()
		{
			return new SysInfoNotify();
		}

		// Token: 0x1700579C RID: 22428
		// (get) Token: 0x06019FA6 RID: 106406 RVA: 0x003C63DA File Offset: 0x003C45DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700579D RID: 22429
		// (get) Token: 0x06019FA7 RID: 106407 RVA: 0x003C63DD File Offset: 0x003C45DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SysInfoNotify.Descriptor;
			}
		}

		// Token: 0x06019FA8 RID: 106408 RVA: 0x003C63E4 File Offset: 0x003C45E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysInfoNotify()
		{
		}

		// Token: 0x06019FA9 RID: 106409 RVA: 0x003C63F8 File Offset: 0x003C45F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysInfoNotify(SysInfoNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.isShowErrorCodeTips_ = other.isShowErrorCodeTips_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019FAA RID: 106410 RVA: 0x003C6445 File Offset: 0x003C4645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysInfoNotify Clone()
		{
			return new SysInfoNotify(this);
		}

		// Token: 0x1700579E RID: 22430
		// (get) Token: 0x06019FAB RID: 106411 RVA: 0x003C644D File Offset: 0x003C464D
		// (set) Token: 0x06019FAC RID: 106412 RVA: 0x003C6455 File Offset: 0x003C4655
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

		// Token: 0x1700579F RID: 22431
		// (get) Token: 0x06019FAD RID: 106413 RVA: 0x003C645E File Offset: 0x003C465E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x170057A0 RID: 22432
		// (get) Token: 0x06019FAE RID: 106414 RVA: 0x003C6466 File Offset: 0x003C4666
		// (set) Token: 0x06019FAF RID: 106415 RVA: 0x003C646E File Offset: 0x003C466E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShowErrorCodeTips
		{
			get
			{
				return this.isShowErrorCodeTips_;
			}
			set
			{
				this.isShowErrorCodeTips_ = value;
			}
		}

		// Token: 0x06019FB0 RID: 106416 RVA: 0x003C6477 File Offset: 0x003C4677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SysInfoNotify);
		}

		// Token: 0x06019FB1 RID: 106417 RVA: 0x003C6488 File Offset: 0x003C4688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SysInfoNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && this.IsShowErrorCodeTips == other.IsShowErrorCodeTips && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019FB2 RID: 106418 RVA: 0x003C64E8 File Offset: 0x003C46E8
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
			if (this.IsShowErrorCodeTips)
			{
				num ^= this.IsShowErrorCodeTips.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019FB3 RID: 106419 RVA: 0x003C6554 File Offset: 0x003C4754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019FB4 RID: 106420 RVA: 0x003C6561 File Offset: 0x003C4761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019FB5 RID: 106421 RVA: 0x003C656C File Offset: 0x003C476C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsShowErrorCodeTips)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsShowErrorCodeTips);
			}
			this.errorParams_.WriteTo(ref output, SysInfoNotify._repeated_errorParams_codec);
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

		// Token: 0x06019FB6 RID: 106422 RVA: 0x003C65D8 File Offset: 0x003C47D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(SysInfoNotify._repeated_errorParams_codec);
			if (this.IsShowErrorCodeTips)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019FB7 RID: 106423 RVA: 0x003C6638 File Offset: 0x003C4838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SysInfoNotify other)
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
			if (other.IsShowErrorCodeTips)
			{
				this.IsShowErrorCodeTips = other.IsShowErrorCodeTips;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019FB8 RID: 106424 RVA: 0x003C6699 File Offset: 0x003C4899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019FB9 RID: 106425 RVA: 0x003C66A4 File Offset: 0x003C48A4
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
				if (num != 48U)
				{
					if (num != 114U)
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
						this.errorParams_.AddEntriesFrom(ref input, SysInfoNotify._repeated_errorParams_codec);
					}
				}
				else
				{
					this.IsShowErrorCodeTips = input.ReadBool();
				}
			}
		}

		// Token: 0x040097CB RID: 38859
		private UnknownFieldSet _unknownFields;

		// Token: 0x040097CC RID: 38860
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040097CD RID: 38861
		private ErrorCode errorCode_;

		// Token: 0x040097CE RID: 38862
		public const int ErrorParamsFieldNumber = 14;

		// Token: 0x040097CF RID: 38863
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(114U);

		// Token: 0x040097D0 RID: 38864
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x040097D1 RID: 38865
		public const int IsShowErrorCodeTipsFieldNumber = 6;

		// Token: 0x040097D2 RID: 38866
		private bool isShowErrorCodeTips_;
	}
}
