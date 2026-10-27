using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001070 RID: 4208
	[NetMessage(EMessageId.RoleFavorExpTipsNotify)]
	public sealed class RoleFavorExpTipsNotify : IMessage<RoleFavorExpTipsNotify>, IMessage, IEquatable<RoleFavorExpTipsNotify>, IDeepCloneable<RoleFavorExpTipsNotify>, IBufferMessage
	{
		// Token: 0x060167CB RID: 92107 RVA: 0x00344F60 File Offset: 0x00343160
		[NullableContext(1)]
		public static RoleFavorExpTipsNotify Create()
		{
			return new RoleFavorExpTipsNotify();
		}

		// Token: 0x17004B4B RID: 19275
		// (get) Token: 0x060167CC RID: 92108 RVA: 0x00344F67 File Offset: 0x00343167
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B4C RID: 19276
		// (get) Token: 0x060167CD RID: 92109 RVA: 0x00344F6A File Offset: 0x0034316A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorExpTipsNotify.Descriptor;
			}
		}

		// Token: 0x060167CE RID: 92110 RVA: 0x00344F71 File Offset: 0x00343171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorExpTipsNotify()
		{
		}

		// Token: 0x060167CF RID: 92111 RVA: 0x00344F84 File Offset: 0x00343184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorExpTipsNotify(RoleFavorExpTipsNotify other) : this()
		{
			this.expTips_ = other.expTips_.Clone();
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060167D0 RID: 92112 RVA: 0x00344FD1 File Offset: 0x003431D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorExpTipsNotify Clone()
		{
			return new RoleFavorExpTipsNotify(this);
		}

		// Token: 0x17004B4D RID: 19277
		// (get) Token: 0x060167D1 RID: 92113 RVA: 0x00344FD9 File Offset: 0x003431D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExpTips> ExpTips
		{
			get
			{
				return this.expTips_;
			}
		}

		// Token: 0x17004B4E RID: 19278
		// (get) Token: 0x060167D2 RID: 92114 RVA: 0x00344FE1 File Offset: 0x003431E1
		// (set) Token: 0x060167D3 RID: 92115 RVA: 0x00344FE9 File Offset: 0x003431E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17004B4F RID: 19279
		// (get) Token: 0x060167D4 RID: 92116 RVA: 0x00344FF2 File Offset: 0x003431F2
		// (set) Token: 0x060167D5 RID: 92117 RVA: 0x00344FFA File Offset: 0x003431FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x060167D6 RID: 92118 RVA: 0x00345003 File Offset: 0x00343203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorExpTipsNotify);
		}

		// Token: 0x060167D7 RID: 92119 RVA: 0x00345014 File Offset: 0x00343214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorExpTipsNotify other)
		{
			return other != null && (other == this || (this.expTips_.Equals(other.expTips_) && this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060167D8 RID: 92120 RVA: 0x00345074 File Offset: 0x00343274
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.expTips_.GetHashCode();
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060167D9 RID: 92121 RVA: 0x003450DA File Offset: 0x003432DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060167DA RID: 92122 RVA: 0x003450E7 File Offset: 0x003432E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060167DB RID: 92123 RVA: 0x003450F0 File Offset: 0x003432F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.expTips_.WriteTo(ref output, RoleFavorExpTipsNotify._repeated_expTips_codec);
			if (this.ItemId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ItemId);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Count);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060167DC RID: 92124 RVA: 0x0034515C File Offset: 0x0034335C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.expTips_.CalculateSize(RoleFavorExpTipsNotify._repeated_expTips_codec);
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060167DD RID: 92125 RVA: 0x003451C8 File Offset: 0x003433C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorExpTipsNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.expTips_.Add(other.expTips_);
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060167DE RID: 92126 RVA: 0x00345229 File Offset: 0x00343429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060167DF RID: 92127 RVA: 0x00345234 File Offset: 0x00343434
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
				if (num != 18U)
				{
					if (num != 56U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Count = input.ReadInt32();
						}
					}
					else
					{
						this.ItemId = input.ReadInt32();
					}
				}
				else
				{
					this.expTips_.AddEntriesFrom(ref input, RoleFavorExpTipsNotify._repeated_expTips_codec);
				}
			}
		}

		// Token: 0x04008681 RID: 34433
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008682 RID: 34434
		public const int ExpTipsFieldNumber = 2;

		// Token: 0x04008683 RID: 34435
		private static readonly FieldCodec<ExpTips> _repeated_expTips_codec = FieldCodec.ForMessage<ExpTips>(18U, Aki.Protocol.ExpTips.Parser);

		// Token: 0x04008684 RID: 34436
		private readonly RepeatedField<ExpTips> expTips_ = new RepeatedField<ExpTips>();

		// Token: 0x04008685 RID: 34437
		public const int ItemIdFieldNumber = 7;

		// Token: 0x04008686 RID: 34438
		private int itemId_;

		// Token: 0x04008687 RID: 34439
		public const int CountFieldNumber = 10;

		// Token: 0x04008688 RID: 34440
		private int count_;
	}
}
