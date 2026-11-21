using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200133F RID: 4927
	[NetMessage(EMessageId.SurvivorsMonsterConsecutiveKillsNotify)]
	public sealed class SurvivorsMonsterConsecutiveKillsNotify : IMessage<SurvivorsMonsterConsecutiveKillsNotify>, IMessage, IEquatable<SurvivorsMonsterConsecutiveKillsNotify>, IDeepCloneable<SurvivorsMonsterConsecutiveKillsNotify>, IBufferMessage
	{
		// Token: 0x0601A42F RID: 107567 RVA: 0x003D4151 File Offset: 0x003D2351
		[NullableContext(1)]
		public static SurvivorsMonsterConsecutiveKillsNotify Create()
		{
			return new SurvivorsMonsterConsecutiveKillsNotify();
		}

		// Token: 0x170058F3 RID: 22771
		// (get) Token: 0x0601A430 RID: 107568 RVA: 0x003D4158 File Offset: 0x003D2358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058F4 RID: 22772
		// (get) Token: 0x0601A431 RID: 107569 RVA: 0x003D415B File Offset: 0x003D235B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsMonsterConsecutiveKillsNotify.Descriptor;
			}
		}

		// Token: 0x0601A432 RID: 107570 RVA: 0x003D4162 File Offset: 0x003D2362
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterConsecutiveKillsNotify()
		{
		}

		// Token: 0x0601A433 RID: 107571 RVA: 0x003D416A File Offset: 0x003D236A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterConsecutiveKillsNotify(SurvivorsMonsterConsecutiveKillsNotify other) : this()
		{
			this.consecutiveKillCount_ = other.consecutiveKillCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A434 RID: 107572 RVA: 0x003D418F File Offset: 0x003D238F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsMonsterConsecutiveKillsNotify Clone()
		{
			return new SurvivorsMonsterConsecutiveKillsNotify(this);
		}

		// Token: 0x170058F5 RID: 22773
		// (get) Token: 0x0601A435 RID: 107573 RVA: 0x003D4197 File Offset: 0x003D2397
		// (set) Token: 0x0601A436 RID: 107574 RVA: 0x003D419F File Offset: 0x003D239F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConsecutiveKillCount
		{
			get
			{
				return this.consecutiveKillCount_;
			}
			set
			{
				this.consecutiveKillCount_ = value;
			}
		}

		// Token: 0x0601A437 RID: 107575 RVA: 0x003D41A8 File Offset: 0x003D23A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsMonsterConsecutiveKillsNotify);
		}

		// Token: 0x0601A438 RID: 107576 RVA: 0x003D41B6 File Offset: 0x003D23B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsMonsterConsecutiveKillsNotify other)
		{
			return other != null && (other == this || (this.ConsecutiveKillCount == other.ConsecutiveKillCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A439 RID: 107577 RVA: 0x003D41E4 File Offset: 0x003D23E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConsecutiveKillCount != 0)
			{
				num ^= this.ConsecutiveKillCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A43A RID: 107578 RVA: 0x003D4223 File Offset: 0x003D2423
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A43B RID: 107579 RVA: 0x003D4230 File Offset: 0x003D2430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A43C RID: 107580 RVA: 0x003D4239 File Offset: 0x003D2439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConsecutiveKillCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ConsecutiveKillCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A43D RID: 107581 RVA: 0x003D426C File Offset: 0x003D246C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConsecutiveKillCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConsecutiveKillCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A43E RID: 107582 RVA: 0x003D42AA File Offset: 0x003D24AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsMonsterConsecutiveKillsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConsecutiveKillCount != 0)
			{
				this.ConsecutiveKillCount = other.ConsecutiveKillCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A43F RID: 107583 RVA: 0x003D42DB File Offset: 0x003D24DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A440 RID: 107584 RVA: 0x003D42E4 File Offset: 0x003D24E4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConsecutiveKillCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A72 RID: 39538
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A73 RID: 39539
		public const int ConsecutiveKillCountFieldNumber = 13;

		// Token: 0x04009A74 RID: 39540
		private int consecutiveKillCount_;
	}
}
