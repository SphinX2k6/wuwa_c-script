using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA5 RID: 3237
	[NetMessage(EMessageId.PhantomBattleRepeatedTaskRewardRequest)]
	public sealed class PhantomBattleRepeatedTaskRewardRequest : IMessage<PhantomBattleRepeatedTaskRewardRequest>, IMessage, IEquatable<PhantomBattleRepeatedTaskRewardRequest>, IDeepCloneable<PhantomBattleRepeatedTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x060118AD RID: 71853 RVA: 0x00292035 File Offset: 0x00290235
		[NullableContext(1)]
		public static PhantomBattleRepeatedTaskRewardRequest Create()
		{
			return new PhantomBattleRepeatedTaskRewardRequest();
		}

		// Token: 0x17003A20 RID: 14880
		// (get) Token: 0x060118AE RID: 71854 RVA: 0x0029203C File Offset: 0x0029023C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A21 RID: 14881
		// (get) Token: 0x060118AF RID: 71855 RVA: 0x0029203F File Offset: 0x0029023F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRepeatedTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x060118B0 RID: 71856 RVA: 0x00292046 File Offset: 0x00290246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRepeatedTaskRewardRequest()
		{
		}

		// Token: 0x060118B1 RID: 71857 RVA: 0x00292059 File Offset: 0x00290259
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRepeatedTaskRewardRequest(PhantomBattleRepeatedTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060118B2 RID: 71858 RVA: 0x00292083 File Offset: 0x00290283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRepeatedTaskRewardRequest Clone()
		{
			return new PhantomBattleRepeatedTaskRewardRequest(this);
		}

		// Token: 0x17003A22 RID: 14882
		// (get) Token: 0x060118B3 RID: 71859 RVA: 0x0029208B File Offset: 0x0029028B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskId
		{
			get
			{
				return this.taskId_;
			}
		}

		// Token: 0x060118B4 RID: 71860 RVA: 0x00292093 File Offset: 0x00290293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRepeatedTaskRewardRequest);
		}

		// Token: 0x060118B5 RID: 71861 RVA: 0x002920A1 File Offset: 0x002902A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRepeatedTaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskId_.Equals(other.taskId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060118B6 RID: 71862 RVA: 0x002920D4 File Offset: 0x002902D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060118B7 RID: 71863 RVA: 0x00292108 File Offset: 0x00290308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060118B8 RID: 71864 RVA: 0x00292115 File Offset: 0x00290315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060118B9 RID: 71865 RVA: 0x0029211E File Offset: 0x0029031E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskId_.WriteTo(ref output, PhantomBattleRepeatedTaskRewardRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060118BA RID: 71866 RVA: 0x00292148 File Offset: 0x00290348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskId_.CalculateSize(PhantomBattleRepeatedTaskRewardRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060118BB RID: 71867 RVA: 0x00292181 File Offset: 0x00290381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRepeatedTaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskId_.Add(other.taskId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060118BC RID: 71868 RVA: 0x002921AF File Offset: 0x002903AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060118BD RID: 71869 RVA: 0x002921B8 File Offset: 0x002903B8
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
				if (num != 32U && num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskId_.AddEntriesFrom(ref input, PhantomBattleRepeatedTaskRewardRequest._repeated_taskId_codec);
				}
			}
		}

		// Token: 0x04006E9F RID: 28319
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EA0 RID: 28320
		public const int TaskIdFieldNumber = 4;

		// Token: 0x04006EA1 RID: 28321
		private static readonly FieldCodec<int> _repeated_taskId_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04006EA2 RID: 28322
		private readonly RepeatedField<int> taskId_ = new RepeatedField<int>();
	}
}
