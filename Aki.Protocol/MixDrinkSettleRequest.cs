using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009DE RID: 2526
	[NetMessage(EMessageId.MixDrinkSettleRequest)]
	public sealed class MixDrinkSettleRequest : IMessage<MixDrinkSettleRequest>, IMessage, IEquatable<MixDrinkSettleRequest>, IDeepCloneable<MixDrinkSettleRequest>, IBufferMessage
	{
		// Token: 0x0600DD5E RID: 56670 RVA: 0x002078F1 File Offset: 0x00205AF1
		[NullableContext(1)]
		public static MixDrinkSettleRequest Create()
		{
			return new MixDrinkSettleRequest();
		}

		// Token: 0x17002CDC RID: 11484
		// (get) Token: 0x0600DD5F RID: 56671 RVA: 0x002078F8 File Offset: 0x00205AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CDD RID: 11485
		// (get) Token: 0x0600DD60 RID: 56672 RVA: 0x002078FB File Offset: 0x00205AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkSettleRequest.Descriptor;
			}
		}

		// Token: 0x0600DD61 RID: 56673 RVA: 0x00207902 File Offset: 0x00205B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkSettleRequest()
		{
		}

		// Token: 0x0600DD62 RID: 56674 RVA: 0x00207920 File Offset: 0x00205B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkSettleRequest(MixDrinkSettleRequest other) : this()
		{
			this.requireId_ = other.requireId_;
			this.baseDrinks_ = other.baseDrinks_.Clone();
			this.batching_ = other.batching_.Clone();
			this.orna_ = other.orna_;
			this.likePoint_ = other.likePoint_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD63 RID: 56675 RVA: 0x0020798A File Offset: 0x00205B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkSettleRequest Clone()
		{
			return new MixDrinkSettleRequest(this);
		}

		// Token: 0x17002CDE RID: 11486
		// (get) Token: 0x0600DD64 RID: 56676 RVA: 0x00207992 File Offset: 0x00205B92
		// (set) Token: 0x0600DD65 RID: 56677 RVA: 0x0020799A File Offset: 0x00205B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RequireId
		{
			get
			{
				return this.requireId_;
			}
			set
			{
				this.requireId_ = value;
			}
		}

		// Token: 0x17002CDF RID: 11487
		// (get) Token: 0x0600DD66 RID: 56678 RVA: 0x002079A3 File Offset: 0x00205BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BaseDrinks
		{
			get
			{
				return this.baseDrinks_;
			}
		}

		// Token: 0x17002CE0 RID: 11488
		// (get) Token: 0x0600DD67 RID: 56679 RVA: 0x002079AB File Offset: 0x00205BAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Batching
		{
			get
			{
				return this.batching_;
			}
		}

		// Token: 0x17002CE1 RID: 11489
		// (get) Token: 0x0600DD68 RID: 56680 RVA: 0x002079B3 File Offset: 0x00205BB3
		// (set) Token: 0x0600DD69 RID: 56681 RVA: 0x002079BB File Offset: 0x00205BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Orna
		{
			get
			{
				return this.orna_;
			}
			set
			{
				this.orna_ = value;
			}
		}

		// Token: 0x17002CE2 RID: 11490
		// (get) Token: 0x0600DD6A RID: 56682 RVA: 0x002079C4 File Offset: 0x00205BC4
		// (set) Token: 0x0600DD6B RID: 56683 RVA: 0x002079CC File Offset: 0x00205BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LikePoint
		{
			get
			{
				return this.likePoint_;
			}
			set
			{
				this.likePoint_ = value;
			}
		}

		// Token: 0x0600DD6C RID: 56684 RVA: 0x002079D5 File Offset: 0x00205BD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkSettleRequest);
		}

		// Token: 0x0600DD6D RID: 56685 RVA: 0x002079E4 File Offset: 0x00205BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkSettleRequest other)
		{
			return other != null && (other == this || (this.RequireId == other.RequireId && this.baseDrinks_.Equals(other.baseDrinks_) && this.batching_.Equals(other.batching_) && this.Orna == other.Orna && this.LikePoint == other.LikePoint && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD6E RID: 56686 RVA: 0x00207A68 File Offset: 0x00205C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RequireId != 0)
			{
				num ^= this.RequireId.GetHashCode();
			}
			num ^= this.baseDrinks_.GetHashCode();
			num ^= this.batching_.GetHashCode();
			if (this.Orna != 0)
			{
				num ^= this.Orna.GetHashCode();
			}
			if (this.LikePoint != 0)
			{
				num ^= this.LikePoint.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DD6F RID: 56687 RVA: 0x00207AF5 File Offset: 0x00205CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD70 RID: 56688 RVA: 0x00207B02 File Offset: 0x00205D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD71 RID: 56689 RVA: 0x00207B0C File Offset: 0x00205D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.baseDrinks_.WriteTo(ref output, MixDrinkSettleRequest._repeated_baseDrinks_codec);
			this.batching_.WriteTo(ref output, MixDrinkSettleRequest._repeated_batching_codec);
			if (this.RequireId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RequireId);
			}
			if (this.Orna != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.Orna);
			}
			if (this.LikePoint != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.LikePoint);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD72 RID: 56690 RVA: 0x00207BA4 File Offset: 0x00205DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RequireId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RequireId);
			}
			num += this.baseDrinks_.CalculateSize(MixDrinkSettleRequest._repeated_baseDrinks_codec);
			num += this.batching_.CalculateSize(MixDrinkSettleRequest._repeated_batching_codec);
			if (this.Orna != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Orna);
			}
			if (this.LikePoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LikePoint);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DD73 RID: 56691 RVA: 0x00207C38 File Offset: 0x00205E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MixDrinkSettleRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RequireId != 0)
			{
				this.RequireId = other.RequireId;
			}
			this.baseDrinks_.Add(other.baseDrinks_);
			this.batching_.Add(other.batching_);
			if (other.Orna != 0)
			{
				this.Orna = other.Orna;
			}
			if (other.LikePoint != 0)
			{
				this.LikePoint = other.LikePoint;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DD74 RID: 56692 RVA: 0x00207CBE File Offset: 0x00205EBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD75 RID: 56693 RVA: 0x00207CC8 File Offset: 0x00205EC8
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
				if (num <= 80U)
				{
					if (num == 16U || num == 18U)
					{
						this.baseDrinks_.AddEntriesFrom(ref input, MixDrinkSettleRequest._repeated_baseDrinks_codec);
						continue;
					}
					if (num == 80U)
					{
						goto IL_64;
					}
				}
				else if (num <= 104U)
				{
					if (num == 82U)
					{
						goto IL_64;
					}
					if (num == 104U)
					{
						this.RequireId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.Orna = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.LikePoint = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_64:
				this.batching_.AddEntriesFrom(ref input, MixDrinkSettleRequest._repeated_batching_codec);
			}
		}

		// Token: 0x04005B88 RID: 23432
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B89 RID: 23433
		public const int RequireIdFieldNumber = 13;

		// Token: 0x04005B8A RID: 23434
		private int requireId_;

		// Token: 0x04005B8B RID: 23435
		public const int BaseDrinksFieldNumber = 2;

		// Token: 0x04005B8C RID: 23436
		private static readonly FieldCodec<int> _repeated_baseDrinks_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005B8D RID: 23437
		private readonly RepeatedField<int> baseDrinks_ = new RepeatedField<int>();

		// Token: 0x04005B8E RID: 23438
		public const int BatchingFieldNumber = 10;

		// Token: 0x04005B8F RID: 23439
		private static readonly FieldCodec<int> _repeated_batching_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04005B90 RID: 23440
		private readonly RepeatedField<int> batching_ = new RepeatedField<int>();

		// Token: 0x04005B91 RID: 23441
		public const int OrnaFieldNumber = 14;

		// Token: 0x04005B92 RID: 23442
		private int orna_;

		// Token: 0x04005B93 RID: 23443
		public const int LikePointFieldNumber = 15;

		// Token: 0x04005B94 RID: 23444
		private int likePoint_;
	}
}
