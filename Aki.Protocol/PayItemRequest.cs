using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BD5 RID: 3029
	[NetMessage(EMessageId.PayItemRequest)]
	public sealed class PayItemRequest : IMessage<PayItemRequest>, IMessage, IEquatable<PayItemRequest>, IDeepCloneable<PayItemRequest>, IBufferMessage
	{
		// Token: 0x06010704 RID: 67332 RVA: 0x00266E7E File Offset: 0x0026507E
		[NullableContext(1)]
		public static PayItemRequest Create()
		{
			return new PayItemRequest();
		}

		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x06010705 RID: 67333 RVA: 0x00266E85 File Offset: 0x00265085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x06010706 RID: 67334 RVA: 0x00266E88 File Offset: 0x00265088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PayItemRequest.Descriptor;
			}
		}

		// Token: 0x06010707 RID: 67335 RVA: 0x00266E8F File Offset: 0x0026508F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemRequest()
		{
		}

		// Token: 0x06010708 RID: 67336 RVA: 0x00266EA2 File Offset: 0x002650A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemRequest(PayItemRequest other) : this()
		{
			this.id_ = other.id_;
			this.version_ = other.version_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010709 RID: 67337 RVA: 0x00266ED3 File Offset: 0x002650D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PayItemRequest Clone()
		{
			return new PayItemRequest(this);
		}

		// Token: 0x170035FE RID: 13822
		// (get) Token: 0x0601070A RID: 67338 RVA: 0x00266EDB File Offset: 0x002650DB
		// (set) Token: 0x0601070B RID: 67339 RVA: 0x00266EE3 File Offset: 0x002650E3
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

		// Token: 0x170035FF RID: 13823
		// (get) Token: 0x0601070C RID: 67340 RVA: 0x00266EEC File Offset: 0x002650EC
		// (set) Token: 0x0601070D RID: 67341 RVA: 0x00266EF4 File Offset: 0x002650F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Version
		{
			get
			{
				return this.version_;
			}
			set
			{
				this.version_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601070E RID: 67342 RVA: 0x00266F07 File Offset: 0x00265107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PayItemRequest);
		}

		// Token: 0x0601070F RID: 67343 RVA: 0x00266F18 File Offset: 0x00265118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PayItemRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && !(this.Version != other.Version) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010710 RID: 67344 RVA: 0x00266F68 File Offset: 0x00265168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Version.Length != 0)
			{
				num ^= this.Version.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010711 RID: 67345 RVA: 0x00266FC2 File Offset: 0x002651C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010712 RID: 67346 RVA: 0x00266FCF File Offset: 0x002651CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010713 RID: 67347 RVA: 0x00266FD8 File Offset: 0x002651D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Version.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.Version);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010714 RID: 67348 RVA: 0x00267038 File Offset: 0x00265238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Version.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Version);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010715 RID: 67349 RVA: 0x00267094 File Offset: 0x00265294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PayItemRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Version.Length != 0)
			{
				this.Version = other.Version;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010716 RID: 67350 RVA: 0x002670E9 File Offset: 0x002652E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010717 RID: 67351 RVA: 0x002670F4 File Offset: 0x002652F4
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
				if (num != 8U)
				{
					if (num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Version = input.ReadString();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040068C9 RID: 26825
		private UnknownFieldSet _unknownFields;

		// Token: 0x040068CA RID: 26826
		public const int IdFieldNumber = 1;

		// Token: 0x040068CB RID: 26827
		private int id_;

		// Token: 0x040068CC RID: 26828
		public const int VersionFieldNumber = 3;

		// Token: 0x040068CD RID: 26829
		private string version_ = "";
	}
}
