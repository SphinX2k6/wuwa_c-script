using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200064F RID: 1615
	public sealed class FRUnitOperateActionGroup : IMessage<FRUnitOperateActionGroup>, IMessage, IEquatable<FRUnitOperateActionGroup>, IDeepCloneable<FRUnitOperateActionGroup>, IBufferMessage
	{
		// Token: 0x060094B3 RID: 38067 RVA: 0x00167549 File Offset: 0x00165749
		[NullableContext(1)]
		public static FRUnitOperateActionGroup Create()
		{
			return new FRUnitOperateActionGroup();
		}

		// Token: 0x17001D92 RID: 7570
		// (get) Token: 0x060094B4 RID: 38068 RVA: 0x00167550 File Offset: 0x00165750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D93 RID: 7571
		// (get) Token: 0x060094B5 RID: 38069 RVA: 0x00167553 File Offset: 0x00165753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitOperateActionGroup.Descriptor;
			}
		}

		// Token: 0x060094B6 RID: 38070 RVA: 0x0016755A File Offset: 0x0016575A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateActionGroup()
		{
		}

		// Token: 0x060094B7 RID: 38071 RVA: 0x0016756D File Offset: 0x0016576D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateActionGroup(FRUnitOperateActionGroup other) : this()
		{
			this.actions_ = other.actions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060094B8 RID: 38072 RVA: 0x00167597 File Offset: 0x00165797
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateActionGroup Clone()
		{
			return new FRUnitOperateActionGroup(this);
		}

		// Token: 0x17001D94 RID: 7572
		// (get) Token: 0x060094B9 RID: 38073 RVA: 0x0016759F File Offset: 0x0016579F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FRUnitOperateAction> Actions
		{
			get
			{
				return this.actions_;
			}
		}

		// Token: 0x060094BA RID: 38074 RVA: 0x001675A7 File Offset: 0x001657A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitOperateActionGroup);
		}

		// Token: 0x060094BB RID: 38075 RVA: 0x001675B5 File Offset: 0x001657B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitOperateActionGroup other)
		{
			return other != null && (other == this || (this.actions_.Equals(other.actions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060094BC RID: 38076 RVA: 0x001675E8 File Offset: 0x001657E8
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

		// Token: 0x060094BD RID: 38077 RVA: 0x0016761C File Offset: 0x0016581C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060094BE RID: 38078 RVA: 0x00167629 File Offset: 0x00165829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060094BF RID: 38079 RVA: 0x00167632 File Offset: 0x00165832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.actions_.WriteTo(ref output, FRUnitOperateActionGroup._repeated_actions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060094C0 RID: 38080 RVA: 0x0016765C File Offset: 0x0016585C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.actions_.CalculateSize(FRUnitOperateActionGroup._repeated_actions_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060094C1 RID: 38081 RVA: 0x00167695 File Offset: 0x00165895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRUnitOperateActionGroup other)
		{
			if (other == null)
			{
				return;
			}
			this.actions_.Add(other.actions_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060094C2 RID: 38082 RVA: 0x001676C3 File Offset: 0x001658C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060094C3 RID: 38083 RVA: 0x001676CC File Offset: 0x001658CC
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
					this.actions_.AddEntriesFrom(ref input, FRUnitOperateActionGroup._repeated_actions_codec);
				}
			}
		}

		// Token: 0x04004788 RID: 18312
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004789 RID: 18313
		public const int ActionsFieldNumber = 1;

		// Token: 0x0400478A RID: 18314
		private static readonly FieldCodec<FRUnitOperateAction> _repeated_actions_codec = FieldCodec.ForMessage<FRUnitOperateAction>(10U, FRUnitOperateAction.Parser);

		// Token: 0x0400478B RID: 18315
		private readonly RepeatedField<FRUnitOperateAction> actions_ = new RepeatedField<FRUnitOperateAction>();
	}
}
