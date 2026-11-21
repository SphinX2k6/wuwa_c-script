using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B4B RID: 2891
	[NetMessage(EMessageId.NormalItemAddNotify)]
	public sealed class NormalItemAddNotify : IMessage<NormalItemAddNotify>, IMessage, IEquatable<NormalItemAddNotify>, IDeepCloneable<NormalItemAddNotify>, IBufferMessage
	{
		// Token: 0x0600FAF2 RID: 64242 RVA: 0x00249507 File Offset: 0x00247707
		[NullableContext(1)]
		public static NormalItemAddNotify Create()
		{
			return new NormalItemAddNotify();
		}

		// Token: 0x17003325 RID: 13093
		// (get) Token: 0x0600FAF3 RID: 64243 RVA: 0x0024950E File Offset: 0x0024770E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003326 RID: 13094
		// (get) Token: 0x0600FAF4 RID: 64244 RVA: 0x00249511 File Offset: 0x00247711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalItemAddNotify.Descriptor;
			}
		}

		// Token: 0x0600FAF5 RID: 64245 RVA: 0x00249518 File Offset: 0x00247718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemAddNotify()
		{
		}

		// Token: 0x0600FAF6 RID: 64246 RVA: 0x0024952C File Offset: 0x0024772C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemAddNotify(NormalItemAddNotify other) : this()
		{
			this.normalItemList_ = other.normalItemList_.Clone();
			this.noTips_ = other.noTips_;
			this.reason_ = other.reason_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FAF7 RID: 64247 RVA: 0x00249579 File Offset: 0x00247779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemAddNotify Clone()
		{
			return new NormalItemAddNotify(this);
		}

		// Token: 0x17003327 RID: 13095
		// (get) Token: 0x0600FAF8 RID: 64248 RVA: 0x00249581 File Offset: 0x00247781
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NormalItem> NormalItemList
		{
			get
			{
				return this.normalItemList_;
			}
		}

		// Token: 0x17003328 RID: 13096
		// (get) Token: 0x0600FAF9 RID: 64249 RVA: 0x00249589 File Offset: 0x00247789
		// (set) Token: 0x0600FAFA RID: 64250 RVA: 0x00249591 File Offset: 0x00247791
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NoTips
		{
			get
			{
				return this.noTips_;
			}
			set
			{
				this.noTips_ = value;
			}
		}

		// Token: 0x17003329 RID: 13097
		// (get) Token: 0x0600FAFB RID: 64251 RVA: 0x0024959A File Offset: 0x0024779A
		// (set) Token: 0x0600FAFC RID: 64252 RVA: 0x002495A2 File Offset: 0x002477A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Reason
		{
			get
			{
				return this.reason_;
			}
			set
			{
				this.reason_ = value;
			}
		}

		// Token: 0x0600FAFD RID: 64253 RVA: 0x002495AB File Offset: 0x002477AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalItemAddNotify);
		}

		// Token: 0x0600FAFE RID: 64254 RVA: 0x002495BC File Offset: 0x002477BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalItemAddNotify other)
		{
			return other != null && (other == this || (this.normalItemList_.Equals(other.normalItemList_) && this.NoTips == other.NoTips && this.Reason == other.Reason && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FAFF RID: 64255 RVA: 0x0024961C File Offset: 0x0024781C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.normalItemList_.GetHashCode();
			if (this.NoTips)
			{
				num ^= this.NoTips.GetHashCode();
			}
			if (this.Reason != 0)
			{
				num ^= this.Reason.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FB00 RID: 64256 RVA: 0x00249682 File Offset: 0x00247882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB01 RID: 64257 RVA: 0x0024968F File Offset: 0x0024788F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB02 RID: 64258 RVA: 0x00249698 File Offset: 0x00247898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.normalItemList_.WriteTo(ref output, NormalItemAddNotify._repeated_normalItemList_codec);
			if (this.Reason != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Reason);
			}
			if (this.NoTips)
			{
				output.WriteRawTag(120);
				output.WriteBool(this.NoTips);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FB03 RID: 64259 RVA: 0x00249704 File Offset: 0x00247904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.normalItemList_.CalculateSize(NormalItemAddNotify._repeated_normalItemList_codec);
			if (this.NoTips)
			{
				num += 2;
			}
			if (this.Reason != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Reason);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FB04 RID: 64260 RVA: 0x00249764 File Offset: 0x00247964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalItemAddNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.normalItemList_.Add(other.normalItemList_);
			if (other.NoTips)
			{
				this.NoTips = other.NoTips;
			}
			if (other.Reason != 0)
			{
				this.Reason = other.Reason;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FB05 RID: 64261 RVA: 0x002497C5 File Offset: 0x002479C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB06 RID: 64262 RVA: 0x002497D0 File Offset: 0x002479D0
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
				if (num != 10U)
				{
					if (num != 96U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.NoTips = input.ReadBool();
						}
					}
					else
					{
						this.Reason = input.ReadInt32();
					}
				}
				else
				{
					this.normalItemList_.AddEntriesFrom(ref input, NormalItemAddNotify._repeated_normalItemList_codec);
				}
			}
		}

		// Token: 0x040064B5 RID: 25781
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064B6 RID: 25782
		public const int NormalItemListFieldNumber = 1;

		// Token: 0x040064B7 RID: 25783
		private static readonly FieldCodec<NormalItem> _repeated_normalItemList_codec = FieldCodec.ForMessage<NormalItem>(10U, NormalItem.Parser);

		// Token: 0x040064B8 RID: 25784
		private readonly RepeatedField<NormalItem> normalItemList_ = new RepeatedField<NormalItem>();

		// Token: 0x040064B9 RID: 25785
		public const int NoTipsFieldNumber = 15;

		// Token: 0x040064BA RID: 25786
		private bool noTips_;

		// Token: 0x040064BB RID: 25787
		public const int ReasonFieldNumber = 12;

		// Token: 0x040064BC RID: 25788
		private int reason_;
	}
}
