using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D71 RID: 3441
	[NetMessage(EMessageId.PlayerBasicInfoGetRequest)]
	public sealed class PlayerBasicInfoGetRequest : IMessage<PlayerBasicInfoGetRequest>, IMessage, IEquatable<PlayerBasicInfoGetRequest>, IDeepCloneable<PlayerBasicInfoGetRequest>, IBufferMessage
	{
		// Token: 0x06012932 RID: 76082 RVA: 0x002B629D File Offset: 0x002B449D
		[NullableContext(1)]
		public static PlayerBasicInfoGetRequest Create()
		{
			return new PlayerBasicInfoGetRequest();
		}

		// Token: 0x17003D97 RID: 15767
		// (get) Token: 0x06012933 RID: 76083 RVA: 0x002B62A4 File Offset: 0x002B44A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D98 RID: 15768
		// (get) Token: 0x06012934 RID: 76084 RVA: 0x002B62A7 File Offset: 0x002B44A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerBasicInfoGetRequest.Descriptor;
			}
		}

		// Token: 0x06012935 RID: 76085 RVA: 0x002B62AE File Offset: 0x002B44AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfoGetRequest()
		{
		}

		// Token: 0x06012936 RID: 76086 RVA: 0x002B62B6 File Offset: 0x002B44B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfoGetRequest(PlayerBasicInfoGetRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012937 RID: 76087 RVA: 0x002B62DB File Offset: 0x002B44DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerBasicInfoGetRequest Clone()
		{
			return new PlayerBasicInfoGetRequest(this);
		}

		// Token: 0x17003D99 RID: 15769
		// (get) Token: 0x06012938 RID: 76088 RVA: 0x002B62E3 File Offset: 0x002B44E3
		// (set) Token: 0x06012939 RID: 76089 RVA: 0x002B62EB File Offset: 0x002B44EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0601293A RID: 76090 RVA: 0x002B62F4 File Offset: 0x002B44F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerBasicInfoGetRequest);
		}

		// Token: 0x0601293B RID: 76091 RVA: 0x002B6302 File Offset: 0x002B4502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerBasicInfoGetRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601293C RID: 76092 RVA: 0x002B6330 File Offset: 0x002B4530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601293D RID: 76093 RVA: 0x002B636F File Offset: 0x002B456F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601293E RID: 76094 RVA: 0x002B637C File Offset: 0x002B457C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601293F RID: 76095 RVA: 0x002B6385 File Offset: 0x002B4585
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012940 RID: 76096 RVA: 0x002B63B8 File Offset: 0x002B45B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012941 RID: 76097 RVA: 0x002B63F6 File Offset: 0x002B45F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerBasicInfoGetRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012942 RID: 76098 RVA: 0x002B6427 File Offset: 0x002B4627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012943 RID: 76099 RVA: 0x002B6430 File Offset: 0x002B4630
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
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040073B8 RID: 29624
		private UnknownFieldSet _unknownFields;

		// Token: 0x040073B9 RID: 29625
		public const int IdFieldNumber = 9;

		// Token: 0x040073BA RID: 29626
		private int id_;
	}
}
