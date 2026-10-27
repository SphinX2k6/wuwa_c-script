using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200050A RID: 1290
	[NetMessage(EMessageId.ExploreSkillRouletteSetRequest)]
	public sealed class ExploreSkillRouletteSetRequest : IMessage<ExploreSkillRouletteSetRequest>, IMessage, IEquatable<ExploreSkillRouletteSetRequest>, IDeepCloneable<ExploreSkillRouletteSetRequest>, IBufferMessage
	{
		// Token: 0x0600796A RID: 31082 RVA: 0x00127217 File Offset: 0x00125417
		[NullableContext(1)]
		public static ExploreSkillRouletteSetRequest Create()
		{
			return new ExploreSkillRouletteSetRequest();
		}

		// Token: 0x17001786 RID: 6022
		// (get) Token: 0x0600796B RID: 31083 RVA: 0x0012721E File Offset: 0x0012541E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001787 RID: 6023
		// (get) Token: 0x0600796C RID: 31084 RVA: 0x00127221 File Offset: 0x00125421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillRouletteSetRequest.Descriptor;
			}
		}

		// Token: 0x0600796D RID: 31085 RVA: 0x00127228 File Offset: 0x00125428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteSetRequest()
		{
		}

		// Token: 0x0600796E RID: 31086 RVA: 0x0012723C File Offset: 0x0012543C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteSetRequest(ExploreSkillRouletteSetRequest other) : this()
		{
			this.skillRoulette_ = ((other.skillRoulette_ != null) ? other.skillRoulette_.Clone() : null);
			this.rouletteType_ = other.rouletteType_;
			this.skillRoulettes_ = other.skillRoulettes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600796F RID: 31087 RVA: 0x00127299 File Offset: 0x00125499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillRouletteSetRequest Clone()
		{
			return new ExploreSkillRouletteSetRequest(this);
		}

		// Token: 0x17001788 RID: 6024
		// (get) Token: 0x06007970 RID: 31088 RVA: 0x001272A1 File Offset: 0x001254A1
		// (set) Token: 0x06007971 RID: 31089 RVA: 0x001272A9 File Offset: 0x001254A9
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

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06007972 RID: 31090 RVA: 0x001272B2 File Offset: 0x001254B2
		// (set) Token: 0x06007973 RID: 31091 RVA: 0x001272BA File Offset: 0x001254BA
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

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x06007974 RID: 31092 RVA: 0x001272C3 File Offset: 0x001254C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ExploreSkillRoulette> SkillRoulettes
		{
			get
			{
				return this.skillRoulettes_;
			}
		}

		// Token: 0x06007975 RID: 31093 RVA: 0x001272CB File Offset: 0x001254CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillRouletteSetRequest);
		}

		// Token: 0x06007976 RID: 31094 RVA: 0x001272DC File Offset: 0x001254DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillRouletteSetRequest other)
		{
			return other != null && (other == this || (object.Equals(this.SkillRoulette, other.SkillRoulette) && this.RouletteType == other.RouletteType && this.skillRoulettes_.Equals(other.skillRoulettes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007977 RID: 31095 RVA: 0x00127340 File Offset: 0x00125540
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

		// Token: 0x06007978 RID: 31096 RVA: 0x001273A9 File Offset: 0x001255A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007979 RID: 31097 RVA: 0x001273B6 File Offset: 0x001255B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600797A RID: 31098 RVA: 0x001273C0 File Offset: 0x001255C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RouletteType != RouletteType.Explore)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.RouletteType);
			}
			this.skillRoulettes_.WriteTo(ref output, ExploreSkillRouletteSetRequest._repeated_skillRoulettes_codec);
			if (this.skillRoulette_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.SkillRoulette);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600797B RID: 31099 RVA: 0x0012742C File Offset: 0x0012562C
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

		// Token: 0x0600797C RID: 31100 RVA: 0x00127498 File Offset: 0x00125698
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

		// Token: 0x0600797D RID: 31101 RVA: 0x00127511 File Offset: 0x00125711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600797E RID: 31102 RVA: 0x0012751C File Offset: 0x0012571C
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
				if (num != 40U)
				{
					if (num != 66U)
					{
						if (num != 90U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.RouletteType = (RouletteType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003EA1 RID: 16033
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EA2 RID: 16034
		public const int SkillRouletteFieldNumber = 11;

		// Token: 0x04003EA3 RID: 16035
		private ExploreSkillRoulette skillRoulette_;

		// Token: 0x04003EA4 RID: 16036
		public const int RouletteTypeFieldNumber = 5;

		// Token: 0x04003EA5 RID: 16037
		private RouletteType rouletteType_;

		// Token: 0x04003EA6 RID: 16038
		public const int SkillRoulettesFieldNumber = 8;

		// Token: 0x04003EA7 RID: 16039
		private static readonly FieldCodec<ExploreSkillRoulette> _repeated_skillRoulettes_codec = FieldCodec.ForMessage<ExploreSkillRoulette>(66U, ExploreSkillRoulette.Parser);

		// Token: 0x04003EA8 RID: 16040
		private readonly RepeatedField<ExploreSkillRoulette> skillRoulettes_ = new RepeatedField<ExploreSkillRoulette>();
	}
}
