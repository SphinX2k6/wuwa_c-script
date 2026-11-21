using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200141D RID: 5149
	[NetMessage(EMessageId.TowerDefenceRandListResponse)]
	public sealed class TowerDefenceRandListResponse : IMessage<TowerDefenceRandListResponse>, IMessage, IEquatable<TowerDefenceRandListResponse>, IDeepCloneable<TowerDefenceRandListResponse>, IBufferMessage
	{
		// Token: 0x0601B5E4 RID: 112100 RVA: 0x003FAD3D File Offset: 0x003F8F3D
		[NullableContext(1)]
		public static TowerDefenceRandListResponse Create()
		{
			return new TowerDefenceRandListResponse();
		}

		// Token: 0x17005CA6 RID: 23718
		// (get) Token: 0x0601B5E5 RID: 112101 RVA: 0x003FAD44 File Offset: 0x003F8F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CA7 RID: 23719
		// (get) Token: 0x0601B5E6 RID: 112102 RVA: 0x003FAD47 File Offset: 0x003F8F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRandListResponse.Descriptor;
			}
		}

		// Token: 0x0601B5E7 RID: 112103 RVA: 0x003FAD4E File Offset: 0x003F8F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRandListResponse()
		{
		}

		// Token: 0x0601B5E8 RID: 112104 RVA: 0x003FAD6C File Offset: 0x003F8F6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRandListResponse(TowerDefenceRandListResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.friendPassData_ = other.friendPassData_.Clone();
			this.selfPassData_ = other.selfPassData_.Clone();
			this.showName_ = other.showName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B5E9 RID: 112105 RVA: 0x003FADCA File Offset: 0x003F8FCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRandListResponse Clone()
		{
			return new TowerDefenceRandListResponse(this);
		}

		// Token: 0x17005CA8 RID: 23720
		// (get) Token: 0x0601B5EA RID: 112106 RVA: 0x003FADD2 File Offset: 0x003F8FD2
		// (set) Token: 0x0601B5EB RID: 112107 RVA: 0x003FADDA File Offset: 0x003F8FDA
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

		// Token: 0x17005CA9 RID: 23721
		// (get) Token: 0x0601B5EC RID: 112108 RVA: 0x003FADE3 File Offset: 0x003F8FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneTowerDefencePassInfo> FriendPassData
		{
			get
			{
				return this.friendPassData_;
			}
		}

		// Token: 0x17005CAA RID: 23722
		// (get) Token: 0x0601B5ED RID: 112109 RVA: 0x003FADEB File Offset: 0x003F8FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneTowerDefencePassInfo> SelfPassData
		{
			get
			{
				return this.selfPassData_;
			}
		}

		// Token: 0x17005CAB RID: 23723
		// (get) Token: 0x0601B5EE RID: 112110 RVA: 0x003FADF3 File Offset: 0x003F8FF3
		// (set) Token: 0x0601B5EF RID: 112111 RVA: 0x003FADFB File Offset: 0x003F8FFB
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

		// Token: 0x0601B5F0 RID: 112112 RVA: 0x003FAE04 File Offset: 0x003F9004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRandListResponse);
		}

		// Token: 0x0601B5F1 RID: 112113 RVA: 0x003FAE14 File Offset: 0x003F9014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRandListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.friendPassData_.Equals(other.friendPassData_) && this.selfPassData_.Equals(other.selfPassData_) && this.ShowName == other.ShowName && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B5F2 RID: 112114 RVA: 0x003FAE88 File Offset: 0x003F9088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.friendPassData_.GetHashCode();
			num ^= this.selfPassData_.GetHashCode();
			if (this.ShowName)
			{
				num ^= this.ShowName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B5F3 RID: 112115 RVA: 0x003FAF02 File Offset: 0x003F9102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B5F4 RID: 112116 RVA: 0x003FAF0F File Offset: 0x003F910F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B5F5 RID: 112117 RVA: 0x003FAF18 File Offset: 0x003F9118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShowName)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.ShowName);
			}
			this.friendPassData_.WriteTo(ref output, TowerDefenceRandListResponse._repeated_friendPassData_codec);
			this.selfPassData_.WriteTo(ref output, TowerDefenceRandListResponse._repeated_selfPassData_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B5F6 RID: 112118 RVA: 0x003FAF94 File Offset: 0x003F9194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.friendPassData_.CalculateSize(TowerDefenceRandListResponse._repeated_friendPassData_codec);
			num += this.selfPassData_.CalculateSize(TowerDefenceRandListResponse._repeated_selfPassData_codec);
			if (this.ShowName)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B5F7 RID: 112119 RVA: 0x003FB004 File Offset: 0x003F9204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceRandListResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.friendPassData_.Add(other.friendPassData_);
			this.selfPassData_.Add(other.selfPassData_);
			if (other.ShowName)
			{
				this.ShowName = other.ShowName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B5F8 RID: 112120 RVA: 0x003FB076 File Offset: 0x003F9276
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B5F9 RID: 112121 RVA: 0x003FB080 File Offset: 0x003F9280
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
				if (num <= 42U)
				{
					if (num == 24U)
					{
						this.ShowName = input.ReadBool();
						continue;
					}
					if (num == 42U)
					{
						this.friendPassData_.AddEntriesFrom(ref input, TowerDefenceRandListResponse._repeated_friendPassData_codec);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.selfPassData_.AddEntriesFrom(ref input, TowerDefenceRandListResponse._repeated_selfPassData_codec);
						continue;
					}
					if (num == 120U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009F65 RID: 40805
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F66 RID: 40806
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04009F67 RID: 40807
		private ErrorCode errorCode_;

		// Token: 0x04009F68 RID: 40808
		public const int FriendPassDataFieldNumber = 5;

		// Token: 0x04009F69 RID: 40809
		private static readonly FieldCodec<OneTowerDefencePassInfo> _repeated_friendPassData_codec = FieldCodec.ForMessage<OneTowerDefencePassInfo>(42U, OneTowerDefencePassInfo.Parser);

		// Token: 0x04009F6A RID: 40810
		private readonly RepeatedField<OneTowerDefencePassInfo> friendPassData_ = new RepeatedField<OneTowerDefencePassInfo>();

		// Token: 0x04009F6B RID: 40811
		public const int SelfPassDataFieldNumber = 9;

		// Token: 0x04009F6C RID: 40812
		private static readonly FieldCodec<OneTowerDefencePassInfo> _repeated_selfPassData_codec = FieldCodec.ForMessage<OneTowerDefencePassInfo>(74U, OneTowerDefencePassInfo.Parser);

		// Token: 0x04009F6D RID: 40813
		private readonly RepeatedField<OneTowerDefencePassInfo> selfPassData_ = new RepeatedField<OneTowerDefencePassInfo>();

		// Token: 0x04009F6E RID: 40814
		public const int ShowNameFieldNumber = 3;

		// Token: 0x04009F6F RID: 40815
		private bool showName_;
	}
}
