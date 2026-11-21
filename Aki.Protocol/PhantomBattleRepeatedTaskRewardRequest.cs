using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C95 RID: 3221
	[NetMessage(EMessageId.PhantomBattleRepeatedTaskRewardRequest)]
	public sealed class PhantomBattleRepeatedTaskRewardRequest : IMessage<PhantomBattleRepeatedTaskRewardRequest>, IMessage, IEquatable<PhantomBattleRepeatedTaskRewardRequest>, IDeepCloneable<PhantomBattleRepeatedTaskRewardRequest>, IBufferMessage
	{
		// Token: 0x060117AD RID: 71597 RVA: 0x002902C9 File Offset: 0x0028E4C9
		[NullableContext(1)]
		public static PhantomBattleRepeatedTaskRewardRequest Create()
		{
			return new PhantomBattleRepeatedTaskRewardRequest();
		}

		// Token: 0x170039E9 RID: 14825
		// (get) Token: 0x060117AE RID: 71598 RVA: 0x002902D0 File Offset: 0x0028E4D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039EA RID: 14826
		// (get) Token: 0x060117AF RID: 71599 RVA: 0x002902D3 File Offset: 0x0028E4D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRepeatedTaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x060117B0 RID: 71600 RVA: 0x002902DA File Offset: 0x0028E4DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRepeatedTaskRewardRequest()
		{
		}

		// Token: 0x060117B1 RID: 71601 RVA: 0x002902ED File Offset: 0x0028E4ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRepeatedTaskRewardRequest(PhantomBattleRepeatedTaskRewardRequest other) : this()
		{
			this.taskId_ = other.taskId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060117B2 RID: 71602 RVA: 0x00290317 File Offset: 0x0028E517
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRepeatedTaskRewardRequest Clone()
		{
			return new PhantomBattleRepeatedTaskRewardRequest(this);
		}

		// Token: 0x170039EB RID: 14827
		// (get) Token: 0x060117B3 RID: 71603 RVA: 0x0029031F File Offset: 0x0028E51F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskId
		{
			get
			{
				return this.taskId_;
			}
		}

		// Token: 0x060117B4 RID: 71604 RVA: 0x00290327 File Offset: 0x0028E527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRepeatedTaskRewardRequest);
		}

		// Token: 0x060117B5 RID: 71605 RVA: 0x00290335 File Offset: 0x0028E535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRepeatedTaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskId_.Equals(other.taskId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060117B6 RID: 71606 RVA: 0x00290368 File Offset: 0x0028E568
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

		// Token: 0x060117B7 RID: 71607 RVA: 0x0029039C File Offset: 0x0028E59C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060117B8 RID: 71608 RVA: 0x002903A9 File Offset: 0x0028E5A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060117B9 RID: 71609 RVA: 0x002903B2 File Offset: 0x0028E5B2
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

		// Token: 0x060117BA RID: 71610 RVA: 0x002903DC File Offset: 0x0028E5DC
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

		// Token: 0x060117BB RID: 71611 RVA: 0x00290415 File Offset: 0x0028E615
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

		// Token: 0x060117BC RID: 71612 RVA: 0x00290443 File Offset: 0x0028E643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060117BD RID: 71613 RVA: 0x0029044C File Offset: 0x0028E64C
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskId_.AddEntriesFrom(ref input, PhantomBattleRepeatedTaskRewardRequest._repeated_taskId_codec);
				}
			}
		}

		// Token: 0x04006EB3 RID: 28339
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EB4 RID: 28340
		public const int TaskIdFieldNumber = 10;

		// Token: 0x04006EB5 RID: 28341
		private static readonly FieldCodec<int> _repeated_taskId_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04006EB6 RID: 28342
		private readonly RepeatedField<int> taskId_ = new RepeatedField<int>();
	}
}
