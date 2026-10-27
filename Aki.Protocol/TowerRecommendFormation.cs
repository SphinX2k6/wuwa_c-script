using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C3 RID: 5059
	public sealed class TowerRecommendFormation : IMessage<TowerRecommendFormation>, IMessage, IEquatable<TowerRecommendFormation>, IDeepCloneable<TowerRecommendFormation>, IBufferMessage
	{
		// Token: 0x0601AD5C RID: 109916 RVA: 0x003E403F File Offset: 0x003E223F
		[NullableContext(1)]
		public static TowerRecommendFormation Create()
		{
			return new TowerRecommendFormation();
		}

		// Token: 0x17005A80 RID: 23168
		// (get) Token: 0x0601AD5D RID: 109917 RVA: 0x003E4046 File Offset: 0x003E2246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TowerRecommendFormation> Parser
		{
			get
			{
				return TowerRecommendFormation._parser;
			}
		}

		// Token: 0x17005A81 RID: 23169
		// (get) Token: 0x0601AD5E RID: 109918 RVA: 0x003E404D File Offset: 0x003E224D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A82 RID: 23170
		// (get) Token: 0x0601AD5F RID: 109919 RVA: 0x003E4050 File Offset: 0x003E2250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerRecommendFormation.Descriptor;
			}
		}

		// Token: 0x0601AD60 RID: 109920 RVA: 0x003E4057 File Offset: 0x003E2257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRecommendFormation()
		{
		}

		// Token: 0x0601AD61 RID: 109921 RVA: 0x003E406A File Offset: 0x003E226A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRecommendFormation(TowerRecommendFormation other) : this()
		{
			this.formation_ = other.formation_.Clone();
			this.usage_ = other.usage_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AD62 RID: 109922 RVA: 0x003E40A0 File Offset: 0x003E22A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRecommendFormation Clone()
		{
			return new TowerRecommendFormation(this);
		}

		// Token: 0x17005A83 RID: 23171
		// (get) Token: 0x0601AD63 RID: 109923 RVA: 0x003E40A8 File Offset: 0x003E22A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerRecommendRole> Formation
		{
			get
			{
				return this.formation_;
			}
		}

		// Token: 0x17005A84 RID: 23172
		// (get) Token: 0x0601AD64 RID: 109924 RVA: 0x003E40B0 File Offset: 0x003E22B0
		// (set) Token: 0x0601AD65 RID: 109925 RVA: 0x003E40B8 File Offset: 0x003E22B8
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

		// Token: 0x0601AD66 RID: 109926 RVA: 0x003E40C1 File Offset: 0x003E22C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerRecommendFormation);
		}

		// Token: 0x0601AD67 RID: 109927 RVA: 0x003E40D0 File Offset: 0x003E22D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerRecommendFormation other)
		{
			return other != null && (other == this || (this.formation_.Equals(other.formation_) && this.Usage == other.Usage && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AD68 RID: 109928 RVA: 0x003E4120 File Offset: 0x003E2320
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

		// Token: 0x0601AD69 RID: 109929 RVA: 0x003E416D File Offset: 0x003E236D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AD6A RID: 109930 RVA: 0x003E417A File Offset: 0x003E237A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AD6B RID: 109931 RVA: 0x003E4184 File Offset: 0x003E2384
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

		// Token: 0x0601AD6C RID: 109932 RVA: 0x003E41D4 File Offset: 0x003E23D4
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

		// Token: 0x0601AD6D RID: 109933 RVA: 0x003E4228 File Offset: 0x003E2428
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

		// Token: 0x0601AD6E RID: 109934 RVA: 0x003E4275 File Offset: 0x003E2475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AD6F RID: 109935 RVA: 0x003E4280 File Offset: 0x003E2480
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

		// Token: 0x04009BBB RID: 39867
		private static readonly MessageParser<TowerRecommendFormation> _parser = new MessageParser<TowerRecommendFormation>(() => new TowerRecommendFormation());

		// Token: 0x04009BBC RID: 39868
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BBD RID: 39869
		public const int FormationFieldNumber = 1;

		// Token: 0x04009BBE RID: 39870
		private static readonly FieldCodec<TowerRecommendRole> _repeated_formation_codec = FieldCodec.ForMessage<TowerRecommendRole>(10U, TowerRecommendRole.Parser);

		// Token: 0x04009BBF RID: 39871
		private readonly RepeatedField<TowerRecommendRole> formation_ = new RepeatedField<TowerRecommendRole>();

		// Token: 0x04009BC0 RID: 39872
		public const int UsageFieldNumber = 2;

		// Token: 0x04009BC1 RID: 39873
		private int usage_;
	}
}
