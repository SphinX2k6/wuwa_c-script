using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003EF RID: 1007
	public sealed class DropCatchActivityInfo : IMessage<DropCatchActivityInfo>, IMessage, IEquatable<DropCatchActivityInfo>, IDeepCloneable<DropCatchActivityInfo>, IBufferMessage
	{
		// Token: 0x060061D7 RID: 25047 RVA: 0x000EC0BA File Offset: 0x000EA2BA
		[NullableContext(1)]
		public static DropCatchActivityInfo Create()
		{
			return new DropCatchActivityInfo();
		}

		// Token: 0x17001239 RID: 4665
		// (get) Token: 0x060061D8 RID: 25048 RVA: 0x000EC0C1 File Offset: 0x000EA2C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700123A RID: 4666
		// (get) Token: 0x060061D9 RID: 25049 RVA: 0x000EC0C4 File Offset: 0x000EA2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DropCatchActivityInfo.Descriptor;
			}
		}

		// Token: 0x060061DA RID: 25050 RVA: 0x000EC0CB File Offset: 0x000EA2CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchActivityInfo()
		{
		}

		// Token: 0x060061DB RID: 25051 RVA: 0x000EC0DE File Offset: 0x000EA2DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchActivityInfo(DropCatchActivityInfo other) : this()
		{
			this.dropCatchLevelInfos_ = other.dropCatchLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060061DC RID: 25052 RVA: 0x000EC108 File Offset: 0x000EA308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DropCatchActivityInfo Clone()
		{
			return new DropCatchActivityInfo(this);
		}

		// Token: 0x1700123B RID: 4667
		// (get) Token: 0x060061DD RID: 25053 RVA: 0x000EC110 File Offset: 0x000EA310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DropCatchLevelInfo> DropCatchLevelInfos
		{
			get
			{
				return this.dropCatchLevelInfos_;
			}
		}

		// Token: 0x060061DE RID: 25054 RVA: 0x000EC118 File Offset: 0x000EA318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DropCatchActivityInfo);
		}

		// Token: 0x060061DF RID: 25055 RVA: 0x000EC126 File Offset: 0x000EA326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DropCatchActivityInfo other)
		{
			return other != null && (other == this || (this.dropCatchLevelInfos_.Equals(other.dropCatchLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060061E0 RID: 25056 RVA: 0x000EC15C File Offset: 0x000EA35C
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

		// Token: 0x060061E1 RID: 25057 RVA: 0x000EC190 File Offset: 0x000EA390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060061E2 RID: 25058 RVA: 0x000EC19D File Offset: 0x000EA39D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060061E3 RID: 25059 RVA: 0x000EC1A6 File Offset: 0x000EA3A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dropCatchLevelInfos_.WriteTo(ref output, DropCatchActivityInfo._repeated_dropCatchLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060061E4 RID: 25060 RVA: 0x000EC1D0 File Offset: 0x000EA3D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dropCatchLevelInfos_.CalculateSize(DropCatchActivityInfo._repeated_dropCatchLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060061E5 RID: 25061 RVA: 0x000EC209 File Offset: 0x000EA409
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DropCatchActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.dropCatchLevelInfos_.Add(other.dropCatchLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060061E6 RID: 25062 RVA: 0x000EC237 File Offset: 0x000EA437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060061E7 RID: 25063 RVA: 0x000EC240 File Offset: 0x000EA440
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
					this.dropCatchLevelInfos_.AddEntriesFrom(ref input, DropCatchActivityInfo._repeated_dropCatchLevelInfos_codec);
				}
			}
		}

		// Token: 0x04003810 RID: 14352
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003811 RID: 14353
		public const int DropCatchLevelInfosFieldNumber = 1;

		// Token: 0x04003812 RID: 14354
		private static readonly FieldCodec<DropCatchLevelInfo> _repeated_dropCatchLevelInfos_codec = FieldCodec.ForMessage<DropCatchLevelInfo>(10U, DropCatchLevelInfo.Parser);

		// Token: 0x04003813 RID: 14355
		private readonly RepeatedField<DropCatchLevelInfo> dropCatchLevelInfos_ = new RepeatedField<DropCatchLevelInfo>();
	}
}
