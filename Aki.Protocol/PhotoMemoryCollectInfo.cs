using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D23 RID: 3363
	public sealed class PhotoMemoryCollectInfo : IMessage<PhotoMemoryCollectInfo>, IMessage, IEquatable<PhotoMemoryCollectInfo>, IDeepCloneable<PhotoMemoryCollectInfo>, IBufferMessage
	{
		// Token: 0x060122E4 RID: 74468 RVA: 0x002A826A File Offset: 0x002A646A
		[NullableContext(1)]
		public static PhotoMemoryCollectInfo Create()
		{
			return new PhotoMemoryCollectInfo();
		}

		// Token: 0x17003C3F RID: 15423
		// (get) Token: 0x060122E5 RID: 74469 RVA: 0x002A8271 File Offset: 0x002A6471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhotoMemoryCollectInfo> Parser
		{
			get
			{
				return PhotoMemoryCollectInfo._parser;
			}
		}

		// Token: 0x17003C40 RID: 15424
		// (get) Token: 0x060122E6 RID: 74470 RVA: 0x002A8278 File Offset: 0x002A6478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C41 RID: 15425
		// (get) Token: 0x060122E7 RID: 74471 RVA: 0x002A827B File Offset: 0x002A647B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoMemoryCollectInfo.Descriptor;
			}
		}

		// Token: 0x060122E8 RID: 74472 RVA: 0x002A8282 File Offset: 0x002A6482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryCollectInfo()
		{
		}

		// Token: 0x060122E9 RID: 74473 RVA: 0x002A828A File Offset: 0x002A648A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryCollectInfo(PhotoMemoryCollectInfo other) : this()
		{
			this.id_ = other.id_;
			this.flag_ = other.flag_;
			this.collectTime_ = other.collectTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060122EA RID: 74474 RVA: 0x002A82C7 File Offset: 0x002A64C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoMemoryCollectInfo Clone()
		{
			return new PhotoMemoryCollectInfo(this);
		}

		// Token: 0x17003C42 RID: 15426
		// (get) Token: 0x060122EB RID: 74475 RVA: 0x002A82CF File Offset: 0x002A64CF
		// (set) Token: 0x060122EC RID: 74476 RVA: 0x002A82D7 File Offset: 0x002A64D7
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

		// Token: 0x17003C43 RID: 15427
		// (get) Token: 0x060122ED RID: 74477 RVA: 0x002A82E0 File Offset: 0x002A64E0
		// (set) Token: 0x060122EE RID: 74478 RVA: 0x002A82E8 File Offset: 0x002A64E8
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

		// Token: 0x17003C44 RID: 15428
		// (get) Token: 0x060122EF RID: 74479 RVA: 0x002A82F1 File Offset: 0x002A64F1
		// (set) Token: 0x060122F0 RID: 74480 RVA: 0x002A82F9 File Offset: 0x002A64F9
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

		// Token: 0x060122F1 RID: 74481 RVA: 0x002A8302 File Offset: 0x002A6502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoMemoryCollectInfo);
		}

		// Token: 0x060122F2 RID: 74482 RVA: 0x002A8310 File Offset: 0x002A6510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoMemoryCollectInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Flag == other.Flag && this.CollectTime == other.CollectTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060122F3 RID: 74483 RVA: 0x002A836C File Offset: 0x002A656C
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

		// Token: 0x060122F4 RID: 74484 RVA: 0x002A83DD File Offset: 0x002A65DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060122F5 RID: 74485 RVA: 0x002A83EA File Offset: 0x002A65EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060122F6 RID: 74486 RVA: 0x002A83F4 File Offset: 0x002A65F4
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

		// Token: 0x060122F7 RID: 74487 RVA: 0x002A8468 File Offset: 0x002A6668
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

		// Token: 0x060122F8 RID: 74488 RVA: 0x002A84D8 File Offset: 0x002A66D8
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

		// Token: 0x060122F9 RID: 74489 RVA: 0x002A853C File Offset: 0x002A673C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060122FA RID: 74490 RVA: 0x002A8548 File Offset: 0x002A6748
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

		// Token: 0x040071F4 RID: 29172
		private static readonly MessageParser<PhotoMemoryCollectInfo> _parser = new MessageParser<PhotoMemoryCollectInfo>(() => new PhotoMemoryCollectInfo());

		// Token: 0x040071F5 RID: 29173
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071F6 RID: 29174
		public const int IdFieldNumber = 1;

		// Token: 0x040071F7 RID: 29175
		private int id_;

		// Token: 0x040071F8 RID: 29176
		public const int FlagFieldNumber = 2;

		// Token: 0x040071F9 RID: 29177
		private int flag_;

		// Token: 0x040071FA RID: 29178
		public const int CollectTimeFieldNumber = 3;

		// Token: 0x040071FB RID: 29179
		private long collectTime_;
	}
}
