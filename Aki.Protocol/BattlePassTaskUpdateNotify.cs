using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200017D RID: 381
	[NetMessage(EMessageId.BattlePassTaskUpdateNotify)]
	public sealed class BattlePassTaskUpdateNotify : IMessage<BattlePassTaskUpdateNotify>, IMessage, IEquatable<BattlePassTaskUpdateNotify>, IDeepCloneable<BattlePassTaskUpdateNotify>, IBufferMessage
	{
		// Token: 0x06002E86 RID: 11910 RVA: 0x00078130 File Offset: 0x00076330
		[NullableContext(1)]
		public static BattlePassTaskUpdateNotify Create()
		{
			return new BattlePassTaskUpdateNotify();
		}

		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x06002E87 RID: 11911 RVA: 0x00078137 File Offset: 0x00076337
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000716 RID: 1814
		// (get) Token: 0x06002E88 RID: 11912 RVA: 0x0007813A File Offset: 0x0007633A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassTaskUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x00078141 File Offset: 0x00076341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskUpdateNotify()
		{
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x00078154 File Offset: 0x00076354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskUpdateNotify(BattlePassTaskUpdateNotify other) : this()
		{
			this.tasks_ = other.tasks_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x0007817E File Offset: 0x0007637E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassTaskUpdateNotify Clone()
		{
			return new BattlePassTaskUpdateNotify(this);
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06002E8C RID: 11916 RVA: 0x00078186 File Offset: 0x00076386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PbBattlePassTask> Tasks
		{
			get
			{
				return this.tasks_;
			}
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x0007818E File Offset: 0x0007638E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassTaskUpdateNotify);
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x0007819C File Offset: 0x0007639C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassTaskUpdateNotify other)
		{
			return other != null && (other == this || (this.tasks_.Equals(other.tasks_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x000781D0 File Offset: 0x000763D0
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

		// Token: 0x06002E90 RID: 11920 RVA: 0x00078204 File Offset: 0x00076404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x00078211 File Offset: 0x00076411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x0007821A File Offset: 0x0007641A
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

		// Token: 0x06002E93 RID: 11923 RVA: 0x00078244 File Offset: 0x00076444
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

		// Token: 0x06002E94 RID: 11924 RVA: 0x0007827D File Offset: 0x0007647D
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

		// Token: 0x06002E95 RID: 11925 RVA: 0x000782AB File Offset: 0x000764AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x000782B4 File Offset: 0x000764B4
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.tasks_.AddEntriesFrom(ref input, BattlePassTaskUpdateNotify._repeated_tasks_codec);
				}
			}
		}

		// Token: 0x040028D1 RID: 10449
		private UnknownFieldSet _unknownFields;

		// Token: 0x040028D2 RID: 10450
		public const int TasksFieldNumber = 8;

		// Token: 0x040028D3 RID: 10451
		private static readonly FieldCodec<PbBattlePassTask> _repeated_tasks_codec = FieldCodec.ForMessage<PbBattlePassTask>(66U, PbBattlePassTask.Parser);

		// Token: 0x040028D4 RID: 10452
		private readonly RepeatedField<PbBattlePassTask> tasks_ = new RepeatedField<PbBattlePassTask>();
	}
}
