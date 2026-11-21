using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B4C RID: 2892
	[NetMessage(EMessageId.NormalItemRemoveNotify)]
	public sealed class NormalItemRemoveNotify : IMessage<NormalItemRemoveNotify>, IMessage, IEquatable<NormalItemRemoveNotify>, IDeepCloneable<NormalItemRemoveNotify>, IBufferMessage
	{
		// Token: 0x0600FB08 RID: 64264 RVA: 0x00249853 File Offset: 0x00247A53
		[NullableContext(1)]
		public static NormalItemRemoveNotify Create()
		{
			return new NormalItemRemoveNotify();
		}

		// Token: 0x1700332A RID: 13098
		// (get) Token: 0x0600FB09 RID: 64265 RVA: 0x0024985A File Offset: 0x00247A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700332B RID: 13099
		// (get) Token: 0x0600FB0A RID: 64266 RVA: 0x0024985D File Offset: 0x00247A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalItemRemoveNotify.Descriptor;
			}
		}

		// Token: 0x0600FB0B RID: 64267 RVA: 0x00249864 File Offset: 0x00247A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemRemoveNotify()
		{
		}

		// Token: 0x0600FB0C RID: 64268 RVA: 0x00249877 File Offset: 0x00247A77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemRemoveNotify(NormalItemRemoveNotify other) : this()
		{
			this.normalItemIdList_ = other.normalItemIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FB0D RID: 64269 RVA: 0x002498A1 File Offset: 0x00247AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItemRemoveNotify Clone()
		{
			return new NormalItemRemoveNotify(this);
		}

		// Token: 0x1700332C RID: 13100
		// (get) Token: 0x0600FB0E RID: 64270 RVA: 0x002498A9 File Offset: 0x00247AA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NormalItemIdList
		{
			get
			{
				return this.normalItemIdList_;
			}
		}

		// Token: 0x0600FB0F RID: 64271 RVA: 0x002498B1 File Offset: 0x00247AB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalItemRemoveNotify);
		}

		// Token: 0x0600FB10 RID: 64272 RVA: 0x002498BF File Offset: 0x00247ABF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalItemRemoveNotify other)
		{
			return other != null && (other == this || (this.normalItemIdList_.Equals(other.normalItemIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FB11 RID: 64273 RVA: 0x002498F4 File Offset: 0x00247AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.normalItemIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FB12 RID: 64274 RVA: 0x00249928 File Offset: 0x00247B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FB13 RID: 64275 RVA: 0x00249935 File Offset: 0x00247B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FB14 RID: 64276 RVA: 0x0024993E File Offset: 0x00247B3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.normalItemIdList_.WriteTo(ref output, NormalItemRemoveNotify._repeated_normalItemIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FB15 RID: 64277 RVA: 0x00249968 File Offset: 0x00247B68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.normalItemIdList_.CalculateSize(NormalItemRemoveNotify._repeated_normalItemIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FB16 RID: 64278 RVA: 0x002499A1 File Offset: 0x00247BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalItemRemoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.normalItemIdList_.Add(other.normalItemIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FB17 RID: 64279 RVA: 0x002499CF File Offset: 0x00247BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FB18 RID: 64280 RVA: 0x002499D8 File Offset: 0x00247BD8
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.normalItemIdList_.AddEntriesFrom(ref input, NormalItemRemoveNotify._repeated_normalItemIdList_codec);
				}
			}
		}

		// Token: 0x040064BD RID: 25789
		private UnknownFieldSet _unknownFields;

		// Token: 0x040064BE RID: 25790
		public const int NormalItemIdListFieldNumber = 5;

		// Token: 0x040064BF RID: 25791
		private static readonly FieldCodec<int> _repeated_normalItemIdList_codec = FieldCodec.ForInt32(42U);

		// Token: 0x040064C0 RID: 25792
		private readonly RepeatedField<int> normalItemIdList_ = new RepeatedField<int>();
	}
}
