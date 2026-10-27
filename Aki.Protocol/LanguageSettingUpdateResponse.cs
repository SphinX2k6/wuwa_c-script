using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008E5 RID: 2277
	[NetMessage(EMessageId.LanguageSettingUpdateResponse)]
	public sealed class LanguageSettingUpdateResponse : IMessage<LanguageSettingUpdateResponse>, IMessage, IEquatable<LanguageSettingUpdateResponse>, IDeepCloneable<LanguageSettingUpdateResponse>, IBufferMessage
	{
		// Token: 0x0600C978 RID: 51576 RVA: 0x001DC369 File Offset: 0x001DA569
		[NullableContext(1)]
		public static LanguageSettingUpdateResponse Create()
		{
			return new LanguageSettingUpdateResponse();
		}

		// Token: 0x170028B2 RID: 10418
		// (get) Token: 0x0600C979 RID: 51577 RVA: 0x001DC370 File Offset: 0x001DA570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028B3 RID: 10419
		// (get) Token: 0x0600C97A RID: 51578 RVA: 0x001DC373 File Offset: 0x001DA573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LanguageSettingUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0600C97B RID: 51579 RVA: 0x001DC37A File Offset: 0x001DA57A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LanguageSettingUpdateResponse()
		{
		}

		// Token: 0x0600C97C RID: 51580 RVA: 0x001DC382 File Offset: 0x001DA582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LanguageSettingUpdateResponse(LanguageSettingUpdateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C97D RID: 51581 RVA: 0x001DC3A7 File Offset: 0x001DA5A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LanguageSettingUpdateResponse Clone()
		{
			return new LanguageSettingUpdateResponse(this);
		}

		// Token: 0x170028B4 RID: 10420
		// (get) Token: 0x0600C97E RID: 51582 RVA: 0x001DC3AF File Offset: 0x001DA5AF
		// (set) Token: 0x0600C97F RID: 51583 RVA: 0x001DC3B7 File Offset: 0x001DA5B7
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

		// Token: 0x0600C980 RID: 51584 RVA: 0x001DC3C0 File Offset: 0x001DA5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LanguageSettingUpdateResponse);
		}

		// Token: 0x0600C981 RID: 51585 RVA: 0x001DC3CE File Offset: 0x001DA5CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LanguageSettingUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C982 RID: 51586 RVA: 0x001DC3FC File Offset: 0x001DA5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0600C983 RID: 51587 RVA: 0x001DC441 File Offset: 0x001DA641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C984 RID: 51588 RVA: 0x001DC44E File Offset: 0x001DA64E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C985 RID: 51589 RVA: 0x001DC457 File Offset: 0x001DA657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C986 RID: 51590 RVA: 0x001DC48C File Offset: 0x001DA68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x0600C987 RID: 51591 RVA: 0x001DC4CA File Offset: 0x001DA6CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LanguageSettingUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C988 RID: 51592 RVA: 0x001DC4FB File Offset: 0x001DA6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C989 RID: 51593 RVA: 0x001DC504 File Offset: 0x001DA704
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040055F1 RID: 22001
		private UnknownFieldSet _unknownFields;

		// Token: 0x040055F2 RID: 22002
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040055F3 RID: 22003
		private ErrorCode errorCode_;
	}
}
