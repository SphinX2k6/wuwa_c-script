using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001236 RID: 4662
	[NetMessage(EMessageId.ShopUpdateRequest)]
	public sealed class ShopUpdateRequest : IMessage<ShopUpdateRequest>, IMessage, IEquatable<ShopUpdateRequest>, IDeepCloneable<ShopUpdateRequest>, IBufferMessage
	{
		// Token: 0x06018E6F RID: 101999 RVA: 0x003A1821 File Offset: 0x0039FA21
		[NullableContext(1)]
		public static ShopUpdateRequest Create()
		{
			return new ShopUpdateRequest();
		}

		// Token: 0x17005426 RID: 21542
		// (get) Token: 0x06018E70 RID: 102000 RVA: 0x003A1828 File Offset: 0x0039FA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005427 RID: 21543
		// (get) Token: 0x06018E71 RID: 102001 RVA: 0x003A182B File Offset: 0x0039FA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopUpdateRequest.Descriptor;
			}
		}

		// Token: 0x06018E72 RID: 102002 RVA: 0x003A1832 File Offset: 0x0039FA32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUpdateRequest()
		{
		}

		// Token: 0x06018E73 RID: 102003 RVA: 0x003A183A File Offset: 0x0039FA3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUpdateRequest(ShopUpdateRequest other) : this()
		{
			this.shopId_ = other.shopId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018E74 RID: 102004 RVA: 0x003A185F File Offset: 0x0039FA5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUpdateRequest Clone()
		{
			return new ShopUpdateRequest(this);
		}

		// Token: 0x17005428 RID: 21544
		// (get) Token: 0x06018E75 RID: 102005 RVA: 0x003A1867 File Offset: 0x0039FA67
		// (set) Token: 0x06018E76 RID: 102006 RVA: 0x003A186F File Offset: 0x0039FA6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShopId
		{
			get
			{
				return this.shopId_;
			}
			set
			{
				this.shopId_ = value;
			}
		}

		// Token: 0x06018E77 RID: 102007 RVA: 0x003A1878 File Offset: 0x0039FA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopUpdateRequest);
		}

		// Token: 0x06018E78 RID: 102008 RVA: 0x003A1886 File Offset: 0x0039FA86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopUpdateRequest other)
		{
			return other != null && (other == this || (this.ShopId == other.ShopId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018E79 RID: 102009 RVA: 0x003A18B4 File Offset: 0x0039FAB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ShopId != 0)
			{
				num ^= this.ShopId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018E7A RID: 102010 RVA: 0x003A18F3 File Offset: 0x0039FAF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018E7B RID: 102011 RVA: 0x003A1900 File Offset: 0x0039FB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018E7C RID: 102012 RVA: 0x003A1909 File Offset: 0x0039FB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ShopId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ShopId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018E7D RID: 102013 RVA: 0x003A193C File Offset: 0x0039FB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ShopId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShopId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018E7E RID: 102014 RVA: 0x003A197A File Offset: 0x0039FB7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopUpdateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ShopId != 0)
			{
				this.ShopId = other.ShopId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018E7F RID: 102015 RVA: 0x003A19AB File Offset: 0x0039FBAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018E80 RID: 102016 RVA: 0x003A19B4 File Offset: 0x0039FBB4
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ShopId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040093C0 RID: 37824
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093C1 RID: 37825
		public const int ShopIdFieldNumber = 13;

		// Token: 0x040093C2 RID: 37826
		private int shopId_;
	}
}
