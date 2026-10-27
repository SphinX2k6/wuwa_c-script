using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A16 RID: 2582
	public sealed class MoraleAreaInfo : IMessage<MoraleAreaInfo>, IMessage, IEquatable<MoraleAreaInfo>, IDeepCloneable<MoraleAreaInfo>, IBufferMessage
	{
		// Token: 0x0600E1D0 RID: 57808 RVA: 0x002111E6 File Offset: 0x0020F3E6
		[NullableContext(1)]
		public static MoraleAreaInfo Create()
		{
			return new MoraleAreaInfo();
		}

		// Token: 0x17002DC8 RID: 11720
		// (get) Token: 0x0600E1D1 RID: 57809 RVA: 0x002111ED File Offset: 0x0020F3ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MoraleAreaInfo> Parser
		{
			get
			{
				return MoraleAreaInfo._parser;
			}
		}

		// Token: 0x17002DC9 RID: 11721
		// (get) Token: 0x0600E1D2 RID: 57810 RVA: 0x002111F4 File Offset: 0x0020F3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DCA RID: 11722
		// (get) Token: 0x0600E1D3 RID: 57811 RVA: 0x002111F7 File Offset: 0x0020F3F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MoraleAreaInfo.Descriptor;
			}
		}

		// Token: 0x0600E1D4 RID: 57812 RVA: 0x002111FE File Offset: 0x0020F3FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleAreaInfo()
		{
		}

		// Token: 0x0600E1D5 RID: 57813 RVA: 0x00211206 File Offset: 0x0020F406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleAreaInfo(MoraleAreaInfo other) : this()
		{
			this.moraleArea_ = other.moraleArea_;
			this.exploreBoxGetCount_ = other.exploreBoxGetCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E1D6 RID: 57814 RVA: 0x00211237 File Offset: 0x0020F437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoraleAreaInfo Clone()
		{
			return new MoraleAreaInfo(this);
		}

		// Token: 0x17002DCB RID: 11723
		// (get) Token: 0x0600E1D7 RID: 57815 RVA: 0x0021123F File Offset: 0x0020F43F
		// (set) Token: 0x0600E1D8 RID: 57816 RVA: 0x00211247 File Offset: 0x0020F447
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

		// Token: 0x17002DCC RID: 11724
		// (get) Token: 0x0600E1D9 RID: 57817 RVA: 0x00211250 File Offset: 0x0020F450
		// (set) Token: 0x0600E1DA RID: 57818 RVA: 0x00211258 File Offset: 0x0020F458
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

		// Token: 0x0600E1DB RID: 57819 RVA: 0x00211261 File Offset: 0x0020F461
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MoraleAreaInfo);
		}

		// Token: 0x0600E1DC RID: 57820 RVA: 0x0021126F File Offset: 0x0020F46F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MoraleAreaInfo other)
		{
			return other != null && (other == this || (this.MoraleArea == other.MoraleArea && this.ExploreBoxGetCount == other.ExploreBoxGetCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E1DD RID: 57821 RVA: 0x002112B0 File Offset: 0x0020F4B0
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

		// Token: 0x0600E1DE RID: 57822 RVA: 0x00211308 File Offset: 0x0020F508
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E1DF RID: 57823 RVA: 0x00211315 File Offset: 0x0020F515
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E1E0 RID: 57824 RVA: 0x00211320 File Offset: 0x0020F520
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

		// Token: 0x0600E1E1 RID: 57825 RVA: 0x00211378 File Offset: 0x0020F578
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

		// Token: 0x0600E1E2 RID: 57826 RVA: 0x002113D0 File Offset: 0x0020F5D0
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

		// Token: 0x0600E1E3 RID: 57827 RVA: 0x00211420 File Offset: 0x0020F620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E1E4 RID: 57828 RVA: 0x0021142C File Offset: 0x0020F62C
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

		// Token: 0x04005CC3 RID: 23747
		private static readonly MessageParser<MoraleAreaInfo> _parser = new MessageParser<MoraleAreaInfo>(() => new MoraleAreaInfo());

		// Token: 0x04005CC4 RID: 23748
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005CC5 RID: 23749
		public const int MoraleAreaFieldNumber = 1;

		// Token: 0x04005CC6 RID: 23750
		private int moraleArea_;

		// Token: 0x04005CC7 RID: 23751
		public const int ExploreBoxGetCountFieldNumber = 2;

		// Token: 0x04005CC8 RID: 23752
		private int exploreBoxGetCount_;
	}
}
