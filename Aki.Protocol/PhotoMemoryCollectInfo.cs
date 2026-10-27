using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D33 RID: 3379
	public sealed class PhotoMemoryCollectInfo : IMessage<PhotoMemoryCollectInfo>, IMessage, IEquatable<PhotoMemoryCollectInfo>, IDeepCloneable<PhotoMemoryCollectInfo>, IBufferMessage
	{
		// Token: 0x060123E0 RID: 74720 RVA: 0x002A9E92 File Offset: 0x002A8092
		[NullableContext(1)]
		public static PhotoMemoryCollectInfo Create()
		{
			return new PhotoMemoryCollectInfo();
		}

		// Token: 0x17003C74 RID: 15476
		// (get) Token: 0x060123E1 RID: 74721 RVA: 0x002A9E99 File Offset: 0x002A8099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhotoMemoryCollectInfo> Parser
		{
			get
			{
				return PhotoMemoryCollectInfo._parser;
			}
		}

		// Token: 0x17003C75 RID: 15477
		// (get) Token: 0x060123E2 RID: 74722 RVA: 0x002A9EA0 File Offset: 0x002A80A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C76 RID: 15478
		// (get) Token: 0x060123E3 RID: 74723 RVA: 0x002A9EA3 File Offset: 0x002A80A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryCollectInfo.Descriptor;
			}
		}

		// Token: 0x060123E4 RID: 74724 RVA: 0x002A9EAA File Offset: 0x002A80AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryCollectInfo()
		{
		}

		// Token: 0x060123E5 RID: 74725 RVA: 0x002A9EB2 File Offset: 0x002A80B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryCollectInfo(PhotoMemoryCollectInfo other) : this()
		{
			this.id_ = other.id_;
			this.flag_ = other.flag_;
			this.collectTime_ = other.collectTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060123E6 RID: 74726 RVA: 0x002A9EEF File Offset: 0x002A80EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryCollectInfo Clone()
		{
			return new PhotoMemoryCollectInfo(this);
		}

		// Token: 0x17003C77 RID: 15479
		// (get) Token: 0x060123E7 RID: 74727 RVA: 0x002A9EF7 File Offset: 0x002A80F7
		// (set) Token: 0x060123E8 RID: 74728 RVA: 0x002A9EFF File Offset: 0x002A80FF
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

		// Token: 0x17003C78 RID: 15480
		// (get) Token: 0x060123E9 RID: 74729 RVA: 0x002A9F08 File Offset: 0x002A8108
		// (set) Token: 0x060123EA RID: 74730 RVA: 0x002A9F10 File Offset: 0x002A8110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Flag
		{
			get
			{
				return this.flag_;
			}
			set
			{
				this.flag_ = value;
			}
		}

		// Token: 0x17003C79 RID: 15481
		// (get) Token: 0x060123EB RID: 74731 RVA: 0x002A9F19 File Offset: 0x002A8119
		// (set) Token: 0x060123EC RID: 74732 RVA: 0x002A9F21 File Offset: 0x002A8121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CollectTime
		{
			get
			{
				return this.collectTime_;
			}
			set
			{
				this.collectTime_ = value;
			}
		}

		// Token: 0x060123ED RID: 74733 RVA: 0x002A9F2A File Offset: 0x002A812A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryCollectInfo);
		}

		// Token: 0x060123EE RID: 74734 RVA: 0x002A9F38 File Offset: 0x002A8138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryCollectInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Flag == other.Flag && this.CollectTime == other.CollectTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060123EF RID: 74735 RVA: 0x002A9F94 File Offset: 0x002A8194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Flag != 0)
			{
				num ^= this.Flag.GetHashCode();
			}
			if (this.CollectTime != 0L)
			{
				num ^= this.CollectTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060123F0 RID: 74736 RVA: 0x002AA005 File Offset: 0x002A8205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060123F1 RID: 74737 RVA: 0x002AA012 File Offset: 0x002A8212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060123F2 RID: 74738 RVA: 0x002AA01C File Offset: 0x002A821C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Flag != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Flag);
			}
			if (this.CollectTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.CollectTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060123F3 RID: 74739 RVA: 0x002AA090 File Offset: 0x002A8290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Flag != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Flag);
			}
			if (this.CollectTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CollectTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060123F4 RID: 74740 RVA: 0x002AA100 File Offset: 0x002A8300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoMemoryCollectInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Flag != 0)
			{
				this.Flag = other.Flag;
			}
			if (other.CollectTime != 0L)
			{
				this.CollectTime = other.CollectTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060123F5 RID: 74741 RVA: 0x002AA164 File Offset: 0x002A8364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060123F6 RID: 74742 RVA: 0x002AA170 File Offset: 0x002A8370
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CollectTime = input.ReadInt64();
						}
					}
					else
					{
						this.Flag = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040071DC RID: 29148
		private static readonly MessageParser<PhotoMemoryCollectInfo> _parser = new MessageParser<PhotoMemoryCollectInfo>(() => new PhotoMemoryCollectInfo());

		// Token: 0x040071DD RID: 29149
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071DE RID: 29150
		public const int IdFieldNumber = 1;

		// Token: 0x040071DF RID: 29151
		private int id_;

		// Token: 0x040071E0 RID: 29152
		public const int FlagFieldNumber = 2;

		// Token: 0x040071E1 RID: 29153
		private int flag_;

		// Token: 0x040071E2 RID: 29154
		public const int CollectTimeFieldNumber = 3;

		// Token: 0x040071E3 RID: 29155
		private long collectTime_;
	}
}
