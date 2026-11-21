using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005DA RID: 1498
	public sealed class FloroRanchWageSettleTask : IMessage<FloroRanchWageSettleTask>, IMessage, IEquatable<FloroRanchWageSettleTask>, IDeepCloneable<FloroRanchWageSettleTask>, IBufferMessage
	{
		// Token: 0x06008B48 RID: 35656 RVA: 0x001529E2 File Offset: 0x00150BE2
		[NullableContext(1)]
		public static FloroRanchWageSettleTask Create()
		{
			return new FloroRanchWageSettleTask();
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x06008B49 RID: 35657 RVA: 0x001529E9 File Offset: 0x00150BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x06008B4A RID: 35658 RVA: 0x001529EC File Offset: 0x00150BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchWageSettleTask.Descriptor;
			}
		}

		// Token: 0x06008B4B RID: 35659 RVA: 0x001529F3 File Offset: 0x00150BF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWageSettleTask()
		{
		}

		// Token: 0x06008B4C RID: 35660 RVA: 0x00152A06 File Offset: 0x00150C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWageSettleTask(FloroRanchWageSettleTask other) : this()
		{
			this.settleActions_ = other.settleActions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008B4D RID: 35661 RVA: 0x00152A30 File Offset: 0x00150C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchWageSettleTask Clone()
		{
			return new FloroRanchWageSettleTask(this);
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x06008B4E RID: 35662 RVA: 0x00152A38 File Offset: 0x00150C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FRUnitResourcesChangeAction> SettleActions
		{
			get
			{
				return this.settleActions_;
			}
		}

		// Token: 0x06008B4F RID: 35663 RVA: 0x00152A40 File Offset: 0x00150C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchWageSettleTask);
		}

		// Token: 0x06008B50 RID: 35664 RVA: 0x00152A4E File Offset: 0x00150C4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchWageSettleTask other)
		{
			return other != null && (other == this || (this.settleActions_.Equals(other.settleActions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008B51 RID: 35665 RVA: 0x00152A84 File Offset: 0x00150C84
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

		// Token: 0x06008B52 RID: 35666 RVA: 0x00152AB8 File Offset: 0x00150CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008B53 RID: 35667 RVA: 0x00152AC5 File Offset: 0x00150CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008B54 RID: 35668 RVA: 0x00152ACE File Offset: 0x00150CCE
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

		// Token: 0x06008B55 RID: 35669 RVA: 0x00152AF8 File Offset: 0x00150CF8
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

		// Token: 0x06008B56 RID: 35670 RVA: 0x00152B31 File Offset: 0x00150D31
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

		// Token: 0x06008B57 RID: 35671 RVA: 0x00152B5F File Offset: 0x00150D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008B58 RID: 35672 RVA: 0x00152B68 File Offset: 0x00150D68
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

		// Token: 0x040044CB RID: 17611
		private UnknownFieldSet _unknownFields;

		// Token: 0x040044CC RID: 17612
		public const int SettleActionsFieldNumber = 1;

		// Token: 0x040044CD RID: 17613
		private static readonly FieldCodec<FRUnitResourcesChangeAction> _repeated_settleActions_codec = FieldCodec.ForMessage<FRUnitResourcesChangeAction>(10U, FRUnitResourcesChangeAction.Parser);

		// Token: 0x040044CE RID: 17614
		private readonly RepeatedField<FRUnitResourcesChangeAction> settleActions_ = new RepeatedField<FRUnitResourcesChangeAction>();
	}
}
