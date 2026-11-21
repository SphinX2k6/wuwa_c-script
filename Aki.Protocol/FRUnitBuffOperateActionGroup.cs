using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200064B RID: 1611
	public sealed class FRUnitBuffOperateActionGroup : IMessage<FRUnitBuffOperateActionGroup>, IMessage, IEquatable<FRUnitBuffOperateActionGroup>, IDeepCloneable<FRUnitBuffOperateActionGroup>, IBufferMessage
	{
		// Token: 0x06009460 RID: 37984 RVA: 0x00166A15 File Offset: 0x00164C15
		[NullableContext(1)]
		public static FRUnitBuffOperateActionGroup Create()
		{
			return new FRUnitBuffOperateActionGroup();
		}

		// Token: 0x17001D80 RID: 7552
		// (get) Token: 0x06009461 RID: 37985 RVA: 0x00166A1C File Offset: 0x00164C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D81 RID: 7553
		// (get) Token: 0x06009462 RID: 37986 RVA: 0x00166A1F File Offset: 0x00164C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitBuffOperateActionGroup.Descriptor;
			}
		}

		// Token: 0x06009463 RID: 37987 RVA: 0x00166A26 File Offset: 0x00164C26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitBuffOperateActionGroup()
		{
		}

		// Token: 0x06009464 RID: 37988 RVA: 0x00166A39 File Offset: 0x00164C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitBuffOperateActionGroup(FRUnitBuffOperateActionGroup other) : this()
		{
			this.actions_ = other.actions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009465 RID: 37989 RVA: 0x00166A63 File Offset: 0x00164C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitBuffOperateActionGroup Clone()
		{
			return new FRUnitBuffOperateActionGroup(this);
		}

		// Token: 0x17001D82 RID: 7554
		// (get) Token: 0x06009466 RID: 37990 RVA: 0x00166A6B File Offset: 0x00164C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FRUnitOperateBuffAction> Actions
		{
			get
			{
				return this.actions_;
			}
		}

		// Token: 0x06009467 RID: 37991 RVA: 0x00166A73 File Offset: 0x00164C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitBuffOperateActionGroup);
		}

		// Token: 0x06009468 RID: 37992 RVA: 0x00166A81 File Offset: 0x00164C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitBuffOperateActionGroup other)
		{
			return other != null && (other == this || (this.actions_.Equals(other.actions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009469 RID: 37993 RVA: 0x00166AB4 File Offset: 0x00164CB4
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

		// Token: 0x0600946A RID: 37994 RVA: 0x00166AE8 File Offset: 0x00164CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600946B RID: 37995 RVA: 0x00166AF5 File Offset: 0x00164CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600946C RID: 37996 RVA: 0x00166AFE File Offset: 0x00164CFE
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

		// Token: 0x0600946D RID: 37997 RVA: 0x00166B28 File Offset: 0x00164D28
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

		// Token: 0x0600946E RID: 37998 RVA: 0x00166B61 File Offset: 0x00164D61
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

		// Token: 0x0600946F RID: 37999 RVA: 0x00166B8F File Offset: 0x00164D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009470 RID: 38000 RVA: 0x00166B98 File Offset: 0x00164D98
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

		// Token: 0x0400476F RID: 18287
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004770 RID: 18288
		public const int ActionsFieldNumber = 1;

		// Token: 0x04004771 RID: 18289
		private static readonly FieldCodec<FRUnitOperateBuffAction> _repeated_actions_codec = FieldCodec.ForMessage<FRUnitOperateBuffAction>(10U, FRUnitOperateBuffAction.Parser);

		// Token: 0x04004772 RID: 18290
		private readonly RepeatedField<FRUnitOperateBuffAction> actions_ = new RepeatedField<FRUnitOperateBuffAction>();
	}
}
