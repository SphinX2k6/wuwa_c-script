using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EE6 RID: 3814
	[NetMessage(EMessageId.RemoveEntityAoiNotify)]
	public sealed class RemoveEntityAoiNotify : IMessage<RemoveEntityAoiNotify>, IMessage, IEquatable<RemoveEntityAoiNotify>, IDeepCloneable<RemoveEntityAoiNotify>, IBufferMessage
	{
		// Token: 0x06014775 RID: 83829 RVA: 0x002F9EAC File Offset: 0x002F80AC
		[NullableContext(1)]
		public static RemoveEntityAoiNotify Create()
		{
			return new RemoveEntityAoiNotify();
		}

		// Token: 0x17004416 RID: 17430
		// (get) Token: 0x06014776 RID: 83830 RVA: 0x002F9EB3 File Offset: 0x002F80B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004417 RID: 17431
		// (get) Token: 0x06014777 RID: 83831 RVA: 0x002F9EB6 File Offset: 0x002F80B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveEntityAoiNotify.Descriptor;
			}
		}

		// Token: 0x06014778 RID: 83832 RVA: 0x002F9EBD File Offset: 0x002F80BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveEntityAoiNotify()
		{
		}

		// Token: 0x06014779 RID: 83833 RVA: 0x002F9ED0 File Offset: 0x002F80D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveEntityAoiNotify(RemoveEntityAoiNotify other) : this()
		{
			this.removeInfos_ = other.removeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601477A RID: 83834 RVA: 0x002F9EFA File Offset: 0x002F80FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveEntityAoiNotify Clone()
		{
			return new RemoveEntityAoiNotify(this);
		}

		// Token: 0x17004418 RID: 17432
		// (get) Token: 0x0601477B RID: 83835 RVA: 0x002F9F02 File Offset: 0x002F8102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityRemoveInfo> RemoveInfos
		{
			get
			{
				return this.removeInfos_;
			}
		}

		// Token: 0x0601477C RID: 83836 RVA: 0x002F9F0A File Offset: 0x002F810A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveEntityAoiNotify);
		}

		// Token: 0x0601477D RID: 83837 RVA: 0x002F9F18 File Offset: 0x002F8118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveEntityAoiNotify other)
		{
			return other != null && (other == this || (this.removeInfos_.Equals(other.removeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601477E RID: 83838 RVA: 0x002F9F4C File Offset: 0x002F814C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.removeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601477F RID: 83839 RVA: 0x002F9F80 File Offset: 0x002F8180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014780 RID: 83840 RVA: 0x002F9F8D File Offset: 0x002F818D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014781 RID: 83841 RVA: 0x002F9F96 File Offset: 0x002F8196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.removeInfos_.WriteTo(ref output, RemoveEntityAoiNotify._repeated_removeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014782 RID: 83842 RVA: 0x002F9FC0 File Offset: 0x002F81C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.removeInfos_.CalculateSize(RemoveEntityAoiNotify._repeated_removeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014783 RID: 83843 RVA: 0x002F9FF9 File Offset: 0x002F81F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveEntityAoiNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.removeInfos_.Add(other.removeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014784 RID: 83844 RVA: 0x002FA027 File Offset: 0x002F8227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014785 RID: 83845 RVA: 0x002FA030 File Offset: 0x002F8230
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
					this.removeInfos_.AddEntriesFrom(ref input, RemoveEntityAoiNotify._repeated_removeInfos_codec);
				}
			}
		}

		// Token: 0x04007C94 RID: 31892
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C95 RID: 31893
		public const int RemoveInfosFieldNumber = 2;

		// Token: 0x04007C96 RID: 31894
		private static readonly FieldCodec<EntityRemoveInfo> _repeated_removeInfos_codec = FieldCodec.ForMessage<EntityRemoveInfo>(18U, EntityRemoveInfo.Parser);

		// Token: 0x04007C97 RID: 31895
		private readonly RepeatedField<EntityRemoveInfo> removeInfos_ = new RepeatedField<EntityRemoveInfo>();
	}
}
