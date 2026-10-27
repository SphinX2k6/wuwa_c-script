using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013CD RID: 5069
	[NetMessage(EMessageId.TowerSeasonUpdateResponse)]
	public sealed class TowerSeasonUpdateResponse : IMessage<TowerSeasonUpdateResponse>, IMessage, IEquatable<TowerSeasonUpdateResponse>, IDeepCloneable<TowerSeasonUpdateResponse>, IBufferMessage
	{
		// Token: 0x0601AE29 RID: 110121 RVA: 0x003E5AF6 File Offset: 0x003E3CF6
		[NullableContext(1)]
		public static TowerSeasonUpdateResponse Create()
		{
			return new TowerSeasonUpdateResponse();
		}

		// Token: 0x17005AAB RID: 23211
		// (get) Token: 0x0601AE2A RID: 110122 RVA: 0x003E5AFD File Offset: 0x003E3CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AAC RID: 23212
		// (get) Token: 0x0601AE2B RID: 110123 RVA: 0x003E5B00 File Offset: 0x003E3D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerSeasonUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0601AE2C RID: 110124 RVA: 0x003E5B07 File Offset: 0x003E3D07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerSeasonUpdateResponse()
		{
		}

		// Token: 0x0601AE2D RID: 110125 RVA: 0x003E5B10 File Offset: 0x003E3D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerSeasonUpdateResponse(TowerSeasonUpdateResponse other) : this()
		{
			this.towerInfo_ = ((other.towerInfo_ != null) ? other.towerInfo_.Clone() : null);
			this.maxUnlockDifficulty_ = other.maxUnlockDifficulty_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AE2E RID: 110126 RVA: 0x003E5B5C File Offset: 0x003E3D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerSeasonUpdateResponse Clone()
		{
			return new TowerSeasonUpdateResponse(this);
		}

		// Token: 0x17005AAD RID: 23213
		// (get) Token: 0x0601AE2F RID: 110127 RVA: 0x003E5B64 File Offset: 0x003E3D64
		// (set) Token: 0x0601AE30 RID: 110128 RVA: 0x003E5B6C File Offset: 0x003E3D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerInfo TowerInfo
		{
			get
			{
				return this.towerInfo_;
			}
			set
			{
				this.towerInfo_ = value;
			}
		}

		// Token: 0x17005AAE RID: 23214
		// (get) Token: 0x0601AE31 RID: 110129 RVA: 0x003E5B75 File Offset: 0x003E3D75
		// (set) Token: 0x0601AE32 RID: 110130 RVA: 0x003E5B7D File Offset: 0x003E3D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxUnlockDifficulty
		{
			get
			{
				return this.maxUnlockDifficulty_;
			}
			set
			{
				this.maxUnlockDifficulty_ = value;
			}
		}

		// Token: 0x0601AE33 RID: 110131 RVA: 0x003E5B86 File Offset: 0x003E3D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerSeasonUpdateResponse);
		}

		// Token: 0x0601AE34 RID: 110132 RVA: 0x003E5B94 File Offset: 0x003E3D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerSeasonUpdateResponse other)
		{
			return other != null && (other == this || (object.Equals(this.TowerInfo, other.TowerInfo) && this.MaxUnlockDifficulty == other.MaxUnlockDifficulty && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AE35 RID: 110133 RVA: 0x003E5BE4 File Offset: 0x003E3DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.towerInfo_ != null)
			{
				num ^= this.TowerInfo.GetHashCode();
			}
			if (this.MaxUnlockDifficulty != 0)
			{
				num ^= this.MaxUnlockDifficulty.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AE36 RID: 110134 RVA: 0x003E5C39 File Offset: 0x003E3E39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE37 RID: 110135 RVA: 0x003E5C46 File Offset: 0x003E3E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE38 RID: 110136 RVA: 0x003E5C50 File Offset: 0x003E3E50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxUnlockDifficulty != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MaxUnlockDifficulty);
			}
			if (this.towerInfo_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.TowerInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AE39 RID: 110137 RVA: 0x003E5CAC File Offset: 0x003E3EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.towerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TowerInfo);
			}
			if (this.MaxUnlockDifficulty != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxUnlockDifficulty);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AE3A RID: 110138 RVA: 0x003E5D04 File Offset: 0x003E3F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerSeasonUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.towerInfo_ != null)
			{
				if (this.towerInfo_ == null)
				{
					this.TowerInfo = new TowerInfo();
				}
				this.TowerInfo.MergeFrom(other.TowerInfo);
			}
			if (other.MaxUnlockDifficulty != 0)
			{
				this.MaxUnlockDifficulty = other.MaxUnlockDifficulty;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AE3B RID: 110139 RVA: 0x003E5D6C File Offset: 0x003E3F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE3C RID: 110140 RVA: 0x003E5D78 File Offset: 0x003E3F78
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
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.towerInfo_ == null)
						{
							this.TowerInfo = new TowerInfo();
						}
						input.ReadMessage(this.TowerInfo);
					}
				}
				else
				{
					this.MaxUnlockDifficulty = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009BF3 RID: 39923
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BF4 RID: 39924
		public const int TowerInfoFieldNumber = 11;

		// Token: 0x04009BF5 RID: 39925
		private TowerInfo towerInfo_;

		// Token: 0x04009BF6 RID: 39926
		public const int MaxUnlockDifficultyFieldNumber = 6;

		// Token: 0x04009BF7 RID: 39927
		private int maxUnlockDifficulty_;
	}
}
