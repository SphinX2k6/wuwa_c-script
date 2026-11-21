using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200140A RID: 5130
	[NetMessage(EMessageId.TowerApplyFloorDataResponse)]
	public sealed class TowerApplyFloorDataResponse : IMessage<TowerApplyFloorDataResponse>, IMessage, IEquatable<TowerApplyFloorDataResponse>, IDeepCloneable<TowerApplyFloorDataResponse>, IBufferMessage
	{
		// Token: 0x0601B44F RID: 111695 RVA: 0x003F7535 File Offset: 0x003F5735
		[NullableContext(1)]
		public static TowerApplyFloorDataResponse Create()
		{
			return new TowerApplyFloorDataResponse();
		}

		// Token: 0x17005C4C RID: 23628
		// (get) Token: 0x0601B450 RID: 111696 RVA: 0x003F753C File Offset: 0x003F573C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C4D RID: 23629
		// (get) Token: 0x0601B451 RID: 111697 RVA: 0x003F753F File Offset: 0x003F573F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerApplyFloorDataResponse.Descriptor;
			}
		}

		// Token: 0x0601B452 RID: 111698 RVA: 0x003F7546 File Offset: 0x003F5746
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerApplyFloorDataResponse()
		{
		}

		// Token: 0x0601B453 RID: 111699 RVA: 0x003F754E File Offset: 0x003F574E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerApplyFloorDataResponse(TowerApplyFloorDataResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.needUpdateSeason_ = other.needUpdateSeason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B454 RID: 111700 RVA: 0x003F757F File Offset: 0x003F577F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerApplyFloorDataResponse Clone()
		{
			return new TowerApplyFloorDataResponse(this);
		}

		// Token: 0x17005C4E RID: 23630
		// (get) Token: 0x0601B455 RID: 111701 RVA: 0x003F7587 File Offset: 0x003F5787
		// (set) Token: 0x0601B456 RID: 111702 RVA: 0x003F758F File Offset: 0x003F578F
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

		// Token: 0x17005C4F RID: 23631
		// (get) Token: 0x0601B457 RID: 111703 RVA: 0x003F7598 File Offset: 0x003F5798
		// (set) Token: 0x0601B458 RID: 111704 RVA: 0x003F75A0 File Offset: 0x003F57A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedUpdateSeason
		{
			get
			{
				return this.needUpdateSeason_;
			}
			set
			{
				this.needUpdateSeason_ = value;
			}
		}

		// Token: 0x0601B459 RID: 111705 RVA: 0x003F75A9 File Offset: 0x003F57A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerApplyFloorDataResponse);
		}

		// Token: 0x0601B45A RID: 111706 RVA: 0x003F75B7 File Offset: 0x003F57B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerApplyFloorDataResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.NeedUpdateSeason == other.NeedUpdateSeason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B45B RID: 111707 RVA: 0x003F75F8 File Offset: 0x003F57F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.NeedUpdateSeason)
			{
				num ^= this.NeedUpdateSeason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B45C RID: 111708 RVA: 0x003F7656 File Offset: 0x003F5856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B45D RID: 111709 RVA: 0x003F7663 File Offset: 0x003F5863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B45E RID: 111710 RVA: 0x003F766C File Offset: 0x003F586C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.NeedUpdateSeason)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.NeedUpdateSeason);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B45F RID: 111711 RVA: 0x003F76C4 File Offset: 0x003F58C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.NeedUpdateSeason)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B460 RID: 111712 RVA: 0x003F7710 File Offset: 0x003F5910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerApplyFloorDataResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.NeedUpdateSeason)
			{
				this.NeedUpdateSeason = other.NeedUpdateSeason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B461 RID: 111713 RVA: 0x003F7760 File Offset: 0x003F5960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B462 RID: 111714 RVA: 0x003F776C File Offset: 0x003F596C
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
				if (num != 8U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NeedUpdateSeason = input.ReadBool();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009EE5 RID: 40677
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EE6 RID: 40678
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04009EE7 RID: 40679
		private ErrorCode errorCode_;

		// Token: 0x04009EE8 RID: 40680
		public const int NeedUpdateSeasonFieldNumber = 10;

		// Token: 0x04009EE9 RID: 40681
		private bool needUpdateSeason_;
	}
}
