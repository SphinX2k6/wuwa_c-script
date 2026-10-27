using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005EF RID: 1519
	public sealed class FloroRanchWageSettleTask : IMessage<FloroRanchWageSettleTask>, IMessage, IEquatable<FloroRanchWageSettleTask>, IDeepCloneable<FloroRanchWageSettleTask>, IBufferMessage
	{
		// Token: 0x06008CB0 RID: 36016 RVA: 0x001555ED File Offset: 0x001537ED
		[NullableContext(1)]
		public static FloroRanchWageSettleTask Create()
		{
			return new FloroRanchWageSettleTask();
		}

		// Token: 0x17001BE1 RID: 7137
		// (get) Token: 0x06008CB1 RID: 36017 RVA: 0x001555F4 File Offset: 0x001537F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BE2 RID: 7138
		// (get) Token: 0x06008CB2 RID: 36018 RVA: 0x001555F7 File Offset: 0x001537F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchWageSettleTask.Descriptor;
			}
		}

		// Token: 0x06008CB3 RID: 36019 RVA: 0x001555FE File Offset: 0x001537FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWageSettleTask()
		{
		}

		// Token: 0x06008CB4 RID: 36020 RVA: 0x00155611 File Offset: 0x00153811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWageSettleTask(FloroRanchWageSettleTask other) : this()
		{
			this.settleActions_ = other.settleActions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008CB5 RID: 36021 RVA: 0x0015563B File Offset: 0x0015383B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWageSettleTask Clone()
		{
			return new FloroRanchWageSettleTask(this);
		}

		// Token: 0x17001BE3 RID: 7139
		// (get) Token: 0x06008CB6 RID: 36022 RVA: 0x00155643 File Offset: 0x00153843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FRUnitResourcesChangeAction> SettleActions
		{
			get
			{
				return this.settleActions_;
			}
		}

		// Token: 0x06008CB7 RID: 36023 RVA: 0x0015564B File Offset: 0x0015384B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchWageSettleTask);
		}

		// Token: 0x06008CB8 RID: 36024 RVA: 0x00155659 File Offset: 0x00153859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchWageSettleTask other)
		{
			return other != null && (other == this || (this.settleActions_.Equals(other.settleActions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008CB9 RID: 36025 RVA: 0x0015568C File Offset: 0x0015388C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.settleActions_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008CBA RID: 36026 RVA: 0x001556C0 File Offset: 0x001538C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008CBB RID: 36027 RVA: 0x001556CD File Offset: 0x001538CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008CBC RID: 36028 RVA: 0x001556D6 File Offset: 0x001538D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.settleActions_.WriteTo(ref output, FloroRanchWageSettleTask._repeated_settleActions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008CBD RID: 36029 RVA: 0x00155700 File Offset: 0x00153900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.settleActions_.CalculateSize(FloroRanchWageSettleTask._repeated_settleActions_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008CBE RID: 36030 RVA: 0x00155739 File Offset: 0x00153939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchWageSettleTask other)
		{
			if (other == null)
			{
				return;
			}
			this.settleActions_.Add(other.settleActions_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008CBF RID: 36031 RVA: 0x00155767 File Offset: 0x00153967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008CC0 RID: 36032 RVA: 0x00155770 File Offset: 0x00153970
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.settleActions_.AddEntriesFrom(ref input, FloroRanchWageSettleTask._repeated_settleActions_codec);
				}
			}
		}

		// Token: 0x040044D5 RID: 17621
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044D6 RID: 17622
		public const int SettleActionsFieldNumber = 1;

		// Token: 0x040044D7 RID: 17623
		private static readonly FieldCodec<FRUnitResourcesChangeAction> _repeated_settleActions_codec = FieldCodec.ForMessage<FRUnitResourcesChangeAction>(10U, FRUnitResourcesChangeAction.Parser);

		// Token: 0x040044D8 RID: 17624
		private readonly RepeatedField<FRUnitResourcesChangeAction> settleActions_ = new RepeatedField<FRUnitResourcesChangeAction>();
	}
}
