using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000250 RID: 592
	[NetMessage(EMessageId.ChangeHeadPhotoRequest)]
	public sealed class ChangeHeadPhotoRequest : IMessage<ChangeHeadPhotoRequest>, IMessage, IEquatable<ChangeHeadPhotoRequest>, IDeepCloneable<ChangeHeadPhotoRequest>, IBufferMessage
	{
		// Token: 0x06003F1F RID: 16159 RVA: 0x0009B752 File Offset: 0x00099952
		[NullableContext(1)]
		public static ChangeHeadPhotoRequest Create()
		{
			return new ChangeHeadPhotoRequest();
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06003F20 RID: 16160 RVA: 0x0009B759 File Offset: 0x00099959
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06003F21 RID: 16161 RVA: 0x0009B75C File Offset: 0x0009995C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeHeadPhotoRequest.Descriptor;
			}
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x0009B763 File Offset: 0x00099963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeHeadPhotoRequest()
		{
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x0009B76B File Offset: 0x0009996B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeHeadPhotoRequest(ChangeHeadPhotoRequest other) : this()
		{
			this.headPhotoId_ = other.headPhotoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x0009B790 File Offset: 0x00099990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeHeadPhotoRequest Clone()
		{
			return new ChangeHeadPhotoRequest(this);
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06003F25 RID: 16165 RVA: 0x0009B798 File Offset: 0x00099998
		// (set) Token: 0x06003F26 RID: 16166 RVA: 0x0009B7A0 File Offset: 0x000999A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadPhotoId
		{
			get
			{
				return this.headPhotoId_;
			}
			set
			{
				this.headPhotoId_ = value;
			}
		}

		// Token: 0x06003F27 RID: 16167 RVA: 0x0009B7A9 File Offset: 0x000999A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeHeadPhotoRequest);
		}

		// Token: 0x06003F28 RID: 16168 RVA: 0x0009B7B7 File Offset: 0x000999B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeHeadPhotoRequest other)
		{
			return other != null && (other == this || (this.HeadPhotoId == other.HeadPhotoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003F29 RID: 16169 RVA: 0x0009B7E8 File Offset: 0x000999E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HeadPhotoId != 0)
			{
				num ^= this.HeadPhotoId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003F2A RID: 16170 RVA: 0x0009B827 File Offset: 0x00099A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003F2B RID: 16171 RVA: 0x0009B834 File Offset: 0x00099A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003F2C RID: 16172 RVA: 0x0009B83D File Offset: 0x00099A3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HeadPhotoId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.HeadPhotoId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003F2D RID: 16173 RVA: 0x0009B870 File Offset: 0x00099A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HeadPhotoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadPhotoId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003F2E RID: 16174 RVA: 0x0009B8AE File Offset: 0x00099AAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeHeadPhotoRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HeadPhotoId != 0)
			{
				this.HeadPhotoId = other.HeadPhotoId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003F2F RID: 16175 RVA: 0x0009B8DF File Offset: 0x00099ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003F30 RID: 16176 RVA: 0x0009B8E8 File Offset: 0x00099AE8
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HeadPhotoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D0C RID: 11532
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D0D RID: 11533
		public const int HeadPhotoIdFieldNumber = 9;

		// Token: 0x04002D0E RID: 11534
		private int headPhotoId_;
	}
}
