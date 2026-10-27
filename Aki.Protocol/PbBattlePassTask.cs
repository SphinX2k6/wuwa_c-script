using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C00 RID: 3072
	public sealed class PbBattlePassTask : IMessage<PbBattlePassTask>, IMessage, IEquatable<PbBattlePassTask>, IDeepCloneable<PbBattlePassTask>, IBufferMessage
	{
		// Token: 0x06010AD6 RID: 68310 RVA: 0x0027134E File Offset: 0x0026F54E
		[NullableContext(1)]
		public static PbBattlePassTask Create()
		{
			return new PbBattlePassTask();
		}

		// Token: 0x170036FF RID: 14079
		// (get) Token: 0x06010AD7 RID: 68311 RVA: 0x00271355 File Offset: 0x0026F555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbBattlePassTask> Parser
		{
			get
			{
				return PbBattlePassTask._parser;
			}
		}

		// Token: 0x17003700 RID: 14080
		// (get) Token: 0x06010AD8 RID: 68312 RVA: 0x0027135C File Offset: 0x0026F55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003701 RID: 14081
		// (get) Token: 0x06010AD9 RID: 68313 RVA: 0x0027135F File Offset: 0x0026F55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbBattlePassTask.Descriptor;
			}
		}

		// Token: 0x06010ADA RID: 68314 RVA: 0x00271366 File Offset: 0x0026F566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassTask()
		{
		}

		// Token: 0x06010ADB RID: 68315 RVA: 0x00271370 File Offset: 0x0026F570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassTask(PbBattlePassTask other) : this()
		{
			this.id_ = other.id_;
			this.current_ = other.current_;
			this.target_ = other.target_;
			this.isFinished_ = other.isFinished_;
			this.isTaken_ = other.isTaken_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010ADC RID: 68316 RVA: 0x002713D0 File Offset: 0x0026F5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassTask Clone()
		{
			return new PbBattlePassTask(this);
		}

		// Token: 0x17003702 RID: 14082
		// (get) Token: 0x06010ADD RID: 68317 RVA: 0x002713D8 File Offset: 0x0026F5D8
		// (set) Token: 0x06010ADE RID: 68318 RVA: 0x002713E0 File Offset: 0x0026F5E0
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

		// Token: 0x17003703 RID: 14083
		// (get) Token: 0x06010ADF RID: 68319 RVA: 0x002713E9 File Offset: 0x0026F5E9
		// (set) Token: 0x06010AE0 RID: 68320 RVA: 0x002713F1 File Offset: 0x0026F5F1
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

		// Token: 0x17003704 RID: 14084
		// (get) Token: 0x06010AE1 RID: 68321 RVA: 0x002713FA File Offset: 0x0026F5FA
		// (set) Token: 0x06010AE2 RID: 68322 RVA: 0x00271402 File Offset: 0x0026F602
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

		// Token: 0x17003705 RID: 14085
		// (get) Token: 0x06010AE3 RID: 68323 RVA: 0x0027140B File Offset: 0x0026F60B
		// (set) Token: 0x06010AE4 RID: 68324 RVA: 0x00271413 File Offset: 0x0026F613
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

		// Token: 0x17003706 RID: 14086
		// (get) Token: 0x06010AE5 RID: 68325 RVA: 0x0027141C File Offset: 0x0026F61C
		// (set) Token: 0x06010AE6 RID: 68326 RVA: 0x00271424 File Offset: 0x0026F624
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

		// Token: 0x06010AE7 RID: 68327 RVA: 0x0027142D File Offset: 0x0026F62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbBattlePassTask);
		}

		// Token: 0x06010AE8 RID: 68328 RVA: 0x0027143C File Offset: 0x0026F63C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbBattlePassTask other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.IsFinished == other.IsFinished && this.IsTaken == other.IsTaken && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010AE9 RID: 68329 RVA: 0x002714B8 File Offset: 0x0026F6B8
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

		// Token: 0x06010AEA RID: 68330 RVA: 0x0027155B File Offset: 0x0026F75B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010AEB RID: 68331 RVA: 0x00271568 File Offset: 0x0026F768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010AEC RID: 68332 RVA: 0x00271574 File Offset: 0x0026F774
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

		// Token: 0x06010AED RID: 68333 RVA: 0x00271620 File Offset: 0x0026F820
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

		// Token: 0x06010AEE RID: 68334 RVA: 0x002716A8 File Offset: 0x0026F8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbBattlePassTask other)
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

		// Token: 0x06010AEF RID: 68335 RVA: 0x00271734 File Offset: 0x0026F934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010AF0 RID: 68336 RVA: 0x00271740 File Offset: 0x0026F940
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

		// Token: 0x04006A05 RID: 27141
		private static readonly MessageParser<PbBattlePassTask> _parser = new MessageParser<PbBattlePassTask>(() => new PbBattlePassTask());

		// Token: 0x04006A06 RID: 27142
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A07 RID: 27143
		public const int IdFieldNumber = 1;

		// Token: 0x04006A08 RID: 27144
		private int id_;

		// Token: 0x04006A09 RID: 27145
		public const int CurrentFieldNumber = 2;

		// Token: 0x04006A0A RID: 27146
		private int current_;

		// Token: 0x04006A0B RID: 27147
		public const int TargetFieldNumber = 3;

		// Token: 0x04006A0C RID: 27148
		private int target_;

		// Token: 0x04006A0D RID: 27149
		public const int IsFinishedFieldNumber = 4;

		// Token: 0x04006A0E RID: 27150
		private bool isFinished_;

		// Token: 0x04006A0F RID: 27151
		public const int IsTakenFieldNumber = 5;

		// Token: 0x04006A10 RID: 27152
		private bool isTaken_;
	}
}
