using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A05 RID: 2565
	public sealed class MoraleAreaInfo : IMessage<MoraleAreaInfo>, IMessage, IEquatable<MoraleAreaInfo>, IDeepCloneable<MoraleAreaInfo>, IBufferMessage
	{
		// Token: 0x0600E0B6 RID: 57526 RVA: 0x0020EFF2 File Offset: 0x0020D1F2
		[NullableContext(1)]
		public static MoraleAreaInfo Create()
		{
			return new MoraleAreaInfo();
		}

		// Token: 0x17002D8A RID: 11658
		// (get) Token: 0x0600E0B7 RID: 57527 RVA: 0x0020EFF9 File Offset: 0x0020D1F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MoraleAreaInfo> Parser
		{
			get
			{
				return MoraleAreaInfo._parser;
			}
		}

		// Token: 0x17002D8B RID: 11659
		// (get) Token: 0x0600E0B8 RID: 57528 RVA: 0x0020F000 File Offset: 0x0020D200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D8C RID: 11660
		// (get) Token: 0x0600E0B9 RID: 57529 RVA: 0x0020F003 File Offset: 0x0020D203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoraleAreaInfo.Descriptor;
			}
		}

		// Token: 0x0600E0BA RID: 57530 RVA: 0x0020F00A File Offset: 0x0020D20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleAreaInfo()
		{
		}

		// Token: 0x0600E0BB RID: 57531 RVA: 0x0020F012 File Offset: 0x0020D212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleAreaInfo(MoraleAreaInfo other) : this()
		{
			this.moraleArea_ = other.moraleArea_;
			this.exploreBoxGetCount_ = other.exploreBoxGetCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E0BC RID: 57532 RVA: 0x0020F043 File Offset: 0x0020D243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleAreaInfo Clone()
		{
			return new MoraleAreaInfo(this);
		}

		// Token: 0x17002D8D RID: 11661
		// (get) Token: 0x0600E0BD RID: 57533 RVA: 0x0020F04B File Offset: 0x0020D24B
		// (set) Token: 0x0600E0BE RID: 57534 RVA: 0x0020F053 File Offset: 0x0020D253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoraleArea
		{
			get
			{
				return this.moraleArea_;
			}
			set
			{
				this.moraleArea_ = value;
			}
		}

		// Token: 0x17002D8E RID: 11662
		// (get) Token: 0x0600E0BF RID: 57535 RVA: 0x0020F05C File Offset: 0x0020D25C
		// (set) Token: 0x0600E0C0 RID: 57536 RVA: 0x0020F064 File Offset: 0x0020D264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExploreBoxGetCount
		{
			get
			{
				return this.exploreBoxGetCount_;
			}
			set
			{
				this.exploreBoxGetCount_ = value;
			}
		}

		// Token: 0x0600E0C1 RID: 57537 RVA: 0x0020F06D File Offset: 0x0020D26D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoraleAreaInfo);
		}

		// Token: 0x0600E0C2 RID: 57538 RVA: 0x0020F07B File Offset: 0x0020D27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoraleAreaInfo other)
		{
			return other != null && (other == this || (this.MoraleArea == other.MoraleArea && this.ExploreBoxGetCount == other.ExploreBoxGetCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E0C3 RID: 57539 RVA: 0x0020F0BC File Offset: 0x0020D2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MoraleArea != 0)
			{
				num ^= this.MoraleArea.GetHashCode();
			}
			if (this.ExploreBoxGetCount != 0)
			{
				num ^= this.ExploreBoxGetCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E0C4 RID: 57540 RVA: 0x0020F114 File Offset: 0x0020D314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E0C5 RID: 57541 RVA: 0x0020F121 File Offset: 0x0020D321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E0C6 RID: 57542 RVA: 0x0020F12C File Offset: 0x0020D32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MoraleArea != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MoraleArea);
			}
			if (this.ExploreBoxGetCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ExploreBoxGetCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E0C7 RID: 57543 RVA: 0x0020F184 File Offset: 0x0020D384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MoraleArea != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoraleArea);
			}
			if (this.ExploreBoxGetCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExploreBoxGetCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E0C8 RID: 57544 RVA: 0x0020F1DC File Offset: 0x0020D3DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MoraleAreaInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MoraleArea != 0)
			{
				this.MoraleArea = other.MoraleArea;
			}
			if (other.ExploreBoxGetCount != 0)
			{
				this.ExploreBoxGetCount = other.ExploreBoxGetCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E0C9 RID: 57545 RVA: 0x0020F22C File Offset: 0x0020D42C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E0CA RID: 57546 RVA: 0x0020F238 File Offset: 0x0020D438
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
						this.ExploreBoxGetCount = input.ReadInt32();
					}
				}
				else
				{
					this.MoraleArea = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005CCC RID: 23756
		private static readonly MessageParser<MoraleAreaInfo> _parser = new MessageParser<MoraleAreaInfo>(() => new MoraleAreaInfo());

		// Token: 0x04005CCD RID: 23757
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CCE RID: 23758
		public const int MoraleAreaFieldNumber = 1;

		// Token: 0x04005CCF RID: 23759
		private int moraleArea_;

		// Token: 0x04005CD0 RID: 23760
		public const int ExploreBoxGetCountFieldNumber = 2;

		// Token: 0x04005CD1 RID: 23761
		private int exploreBoxGetCount_;
	}
}
