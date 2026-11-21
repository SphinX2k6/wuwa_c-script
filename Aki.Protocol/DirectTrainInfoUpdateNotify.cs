using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003C5 RID: 965
	[NetMessage(EMessageId.DirectTrainInfoUpdateNotify)]
	public sealed class DirectTrainInfoUpdateNotify : IMessage<DirectTrainInfoUpdateNotify>, IMessage, IEquatable<DirectTrainInfoUpdateNotify>, IDeepCloneable<DirectTrainInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06005E9F RID: 24223 RVA: 0x000E599F File Offset: 0x000E3B9F
		[NullableContext(1)]
		public static DirectTrainInfoUpdateNotify Create()
		{
			return new DirectTrainInfoUpdateNotify();
		}

		// Token: 0x17001197 RID: 4503
		// (get) Token: 0x06005EA0 RID: 24224 RVA: 0x000E59A6 File Offset: 0x000E3BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x06005EA1 RID: 24225 RVA: 0x000E59A9 File Offset: 0x000E3BA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DirectTrainInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06005EA2 RID: 24226 RVA: 0x000E59B0 File Offset: 0x000E3BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoUpdateNotify()
		{
		}

		// Token: 0x06005EA3 RID: 24227 RVA: 0x000E59C3 File Offset: 0x000E3BC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoUpdateNotify(DirectTrainInfoUpdateNotify other) : this()
		{
			this.activitys_ = other.activitys_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005EA4 RID: 24228 RVA: 0x000E59ED File Offset: 0x000E3BED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DirectTrainInfoUpdateNotify Clone()
		{
			return new DirectTrainInfoUpdateNotify(this);
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x06005EA5 RID: 24229 RVA: 0x000E59F5 File Offset: 0x000E3BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ActivityData> Activitys
		{
			get
			{
				return this.activitys_;
			}
		}

		// Token: 0x06005EA6 RID: 24230 RVA: 0x000E59FD File Offset: 0x000E3BFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DirectTrainInfoUpdateNotify);
		}

		// Token: 0x06005EA7 RID: 24231 RVA: 0x000E5A0B File Offset: 0x000E3C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DirectTrainInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.activitys_.Equals(other.activitys_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005EA8 RID: 24232 RVA: 0x000E5A40 File Offset: 0x000E3C40
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

		// Token: 0x06005EA9 RID: 24233 RVA: 0x000E5A74 File Offset: 0x000E3C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005EAA RID: 24234 RVA: 0x000E5A81 File Offset: 0x000E3C81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005EAB RID: 24235 RVA: 0x000E5A8A File Offset: 0x000E3C8A
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

		// Token: 0x06005EAC RID: 24236 RVA: 0x000E5AB4 File Offset: 0x000E3CB4
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

		// Token: 0x06005EAD RID: 24237 RVA: 0x000E5AED File Offset: 0x000E3CED
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

		// Token: 0x06005EAE RID: 24238 RVA: 0x000E5B1B File Offset: 0x000E3D1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005EAF RID: 24239 RVA: 0x000E5B24 File Offset: 0x000E3D24
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.activitys_.AddEntriesFrom(ref input, DirectTrainInfoUpdateNotify._repeated_activitys_codec);
				}
			}
		}

		// Token: 0x04003740 RID: 14144
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003741 RID: 14145
		public const int ActivitysFieldNumber = 8;

		// Token: 0x04003742 RID: 14146
		private static readonly FieldCodec<ActivityData> _repeated_activitys_codec = FieldCodec.ForMessage<ActivityData>(66U, ActivityData.Parser);

		// Token: 0x04003743 RID: 14147
		private readonly RepeatedField<ActivityData> activitys_ = new RepeatedField<ActivityData>();
	}
}
