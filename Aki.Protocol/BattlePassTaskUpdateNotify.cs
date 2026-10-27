using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200017A RID: 378
	[NetMessage(EMessageId.BattlePassTaskUpdateNotify)]
	public sealed class BattlePassTaskUpdateNotify : IMessage<BattlePassTaskUpdateNotify>, IMessage, IEquatable<BattlePassTaskUpdateNotify>, IDeepCloneable<BattlePassTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x06002E0F RID: 11791 RVA: 0x00076D04 File Offset: 0x00074F04
		[NullableContext(1)]
		public static BattlePassTaskUpdateNotify Create()
		{
			return new BattlePassTaskUpdateNotify();
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06002E10 RID: 11792 RVA: 0x00076D0B File Offset: 0x00074F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06002E11 RID: 11793 RVA: 0x00076D0E File Offset: 0x00074F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06002E12 RID: 11794 RVA: 0x00076D15 File Offset: 0x00074F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskUpdateNotify()
		{
		}

		// Token: 0x06002E13 RID: 11795 RVA: 0x00076D28 File Offset: 0x00074F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskUpdateNotify(BattlePassTaskUpdateNotify other) : this()
		{
			this.tasks_ = other.tasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E14 RID: 11796 RVA: 0x00076D52 File Offset: 0x00074F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskUpdateNotify Clone()
		{
			return new BattlePassTaskUpdateNotify(this);
		}

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06002E15 RID: 11797 RVA: 0x00076D5A File Offset: 0x00074F5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbBattlePassTask> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x00076D62 File Offset: 0x00074F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTaskUpdateNotify);
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x00076D70 File Offset: 0x00074F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.tasks_.Equals(other.tasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x00076DA4 File Offset: 0x00074FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.tasks_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x00076DD8 File Offset: 0x00074FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x00076DE5 File Offset: 0x00074FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x00076DEE File Offset: 0x00074FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.tasks_.WriteTo(ref output, BattlePassTaskUpdateNotify._repeated_tasks_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x00076E18 File Offset: 0x00075018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.tasks_.CalculateSize(BattlePassTaskUpdateNotify._repeated_tasks_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x00076E51 File Offset: 0x00075051
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassTaskUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.tasks_.Add(other.tasks_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x00076E7F File Offset: 0x0007507F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x00076E88 File Offset: 0x00075088
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.tasks_.AddEntriesFrom(ref input, BattlePassTaskUpdateNotify._repeated_tasks_codec);
				}
			}
		}

		// Token: 0x0400285D RID: 10333
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400285E RID: 10334
		public const int TasksFieldNumber = 10;

		// Token: 0x0400285F RID: 10335
		private static readonly FieldCodec<PbBattlePassTask> _repeated_tasks_codec = FieldCodec.ForMessage<PbBattlePassTask>(82U, PbBattlePassTask.Parser);

		// Token: 0x04002860 RID: 10336
		private readonly RepeatedField<PbBattlePassTask> tasks_ = new RepeatedField<PbBattlePassTask>();
	}
}
