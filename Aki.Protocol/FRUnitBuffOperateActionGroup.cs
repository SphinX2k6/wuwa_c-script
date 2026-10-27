using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200065F RID: 1631
	public sealed class FRUnitBuffOperateActionGroup : IMessage<FRUnitBuffOperateActionGroup>, IMessage, IEquatable<FRUnitBuffOperateActionGroup>, IDeepCloneable<FRUnitBuffOperateActionGroup>, IBufferMessage
	{
		// Token: 0x060095B6 RID: 38326 RVA: 0x00169441 File Offset: 0x00167641
		[NullableContext(1)]
		public static FRUnitBuffOperateActionGroup Create()
		{
			return new FRUnitBuffOperateActionGroup();
		}

		// Token: 0x17001DCA RID: 7626
		// (get) Token: 0x060095B7 RID: 38327 RVA: 0x00169448 File Offset: 0x00167648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DCB RID: 7627
		// (get) Token: 0x060095B8 RID: 38328 RVA: 0x0016944B File Offset: 0x0016764B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitBuffOperateActionGroup.Descriptor;
			}
		}

		// Token: 0x060095B9 RID: 38329 RVA: 0x00169452 File Offset: 0x00167652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitBuffOperateActionGroup()
		{
		}

		// Token: 0x060095BA RID: 38330 RVA: 0x00169465 File Offset: 0x00167665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitBuffOperateActionGroup(FRUnitBuffOperateActionGroup other) : this()
		{
			this.actions_ = other.actions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095BB RID: 38331 RVA: 0x0016948F File Offset: 0x0016768F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitBuffOperateActionGroup Clone()
		{
			return new FRUnitBuffOperateActionGroup(this);
		}

		// Token: 0x17001DCC RID: 7628
		// (get) Token: 0x060095BC RID: 38332 RVA: 0x00169497 File Offset: 0x00167697
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FRUnitOperateBuffAction> Actions
		{
			get
			{
				return this.actions_;
			}
		}

		// Token: 0x060095BD RID: 38333 RVA: 0x0016949F File Offset: 0x0016769F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitBuffOperateActionGroup);
		}

		// Token: 0x060095BE RID: 38334 RVA: 0x001694AD File Offset: 0x001676AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitBuffOperateActionGroup other)
		{
			return other != null && (other == this || (this.actions_.Equals(other.actions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060095BF RID: 38335 RVA: 0x001694E0 File Offset: 0x001676E0
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

		// Token: 0x060095C0 RID: 38336 RVA: 0x00169514 File Offset: 0x00167714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060095C1 RID: 38337 RVA: 0x00169521 File Offset: 0x00167721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095C2 RID: 38338 RVA: 0x0016952A File Offset: 0x0016772A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.actions_.WriteTo(ref output, FRUnitBuffOperateActionGroup._repeated_actions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060095C3 RID: 38339 RVA: 0x00169554 File Offset: 0x00167754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.actions_.CalculateSize(FRUnitBuffOperateActionGroup._repeated_actions_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060095C4 RID: 38340 RVA: 0x0016958D File Offset: 0x0016778D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRUnitBuffOperateActionGroup other)
		{
			if (other == null)
			{
				return;
			}
			this.actions_.Add(other.actions_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060095C5 RID: 38341 RVA: 0x001695BB File Offset: 0x001677BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095C6 RID: 38342 RVA: 0x001695C4 File Offset: 0x001677C4
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
					this.actions_.AddEntriesFrom(ref input, FRUnitBuffOperateActionGroup._repeated_actions_codec);
				}
			}
		}

		// Token: 0x04004776 RID: 18294
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004777 RID: 18295
		public const int ActionsFieldNumber = 1;

		// Token: 0x04004778 RID: 18296
		private static readonly FieldCodec<FRUnitOperateBuffAction> _repeated_actions_codec = FieldCodec.ForMessage<FRUnitOperateBuffAction>(10U, FRUnitOperateBuffAction.Parser);

		// Token: 0x04004779 RID: 18297
		private readonly RepeatedField<FRUnitOperateBuffAction> actions_ = new RepeatedField<FRUnitOperateBuffAction>();
	}
}
