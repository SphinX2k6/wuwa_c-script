using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009CD RID: 2509
	[NetMessage(EMessageId.MixDrinkSettleRequest)]
	public sealed class MixDrinkSettleRequest : IMessage<MixDrinkSettleRequest>, IMessage, IEquatable<MixDrinkSettleRequest>, IDeepCloneable<MixDrinkSettleRequest>, IBufferMessage
	{
		// Token: 0x0600DC44 RID: 56388 RVA: 0x00205705 File Offset: 0x00203905
		[NullableContext(1)]
		public static MixDrinkSettleRequest Create()
		{
			return new MixDrinkSettleRequest();
		}

		// Token: 0x17002C9E RID: 11422
		// (get) Token: 0x0600DC45 RID: 56389 RVA: 0x0020570C File Offset: 0x0020390C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C9F RID: 11423
		// (get) Token: 0x0600DC46 RID: 56390 RVA: 0x0020570F File Offset: 0x0020390F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkSettleRequest.Descriptor;
			}
		}

		// Token: 0x0600DC47 RID: 56391 RVA: 0x00205716 File Offset: 0x00203916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkSettleRequest()
		{
		}

		// Token: 0x0600DC48 RID: 56392 RVA: 0x00205734 File Offset: 0x00203934
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

		// Token: 0x0600DC49 RID: 56393 RVA: 0x0020579E File Offset: 0x0020399E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkSettleRequest Clone()
		{
			return new MixDrinkSettleRequest(this);
		}

		// Token: 0x17002CA0 RID: 11424
		// (get) Token: 0x0600DC4A RID: 56394 RVA: 0x002057A6 File Offset: 0x002039A6
		// (set) Token: 0x0600DC4B RID: 56395 RVA: 0x002057AE File Offset: 0x002039AE
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

		// Token: 0x17002CA1 RID: 11425
		// (get) Token: 0x0600DC4C RID: 56396 RVA: 0x002057B7 File Offset: 0x002039B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BaseDrinks
		{
			get
			{
				return this.baseDrinks_;
			}
		}

		// Token: 0x17002CA2 RID: 11426
		// (get) Token: 0x0600DC4D RID: 56397 RVA: 0x002057BF File Offset: 0x002039BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Batching
		{
			get
			{
				return this.batching_;
			}
		}

		// Token: 0x17002CA3 RID: 11427
		// (get) Token: 0x0600DC4E RID: 56398 RVA: 0x002057C7 File Offset: 0x002039C7
		// (set) Token: 0x0600DC4F RID: 56399 RVA: 0x002057CF File Offset: 0x002039CF
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

		// Token: 0x17002CA4 RID: 11428
		// (get) Token: 0x0600DC50 RID: 56400 RVA: 0x002057D8 File Offset: 0x002039D8
		// (set) Token: 0x0600DC51 RID: 56401 RVA: 0x002057E0 File Offset: 0x002039E0
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

		// Token: 0x0600DC52 RID: 56402 RVA: 0x002057E9 File Offset: 0x002039E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkSettleRequest);
		}

		// Token: 0x0600DC53 RID: 56403 RVA: 0x002057F8 File Offset: 0x002039F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkSettleRequest other)
		{
			return other != null && (other == this || (this.RequireId == other.RequireId && this.baseDrinks_.Equals(other.baseDrinks_) && this.batching_.Equals(other.batching_) && this.Orna == other.Orna && this.LikePoint == other.LikePoint && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC54 RID: 56404 RVA: 0x0020587C File Offset: 0x00203A7C
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

		// Token: 0x0600DC55 RID: 56405 RVA: 0x00205909 File Offset: 0x00203B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC56 RID: 56406 RVA: 0x00205916 File Offset: 0x00203B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC57 RID: 56407 RVA: 0x00205920 File Offset: 0x00203B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LikePoint != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LikePoint);
			}
			if (this.Orna != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Orna);
			}
			if (this.RequireId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RequireId);
			}
			this.batching_.WriteTo(ref output, MixDrinkSettleRequest._repeated_batching_codec);
			this.baseDrinks_.WriteTo(ref output, MixDrinkSettleRequest._repeated_baseDrinks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC58 RID: 56408 RVA: 0x002059B8 File Offset: 0x00203BB8
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

		// Token: 0x0600DC59 RID: 56409 RVA: 0x00205A4C File Offset: 0x00203C4C
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

		// Token: 0x0600DC5A RID: 56410 RVA: 0x00205AD2 File Offset: 0x00203CD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC5B RID: 56411 RVA: 0x00205ADC File Offset: 0x00203CDC
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
				if (num <= 64U)
				{
					if (num == 8U)
					{
						this.LikePoint = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Orna = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.RequireId = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 98U)
				{
					if (num == 96U || num == 98U)
					{
						this.batching_.AddEntriesFrom(ref input, MixDrinkSettleRequest._repeated_batching_codec);
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.baseDrinks_.AddEntriesFrom(ref input, MixDrinkSettleRequest._repeated_baseDrinks_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005B91 RID: 23441
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B92 RID: 23442
		public const int RequireIdFieldNumber = 8;

		// Token: 0x04005B93 RID: 23443
		private int requireId_;

		// Token: 0x04005B94 RID: 23444
		public const int BaseDrinksFieldNumber = 15;

		// Token: 0x04005B95 RID: 23445
		private static readonly FieldCodec<int> _repeated_baseDrinks_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04005B96 RID: 23446
		private readonly RepeatedField<int> baseDrinks_ = new RepeatedField<int>();

		// Token: 0x04005B97 RID: 23447
		public const int BatchingFieldNumber = 12;

		// Token: 0x04005B98 RID: 23448
		private static readonly FieldCodec<int> _repeated_batching_codec = FieldCodec.ForInt32(98U);

		// Token: 0x04005B99 RID: 23449
		private readonly RepeatedField<int> batching_ = new RepeatedField<int>();

		// Token: 0x04005B9A RID: 23450
		public const int OrnaFieldNumber = 5;

		// Token: 0x04005B9B RID: 23451
		private int orna_;

		// Token: 0x04005B9C RID: 23452
		public const int LikePointFieldNumber = 1;

		// Token: 0x04005B9D RID: 23453
		private int likePoint_;
	}
}
