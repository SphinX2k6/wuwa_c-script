using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000171 RID: 369
	[NetMessage(EMessageId.BattlePassResponse)]
	public sealed class BattlePassResponse : IMessage<BattlePassResponse>, IMessage, IEquatable<BattlePassResponse>, IDeepCloneable<BattlePassResponse>, IBufferMessage
	{
		// Token: 0x06002D60 RID: 11616 RVA: 0x00075672 File Offset: 0x00073872
		[NullableContext(1)]
		public static BattlePassResponse Create()
		{
			return new BattlePassResponse();
		}

		// Token: 0x170006DF RID: 1759
		// (get) Token: 0x06002D61 RID: 11617 RVA: 0x00075679 File Offset: 0x00073879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006E0 RID: 1760
		// (get) Token: 0x06002D62 RID: 11618 RVA: 0x0007567C File Offset: 0x0007387C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassResponse.Descriptor;
			}
		}

		// Token: 0x06002D63 RID: 11619 RVA: 0x00075683 File Offset: 0x00073883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassResponse()
		{
		}

		// Token: 0x06002D64 RID: 11620 RVA: 0x0007568C File Offset: 0x0007388C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassResponse(BattlePassResponse other) : this()
		{
			this.battlePass_ = ((other.battlePass_ != null) ? other.battlePass_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D65 RID: 11621 RVA: 0x000756D8 File Offset: 0x000738D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassResponse Clone()
		{
			return new BattlePassResponse(this);
		}

		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06002D66 RID: 11622 RVA: 0x000756E0 File Offset: 0x000738E0
		// (set) Token: 0x06002D67 RID: 11623 RVA: 0x000756E8 File Offset: 0x000738E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePass BattlePass
		{
			get
			{
				return this.battlePass_;
			}
			set
			{
				this.battlePass_ = value;
			}
		}

		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06002D68 RID: 11624 RVA: 0x000756F1 File Offset: 0x000738F1
		// (set) Token: 0x06002D69 RID: 11625 RVA: 0x000756F9 File Offset: 0x000738F9
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

		// Token: 0x06002D6A RID: 11626 RVA: 0x00075702 File Offset: 0x00073902
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassResponse);
		}

		// Token: 0x06002D6B RID: 11627 RVA: 0x00075710 File Offset: 0x00073910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassResponse other)
		{
			return other != null && (other == this || (object.Equals(this.BattlePass, other.BattlePass) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D6C RID: 11628 RVA: 0x00075760 File Offset: 0x00073960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.battlePass_ != null)
			{
				num ^= this.BattlePass.GetHashCode();
			}
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

		// Token: 0x06002D6D RID: 11629 RVA: 0x000757BB File Offset: 0x000739BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D6E RID: 11630 RVA: 0x000757C8 File Offset: 0x000739C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D6F RID: 11631 RVA: 0x000757D4 File Offset: 0x000739D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.battlePass_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.BattlePass);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D70 RID: 11632 RVA: 0x00075830 File Offset: 0x00073A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.battlePass_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BattlePass);
			}
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

		// Token: 0x06002D71 RID: 11633 RVA: 0x00075888 File Offset: 0x00073A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.battlePass_ != null)
			{
				if (this.battlePass_ == null)
				{
					this.BattlePass = new PbBattlePass();
				}
				this.BattlePass.MergeFrom(other.BattlePass);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D72 RID: 11634 RVA: 0x000758F0 File Offset: 0x00073AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D73 RID: 11635 RVA: 0x000758FC File Offset: 0x00073AFC
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.battlePass_ == null)
						{
							this.BattlePass = new PbBattlePass();
						}
						input.ReadMessage(this.BattlePass);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400282F RID: 10287
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002830 RID: 10288
		public const int BattlePassFieldNumber = 15;

		// Token: 0x04002831 RID: 10289
		private PbBattlePass battlePass_;

		// Token: 0x04002832 RID: 10290
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04002833 RID: 10291
		private ErrorCode errorCode_;
	}
}
