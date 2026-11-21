using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE4 RID: 2788
	[NetMessage(EMessageId.NetTestDataRequest)]
	public sealed class NetTestDataRequest : IMessage<NetTestDataRequest>, IMessage, IEquatable<NetTestDataRequest>, IDeepCloneable<NetTestDataRequest>, IBufferMessage
	{
		// Token: 0x0600F2D5 RID: 62165 RVA: 0x00237D20 File Offset: 0x00235F20
		[NullableContext(1)]
		public static NetTestDataRequest Create()
		{
			return new NetTestDataRequest();
		}

		// Token: 0x17003174 RID: 12660
		// (get) Token: 0x0600F2D6 RID: 62166 RVA: 0x00237D27 File Offset: 0x00235F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003175 RID: 12661
		// (get) Token: 0x0600F2D7 RID: 62167 RVA: 0x00237D2A File Offset: 0x00235F2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NetTestDataRequest.Descriptor;
			}
		}

		// Token: 0x0600F2D8 RID: 62168 RVA: 0x00237D31 File Offset: 0x00235F31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataRequest()
		{
		}

		// Token: 0x0600F2D9 RID: 62169 RVA: 0x00237D39 File Offset: 0x00235F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataRequest(NetTestDataRequest other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F2DA RID: 62170 RVA: 0x00237D6E File Offset: 0x00235F6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataRequest Clone()
		{
			return new NetTestDataRequest(this);
		}

		// Token: 0x17003176 RID: 12662
		// (get) Token: 0x0600F2DB RID: 62171 RVA: 0x00237D76 File Offset: 0x00235F76
		// (set) Token: 0x0600F2DC RID: 62172 RVA: 0x00237D7E File Offset: 0x00235F7E
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

		// Token: 0x0600F2DD RID: 62173 RVA: 0x00237D87 File Offset: 0x00235F87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NetTestDataRequest);
		}

		// Token: 0x0600F2DE RID: 62174 RVA: 0x00237D95 File Offset: 0x00235F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NetTestDataRequest other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F2DF RID: 62175 RVA: 0x00237DC8 File Offset: 0x00235FC8
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

		// Token: 0x0600F2E0 RID: 62176 RVA: 0x00237E04 File Offset: 0x00236004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F2E1 RID: 62177 RVA: 0x00237E11 File Offset: 0x00236011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F2E2 RID: 62178 RVA: 0x00237E1A File Offset: 0x0023601A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F2E3 RID: 62179 RVA: 0x00237E4C File Offset: 0x0023604C
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

		// Token: 0x0600F2E4 RID: 62180 RVA: 0x00237E8C File Offset: 0x0023608C
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

		// Token: 0x0600F2E5 RID: 62181 RVA: 0x00237EE0 File Offset: 0x002360E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F2E6 RID: 62182 RVA: 0x00237EEC File Offset: 0x002360EC
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
				if (num != 18U)
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

		// Token: 0x04006258 RID: 25176
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006259 RID: 25177
		public const int DataFieldNumber = 2;

		// Token: 0x0400625A RID: 25178
		private NetTestData data_;
	}
}
