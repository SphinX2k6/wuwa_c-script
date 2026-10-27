using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003A7 RID: 935
	[NetMessage(EMessageId.DarkTideItemMarkRequest)]
	public sealed class DarkTideItemMarkRequest : IMessage<DarkTideItemMarkRequest>, IMessage, IEquatable<DarkTideItemMarkRequest>, IDeepCloneable<DarkTideItemMarkRequest>, IBufferMessage
	{
		// Token: 0x06005BF5 RID: 23541 RVA: 0x000DF7C0 File Offset: 0x000DD9C0
		[NullableContext(1)]
		public static DarkTideItemMarkRequest Create()
		{
			return new DarkTideItemMarkRequest();
		}

		// Token: 0x1700110A RID: 4362
		// (get) Token: 0x06005BF6 RID: 23542 RVA: 0x000DF7C7 File Offset: 0x000DD9C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700110B RID: 4363
		// (get) Token: 0x06005BF7 RID: 23543 RVA: 0x000DF7CA File Offset: 0x000DD9CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTideItemMarkRequest.Descriptor;
			}
		}

		// Token: 0x06005BF8 RID: 23544 RVA: 0x000DF7D1 File Offset: 0x000DD9D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideItemMarkRequest()
		{
		}

		// Token: 0x06005BF9 RID: 23545 RVA: 0x000DF7D9 File Offset: 0x000DD9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideItemMarkRequest(DarkTideItemMarkRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this.isCancel_ = other.isCancel_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005BFA RID: 23546 RVA: 0x000DF80A File Offset: 0x000DDA0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTideItemMarkRequest Clone()
		{
			return new DarkTideItemMarkRequest(this);
		}

		// Token: 0x1700110C RID: 4364
		// (get) Token: 0x06005BFB RID: 23547 RVA: 0x000DF812 File Offset: 0x000DDA12
		// (set) Token: 0x06005BFC RID: 23548 RVA: 0x000DF81A File Offset: 0x000DDA1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x1700110D RID: 4365
		// (get) Token: 0x06005BFD RID: 23549 RVA: 0x000DF823 File Offset: 0x000DDA23
		// (set) Token: 0x06005BFE RID: 23550 RVA: 0x000DF82B File Offset: 0x000DDA2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsCancel
		{
			get
			{
				return this.isCancel_;
			}
			set
			{
				this.isCancel_ = value;
			}
		}

		// Token: 0x06005BFF RID: 23551 RVA: 0x000DF834 File Offset: 0x000DDA34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTideItemMarkRequest);
		}

		// Token: 0x06005C00 RID: 23552 RVA: 0x000DF842 File Offset: 0x000DDA42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTideItemMarkRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && this.IsCancel == other.IsCancel && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005C01 RID: 23553 RVA: 0x000DF880 File Offset: 0x000DDA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this.IsCancel)
			{
				num ^= this.IsCancel.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005C02 RID: 23554 RVA: 0x000DF8D8 File Offset: 0x000DDAD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005C03 RID: 23555 RVA: 0x000DF8E5 File Offset: 0x000DDAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005C04 RID: 23556 RVA: 0x000DF8F0 File Offset: 0x000DDAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsCancel)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsCancel);
			}
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005C05 RID: 23557 RVA: 0x000DF94C File Offset: 0x000DDB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this.IsCancel)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005C06 RID: 23558 RVA: 0x000DF998 File Offset: 0x000DDB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTideItemMarkRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			if (other.IsCancel)
			{
				this.IsCancel = other.IsCancel;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005C07 RID: 23559 RVA: 0x000DF9E8 File Offset: 0x000DDBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005C08 RID: 23560 RVA: 0x000DF9F4 File Offset: 0x000DDBF4
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
				if (num != 88U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityIncId = input.ReadInt64();
					}
				}
				else
				{
					this.IsCancel = input.ReadBool();
				}
			}
		}

		// Token: 0x04003624 RID: 13860
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003625 RID: 13861
		public const int EntityIncIdFieldNumber = 14;

		// Token: 0x04003626 RID: 13862
		private long entityIncId_;

		// Token: 0x04003627 RID: 13863
		public const int IsCancelFieldNumber = 11;

		// Token: 0x04003628 RID: 13864
		private bool isCancel_;
	}
}
