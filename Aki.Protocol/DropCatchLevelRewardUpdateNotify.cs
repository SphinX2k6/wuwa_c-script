using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200040E RID: 1038
	[NetMessage(EMessageId.DropCatchLevelRewardUpdateNotify)]
	public sealed class DropCatchLevelRewardUpdateNotify : IMessage<DropCatchLevelRewardUpdateNotify>, IMessage, IEquatable<DropCatchLevelRewardUpdateNotify>, IDeepCloneable<DropCatchLevelRewardUpdateNotify>, IBufferMessage
	{
		// Token: 0x06006402 RID: 25602 RVA: 0x000F0521 File Offset: 0x000EE721
		[NullableContext(1)]
		public static DropCatchLevelRewardUpdateNotify Create()
		{
			return new DropCatchLevelRewardUpdateNotify();
		}

		// Token: 0x170012AC RID: 4780
		// (get) Token: 0x06006403 RID: 25603 RVA: 0x000F0528 File Offset: 0x000EE728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012AD RID: 4781
		// (get) Token: 0x06006404 RID: 25604 RVA: 0x000F052B File Offset: 0x000EE72B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchLevelRewardUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06006405 RID: 25605 RVA: 0x000F0532 File Offset: 0x000EE732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardUpdateNotify()
		{
		}

		// Token: 0x06006406 RID: 25606 RVA: 0x000F0545 File Offset: 0x000EE745
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardUpdateNotify(DropCatchLevelRewardUpdateNotify other) : this()
		{
			this.dropCatchLevelInfos_ = other.dropCatchLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006407 RID: 25607 RVA: 0x000F056F File Offset: 0x000EE76F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchLevelRewardUpdateNotify Clone()
		{
			return new DropCatchLevelRewardUpdateNotify(this);
		}

		// Token: 0x170012AE RID: 4782
		// (get) Token: 0x06006408 RID: 25608 RVA: 0x000F0577 File Offset: 0x000EE777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DropCatchLevelInfo> DropCatchLevelInfos
		{
			get
			{
				return this.dropCatchLevelInfos_;
			}
		}

		// Token: 0x06006409 RID: 25609 RVA: 0x000F057F File Offset: 0x000EE77F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchLevelRewardUpdateNotify);
		}

		// Token: 0x0600640A RID: 25610 RVA: 0x000F058D File Offset: 0x000EE78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchLevelRewardUpdateNotify other)
		{
			return other != null && (other == this || (this.dropCatchLevelInfos_.Equals(other.dropCatchLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600640B RID: 25611 RVA: 0x000F05C0 File Offset: 0x000EE7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dropCatchLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600640C RID: 25612 RVA: 0x000F05F4 File Offset: 0x000EE7F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600640D RID: 25613 RVA: 0x000F0601 File Offset: 0x000EE801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600640E RID: 25614 RVA: 0x000F060A File Offset: 0x000EE80A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dropCatchLevelInfos_.WriteTo(ref output, DropCatchLevelRewardUpdateNotify._repeated_dropCatchLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600640F RID: 25615 RVA: 0x000F0634 File Offset: 0x000EE834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dropCatchLevelInfos_.CalculateSize(DropCatchLevelRewardUpdateNotify._repeated_dropCatchLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006410 RID: 25616 RVA: 0x000F066D File Offset: 0x000EE86D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchLevelRewardUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.dropCatchLevelInfos_.Add(other.dropCatchLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006411 RID: 25617 RVA: 0x000F069B File Offset: 0x000EE89B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006412 RID: 25618 RVA: 0x000F06A4 File Offset: 0x000EE8A4
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
				if (num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.dropCatchLevelInfos_.AddEntriesFrom(ref input, DropCatchLevelRewardUpdateNotify._repeated_dropCatchLevelInfos_codec);
				}
			}
		}

		// Token: 0x0400384A RID: 14410
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400384B RID: 14411
		public const int DropCatchLevelInfosFieldNumber = 3;

		// Token: 0x0400384C RID: 14412
		private static readonly FieldCodec<DropCatchLevelInfo> _repeated_dropCatchLevelInfos_codec = FieldCodec.ForMessage<DropCatchLevelInfo>(26U, DropCatchLevelInfo.Parser);

		// Token: 0x0400384D RID: 14413
		private readonly RepeatedField<DropCatchLevelInfo> dropCatchLevelInfos_ = new RepeatedField<DropCatchLevelInfo>();
	}
}
