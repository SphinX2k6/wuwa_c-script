using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000663 RID: 1635
	public sealed class FRUnitOperateActionGroup : IMessage<FRUnitOperateActionGroup>, IMessage, IEquatable<FRUnitOperateActionGroup>, IDeepCloneable<FRUnitOperateActionGroup>, IBufferMessage
	{
		// Token: 0x06009609 RID: 38409 RVA: 0x00169F75 File Offset: 0x00168175
		[NullableContext(1)]
		public static FRUnitOperateActionGroup Create()
		{
			return new FRUnitOperateActionGroup();
		}

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x0600960A RID: 38410 RVA: 0x00169F7C File Offset: 0x0016817C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x0600960B RID: 38411 RVA: 0x00169F7F File Offset: 0x0016817F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitOperateActionGroup.Descriptor;
			}
		}

		// Token: 0x0600960C RID: 38412 RVA: 0x00169F86 File Offset: 0x00168186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateActionGroup()
		{
		}

		// Token: 0x0600960D RID: 38413 RVA: 0x00169F99 File Offset: 0x00168199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateActionGroup(FRUnitOperateActionGroup other) : this()
		{
			this.actions_ = other.actions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600960E RID: 38414 RVA: 0x00169FC3 File Offset: 0x001681C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitOperateActionGroup Clone()
		{
			return new FRUnitOperateActionGroup(this);
		}

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x0600960F RID: 38415 RVA: 0x00169FCB File Offset: 0x001681CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FRUnitOperateAction> Actions
		{
			get
			{
				return this.actions_;
			}
		}

		// Token: 0x06009610 RID: 38416 RVA: 0x00169FD3 File Offset: 0x001681D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitOperateActionGroup);
		}

		// Token: 0x06009611 RID: 38417 RVA: 0x00169FE1 File Offset: 0x001681E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitOperateActionGroup other)
		{
			return other != null && (other == this || (this.actions_.Equals(other.actions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009612 RID: 38418 RVA: 0x0016A014 File Offset: 0x00168214
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

		// Token: 0x06009613 RID: 38419 RVA: 0x0016A048 File Offset: 0x00168248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009614 RID: 38420 RVA: 0x0016A055 File Offset: 0x00168255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009615 RID: 38421 RVA: 0x0016A05E File Offset: 0x0016825E
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

		// Token: 0x06009616 RID: 38422 RVA: 0x0016A088 File Offset: 0x00168288
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

		// Token: 0x06009617 RID: 38423 RVA: 0x0016A0C1 File Offset: 0x001682C1
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

		// Token: 0x06009618 RID: 38424 RVA: 0x0016A0EF File Offset: 0x001682EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009619 RID: 38425 RVA: 0x0016A0F8 File Offset: 0x001682F8
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

		// Token: 0x0400478F RID: 18319
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004790 RID: 18320
		public const int ActionsFieldNumber = 1;

		// Token: 0x04004791 RID: 18321
		private static readonly FieldCodec<FRUnitOperateAction> _repeated_actions_codec = FieldCodec.ForMessage<FRUnitOperateAction>(10U, FRUnitOperateAction.Parser);

		// Token: 0x04004792 RID: 18322
		private readonly RepeatedField<FRUnitOperateAction> actions_ = new RepeatedField<FRUnitOperateAction>();
	}
}
