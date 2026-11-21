using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200102B RID: 4139
	[NetMessage(EMessageId.RogueWeeklyInteractionResultNotify)]
	public sealed class RogueWeeklyInteractionResultNotify : IMessage<RogueWeeklyInteractionResultNotify>, IMessage, IEquatable<RogueWeeklyInteractionResultNotify>, IDeepCloneable<RogueWeeklyInteractionResultNotify>, IBufferMessage
	{
		// Token: 0x06016263 RID: 90723 RVA: 0x0033873A File Offset: 0x0033693A
		[NullableContext(1)]
		public static RogueWeeklyInteractionResultNotify Create()
		{
			return new RogueWeeklyInteractionResultNotify();
		}

		// Token: 0x17004A12 RID: 18962
		// (get) Token: 0x06016264 RID: 90724 RVA: 0x00338741 File Offset: 0x00336941
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A13 RID: 18963
		// (get) Token: 0x06016265 RID: 90725 RVA: 0x00338744 File Offset: 0x00336944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyInteractionResultNotify.Descriptor;
			}
		}

		// Token: 0x06016266 RID: 90726 RVA: 0x0033874B File Offset: 0x0033694B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyInteractionResultNotify()
		{
		}

		// Token: 0x06016267 RID: 90727 RVA: 0x00338753 File Offset: 0x00336953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyInteractionResultNotify(RogueWeeklyInteractionResultNotify other) : this()
		{
			this.curScore_ = other.curScore_;
			this.maxScore_ = other.maxScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016268 RID: 90728 RVA: 0x00338784 File Offset: 0x00336984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyInteractionResultNotify Clone()
		{
			return new RogueWeeklyInteractionResultNotify(this);
		}

		// Token: 0x17004A14 RID: 18964
		// (get) Token: 0x06016269 RID: 90729 RVA: 0x0033878C File Offset: 0x0033698C
		// (set) Token: 0x0601626A RID: 90730 RVA: 0x00338794 File Offset: 0x00336994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurScore
		{
			get
			{
				return this.curScore_;
			}
			set
			{
				this.curScore_ = value;
			}
		}

		// Token: 0x17004A15 RID: 18965
		// (get) Token: 0x0601626B RID: 90731 RVA: 0x0033879D File Offset: 0x0033699D
		// (set) Token: 0x0601626C RID: 90732 RVA: 0x003387A5 File Offset: 0x003369A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxScore
		{
			get
			{
				return this.maxScore_;
			}
			set
			{
				this.maxScore_ = value;
			}
		}

		// Token: 0x0601626D RID: 90733 RVA: 0x003387AE File Offset: 0x003369AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyInteractionResultNotify);
		}

		// Token: 0x0601626E RID: 90734 RVA: 0x003387BC File Offset: 0x003369BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyInteractionResultNotify other)
		{
			return other != null && (other == this || (this.CurScore == other.CurScore && this.MaxScore == other.MaxScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601626F RID: 90735 RVA: 0x003387FC File Offset: 0x003369FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurScore != 0)
			{
				num ^= this.CurScore.GetHashCode();
			}
			if (this.MaxScore != 0)
			{
				num ^= this.MaxScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016270 RID: 90736 RVA: 0x00338854 File Offset: 0x00336A54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016271 RID: 90737 RVA: 0x00338861 File Offset: 0x00336A61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016272 RID: 90738 RVA: 0x0033886C File Offset: 0x00336A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurScore != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurScore);
			}
			if (this.MaxScore != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.MaxScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016273 RID: 90739 RVA: 0x003388C4 File Offset: 0x00336AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurScore);
			}
			if (this.MaxScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016274 RID: 90740 RVA: 0x0033891C File Offset: 0x00336B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyInteractionResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurScore != 0)
			{
				this.CurScore = other.CurScore;
			}
			if (other.MaxScore != 0)
			{
				this.MaxScore = other.MaxScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016275 RID: 90741 RVA: 0x0033896C File Offset: 0x00336B6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016276 RID: 90742 RVA: 0x00338978 File Offset: 0x00336B78
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
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.MaxScore = input.ReadInt32();
					}
				}
				else
				{
					this.CurScore = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400850F RID: 34063
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008510 RID: 34064
		public const int CurScoreFieldNumber = 1;

		// Token: 0x04008511 RID: 34065
		private int curScore_;

		// Token: 0x04008512 RID: 34066
		public const int MaxScoreFieldNumber = 12;

		// Token: 0x04008513 RID: 34067
		private int maxScore_;
	}
}
