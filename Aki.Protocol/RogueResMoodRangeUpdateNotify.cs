using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FE5 RID: 4069
	[NetMessage(EMessageId.RogueResMoodRangeUpdateNotify)]
	public sealed class RogueResMoodRangeUpdateNotify : IMessage<RogueResMoodRangeUpdateNotify>, IMessage, IEquatable<RogueResMoodRangeUpdateNotify>, IDeepCloneable<RogueResMoodRangeUpdateNotify>, IBufferMessage
	{
		// Token: 0x06015C77 RID: 89207 RVA: 0x0032A71B File Offset: 0x0032891B
		[NullableContext(1)]
		public static RogueResMoodRangeUpdateNotify Create()
		{
			return new RogueResMoodRangeUpdateNotify();
		}

		// Token: 0x170048BA RID: 18618
		// (get) Token: 0x06015C78 RID: 89208 RVA: 0x0032A722 File Offset: 0x00328922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048BB RID: 18619
		// (get) Token: 0x06015C79 RID: 89209 RVA: 0x0032A725 File Offset: 0x00328925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResMoodRangeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06015C7A RID: 89210 RVA: 0x0032A72C File Offset: 0x0032892C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoodRangeUpdateNotify()
		{
		}

		// Token: 0x06015C7B RID: 89211 RVA: 0x0032A734 File Offset: 0x00328934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoodRangeUpdateNotify(RogueResMoodRangeUpdateNotify other) : this()
		{
			this.maxMood_ = other.maxMood_;
			this.minMood_ = other.minMood_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015C7C RID: 89212 RVA: 0x0032A765 File Offset: 0x00328965
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoodRangeUpdateNotify Clone()
		{
			return new RogueResMoodRangeUpdateNotify(this);
		}

		// Token: 0x170048BC RID: 18620
		// (get) Token: 0x06015C7D RID: 89213 RVA: 0x0032A76D File Offset: 0x0032896D
		// (set) Token: 0x06015C7E RID: 89214 RVA: 0x0032A775 File Offset: 0x00328975
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

		// Token: 0x170048BD RID: 18621
		// (get) Token: 0x06015C7F RID: 89215 RVA: 0x0032A77E File Offset: 0x0032897E
		// (set) Token: 0x06015C80 RID: 89216 RVA: 0x0032A786 File Offset: 0x00328986
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

		// Token: 0x06015C81 RID: 89217 RVA: 0x0032A78F File Offset: 0x0032898F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResMoodRangeUpdateNotify);
		}

		// Token: 0x06015C82 RID: 89218 RVA: 0x0032A79D File Offset: 0x0032899D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResMoodRangeUpdateNotify other)
		{
			return other != null && (other == this || (this.MaxMood == other.MaxMood && this.MinMood == other.MinMood && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015C83 RID: 89219 RVA: 0x0032A7DC File Offset: 0x003289DC
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

		// Token: 0x06015C84 RID: 89220 RVA: 0x0032A834 File Offset: 0x00328A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015C85 RID: 89221 RVA: 0x0032A841 File Offset: 0x00328A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015C86 RID: 89222 RVA: 0x0032A84C File Offset: 0x00328A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxMood != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.MaxMood);
			}
			if (this.MinMood != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.MinMood);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015C87 RID: 89223 RVA: 0x0032A8A8 File Offset: 0x00328AA8
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

		// Token: 0x06015C88 RID: 89224 RVA: 0x0032A900 File Offset: 0x00328B00
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

		// Token: 0x06015C89 RID: 89225 RVA: 0x0032A950 File Offset: 0x00328B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015C8A RID: 89226 RVA: 0x0032A95C File Offset: 0x00328B5C
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
				if (num != 64U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MinMood = input.ReadInt32();
					}
				}
				else
				{
					this.MaxMood = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400832A RID: 33578
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400832B RID: 33579
		public const int MaxMoodFieldNumber = 8;

		// Token: 0x0400832C RID: 33580
		private int maxMood_;

		// Token: 0x0400832D RID: 33581
		public const int MinMoodFieldNumber = 9;

		// Token: 0x0400832E RID: 33582
		private int minMood_;
	}
}
