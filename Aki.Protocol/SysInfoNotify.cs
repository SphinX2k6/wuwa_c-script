using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001385 RID: 4997
	[NetMessage(EMessageId.SysInfoNotify)]
	public sealed class SysInfoNotify : IMessage<SysInfoNotify>, IMessage, IEquatable<SysInfoNotify>, IDeepCloneable<SysInfoNotify>, IBufferMessage
	{
		// Token: 0x0601A9B5 RID: 108981 RVA: 0x003E068F File Offset: 0x003DE88F
		[NullableContext(1)]
		public static SysInfoNotify Create()
		{
			return new SysInfoNotify();
		}

		// Token: 0x17005A16 RID: 23062
		// (get) Token: 0x0601A9B6 RID: 108982 RVA: 0x003E0696 File Offset: 0x003DE896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A17 RID: 23063
		// (get) Token: 0x0601A9B7 RID: 108983 RVA: 0x003E0699 File Offset: 0x003DE899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SysInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601A9B8 RID: 108984 RVA: 0x003E06A0 File Offset: 0x003DE8A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysInfoNotify()
		{
		}

		// Token: 0x0601A9B9 RID: 108985 RVA: 0x003E06B4 File Offset: 0x003DE8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysInfoNotify(SysInfoNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.isShowErrorCodeTips_ = other.isShowErrorCodeTips_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A9BA RID: 108986 RVA: 0x003E0701 File Offset: 0x003DE901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SysInfoNotify Clone()
		{
			return new SysInfoNotify(this);
		}

		// Token: 0x17005A18 RID: 23064
		// (get) Token: 0x0601A9BB RID: 108987 RVA: 0x003E0709 File Offset: 0x003DE909
		// (set) Token: 0x0601A9BC RID: 108988 RVA: 0x003E0711 File Offset: 0x003DE911
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

		// Token: 0x17005A19 RID: 23065
		// (get) Token: 0x0601A9BD RID: 108989 RVA: 0x003E071A File Offset: 0x003DE91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x17005A1A RID: 23066
		// (get) Token: 0x0601A9BE RID: 108990 RVA: 0x003E0722 File Offset: 0x003DE922
		// (set) Token: 0x0601A9BF RID: 108991 RVA: 0x003E072A File Offset: 0x003DE92A
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

		// Token: 0x0601A9C0 RID: 108992 RVA: 0x003E0733 File Offset: 0x003DE933
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SysInfoNotify);
		}

		// Token: 0x0601A9C1 RID: 108993 RVA: 0x003E0744 File Offset: 0x003DE944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SysInfoNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && this.IsShowErrorCodeTips == other.IsShowErrorCodeTips && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A9C2 RID: 108994 RVA: 0x003E07A4 File Offset: 0x003DE9A4
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

		// Token: 0x0601A9C3 RID: 108995 RVA: 0x003E0810 File Offset: 0x003DEA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A9C4 RID: 108996 RVA: 0x003E081D File Offset: 0x003DEA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A9C5 RID: 108997 RVA: 0x003E0828 File Offset: 0x003DEA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.errorParams_.WriteTo(ref output, SysInfoNotify._repeated_errorParams_codec);
			if (this.IsShowErrorCodeTips)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsShowErrorCodeTips);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A9C6 RID: 108998 RVA: 0x003E0894 File Offset: 0x003DEA94
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

		// Token: 0x0601A9C7 RID: 108999 RVA: 0x003E08F4 File Offset: 0x003DEAF4
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

		// Token: 0x0601A9C8 RID: 109000 RVA: 0x003E0955 File Offset: 0x003DEB55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A9C9 RID: 109001 RVA: 0x003E0960 File Offset: 0x003DEB60
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
				if (num != 32U)
				{
					if (num != 90U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsShowErrorCodeTips = input.ReadBool();
						}
					}
					else
					{
						this.errorParams_.AddEntriesFrom(ref input, SysInfoNotify._repeated_errorParams_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009BED RID: 39917
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BEE RID: 39918
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04009BEF RID: 39919
		private ErrorCode errorCode_;

		// Token: 0x04009BF0 RID: 39920
		public const int ErrorParamsFieldNumber = 11;

		// Token: 0x04009BF1 RID: 39921
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(90U);

		// Token: 0x04009BF2 RID: 39922
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x04009BF3 RID: 39923
		public const int IsShowErrorCodeTipsFieldNumber = 14;

		// Token: 0x04009BF4 RID: 39924
		private bool isShowErrorCodeTips_;
	}
}
