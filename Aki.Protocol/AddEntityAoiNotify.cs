using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000A3 RID: 163
	[NetMessage(EMessageId.AddEntityAoiNotify)]
	public sealed class AddEntityAoiNotify : IMessage<AddEntityAoiNotify>, IMessage, IEquatable<AddEntityAoiNotify>, IDeepCloneable<AddEntityAoiNotify>, IBufferMessage
	{
		// Token: 0x06001C81 RID: 7297 RVA: 0x0004F0CD File Offset: 0x0004D2CD
		[NullableContext(1)]
		public static AddEntityAoiNotify Create()
		{
			return new AddEntityAoiNotify();
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x06001C82 RID: 7298 RVA: 0x0004F0D4 File Offset: 0x0004D2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001C83 RID: 7299 RVA: 0x0004F0D7 File Offset: 0x0004D2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddEntityAoiNotify.Descriptor;
			}
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0004F0DE File Offset: 0x0004D2DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddEntityAoiNotify()
		{
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0004F0F1 File Offset: 0x0004D2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddEntityAoiNotify(AddEntityAoiNotify other) : this()
		{
			this.entityInfos_ = other.entityInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0004F11B File Offset: 0x0004D31B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddEntityAoiNotify Clone()
		{
			return new AddEntityAoiNotify(this);
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001C87 RID: 7303 RVA: 0x0004F123 File Offset: 0x0004D323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DynamicEntityInformation> EntityInfos
		{
			get
			{
				return this.entityInfos_;
			}
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0004F12B File Offset: 0x0004D32B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddEntityAoiNotify);
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0004F139 File Offset: 0x0004D339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddEntityAoiNotify other)
		{
			return other != null && (other == this || (this.entityInfos_.Equals(other.entityInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0004F16C File Offset: 0x0004D36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.entityInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0004F1A0 File Offset: 0x0004D3A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x0004F1AD File Offset: 0x0004D3AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0004F1B6 File Offset: 0x0004D3B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityInfos_.WriteTo(ref output, AddEntityAoiNotify._repeated_entityInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0004F1E0 File Offset: 0x0004D3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityInfos_.CalculateSize(AddEntityAoiNotify._repeated_entityInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0004F219 File Offset: 0x0004D419
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddEntityAoiNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entityInfos_.Add(other.entityInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0004F247 File Offset: 0x0004D447
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x0004F250 File Offset: 0x0004D450
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
					this.entityInfos_.AddEntriesFrom(ref input, AddEntityAoiNotify._repeated_entityInfos_codec);
				}
			}
		}

		// Token: 0x040022E3 RID: 8931
		private UnknownFieldSet _unknownFields;

		// Token: 0x040022E4 RID: 8932
		public const int EntityInfosFieldNumber = 1;

		// Token: 0x040022E5 RID: 8933
		private static readonly FieldCodec<DynamicEntityInformation> _repeated_entityInfos_codec = FieldCodec.ForMessage<DynamicEntityInformation>(10U, DynamicEntityInformation.Parser);

		// Token: 0x040022E6 RID: 8934
		private readonly RepeatedField<DynamicEntityInformation> entityInfos_ = new RepeatedField<DynamicEntityInformation>();
	}
}
