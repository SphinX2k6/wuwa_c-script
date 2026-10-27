using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001BC RID: 444
	[NetMessage(EMessageId.BoneVisibleChangeRequest)]
	public sealed class BoneVisibleChangeRequest : IMessage<BoneVisibleChangeRequest>, IMessage, IEquatable<BoneVisibleChangeRequest>, IDeepCloneable<BoneVisibleChangeRequest>, IBufferMessage
	{
		// Token: 0x0600334A RID: 13130 RVA: 0x00081E18 File Offset: 0x00080018
		[NullableContext(1)]
		public static BoneVisibleChangeRequest Create()
		{
			return new BoneVisibleChangeRequest();
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x0600334B RID: 13131 RVA: 0x00081E1F File Offset: 0x0008001F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x0600334C RID: 13132 RVA: 0x00081E22 File Offset: 0x00080022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoneVisibleChangeRequest.Descriptor;
			}
		}

		// Token: 0x0600334D RID: 13133 RVA: 0x00081E29 File Offset: 0x00080029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeRequest()
		{
		}

		// Token: 0x0600334E RID: 13134 RVA: 0x00081E31 File Offset: 0x00080031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeRequest(BoneVisibleChangeRequest other) : this()
		{
			this.boneVisibleData_ = ((other.boneVisibleData_ != null) ? other.boneVisibleData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600334F RID: 13135 RVA: 0x00081E66 File Offset: 0x00080066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleChangeRequest Clone()
		{
			return new BoneVisibleChangeRequest(this);
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06003350 RID: 13136 RVA: 0x00081E6E File Offset: 0x0008006E
		// (set) Token: 0x06003351 RID: 13137 RVA: 0x00081E76 File Offset: 0x00080076
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoneVisibleData BoneVisibleData
		{
			get
			{
				return this.boneVisibleData_;
			}
			set
			{
				this.boneVisibleData_ = value;
			}
		}

		// Token: 0x06003352 RID: 13138 RVA: 0x00081E7F File Offset: 0x0008007F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoneVisibleChangeRequest);
		}

		// Token: 0x06003353 RID: 13139 RVA: 0x00081E8D File Offset: 0x0008008D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoneVisibleChangeRequest other)
		{
			return other != null && (other == this || (object.Equals(this.BoneVisibleData, other.BoneVisibleData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003354 RID: 13140 RVA: 0x00081EC0 File Offset: 0x000800C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.boneVisibleData_ != null)
			{
				num ^= this.BoneVisibleData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003355 RID: 13141 RVA: 0x00081EFC File Offset: 0x000800FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003356 RID: 13142 RVA: 0x00081F09 File Offset: 0x00080109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003357 RID: 13143 RVA: 0x00081F12 File Offset: 0x00080112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.boneVisibleData_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.BoneVisibleData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003358 RID: 13144 RVA: 0x00081F44 File Offset: 0x00080144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.boneVisibleData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BoneVisibleData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003359 RID: 13145 RVA: 0x00081F84 File Offset: 0x00080184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoneVisibleChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.boneVisibleData_ != null)
			{
				if (this.boneVisibleData_ == null)
				{
					this.BoneVisibleData = new BoneVisibleData();
				}
				this.BoneVisibleData.MergeFrom(other.BoneVisibleData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600335A RID: 13146 RVA: 0x00081FD8 File Offset: 0x000801D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600335B RID: 13147 RVA: 0x00081FE4 File Offset: 0x000801E4
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
					if (this.boneVisibleData_ == null)
					{
						this.BoneVisibleData = new BoneVisibleData();
					}
					input.ReadMessage(this.BoneVisibleData);
				}
			}
		}

		// Token: 0x040029B2 RID: 10674
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029B3 RID: 10675
		public const int BoneVisibleDataFieldNumber = 5;

		// Token: 0x040029B4 RID: 10676
		private BoneVisibleData boneVisibleData_;
	}
}
