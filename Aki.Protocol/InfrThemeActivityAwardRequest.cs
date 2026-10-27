using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007F2 RID: 2034
	[NetMessage(EMessageId.InfrThemeActivityAwardRequest)]
	public sealed class InfrThemeActivityAwardRequest : IMessage<InfrThemeActivityAwardRequest>, IMessage, IEquatable<InfrThemeActivityAwardRequest>, IDeepCloneable<InfrThemeActivityAwardRequest>, IBufferMessage
	{
		// Token: 0x0600B65E RID: 46686 RVA: 0x001B3556 File Offset: 0x001B1756
		[NullableContext(1)]
		public static InfrThemeActivityAwardRequest Create()
		{
			return new InfrThemeActivityAwardRequest();
		}

		// Token: 0x170024C7 RID: 9415
		// (get) Token: 0x0600B65F RID: 46687 RVA: 0x001B355D File Offset: 0x001B175D
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
		// (get) Token: 0x0600B660 RID: 46688 RVA: 0x001B3560 File Offset: 0x001B1760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrThemeActivityAwardRequest.Descriptor;
			}
		}

		// Token: 0x0600B661 RID: 46689 RVA: 0x001B3567 File Offset: 0x001B1767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityAwardRequest()
		{
		}

		// Token: 0x0600B662 RID: 46690 RVA: 0x001B357A File Offset: 0x001B177A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityAwardRequest(InfrThemeActivityAwardRequest other) : this()
		{
			this.taskId_ = other.taskId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B663 RID: 46691 RVA: 0x001B35A4 File Offset: 0x001B17A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrThemeActivityAwardRequest Clone()
		{
			return new InfrThemeActivityAwardRequest(this);
		}

		// Token: 0x170024C9 RID: 9417
		// (get) Token: 0x0600B664 RID: 46692 RVA: 0x001B35AC File Offset: 0x001B17AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TaskId
		{
			get
			{
				return this.taskId_;
			}
		}

		// Token: 0x0600B665 RID: 46693 RVA: 0x001B35B4 File Offset: 0x001B17B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrThemeActivityAwardRequest);
		}

		// Token: 0x0600B666 RID: 46694 RVA: 0x001B35C2 File Offset: 0x001B17C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrThemeActivityAwardRequest other)
		{
			return other != null && (other == this || (this.taskId_.Equals(other.taskId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B667 RID: 46695 RVA: 0x001B35F8 File Offset: 0x001B17F8
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

		// Token: 0x0600B668 RID: 46696 RVA: 0x001B362C File Offset: 0x001B182C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B669 RID: 46697 RVA: 0x001B3639 File Offset: 0x001B1839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B66A RID: 46698 RVA: 0x001B3642 File Offset: 0x001B1842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.taskId_.WriteTo(ref output, InfrThemeActivityAwardRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B66B RID: 46699 RVA: 0x001B366C File Offset: 0x001B186C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.taskId_.CalculateSize(InfrThemeActivityAwardRequest._repeated_taskId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B66C RID: 46700 RVA: 0x001B36A5 File Offset: 0x001B18A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrThemeActivityAwardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.taskId_.Add(other.taskId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B66D RID: 46701 RVA: 0x001B36D3 File Offset: 0x001B18D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B66E RID: 46702 RVA: 0x001B36DC File Offset: 0x001B18DC
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
				if (num != 24U && num != 26U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.taskId_.AddEntriesFrom(ref input, InfrThemeActivityAwardRequest._repeated_taskId_codec);
				}
			}
		}

		// Token: 0x040050C8 RID: 20680
		private UnknownFieldSet _unknownFields;

		// Token: 0x040050C9 RID: 20681
		public const int TaskIdFieldNumber = 3;

		// Token: 0x040050CA RID: 20682
		private static readonly FieldCodec<int> _repeated_taskId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040050CB RID: 20683
		private readonly RepeatedField<int> taskId_ = new RepeatedField<int>();
	}
}
