using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000003 RID: 3
	public sealed class NormalItem : IProto_NormalItem, IMessage<NormalItem>, IMessage, IEquatable<NormalItem>, IDeepCloneable<NormalItem>, IBufferMessage
	{
		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		[NullableContext(1)]
		public static NormalItem Create()
		{
			return new NormalItem();
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002057 File Offset: 0x00000257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<NormalItem> Parser
		{
			get
			{
				return NormalItem._parser;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000006 RID: 6 RVA: 0x0000205E File Offset: 0x0000025E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002061 File Offset: 0x00000261
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NormalItem.Descriptor;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002068 File Offset: 0x00000268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItem()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002070 File Offset: 0x00000270
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItem(NormalItem other) : this()
		{
			this.id_ = other.id_;
			this.count_ = other.count_;
			this.expireTime_ = other.expireTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020AD File Offset: 0x000002AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NormalItem Clone()
		{
			return new NormalItem(this);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000020B5 File Offset: 0x000002B5
		// (set) Token: 0x0600000C RID: 12 RVA: 0x000020BD File Offset: 0x000002BD
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

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020C6 File Offset: 0x000002C6
		// (set) Token: 0x0600000E RID: 14 RVA: 0x000020CE File Offset: 0x000002CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Count
		{
			get
			{
				return this.count_;
			}
			set
			{
				this.count_ = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000020D7 File Offset: 0x000002D7
		// (set) Token: 0x06000010 RID: 16 RVA: 0x000020DF File Offset: 0x000002DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long ExpireTime
		{
			get
			{
				return this.expireTime_;
			}
			set
			{
				this.expireTime_ = value;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020E8 File Offset: 0x000002E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NormalItem);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000020F8 File Offset: 0x000002F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NormalItem other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Count == other.Count && this.ExpireTime == other.ExpireTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002154 File Offset: 0x00000354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Count != 0)
			{
				num ^= this.Count.GetHashCode();
			}
			if (this.ExpireTime != 0L)
			{
				num ^= this.ExpireTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000021C5 File Offset: 0x000003C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000021D2 File Offset: 0x000003D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000021DC File Offset: 0x000003DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Count);
			}
			if (this.ExpireTime != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.ExpireTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002250 File Offset: 0x00000450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Count != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Count);
			}
			if (this.ExpireTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.ExpireTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000022C0 File Offset: 0x000004C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NormalItem other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Count != 0)
			{
				this.Count = other.Count;
			}
			if (other.ExpireTime != 0L)
			{
				this.ExpireTime = other.ExpireTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002324 File Offset: 0x00000524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002330 File Offset: 0x00000530
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 32U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ExpireTime = input.ReadInt64();
						}
					}
					else
					{
						this.Count = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04000001 RID: 1
		private static readonly MessageParser<NormalItem> _parser = new MessageParser<NormalItem>(() => new NormalItem());

		// Token: 0x04000002 RID: 2
		private UnknownFieldSet _unknownFields;

		// Token: 0x04000003 RID: 3
		public const int IdFieldNumber = 1;

		// Token: 0x04000004 RID: 4
		private int id_;

		// Token: 0x04000005 RID: 5
		public const int CountFieldNumber = 2;

		// Token: 0x04000006 RID: 6
		private int count_;

		// Token: 0x04000007 RID: 7
		public const int ExpireTimeFieldNumber = 4;

		// Token: 0x04000008 RID: 8
		private long expireTime_;
	}
}
