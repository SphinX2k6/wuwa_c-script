using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200103B RID: 4155
	[NetMessage(EMessageId.RogueWeeklyInteractionResultNotify)]
	public sealed class RogueWeeklyInteractionResultNotify : IMessage<RogueWeeklyInteractionResultNotify>, IMessage, IEquatable<RogueWeeklyInteractionResultNotify>, IDeepCloneable<RogueWeeklyInteractionResultNotify>, IBufferMessage
	{
		// Token: 0x06016348 RID: 90952 RVA: 0x00339E01 File Offset: 0x00338001
		[NullableContext(1)]
		public static RogueWeeklyInteractionResultNotify Create()
		{
			return new RogueWeeklyInteractionResultNotify();
		}

		// Token: 0x17004A3C RID: 19004
		// (get) Token: 0x06016349 RID: 90953 RVA: 0x00339E08 File Offset: 0x00338008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004A3D RID: 19005
		// (get) Token: 0x0601634A RID: 90954 RVA: 0x00339E0B File Offset: 0x0033800B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyInteractionResultNotify.Descriptor;
			}
		}

		// Token: 0x0601634B RID: 90955 RVA: 0x00339E12 File Offset: 0x00338012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyInteractionResultNotify()
		{
		}

		// Token: 0x0601634C RID: 90956 RVA: 0x00339E1A File Offset: 0x0033801A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyInteractionResultNotify(RogueWeeklyInteractionResultNotify other) : this()
		{
			this.curScore_ = other.curScore_;
			this.maxScore_ = other.maxScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601634D RID: 90957 RVA: 0x00339E4B File Offset: 0x0033804B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyInteractionResultNotify Clone()
		{
			return new RogueWeeklyInteractionResultNotify(this);
		}

		// Token: 0x17004A3E RID: 19006
		// (get) Token: 0x0601634E RID: 90958 RVA: 0x00339E53 File Offset: 0x00338053
		// (set) Token: 0x0601634F RID: 90959 RVA: 0x00339E5B File Offset: 0x0033805B
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

		// Token: 0x17004A3F RID: 19007
		// (get) Token: 0x06016350 RID: 90960 RVA: 0x00339E64 File Offset: 0x00338064
		// (set) Token: 0x06016351 RID: 90961 RVA: 0x00339E6C File Offset: 0x0033806C
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

		// Token: 0x06016352 RID: 90962 RVA: 0x00339E75 File Offset: 0x00338075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyInteractionResultNotify);
		}

		// Token: 0x06016353 RID: 90963 RVA: 0x00339E83 File Offset: 0x00338083
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyInteractionResultNotify other)
		{
			return other != null && (other == this || (this.CurScore == other.CurScore && this.MaxScore == other.MaxScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016354 RID: 90964 RVA: 0x00339EC4 File Offset: 0x003380C4
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

		// Token: 0x06016355 RID: 90965 RVA: 0x00339F1C File Offset: 0x0033811C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016356 RID: 90966 RVA: 0x00339F29 File Offset: 0x00338129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016357 RID: 90967 RVA: 0x00339F34 File Offset: 0x00338134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxScore != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MaxScore);
			}
			if (this.CurScore != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.CurScore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016358 RID: 90968 RVA: 0x00339F90 File Offset: 0x00338190
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

		// Token: 0x06016359 RID: 90969 RVA: 0x00339FE8 File Offset: 0x003381E8
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

		// Token: 0x0601635A RID: 90970 RVA: 0x0033A038 File Offset: 0x00338238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601635B RID: 90971 RVA: 0x0033A044 File Offset: 0x00338244
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
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CurScore = input.ReadInt32();
					}
				}
				else
				{
					this.MaxScore = input.ReadInt32();
				}
			}
		}

		// Token: 0x040084E5 RID: 34021
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084E6 RID: 34022
		public const int CurScoreFieldNumber = 6;

		// Token: 0x040084E7 RID: 34023
		private int curScore_;

		// Token: 0x040084E8 RID: 34024
		public const int MaxScoreFieldNumber = 5;

		// Token: 0x040084E9 RID: 34025
		private int maxScore_;
	}
}
