using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200054D RID: 1357
	public sealed class FishingIllustratedRewardInfo : IMessage<FishingIllustratedRewardInfo>, IMessage, IEquatable<FishingIllustratedRewardInfo>, IDeepCloneable<FishingIllustratedRewardInfo>, IBufferMessage
	{
		// Token: 0x06007F0C RID: 32524 RVA: 0x00133887 File Offset: 0x00131A87
		[NullableContext(1)]
		public static FishingIllustratedRewardInfo Create()
		{
			return new FishingIllustratedRewardInfo();
		}

		// Token: 0x170018B5 RID: 6325
		// (get) Token: 0x06007F0D RID: 32525 RVA: 0x0013388E File Offset: 0x00131A8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<FishingIllustratedRewardInfo> Parser
		{
			get
			{
				return FishingIllustratedRewardInfo._parser;
			}
		}

		// Token: 0x170018B6 RID: 6326
		// (get) Token: 0x06007F0E RID: 32526 RVA: 0x00133895 File Offset: 0x00131A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018B7 RID: 6327
		// (get) Token: 0x06007F0F RID: 32527 RVA: 0x00133898 File Offset: 0x00131A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingIllustratedRewardInfo.Descriptor;
			}
		}

		// Token: 0x06007F10 RID: 32528 RVA: 0x0013389F File Offset: 0x00131A9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardInfo()
		{
		}

		// Token: 0x06007F11 RID: 32529 RVA: 0x001338A8 File Offset: 0x00131AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardInfo(FishingIllustratedRewardInfo other) : this()
		{
			this.id_ = other.id_;
			this.current_ = other.current_;
			this.target_ = other.target_;
			this.isFinished_ = other.isFinished_;
			this.isTaken_ = other.isTaken_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F12 RID: 32530 RVA: 0x00133908 File Offset: 0x00131B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardInfo Clone()
		{
			return new FishingIllustratedRewardInfo(this);
		}

		// Token: 0x170018B8 RID: 6328
		// (get) Token: 0x06007F13 RID: 32531 RVA: 0x00133910 File Offset: 0x00131B10
		// (set) Token: 0x06007F14 RID: 32532 RVA: 0x00133918 File Offset: 0x00131B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170018B9 RID: 6329
		// (get) Token: 0x06007F15 RID: 32533 RVA: 0x00133921 File Offset: 0x00131B21
		// (set) Token: 0x06007F16 RID: 32534 RVA: 0x00133929 File Offset: 0x00131B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Current
		{
			get
			{
				return this.current_;
			}
			set
			{
				this.current_ = value;
			}
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x06007F17 RID: 32535 RVA: 0x00133932 File Offset: 0x00131B32
		// (set) Token: 0x06007F18 RID: 32536 RVA: 0x0013393A File Offset: 0x00131B3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x06007F19 RID: 32537 RVA: 0x00133943 File Offset: 0x00131B43
		// (set) Token: 0x06007F1A RID: 32538 RVA: 0x0013394B File Offset: 0x00131B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsFinished
		{
			get
			{
				return this.isFinished_;
			}
			set
			{
				this.isFinished_ = value;
			}
		}

		// Token: 0x170018BC RID: 6332
		// (get) Token: 0x06007F1B RID: 32539 RVA: 0x00133954 File Offset: 0x00131B54
		// (set) Token: 0x06007F1C RID: 32540 RVA: 0x0013395C File Offset: 0x00131B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTaken
		{
			get
			{
				return this.isTaken_;
			}
			set
			{
				this.isTaken_ = value;
			}
		}

		// Token: 0x06007F1D RID: 32541 RVA: 0x00133965 File Offset: 0x00131B65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingIllustratedRewardInfo);
		}

		// Token: 0x06007F1E RID: 32542 RVA: 0x00133974 File Offset: 0x00131B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingIllustratedRewardInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.IsFinished == other.IsFinished && this.IsTaken == other.IsTaken && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F1F RID: 32543 RVA: 0x001339F0 File Offset: 0x00131BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Current != 0)
			{
				int num2 = num;
				int num3 = this.Current;
				num = (num2 ^ num3.GetHashCode());
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this.IsFinished)
			{
				num ^= this.IsFinished.GetHashCode();
			}
			if (this.IsTaken)
			{
				num ^= this.IsTaken.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F20 RID: 32544 RVA: 0x00133A93 File Offset: 0x00131C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F21 RID: 32545 RVA: 0x00133AA0 File Offset: 0x00131CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F22 RID: 32546 RVA: 0x00133AAC File Offset: 0x00131CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Current != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Current);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Target);
			}
			if (this.IsFinished)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsFinished);
			}
			if (this.IsTaken)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.IsTaken);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F23 RID: 32547 RVA: 0x00133B58 File Offset: 0x00131D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Current != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Current);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this.IsFinished)
			{
				num += 2;
			}
			if (this.IsTaken)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F24 RID: 32548 RVA: 0x00133BE0 File Offset: 0x00131DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingIllustratedRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Current != 0)
			{
				this.Current = other.Current;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			if (other.IsFinished)
			{
				this.IsFinished = other.IsFinished;
			}
			if (other.IsTaken)
			{
				this.IsTaken = other.IsTaken;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F25 RID: 32549 RVA: 0x00133C6C File Offset: 0x00131E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F26 RID: 32550 RVA: 0x00133C78 File Offset: 0x00131E78
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Current = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Target = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IsFinished = input.ReadBool();
						continue;
					}
					if (num == 40U)
					{
						this.IsTaken = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400409C RID: 16540
		private static readonly MessageParser<FishingIllustratedRewardInfo> _parser = new MessageParser<FishingIllustratedRewardInfo>(() => new FishingIllustratedRewardInfo());

		// Token: 0x0400409D RID: 16541
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400409E RID: 16542
		public const int IdFieldNumber = 1;

		// Token: 0x0400409F RID: 16543
		private int id_;

		// Token: 0x040040A0 RID: 16544
		public const int CurrentFieldNumber = 2;

		// Token: 0x040040A1 RID: 16545
		private int current_;

		// Token: 0x040040A2 RID: 16546
		public const int TargetFieldNumber = 3;

		// Token: 0x040040A3 RID: 16547
		private int target_;

		// Token: 0x040040A4 RID: 16548
		public const int IsFinishedFieldNumber = 4;

		// Token: 0x040040A5 RID: 16549
		private bool isFinished_;

		// Token: 0x040040A6 RID: 16550
		public const int IsTakenFieldNumber = 5;

		// Token: 0x040040A7 RID: 16551
		private bool isTaken_;
	}
}
