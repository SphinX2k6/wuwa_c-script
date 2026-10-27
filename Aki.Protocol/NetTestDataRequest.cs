using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF5 RID: 2805
	[NetMessage(EMessageId.NetTestDataRequest)]
	public sealed class NetTestDataRequest : IMessage<NetTestDataRequest>, IMessage, IEquatable<NetTestDataRequest>, IDeepCloneable<NetTestDataRequest>, IBufferMessage
	{
		// Token: 0x0600F3EF RID: 62447 RVA: 0x00239F28 File Offset: 0x00238128
		[NullableContext(1)]
		public static NetTestDataRequest Create()
		{
			return new NetTestDataRequest();
		}

		// Token: 0x170031B2 RID: 12722
		// (get) Token: 0x0600F3F0 RID: 62448 RVA: 0x00239F2F File Offset: 0x0023812F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031B3 RID: 12723
		// (get) Token: 0x0600F3F1 RID: 62449 RVA: 0x00239F32 File Offset: 0x00238132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NetTestDataRequest.Descriptor;
			}
		}

		// Token: 0x0600F3F2 RID: 62450 RVA: 0x00239F39 File Offset: 0x00238139
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataRequest()
		{
		}

		// Token: 0x0600F3F3 RID: 62451 RVA: 0x00239F41 File Offset: 0x00238141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataRequest(NetTestDataRequest other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F3F4 RID: 62452 RVA: 0x00239F76 File Offset: 0x00238176
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataRequest Clone()
		{
			return new NetTestDataRequest(this);
		}

		// Token: 0x170031B4 RID: 12724
		// (get) Token: 0x0600F3F5 RID: 62453 RVA: 0x00239F7E File Offset: 0x0023817E
		// (set) Token: 0x0600F3F6 RID: 62454 RVA: 0x00239F86 File Offset: 0x00238186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestData Data
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

		// Token: 0x0600F3F7 RID: 62455 RVA: 0x00239F8F File Offset: 0x0023818F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NetTestDataRequest);
		}

		// Token: 0x0600F3F8 RID: 62456 RVA: 0x00239F9D File Offset: 0x0023819D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NetTestDataRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F3F9 RID: 62457 RVA: 0x00239FD0 File Offset: 0x002381D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.data_ != null)
			{
				num ^= this.Data.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F3FA RID: 62458 RVA: 0x0023A00C File Offset: 0x0023820C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F3FB RID: 62459 RVA: 0x0023A019 File Offset: 0x00238219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F3FC RID: 62460 RVA: 0x0023A022 File Offset: 0x00238222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F3FD RID: 62461 RVA: 0x0023A054 File Offset: 0x00238254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.data_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Data);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F3FE RID: 62462 RVA: 0x0023A094 File Offset: 0x00238294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NetTestDataRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.data_ != null)
			{
				if (this.data_ == null)
				{
					this.Data = new NetTestData();
				}
				this.Data.MergeFrom(other.Data);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F3FF RID: 62463 RVA: 0x0023A0E8 File Offset: 0x002382E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F400 RID: 62464 RVA: 0x0023A0F4 File Offset: 0x002382F4
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
					if (this.data_ == null)
					{
						this.Data = new NetTestData();
					}
					input.ReadMessage(this.Data);
				}
			}
		}

		// Token: 0x0400624F RID: 25167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006250 RID: 25168
		public const int DataFieldNumber = 5;

		// Token: 0x04006251 RID: 25169
		private NetTestData data_;
	}
}
