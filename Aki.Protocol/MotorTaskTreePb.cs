using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A98 RID: 2712
	public sealed class MotorTaskTreePb : IMessage<MotorTaskTreePb>, IMessage, IEquatable<MotorTaskTreePb>, IDeepCloneable<MotorTaskTreePb>, IBufferMessage
	{
		// Token: 0x0600EC75 RID: 60533 RVA: 0x00228BBA File Offset: 0x00226DBA
		[NullableContext(1)]
		public static MotorTaskTreePb Create()
		{
			return new MotorTaskTreePb();
		}

		// Token: 0x17003005 RID: 12293
		// (get) Token: 0x0600EC76 RID: 60534 RVA: 0x00228BC1 File Offset: 0x00226DC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MotorTaskTreePb> Parser
		{
			get
			{
				return MotorTaskTreePb._parser;
			}
		}

		// Token: 0x17003006 RID: 12294
		// (get) Token: 0x0600EC77 RID: 60535 RVA: 0x00228BC8 File Offset: 0x00226DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003007 RID: 12295
		// (get) Token: 0x0600EC78 RID: 60536 RVA: 0x00228BCB File Offset: 0x00226DCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskTreePb.Descriptor;
			}
		}

		// Token: 0x0600EC79 RID: 60537 RVA: 0x00228BD2 File Offset: 0x00226DD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskTreePb()
		{
		}

		// Token: 0x0600EC7A RID: 60538 RVA: 0x00228BE8 File Offset: 0x00226DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskTreePb(MotorTaskTreePb other) : this()
		{
			this.treeId_ = other.treeId_;
			this.tasks_ = other.tasks_.Clone();
			this.tpRewarded_ = other.tpRewarded_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EC7B RID: 60539 RVA: 0x00228C35 File Offset: 0x00226E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskTreePb Clone()
		{
			return new MotorTaskTreePb(this);
		}

		// Token: 0x17003008 RID: 12296
		// (get) Token: 0x0600EC7C RID: 60540 RVA: 0x00228C3D File Offset: 0x00226E3D
		// (set) Token: 0x0600EC7D RID: 60541 RVA: 0x00228C45 File Offset: 0x00226E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeId
		{
			get
			{
				return this.treeId_;
			}
			set
			{
				this.treeId_ = value;
			}
		}

		// Token: 0x17003009 RID: 12297
		// (get) Token: 0x0600EC7E RID: 60542 RVA: 0x00228C4E File Offset: 0x00226E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorTaskPb> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x1700300A RID: 12298
		// (get) Token: 0x0600EC7F RID: 60543 RVA: 0x00228C56 File Offset: 0x00226E56
		// (set) Token: 0x0600EC80 RID: 60544 RVA: 0x00228C5E File Offset: 0x00226E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TpRewarded
		{
			get
			{
				return this.tpRewarded_;
			}
			set
			{
				this.tpRewarded_ = value;
			}
		}

		// Token: 0x0600EC81 RID: 60545 RVA: 0x00228C67 File Offset: 0x00226E67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskTreePb);
		}

		// Token: 0x0600EC82 RID: 60546 RVA: 0x00228C78 File Offset: 0x00226E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskTreePb other)
		{
			return other != null && (other == this || (this.TreeId == other.TreeId && this.tasks_.Equals(other.tasks_) && this.TpRewarded == other.TpRewarded && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EC83 RID: 60547 RVA: 0x00228CD8 File Offset: 0x00226ED8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeId != 0)
			{
				num ^= this.TreeId.GetHashCode();
			}
			num ^= this.tasks_.GetHashCode();
			if (this.TpRewarded != 0)
			{
				num ^= this.TpRewarded.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EC84 RID: 60548 RVA: 0x00228D3E File Offset: 0x00226F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EC85 RID: 60549 RVA: 0x00228D4B File Offset: 0x00226F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EC86 RID: 60550 RVA: 0x00228D54 File Offset: 0x00226F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TreeId);
			}
			this.tasks_.WriteTo(ref output, MotorTaskTreePb._repeated_tasks_codec);
			if (this.TpRewarded != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.TpRewarded);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EC87 RID: 60551 RVA: 0x00228DC0 File Offset: 0x00226FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeId);
			}
			num += this.tasks_.CalculateSize(MotorTaskTreePb._repeated_tasks_codec);
			if (this.TpRewarded != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TpRewarded);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EC88 RID: 60552 RVA: 0x00228E2C File Offset: 0x0022702C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTaskTreePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeId != 0)
			{
				this.TreeId = other.TreeId;
			}
			this.tasks_.Add(other.tasks_);
			if (other.TpRewarded != 0)
			{
				this.TpRewarded = other.TpRewarded;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EC89 RID: 60553 RVA: 0x00228E8D File Offset: 0x0022708D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EC8A RID: 60554 RVA: 0x00228E98 File Offset: 0x00227098
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TpRewarded = input.ReadInt32();
						}
					}
					else
					{
						this.tasks_.AddEntriesFrom(ref input, MotorTaskTreePb._repeated_tasks_codec);
					}
				}
				else
				{
					this.TreeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400603D RID: 24637
		private static readonly MessageParser<MotorTaskTreePb> _parser = new MessageParser<MotorTaskTreePb>(() => new MotorTaskTreePb());

		// Token: 0x0400603E RID: 24638
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400603F RID: 24639
		public const int TreeIdFieldNumber = 1;

		// Token: 0x04006040 RID: 24640
		private int treeId_;

		// Token: 0x04006041 RID: 24641
		public const int TasksFieldNumber = 2;

		// Token: 0x04006042 RID: 24642
		private static readonly FieldCodec<MotorTaskPb> _repeated_tasks_codec = FieldCodec.ForMessage<MotorTaskPb>(18U, MotorTaskPb.Parser);

		// Token: 0x04006043 RID: 24643
		private readonly RepeatedField<MotorTaskPb> tasks_ = new RepeatedField<MotorTaskPb>();

		// Token: 0x04006044 RID: 24644
		public const int TpRewardedFieldNumber = 3;

		// Token: 0x04006045 RID: 24645
		private int tpRewarded_;
	}
}
