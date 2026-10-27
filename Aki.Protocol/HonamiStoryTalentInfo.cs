using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A6 RID: 1958
	public sealed class HonamiStoryTalentInfo : IMessage<HonamiStoryTalentInfo>, IMessage, IEquatable<HonamiStoryTalentInfo>, IDeepCloneable<HonamiStoryTalentInfo>, IBufferMessage
	{
		// Token: 0x0600B079 RID: 45177 RVA: 0x001A742F File Offset: 0x001A562F
		[NullableContext(1)]
		public static HonamiStoryTalentInfo Create()
		{
			return new HonamiStoryTalentInfo();
		}

		// Token: 0x1700239A RID: 9114
		// (get) Token: 0x0600B07A RID: 45178 RVA: 0x001A7436 File Offset: 0x001A5636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryTalentInfo> Parser
		{
			get
			{
				return HonamiStoryTalentInfo._parser;
			}
		}

		// Token: 0x1700239B RID: 9115
		// (get) Token: 0x0600B07B RID: 45179 RVA: 0x001A743D File Offset: 0x001A563D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x0600B07C RID: 45180 RVA: 0x001A7440 File Offset: 0x001A5640
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryTalentInfo.Descriptor;
			}
		}

		// Token: 0x0600B07D RID: 45181 RVA: 0x001A7447 File Offset: 0x001A5647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTalentInfo()
		{
		}

		// Token: 0x0600B07E RID: 45182 RVA: 0x001A744F File Offset: 0x001A564F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTalentInfo(HonamiStoryTalentInfo other) : this()
		{
			this.talentId_ = other.talentId_;
			this.status_ = other.status_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B07F RID: 45183 RVA: 0x001A7480 File Offset: 0x001A5680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryTalentInfo Clone()
		{
			return new HonamiStoryTalentInfo(this);
		}

		// Token: 0x1700239D RID: 9117
		// (get) Token: 0x0600B080 RID: 45184 RVA: 0x001A7488 File Offset: 0x001A5688
		// (set) Token: 0x0600B081 RID: 45185 RVA: 0x001A7490 File Offset: 0x001A5690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TalentId
		{
			get
			{
				return this.talentId_;
			}
			set
			{
				this.talentId_ = value;
			}
		}

		// Token: 0x1700239E RID: 9118
		// (get) Token: 0x0600B082 RID: 45186 RVA: 0x001A7499 File Offset: 0x001A5699
		// (set) Token: 0x0600B083 RID: 45187 RVA: 0x001A74A1 File Offset: 0x001A56A1
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

		// Token: 0x0600B084 RID: 45188 RVA: 0x001A74AA File Offset: 0x001A56AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryTalentInfo);
		}

		// Token: 0x0600B085 RID: 45189 RVA: 0x001A74B8 File Offset: 0x001A56B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryTalentInfo other)
		{
			return other != null && (other == this || (this.TalentId == other.TalentId && this.Status == other.Status && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B086 RID: 45190 RVA: 0x001A74F8 File Offset: 0x001A56F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TalentId != 0)
			{
				num ^= this.TalentId.GetHashCode();
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

		// Token: 0x0600B087 RID: 45191 RVA: 0x001A7550 File Offset: 0x001A5750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B088 RID: 45192 RVA: 0x001A755D File Offset: 0x001A575D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B089 RID: 45193 RVA: 0x001A7568 File Offset: 0x001A5768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TalentId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TalentId);
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

		// Token: 0x0600B08A RID: 45194 RVA: 0x001A75C0 File Offset: 0x001A57C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TalentId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TalentId);
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

		// Token: 0x0600B08B RID: 45195 RVA: 0x001A7618 File Offset: 0x001A5818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryTalentInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TalentId != 0)
			{
				this.TalentId = other.TalentId;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B08C RID: 45196 RVA: 0x001A7668 File Offset: 0x001A5868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B08D RID: 45197 RVA: 0x001A7674 File Offset: 0x001A5874
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
					this.TalentId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004F45 RID: 20293
		private static readonly MessageParser<HonamiStoryTalentInfo> _parser = new MessageParser<HonamiStoryTalentInfo>(() => new HonamiStoryTalentInfo());

		// Token: 0x04004F46 RID: 20294
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F47 RID: 20295
		public const int TalentIdFieldNumber = 1;

		// Token: 0x04004F48 RID: 20296
		private int talentId_;

		// Token: 0x04004F49 RID: 20297
		public const int StatusFieldNumber = 2;

		// Token: 0x04004F4A RID: 20298
		private int status_;
	}
}
