using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B7 RID: 4791
	[NetMessage(EMessageId.SolarSchoolOneKeyRewardResponse)]
	public sealed class SolarSchoolOneKeyRewardResponse : IMessage<SolarSchoolOneKeyRewardResponse>, IMessage, IEquatable<SolarSchoolOneKeyRewardResponse>, IDeepCloneable<SolarSchoolOneKeyRewardResponse>, IBufferMessage
	{
		// Token: 0x06019926 RID: 104742 RVA: 0x003BACF4 File Offset: 0x003B8EF4
		[NullableContext(1)]
		public static SolarSchoolOneKeyRewardResponse Create()
		{
			return new SolarSchoolOneKeyRewardResponse();
		}

		// Token: 0x1700568C RID: 22156
		// (get) Token: 0x06019927 RID: 104743 RVA: 0x003BACFB File Offset: 0x003B8EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700568D RID: 22157
		// (get) Token: 0x06019928 RID: 104744 RVA: 0x003BACFE File Offset: 0x003B8EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolOneKeyRewardResponse.Descriptor;
			}
		}

		// Token: 0x06019929 RID: 104745 RVA: 0x003BAD05 File Offset: 0x003B8F05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneKeyRewardResponse()
		{
		}

		// Token: 0x0601992A RID: 104746 RVA: 0x003BAD0D File Offset: 0x003B8F0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneKeyRewardResponse(SolarSchoolOneKeyRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601992B RID: 104747 RVA: 0x003BAD32 File Offset: 0x003B8F32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolOneKeyRewardResponse Clone()
		{
			return new SolarSchoolOneKeyRewardResponse(this);
		}

		// Token: 0x1700568E RID: 22158
		// (get) Token: 0x0601992C RID: 104748 RVA: 0x003BAD3A File Offset: 0x003B8F3A
		// (set) Token: 0x0601992D RID: 104749 RVA: 0x003BAD42 File Offset: 0x003B8F42
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

		// Token: 0x0601992E RID: 104750 RVA: 0x003BAD4B File Offset: 0x003B8F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolOneKeyRewardResponse);
		}

		// Token: 0x0601992F RID: 104751 RVA: 0x003BAD59 File Offset: 0x003B8F59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolOneKeyRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019930 RID: 104752 RVA: 0x003BAD88 File Offset: 0x003B8F88
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

		// Token: 0x06019931 RID: 104753 RVA: 0x003BADCD File Offset: 0x003B8FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019932 RID: 104754 RVA: 0x003BADDA File Offset: 0x003B8FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019933 RID: 104755 RVA: 0x003BADE3 File Offset: 0x003B8FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x06019934 RID: 104756 RVA: 0x003BAE18 File Offset: 0x003B9018
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

		// Token: 0x06019935 RID: 104757 RVA: 0x003BAE56 File Offset: 0x003B9056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolOneKeyRewardResponse other)
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

		// Token: 0x06019936 RID: 104758 RVA: 0x003BAE87 File Offset: 0x003B9087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019937 RID: 104759 RVA: 0x003BAE90 File Offset: 0x003B9090
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009710 RID: 38672
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009711 RID: 38673
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04009712 RID: 38674
		private ErrorCode errorCode_;
	}
}
