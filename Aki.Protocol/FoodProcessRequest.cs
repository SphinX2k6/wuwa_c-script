using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200061B RID: 1563
	[NetMessage(EMessageId.FoodProcessRequest)]
	public sealed class FoodProcessRequest : IMessage<FoodProcessRequest>, IMessage, IEquatable<FoodProcessRequest>, IDeepCloneable<FoodProcessRequest>, IBufferMessage
	{
		// Token: 0x06009042 RID: 36930 RVA: 0x0015D2BD File Offset: 0x0015B4BD
		[NullableContext(1)]
		public static FoodProcessRequest Create()
		{
			return new FoodProcessRequest();
		}

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x06009043 RID: 36931 RVA: 0x0015D2C4 File Offset: 0x0015B4C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x06009044 RID: 36932 RVA: 0x0015D2C7 File Offset: 0x0015B4C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoodProcessRequest.Descriptor;
			}
		}

		// Token: 0x06009045 RID: 36933 RVA: 0x0015D2CE File Offset: 0x0015B4CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoodProcessRequest()
		{
		}

		// Token: 0x06009046 RID: 36934 RVA: 0x0015D2E4 File Offset: 0x0015B4E4
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

		// Token: 0x06009047 RID: 36935 RVA: 0x0015D33D File Offset: 0x0015B53D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoodProcessRequest Clone()
		{
			return new FoodProcessRequest(this);
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x06009048 RID: 36936 RVA: 0x0015D345 File Offset: 0x0015B545
		// (set) Token: 0x06009049 RID: 36937 RVA: 0x0015D34D File Offset: 0x0015B54D
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

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x0600904A RID: 36938 RVA: 0x0015D356 File Offset: 0x0015B556
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SingleItemInfo> PrimaryFood
		{
			get
			{
				return this.primaryFood_;
			}
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x0600904B RID: 36939 RVA: 0x0015D35E File Offset: 0x0015B55E
		// (set) Token: 0x0600904C RID: 36940 RVA: 0x0015D366 File Offset: 0x0015B566
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

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x0600904D RID: 36941 RVA: 0x0015D36F File Offset: 0x0015B56F
		// (set) Token: 0x0600904E RID: 36942 RVA: 0x0015D377 File Offset: 0x0015B577
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

		// Token: 0x0600904F RID: 36943 RVA: 0x0015D380 File Offset: 0x0015B580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoodProcessRequest);
		}

		// Token: 0x06009050 RID: 36944 RVA: 0x0015D390 File Offset: 0x0015B590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoodProcessRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.primaryFood_.Equals(other.primaryFood_) && this.CookCount == other.CookCount && this.InteractEntityId == other.InteractEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009051 RID: 36945 RVA: 0x0015D400 File Offset: 0x0015B600
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

		// Token: 0x06009052 RID: 36946 RVA: 0x0015D47F File Offset: 0x0015B67F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009053 RID: 36947 RVA: 0x0015D48C File Offset: 0x0015B68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009054 RID: 36948 RVA: 0x0015D498 File Offset: 0x0015B698
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
				output.WriteRawTag(72);
				output.WriteInt32(this.CookCount);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Id);
			}
			this.primaryFood_.WriteTo(ref output, FoodProcessRequest._repeated_primaryFood_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009055 RID: 36949 RVA: 0x0015D520 File Offset: 0x0015B720
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

		// Token: 0x06009056 RID: 36950 RVA: 0x0015D5A4 File Offset: 0x0015B7A4
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

		// Token: 0x06009057 RID: 36951 RVA: 0x0015D619 File Offset: 0x0015B819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009058 RID: 36952 RVA: 0x0015D624 File Offset: 0x0015B824
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
				if (num <= 72U)
				{
					if (num == 24U)
					{
						this.InteractEntityId = input.ReadInt64();
						continue;
					}
					if (num == 72U)
					{
						this.CookCount = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						this.primaryFood_.AddEntriesFrom(ref input, FoodProcessRequest._repeated_primaryFood_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040045D9 RID: 17881
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045DA RID: 17882
		public const int IdFieldNumber = 10;

		// Token: 0x040045DB RID: 17883
		private int id_;

		// Token: 0x040045DC RID: 17884
		public const int PrimaryFoodFieldNumber = 14;

		// Token: 0x040045DD RID: 17885
		private static readonly FieldCodec<SingleItemInfo> _repeated_primaryFood_codec = FieldCodec.ForMessage<SingleItemInfo>(114U, SingleItemInfo.Parser);

		// Token: 0x040045DE RID: 17886
		private readonly RepeatedField<SingleItemInfo> primaryFood_ = new RepeatedField<SingleItemInfo>();

		// Token: 0x040045DF RID: 17887
		public const int CookCountFieldNumber = 9;

		// Token: 0x040045E0 RID: 17888
		private int cookCount_;

		// Token: 0x040045E1 RID: 17889
		public const int InteractEntityIdFieldNumber = 3;

		// Token: 0x040045E2 RID: 17890
		private long interactEntityId_;
	}
}
