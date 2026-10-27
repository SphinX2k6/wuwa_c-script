using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EF6 RID: 3830
	[NetMessage(EMessageId.RemoveEntityAoiNotify)]
	public sealed class RemoveEntityAoiNotify : IMessage<RemoveEntityAoiNotify>, IMessage, IEquatable<RemoveEntityAoiNotify>, IDeepCloneable<RemoveEntityAoiNotify>, IBufferMessage
	{
		// Token: 0x0601485A RID: 84058 RVA: 0x002FB560 File Offset: 0x002F9760
		[NullableContext(1)]
		public static RemoveEntityAoiNotify Create()
		{
			return new RemoveEntityAoiNotify();
		}

		// Token: 0x17004440 RID: 17472
		// (get) Token: 0x0601485B RID: 84059 RVA: 0x002FB567 File Offset: 0x002F9767
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004441 RID: 17473
		// (get) Token: 0x0601485C RID: 84060 RVA: 0x002FB56A File Offset: 0x002F976A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveEntityAoiNotify.Descriptor;
			}
		}

		// Token: 0x0601485D RID: 84061 RVA: 0x002FB571 File Offset: 0x002F9771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveEntityAoiNotify()
		{
		}

		// Token: 0x0601485E RID: 84062 RVA: 0x002FB584 File Offset: 0x002F9784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveEntityAoiNotify(RemoveEntityAoiNotify other) : this()
		{
			this.removeInfos_ = other.removeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601485F RID: 84063 RVA: 0x002FB5AE File Offset: 0x002F97AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveEntityAoiNotify Clone()
		{
			return new RemoveEntityAoiNotify(this);
		}

		// Token: 0x17004442 RID: 17474
		// (get) Token: 0x06014860 RID: 84064 RVA: 0x002FB5B6 File Offset: 0x002F97B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EntityRemoveInfo> RemoveInfos
		{
			get
			{
				return this.removeInfos_;
			}
		}

		// Token: 0x06014861 RID: 84065 RVA: 0x002FB5BE File Offset: 0x002F97BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveEntityAoiNotify);
		}

		// Token: 0x06014862 RID: 84066 RVA: 0x002FB5CC File Offset: 0x002F97CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveEntityAoiNotify other)
		{
			return other != null && (other == this || (this.removeInfos_.Equals(other.removeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014863 RID: 84067 RVA: 0x002FB600 File Offset: 0x002F9800
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

		// Token: 0x06014864 RID: 84068 RVA: 0x002FB634 File Offset: 0x002F9834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014865 RID: 84069 RVA: 0x002FB641 File Offset: 0x002F9841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014866 RID: 84070 RVA: 0x002FB64A File Offset: 0x002F984A
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

		// Token: 0x06014867 RID: 84071 RVA: 0x002FB674 File Offset: 0x002F9874
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

		// Token: 0x06014868 RID: 84072 RVA: 0x002FB6AD File Offset: 0x002F98AD
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

		// Token: 0x06014869 RID: 84073 RVA: 0x002FB6DB File Offset: 0x002F98DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601486A RID: 84074 RVA: 0x002FB6E4 File Offset: 0x002F98E4
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
					this.removeInfos_.AddEntriesFrom(ref input, RemoveEntityAoiNotify._repeated_removeInfos_codec);
				}
			}
		}

		// Token: 0x04007C6A RID: 31850
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007C6B RID: 31851
		public const int RemoveInfosFieldNumber = 3;

		// Token: 0x04007C6C RID: 31852
		private static readonly FieldCodec<EntityRemoveInfo> _repeated_removeInfos_codec = FieldCodec.ForMessage<EntityRemoveInfo>(26U, EntityRemoveInfo.Parser);

		// Token: 0x04007C6D RID: 31853
		private readonly RepeatedField<EntityRemoveInfo> removeInfos_ = new RepeatedField<EntityRemoveInfo>();
	}
}
