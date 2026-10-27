using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200077E RID: 1918
	public sealed class HonamiStoryItemCollectionInfo : IMessage<HonamiStoryItemCollectionInfo>, IMessage, IEquatable<HonamiStoryItemCollectionInfo>, IDeepCloneable<HonamiStoryItemCollectionInfo>, IBufferMessage
	{
		// Token: 0x0600AD56 RID: 44374 RVA: 0x001A0C09 File Offset: 0x0019EE09
		[NullableContext(1)]
		public static HonamiStoryItemCollectionInfo Create()
		{
			return new HonamiStoryItemCollectionInfo();
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x0600AD57 RID: 44375 RVA: 0x001A0C10 File Offset: 0x0019EE10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryItemCollectionInfo> Parser
		{
			get
			{
				return HonamiStoryItemCollectionInfo._parser;
			}
		}

		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x0600AD58 RID: 44376 RVA: 0x001A0C17 File Offset: 0x0019EE17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x0600AD59 RID: 44377 RVA: 0x001A0C1A File Offset: 0x0019EE1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryItemCollectionInfo.Descriptor;
			}
		}

		// Token: 0x0600AD5A RID: 44378 RVA: 0x001A0C21 File Offset: 0x0019EE21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionInfo()
		{
		}

		// Token: 0x0600AD5B RID: 44379 RVA: 0x001A0C29 File Offset: 0x0019EE29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionInfo(HonamiStoryItemCollectionInfo other) : this()
		{
			this.honamiStoryItemId_ = other.honamiStoryItemId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD5C RID: 44380 RVA: 0x001A0C5A File Offset: 0x0019EE5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionInfo Clone()
		{
			return new HonamiStoryItemCollectionInfo(this);
		}

		// Token: 0x170022FA RID: 8954
		// (get) Token: 0x0600AD5D RID: 44381 RVA: 0x001A0C62 File Offset: 0x0019EE62
		// (set) Token: 0x0600AD5E RID: 44382 RVA: 0x001A0C6A File Offset: 0x0019EE6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HonamiStoryItemId
		{
			get
			{
				return this.honamiStoryItemId_;
			}
			set
			{
				this.honamiStoryItemId_ = value;
			}
		}

		// Token: 0x170022FB RID: 8955
		// (get) Token: 0x0600AD5F RID: 44383 RVA: 0x001A0C73 File Offset: 0x0019EE73
		// (set) Token: 0x0600AD60 RID: 44384 RVA: 0x001A0C7B File Offset: 0x0019EE7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x0600AD61 RID: 44385 RVA: 0x001A0C84 File Offset: 0x0019EE84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryItemCollectionInfo);
		}

		// Token: 0x0600AD62 RID: 44386 RVA: 0x001A0C92 File Offset: 0x0019EE92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryItemCollectionInfo other)
		{
			return other != null && (other == this || (this.HonamiStoryItemId == other.HonamiStoryItemId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD63 RID: 44387 RVA: 0x001A0CD0 File Offset: 0x0019EED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HonamiStoryItemId != 0)
			{
				num ^= this.HonamiStoryItemId.GetHashCode();
			}
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AD64 RID: 44388 RVA: 0x001A0D28 File Offset: 0x0019EF28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD65 RID: 44389 RVA: 0x001A0D35 File Offset: 0x0019EF35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD66 RID: 44390 RVA: 0x001A0D40 File Offset: 0x0019EF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HonamiStoryItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HonamiStoryItemId);
			}
			if (this.Status != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Status);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD67 RID: 44391 RVA: 0x001A0D98 File Offset: 0x0019EF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HonamiStoryItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HonamiStoryItemId);
			}
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD68 RID: 44392 RVA: 0x001A0DF0 File Offset: 0x0019EFF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryItemCollectionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HonamiStoryItemId != 0)
			{
				this.HonamiStoryItemId = other.HonamiStoryItemId;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD69 RID: 44393 RVA: 0x001A0E40 File Offset: 0x0019F040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD6A RID: 44394 RVA: 0x001A0E4C File Offset: 0x0019F04C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Status = input.ReadInt32();
					}
				}
				else
				{
					this.HonamiStoryItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004E6C RID: 20076
		private static readonly MessageParser<HonamiStoryItemCollectionInfo> _parser = new MessageParser<HonamiStoryItemCollectionInfo>(() => new HonamiStoryItemCollectionInfo());

		// Token: 0x04004E6D RID: 20077
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E6E RID: 20078
		public const int HonamiStoryItemIdFieldNumber = 1;

		// Token: 0x04004E6F RID: 20079
		private int honamiStoryItemId_;

		// Token: 0x04004E70 RID: 20080
		public const int StatusFieldNumber = 2;

		// Token: 0x04004E71 RID: 20081
		private int status_;
	}
}
