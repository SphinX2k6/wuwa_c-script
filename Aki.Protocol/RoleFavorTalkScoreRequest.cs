using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001068 RID: 4200
	[NetMessage(EMessageId.RoleFavorTalkScoreRequest)]
	public sealed class RoleFavorTalkScoreRequest : IMessage<RoleFavorTalkScoreRequest>, IMessage, IEquatable<RoleFavorTalkScoreRequest>, IDeepCloneable<RoleFavorTalkScoreRequest>, IBufferMessage
	{
		// Token: 0x06016785 RID: 92037 RVA: 0x00344DDF File Offset: 0x00342FDF
		[NullableContext(1)]
		public static RoleFavorTalkScoreRequest Create()
		{
			return new RoleFavorTalkScoreRequest();
		}

		// Token: 0x17004B41 RID: 19265
		// (get) Token: 0x06016786 RID: 92038 RVA: 0x00344DE6 File Offset: 0x00342FE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B42 RID: 19266
		// (get) Token: 0x06016787 RID: 92039 RVA: 0x00344DE9 File Offset: 0x00342FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorTalkScoreRequest.Descriptor;
			}
		}

		// Token: 0x06016788 RID: 92040 RVA: 0x00344DF0 File Offset: 0x00342FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorTalkScoreRequest()
		{
		}

		// Token: 0x06016789 RID: 92041 RVA: 0x00344DF8 File Offset: 0x00342FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorTalkScoreRequest(RoleFavorTalkScoreRequest other) : this()
		{
			this.score_ = other.score_;
			this.errorCount_ = other.errorCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601678A RID: 92042 RVA: 0x00344E29 File Offset: 0x00343029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorTalkScoreRequest Clone()
		{
			return new RoleFavorTalkScoreRequest(this);
		}

		// Token: 0x17004B43 RID: 19267
		// (get) Token: 0x0601678B RID: 92043 RVA: 0x00344E31 File Offset: 0x00343031
		// (set) Token: 0x0601678C RID: 92044 RVA: 0x00344E39 File Offset: 0x00343039
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x17004B44 RID: 19268
		// (get) Token: 0x0601678D RID: 92045 RVA: 0x00344E42 File Offset: 0x00343042
		// (set) Token: 0x0601678E RID: 92046 RVA: 0x00344E4A File Offset: 0x0034304A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ErrorCount
		{
			get
			{
				return this.errorCount_;
			}
			set
			{
				this.errorCount_ = value;
			}
		}

		// Token: 0x0601678F RID: 92047 RVA: 0x00344E53 File Offset: 0x00343053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorTalkScoreRequest);
		}

		// Token: 0x06016790 RID: 92048 RVA: 0x00344E61 File Offset: 0x00343061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorTalkScoreRequest other)
		{
			return other != null && (other == this || (this.Score == other.Score && this.ErrorCount == other.ErrorCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016791 RID: 92049 RVA: 0x00344EA0 File Offset: 0x003430A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.ErrorCount != 0)
			{
				num ^= this.ErrorCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016792 RID: 92050 RVA: 0x00344EF8 File Offset: 0x003430F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016793 RID: 92051 RVA: 0x00344F05 File Offset: 0x00343105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016794 RID: 92052 RVA: 0x00344F10 File Offset: 0x00343110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Score != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Score);
			}
			if (this.ErrorCount != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ErrorCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016795 RID: 92053 RVA: 0x00344F6C File Offset: 0x0034316C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.ErrorCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ErrorCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016796 RID: 92054 RVA: 0x00344FC4 File Offset: 0x003431C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleFavorTalkScoreRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.ErrorCount != 0)
			{
				this.ErrorCount = other.ErrorCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016797 RID: 92055 RVA: 0x00345014 File Offset: 0x00343214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016798 RID: 92056 RVA: 0x00345020 File Offset: 0x00343220
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
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCount = input.ReadInt32();
					}
				}
				else
				{
					this.Score = input.ReadInt32();
				}
			}
		}

		// Token: 0x040086D8 RID: 34520
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086D9 RID: 34521
		public const int ScoreFieldNumber = 5;

		// Token: 0x040086DA RID: 34522
		private int score_;

		// Token: 0x040086DB RID: 34523
		public const int ErrorCountFieldNumber = 9;

		// Token: 0x040086DC RID: 34524
		private int errorCount_;
	}
}
