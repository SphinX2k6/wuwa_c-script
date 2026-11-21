using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001060 RID: 4192
	[NetMessage(EMessageId.RoleFavorExpTipsNotify)]
	public sealed class RoleFavorExpTipsNotify : IMessage<RoleFavorExpTipsNotify>, IMessage, IEquatable<RoleFavorExpTipsNotify>, IDeepCloneable<RoleFavorExpTipsNotify>, IBufferMessage
	{
		// Token: 0x060166E6 RID: 91878 RVA: 0x00343890 File Offset: 0x00341A90
		[NullableContext(1)]
		public static RoleFavorExpTipsNotify Create()
		{
			return new RoleFavorExpTipsNotify();
		}

		// Token: 0x17004B21 RID: 19233
		// (get) Token: 0x060166E7 RID: 91879 RVA: 0x00343897 File Offset: 0x00341A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B22 RID: 19234
		// (get) Token: 0x060166E8 RID: 91880 RVA: 0x0034389A File Offset: 0x00341A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorExpTipsNotify.Descriptor;
			}
		}

		// Token: 0x060166E9 RID: 91881 RVA: 0x003438A1 File Offset: 0x00341AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorExpTipsNotify()
		{
		}

		// Token: 0x060166EA RID: 91882 RVA: 0x003438B4 File Offset: 0x00341AB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorExpTipsNotify(RoleFavorExpTipsNotify other) : this()
		{
			this.expTips_ = other.expTips_.Clone();
			this.itemId_ = other.itemId_;
			this.count_ = other.count_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060166EB RID: 91883 RVA: 0x00343901 File Offset: 0x00341B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorExpTipsNotify Clone()
		{
			return new RoleFavorExpTipsNotify(this);
		}

		// Token: 0x17004B23 RID: 19235
		// (get) Token: 0x060166EC RID: 91884 RVA: 0x00343909 File Offset: 0x00341B09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExpTips> ExpTips
		{
			get
			{
				return this.expTips_;
			}
		}

		// Token: 0x17004B24 RID: 19236
		// (get) Token: 0x060166ED RID: 91885 RVA: 0x00343911 File Offset: 0x00341B11
		// (set) Token: 0x060166EE RID: 91886 RVA: 0x00343919 File Offset: 0x00341B19
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

		// Token: 0x17004B25 RID: 19237
		// (get) Token: 0x060166EF RID: 91887 RVA: 0x00343922 File Offset: 0x00341B22
		// (set) Token: 0x060166F0 RID: 91888 RVA: 0x0034392A File Offset: 0x00341B2A
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

		// Token: 0x060166F1 RID: 91889 RVA: 0x00343933 File Offset: 0x00341B33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorExpTipsNotify);
		}

		// Token: 0x060166F2 RID: 91890 RVA: 0x00343944 File Offset: 0x00341B44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorExpTipsNotify other)
		{
			return other != null && (other == this || (this.expTips_.Equals(other.expTips_) && this.ItemId == other.ItemId && this.Count == other.Count && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060166F3 RID: 91891 RVA: 0x003439A4 File Offset: 0x00341BA4
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

		// Token: 0x060166F4 RID: 91892 RVA: 0x00343A0A File Offset: 0x00341C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060166F5 RID: 91893 RVA: 0x00343A17 File Offset: 0x00341C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060166F6 RID: 91894 RVA: 0x00343A20 File Offset: 0x00341C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Count != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Count);
			}
			this.expTips_.WriteTo(ref output, RoleFavorExpTipsNotify._repeated_expTips_codec);
			if (this.ItemId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060166F7 RID: 91895 RVA: 0x00343A8C File Offset: 0x00341C8C
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

		// Token: 0x060166F8 RID: 91896 RVA: 0x00343AF8 File Offset: 0x00341CF8
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

		// Token: 0x060166F9 RID: 91897 RVA: 0x00343B59 File Offset: 0x00341D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060166FA RID: 91898 RVA: 0x00343B64 File Offset: 0x00341D64
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
				if (num != 64U)
				{
					if (num != 74U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.Count = input.ReadInt32();
				}
			}
		}

		// Token: 0x040086AB RID: 34475
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086AC RID: 34476
		public const int ExpTipsFieldNumber = 9;

		// Token: 0x040086AD RID: 34477
		private static readonly FieldCodec<ExpTips> _repeated_expTips_codec = FieldCodec.ForMessage<ExpTips>(74U, Aki.Protocol.ExpTips.Parser);

		// Token: 0x040086AE RID: 34478
		private readonly RepeatedField<ExpTips> expTips_ = new RepeatedField<ExpTips>();

		// Token: 0x040086AF RID: 34479
		public const int ItemIdFieldNumber = 12;

		// Token: 0x040086B0 RID: 34480
		private int itemId_;

		// Token: 0x040086B1 RID: 34481
		public const int CountFieldNumber = 8;

		// Token: 0x040086B2 RID: 34482
		private int count_;
	}
}
