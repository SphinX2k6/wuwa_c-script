using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001078 RID: 4216
	[NetMessage(EMessageId.RoleFavorTalkScoreRequest)]
	public sealed class RoleFavorTalkScoreRequest : IMessage<RoleFavorTalkScoreRequest>, IMessage, IEquatable<RoleFavorTalkScoreRequest>, IDeepCloneable<RoleFavorTalkScoreRequest>, IBufferMessage
	{
		// Token: 0x0601686A RID: 92266 RVA: 0x003464B3 File Offset: 0x003446B3
		[NullableContext(1)]
		public static RoleFavorTalkScoreRequest Create()
		{
			return new RoleFavorTalkScoreRequest();
		}

		// Token: 0x17004B6B RID: 19307
		// (get) Token: 0x0601686B RID: 92267 RVA: 0x003464BA File Offset: 0x003446BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B6C RID: 19308
		// (get) Token: 0x0601686C RID: 92268 RVA: 0x003464BD File Offset: 0x003446BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleFavorTalkScoreRequest.Descriptor;
			}
		}

		// Token: 0x0601686D RID: 92269 RVA: 0x003464C4 File Offset: 0x003446C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorTalkScoreRequest()
		{
		}

		// Token: 0x0601686E RID: 92270 RVA: 0x003464CC File Offset: 0x003446CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorTalkScoreRequest(RoleFavorTalkScoreRequest other) : this()
		{
			this.score_ = other.score_;
			this.errorCount_ = other.errorCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601686F RID: 92271 RVA: 0x003464FD File Offset: 0x003446FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleFavorTalkScoreRequest Clone()
		{
			return new RoleFavorTalkScoreRequest(this);
		}

		// Token: 0x17004B6D RID: 19309
		// (get) Token: 0x06016870 RID: 92272 RVA: 0x00346505 File Offset: 0x00344705
		// (set) Token: 0x06016871 RID: 92273 RVA: 0x0034650D File Offset: 0x0034470D
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

		// Token: 0x17004B6E RID: 19310
		// (get) Token: 0x06016872 RID: 92274 RVA: 0x00346516 File Offset: 0x00344716
		// (set) Token: 0x06016873 RID: 92275 RVA: 0x0034651E File Offset: 0x0034471E
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

		// Token: 0x06016874 RID: 92276 RVA: 0x00346527 File Offset: 0x00344727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleFavorTalkScoreRequest);
		}

		// Token: 0x06016875 RID: 92277 RVA: 0x00346535 File Offset: 0x00344735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleFavorTalkScoreRequest other)
		{
			return other != null && (other == this || (this.Score == other.Score && this.ErrorCount == other.ErrorCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016876 RID: 92278 RVA: 0x00346574 File Offset: 0x00344774
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

		// Token: 0x06016877 RID: 92279 RVA: 0x003465CC File Offset: 0x003447CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016878 RID: 92280 RVA: 0x003465D9 File Offset: 0x003447D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016879 RID: 92281 RVA: 0x003465E4 File Offset: 0x003447E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCount != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ErrorCount);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Score);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601687A RID: 92282 RVA: 0x00346640 File Offset: 0x00344840
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

		// Token: 0x0601687B RID: 92283 RVA: 0x00346698 File Offset: 0x00344898
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

		// Token: 0x0601687C RID: 92284 RVA: 0x003466E8 File Offset: 0x003448E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601687D RID: 92285 RVA: 0x003466F4 File Offset: 0x003448F4
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
				if (num != 56U)
				{
					if (num != 64U)
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
					this.ErrorCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x040086AE RID: 34478
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086AF RID: 34479
		public const int ScoreFieldNumber = 8;

		// Token: 0x040086B0 RID: 34480
		private int score_;

		// Token: 0x040086B1 RID: 34481
		public const int ErrorCountFieldNumber = 7;

		// Token: 0x040086B2 RID: 34482
		private int errorCount_;
	}
}
