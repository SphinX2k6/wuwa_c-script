using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE5 RID: 3557
	public sealed class PublicTowerDefenceInfo : IMessage<PublicTowerDefenceInfo>, IMessage, IEquatable<PublicTowerDefenceInfo>, IDeepCloneable<PublicTowerDefenceInfo>, IBufferMessage
	{
		// Token: 0x0601329C RID: 78492 RVA: 0x002CB1EA File Offset: 0x002C93EA
		[NullableContext(1)]
		public static PublicTowerDefenceInfo Create()
		{
			return new PublicTowerDefenceInfo();
		}

		// Token: 0x17003F9C RID: 16284
		// (get) Token: 0x0601329D RID: 78493 RVA: 0x002CB1F1 File Offset: 0x002C93F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F9D RID: 16285
		// (get) Token: 0x0601329E RID: 78494 RVA: 0x002CB1F4 File Offset: 0x002C93F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PublicTowerDefenceInfo.Descriptor;
			}
		}

		// Token: 0x0601329F RID: 78495 RVA: 0x002CB1FB File Offset: 0x002C93FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicTowerDefenceInfo()
		{
		}

		// Token: 0x060132A0 RID: 78496 RVA: 0x002CB21C File Offset: 0x002C941C
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

		// Token: 0x060132A1 RID: 78497 RVA: 0x002CB275 File Offset: 0x002C9475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicTowerDefenceInfo Clone()
		{
			return new PublicTowerDefenceInfo(this);
		}

		// Token: 0x17003F9E RID: 16286
		// (get) Token: 0x060132A2 RID: 78498 RVA: 0x002CB27D File Offset: 0x002C947D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneTowerDefencePassInfo> TowerDefenceInfo
		{
			get
			{
				return this.towerDefenceInfo_;
			}
		}

		// Token: 0x17003F9F RID: 16287
		// (get) Token: 0x060132A3 RID: 78499 RVA: 0x002CB285 File Offset: 0x002C9485
		// (set) Token: 0x060132A4 RID: 78500 RVA: 0x002CB28D File Offset: 0x002C948D
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

		// Token: 0x17003FA0 RID: 16288
		// (get) Token: 0x060132A5 RID: 78501 RVA: 0x002CB296 File Offset: 0x002C9496
		// (set) Token: 0x060132A6 RID: 78502 RVA: 0x002CB29E File Offset: 0x002C949E
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

		// Token: 0x17003FA1 RID: 16289
		// (get) Token: 0x060132A7 RID: 78503 RVA: 0x002CB2A7 File Offset: 0x002C94A7
		// (set) Token: 0x060132A8 RID: 78504 RVA: 0x002CB2AF File Offset: 0x002C94AF
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

		// Token: 0x060132A9 RID: 78505 RVA: 0x002CB2C2 File Offset: 0x002C94C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PublicTowerDefenceInfo);
		}

		// Token: 0x060132AA RID: 78506 RVA: 0x002CB2D0 File Offset: 0x002C94D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PublicTowerDefenceInfo other)
		{
			return other != null && (other == this || (this.towerDefenceInfo_.Equals(other.towerDefenceInfo_) && this.ShowName == other.ShowName && this.PlayerId == other.PlayerId && !(this.Name != other.Name) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060132AB RID: 78507 RVA: 0x002CB344 File Offset: 0x002C9544
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

		// Token: 0x060132AC RID: 78508 RVA: 0x002CB3C5 File Offset: 0x002C95C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060132AD RID: 78509 RVA: 0x002CB3D2 File Offset: 0x002C95D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060132AE RID: 78510 RVA: 0x002CB3DC File Offset: 0x002C95DC
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

		// Token: 0x060132AF RID: 78511 RVA: 0x002CB468 File Offset: 0x002C9668
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

		// Token: 0x060132B0 RID: 78512 RVA: 0x002CB4E4 File Offset: 0x002C96E4
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

		// Token: 0x060132B1 RID: 78513 RVA: 0x002CB55E File Offset: 0x002C975E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060132B2 RID: 78514 RVA: 0x002CB568 File Offset: 0x002C9768
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

		// Token: 0x04007679 RID: 30329
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400767A RID: 30330
		public const int TowerDefenceInfoFieldNumber = 1;

		// Token: 0x0400767B RID: 30331
		private static readonly FieldCodec<OneTowerDefencePassInfo> _repeated_towerDefenceInfo_codec = FieldCodec.ForMessage<OneTowerDefencePassInfo>(10U, OneTowerDefencePassInfo.Parser);

		// Token: 0x0400767C RID: 30332
		private readonly RepeatedField<OneTowerDefencePassInfo> towerDefenceInfo_ = new RepeatedField<OneTowerDefencePassInfo>();

		// Token: 0x0400767D RID: 30333
		public const int ShowNameFieldNumber = 2;

		// Token: 0x0400767E RID: 30334
		private bool showName_;

		// Token: 0x0400767F RID: 30335
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04007680 RID: 30336
		private int playerId_;

		// Token: 0x04007681 RID: 30337
		public const int NameFieldNumber = 4;

		// Token: 0x04007682 RID: 30338
		private string name_ = "";
	}
}
