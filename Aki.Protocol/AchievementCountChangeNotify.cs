using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200005A RID: 90
	[NetMessage(EMessageId.AchievementCountChangeNotify)]
	public sealed class AchievementCountChangeNotify : IMessage<AchievementCountChangeNotify>, IMessage, IEquatable<AchievementCountChangeNotify>, IDeepCloneable<AchievementCountChangeNotify>, IBufferMessage
	{
		// Token: 0x060015CB RID: 5579 RVA: 0x00039B17 File Offset: 0x00037D17
		[NullableContext(1)]
		public static AchievementCountChangeNotify Create()
		{
			return new AchievementCountChangeNotify();
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060015CC RID: 5580 RVA: 0x00039B1E File Offset: 0x00037D1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060015CD RID: 5581 RVA: 0x00039B21 File Offset: 0x00037D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementCountChangeNotify.Descriptor;
			}
		}

		// Token: 0x060015CE RID: 5582 RVA: 0x00039B28 File Offset: 0x00037D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementCountChangeNotify()
		{
		}

		// Token: 0x060015CF RID: 5583 RVA: 0x00039B30 File Offset: 0x00037D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementCountChangeNotify(AchievementCountChangeNotify other) : this()
		{
			this.starCount_ = other.starCount_;
			this.finishCount_ = other.finishCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060015D0 RID: 5584 RVA: 0x00039B61 File Offset: 0x00037D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementCountChangeNotify Clone()
		{
			return new AchievementCountChangeNotify(this);
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060015D1 RID: 5585 RVA: 0x00039B69 File Offset: 0x00037D69
		// (set) Token: 0x060015D2 RID: 5586 RVA: 0x00039B71 File Offset: 0x00037D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int StarCount
		{
			get
			{
				return this.starCount_;
			}
			set
			{
				this.starCount_ = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060015D3 RID: 5587 RVA: 0x00039B7A File Offset: 0x00037D7A
		// (set) Token: 0x060015D4 RID: 5588 RVA: 0x00039B82 File Offset: 0x00037D82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FinishCount
		{
			get
			{
				return this.finishCount_;
			}
			set
			{
				this.finishCount_ = value;
			}
		}

		// Token: 0x060015D5 RID: 5589 RVA: 0x00039B8B File Offset: 0x00037D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementCountChangeNotify);
		}

		// Token: 0x060015D6 RID: 5590 RVA: 0x00039B99 File Offset: 0x00037D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementCountChangeNotify other)
		{
			return other != null && (other == this || (this.StarCount == other.StarCount && this.FinishCount == other.FinishCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060015D7 RID: 5591 RVA: 0x00039BD8 File Offset: 0x00037DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.StarCount != 0)
			{
				num ^= this.StarCount.GetHashCode();
			}
			if (this.FinishCount != 0)
			{
				num ^= this.FinishCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060015D8 RID: 5592 RVA: 0x00039C30 File Offset: 0x00037E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060015D9 RID: 5593 RVA: 0x00039C3D File Offset: 0x00037E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060015DA RID: 5594 RVA: 0x00039C48 File Offset: 0x00037E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.StarCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.StarCount);
			}
			if (this.FinishCount != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.FinishCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060015DB RID: 5595 RVA: 0x00039CA4 File Offset: 0x00037EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.StarCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.StarCount);
			}
			if (this.FinishCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FinishCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060015DC RID: 5596 RVA: 0x00039CFC File Offset: 0x00037EFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementCountChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.StarCount != 0)
			{
				this.StarCount = other.StarCount;
			}
			if (other.FinishCount != 0)
			{
				this.FinishCount = other.FinishCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060015DD RID: 5597 RVA: 0x00039D4C File Offset: 0x00037F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060015DE RID: 5598 RVA: 0x00039D58 File Offset: 0x00037F58
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.FinishCount = input.ReadInt32();
					}
				}
				else
				{
					this.StarCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002105 RID: 8453
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002106 RID: 8454
		public const int StarCountFieldNumber = 5;

		// Token: 0x04002107 RID: 8455
		private int starCount_;

		// Token: 0x04002108 RID: 8456
		public const int FinishCountFieldNumber = 8;

		// Token: 0x04002109 RID: 8457
		private int finishCount_;
	}
}
