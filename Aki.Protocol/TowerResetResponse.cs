using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200143A RID: 5178
	[NetMessage(EMessageId.TowerResetResponse)]
	public sealed class TowerResetResponse : IMessage<TowerResetResponse>, IMessage, IEquatable<TowerResetResponse>, IDeepCloneable<TowerResetResponse>, IBufferMessage
	{
		// Token: 0x0601B838 RID: 112696 RVA: 0x003FFCFD File Offset: 0x003FDEFD
		[NullableContext(1)]
		public static TowerResetResponse Create()
		{
			return new TowerResetResponse();
		}

		// Token: 0x17005D26 RID: 23846
		// (get) Token: 0x0601B839 RID: 112697 RVA: 0x003FFD04 File Offset: 0x003FDF04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D27 RID: 23847
		// (get) Token: 0x0601B83A RID: 112698 RVA: 0x003FFD07 File Offset: 0x003FDF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerResetResponse.Descriptor;
			}
		}

		// Token: 0x0601B83B RID: 112699 RVA: 0x003FFD0E File Offset: 0x003FDF0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResetResponse()
		{
		}

		// Token: 0x0601B83C RID: 112700 RVA: 0x003FFD16 File Offset: 0x003FDF16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResetResponse(TowerResetResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.towerConfigId_ = other.towerConfigId_;
			this.needUpdateSeason_ = other.needUpdateSeason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B83D RID: 112701 RVA: 0x003FFD53 File Offset: 0x003FDF53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerResetResponse Clone()
		{
			return new TowerResetResponse(this);
		}

		// Token: 0x17005D28 RID: 23848
		// (get) Token: 0x0601B83E RID: 112702 RVA: 0x003FFD5B File Offset: 0x003FDF5B
		// (set) Token: 0x0601B83F RID: 112703 RVA: 0x003FFD63 File Offset: 0x003FDF63
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

		// Token: 0x17005D29 RID: 23849
		// (get) Token: 0x0601B840 RID: 112704 RVA: 0x003FFD6C File Offset: 0x003FDF6C
		// (set) Token: 0x0601B841 RID: 112705 RVA: 0x003FFD74 File Offset: 0x003FDF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TowerConfigId
		{
			get
			{
				return this.towerConfigId_;
			}
			set
			{
				this.towerConfigId_ = value;
			}
		}

		// Token: 0x17005D2A RID: 23850
		// (get) Token: 0x0601B842 RID: 112706 RVA: 0x003FFD7D File Offset: 0x003FDF7D
		// (set) Token: 0x0601B843 RID: 112707 RVA: 0x003FFD85 File Offset: 0x003FDF85
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

		// Token: 0x0601B844 RID: 112708 RVA: 0x003FFD8E File Offset: 0x003FDF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerResetResponse);
		}

		// Token: 0x0601B845 RID: 112709 RVA: 0x003FFD9C File Offset: 0x003FDF9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerResetResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TowerConfigId == other.TowerConfigId && this.NeedUpdateSeason == other.NeedUpdateSeason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B846 RID: 112710 RVA: 0x003FFDF8 File Offset: 0x003FDFF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.TowerConfigId != 0)
			{
				num ^= this.TowerConfigId.GetHashCode();
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

		// Token: 0x0601B847 RID: 112711 RVA: 0x003FFE6F File Offset: 0x003FE06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B848 RID: 112712 RVA: 0x003FFE7C File Offset: 0x003FE07C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B849 RID: 112713 RVA: 0x003FFE88 File Offset: 0x003FE088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NeedUpdateSeason)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.NeedUpdateSeason);
			}
			if (this.TowerConfigId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.TowerConfigId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B84A RID: 112714 RVA: 0x003FFF00 File Offset: 0x003FE100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.TowerConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TowerConfigId);
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

		// Token: 0x0601B84B RID: 112715 RVA: 0x003FFF64 File Offset: 0x003FE164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerResetResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.TowerConfigId != 0)
			{
				this.TowerConfigId = other.TowerConfigId;
			}
			if (other.NeedUpdateSeason)
			{
				this.NeedUpdateSeason = other.NeedUpdateSeason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B84C RID: 112716 RVA: 0x003FFFC8 File Offset: 0x003FE1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B84D RID: 112717 RVA: 0x003FFFD4 File Offset: 0x003FE1D4
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
				if (num != 72U)
				{
					if (num != 88U)
					{
						if (num != 112U)
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
						this.TowerConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.NeedUpdateSeason = input.ReadBool();
				}
			}
		}

		// Token: 0x0400A017 RID: 40983
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A018 RID: 40984
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400A019 RID: 40985
		private ErrorCode errorCode_;

		// Token: 0x0400A01A RID: 40986
		public const int TowerConfigIdFieldNumber = 11;

		// Token: 0x0400A01B RID: 40987
		private int towerConfigId_;

		// Token: 0x0400A01C RID: 40988
		public const int NeedUpdateSeasonFieldNumber = 9;

		// Token: 0x0400A01D RID: 40989
		private bool needUpdateSeason_;
	}
}
