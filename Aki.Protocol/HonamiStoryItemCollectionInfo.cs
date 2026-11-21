using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200076A RID: 1898
	public sealed class HonamiStoryItemCollectionInfo : IMessage<HonamiStoryItemCollectionInfo>, IMessage, IEquatable<HonamiStoryItemCollectionInfo>, IDeepCloneable<HonamiStoryItemCollectionInfo>, IBufferMessage
	{
		// Token: 0x0600AC00 RID: 44032 RVA: 0x0019E1E1 File Offset: 0x0019C3E1
		[NullableContext(1)]
		public static HonamiStoryItemCollectionInfo Create()
		{
			return new HonamiStoryItemCollectionInfo();
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x0600AC01 RID: 44033 RVA: 0x0019E1E8 File Offset: 0x0019C3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryItemCollectionInfo> Parser
		{
			get
			{
				return HonamiStoryItemCollectionInfo._parser;
			}
		}

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x0600AC02 RID: 44034 RVA: 0x0019E1EF File Offset: 0x0019C3EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022AF RID: 8879
		// (get) Token: 0x0600AC03 RID: 44035 RVA: 0x0019E1F2 File Offset: 0x0019C3F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryItemCollectionInfo.Descriptor;
			}
		}

		// Token: 0x0600AC04 RID: 44036 RVA: 0x0019E1F9 File Offset: 0x0019C3F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionInfo()
		{
		}

		// Token: 0x0600AC05 RID: 44037 RVA: 0x0019E201 File Offset: 0x0019C401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionInfo(HonamiStoryItemCollectionInfo other) : this()
		{
			this.honamiStoryItemId_ = other.honamiStoryItemId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC06 RID: 44038 RVA: 0x0019E232 File Offset: 0x0019C432
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryItemCollectionInfo Clone()
		{
			return new HonamiStoryItemCollectionInfo(this);
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x0600AC07 RID: 44039 RVA: 0x0019E23A File Offset: 0x0019C43A
		// (set) Token: 0x0600AC08 RID: 44040 RVA: 0x0019E242 File Offset: 0x0019C442
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

		// Token: 0x170022B1 RID: 8881
		// (get) Token: 0x0600AC09 RID: 44041 RVA: 0x0019E24B File Offset: 0x0019C44B
		// (set) Token: 0x0600AC0A RID: 44042 RVA: 0x0019E253 File Offset: 0x0019C453
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

		// Token: 0x0600AC0B RID: 44043 RVA: 0x0019E25C File Offset: 0x0019C45C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryItemCollectionInfo);
		}

		// Token: 0x0600AC0C RID: 44044 RVA: 0x0019E26A File Offset: 0x0019C46A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryItemCollectionInfo other)
		{
			return other != null && (other == this || (this.HonamiStoryItemId == other.HonamiStoryItemId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC0D RID: 44045 RVA: 0x0019E2A8 File Offset: 0x0019C4A8
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

		// Token: 0x0600AC0E RID: 44046 RVA: 0x0019E300 File Offset: 0x0019C500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AC0F RID: 44047 RVA: 0x0019E30D File Offset: 0x0019C50D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC10 RID: 44048 RVA: 0x0019E318 File Offset: 0x0019C518
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

		// Token: 0x0600AC11 RID: 44049 RVA: 0x0019E370 File Offset: 0x0019C570
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

		// Token: 0x0600AC12 RID: 44050 RVA: 0x0019E3C8 File Offset: 0x0019C5C8
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

		// Token: 0x0600AC13 RID: 44051 RVA: 0x0019E418 File Offset: 0x0019C618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC14 RID: 44052 RVA: 0x0019E424 File Offset: 0x0019C624
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

		// Token: 0x04004E65 RID: 20069
		private static readonly MessageParser<HonamiStoryItemCollectionInfo> _parser = new MessageParser<HonamiStoryItemCollectionInfo>(() => new HonamiStoryItemCollectionInfo());

		// Token: 0x04004E66 RID: 20070
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E67 RID: 20071
		public const int HonamiStoryItemIdFieldNumber = 1;

		// Token: 0x04004E68 RID: 20072
		private int honamiStoryItemId_;

		// Token: 0x04004E69 RID: 20073
		public const int StatusFieldNumber = 2;

		// Token: 0x04004E6A RID: 20074
		private int status_;
	}
}
