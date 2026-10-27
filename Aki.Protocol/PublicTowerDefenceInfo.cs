using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF5 RID: 3573
	public sealed class PublicTowerDefenceInfo : IMessage<PublicTowerDefenceInfo>, IMessage, IEquatable<PublicTowerDefenceInfo>, IDeepCloneable<PublicTowerDefenceInfo>, IBufferMessage
	{
		// Token: 0x06013381 RID: 78721 RVA: 0x002CC8AE File Offset: 0x002CAAAE
		[NullableContext(1)]
		public static PublicTowerDefenceInfo Create()
		{
			return new PublicTowerDefenceInfo();
		}

		// Token: 0x17003FC6 RID: 16326
		// (get) Token: 0x06013382 RID: 78722 RVA: 0x002CC8B5 File Offset: 0x002CAAB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FC7 RID: 16327
		// (get) Token: 0x06013383 RID: 78723 RVA: 0x002CC8B8 File Offset: 0x002CAAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PublicTowerDefenceInfo.Descriptor;
			}
		}

		// Token: 0x06013384 RID: 78724 RVA: 0x002CC8BF File Offset: 0x002CAABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicTowerDefenceInfo()
		{
		}

		// Token: 0x06013385 RID: 78725 RVA: 0x002CC8E0 File Offset: 0x002CAAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicTowerDefenceInfo(PublicTowerDefenceInfo other) : this()
		{
			this.towerDefenceInfo_ = other.towerDefenceInfo_.Clone();
			this.showName_ = other.showName_;
			this.playerId_ = other.playerId_;
			this.name_ = other.name_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013386 RID: 78726 RVA: 0x002CC939 File Offset: 0x002CAB39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicTowerDefenceInfo Clone()
		{
			return new PublicTowerDefenceInfo(this);
		}

		// Token: 0x17003FC8 RID: 16328
		// (get) Token: 0x06013387 RID: 78727 RVA: 0x002CC941 File Offset: 0x002CAB41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneTowerDefencePassInfo> TowerDefenceInfo
		{
			get
			{
				return this.towerDefenceInfo_;
			}
		}

		// Token: 0x17003FC9 RID: 16329
		// (get) Token: 0x06013388 RID: 78728 RVA: 0x002CC949 File Offset: 0x002CAB49
		// (set) Token: 0x06013389 RID: 78729 RVA: 0x002CC951 File Offset: 0x002CAB51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowName
		{
			get
			{
				return this.showName_;
			}
			set
			{
				this.showName_ = value;
			}
		}

		// Token: 0x17003FCA RID: 16330
		// (get) Token: 0x0601338A RID: 78730 RVA: 0x002CC95A File Offset: 0x002CAB5A
		// (set) Token: 0x0601338B RID: 78731 RVA: 0x002CC962 File Offset: 0x002CAB62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17003FCB RID: 16331
		// (get) Token: 0x0601338C RID: 78732 RVA: 0x002CC96B File Offset: 0x002CAB6B
		// (set) Token: 0x0601338D RID: 78733 RVA: 0x002CC973 File Offset: 0x002CAB73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601338E RID: 78734 RVA: 0x002CC986 File Offset: 0x002CAB86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PublicTowerDefenceInfo);
		}

		// Token: 0x0601338F RID: 78735 RVA: 0x002CC994 File Offset: 0x002CAB94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PublicTowerDefenceInfo other)
		{
			return other != null && (other == this || (this.towerDefenceInfo_.Equals(other.towerDefenceInfo_) && this.ShowName == other.ShowName && this.PlayerId == other.PlayerId && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013390 RID: 78736 RVA: 0x002CCA08 File Offset: 0x002CAC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.towerDefenceInfo_.GetHashCode();
			if (this.ShowName)
			{
				num ^= this.ShowName.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013391 RID: 78737 RVA: 0x002CCA89 File Offset: 0x002CAC89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013392 RID: 78738 RVA: 0x002CCA96 File Offset: 0x002CAC96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013393 RID: 78739 RVA: 0x002CCAA0 File Offset: 0x002CACA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.towerDefenceInfo_.WriteTo(ref output, PublicTowerDefenceInfo._repeated_towerDefenceInfo_codec);
			if (this.ShowName)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.ShowName);
			}
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Name);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013394 RID: 78740 RVA: 0x002CCB2C File Offset: 0x002CAD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.towerDefenceInfo_.CalculateSize(PublicTowerDefenceInfo._repeated_towerDefenceInfo_codec);
			if (this.ShowName)
			{
				num += 2;
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013395 RID: 78741 RVA: 0x002CCBA8 File Offset: 0x002CADA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PublicTowerDefenceInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.towerDefenceInfo_.Add(other.towerDefenceInfo_);
			if (other.ShowName)
			{
				this.ShowName = other.ShowName;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013396 RID: 78742 RVA: 0x002CCC22 File Offset: 0x002CAE22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013397 RID: 78743 RVA: 0x002CCC2C File Offset: 0x002CAE2C
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
				if (num <= 16U)
				{
					if (num == 10U)
					{
						this.towerDefenceInfo_.AddEntriesFrom(ref input, PublicTowerDefenceInfo._repeated_towerDefenceInfo_codec);
						continue;
					}
					if (num == 16U)
					{
						this.ShowName = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.Name = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400764F RID: 30287
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007650 RID: 30288
		public const int TowerDefenceInfoFieldNumber = 1;

		// Token: 0x04007651 RID: 30289
		private static readonly FieldCodec<OneTowerDefencePassInfo> _repeated_towerDefenceInfo_codec = FieldCodec.ForMessage<OneTowerDefencePassInfo>(10U, OneTowerDefencePassInfo.Parser);

		// Token: 0x04007652 RID: 30290
		private readonly RepeatedField<OneTowerDefencePassInfo> towerDefenceInfo_ = new RepeatedField<OneTowerDefencePassInfo>();

		// Token: 0x04007653 RID: 30291
		public const int ShowNameFieldNumber = 2;

		// Token: 0x04007654 RID: 30292
		private bool showName_;

		// Token: 0x04007655 RID: 30293
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04007656 RID: 30294
		private int playerId_;

		// Token: 0x04007657 RID: 30295
		public const int NameFieldNumber = 4;

		// Token: 0x04007658 RID: 30296
		private string name_ = "";
	}
}
