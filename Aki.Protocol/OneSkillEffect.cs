using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B7F RID: 2943
	public sealed class OneSkillEffect : IMessage<OneSkillEffect>, IMessage, IEquatable<OneSkillEffect>, IDeepCloneable<OneSkillEffect>, IBufferMessage
	{
		// Token: 0x0600FF9D RID: 65437 RVA: 0x00255443 File Offset: 0x00253643
		[NullableContext(1)]
		public static OneSkillEffect Create()
		{
			return new OneSkillEffect();
		}

		// Token: 0x17003447 RID: 13383
		// (get) Token: 0x0600FF9E RID: 65438 RVA: 0x0025544A File Offset: 0x0025364A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<OneSkillEffect> Parser
		{
			get
			{
				return OneSkillEffect._parser;
			}
		}

		// Token: 0x17003448 RID: 13384
		// (get) Token: 0x0600FF9F RID: 65439 RVA: 0x00255451 File Offset: 0x00253651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003449 RID: 13385
		// (get) Token: 0x0600FFA0 RID: 65440 RVA: 0x00255454 File Offset: 0x00253654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OneSkillEffect.Descriptor;
			}
		}

		// Token: 0x0600FFA1 RID: 65441 RVA: 0x0025545B File Offset: 0x0025365B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSkillEffect()
		{
		}

		// Token: 0x0600FFA2 RID: 65442 RVA: 0x0025546E File Offset: 0x0025366E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSkillEffect(OneSkillEffect other) : this()
		{
			this.id_ = other.id_;
			this.desc_ = other.desc_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FFA3 RID: 65443 RVA: 0x002554A4 File Offset: 0x002536A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneSkillEffect Clone()
		{
			return new OneSkillEffect(this);
		}

		// Token: 0x1700344A RID: 13386
		// (get) Token: 0x0600FFA4 RID: 65444 RVA: 0x002554AC File Offset: 0x002536AC
		// (set) Token: 0x0600FFA5 RID: 65445 RVA: 0x002554B4 File Offset: 0x002536B4
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

		// Token: 0x1700344B RID: 13387
		// (get) Token: 0x0600FFA6 RID: 65446 RVA: 0x002554BD File Offset: 0x002536BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> Desc
		{
			get
			{
				return this.desc_;
			}
		}

		// Token: 0x0600FFA7 RID: 65447 RVA: 0x002554C5 File Offset: 0x002536C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OneSkillEffect);
		}

		// Token: 0x0600FFA8 RID: 65448 RVA: 0x002554D4 File Offset: 0x002536D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OneSkillEffect other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.desc_.Equals(other.desc_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FFA9 RID: 65449 RVA: 0x00255524 File Offset: 0x00253724
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

		// Token: 0x0600FFAA RID: 65450 RVA: 0x00255571 File Offset: 0x00253771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FFAB RID: 65451 RVA: 0x0025557E File Offset: 0x0025377E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FFAC RID: 65452 RVA: 0x00255588 File Offset: 0x00253788
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

		// Token: 0x0600FFAD RID: 65453 RVA: 0x002555D8 File Offset: 0x002537D8
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

		// Token: 0x0600FFAE RID: 65454 RVA: 0x0025562C File Offset: 0x0025382C
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

		// Token: 0x0600FFAF RID: 65455 RVA: 0x00255679 File Offset: 0x00253879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FFB0 RID: 65456 RVA: 0x00255684 File Offset: 0x00253884
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

		// Token: 0x04006651 RID: 26193
		private static readonly MessageParser<OneSkillEffect> _parser = new MessageParser<OneSkillEffect>(() => new OneSkillEffect());

		// Token: 0x04006652 RID: 26194
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006653 RID: 26195
		public const int IdFieldNumber = 1;

		// Token: 0x04006654 RID: 26196
		private int id_;

		// Token: 0x04006655 RID: 26197
		public const int DescFieldNumber = 3;

		// Token: 0x04006656 RID: 26198
		private static readonly FieldCodec<string> _repeated_desc_codec = FieldCodec.ForString(26U);

		// Token: 0x04006657 RID: 26199
		private readonly RepeatedField<string> desc_ = new RepeatedField<string>();
	}
}
