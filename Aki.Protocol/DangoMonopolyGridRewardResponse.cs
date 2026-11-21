using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000390 RID: 912
	[NetMessage(EMessageId.DangoMonopolyGridRewardResponse)]
	public sealed class DangoMonopolyGridRewardResponse : IMessage<DangoMonopolyGridRewardResponse>, IMessage, IEquatable<DangoMonopolyGridRewardResponse>, IDeepCloneable<DangoMonopolyGridRewardResponse>, IBufferMessage
	{
		// Token: 0x06005A5A RID: 23130 RVA: 0x000DC3AD File Offset: 0x000DA5AD
		[NullableContext(1)]
		public static DangoMonopolyGridRewardResponse Create()
		{
			return new DangoMonopolyGridRewardResponse();
		}

		// Token: 0x170010B0 RID: 4272
		// (get) Token: 0x06005A5B RID: 23131 RVA: 0x000DC3B4 File Offset: 0x000DA5B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170010B1 RID: 4273
		// (get) Token: 0x06005A5C RID: 23132 RVA: 0x000DC3B7 File Offset: 0x000DA5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyGridRewardResponse.Descriptor;
			}
		}

		// Token: 0x06005A5D RID: 23133 RVA: 0x000DC3BE File Offset: 0x000DA5BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyGridRewardResponse()
		{
		}

		// Token: 0x06005A5E RID: 23134 RVA: 0x000DC3C6 File Offset: 0x000DA5C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyGridRewardResponse(DangoMonopolyGridRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.hasReward_ = other.hasReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005A5F RID: 23135 RVA: 0x000DC3F7 File Offset: 0x000DA5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyGridRewardResponse Clone()
		{
			return new DangoMonopolyGridRewardResponse(this);
		}

		// Token: 0x170010B2 RID: 4274
		// (get) Token: 0x06005A60 RID: 23136 RVA: 0x000DC3FF File Offset: 0x000DA5FF
		// (set) Token: 0x06005A61 RID: 23137 RVA: 0x000DC407 File Offset: 0x000DA607
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

		// Token: 0x170010B3 RID: 4275
		// (get) Token: 0x06005A62 RID: 23138 RVA: 0x000DC410 File Offset: 0x000DA610
		// (set) Token: 0x06005A63 RID: 23139 RVA: 0x000DC418 File Offset: 0x000DA618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasReward
		{
			get
			{
				return this.hasReward_;
			}
			set
			{
				this.hasReward_ = value;
			}
		}

		// Token: 0x06005A64 RID: 23140 RVA: 0x000DC421 File Offset: 0x000DA621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyGridRewardResponse);
		}

		// Token: 0x06005A65 RID: 23141 RVA: 0x000DC42F File Offset: 0x000DA62F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyGridRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.HasReward == other.HasReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005A66 RID: 23142 RVA: 0x000DC470 File Offset: 0x000DA670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.HasReward)
			{
				num ^= this.HasReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005A67 RID: 23143 RVA: 0x000DC4CE File Offset: 0x000DA6CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005A68 RID: 23144 RVA: 0x000DC4DB File Offset: 0x000DA6DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005A69 RID: 23145 RVA: 0x000DC4E4 File Offset: 0x000DA6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.HasReward)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.HasReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005A6A RID: 23146 RVA: 0x000DC540 File Offset: 0x000DA740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.HasReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005A6B RID: 23147 RVA: 0x000DC58C File Offset: 0x000DA78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyGridRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.HasReward)
			{
				this.HasReward = other.HasReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005A6C RID: 23148 RVA: 0x000DC5DC File Offset: 0x000DA7DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005A6D RID: 23149 RVA: 0x000DC5E8 File Offset: 0x000DA7E8
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
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.HasReward = input.ReadBool();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003600 RID: 13824
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003601 RID: 13825
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04003602 RID: 13826
		private ErrorCode errorCode_;

		// Token: 0x04003603 RID: 13827
		public const int HasRewardFieldNumber = 13;

		// Token: 0x04003604 RID: 13828
		private bool hasReward_;
	}
}
