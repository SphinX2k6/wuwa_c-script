using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BF0 RID: 3056
	public sealed class PbBattlePassTask : IMessage<PbBattlePassTask>, IMessage, IEquatable<PbBattlePassTask>, IDeepCloneable<PbBattlePassTask>, IBufferMessage
	{
		// Token: 0x060109D6 RID: 68054 RVA: 0x0026F5E6 File Offset: 0x0026D7E6
		[NullableContext(1)]
		public static PbBattlePassTask Create()
		{
			return new PbBattlePassTask();
		}

		// Token: 0x170036C8 RID: 14024
		// (get) Token: 0x060109D7 RID: 68055 RVA: 0x0026F5ED File Offset: 0x0026D7ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PbBattlePassTask> Parser
		{
			get
			{
				return PbBattlePassTask._parser;
			}
		}

		// Token: 0x170036C9 RID: 14025
		// (get) Token: 0x060109D8 RID: 68056 RVA: 0x0026F5F4 File Offset: 0x0026D7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170036CA RID: 14026
		// (get) Token: 0x060109D9 RID: 68057 RVA: 0x0026F5F7 File Offset: 0x0026D7F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbBattlePassTask.Descriptor;
			}
		}

		// Token: 0x060109DA RID: 68058 RVA: 0x0026F5FE File Offset: 0x0026D7FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassTask()
		{
		}

		// Token: 0x060109DB RID: 68059 RVA: 0x0026F608 File Offset: 0x0026D808
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

		// Token: 0x060109DC RID: 68060 RVA: 0x0026F668 File Offset: 0x0026D868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbBattlePassTask Clone()
		{
			return new PbBattlePassTask(this);
		}

		// Token: 0x170036CB RID: 14027
		// (get) Token: 0x060109DD RID: 68061 RVA: 0x0026F670 File Offset: 0x0026D870
		// (set) Token: 0x060109DE RID: 68062 RVA: 0x0026F678 File Offset: 0x0026D878
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

		// Token: 0x170036CC RID: 14028
		// (get) Token: 0x060109DF RID: 68063 RVA: 0x0026F681 File Offset: 0x0026D881
		// (set) Token: 0x060109E0 RID: 68064 RVA: 0x0026F689 File Offset: 0x0026D889
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

		// Token: 0x170036CD RID: 14029
		// (get) Token: 0x060109E1 RID: 68065 RVA: 0x0026F692 File Offset: 0x0026D892
		// (set) Token: 0x060109E2 RID: 68066 RVA: 0x0026F69A File Offset: 0x0026D89A
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

		// Token: 0x170036CE RID: 14030
		// (get) Token: 0x060109E3 RID: 68067 RVA: 0x0026F6A3 File Offset: 0x0026D8A3
		// (set) Token: 0x060109E4 RID: 68068 RVA: 0x0026F6AB File Offset: 0x0026D8AB
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

		// Token: 0x170036CF RID: 14031
		// (get) Token: 0x060109E5 RID: 68069 RVA: 0x0026F6B4 File Offset: 0x0026D8B4
		// (set) Token: 0x060109E6 RID: 68070 RVA: 0x0026F6BC File Offset: 0x0026D8BC
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

		// Token: 0x060109E7 RID: 68071 RVA: 0x0026F6C5 File Offset: 0x0026D8C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbBattlePassTask);
		}

		// Token: 0x060109E8 RID: 68072 RVA: 0x0026F6D4 File Offset: 0x0026D8D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbBattlePassTask other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && this.IsFinished == other.IsFinished && this.IsTaken == other.IsTaken && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060109E9 RID: 68073 RVA: 0x0026F750 File Offset: 0x0026D950
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

		// Token: 0x060109EA RID: 68074 RVA: 0x0026F7F3 File Offset: 0x0026D9F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060109EB RID: 68075 RVA: 0x0026F800 File Offset: 0x0026DA00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060109EC RID: 68076 RVA: 0x0026F80C File Offset: 0x0026DA0C
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

		// Token: 0x060109ED RID: 68077 RVA: 0x0026F8B8 File Offset: 0x0026DAB8
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

		// Token: 0x060109EE RID: 68078 RVA: 0x0026F940 File Offset: 0x0026DB40
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

		// Token: 0x060109EF RID: 68079 RVA: 0x0026F9CC File Offset: 0x0026DBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060109F0 RID: 68080 RVA: 0x0026F9D8 File Offset: 0x0026DBD8
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

		// Token: 0x04006A19 RID: 27161
		private static readonly MessageParser<PbBattlePassTask> _parser = new MessageParser<PbBattlePassTask>(() => new PbBattlePassTask());

		// Token: 0x04006A1A RID: 27162
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A1B RID: 27163
		public const int IdFieldNumber = 1;

		// Token: 0x04006A1C RID: 27164
		private int id_;

		// Token: 0x04006A1D RID: 27165
		public const int CurrentFieldNumber = 2;

		// Token: 0x04006A1E RID: 27166
		private int current_;

		// Token: 0x04006A1F RID: 27167
		public const int TargetFieldNumber = 3;

		// Token: 0x04006A20 RID: 27168
		private int target_;

		// Token: 0x04006A21 RID: 27169
		public const int IsFinishedFieldNumber = 4;

		// Token: 0x04006A22 RID: 27170
		private bool isFinished_;

		// Token: 0x04006A23 RID: 27171
		public const int IsTakenFieldNumber = 5;

		// Token: 0x04006A24 RID: 27172
		private bool isTaken_;
	}
}
