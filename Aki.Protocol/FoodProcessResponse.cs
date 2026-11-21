using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000607 RID: 1543
	[NetMessage(EMessageId.FoodProcessResponse)]
	public sealed class FoodProcessResponse : IMessage<FoodProcessResponse>, IMessage, IEquatable<FoodProcessResponse>, IDeepCloneable<FoodProcessResponse>, IBufferMessage
	{
		// Token: 0x06008EF2 RID: 36594 RVA: 0x0015AAB5 File Offset: 0x00158CB5
		[NullableContext(1)]
		public static FoodProcessResponse Create()
		{
			return new FoodProcessResponse();
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x06008EF3 RID: 36595 RVA: 0x0015AABC File Offset: 0x00158CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x06008EF4 RID: 36596 RVA: 0x0015AABF File Offset: 0x00158CBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoodProcessResponse.Descriptor;
			}
		}

		// Token: 0x06008EF5 RID: 36597 RVA: 0x0015AAC6 File Offset: 0x00158CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoodProcessResponse()
		{
		}

		// Token: 0x06008EF6 RID: 36598 RVA: 0x0015AAE4 File Offset: 0x00158CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoodProcessResponse(FoodProcessResponse other) : this()
		{
			this.code_ = other.code_;
			this.id_ = other.id_;
			this.finalFood_ = other.finalFood_.Clone();
			this.lockState_ = other.lockState_;
			this.unlockParam_ = other.unlockParam_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008EF7 RID: 36599 RVA: 0x0015AB4E File Offset: 0x00158D4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoodProcessResponse Clone()
		{
			return new FoodProcessResponse(this);
		}

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x06008EF8 RID: 36600 RVA: 0x0015AB56 File Offset: 0x00158D56
		// (set) Token: 0x06008EF9 RID: 36601 RVA: 0x0015AB5E File Offset: 0x00158D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x06008EFA RID: 36602 RVA: 0x0015AB67 File Offset: 0x00158D67
		// (set) Token: 0x06008EFB RID: 36603 RVA: 0x0015AB6F File Offset: 0x00158D6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x06008EFC RID: 36604 RVA: 0x0015AB78 File Offset: 0x00158D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> FinalFood
		{
			get
			{
				return this.finalFood_;
			}
		}

		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x06008EFD RID: 36605 RVA: 0x0015AB80 File Offset: 0x00158D80
		// (set) Token: 0x06008EFE RID: 36606 RVA: 0x0015AB88 File Offset: 0x00158D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool LockState
		{
			get
			{
				return this.lockState_;
			}
			set
			{
				this.lockState_ = value;
			}
		}

		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x06008EFF RID: 36607 RVA: 0x0015AB91 File Offset: 0x00158D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockParam
		{
			get
			{
				return this.unlockParam_;
			}
		}

		// Token: 0x06008F00 RID: 36608 RVA: 0x0015AB99 File Offset: 0x00158D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoodProcessResponse);
		}

		// Token: 0x06008F01 RID: 36609 RVA: 0x0015ABA8 File Offset: 0x00158DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoodProcessResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Id == other.Id && this.finalFood_.Equals(other.finalFood_) && this.LockState == other.LockState && this.unlockParam_.Equals(other.unlockParam_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F02 RID: 36610 RVA: 0x0015AC2C File Offset: 0x00158E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.finalFood_.GetHashCode();
			if (this.LockState)
			{
				num ^= this.LockState.GetHashCode();
			}
			num ^= this.unlockParam_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F03 RID: 36611 RVA: 0x0015ACBF File Offset: 0x00158EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F04 RID: 36612 RVA: 0x0015ACCC File Offset: 0x00158ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F05 RID: 36613 RVA: 0x0015ACD8 File Offset: 0x00158ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Code);
			}
			if (this.LockState)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.LockState);
			}
			this.finalFood_.WriteTo(ref output, FoodProcessResponse._repeated_finalFood_codec);
			this.unlockParam_.WriteTo(ref output, FoodProcessResponse._repeated_unlockParam_codec);
			if (this.Id != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008F06 RID: 36614 RVA: 0x0015AD70 File Offset: 0x00158F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.finalFood_.CalculateSize(FoodProcessResponse._repeated_finalFood_codec);
			if (this.LockState)
			{
				num += 2;
			}
			num += this.unlockParam_.CalculateSize(FoodProcessResponse._repeated_unlockParam_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F07 RID: 36615 RVA: 0x0015ADF8 File Offset: 0x00158FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FoodProcessResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.finalFood_.Add(other.finalFood_);
			if (other.LockState)
			{
				this.LockState = other.LockState;
			}
			this.unlockParam_.Add(other.unlockParam_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F08 RID: 36616 RVA: 0x0015AE7E File Offset: 0x0015907E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008F09 RID: 36617 RVA: 0x0015AE88 File Offset: 0x00159088
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
				if (num <= 98U)
				{
					if (num == 8U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 88U)
					{
						this.LockState = input.ReadBool();
						continue;
					}
					if (num == 98U)
					{
						this.finalFood_.AddEntriesFrom(ref input, FoodProcessResponse._repeated_finalFood_codec);
						continue;
					}
				}
				else
				{
					if (num == 112U || num == 114U)
					{
						this.unlockParam_.AddEntriesFrom(ref input, FoodProcessResponse._repeated_unlockParam_codec);
						continue;
					}
					if (num == 120U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040045D9 RID: 17881
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045DA RID: 17882
		public const int CodeFieldNumber = 1;

		// Token: 0x040045DB RID: 17883
		private ErrorCode code_;

		// Token: 0x040045DC RID: 17884
		public const int IdFieldNumber = 15;

		// Token: 0x040045DD RID: 17885
		private int id_;

		// Token: 0x040045DE RID: 17886
		public const int FinalFoodFieldNumber = 12;

		// Token: 0x040045DF RID: 17887
		private static readonly FieldCodec<SingleItemInfo> _repeated_finalFood_codec = FieldCodec.ForMessage<SingleItemInfo>(98U, SingleItemInfo.Parser);

		// Token: 0x040045E0 RID: 17888
		private readonly RepeatedField<SingleItemInfo> finalFood_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x040045E1 RID: 17889
		public const int LockStateFieldNumber = 11;

		// Token: 0x040045E2 RID: 17890
		private bool lockState_;

		// Token: 0x040045E3 RID: 17891
		public const int UnlockParamFieldNumber = 14;

		// Token: 0x040045E4 RID: 17892
		private static readonly FieldCodec<int> _repeated_unlockParam_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040045E5 RID: 17893
		private readonly RepeatedField<int> unlockParam_ = new RepeatedField<int>();
	}
}
