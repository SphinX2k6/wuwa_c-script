using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010EB RID: 4331
	[NetMessage(EMessageId.RoleTowerScoreUpdateNotify)]
	public sealed class RoleTowerScoreUpdateNotify : IMessage<RoleTowerScoreUpdateNotify>, IMessage, IEquatable<RoleTowerScoreUpdateNotify>, IDeepCloneable<RoleTowerScoreUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601726A RID: 94826 RVA: 0x0035E1AD File Offset: 0x0035C3AD
		[NullableContext(1)]
		public static RoleTowerScoreUpdateNotify Create()
		{
			return new RoleTowerScoreUpdateNotify();
		}

		// Token: 0x17004DBB RID: 19899
		// (get) Token: 0x0601726B RID: 94827 RVA: 0x0035E1B4 File Offset: 0x0035C3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004DBC RID: 19900
		// (get) Token: 0x0601726C RID: 94828 RVA: 0x0035E1B7 File Offset: 0x0035C3B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerScoreUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601726D RID: 94829 RVA: 0x0035E1BE File Offset: 0x0035C3BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerScoreUpdateNotify()
		{
		}

		// Token: 0x0601726E RID: 94830 RVA: 0x0035E1C6 File Offset: 0x0035C3C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerScoreUpdateNotify(RoleTowerScoreUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.score_ = other.score_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601726F RID: 94831 RVA: 0x0035E1F7 File Offset: 0x0035C3F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerScoreUpdateNotify Clone()
		{
			return new RoleTowerScoreUpdateNotify(this);
		}

		// Token: 0x17004DBD RID: 19901
		// (get) Token: 0x06017270 RID: 94832 RVA: 0x0035E1FF File Offset: 0x0035C3FF
		// (set) Token: 0x06017271 RID: 94833 RVA: 0x0035E207 File Offset: 0x0035C407
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x17004DBE RID: 19902
		// (get) Token: 0x06017272 RID: 94834 RVA: 0x0035E210 File Offset: 0x0035C410
		// (set) Token: 0x06017273 RID: 94835 RVA: 0x0035E218 File Offset: 0x0035C418
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

		// Token: 0x06017274 RID: 94836 RVA: 0x0035E221 File Offset: 0x0035C421
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerScoreUpdateNotify);
		}

		// Token: 0x06017275 RID: 94837 RVA: 0x0035E22F File Offset: 0x0035C42F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerScoreUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Score == other.Score && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017276 RID: 94838 RVA: 0x0035E270 File Offset: 0x0035C470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017277 RID: 94839 RVA: 0x0035E2C8 File Offset: 0x0035C4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017278 RID: 94840 RVA: 0x0035E2D5 File Offset: 0x0035C4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017279 RID: 94841 RVA: 0x0035E2E0 File Offset: 0x0035C4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601727A RID: 94842 RVA: 0x0035E33C File Offset: 0x0035C53C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601727B RID: 94843 RVA: 0x0035E394 File Offset: 0x0035C594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerScoreUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601727C RID: 94844 RVA: 0x0035E3E4 File Offset: 0x0035C5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601727D RID: 94845 RVA: 0x0035E3F0 File Offset: 0x0035C5F0
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
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Score = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008A81 RID: 35457
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008A82 RID: 35458
		public const int ActivityIdFieldNumber = 8;

		// Token: 0x04008A83 RID: 35459
		private int activityId_;

		// Token: 0x04008A84 RID: 35460
		public const int ScoreFieldNumber = 10;

		// Token: 0x04008A85 RID: 35461
		private int score_;
	}
}
