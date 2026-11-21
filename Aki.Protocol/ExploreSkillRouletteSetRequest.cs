using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004F4 RID: 1268
	[NetMessage(EMessageId.ExploreSkillRouletteSetRequest)]
	public sealed class ExploreSkillRouletteSetRequest : IMessage<ExploreSkillRouletteSetRequest>, IMessage, IEquatable<ExploreSkillRouletteSetRequest>, IDeepCloneable<ExploreSkillRouletteSetRequest>, IBufferMessage
	{
		// Token: 0x060077EE RID: 30702 RVA: 0x00124383 File Offset: 0x00122583
		[NullableContext(1)]
		public static ExploreSkillRouletteSetRequest Create()
		{
			return new ExploreSkillRouletteSetRequest();
		}

		// Token: 0x17001735 RID: 5941
		// (get) Token: 0x060077EF RID: 30703 RVA: 0x0012438A File Offset: 0x0012258A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001736 RID: 5942
		// (get) Token: 0x060077F0 RID: 30704 RVA: 0x0012438D File Offset: 0x0012258D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillRouletteSetRequest.Descriptor;
			}
		}

		// Token: 0x060077F1 RID: 30705 RVA: 0x00124394 File Offset: 0x00122594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteSetRequest()
		{
		}

		// Token: 0x060077F2 RID: 30706 RVA: 0x001243A8 File Offset: 0x001225A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteSetRequest(ExploreSkillRouletteSetRequest other) : this()
		{
			this.skillRoulette_ = ((other.skillRoulette_ != null) ? other.skillRoulette_.Clone() : null);
			this.rouletteType_ = other.rouletteType_;
			this.skillRoulettes_ = other.skillRoulettes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060077F3 RID: 30707 RVA: 0x00124405 File Offset: 0x00122605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteSetRequest Clone()
		{
			return new ExploreSkillRouletteSetRequest(this);
		}

		// Token: 0x17001737 RID: 5943
		// (get) Token: 0x060077F4 RID: 30708 RVA: 0x0012440D File Offset: 0x0012260D
		// (set) Token: 0x060077F5 RID: 30709 RVA: 0x00124415 File Offset: 0x00122615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRoulette SkillRoulette
		{
			get
			{
				return this.skillRoulette_;
			}
			set
			{
				this.skillRoulette_ = value;
			}
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x060077F6 RID: 30710 RVA: 0x0012441E File Offset: 0x0012261E
		// (set) Token: 0x060077F7 RID: 30711 RVA: 0x00124426 File Offset: 0x00122626
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RouletteType RouletteType
		{
			get
			{
				return this.rouletteType_;
			}
			set
			{
				this.rouletteType_ = value;
			}
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x060077F8 RID: 30712 RVA: 0x0012442F File Offset: 0x0012262F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExploreSkillRoulette> SkillRoulettes
		{
			get
			{
				return this.skillRoulettes_;
			}
		}

		// Token: 0x060077F9 RID: 30713 RVA: 0x00124437 File Offset: 0x00122637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillRouletteSetRequest);
		}

		// Token: 0x060077FA RID: 30714 RVA: 0x00124448 File Offset: 0x00122648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillRouletteSetRequest other)
		{
			return other != null && (other == this || (object.Equals(this.SkillRoulette, other.SkillRoulette) && this.RouletteType == other.RouletteType && this.skillRoulettes_.Equals(other.skillRoulettes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060077FB RID: 30715 RVA: 0x001244AC File Offset: 0x001226AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.skillRoulette_ != null)
			{
				num ^= this.SkillRoulette.GetHashCode();
			}
			if (this.RouletteType != RouletteType.Explore)
			{
				num ^= this.RouletteType.GetHashCode();
			}
			num ^= this.skillRoulettes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060077FC RID: 30716 RVA: 0x00124515 File Offset: 0x00122715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060077FD RID: 30717 RVA: 0x00124522 File Offset: 0x00122722
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060077FE RID: 30718 RVA: 0x0012452C File Offset: 0x0012272C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skillRoulettes_.WriteTo(ref output, ExploreSkillRouletteSetRequest._repeated_skillRoulettes_codec);
			if (this.skillRoulette_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.SkillRoulette);
			}
			if (this.RouletteType != RouletteType.Explore)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.RouletteType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060077FF RID: 30719 RVA: 0x00124598 File Offset: 0x00122798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.skillRoulette_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SkillRoulette);
			}
			if (this.RouletteType != RouletteType.Explore)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RouletteType);
			}
			num += this.skillRoulettes_.CalculateSize(ExploreSkillRouletteSetRequest._repeated_skillRoulettes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007800 RID: 30720 RVA: 0x00124604 File Offset: 0x00122804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillRouletteSetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.skillRoulette_ != null)
			{
				if (this.skillRoulette_ == null)
				{
					this.SkillRoulette = new ExploreSkillRoulette();
				}
				this.SkillRoulette.MergeFrom(other.SkillRoulette);
			}
			if (other.RouletteType != RouletteType.Explore)
			{
				this.RouletteType = other.RouletteType;
			}
			this.skillRoulettes_.Add(other.skillRoulettes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007801 RID: 30721 RVA: 0x0012467D File Offset: 0x0012287D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007802 RID: 30722 RVA: 0x00124688 File Offset: 0x00122888
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
				if (num != 26U)
				{
					if (num != 50U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RouletteType = (RouletteType)input.ReadEnum();
						}
					}
					else
					{
						if (this.skillRoulette_ == null)
						{
							this.SkillRoulette = new ExploreSkillRoulette();
						}
						input.ReadMessage(this.SkillRoulette);
					}
				}
				else
				{
					this.skillRoulettes_.AddEntriesFrom(ref input, ExploreSkillRouletteSetRequest._repeated_skillRoulettes_codec);
				}
			}
		}

		// Token: 0x04003E92 RID: 16018
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E93 RID: 16019
		public const int SkillRouletteFieldNumber = 6;

		// Token: 0x04003E94 RID: 16020
		private ExploreSkillRoulette skillRoulette_;

		// Token: 0x04003E95 RID: 16021
		public const int RouletteTypeFieldNumber = 9;

		// Token: 0x04003E96 RID: 16022
		private RouletteType rouletteType_;

		// Token: 0x04003E97 RID: 16023
		public const int SkillRoulettesFieldNumber = 3;

		// Token: 0x04003E98 RID: 16024
		private static readonly FieldCodec<ExploreSkillRoulette> _repeated_skillRoulettes_codec = FieldCodec.ForMessage<ExploreSkillRoulette>(26U, ExploreSkillRoulette.Parser);

		// Token: 0x04003E99 RID: 16025
		private readonly RepeatedField<ExploreSkillRoulette> skillRoulettes_ = new RepeatedField<ExploreSkillRoulette>();
	}
}
