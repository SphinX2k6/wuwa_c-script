using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200061C RID: 1564
	[NetMessage(EMessageId.FoodProcessResponse)]
	public sealed class FoodProcessResponse : IMessage<FoodProcessResponse>, IMessage, IEquatable<FoodProcessResponse>, IDeepCloneable<FoodProcessResponse>, IBufferMessage
	{
		// Token: 0x0600905A RID: 36954 RVA: 0x0015D6C1 File Offset: 0x0015B8C1
		[NullableContext(1)]
		public static FoodProcessResponse Create()
		{
			return new FoodProcessResponse();
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x0600905B RID: 36955 RVA: 0x0015D6C8 File Offset: 0x0015B8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x0600905C RID: 36956 RVA: 0x0015D6CB File Offset: 0x0015B8CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoodProcessResponse.Descriptor;
			}
		}

		// Token: 0x0600905D RID: 36957 RVA: 0x0015D6D2 File Offset: 0x0015B8D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoodProcessResponse()
		{
		}

		// Token: 0x0600905E RID: 36958 RVA: 0x0015D6F0 File Offset: 0x0015B8F0
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

		// Token: 0x0600905F RID: 36959 RVA: 0x0015D75A File Offset: 0x0015B95A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoodProcessResponse Clone()
		{
			return new FoodProcessResponse(this);
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x06009060 RID: 36960 RVA: 0x0015D762 File Offset: 0x0015B962
		// (set) Token: 0x06009061 RID: 36961 RVA: 0x0015D76A File Offset: 0x0015B96A
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

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x06009062 RID: 36962 RVA: 0x0015D773 File Offset: 0x0015B973
		// (set) Token: 0x06009063 RID: 36963 RVA: 0x0015D77B File Offset: 0x0015B97B
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

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x06009064 RID: 36964 RVA: 0x0015D784 File Offset: 0x0015B984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> FinalFood
		{
			get
			{
				return this.finalFood_;
			}
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x06009065 RID: 36965 RVA: 0x0015D78C File Offset: 0x0015B98C
		// (set) Token: 0x06009066 RID: 36966 RVA: 0x0015D794 File Offset: 0x0015B994
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

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x06009067 RID: 36967 RVA: 0x0015D79D File Offset: 0x0015B99D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockParam
		{
			get
			{
				return this.unlockParam_;
			}
		}

		// Token: 0x06009068 RID: 36968 RVA: 0x0015D7A5 File Offset: 0x0015B9A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoodProcessResponse);
		}

		// Token: 0x06009069 RID: 36969 RVA: 0x0015D7B4 File Offset: 0x0015B9B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoodProcessResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.Id == other.Id && this.finalFood_.Equals(other.finalFood_) && this.LockState == other.LockState && this.unlockParam_.Equals(other.unlockParam_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600906A RID: 36970 RVA: 0x0015D838 File Offset: 0x0015BA38
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

		// Token: 0x0600906B RID: 36971 RVA: 0x0015D8CB File Offset: 0x0015BACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600906C RID: 36972 RVA: 0x0015D8D8 File Offset: 0x0015BAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600906D RID: 36973 RVA: 0x0015D8E4 File Offset: 0x0015BAE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.finalFood_.WriteTo(ref output, FoodProcessResponse._repeated_finalFood_codec);
			if (this.LockState)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.LockState);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			this.unlockParam_.WriteTo(ref output, FoodProcessResponse._repeated_unlockParam_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600906E RID: 36974 RVA: 0x0015D97C File Offset: 0x0015BB7C
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

		// Token: 0x0600906F RID: 36975 RVA: 0x0015DA04 File Offset: 0x0015BC04
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

		// Token: 0x06009070 RID: 36976 RVA: 0x0015DA8A File Offset: 0x0015BC8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009071 RID: 36977 RVA: 0x0015DA94 File Offset: 0x0015BC94
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
				if (num <= 96U)
				{
					if (num == 10U)
					{
						this.finalFood_.AddEntriesFrom(ref input, FoodProcessResponse._repeated_finalFood_codec);
						continue;
					}
					if (num == 40U)
					{
						this.LockState = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.Id = input.ReadInt32();
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
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040045E3 RID: 17891
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045E4 RID: 17892
		public const int CodeFieldNumber = 15;

		// Token: 0x040045E5 RID: 17893
		private ErrorCode code_;

		// Token: 0x040045E6 RID: 17894
		public const int IdFieldNumber = 12;

		// Token: 0x040045E7 RID: 17895
		private int id_;

		// Token: 0x040045E8 RID: 17896
		public const int FinalFoodFieldNumber = 1;

		// Token: 0x040045E9 RID: 17897
		private static readonly FieldCodec<SingleItemInfo> _repeated_finalFood_codec = FieldCodec.ForMessage<SingleItemInfo>(10U, SingleItemInfo.Parser);

		// Token: 0x040045EA RID: 17898
		private readonly RepeatedField<SingleItemInfo> finalFood_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x040045EB RID: 17899
		public const int LockStateFieldNumber = 5;

		// Token: 0x040045EC RID: 17900
		private bool lockState_;

		// Token: 0x040045ED RID: 17901
		public const int UnlockParamFieldNumber = 14;

		// Token: 0x040045EE RID: 17902
		private static readonly FieldCodec<int> _repeated_unlockParam_codec = FieldCodec.ForInt32(114U);

		// Token: 0x040045EF RID: 17903
		private readonly RepeatedField<int> unlockParam_ = new RepeatedField<int>();
	}
}
