using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AF3 RID: 2803
	[NetMessage(EMessageId.NetTestDataNotify)]
	public sealed class NetTestDataNotify : IMessage<NetTestDataNotify>, IMessage, IEquatable<NetTestDataNotify>, IDeepCloneable<NetTestDataNotify>, IBufferMessage
	{
		// Token: 0x0600F3CB RID: 62411 RVA: 0x00239ADE File Offset: 0x00237CDE
		[NullableContext(1)]
		public static NetTestDataNotify Create()
		{
			return new NetTestDataNotify();
		}

		// Token: 0x170031AC RID: 12716
		// (get) Token: 0x0600F3CC RID: 62412 RVA: 0x00239AE5 File Offset: 0x00237CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031AD RID: 12717
		// (get) Token: 0x0600F3CD RID: 62413 RVA: 0x00239AE8 File Offset: 0x00237CE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NetTestDataNotify.Descriptor;
			}
		}

		// Token: 0x0600F3CE RID: 62414 RVA: 0x00239AEF File Offset: 0x00237CEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataNotify()
		{
		}

		// Token: 0x0600F3CF RID: 62415 RVA: 0x00239AF7 File Offset: 0x00237CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataNotify(NetTestDataNotify other) : this()
		{
			this.data_ = ((other.data_ != null) ? other.data_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F3D0 RID: 62416 RVA: 0x00239B2C File Offset: 0x00237D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NetTestDataNotify Clone()
		{
			return new NetTestDataNotify(this);
		}

		// Token: 0x170031AE RID: 12718
		// (get) Token: 0x0600F3D1 RID: 62417 RVA: 0x00239B34 File Offset: 0x00237D34
		// (set) Token: 0x0600F3D2 RID: 62418 RVA: 0x00239B3C File Offset: 0x00237D3C
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

		// Token: 0x0600F3D3 RID: 62419 RVA: 0x00239B45 File Offset: 0x00237D45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NetTestDataNotify);
		}

		// Token: 0x0600F3D4 RID: 62420 RVA: 0x00239B53 File Offset: 0x00237D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NetTestDataNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Data, other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F3D5 RID: 62421 RVA: 0x00239B88 File Offset: 0x00237D88
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

		// Token: 0x0600F3D6 RID: 62422 RVA: 0x00239BC4 File Offset: 0x00237DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F3D7 RID: 62423 RVA: 0x00239BD1 File Offset: 0x00237DD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F3D8 RID: 62424 RVA: 0x00239BDA File Offset: 0x00237DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.data_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Data);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F3D9 RID: 62425 RVA: 0x00239C0C File Offset: 0x00237E0C
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

		// Token: 0x0600F3DA RID: 62426 RVA: 0x00239C4C File Offset: 0x00237E4C
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

		// Token: 0x0600F3DB RID: 62427 RVA: 0x00239CA0 File Offset: 0x00237EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F3DC RID: 62428 RVA: 0x00239CAC File Offset: 0x00237EAC
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
				if (num != 50U)
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

		// Token: 0x04006249 RID: 25161
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400624A RID: 25162
		public const int DataFieldNumber = 6;

		// Token: 0x0400624B RID: 25163
		private NetTestData data_;
	}
}
