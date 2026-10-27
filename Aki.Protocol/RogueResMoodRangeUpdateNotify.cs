using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF5 RID: 4085
	[NetMessage(EMessageId.RogueResMoodRangeUpdateNotify)]
	public sealed class RogueResMoodRangeUpdateNotify : IMessage<RogueResMoodRangeUpdateNotify>, IMessage, IEquatable<RogueResMoodRangeUpdateNotify>, IDeepCloneable<RogueResMoodRangeUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015D5C RID: 89436 RVA: 0x0032BDDF File Offset: 0x00329FDF
		[NullableContext(1)]
		public static RogueResMoodRangeUpdateNotify Create()
		{
			return new RogueResMoodRangeUpdateNotify();
		}

		// Token: 0x170048E4 RID: 18660
		// (get) Token: 0x06015D5D RID: 89437 RVA: 0x0032BDE6 File Offset: 0x00329FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048E5 RID: 18661
		// (get) Token: 0x06015D5E RID: 89438 RVA: 0x0032BDE9 File Offset: 0x00329FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResMoodRangeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015D5F RID: 89439 RVA: 0x0032BDF0 File Offset: 0x00329FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoodRangeUpdateNotify()
		{
		}

		// Token: 0x06015D60 RID: 89440 RVA: 0x0032BDF8 File Offset: 0x00329FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoodRangeUpdateNotify(RogueResMoodRangeUpdateNotify other) : this()
		{
			this.maxMood_ = other.maxMood_;
			this.minMood_ = other.minMood_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015D61 RID: 89441 RVA: 0x0032BE29 File Offset: 0x0032A029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoodRangeUpdateNotify Clone()
		{
			return new RogueResMoodRangeUpdateNotify(this);
		}

		// Token: 0x170048E6 RID: 18662
		// (get) Token: 0x06015D62 RID: 89442 RVA: 0x0032BE31 File Offset: 0x0032A031
		// (set) Token: 0x06015D63 RID: 89443 RVA: 0x0032BE39 File Offset: 0x0032A039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxMood
		{
			get
			{
				return this.maxMood_;
			}
			set
			{
				this.maxMood_ = value;
			}
		}

		// Token: 0x170048E7 RID: 18663
		// (get) Token: 0x06015D64 RID: 89444 RVA: 0x0032BE42 File Offset: 0x0032A042
		// (set) Token: 0x06015D65 RID: 89445 RVA: 0x0032BE4A File Offset: 0x0032A04A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MinMood
		{
			get
			{
				return this.minMood_;
			}
			set
			{
				this.minMood_ = value;
			}
		}

		// Token: 0x06015D66 RID: 89446 RVA: 0x0032BE53 File Offset: 0x0032A053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResMoodRangeUpdateNotify);
		}

		// Token: 0x06015D67 RID: 89447 RVA: 0x0032BE61 File Offset: 0x0032A061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResMoodRangeUpdateNotify other)
		{
			return other != null && (other == this || (this.MaxMood == other.MaxMood && this.MinMood == other.MinMood && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015D68 RID: 89448 RVA: 0x0032BEA0 File Offset: 0x0032A0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MaxMood != 0)
			{
				num ^= this.MaxMood.GetHashCode();
			}
			if (this.MinMood != 0)
			{
				num ^= this.MinMood.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015D69 RID: 89449 RVA: 0x0032BEF8 File Offset: 0x0032A0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015D6A RID: 89450 RVA: 0x0032BF05 File Offset: 0x0032A105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015D6B RID: 89451 RVA: 0x0032BF10 File Offset: 0x0032A110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MinMood != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MinMood);
			}
			if (this.MaxMood != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.MaxMood);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015D6C RID: 89452 RVA: 0x0032BF6C File Offset: 0x0032A16C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MaxMood != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxMood);
			}
			if (this.MinMood != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MinMood);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015D6D RID: 89453 RVA: 0x0032BFC4 File Offset: 0x0032A1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResMoodRangeUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MaxMood != 0)
			{
				this.MaxMood = other.MaxMood;
			}
			if (other.MinMood != 0)
			{
				this.MinMood = other.MinMood;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015D6E RID: 89454 RVA: 0x0032C014 File Offset: 0x0032A214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015D6F RID: 89455 RVA: 0x0032C020 File Offset: 0x0032A220
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MaxMood = input.ReadInt32();
					}
				}
				else
				{
					this.MinMood = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008300 RID: 33536
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008301 RID: 33537
		public const int MaxMoodFieldNumber = 12;

		// Token: 0x04008302 RID: 33538
		private int maxMood_;

		// Token: 0x04008303 RID: 33539
		public const int MinMoodFieldNumber = 5;

		// Token: 0x04008304 RID: 33540
		private int minMood_;
	}
}
