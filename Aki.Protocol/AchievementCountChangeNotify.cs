using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000059 RID: 89
	[NetMessage(EMessageId.AchievementCountChangeNotify)]
	public sealed class AchievementCountChangeNotify : IMessage<AchievementCountChangeNotify>, IMessage, IEquatable<AchievementCountChangeNotify>, IDeepCloneable<AchievementCountChangeNotify>, IBufferMessage
	{
		// Token: 0x06001588 RID: 5512 RVA: 0x00039173 File Offset: 0x00037373
		[NullableContext(1)]
		public static AchievementCountChangeNotify Create()
		{
			return new AchievementCountChangeNotify();
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06001589 RID: 5513 RVA: 0x0003917A File Offset: 0x0003737A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x0600158A RID: 5514 RVA: 0x0003917D File Offset: 0x0003737D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementCountChangeNotify.Descriptor;
			}
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00039184 File Offset: 0x00037384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementCountChangeNotify()
		{
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x0003918C File Offset: 0x0003738C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementCountChangeNotify(AchievementCountChangeNotify other) : this()
		{
			this.starCount_ = other.starCount_;
			this.finishCount_ = other.finishCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600158D RID: 5517 RVA: 0x000391BD File Offset: 0x000373BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementCountChangeNotify Clone()
		{
			return new AchievementCountChangeNotify(this);
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x000391C5 File Offset: 0x000373C5
		// (set) Token: 0x0600158F RID: 5519 RVA: 0x000391CD File Offset: 0x000373CD
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

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x000391D6 File Offset: 0x000373D6
		// (set) Token: 0x06001591 RID: 5521 RVA: 0x000391DE File Offset: 0x000373DE
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

		// Token: 0x06001592 RID: 5522 RVA: 0x000391E7 File Offset: 0x000373E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementCountChangeNotify);
		}

		// Token: 0x06001593 RID: 5523 RVA: 0x000391F5 File Offset: 0x000373F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementCountChangeNotify other)
		{
			return other != null && (other == this || (this.StarCount == other.StarCount && this.FinishCount == other.FinishCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001594 RID: 5524 RVA: 0x00039234 File Offset: 0x00037434
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

		// Token: 0x06001595 RID: 5525 RVA: 0x0003928C File Offset: 0x0003748C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001596 RID: 5526 RVA: 0x00039299 File Offset: 0x00037499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x000392A4 File Offset: 0x000374A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FinishCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.FinishCount);
			}
			if (this.StarCount != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.StarCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x00039300 File Offset: 0x00037500
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

		// Token: 0x06001599 RID: 5529 RVA: 0x00039358 File Offset: 0x00037558
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

		// Token: 0x0600159A RID: 5530 RVA: 0x000393A8 File Offset: 0x000375A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x000393B4 File Offset: 0x000375B4
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
				if (num != 104U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.StarCount = input.ReadInt32();
					}
				}
				else
				{
					this.FinishCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x040020A6 RID: 8358
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020A7 RID: 8359
		public const int StarCountFieldNumber = 14;

		// Token: 0x040020A8 RID: 8360
		private int starCount_;

		// Token: 0x040020A9 RID: 8361
		public const int FinishCountFieldNumber = 13;

		// Token: 0x040020AA RID: 8362
		private int finishCount_;
	}
}
