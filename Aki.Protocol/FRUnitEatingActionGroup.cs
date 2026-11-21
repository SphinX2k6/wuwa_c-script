using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200064D RID: 1613
	public sealed class FRUnitEatingActionGroup : IMessage<FRUnitEatingActionGroup>, IMessage, IEquatable<FRUnitEatingActionGroup>, IDeepCloneable<FRUnitEatingActionGroup>, IBufferMessage
	{
		// Token: 0x06009489 RID: 38025 RVA: 0x00166FAB File Offset: 0x001651AB
		[NullableContext(1)]
		public static FRUnitEatingActionGroup Create()
		{
			return new FRUnitEatingActionGroup();
		}

		// Token: 0x17001D89 RID: 7561
		// (get) Token: 0x0600948A RID: 38026 RVA: 0x00166FB2 File Offset: 0x001651B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D8A RID: 7562
		// (get) Token: 0x0600948B RID: 38027 RVA: 0x00166FB5 File Offset: 0x001651B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitEatingActionGroup.Descriptor;
			}
		}

		// Token: 0x0600948C RID: 38028 RVA: 0x00166FBC File Offset: 0x001651BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitEatingActionGroup()
		{
		}

		// Token: 0x0600948D RID: 38029 RVA: 0x00166FCF File Offset: 0x001651CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitEatingActionGroup(FRUnitEatingActionGroup other) : this()
		{
			this.actions_ = other.actions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600948E RID: 38030 RVA: 0x00166FF9 File Offset: 0x001651F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitEatingActionGroup Clone()
		{
			return new FRUnitEatingActionGroup(this);
		}

		// Token: 0x17001D8B RID: 7563
		// (get) Token: 0x0600948F RID: 38031 RVA: 0x00167001 File Offset: 0x00165201
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FRUnitEatingAction> Actions
		{
			get
			{
				return this.actions_;
			}
		}

		// Token: 0x06009490 RID: 38032 RVA: 0x00167009 File Offset: 0x00165209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitEatingActionGroup);
		}

		// Token: 0x06009491 RID: 38033 RVA: 0x00167017 File Offset: 0x00165217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitEatingActionGroup other)
		{
			return other != null && (other == this || (this.actions_.Equals(other.actions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009492 RID: 38034 RVA: 0x0016704C File Offset: 0x0016524C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.actions_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009493 RID: 38035 RVA: 0x00167080 File Offset: 0x00165280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009494 RID: 38036 RVA: 0x0016708D File Offset: 0x0016528D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009495 RID: 38037 RVA: 0x00167096 File Offset: 0x00165296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.actions_.WriteTo(ref output, FRUnitEatingActionGroup._repeated_actions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009496 RID: 38038 RVA: 0x001670C0 File Offset: 0x001652C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.actions_.CalculateSize(FRUnitEatingActionGroup._repeated_actions_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009497 RID: 38039 RVA: 0x001670F9 File Offset: 0x001652F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRUnitEatingActionGroup other)
		{
			if (other == null)
			{
				return;
			}
			this.actions_.Add(other.actions_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009498 RID: 38040 RVA: 0x00167127 File Offset: 0x00165327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009499 RID: 38041 RVA: 0x00167130 File Offset: 0x00165330
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
					this.actions_.AddEntriesFrom(ref input, FRUnitEatingActionGroup._repeated_actions_codec);
				}
			}
		}

		// Token: 0x0400477C RID: 18300
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400477D RID: 18301
		public const int ActionsFieldNumber = 1;

		// Token: 0x0400477E RID: 18302
		private static readonly FieldCodec<FRUnitEatingAction> _repeated_actions_codec = FieldCodec.ForMessage<FRUnitEatingAction>(10U, FRUnitEatingAction.Parser);

		// Token: 0x0400477F RID: 18303
		private readonly RepeatedField<FRUnitEatingAction> actions_ = new RepeatedField<FRUnitEatingAction>();
	}
}
