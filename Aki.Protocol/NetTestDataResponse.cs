using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF6 RID: 2806
	[NetMessage(EMessageId.NetTestDataResponse)]
	public sealed class NetTestDataResponse : IMessage<NetTestDataResponse>, IMessage, IEquatable<NetTestDataResponse>, IDeepCloneable<NetTestDataResponse>, IBufferMessage
	{
		// Token: 0x0600F401 RID: 62465 RVA: 0x0023A14C File Offset: 0x0023834C
		[NullableContext(1)]
		public static NetTestDataResponse Create()
		{
			return new NetTestDataResponse();
		}

		// Token: 0x170031B5 RID: 12725
		// (get) Token: 0x0600F402 RID: 62466 RVA: 0x0023A153 File Offset: 0x00238353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031B6 RID: 12726
		// (get) Token: 0x0600F403 RID: 62467 RVA: 0x0023A156 File Offset: 0x00238356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NetTestDataResponse.Descriptor;
			}
		}

		// Token: 0x0600F404 RID: 62468 RVA: 0x0023A15D File Offset: 0x0023835D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataResponse()
		{
		}

		// Token: 0x0600F405 RID: 62469 RVA: 0x0023A165 File Offset: 0x00238365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataResponse(NetTestDataResponse other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F406 RID: 62470 RVA: 0x0023A19A File Offset: 0x0023839A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataResponse Clone()
		{
			return new NetTestDataResponse(this);
		}

		// Token: 0x170031B7 RID: 12727
		// (get) Token: 0x0600F407 RID: 62471 RVA: 0x0023A1A2 File Offset: 0x002383A2
		// (set) Token: 0x0600F408 RID: 62472 RVA: 0x0023A1AA File Offset: 0x002383AA
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

		// Token: 0x0600F409 RID: 62473 RVA: 0x0023A1B3 File Offset: 0x002383B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NetTestDataResponse);
		}

		// Token: 0x0600F40A RID: 62474 RVA: 0x0023A1C1 File Offset: 0x002383C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NetTestDataResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F40B RID: 62475 RVA: 0x0023A1F4 File Offset: 0x002383F4
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

		// Token: 0x0600F40C RID: 62476 RVA: 0x0023A230 File Offset: 0x00238430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F40D RID: 62477 RVA: 0x0023A23D File Offset: 0x0023843D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F40E RID: 62478 RVA: 0x0023A246 File Offset: 0x00238446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F40F RID: 62479 RVA: 0x0023A278 File Offset: 0x00238478
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

		// Token: 0x0600F410 RID: 62480 RVA: 0x0023A2B8 File Offset: 0x002384B8
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

		// Token: 0x0600F411 RID: 62481 RVA: 0x0023A30C File Offset: 0x0023850C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F412 RID: 62482 RVA: 0x0023A318 File Offset: 0x00238518
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
				if (num != 98U)
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

		// Token: 0x04006252 RID: 25170
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006253 RID: 25171
		public const int DataFieldNumber = 12;

		// Token: 0x04006254 RID: 25172
		private NetTestData data_;
	}
}
