using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FEF RID: 4079
	public sealed class RogueResPhantom : IMessage<RogueResPhantom>, IMessage, IEquatable<RogueResPhantom>, IDeepCloneable<RogueResPhantom>, IBufferMessage
	{
		// Token: 0x06015D6A RID: 89450 RVA: 0x0032D3D6 File Offset: 0x0032B5D6
		[NullableContext(1)]
		public static RogueResPhantom Create()
		{
			return new RogueResPhantom();
		}

		// Token: 0x170048F9 RID: 18681
		// (get) Token: 0x06015D6B RID: 89451 RVA: 0x0032D3DD File Offset: 0x0032B5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048FA RID: 18682
		// (get) Token: 0x06015D6C RID: 89452 RVA: 0x0032D3E0 File Offset: 0x0032B5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResPhantom.Descriptor;
			}
		}

		// Token: 0x06015D6D RID: 89453 RVA: 0x0032D3E7 File Offset: 0x0032B5E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResPhantom()
		{
		}

		// Token: 0x06015D6E RID: 89454 RVA: 0x0032D3FC File Offset: 0x0032B5FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResPhantom(RogueResPhantom other) : this()
		{
			this.configId_ = other.configId_;
			this.isNew_ = other.isNew_;
			this.phantomAffixInfos_ = other.phantomAffixInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015D6F RID: 89455 RVA: 0x0032D449 File Offset: 0x0032B649
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResPhantom Clone()
		{
			return new RogueResPhantom(this);
		}

		// Token: 0x170048FB RID: 18683
		// (get) Token: 0x06015D70 RID: 89456 RVA: 0x0032D451 File Offset: 0x0032B651
		// (set) Token: 0x06015D71 RID: 89457 RVA: 0x0032D459 File Offset: 0x0032B659
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x170048FC RID: 18684
		// (get) Token: 0x06015D72 RID: 89458 RVA: 0x0032D462 File Offset: 0x0032B662
		// (set) Token: 0x06015D73 RID: 89459 RVA: 0x0032D46A File Offset: 0x0032B66A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNew
		{
			get
			{
				return this.isNew_;
			}
			set
			{
				this.isNew_ = value;
			}
		}

		// Token: 0x170048FD RID: 18685
		// (get) Token: 0x06015D74 RID: 89460 RVA: 0x0032D473 File Offset: 0x0032B673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomAffixInfo> PhantomAffixInfos
		{
			get
			{
				return this.phantomAffixInfos_;
			}
		}

		// Token: 0x06015D75 RID: 89461 RVA: 0x0032D47B File Offset: 0x0032B67B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResPhantom);
		}

		// Token: 0x06015D76 RID: 89462 RVA: 0x0032D48C File Offset: 0x0032B68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResPhantom other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IsNew == other.IsNew && this.phantomAffixInfos_.Equals(other.phantomAffixInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015D77 RID: 89463 RVA: 0x0032D4EC File Offset: 0x0032B6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.IsNew)
			{
				num ^= this.IsNew.GetHashCode();
			}
			num ^= this.phantomAffixInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015D78 RID: 89464 RVA: 0x0032D552 File Offset: 0x0032B752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015D79 RID: 89465 RVA: 0x0032D55F File Offset: 0x0032B75F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015D7A RID: 89466 RVA: 0x0032D568 File Offset: 0x0032B768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.IsNew)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsNew);
			}
			this.phantomAffixInfos_.WriteTo(ref output, RogueResPhantom._repeated_phantomAffixInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015D7B RID: 89467 RVA: 0x0032D5D4 File Offset: 0x0032B7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.IsNew)
			{
				num += 2;
			}
			num += this.phantomAffixInfos_.CalculateSize(RogueResPhantom._repeated_phantomAffixInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015D7C RID: 89468 RVA: 0x0032D634 File Offset: 0x0032B834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResPhantom other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.IsNew)
			{
				this.IsNew = other.IsNew;
			}
			this.phantomAffixInfos_.Add(other.phantomAffixInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015D7D RID: 89469 RVA: 0x0032D695 File Offset: 0x0032B895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015D7E RID: 89470 RVA: 0x0032D6A0 File Offset: 0x0032B8A0
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.phantomAffixInfos_.AddEntriesFrom(ref input, RogueResPhantom._repeated_phantomAffixInfos_codec);
						}
					}
					else
					{
						this.IsNew = input.ReadBool();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008384 RID: 33668
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008385 RID: 33669
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04008386 RID: 33670
		private int configId_;

		// Token: 0x04008387 RID: 33671
		public const int IsNewFieldNumber = 2;

		// Token: 0x04008388 RID: 33672
		private bool isNew_;

		// Token: 0x04008389 RID: 33673
		public const int PhantomAffixInfosFieldNumber = 3;

		// Token: 0x0400838A RID: 33674
		private static readonly FieldCodec<PhantomAffixInfo> _repeated_phantomAffixInfos_codec = FieldCodec.ForMessage<PhantomAffixInfo>(26U, PhantomAffixInfo.Parser);

		// Token: 0x0400838B RID: 33675
		private readonly RepeatedField<PhantomAffixInfo> phantomAffixInfos_ = new RepeatedField<PhantomAffixInfo>();
	}
}
