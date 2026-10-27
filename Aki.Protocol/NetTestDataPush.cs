using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF4 RID: 2804
	[NetMessage(EMessageId.NetTestDataPush)]
	public sealed class NetTestDataPush : IMessage<NetTestDataPush>, IMessage, IEquatable<NetTestDataPush>, IDeepCloneable<NetTestDataPush>, IBufferMessage
	{
		// Token: 0x0600F3DD RID: 62429 RVA: 0x00239D04 File Offset: 0x00237F04
		[NullableContext(1)]
		public static NetTestDataPush Create()
		{
			return new NetTestDataPush();
		}

		// Token: 0x170031AF RID: 12719
		// (get) Token: 0x0600F3DE RID: 62430 RVA: 0x00239D0B File Offset: 0x00237F0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031B0 RID: 12720
		// (get) Token: 0x0600F3DF RID: 62431 RVA: 0x00239D0E File Offset: 0x00237F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NetTestDataPush.Descriptor;
			}
		}

		// Token: 0x0600F3E0 RID: 62432 RVA: 0x00239D15 File Offset: 0x00237F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataPush()
		{
		}

		// Token: 0x0600F3E1 RID: 62433 RVA: 0x00239D1D File Offset: 0x00237F1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataPush(NetTestDataPush other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F3E2 RID: 62434 RVA: 0x00239D52 File Offset: 0x00237F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataPush Clone()
		{
			return new NetTestDataPush(this);
		}

		// Token: 0x170031B1 RID: 12721
		// (get) Token: 0x0600F3E3 RID: 62435 RVA: 0x00239D5A File Offset: 0x00237F5A
		// (set) Token: 0x0600F3E4 RID: 62436 RVA: 0x00239D62 File Offset: 0x00237F62
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

		// Token: 0x0600F3E5 RID: 62437 RVA: 0x00239D6B File Offset: 0x00237F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NetTestDataPush);
		}

		// Token: 0x0600F3E6 RID: 62438 RVA: 0x00239D79 File Offset: 0x00237F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NetTestDataPush other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F3E7 RID: 62439 RVA: 0x00239DAC File Offset: 0x00237FAC
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

		// Token: 0x0600F3E8 RID: 62440 RVA: 0x00239DE8 File Offset: 0x00237FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F3E9 RID: 62441 RVA: 0x00239DF5 File Offset: 0x00237FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F3EA RID: 62442 RVA: 0x00239DFE File Offset: 0x00237FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F3EB RID: 62443 RVA: 0x00239E30 File Offset: 0x00238030
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

		// Token: 0x0600F3EC RID: 62444 RVA: 0x00239E70 File Offset: 0x00238070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NetTestDataPush other)
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

		// Token: 0x0600F3ED RID: 62445 RVA: 0x00239EC4 File Offset: 0x002380C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F3EE RID: 62446 RVA: 0x00239ED0 File Offset: 0x002380D0
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
				if (num != 82U)
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

		// Token: 0x0400624C RID: 25164
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400624D RID: 25165
		public const int DataFieldNumber = 10;

		// Token: 0x0400624E RID: 25166
		private NetTestData data_;
	}
}
