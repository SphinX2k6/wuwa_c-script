using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003DC RID: 988
	[NetMessage(EMessageId.DirectTrainInfoUpdateNotify)]
	public sealed class DirectTrainInfoUpdateNotify : IMessage<DirectTrainInfoUpdateNotify>, IMessage, IEquatable<DirectTrainInfoUpdateNotify>, IDeepCloneable<DirectTrainInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600602F RID: 24623 RVA: 0x000E8B1F File Offset: 0x000E6D1F
		[NullableContext(1)]
		public static DirectTrainInfoUpdateNotify Create()
		{
			return new DirectTrainInfoUpdateNotify();
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x06006030 RID: 24624 RVA: 0x000E8B26 File Offset: 0x000E6D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011ED RID: 4589
		// (get) Token: 0x06006031 RID: 24625 RVA: 0x000E8B29 File Offset: 0x000E6D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DirectTrainInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06006032 RID: 24626 RVA: 0x000E8B30 File Offset: 0x000E6D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoUpdateNotify()
		{
		}

		// Token: 0x06006033 RID: 24627 RVA: 0x000E8B43 File Offset: 0x000E6D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoUpdateNotify(DirectTrainInfoUpdateNotify other) : this()
		{
			this.activitys_ = other.activitys_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006034 RID: 24628 RVA: 0x000E8B6D File Offset: 0x000E6D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoUpdateNotify Clone()
		{
			return new DirectTrainInfoUpdateNotify(this);
		}

		// Token: 0x170011EE RID: 4590
		// (get) Token: 0x06006035 RID: 24629 RVA: 0x000E8B75 File Offset: 0x000E6D75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityData> Activitys
		{
			get
			{
				return this.activitys_;
			}
		}

		// Token: 0x06006036 RID: 24630 RVA: 0x000E8B7D File Offset: 0x000E6D7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DirectTrainInfoUpdateNotify);
		}

		// Token: 0x06006037 RID: 24631 RVA: 0x000E8B8B File Offset: 0x000E6D8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DirectTrainInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.activitys_.Equals(other.activitys_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006038 RID: 24632 RVA: 0x000E8BC0 File Offset: 0x000E6DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.activitys_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006039 RID: 24633 RVA: 0x000E8BF4 File Offset: 0x000E6DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600603A RID: 24634 RVA: 0x000E8C01 File Offset: 0x000E6E01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600603B RID: 24635 RVA: 0x000E8C0A File Offset: 0x000E6E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.activitys_.WriteTo(ref output, DirectTrainInfoUpdateNotify._repeated_activitys_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600603C RID: 24636 RVA: 0x000E8C34 File Offset: 0x000E6E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.activitys_.CalculateSize(DirectTrainInfoUpdateNotify._repeated_activitys_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600603D RID: 24637 RVA: 0x000E8C6D File Offset: 0x000E6E6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DirectTrainInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.activitys_.Add(other.activitys_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600603E RID: 24638 RVA: 0x000E8C9B File Offset: 0x000E6E9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600603F RID: 24639 RVA: 0x000E8CA4 File Offset: 0x000E6EA4
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activitys_.AddEntriesFrom(ref input, DirectTrainInfoUpdateNotify._repeated_activitys_codec);
				}
			}
		}

		// Token: 0x04003753 RID: 14163
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003754 RID: 14164
		public const int ActivitysFieldNumber = 2;

		// Token: 0x04003755 RID: 14165
		private static readonly FieldCodec<ActivityData> _repeated_activitys_codec = FieldCodec.ForMessage<ActivityData>(18U, ActivityData.Parser);

		// Token: 0x04003756 RID: 14166
		private readonly RepeatedField<ActivityData> activitys_ = new RepeatedField<ActivityData>();
	}
}
