using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A8 RID: 680
	public sealed class ClientStorageIntData : IMessage<ClientStorageIntData>, IMessage, IEquatable<ClientStorageIntData>, IDeepCloneable<ClientStorageIntData>, IBufferMessage
	{
		// Token: 0x060046E8 RID: 18152 RVA: 0x000AED36 File Offset: 0x000ACF36
		[NullableContext(1)]
		public static ClientStorageIntData Create()
		{
			return new ClientStorageIntData();
		}

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x060046E9 RID: 18153 RVA: 0x000AED3D File Offset: 0x000ACF3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x060046EA RID: 18154 RVA: 0x000AED40 File Offset: 0x000ACF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientStorageIntData.Descriptor;
			}
		}

		// Token: 0x060046EB RID: 18155 RVA: 0x000AED47 File Offset: 0x000ACF47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageIntData()
		{
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x000AED4F File Offset: 0x000ACF4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageIntData(ClientStorageIntData other) : this()
		{
			this.data_ = other.data_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060046ED RID: 18157 RVA: 0x000AED74 File Offset: 0x000ACF74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientStorageIntData Clone()
		{
			return new ClientStorageIntData(this);
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x060046EE RID: 18158 RVA: 0x000AED7C File Offset: 0x000ACF7C
		// (set) Token: 0x060046EF RID: 18159 RVA: 0x000AED84 File Offset: 0x000ACF84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Data
		{
			get
			{
				return this.data_;
			}
			set
			{
				this.data_ = value;
			}
		}

		// Token: 0x060046F0 RID: 18160 RVA: 0x000AED8D File Offset: 0x000ACF8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientStorageIntData);
		}

		// Token: 0x060046F1 RID: 18161 RVA: 0x000AED9B File Offset: 0x000ACF9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientStorageIntData other)
		{
			return other != null && (other == this || (this.Data == other.Data && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060046F2 RID: 18162 RVA: 0x000AEDCC File Offset: 0x000ACFCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Data != 0)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060046F3 RID: 18163 RVA: 0x000AEE0B File Offset: 0x000AD00B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060046F4 RID: 18164 RVA: 0x000AEE18 File Offset: 0x000AD018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060046F5 RID: 18165 RVA: 0x000AEE21 File Offset: 0x000AD021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Data != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060046F6 RID: 18166 RVA: 0x000AEE54 File Offset: 0x000AD054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Data != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060046F7 RID: 18167 RVA: 0x000AEE92 File Offset: 0x000AD092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientStorageIntData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Data != 0)
			{
				this.Data = other.Data;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060046F8 RID: 18168 RVA: 0x000AEEC3 File Offset: 0x000AD0C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060046F9 RID: 18169 RVA: 0x000AEECC File Offset: 0x000AD0CC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Data = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002FD5 RID: 12245
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FD6 RID: 12246
		public const int DataFieldNumber = 1;

		// Token: 0x04002FD7 RID: 12247
		private int data_;
	}
}
