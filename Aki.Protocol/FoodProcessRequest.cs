using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000606 RID: 1542
	[NetMessage(EMessageId.FoodProcessRequest)]
	public sealed class FoodProcessRequest : IMessage<FoodProcessRequest>, IMessage, IEquatable<FoodProcessRequest>, IDeepCloneable<FoodProcessRequest>, IBufferMessage
	{
		// Token: 0x06008EDA RID: 36570 RVA: 0x0015A6B1 File Offset: 0x001588B1
		[NullableContext(1)]
		public static FoodProcessRequest Create()
		{
			return new FoodProcessRequest();
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x06008EDB RID: 36571 RVA: 0x0015A6B8 File Offset: 0x001588B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x06008EDC RID: 36572 RVA: 0x0015A6BB File Offset: 0x001588BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoodProcessRequest.Descriptor;
			}
		}

		// Token: 0x06008EDD RID: 36573 RVA: 0x0015A6C2 File Offset: 0x001588C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoodProcessRequest()
		{
		}

		// Token: 0x06008EDE RID: 36574 RVA: 0x0015A6D8 File Offset: 0x001588D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoodProcessRequest(FoodProcessRequest other) : this()
		{
			this.id_ = other.id_;
			this.primaryFood_ = other.primaryFood_.Clone();
			this.cookCount_ = other.cookCount_;
			this.interactEntityId_ = other.interactEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008EDF RID: 36575 RVA: 0x0015A731 File Offset: 0x00158931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoodProcessRequest Clone()
		{
			return new FoodProcessRequest(this);
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x06008EE0 RID: 36576 RVA: 0x0015A739 File Offset: 0x00158939
		// (set) Token: 0x06008EE1 RID: 36577 RVA: 0x0015A741 File Offset: 0x00158941
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

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x06008EE2 RID: 36578 RVA: 0x0015A74A File Offset: 0x0015894A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> PrimaryFood
		{
			get
			{
				return this.primaryFood_;
			}
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x06008EE3 RID: 36579 RVA: 0x0015A752 File Offset: 0x00158952
		// (set) Token: 0x06008EE4 RID: 36580 RVA: 0x0015A75A File Offset: 0x0015895A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CookCount
		{
			get
			{
				return this.cookCount_;
			}
			set
			{
				this.cookCount_ = value;
			}
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x06008EE5 RID: 36581 RVA: 0x0015A763 File Offset: 0x00158963
		// (set) Token: 0x06008EE6 RID: 36582 RVA: 0x0015A76B File Offset: 0x0015896B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long InteractEntityId
		{
			get
			{
				return this.interactEntityId_;
			}
			set
			{
				this.interactEntityId_ = value;
			}
		}

		// Token: 0x06008EE7 RID: 36583 RVA: 0x0015A774 File Offset: 0x00158974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoodProcessRequest);
		}

		// Token: 0x06008EE8 RID: 36584 RVA: 0x0015A784 File Offset: 0x00158984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoodProcessRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.primaryFood_.Equals(other.primaryFood_) && this.CookCount == other.CookCount && this.InteractEntityId == other.InteractEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008EE9 RID: 36585 RVA: 0x0015A7F4 File Offset: 0x001589F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.primaryFood_.GetHashCode();
			if (this.CookCount != 0)
			{
				num ^= this.CookCount.GetHashCode();
			}
			if (this.InteractEntityId != 0L)
			{
				num ^= this.InteractEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008EEA RID: 36586 RVA: 0x0015A873 File Offset: 0x00158A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008EEB RID: 36587 RVA: 0x0015A880 File Offset: 0x00158A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008EEC RID: 36588 RVA: 0x0015A88C File Offset: 0x00158A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InteractEntityId != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.InteractEntityId);
			}
			if (this.CookCount != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.CookCount);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Id);
			}
			this.primaryFood_.WriteTo(ref output, FoodProcessRequest._repeated_primaryFood_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008EED RID: 36589 RVA: 0x0015A914 File Offset: 0x00158B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.primaryFood_.CalculateSize(FoodProcessRequest._repeated_primaryFood_codec);
			if (this.CookCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CookCount);
			}
			if (this.InteractEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.InteractEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008EEE RID: 36590 RVA: 0x0015A998 File Offset: 0x00158B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FoodProcessRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.primaryFood_.Add(other.primaryFood_);
			if (other.CookCount != 0)
			{
				this.CookCount = other.CookCount;
			}
			if (other.InteractEntityId != 0L)
			{
				this.InteractEntityId = other.InteractEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008EEF RID: 36591 RVA: 0x0015AA0D File Offset: 0x00158C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008EF0 RID: 36592 RVA: 0x0015AA18 File Offset: 0x00158C18
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
					if (num == 24U)
					{
						this.InteractEntityId = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.CookCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						this.primaryFood_.AddEntriesFrom(ref input, FoodProcessRequest._repeated_primaryFood_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040045CF RID: 17871
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045D0 RID: 17872
		public const int IdFieldNumber = 12;

		// Token: 0x040045D1 RID: 17873
		private int id_;

		// Token: 0x040045D2 RID: 17874
		public const int PrimaryFoodFieldNumber = 15;

		// Token: 0x040045D3 RID: 17875
		private static readonly FieldCodec<SingleItemInfo> _repeated_primaryFood_codec = FieldCodec.ForMessage<SingleItemInfo>(122U, SingleItemInfo.Parser);

		// Token: 0x040045D4 RID: 17876
		private readonly RepeatedField<SingleItemInfo> primaryFood_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x040045D5 RID: 17877
		public const int CookCountFieldNumber = 4;

		// Token: 0x040045D6 RID: 17878
		private int cookCount_;

		// Token: 0x040045D7 RID: 17879
		public const int InteractEntityIdFieldNumber = 3;

		// Token: 0x040045D8 RID: 17880
		private long interactEntityId_;
	}
}
