using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE3 RID: 2787
	[NetMessage(EMessageId.NetTestDataPush)]
	public sealed class NetTestDataPush : IMessage<NetTestDataPush>, IMessage, IEquatable<NetTestDataPush>, IDeepCloneable<NetTestDataPush>, IBufferMessage
	{
		// Token: 0x0600F2C3 RID: 62147 RVA: 0x00237AFC File Offset: 0x00235CFC
		[NullableContext(1)]
		public static NetTestDataPush Create()
		{
			return new NetTestDataPush();
		}

		// Token: 0x17003171 RID: 12657
		// (get) Token: 0x0600F2C4 RID: 62148 RVA: 0x00237B03 File Offset: 0x00235D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003172 RID: 12658
		// (get) Token: 0x0600F2C5 RID: 62149 RVA: 0x00237B06 File Offset: 0x00235D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NetTestDataPush.Descriptor;
			}
		}

		// Token: 0x0600F2C6 RID: 62150 RVA: 0x00237B0D File Offset: 0x00235D0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataPush()
		{
		}

		// Token: 0x0600F2C7 RID: 62151 RVA: 0x00237B15 File Offset: 0x00235D15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataPush(NetTestDataPush other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F2C8 RID: 62152 RVA: 0x00237B4A File Offset: 0x00235D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataPush Clone()
		{
			return new NetTestDataPush(this);
		}

		// Token: 0x17003173 RID: 12659
		// (get) Token: 0x0600F2C9 RID: 62153 RVA: 0x00237B52 File Offset: 0x00235D52
		// (set) Token: 0x0600F2CA RID: 62154 RVA: 0x00237B5A File Offset: 0x00235D5A
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

		// Token: 0x0600F2CB RID: 62155 RVA: 0x00237B63 File Offset: 0x00235D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NetTestDataPush);
		}

		// Token: 0x0600F2CC RID: 62156 RVA: 0x00237B71 File Offset: 0x00235D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NetTestDataPush other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F2CD RID: 62157 RVA: 0x00237BA4 File Offset: 0x00235DA4
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

		// Token: 0x0600F2CE RID: 62158 RVA: 0x00237BE0 File Offset: 0x00235DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F2CF RID: 62159 RVA: 0x00237BED File Offset: 0x00235DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F2D0 RID: 62160 RVA: 0x00237BF6 File Offset: 0x00235DF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F2D1 RID: 62161 RVA: 0x00237C28 File Offset: 0x00235E28
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

		// Token: 0x0600F2D2 RID: 62162 RVA: 0x00237C68 File Offset: 0x00235E68
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

		// Token: 0x0600F2D3 RID: 62163 RVA: 0x00237CBC File Offset: 0x00235EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F2D4 RID: 62164 RVA: 0x00237CC8 File Offset: 0x00235EC8
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
				if (num != 34U)
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

		// Token: 0x04006255 RID: 25173
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006256 RID: 25174
		public const int DataFieldNumber = 4;

		// Token: 0x04006257 RID: 25175
		private NetTestData data_;
	}
}
