using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000153 RID: 339
	[NetMessage(EMessageId.BabelTowerSelfPassResponse)]
	public sealed class BabelTowerSelfPassResponse : IMessage<BabelTowerSelfPassResponse>, IMessage, IEquatable<BabelTowerSelfPassResponse>, IDeepCloneable<BabelTowerSelfPassResponse>, IBufferMessage
	{
		// Token: 0x06002B48 RID: 11080 RVA: 0x000714F5 File Offset: 0x0006F6F5
		[NullableContext(1)]
		public static BabelTowerSelfPassResponse Create()
		{
			return new BabelTowerSelfPassResponse();
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06002B49 RID: 11081 RVA: 0x000714FC File Offset: 0x0006F6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06002B4A RID: 11082 RVA: 0x000714FF File Offset: 0x0006F6FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerSelfPassResponse.Descriptor;
			}
		}

		// Token: 0x06002B4B RID: 11083 RVA: 0x00071506 File Offset: 0x0006F706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSelfPassResponse()
		{
		}

		// Token: 0x06002B4C RID: 11084 RVA: 0x00071510 File Offset: 0x0006F710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSelfPassResponse(BabelTowerSelfPassResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.selfPassData_ = ((other.selfPassData_ != null) ? other.selfPassData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x0007155C File Offset: 0x0006F75C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerSelfPassResponse Clone()
		{
			return new BabelTowerSelfPassResponse(this);
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06002B4E RID: 11086 RVA: 0x00071564 File Offset: 0x0006F764
		// (set) Token: 0x06002B4F RID: 11087 RVA: 0x0007156C File Offset: 0x0006F76C
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

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06002B50 RID: 11088 RVA: 0x00071575 File Offset: 0x0006F775
		// (set) Token: 0x06002B51 RID: 11089 RVA: 0x0007157D File Offset: 0x0006F77D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicBabelTowerInfo SelfPassData
		{
			get
			{
				return this.selfPassData_;
			}
			set
			{
				this.selfPassData_ = value;
			}
		}

		// Token: 0x06002B52 RID: 11090 RVA: 0x00071586 File Offset: 0x0006F786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerSelfPassResponse);
		}

		// Token: 0x06002B53 RID: 11091 RVA: 0x00071594 File Offset: 0x0006F794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerSelfPassResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.SelfPassData, other.SelfPassData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B54 RID: 11092 RVA: 0x000715E4 File Offset: 0x0006F7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.selfPassData_ != null)
			{
				num ^= this.SelfPassData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002B55 RID: 11093 RVA: 0x0007163F File Offset: 0x0006F83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B56 RID: 11094 RVA: 0x0007164C File Offset: 0x0006F84C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B57 RID: 11095 RVA: 0x00071658 File Offset: 0x0006F858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.selfPassData_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SelfPassData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B58 RID: 11096 RVA: 0x000716B4 File Offset: 0x0006F8B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.selfPassData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SelfPassData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002B59 RID: 11097 RVA: 0x0007170C File Offset: 0x0006F90C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerSelfPassResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.selfPassData_ != null)
			{
				if (this.selfPassData_ == null)
				{
					this.SelfPassData = new PublicBabelTowerInfo();
				}
				this.SelfPassData.MergeFrom(other.SelfPassData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002B5A RID: 11098 RVA: 0x00071774 File Offset: 0x0006F974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B5B RID: 11099 RVA: 0x00071780 File Offset: 0x0006F980
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
				if (num != 16U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.selfPassData_ == null)
						{
							this.SelfPassData = new PublicBabelTowerInfo();
						}
						input.ReadMessage(this.SelfPassData);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040027F0 RID: 10224
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027F1 RID: 10225
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040027F2 RID: 10226
		private ErrorCode errorCode_;

		// Token: 0x040027F3 RID: 10227
		public const int SelfPassDataFieldNumber = 11;

		// Token: 0x040027F4 RID: 10228
		private PublicBabelTowerInfo selfPassData_;
	}
}
