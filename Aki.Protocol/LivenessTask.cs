using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000924 RID: 2340
	public sealed class LivenessTask : IMessage<LivenessTask>, IMessage, IEquatable<LivenessTask>, IDeepCloneable<LivenessTask>, IBufferMessage
	{
		// Token: 0x0600CEA2 RID: 52898 RVA: 0x001E71F8 File Offset: 0x001E53F8
		[NullableContext(1)]
		public static LivenessTask Create()
		{
			return new LivenessTask();
		}

		// Token: 0x170029B8 RID: 10680
		// (get) Token: 0x0600CEA3 RID: 52899 RVA: 0x001E71FF File Offset: 0x001E53FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LivenessTask> Parser
		{
			get
			{
				return LivenessTask._parser;
			}
		}

		// Token: 0x170029B9 RID: 10681
		// (get) Token: 0x0600CEA4 RID: 52900 RVA: 0x001E7206 File Offset: 0x001E5406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029BA RID: 10682
		// (get) Token: 0x0600CEA5 RID: 52901 RVA: 0x001E7209 File Offset: 0x001E5409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LivenessTask.Descriptor;
			}
		}

		// Token: 0x0600CEA6 RID: 52902 RVA: 0x001E7210 File Offset: 0x001E5410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTask()
		{
		}

		// Token: 0x0600CEA7 RID: 52903 RVA: 0x001E7218 File Offset: 0x001E5418
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTask(LivenessTask other) : this()
		{
			this.id_ = other.id_;
			this.current_ = other.current_;
			this.target_ = other.target_;
			this.isFinished_ = other.isFinished_;
			this.isTaken_ = other.isTaken_;
			this.isConditionUnlock_ = other.isConditionUnlock_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CEA8 RID: 52904 RVA: 0x001E7284 File Offset: 0x001E5484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LivenessTask Clone()
		{
			return new LivenessTask(this);
		}

		// Token: 0x170029BB RID: 10683
		// (get) Token: 0x0600CEA9 RID: 52905 RVA: 0x001E728C File Offset: 0x001E548C
		// (set) Token: 0x0600CEAA RID: 52906 RVA: 0x001E7294 File Offset: 0x001E5494
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

		// Token: 0x170029BC RID: 10684
		// (get) Token: 0x0600CEAB RID: 52907 RVA: 0x001E729D File Offset: 0x001E549D
		// (set) Token: 0x0600CEAC RID: 52908 RVA: 0x001E72A5 File Offset: 0x001E54A5
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

		// Token: 0x170029BD RID: 10685
		// (get) Token: 0x0600CEAD RID: 52909 RVA: 0x001E72AE File Offset: 0x001E54AE
		// (set) Token: 0x0600CEAE RID: 52910 RVA: 0x001E72B6 File Offset: 0x001E54B6
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

		// Token: 0x170029BE RID: 10686
		// (get) Token: 0x0600CEAF RID: 52911 RVA: 0x001E72BF File Offset: 0x001E54BF
		// (set) Token: 0x0600CEB0 RID: 52912 RVA: 0x001E72C7 File Offset: 0x001E54C7
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

		// Token: 0x170029BF RID: 10687
		// (get) Token: 0x0600CEB1 RID: 52913 RVA: 0x001E72D0 File Offset: 0x001E54D0
		// (set) Token: 0x0600CEB2 RID: 52914 RVA: 0x001E72D8 File Offset: 0x001E54D8
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

		// Token: 0x170029C0 RID: 10688
		// (get) Token: 0x0600CEB3 RID: 52915 RVA: 0x001E72E1 File Offset: 0x001E54E1
		// (set) Token: 0x0600CEB4 RID: 52916 RVA: 0x001E72E9 File Offset: 0x001E54E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsConditionUnlock
		{
			get
			{
				return this.isConditionUnlock_;
			}
			set
			{
				this.isConditionUnlock_ = value;
			}
		}

		// Token: 0x0600CEB5 RID: 52917 RVA: 0x001E72F2 File Offset: 0x001E54F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LivenessTask);
		}

		// Token: 0x0600CEB6 RID: 52918 RVA: 0x001E7300 File Offset: 0x001E5500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LivenessTask other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.IsFinished == other.IsFinished && this.IsTaken == other.IsTaken && this.IsConditionUnlock == other.IsConditionUnlock && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CEB7 RID: 52919 RVA: 0x001E738C File Offset: 0x001E558C
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
			if (this.IsConditionUnlock)
			{
				num ^= this.IsConditionUnlock.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CEB8 RID: 52920 RVA: 0x001E7448 File Offset: 0x001E5648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CEB9 RID: 52921 RVA: 0x001E7455 File Offset: 0x001E5655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CEBA RID: 52922 RVA: 0x001E7460 File Offset: 0x001E5660
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
			if (this.IsConditionUnlock)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsConditionUnlock);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CEBB RID: 52923 RVA: 0x001E7528 File Offset: 0x001E5728
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
			if (this.IsConditionUnlock)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CEBC RID: 52924 RVA: 0x001E75BC File Offset: 0x001E57BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LivenessTask other)
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
			if (other.IsConditionUnlock)
			{
				this.IsConditionUnlock = other.IsConditionUnlock;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CEBD RID: 52925 RVA: 0x001E765C File Offset: 0x001E585C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CEBE RID: 52926 RVA: 0x001E7668 File Offset: 0x001E5868
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
				if (num <= 24U)
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
					if (num == 24U)
					{
						this.Target = input.ReadInt32();
						continue;
					}
				}
				else
				{
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
					if (num == 48U)
					{
						this.IsConditionUnlock = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040057A0 RID: 22432
		private static readonly MessageParser<LivenessTask> _parser = new MessageParser<LivenessTask>(() => new LivenessTask());

		// Token: 0x040057A1 RID: 22433
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057A2 RID: 22434
		public const int IdFieldNumber = 1;

		// Token: 0x040057A3 RID: 22435
		private int id_;

		// Token: 0x040057A4 RID: 22436
		public const int CurrentFieldNumber = 2;

		// Token: 0x040057A5 RID: 22437
		private int current_;

		// Token: 0x040057A6 RID: 22438
		public const int TargetFieldNumber = 3;

		// Token: 0x040057A7 RID: 22439
		private int target_;

		// Token: 0x040057A8 RID: 22440
		public const int IsFinishedFieldNumber = 4;

		// Token: 0x040057A9 RID: 22441
		private bool isFinished_;

		// Token: 0x040057AA RID: 22442
		public const int IsTakenFieldNumber = 5;

		// Token: 0x040057AB RID: 22443
		private bool isTaken_;

		// Token: 0x040057AC RID: 22444
		public const int IsConditionUnlockFieldNumber = 6;

		// Token: 0x040057AD RID: 22445
		private bool isConditionUnlock_;
	}
}
