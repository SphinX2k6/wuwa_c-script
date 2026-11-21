using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011D8 RID: 4568
	[NetMessage(EMessageId.ScratchCardCountInfoNotify)]
	public sealed class ScratchCardCountInfoNotify : IMessage<ScratchCardCountInfoNotify>, IMessage, IEquatable<ScratchCardCountInfoNotify>, IDeepCloneable<ScratchCardCountInfoNotify>, IBufferMessage
	{
		// Token: 0x0601861F RID: 99871 RVA: 0x0038C73B File Offset: 0x0038A93B
		[NullableContext(1)]
		public static ScratchCardCountInfoNotify Create()
		{
			return new ScratchCardCountInfoNotify();
		}

		// Token: 0x1700522B RID: 21035
		// (get) Token: 0x06018620 RID: 99872 RVA: 0x0038C742 File Offset: 0x0038A942
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700522C RID: 21036
		// (get) Token: 0x06018621 RID: 99873 RVA: 0x0038C745 File Offset: 0x0038A945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ScratchCardCountInfoNotify.Descriptor;
			}
		}

		// Token: 0x06018622 RID: 99874 RVA: 0x0038C74C File Offset: 0x0038A94C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardCountInfoNotify()
		{
		}

		// Token: 0x06018623 RID: 99875 RVA: 0x0038C75F File Offset: 0x0038A95F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardCountInfoNotify(ScratchCardCountInfoNotify other) : this()
		{
			this.scratchTimeInfos_ = other.scratchTimeInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018624 RID: 99876 RVA: 0x0038C789 File Offset: 0x0038A989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ScratchCardCountInfoNotify Clone()
		{
			return new ScratchCardCountInfoNotify(this);
		}

		// Token: 0x1700522D RID: 21037
		// (get) Token: 0x06018625 RID: 99877 RVA: 0x0038C791 File Offset: 0x0038A991
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ScratchCardTimeInfo> ScratchTimeInfos
		{
			get
			{
				return this.scratchTimeInfos_;
			}
		}

		// Token: 0x06018626 RID: 99878 RVA: 0x0038C799 File Offset: 0x0038A999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ScratchCardCountInfoNotify);
		}

		// Token: 0x06018627 RID: 99879 RVA: 0x0038C7A7 File Offset: 0x0038A9A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ScratchCardCountInfoNotify other)
		{
			return other != null && (other == this || (this.scratchTimeInfos_.Equals(other.scratchTimeInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018628 RID: 99880 RVA: 0x0038C7DC File Offset: 0x0038A9DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.scratchTimeInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018629 RID: 99881 RVA: 0x0038C810 File Offset: 0x0038AA10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601862A RID: 99882 RVA: 0x0038C81D File Offset: 0x0038AA1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601862B RID: 99883 RVA: 0x0038C826 File Offset: 0x0038AA26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.scratchTimeInfos_.WriteTo(ref output, ScratchCardCountInfoNotify._repeated_scratchTimeInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601862C RID: 99884 RVA: 0x0038C850 File Offset: 0x0038AA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.scratchTimeInfos_.CalculateSize(ScratchCardCountInfoNotify._repeated_scratchTimeInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601862D RID: 99885 RVA: 0x0038C889 File Offset: 0x0038AA89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ScratchCardCountInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.scratchTimeInfos_.Add(other.scratchTimeInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601862E RID: 99886 RVA: 0x0038C8B7 File Offset: 0x0038AAB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601862F RID: 99887 RVA: 0x0038C8C0 File Offset: 0x0038AAC0
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.scratchTimeInfos_.AddEntriesFrom(ref input, ScratchCardCountInfoNotify._repeated_scratchTimeInfos_codec);
				}
			}
		}

		// Token: 0x040090D6 RID: 37078
		private UnknownFieldSet _unknownFields;

		// Token: 0x040090D7 RID: 37079
		public const int ScratchTimeInfosFieldNumber = 11;

		// Token: 0x040090D8 RID: 37080
		private static readonly FieldCodec<ScratchCardTimeInfo> _repeated_scratchTimeInfos_codec = FieldCodec.ForMessage<ScratchCardTimeInfo>(90U, ScratchCardTimeInfo.Parser);

		// Token: 0x040090D9 RID: 37081
		private readonly RepeatedField<ScratchCardTimeInfo> scratchTimeInfos_ = new RepeatedField<ScratchCardTimeInfo>();
	}
}
