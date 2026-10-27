using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008CC RID: 2252
	[NetMessage(EMessageId.KurotatoShopRewardSelectResponse)]
	public sealed class KurotatoShopRewardSelectResponse : IMessage<KurotatoShopRewardSelectResponse>, IMessage, IEquatable<KurotatoShopRewardSelectResponse>, IDeepCloneable<KurotatoShopRewardSelectResponse>, IBufferMessage
	{
		// Token: 0x0600C792 RID: 51090 RVA: 0x001D832D File Offset: 0x001D652D
		[NullableContext(1)]
		public static KurotatoShopRewardSelectResponse Create()
		{
			return new KurotatoShopRewardSelectResponse();
		}

		// Token: 0x17002854 RID: 10324
		// (get) Token: 0x0600C793 RID: 51091 RVA: 0x001D8334 File Offset: 0x001D6534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002855 RID: 10325
		// (get) Token: 0x0600C794 RID: 51092 RVA: 0x001D8337 File Offset: 0x001D6537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoShopRewardSelectResponse.Descriptor;
			}
		}

		// Token: 0x0600C795 RID: 51093 RVA: 0x001D833E File Offset: 0x001D653E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardSelectResponse()
		{
		}

		// Token: 0x0600C796 RID: 51094 RVA: 0x001D8348 File Offset: 0x001D6548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardSelectResponse(KurotatoShopRewardSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.panelPbData_ = ((other.panelPbData_ != null) ? other.panelPbData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C797 RID: 51095 RVA: 0x001D8394 File Offset: 0x001D6594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopRewardSelectResponse Clone()
		{
			return new KurotatoShopRewardSelectResponse(this);
		}

		// Token: 0x17002856 RID: 10326
		// (get) Token: 0x0600C798 RID: 51096 RVA: 0x001D839C File Offset: 0x001D659C
		// (set) Token: 0x0600C799 RID: 51097 RVA: 0x001D83A4 File Offset: 0x001D65A4
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

		// Token: 0x17002857 RID: 10327
		// (get) Token: 0x0600C79A RID: 51098 RVA: 0x001D83AD File Offset: 0x001D65AD
		// (set) Token: 0x0600C79B RID: 51099 RVA: 0x001D83B5 File Offset: 0x001D65B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoShopPanelPbData PanelPbData
		{
			get
			{
				return this.panelPbData_;
			}
			set
			{
				this.panelPbData_ = value;
			}
		}

		// Token: 0x0600C79C RID: 51100 RVA: 0x001D83BE File Offset: 0x001D65BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoShopRewardSelectResponse);
		}

		// Token: 0x0600C79D RID: 51101 RVA: 0x001D83CC File Offset: 0x001D65CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoShopRewardSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.PanelPbData, other.PanelPbData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C79E RID: 51102 RVA: 0x001D841C File Offset: 0x001D661C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.panelPbData_ != null)
			{
				num ^= this.PanelPbData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C79F RID: 51103 RVA: 0x001D8477 File Offset: 0x001D6677
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C7A0 RID: 51104 RVA: 0x001D8484 File Offset: 0x001D6684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C7A1 RID: 51105 RVA: 0x001D8490 File Offset: 0x001D6690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.panelPbData_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PanelPbData);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C7A2 RID: 51106 RVA: 0x001D84EC File Offset: 0x001D66EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.panelPbData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PanelPbData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C7A3 RID: 51107 RVA: 0x001D8544 File Offset: 0x001D6744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoShopRewardSelectResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.panelPbData_ != null)
			{
				if (this.panelPbData_ == null)
				{
					this.PanelPbData = new KurotatoShopPanelPbData();
				}
				this.PanelPbData.MergeFrom(other.PanelPbData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C7A4 RID: 51108 RVA: 0x001D85AC File Offset: 0x001D67AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C7A5 RID: 51109 RVA: 0x001D85B8 File Offset: 0x001D67B8
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
				if (num != 34U)
				{
					if (num != 72U)
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
					if (this.panelPbData_ == null)
					{
						this.PanelPbData = new KurotatoShopPanelPbData();
					}
					input.ReadMessage(this.PanelPbData);
				}
			}
		}

		// Token: 0x04005583 RID: 21891
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005584 RID: 21892
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04005585 RID: 21893
		private ErrorCode errorCode_;

		// Token: 0x04005586 RID: 21894
		public const int PanelPbDataFieldNumber = 4;

		// Token: 0x04005587 RID: 21895
		private KurotatoShopPanelPbData panelPbData_;
	}
}
