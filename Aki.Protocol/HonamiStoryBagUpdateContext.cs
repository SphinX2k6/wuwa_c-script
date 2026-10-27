using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200076E RID: 1902
	public sealed class HonamiStoryBagUpdateContext : IMessage<HonamiStoryBagUpdateContext>, IMessage, IEquatable<HonamiStoryBagUpdateContext>, IDeepCloneable<HonamiStoryBagUpdateContext>, IBufferMessage
	{
		// Token: 0x0600ABFA RID: 44026 RVA: 0x0019D8BB File Offset: 0x0019BABB
		[NullableContext(1)]
		public static HonamiStoryBagUpdateContext Create()
		{
			return new HonamiStoryBagUpdateContext();
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x0600ABFB RID: 44027 RVA: 0x0019D8C2 File Offset: 0x0019BAC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryBagUpdateContext> Parser
		{
			get
			{
				return HonamiStoryBagUpdateContext._parser;
			}
		}

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x0600ABFC RID: 44028 RVA: 0x0019D8C9 File Offset: 0x0019BAC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x0600ABFD RID: 44029 RVA: 0x0019D8CC File Offset: 0x0019BACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagUpdateContext.Descriptor;
			}
		}

		// Token: 0x0600ABFE RID: 44030 RVA: 0x0019D8D3 File Offset: 0x0019BAD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagUpdateContext()
		{
		}

		// Token: 0x0600ABFF RID: 44031 RVA: 0x0019D8E6 File Offset: 0x0019BAE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagUpdateContext(HonamiStoryBagUpdateContext other) : this()
		{
			this.backPackConfigId_ = other.backPackConfigId_;
			this.honamiStoryBagUpdateInfo_ = other.honamiStoryBagUpdateInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC00 RID: 44032 RVA: 0x0019D91C File Offset: 0x0019BB1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagUpdateContext Clone()
		{
			return new HonamiStoryBagUpdateContext(this);
		}

		// Token: 0x170022AB RID: 8875
		// (get) Token: 0x0600AC01 RID: 44033 RVA: 0x0019D924 File Offset: 0x0019BB24
		// (set) Token: 0x0600AC02 RID: 44034 RVA: 0x0019D92C File Offset: 0x0019BB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BackPackConfigId
		{
			get
			{
				return this.backPackConfigId_;
			}
			set
			{
				this.backPackConfigId_ = value;
			}
		}

		// Token: 0x170022AC RID: 8876
		// (get) Token: 0x0600AC03 RID: 44035 RVA: 0x0019D935 File Offset: 0x0019BB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HonamiStoryBagUpdateInfo> HonamiStoryBagUpdateInfo
		{
			get
			{
				return this.honamiStoryBagUpdateInfo_;
			}
		}

		// Token: 0x0600AC04 RID: 44036 RVA: 0x0019D93D File Offset: 0x0019BB3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagUpdateContext);
		}

		// Token: 0x0600AC05 RID: 44037 RVA: 0x0019D94C File Offset: 0x0019BB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagUpdateContext other)
		{
			return other != null && (other == this || (this.BackPackConfigId == other.BackPackConfigId && this.honamiStoryBagUpdateInfo_.Equals(other.honamiStoryBagUpdateInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC06 RID: 44038 RVA: 0x0019D99C File Offset: 0x0019BB9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BackPackConfigId != 0)
			{
				num ^= this.BackPackConfigId.GetHashCode();
			}
			num ^= this.honamiStoryBagUpdateInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC07 RID: 44039 RVA: 0x0019D9E9 File Offset: 0x0019BBE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AC08 RID: 44040 RVA: 0x0019D9F6 File Offset: 0x0019BBF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC09 RID: 44041 RVA: 0x0019DA00 File Offset: 0x0019BC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BackPackConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BackPackConfigId);
			}
			this.honamiStoryBagUpdateInfo_.WriteTo(ref output, HonamiStoryBagUpdateContext._repeated_honamiStoryBagUpdateInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC0A RID: 44042 RVA: 0x0019DA50 File Offset: 0x0019BC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BackPackConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BackPackConfigId);
			}
			num += this.honamiStoryBagUpdateInfo_.CalculateSize(HonamiStoryBagUpdateContext._repeated_honamiStoryBagUpdateInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC0B RID: 44043 RVA: 0x0019DAA4 File Offset: 0x0019BCA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryBagUpdateContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BackPackConfigId != 0)
			{
				this.BackPackConfigId = other.BackPackConfigId;
			}
			this.honamiStoryBagUpdateInfo_.Add(other.honamiStoryBagUpdateInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC0C RID: 44044 RVA: 0x0019DAF1 File Offset: 0x0019BCF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC0D RID: 44045 RVA: 0x0019DAFC File Offset: 0x0019BCFC
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.honamiStoryBagUpdateInfo_.AddEntriesFrom(ref input, HonamiStoryBagUpdateContext._repeated_honamiStoryBagUpdateInfo_codec);
					}
				}
				else
				{
					this.BackPackConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004DF9 RID: 19961
		private static readonly MessageParser<HonamiStoryBagUpdateContext> _parser = new MessageParser<HonamiStoryBagUpdateContext>(() => new HonamiStoryBagUpdateContext());

		// Token: 0x04004DFA RID: 19962
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DFB RID: 19963
		public const int BackPackConfigIdFieldNumber = 1;

		// Token: 0x04004DFC RID: 19964
		private int backPackConfigId_;

		// Token: 0x04004DFD RID: 19965
		public const int HonamiStoryBagUpdateInfoFieldNumber = 2;

		// Token: 0x04004DFE RID: 19966
		private static readonly FieldCodec<HonamiStoryBagUpdateInfo> _repeated_honamiStoryBagUpdateInfo_codec = FieldCodec.ForMessage<HonamiStoryBagUpdateInfo>(18U, Aki.Protocol.HonamiStoryBagUpdateInfo.Parser);

		// Token: 0x04004DFF RID: 19967
		private readonly RepeatedField<HonamiStoryBagUpdateInfo> honamiStoryBagUpdateInfo_ = new RepeatedField<HonamiStoryBagUpdateInfo>();
	}
}
