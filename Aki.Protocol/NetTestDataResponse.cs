using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE5 RID: 2789
	[NetMessage(EMessageId.NetTestDataResponse)]
	public sealed class NetTestDataResponse : IMessage<NetTestDataResponse>, IMessage, IEquatable<NetTestDataResponse>, IDeepCloneable<NetTestDataResponse>, IBufferMessage
	{
		// Token: 0x0600F2E7 RID: 62183 RVA: 0x00237F44 File Offset: 0x00236144
		[NullableContext(1)]
		public static NetTestDataResponse Create()
		{
			return new NetTestDataResponse();
		}

		// Token: 0x17003177 RID: 12663
		// (get) Token: 0x0600F2E8 RID: 62184 RVA: 0x00237F4B File Offset: 0x0023614B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003178 RID: 12664
		// (get) Token: 0x0600F2E9 RID: 62185 RVA: 0x00237F4E File Offset: 0x0023614E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NetTestDataResponse.Descriptor;
			}
		}

		// Token: 0x0600F2EA RID: 62186 RVA: 0x00237F55 File Offset: 0x00236155
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataResponse()
		{
		}

		// Token: 0x0600F2EB RID: 62187 RVA: 0x00237F5D File Offset: 0x0023615D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataResponse(NetTestDataResponse other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F2EC RID: 62188 RVA: 0x00237F92 File Offset: 0x00236192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataResponse Clone()
		{
			return new NetTestDataResponse(this);
		}

		// Token: 0x17003179 RID: 12665
		// (get) Token: 0x0600F2ED RID: 62189 RVA: 0x00237F9A File Offset: 0x0023619A
		// (set) Token: 0x0600F2EE RID: 62190 RVA: 0x00237FA2 File Offset: 0x002361A2
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

		// Token: 0x0600F2EF RID: 62191 RVA: 0x00237FAB File Offset: 0x002361AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NetTestDataResponse);
		}

		// Token: 0x0600F2F0 RID: 62192 RVA: 0x00237FB9 File Offset: 0x002361B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NetTestDataResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F2F1 RID: 62193 RVA: 0x00237FEC File Offset: 0x002361EC
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

		// Token: 0x0600F2F2 RID: 62194 RVA: 0x00238028 File Offset: 0x00236228
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F2F3 RID: 62195 RVA: 0x00238035 File Offset: 0x00236235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F2F4 RID: 62196 RVA: 0x0023803E File Offset: 0x0023623E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F2F5 RID: 62197 RVA: 0x00238070 File Offset: 0x00236270
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

		// Token: 0x0600F2F6 RID: 62198 RVA: 0x002380B0 File Offset: 0x002362B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NetTestDataResponse other)
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

		// Token: 0x0600F2F7 RID: 62199 RVA: 0x00238104 File Offset: 0x00236304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F2F8 RID: 62200 RVA: 0x00238110 File Offset: 0x00236310
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
				if (num != 58U)
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

		// Token: 0x0400625B RID: 25179
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400625C RID: 25180
		public const int DataFieldNumber = 7;

		// Token: 0x0400625D RID: 25181
		private NetTestData data_;
	}
}
