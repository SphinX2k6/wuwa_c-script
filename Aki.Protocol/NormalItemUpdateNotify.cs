using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B60 RID: 2912
	[NetMessage(EMessageId.NormalItemUpdateNotify)]
	public sealed class NormalItemUpdateNotify : IMessage<NormalItemUpdateNotify>, IMessage, IEquatable<NormalItemUpdateNotify>, IDeepCloneable<NormalItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600FC56 RID: 64598 RVA: 0x0024BF65 File Offset: 0x0024A165
		[NullableContext(1)]
		public static NormalItemUpdateNotify Create()
		{
			return new NormalItemUpdateNotify();
		}

		// Token: 0x17003370 RID: 13168
		// (get) Token: 0x0600FC57 RID: 64599 RVA: 0x0024BF6C File Offset: 0x0024A16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003371 RID: 13169
		// (get) Token: 0x0600FC58 RID: 64600 RVA: 0x0024BF6F File Offset: 0x0024A16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600FC59 RID: 64601 RVA: 0x0024BF76 File Offset: 0x0024A176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemUpdateNotify()
		{
		}

		// Token: 0x0600FC5A RID: 64602 RVA: 0x0024BF89 File Offset: 0x0024A189
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemUpdateNotify(NormalItemUpdateNotify other) : this()
		{
			this.normalItemList_ = other.normalItemList_.Clone();
			this.noTips_ = other.noTips_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FC5B RID: 64603 RVA: 0x0024BFBF File Offset: 0x0024A1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemUpdateNotify Clone()
		{
			return new NormalItemUpdateNotify(this);
		}

		// Token: 0x17003372 RID: 13170
		// (get) Token: 0x0600FC5C RID: 64604 RVA: 0x0024BFC7 File Offset: 0x0024A1C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NormalItem> NormalItemList
		{
			get
			{
				return this.normalItemList_;
			}
		}

		// Token: 0x17003373 RID: 13171
		// (get) Token: 0x0600FC5D RID: 64605 RVA: 0x0024BFCF File Offset: 0x0024A1CF
		// (set) Token: 0x0600FC5E RID: 64606 RVA: 0x0024BFD7 File Offset: 0x0024A1D7
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

		// Token: 0x0600FC5F RID: 64607 RVA: 0x0024BFE0 File Offset: 0x0024A1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalItemUpdateNotify);
		}

		// Token: 0x0600FC60 RID: 64608 RVA: 0x0024BFF0 File Offset: 0x0024A1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalItemUpdateNotify other)
		{
			return other != null && (other == this || (this.normalItemList_.Equals(other.normalItemList_) && this.NoTips == other.NoTips && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FC61 RID: 64609 RVA: 0x0024C040 File Offset: 0x0024A240
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FC62 RID: 64610 RVA: 0x0024C08D File Offset: 0x0024A28D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FC63 RID: 64611 RVA: 0x0024C09A File Offset: 0x0024A29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FC64 RID: 64612 RVA: 0x0024C0A4 File Offset: 0x0024A2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.normalItemList_.WriteTo(ref output, NormalItemUpdateNotify._repeated_normalItemList_codec);
			if (this.NoTips)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.NoTips);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FC65 RID: 64613 RVA: 0x0024C0F4 File Offset: 0x0024A2F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.normalItemList_.CalculateSize(NormalItemUpdateNotify._repeated_normalItemList_codec);
			if (this.NoTips)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FC66 RID: 64614 RVA: 0x0024C13C File Offset: 0x0024A33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalItemUpdateNotify other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FC67 RID: 64615 RVA: 0x0024C189 File Offset: 0x0024A389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FC68 RID: 64616 RVA: 0x0024C194 File Offset: 0x0024A394
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
				if (num != 34U)
				{
					if (num != 88U)
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
					this.normalItemList_.AddEntriesFrom(ref input, NormalItemUpdateNotify._repeated_normalItemList_codec);
				}
			}
		}

		// Token: 0x040064BD RID: 25789
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064BE RID: 25790
		public const int NormalItemListFieldNumber = 4;

		// Token: 0x040064BF RID: 25791
		private static readonly FieldCodec<NormalItem> _repeated_normalItemList_codec = FieldCodec.ForMessage<NormalItem>(34U, NormalItem.Parser);

		// Token: 0x040064C0 RID: 25792
		private readonly RepeatedField<NormalItem> normalItemList_ = new RepeatedField<NormalItem>();

		// Token: 0x040064C1 RID: 25793
		public const int NoTipsFieldNumber = 11;

		// Token: 0x040064C2 RID: 25794
		private bool noTips_;
	}
}
