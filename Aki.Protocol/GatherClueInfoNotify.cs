using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A6 RID: 1702
	[NetMessage(EMessageId.GatherClueInfoNotify)]
	public sealed class GatherClueInfoNotify : IMessage<GatherClueInfoNotify>, IMessage, IEquatable<GatherClueInfoNotify>, IDeepCloneable<GatherClueInfoNotify>, IBufferMessage
	{
		// Token: 0x06009C64 RID: 40036 RVA: 0x0017C8F1 File Offset: 0x0017AAF1
		[NullableContext(1)]
		public static GatherClueInfoNotify Create()
		{
			return new GatherClueInfoNotify();
		}

		// Token: 0x17001F69 RID: 8041
		// (get) Token: 0x06009C65 RID: 40037 RVA: 0x0017C8F8 File Offset: 0x0017AAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F6A RID: 8042
		// (get) Token: 0x06009C66 RID: 40038 RVA: 0x0017C8FB File Offset: 0x0017AAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GatherClueInfoNotify.Descriptor;
			}
		}

		// Token: 0x06009C67 RID: 40039 RVA: 0x0017C902 File Offset: 0x0017AB02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherClueInfoNotify()
		{
		}

		// Token: 0x06009C68 RID: 40040 RVA: 0x0017C915 File Offset: 0x0017AB15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherClueInfoNotify(GatherClueInfoNotify other) : this()
		{
			this.unLockClueIds_ = other.unLockClueIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009C69 RID: 40041 RVA: 0x0017C93F File Offset: 0x0017AB3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GatherClueInfoNotify Clone()
		{
			return new GatherClueInfoNotify(this);
		}

		// Token: 0x17001F6B RID: 8043
		// (get) Token: 0x06009C6A RID: 40042 RVA: 0x0017C947 File Offset: 0x0017AB47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnLockClueIds
		{
			get
			{
				return this.unLockClueIds_;
			}
		}

		// Token: 0x06009C6B RID: 40043 RVA: 0x0017C94F File Offset: 0x0017AB4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GatherClueInfoNotify);
		}

		// Token: 0x06009C6C RID: 40044 RVA: 0x0017C95D File Offset: 0x0017AB5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GatherClueInfoNotify other)
		{
			return other != null && (other == this || (this.unLockClueIds_.Equals(other.unLockClueIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009C6D RID: 40045 RVA: 0x0017C990 File Offset: 0x0017AB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unLockClueIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009C6E RID: 40046 RVA: 0x0017C9C4 File Offset: 0x0017ABC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009C6F RID: 40047 RVA: 0x0017C9D1 File Offset: 0x0017ABD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009C70 RID: 40048 RVA: 0x0017C9DA File Offset: 0x0017ABDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unLockClueIds_.WriteTo(ref output, GatherClueInfoNotify._repeated_unLockClueIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009C71 RID: 40049 RVA: 0x0017CA04 File Offset: 0x0017AC04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unLockClueIds_.CalculateSize(GatherClueInfoNotify._repeated_unLockClueIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009C72 RID: 40050 RVA: 0x0017CA3D File Offset: 0x0017AC3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GatherClueInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unLockClueIds_.Add(other.unLockClueIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009C73 RID: 40051 RVA: 0x0017CA6B File Offset: 0x0017AC6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009C74 RID: 40052 RVA: 0x0017CA74 File Offset: 0x0017AC74
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
					this.unLockClueIds_.AddEntriesFrom(ref input, GatherClueInfoNotify._repeated_unLockClueIds_codec);
				}
			}
		}

		// Token: 0x040049FF RID: 18943
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A00 RID: 18944
		public const int UnLockClueIdsFieldNumber = 13;

		// Token: 0x04004A01 RID: 18945
		private static readonly FieldCodec<int> _repeated_unLockClueIds_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04004A02 RID: 18946
		private readonly RepeatedField<int> unLockClueIds_ = new RepeatedField<int>();
	}
}
