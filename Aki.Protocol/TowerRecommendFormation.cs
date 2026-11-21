using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001436 RID: 5174
	public sealed class TowerRecommendFormation : IMessage<TowerRecommendFormation>, IMessage, IEquatable<TowerRecommendFormation>, IDeepCloneable<TowerRecommendFormation>, IBufferMessage
	{
		// Token: 0x0601B7E7 RID: 112615 RVA: 0x003FF303 File Offset: 0x003FD503
		[NullableContext(1)]
		public static TowerRecommendFormation Create()
		{
			return new TowerRecommendFormation();
		}

		// Token: 0x17005D15 RID: 23829
		// (get) Token: 0x0601B7E8 RID: 112616 RVA: 0x003FF30A File Offset: 0x003FD50A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerRecommendFormation> Parser
		{
			get
			{
				return TowerRecommendFormation._parser;
			}
		}

		// Token: 0x17005D16 RID: 23830
		// (get) Token: 0x0601B7E9 RID: 112617 RVA: 0x003FF311 File Offset: 0x003FD511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D17 RID: 23831
		// (get) Token: 0x0601B7EA RID: 112618 RVA: 0x003FF314 File Offset: 0x003FD514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerRecommendFormation.Descriptor;
			}
		}

		// Token: 0x0601B7EB RID: 112619 RVA: 0x003FF31B File Offset: 0x003FD51B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRecommendFormation()
		{
		}

		// Token: 0x0601B7EC RID: 112620 RVA: 0x003FF32E File Offset: 0x003FD52E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRecommendFormation(TowerRecommendFormation other) : this()
		{
			this.formation_ = other.formation_.Clone();
			this.usage_ = other.usage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B7ED RID: 112621 RVA: 0x003FF364 File Offset: 0x003FD564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRecommendFormation Clone()
		{
			return new TowerRecommendFormation(this);
		}

		// Token: 0x17005D18 RID: 23832
		// (get) Token: 0x0601B7EE RID: 112622 RVA: 0x003FF36C File Offset: 0x003FD56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerRecommendRole> Formation
		{
			get
			{
				return this.formation_;
			}
		}

		// Token: 0x17005D19 RID: 23833
		// (get) Token: 0x0601B7EF RID: 112623 RVA: 0x003FF374 File Offset: 0x003FD574
		// (set) Token: 0x0601B7F0 RID: 112624 RVA: 0x003FF37C File Offset: 0x003FD57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Usage
		{
			get
			{
				return this.usage_;
			}
			set
			{
				this.usage_ = value;
			}
		}

		// Token: 0x0601B7F1 RID: 112625 RVA: 0x003FF385 File Offset: 0x003FD585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerRecommendFormation);
		}

		// Token: 0x0601B7F2 RID: 112626 RVA: 0x003FF394 File Offset: 0x003FD594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerRecommendFormation other)
		{
			return other != null && (other == this || (this.formation_.Equals(other.formation_) && this.Usage == other.Usage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B7F3 RID: 112627 RVA: 0x003FF3E4 File Offset: 0x003FD5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.formation_.GetHashCode();
			if (this.Usage != 0)
			{
				num ^= this.Usage.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B7F4 RID: 112628 RVA: 0x003FF431 File Offset: 0x003FD631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B7F5 RID: 112629 RVA: 0x003FF43E File Offset: 0x003FD63E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B7F6 RID: 112630 RVA: 0x003FF448 File Offset: 0x003FD648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.formation_.WriteTo(ref output, TowerRecommendFormation._repeated_formation_codec);
			if (this.Usage != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Usage);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B7F7 RID: 112631 RVA: 0x003FF498 File Offset: 0x003FD698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.formation_.CalculateSize(TowerRecommendFormation._repeated_formation_codec);
			if (this.Usage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Usage);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B7F8 RID: 112632 RVA: 0x003FF4EC File Offset: 0x003FD6EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerRecommendFormation other)
		{
			if (other == null)
			{
				return;
			}
			this.formation_.Add(other.formation_);
			if (other.Usage != 0)
			{
				this.Usage = other.Usage;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B7F9 RID: 112633 RVA: 0x003FF539 File Offset: 0x003FD739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B7FA RID: 112634 RVA: 0x003FF544 File Offset: 0x003FD744
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Usage = input.ReadInt32();
					}
				}
				else
				{
					this.formation_.AddEntriesFrom(ref input, TowerRecommendFormation._repeated_formation_codec);
				}
			}
		}

		// Token: 0x0400A002 RID: 40962
		private static readonly MessageParser<TowerRecommendFormation> _parser = new MessageParser<TowerRecommendFormation>(() => new TowerRecommendFormation());

		// Token: 0x0400A003 RID: 40963
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A004 RID: 40964
		public const int FormationFieldNumber = 1;

		// Token: 0x0400A005 RID: 40965
		private static readonly FieldCodec<TowerRecommendRole> _repeated_formation_codec = FieldCodec.ForMessage<TowerRecommendRole>(10U, TowerRecommendRole.Parser);

		// Token: 0x0400A006 RID: 40966
		private readonly RepeatedField<TowerRecommendRole> formation_ = new RepeatedField<TowerRecommendRole>();

		// Token: 0x0400A007 RID: 40967
		public const int UsageFieldNumber = 2;

		// Token: 0x0400A008 RID: 40968
		private int usage_;
	}
}
