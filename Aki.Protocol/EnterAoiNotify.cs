using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200044B RID: 1099
	[NetMessage(EMessageId.EnterAoiNotify)]
	public sealed class EnterAoiNotify : IMessage<EnterAoiNotify>, IMessage, IEquatable<EnterAoiNotify>, IDeepCloneable<EnterAoiNotify>, IBufferMessage
	{
		// Token: 0x06006909 RID: 26889 RVA: 0x000FC165 File Offset: 0x000FA365
		[NullableContext(1)]
		public static EnterAoiNotify Create()
		{
			return new EnterAoiNotify();
		}

		// Token: 0x170013C9 RID: 5065
		// (get) Token: 0x0600690A RID: 26890 RVA: 0x000FC16C File Offset: 0x000FA36C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013CA RID: 5066
		// (get) Token: 0x0600690B RID: 26891 RVA: 0x000FC16F File Offset: 0x000FA36F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterAoiNotify.Descriptor;
			}
		}

		// Token: 0x0600690C RID: 26892 RVA: 0x000FC176 File Offset: 0x000FA376
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAoiNotify()
		{
		}

		// Token: 0x0600690D RID: 26893 RVA: 0x000FC189 File Offset: 0x000FA389
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAoiNotify(EnterAoiNotify other) : this()
		{
			this.entityInfos_ = other.entityInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600690E RID: 26894 RVA: 0x000FC1B3 File Offset: 0x000FA3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterAoiNotify Clone()
		{
			return new EnterAoiNotify(this);
		}

		// Token: 0x170013CB RID: 5067
		// (get) Token: 0x0600690F RID: 26895 RVA: 0x000FC1BB File Offset: 0x000FA3BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<DynamicEntityInformation> EntityInfos
		{
			get
			{
				return this.entityInfos_;
			}
		}

		// Token: 0x06006910 RID: 26896 RVA: 0x000FC1C3 File Offset: 0x000FA3C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterAoiNotify);
		}

		// Token: 0x06006911 RID: 26897 RVA: 0x000FC1D1 File Offset: 0x000FA3D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterAoiNotify other)
		{
			return other != null && (other == this || (this.entityInfos_.Equals(other.entityInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006912 RID: 26898 RVA: 0x000FC204 File Offset: 0x000FA404
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

		// Token: 0x06006913 RID: 26899 RVA: 0x000FC238 File Offset: 0x000FA438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006914 RID: 26900 RVA: 0x000FC245 File Offset: 0x000FA445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006915 RID: 26901 RVA: 0x000FC24E File Offset: 0x000FA44E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.entityInfos_.WriteTo(ref output, EnterAoiNotify._repeated_entityInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006916 RID: 26902 RVA: 0x000FC278 File Offset: 0x000FA478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.entityInfos_.CalculateSize(EnterAoiNotify._repeated_entityInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006917 RID: 26903 RVA: 0x000FC2B1 File Offset: 0x000FA4B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterAoiNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.entityInfos_.Add(other.entityInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006918 RID: 26904 RVA: 0x000FC2DF File Offset: 0x000FA4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006919 RID: 26905 RVA: 0x000FC2E8 File Offset: 0x000FA4E8
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.entityInfos_.AddEntriesFrom(ref input, EnterAoiNotify._repeated_entityInfos_codec);
				}
			}
		}

		// Token: 0x040039DC RID: 14812
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039DD RID: 14813
		public const int EntityInfosFieldNumber = 5;

		// Token: 0x040039DE RID: 14814
		private static readonly FieldCodec<DynamicEntityInformation> _repeated_entityInfos_codec = FieldCodec.ForMessage<DynamicEntityInformation>(42U, DynamicEntityInformation.Parser);

		// Token: 0x040039DF RID: 14815
		private readonly RepeatedField<DynamicEntityInformation> entityInfos_ = new RepeatedField<DynamicEntityInformation>();
	}
}
