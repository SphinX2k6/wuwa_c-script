using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F3 RID: 2035
	[NetMessage(EMessageId.InfrV2TaskRewardRequest)]
	public sealed class InfrV2TaskRewardRequest : IMessage<InfrV2TaskRewardRequest>, IMessage, IEquatable<InfrV2TaskRewardRequest>, IDeepCloneable<InfrV2TaskRewardRequest>, IBufferMessage
	{
		// Token: 0x0600B696 RID: 46742 RVA: 0x001B3C00 File Offset: 0x001B1E00
		[NullableContext(1)]
		public static InfrV2TaskRewardRequest Create()
		{
			return new InfrV2TaskRewardRequest();
		}

		// Token: 0x170024C7 RID: 9415
		// (get) Token: 0x0600B697 RID: 46743 RVA: 0x001B3C07 File Offset: 0x001B1E07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170024C8 RID: 9416
		// (get) Token: 0x0600B698 RID: 46744 RVA: 0x001B3C0A File Offset: 0x001B1E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2TaskRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600B699 RID: 46745 RVA: 0x001B3C11 File Offset: 0x001B1E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskRewardRequest()
		{
		}

		// Token: 0x0600B69A RID: 46746 RVA: 0x001B3C24 File Offset: 0x001B1E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskRewardRequest(InfrV2TaskRewardRequest other) : this()
		{
			this.taskIds_ = other.taskIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B69B RID: 46747 RVA: 0x001B3C4E File Offset: 0x001B1E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2TaskRewardRequest Clone()
		{
			return new InfrV2TaskRewardRequest(this);
		}

		// Token: 0x170024C9 RID: 9417
		// (get) Token: 0x0600B69C RID: 46748 RVA: 0x001B3C56 File Offset: 0x001B1E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskIds
		{
			get
			{
				return this.taskIds_;
			}
		}

		// Token: 0x0600B69D RID: 46749 RVA: 0x001B3C5E File Offset: 0x001B1E5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2TaskRewardRequest);
		}

		// Token: 0x0600B69E RID: 46750 RVA: 0x001B3C6C File Offset: 0x001B1E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2TaskRewardRequest other)
		{
			return other != null && (other == this || (this.taskIds_.Equals(other.taskIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B69F RID: 46751 RVA: 0x001B3CA0 File Offset: 0x001B1EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.taskIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B6A0 RID: 46752 RVA: 0x001B3CD4 File Offset: 0x001B1ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B6A1 RID: 46753 RVA: 0x001B3CE1 File Offset: 0x001B1EE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B6A2 RID: 46754 RVA: 0x001B3CEA File Offset: 0x001B1EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskIds_.WriteTo(ref output, InfrV2TaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B6A3 RID: 46755 RVA: 0x001B3D14 File Offset: 0x001B1F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskIds_.CalculateSize(InfrV2TaskRewardRequest._repeated_taskIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B6A4 RID: 46756 RVA: 0x001B3D4D File Offset: 0x001B1F4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2TaskRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskIds_.Add(other.taskIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B6A5 RID: 46757 RVA: 0x001B3D7B File Offset: 0x001B1F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B6A6 RID: 46758 RVA: 0x001B3D84 File Offset: 0x001B1F84
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskIds_.AddEntriesFrom(ref input, InfrV2TaskRewardRequest._repeated_taskIds_codec);
				}
			}
		}

		// Token: 0x0400511A RID: 20762
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400511B RID: 20763
		public const int TaskIdsFieldNumber = 13;

		// Token: 0x0400511C RID: 20764
		private static readonly FieldCodec<int> _repeated_taskIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x0400511D RID: 20765
		private readonly RepeatedField<int> taskIds_ = new RepeatedField<int>();
	}
}
