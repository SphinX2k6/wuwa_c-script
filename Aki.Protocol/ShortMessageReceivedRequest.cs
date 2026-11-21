using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001243 RID: 4675
	[NetMessage(EMessageId.ShortMessageReceivedRequest)]
	public sealed class ShortMessageReceivedRequest : IMessage<ShortMessageReceivedRequest>, IMessage, IEquatable<ShortMessageReceivedRequest>, IDeepCloneable<ShortMessageReceivedRequest>, IBufferMessage
	{
		// Token: 0x06018F78 RID: 102264 RVA: 0x003A3E8D File Offset: 0x003A208D
		[NullableContext(1)]
		public static ShortMessageReceivedRequest Create()
		{
			return new ShortMessageReceivedRequest();
		}

		// Token: 0x17005461 RID: 21601
		// (get) Token: 0x06018F79 RID: 102265 RVA: 0x003A3E94 File Offset: 0x003A2094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005462 RID: 21602
		// (get) Token: 0x06018F7A RID: 102266 RVA: 0x003A3E97 File Offset: 0x003A2097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShortMessageReceivedRequest.Descriptor;
			}
		}

		// Token: 0x06018F7B RID: 102267 RVA: 0x003A3E9E File Offset: 0x003A209E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReceivedRequest()
		{
		}

		// Token: 0x06018F7C RID: 102268 RVA: 0x003A3EA6 File Offset: 0x003A20A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReceivedRequest(ShortMessageReceivedRequest other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018F7D RID: 102269 RVA: 0x003A3ECB File Offset: 0x003A20CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShortMessageReceivedRequest Clone()
		{
			return new ShortMessageReceivedRequest(this);
		}

		// Token: 0x17005463 RID: 21603
		// (get) Token: 0x06018F7E RID: 102270 RVA: 0x003A3ED3 File Offset: 0x003A20D3
		// (set) Token: 0x06018F7F RID: 102271 RVA: 0x003A3EDB File Offset: 0x003A20DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x06018F80 RID: 102272 RVA: 0x003A3EE4 File Offset: 0x003A20E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShortMessageReceivedRequest);
		}

		// Token: 0x06018F81 RID: 102273 RVA: 0x003A3EF2 File Offset: 0x003A20F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShortMessageReceivedRequest other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018F82 RID: 102274 RVA: 0x003A3F20 File Offset: 0x003A2120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018F83 RID: 102275 RVA: 0x003A3F5F File Offset: 0x003A215F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018F84 RID: 102276 RVA: 0x003A3F6C File Offset: 0x003A216C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018F85 RID: 102277 RVA: 0x003A3F75 File Offset: 0x003A2175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018F86 RID: 102278 RVA: 0x003A3FA8 File Offset: 0x003A21A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018F87 RID: 102279 RVA: 0x003A3FE6 File Offset: 0x003A21E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShortMessageReceivedRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018F88 RID: 102280 RVA: 0x003A4017 File Offset: 0x003A2217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018F89 RID: 102281 RVA: 0x003A4020 File Offset: 0x003A2220
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
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009419 RID: 37913
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400941A RID: 37914
		public const int ConfigIdFieldNumber = 9;

		// Token: 0x0400941B RID: 37915
		private int configId_;
	}
}
