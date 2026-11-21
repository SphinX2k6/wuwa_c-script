using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AE2 RID: 2786
	[NetMessage(EMessageId.NetTestDataNotify)]
	public sealed class NetTestDataNotify : IMessage<NetTestDataNotify>, IMessage, IEquatable<NetTestDataNotify>, IDeepCloneable<NetTestDataNotify>, IBufferMessage
	{
		// Token: 0x0600F2B1 RID: 62129 RVA: 0x002378D6 File Offset: 0x00235AD6
		[NullableContext(1)]
		public static NetTestDataNotify Create()
		{
			return new NetTestDataNotify();
		}

		// Token: 0x1700316E RID: 12654
		// (get) Token: 0x0600F2B2 RID: 62130 RVA: 0x002378DD File Offset: 0x00235ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700316F RID: 12655
		// (get) Token: 0x0600F2B3 RID: 62131 RVA: 0x002378E0 File Offset: 0x00235AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NetTestDataNotify.Descriptor;
			}
		}

		// Token: 0x0600F2B4 RID: 62132 RVA: 0x002378E7 File Offset: 0x00235AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataNotify()
		{
		}

		// Token: 0x0600F2B5 RID: 62133 RVA: 0x002378EF File Offset: 0x00235AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataNotify(NetTestDataNotify other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F2B6 RID: 62134 RVA: 0x00237924 File Offset: 0x00235B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataNotify Clone()
		{
			return new NetTestDataNotify(this);
		}

		// Token: 0x17003170 RID: 12656
		// (get) Token: 0x0600F2B7 RID: 62135 RVA: 0x0023792C File Offset: 0x00235B2C
		// (set) Token: 0x0600F2B8 RID: 62136 RVA: 0x00237934 File Offset: 0x00235B34
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

		// Token: 0x0600F2B9 RID: 62137 RVA: 0x0023793D File Offset: 0x00235B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NetTestDataNotify);
		}

		// Token: 0x0600F2BA RID: 62138 RVA: 0x0023794B File Offset: 0x00235B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NetTestDataNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F2BB RID: 62139 RVA: 0x00237980 File Offset: 0x00235B80
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

		// Token: 0x0600F2BC RID: 62140 RVA: 0x002379BC File Offset: 0x00235BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F2BD RID: 62141 RVA: 0x002379C9 File Offset: 0x00235BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F2BE RID: 62142 RVA: 0x002379D2 File Offset: 0x00235BD2
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

		// Token: 0x0600F2BF RID: 62143 RVA: 0x00237A04 File Offset: 0x00235C04
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

		// Token: 0x0600F2C0 RID: 62144 RVA: 0x00237A44 File Offset: 0x00235C44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NetTestDataNotify other)
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

		// Token: 0x0600F2C1 RID: 62145 RVA: 0x00237A98 File Offset: 0x00235C98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F2C2 RID: 62146 RVA: 0x00237AA4 File Offset: 0x00235CA4
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

		// Token: 0x04006252 RID: 25170
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006253 RID: 25171
		public const int DataFieldNumber = 5;

		// Token: 0x04006254 RID: 25172
		private NetTestData data_;
	}
}
