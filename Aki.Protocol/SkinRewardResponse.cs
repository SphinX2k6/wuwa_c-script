using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001283 RID: 4739
	[NetMessage(EMessageId.SkinRewardResponse)]
	public sealed class SkinRewardResponse : IMessage<SkinRewardResponse>, IMessage, IEquatable<SkinRewardResponse>, IDeepCloneable<SkinRewardResponse>, IBufferMessage
	{
		// Token: 0x060194C7 RID: 103623 RVA: 0x003B09F9 File Offset: 0x003AEBF9
		[NullableContext(1)]
		public static SkinRewardResponse Create()
		{
			return new SkinRewardResponse();
		}

		// Token: 0x17005590 RID: 21904
		// (get) Token: 0x060194C8 RID: 103624 RVA: 0x003B0A00 File Offset: 0x003AEC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005591 RID: 21905
		// (get) Token: 0x060194C9 RID: 103625 RVA: 0x003B0A03 File Offset: 0x003AEC03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkinRewardResponse.Descriptor;
			}
		}

		// Token: 0x060194CA RID: 103626 RVA: 0x003B0A0A File Offset: 0x003AEC0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardResponse()
		{
		}

		// Token: 0x060194CB RID: 103627 RVA: 0x003B0A12 File Offset: 0x003AEC12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardResponse(SkinRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060194CC RID: 103628 RVA: 0x003B0A37 File Offset: 0x003AEC37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardResponse Clone()
		{
			return new SkinRewardResponse(this);
		}

		// Token: 0x17005592 RID: 21906
		// (get) Token: 0x060194CD RID: 103629 RVA: 0x003B0A3F File Offset: 0x003AEC3F
		// (set) Token: 0x060194CE RID: 103630 RVA: 0x003B0A47 File Offset: 0x003AEC47
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

		// Token: 0x060194CF RID: 103631 RVA: 0x003B0A50 File Offset: 0x003AEC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkinRewardResponse);
		}

		// Token: 0x060194D0 RID: 103632 RVA: 0x003B0A5E File Offset: 0x003AEC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkinRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060194D1 RID: 103633 RVA: 0x003B0A8C File Offset: 0x003AEC8C
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

		// Token: 0x060194D2 RID: 103634 RVA: 0x003B0AD1 File Offset: 0x003AECD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060194D3 RID: 103635 RVA: 0x003B0ADE File Offset: 0x003AECDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060194D4 RID: 103636 RVA: 0x003B0AE7 File Offset: 0x003AECE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060194D5 RID: 103637 RVA: 0x003B0B1C File Offset: 0x003AED1C
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

		// Token: 0x060194D6 RID: 103638 RVA: 0x003B0B5A File Offset: 0x003AED5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkinRewardResponse other)
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

		// Token: 0x060194D7 RID: 103639 RVA: 0x003B0B8B File Offset: 0x003AED8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060194D8 RID: 103640 RVA: 0x003B0B94 File Offset: 0x003AED94
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040095AE RID: 38318
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095AF RID: 38319
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040095B0 RID: 38320
		private ErrorCode errorCode_;
	}
}
