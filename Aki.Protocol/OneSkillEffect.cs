using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B8F RID: 2959
	public sealed class OneSkillEffect : IMessage<OneSkillEffect>, IMessage, IEquatable<OneSkillEffect>, IDeepCloneable<OneSkillEffect>, IBufferMessage
	{
		// Token: 0x060100A1 RID: 65697 RVA: 0x00257313 File Offset: 0x00255513
		[NullableContext(1)]
		public static OneSkillEffect Create()
		{
			return new OneSkillEffect();
		}

		// Token: 0x17003480 RID: 13440
		// (get) Token: 0x060100A2 RID: 65698 RVA: 0x0025731A File Offset: 0x0025551A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneSkillEffect> Parser
		{
			get
			{
				return OneSkillEffect._parser;
			}
		}

		// Token: 0x17003481 RID: 13441
		// (get) Token: 0x060100A3 RID: 65699 RVA: 0x00257321 File Offset: 0x00255521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003482 RID: 13442
		// (get) Token: 0x060100A4 RID: 65700 RVA: 0x00257324 File Offset: 0x00255524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneSkillEffect.Descriptor;
			}
		}

		// Token: 0x060100A5 RID: 65701 RVA: 0x0025732B File Offset: 0x0025552B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSkillEffect()
		{
		}

		// Token: 0x060100A6 RID: 65702 RVA: 0x0025733E File Offset: 0x0025553E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSkillEffect(OneSkillEffect other) : this()
		{
			this.id_ = other.id_;
			this.desc_ = other.desc_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060100A7 RID: 65703 RVA: 0x00257374 File Offset: 0x00255574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSkillEffect Clone()
		{
			return new OneSkillEffect(this);
		}

		// Token: 0x17003483 RID: 13443
		// (get) Token: 0x060100A8 RID: 65704 RVA: 0x0025737C File Offset: 0x0025557C
		// (set) Token: 0x060100A9 RID: 65705 RVA: 0x00257384 File Offset: 0x00255584
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

		// Token: 0x17003484 RID: 13444
		// (get) Token: 0x060100AA RID: 65706 RVA: 0x0025738D File Offset: 0x0025558D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Desc
		{
			get
			{
				return this.desc_;
			}
		}

		// Token: 0x060100AB RID: 65707 RVA: 0x00257395 File Offset: 0x00255595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneSkillEffect);
		}

		// Token: 0x060100AC RID: 65708 RVA: 0x002573A4 File Offset: 0x002555A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneSkillEffect other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.desc_.Equals(other.desc_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060100AD RID: 65709 RVA: 0x002573F4 File Offset: 0x002555F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.desc_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060100AE RID: 65710 RVA: 0x00257441 File Offset: 0x00255641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060100AF RID: 65711 RVA: 0x0025744E File Offset: 0x0025564E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060100B0 RID: 65712 RVA: 0x00257458 File Offset: 0x00255658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			this.desc_.WriteTo(ref output, OneSkillEffect._repeated_desc_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060100B1 RID: 65713 RVA: 0x002574A8 File Offset: 0x002556A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			num += this.desc_.CalculateSize(OneSkillEffect._repeated_desc_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060100B2 RID: 65714 RVA: 0x002574FC File Offset: 0x002556FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OneSkillEffect other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this.desc_.Add(other.desc_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060100B3 RID: 65715 RVA: 0x00257549 File Offset: 0x00255749
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060100B4 RID: 65716 RVA: 0x00257554 File Offset: 0x00255754
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
					if (num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.desc_.AddEntriesFrom(ref input, OneSkillEffect._repeated_desc_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006641 RID: 26177
		private static readonly MessageParser<OneSkillEffect> _parser = new MessageParser<OneSkillEffect>(() => new OneSkillEffect());

		// Token: 0x04006642 RID: 26178
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006643 RID: 26179
		public const int IdFieldNumber = 1;

		// Token: 0x04006644 RID: 26180
		private int id_;

		// Token: 0x04006645 RID: 26181
		public const int DescFieldNumber = 3;

		// Token: 0x04006646 RID: 26182
		private static readonly FieldCodec<string> _repeated_desc_codec = FieldCodec.ForString(26U);

		// Token: 0x04006647 RID: 26183
		private readonly RepeatedField<string> desc_ = new RepeatedField<string>();
	}
}
