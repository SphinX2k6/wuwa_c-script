using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013AA RID: 5034
	[NetMessage(EMessageId.TowerDefenceRandListResponse)]
	public sealed class TowerDefenceRandListResponse : IMessage<TowerDefenceRandListResponse>, IMessage, IEquatable<TowerDefenceRandListResponse>, IDeepCloneable<TowerDefenceRandListResponse>, IBufferMessage
	{
		// Token: 0x0601AB59 RID: 109401 RVA: 0x003DFA7D File Offset: 0x003DDC7D
		[NullableContext(1)]
		public static TowerDefenceRandListResponse Create()
		{
			return new TowerDefenceRandListResponse();
		}

		// Token: 0x17005A11 RID: 23057
		// (get) Token: 0x0601AB5A RID: 109402 RVA: 0x003DFA84 File Offset: 0x003DDC84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A12 RID: 23058
		// (get) Token: 0x0601AB5B RID: 109403 RVA: 0x003DFA87 File Offset: 0x003DDC87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceRandListResponse.Descriptor;
			}
		}

		// Token: 0x0601AB5C RID: 109404 RVA: 0x003DFA8E File Offset: 0x003DDC8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRandListResponse()
		{
		}

		// Token: 0x0601AB5D RID: 109405 RVA: 0x003DFAAC File Offset: 0x003DDCAC
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

		// Token: 0x0601AB5E RID: 109406 RVA: 0x003DFB0A File Offset: 0x003DDD0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceRandListResponse Clone()
		{
			return new TowerDefenceRandListResponse(this);
		}

		// Token: 0x17005A13 RID: 23059
		// (get) Token: 0x0601AB5F RID: 109407 RVA: 0x003DFB12 File Offset: 0x003DDD12
		// (set) Token: 0x0601AB60 RID: 109408 RVA: 0x003DFB1A File Offset: 0x003DDD1A
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

		// Token: 0x17005A14 RID: 23060
		// (get) Token: 0x0601AB61 RID: 109409 RVA: 0x003DFB23 File Offset: 0x003DDD23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneTowerDefencePassInfo> FriendPassData
		{
			get
			{
				return this.friendPassData_;
			}
		}

		// Token: 0x17005A15 RID: 23061
		// (get) Token: 0x0601AB62 RID: 109410 RVA: 0x003DFB2B File Offset: 0x003DDD2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneTowerDefencePassInfo> SelfPassData
		{
			get
			{
				return this.selfPassData_;
			}
		}

		// Token: 0x17005A16 RID: 23062
		// (get) Token: 0x0601AB63 RID: 109411 RVA: 0x003DFB33 File Offset: 0x003DDD33
		// (set) Token: 0x0601AB64 RID: 109412 RVA: 0x003DFB3B File Offset: 0x003DDD3B
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

		// Token: 0x0601AB65 RID: 109413 RVA: 0x003DFB44 File Offset: 0x003DDD44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceRandListResponse);
		}

		// Token: 0x0601AB66 RID: 109414 RVA: 0x003DFB54 File Offset: 0x003DDD54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceRandListResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.friendPassData_.Equals(other.friendPassData_) && this.selfPassData_.Equals(other.selfPassData_) && this.ShowName == other.ShowName && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB67 RID: 109415 RVA: 0x003DFBC8 File Offset: 0x003DDDC8
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

		// Token: 0x0601AB68 RID: 109416 RVA: 0x003DFC42 File Offset: 0x003DDE42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB69 RID: 109417 RVA: 0x003DFC4F File Offset: 0x003DDE4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB6A RID: 109418 RVA: 0x003DFC58 File Offset: 0x003DDE58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ShowName)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.ShowName);
			}
			this.selfPassData_.WriteTo(ref output, TowerDefenceRandListResponse._repeated_selfPassData_codec);
			this.friendPassData_.WriteTo(ref output, TowerDefenceRandListResponse._repeated_friendPassData_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AB6B RID: 109419 RVA: 0x003DFCD4 File Offset: 0x003DDED4
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

		// Token: 0x0601AB6C RID: 109420 RVA: 0x003DFD44 File Offset: 0x003DDF44
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

		// Token: 0x0601AB6D RID: 109421 RVA: 0x003DFDB6 File Offset: 0x003DDFB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB6E RID: 109422 RVA: 0x003DFDC0 File Offset: 0x003DDFC0
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
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 32U)
					{
						this.ShowName = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 42U)
					{
						this.selfPassData_.AddEntriesFrom(ref input, TowerDefenceRandListResponse._repeated_selfPassData_codec);
						continue;
					}
					if (num == 58U)
					{
						this.friendPassData_.AddEntriesFrom(ref input, TowerDefenceRandListResponse._repeated_friendPassData_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009B1E RID: 39710
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B1F RID: 39711
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04009B20 RID: 39712
		private ErrorCode errorCode_;

		// Token: 0x04009B21 RID: 39713
		public const int FriendPassDataFieldNumber = 7;

		// Token: 0x04009B22 RID: 39714
		private static readonly FieldCodec<OneTowerDefencePassInfo> _repeated_friendPassData_codec = FieldCodec.ForMessage<OneTowerDefencePassInfo>(58U, OneTowerDefencePassInfo.Parser);

		// Token: 0x04009B23 RID: 39715
		private readonly RepeatedField<OneTowerDefencePassInfo> friendPassData_ = new RepeatedField<OneTowerDefencePassInfo>();

		// Token: 0x04009B24 RID: 39716
		public const int SelfPassDataFieldNumber = 5;

		// Token: 0x04009B25 RID: 39717
		private static readonly FieldCodec<OneTowerDefencePassInfo> _repeated_selfPassData_codec = FieldCodec.ForMessage<OneTowerDefencePassInfo>(42U, OneTowerDefencePassInfo.Parser);

		// Token: 0x04009B26 RID: 39718
		private readonly RepeatedField<OneTowerDefencePassInfo> selfPassData_ = new RepeatedField<OneTowerDefencePassInfo>();

		// Token: 0x04009B27 RID: 39719
		public const int ShowNameFieldNumber = 4;

		// Token: 0x04009B28 RID: 39720
		private bool showName_;
	}
}
