using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BE9 RID: 3049
	[NetMessage(EMessageId.PayShopUpdateRequest)]
	public sealed class PayShopUpdateRequest : IMessage<PayShopUpdateRequest>, IMessage, IEquatable<PayShopUpdateRequest>, IDeepCloneable<PayShopUpdateRequest>, IBufferMessage
	{
		// Token: 0x0601092A RID: 67882 RVA: 0x0026DA1D File Offset: 0x0026BC1D
		[NullableContext(1)]
		public static PayShopUpdateRequest Create()
		{
			return new PayShopUpdateRequest();
		}

		// Token: 0x1700369B RID: 13979
		// (get) Token: 0x0601092B RID: 67883 RVA: 0x0026DA24 File Offset: 0x0026BC24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700369C RID: 13980
		// (get) Token: 0x0601092C RID: 67884 RVA: 0x0026DA27 File Offset: 0x0026BC27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayShopUpdateRequest.Descriptor;
			}
		}

		// Token: 0x0601092D RID: 67885 RVA: 0x0026DA2E File Offset: 0x0026BC2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUpdateRequest()
		{
		}

		// Token: 0x0601092E RID: 67886 RVA: 0x0026DA36 File Offset: 0x0026BC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUpdateRequest(PayShopUpdateRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601092F RID: 67887 RVA: 0x0026DA5B File Offset: 0x0026BC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayShopUpdateRequest Clone()
		{
			return new PayShopUpdateRequest(this);
		}

		// Token: 0x1700369D RID: 13981
		// (get) Token: 0x06010930 RID: 67888 RVA: 0x0026DA63 File Offset: 0x0026BC63
		// (set) Token: 0x06010931 RID: 67889 RVA: 0x0026DA6B File Offset: 0x0026BC6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x06010932 RID: 67890 RVA: 0x0026DA74 File Offset: 0x0026BC74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayShopUpdateRequest);
		}

		// Token: 0x06010933 RID: 67891 RVA: 0x0026DA82 File Offset: 0x0026BC82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayShopUpdateRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010934 RID: 67892 RVA: 0x0026DAB0 File Offset: 0x0026BCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010935 RID: 67893 RVA: 0x0026DAEF File Offset: 0x0026BCEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010936 RID: 67894 RVA: 0x0026DAFC File Offset: 0x0026BCFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010937 RID: 67895 RVA: 0x0026DB05 File Offset: 0x0026BD05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010938 RID: 67896 RVA: 0x0026DB38 File Offset: 0x0026BD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010939 RID: 67897 RVA: 0x0026DB76 File Offset: 0x0026BD76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayShopUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601093A RID: 67898 RVA: 0x0026DBA7 File Offset: 0x0026BDA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601093B RID: 67899 RVA: 0x0026DBB0 File Offset: 0x0026BDB0
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040069D5 RID: 27093
		private UnknownFieldSet _unknownFields;

		// Token: 0x040069D6 RID: 27094
		public const int IdFieldNumber = 4;

		// Token: 0x040069D7 RID: 27095
		private int id_;
	}
}
