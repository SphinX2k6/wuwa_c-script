using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C3E RID: 3134
	[NetMessage(EMessageId.PhantomBattleCardGroupNameResponse)]
	public sealed class PhantomBattleCardGroupNameResponse : IMessage<PhantomBattleCardGroupNameResponse>, IMessage, IEquatable<PhantomBattleCardGroupNameResponse>, IDeepCloneable<PhantomBattleCardGroupNameResponse>, IBufferMessage
	{
		// Token: 0x06011056 RID: 69718 RVA: 0x0027EB7F File Offset: 0x0027CD7F
		[NullableContext(1)]
		public static PhantomBattleCardGroupNameResponse Create()
		{
			return new PhantomBattleCardGroupNameResponse();
		}

		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x06011057 RID: 69719 RVA: 0x0027EB86 File Offset: 0x0027CD86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x06011058 RID: 69720 RVA: 0x0027EB89 File Offset: 0x0027CD89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCardGroupNameResponse.Descriptor;
			}
		}

		// Token: 0x06011059 RID: 69721 RVA: 0x0027EB90 File Offset: 0x0027CD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupNameResponse()
		{
		}

		// Token: 0x0601105A RID: 69722 RVA: 0x0027EB98 File Offset: 0x0027CD98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupNameResponse(PhantomBattleCardGroupNameResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomBattleCardGroupInfo_ = ((other.phantomBattleCardGroupInfo_ != null) ? other.phantomBattleCardGroupInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601105B RID: 69723 RVA: 0x0027EBE4 File Offset: 0x0027CDE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupNameResponse Clone()
		{
			return new PhantomBattleCardGroupNameResponse(this);
		}

		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x0601105C RID: 69724 RVA: 0x0027EBEC File Offset: 0x0027CDEC
		// (set) Token: 0x0601105D RID: 69725 RVA: 0x0027EBF4 File Offset: 0x0027CDF4
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

		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x0601105E RID: 69726 RVA: 0x0027EBFD File Offset: 0x0027CDFD
		// (set) Token: 0x0601105F RID: 69727 RVA: 0x0027EC05 File Offset: 0x0027CE05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCardGroupInfo PhantomBattleCardGroupInfo
		{
			get
			{
				return this.phantomBattleCardGroupInfo_;
			}
			set
			{
				this.phantomBattleCardGroupInfo_ = value;
			}
		}

		// Token: 0x06011060 RID: 69728 RVA: 0x0027EC0E File Offset: 0x0027CE0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCardGroupNameResponse);
		}

		// Token: 0x06011061 RID: 69729 RVA: 0x0027EC1C File Offset: 0x0027CE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCardGroupNameResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PhantomBattleCardGroupInfo, other.PhantomBattleCardGroupInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011062 RID: 69730 RVA: 0x0027EC6C File Offset: 0x0027CE6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				num ^= this.PhantomBattleCardGroupInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011063 RID: 69731 RVA: 0x0027ECC7 File Offset: 0x0027CEC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011064 RID: 69732 RVA: 0x0027ECD4 File Offset: 0x0027CED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011065 RID: 69733 RVA: 0x0027ECE0 File Offset: 0x0027CEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.PhantomBattleCardGroupInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011066 RID: 69734 RVA: 0x0027ED3C File Offset: 0x0027CF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.phantomBattleCardGroupInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleCardGroupInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011067 RID: 69735 RVA: 0x0027ED94 File Offset: 0x0027CF94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCardGroupNameResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.phantomBattleCardGroupInfo_ != null)
			{
				if (this.phantomBattleCardGroupInfo_ == null)
				{
					this.PhantomBattleCardGroupInfo = new PhantomBattleCardGroupInfo();
				}
				this.PhantomBattleCardGroupInfo.MergeFrom(other.PhantomBattleCardGroupInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011068 RID: 69736 RVA: 0x0027EDFC File Offset: 0x0027CFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011069 RID: 69737 RVA: 0x0027EE08 File Offset: 0x0027D008
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
					if (num != 66U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.phantomBattleCardGroupInfo_ == null)
						{
							this.PhantomBattleCardGroupInfo = new PhantomBattleCardGroupInfo();
						}
						input.ReadMessage(this.PhantomBattleCardGroupInfo);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006C55 RID: 27733
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006C56 RID: 27734
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04006C57 RID: 27735
		private ErrorCode errorCode_;

		// Token: 0x04006C58 RID: 27736
		public const int PhantomBattleCardGroupInfoFieldNumber = 8;

		// Token: 0x04006C59 RID: 27737
		private PhantomBattleCardGroupInfo phantomBattleCardGroupInfo_;
	}
}
