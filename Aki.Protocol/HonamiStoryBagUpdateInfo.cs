using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200076F RID: 1903
	public sealed class HonamiStoryBagUpdateInfo : IMessage<HonamiStoryBagUpdateInfo>, IMessage, IEquatable<HonamiStoryBagUpdateInfo>, IDeepCloneable<HonamiStoryBagUpdateInfo>, IBufferMessage
	{
		// Token: 0x0600AC0F RID: 44047 RVA: 0x0019DB85 File Offset: 0x0019BD85
		[NullableContext(1)]
		public static HonamiStoryBagUpdateInfo Create()
		{
			return new HonamiStoryBagUpdateInfo();
		}

		// Token: 0x170022AD RID: 8877
		// (get) Token: 0x0600AC10 RID: 44048 RVA: 0x0019DB8C File Offset: 0x0019BD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryBagUpdateInfo> Parser
		{
			get
			{
				return HonamiStoryBagUpdateInfo._parser;
			}
		}

		// Token: 0x170022AE RID: 8878
		// (get) Token: 0x0600AC11 RID: 44049 RVA: 0x0019DB93 File Offset: 0x0019BD93
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
		// (get) Token: 0x0600AC12 RID: 44050 RVA: 0x0019DB96 File Offset: 0x0019BD96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagUpdateInfo.Descriptor;
			}
		}

		// Token: 0x0600AC13 RID: 44051 RVA: 0x0019DB9D File Offset: 0x0019BD9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagUpdateInfo()
		{
		}

		// Token: 0x0600AC14 RID: 44052 RVA: 0x0019DBA8 File Offset: 0x0019BDA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagUpdateInfo(HonamiStoryBagUpdateInfo other) : this()
		{
			this.itemIncrId_ = other.itemIncrId_;
			this.type_ = other.type_;
			this.honamiStoryPosInfo_ = ((other.honamiStoryPosInfo_ != null) ? other.honamiStoryPosInfo_.Clone() : null);
			this.oriHonamiStoryPosInfo_ = ((other.oriHonamiStoryPosInfo_ != null) ? other.oriHonamiStoryPosInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AC15 RID: 44053 RVA: 0x0019DC1C File Offset: 0x0019BE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagUpdateInfo Clone()
		{
			return new HonamiStoryBagUpdateInfo(this);
		}

		// Token: 0x170022B0 RID: 8880
		// (get) Token: 0x0600AC16 RID: 44054 RVA: 0x0019DC24 File Offset: 0x0019BE24
		// (set) Token: 0x0600AC17 RID: 44055 RVA: 0x0019DC2C File Offset: 0x0019BE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemIncrId
		{
			get
			{
				return this.itemIncrId_;
			}
			set
			{
				this.itemIncrId_ = value;
			}
		}

		// Token: 0x170022B1 RID: 8881
		// (get) Token: 0x0600AC18 RID: 44056 RVA: 0x0019DC35 File Offset: 0x0019BE35
		// (set) Token: 0x0600AC19 RID: 44057 RVA: 0x0019DC3D File Offset: 0x0019BE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x170022B2 RID: 8882
		// (get) Token: 0x0600AC1A RID: 44058 RVA: 0x0019DC46 File Offset: 0x0019BE46
		// (set) Token: 0x0600AC1B RID: 44059 RVA: 0x0019DC4E File Offset: 0x0019BE4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPosInfo HonamiStoryPosInfo
		{
			get
			{
				return this.honamiStoryPosInfo_;
			}
			set
			{
				this.honamiStoryPosInfo_ = value;
			}
		}

		// Token: 0x170022B3 RID: 8883
		// (get) Token: 0x0600AC1C RID: 44060 RVA: 0x0019DC57 File Offset: 0x0019BE57
		// (set) Token: 0x0600AC1D RID: 44061 RVA: 0x0019DC5F File Offset: 0x0019BE5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryPosInfo OriHonamiStoryPosInfo
		{
			get
			{
				return this.oriHonamiStoryPosInfo_;
			}
			set
			{
				this.oriHonamiStoryPosInfo_ = value;
			}
		}

		// Token: 0x0600AC1E RID: 44062 RVA: 0x0019DC68 File Offset: 0x0019BE68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagUpdateInfo);
		}

		// Token: 0x0600AC1F RID: 44063 RVA: 0x0019DC78 File Offset: 0x0019BE78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagUpdateInfo other)
		{
			return other != null && (other == this || (this.ItemIncrId == other.ItemIncrId && this.Type == other.Type && object.Equals(this.HonamiStoryPosInfo, other.HonamiStoryPosInfo) && object.Equals(this.OriHonamiStoryPosInfo, other.OriHonamiStoryPosInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AC20 RID: 44064 RVA: 0x0019DCEC File Offset: 0x0019BEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemIncrId != 0)
			{
				num ^= this.ItemIncrId.GetHashCode();
			}
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.honamiStoryPosInfo_ != null)
			{
				num ^= this.HonamiStoryPosInfo.GetHashCode();
			}
			if (this.oriHonamiStoryPosInfo_ != null)
			{
				num ^= this.OriHonamiStoryPosInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AC21 RID: 44065 RVA: 0x0019DD70 File Offset: 0x0019BF70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AC22 RID: 44066 RVA: 0x0019DD7D File Offset: 0x0019BF7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AC23 RID: 44067 RVA: 0x0019DD88 File Offset: 0x0019BF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemIncrId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemIncrId);
			}
			if (this.Type != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Type);
			}
			if (this.honamiStoryPosInfo_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.HonamiStoryPosInfo);
			}
			if (this.oriHonamiStoryPosInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.OriHonamiStoryPosInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AC24 RID: 44068 RVA: 0x0019DE18 File Offset: 0x0019C018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemIncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemIncrId);
			}
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.honamiStoryPosInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.HonamiStoryPosInfo);
			}
			if (this.oriHonamiStoryPosInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.OriHonamiStoryPosInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AC25 RID: 44069 RVA: 0x0019DEA0 File Offset: 0x0019C0A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryBagUpdateInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemIncrId != 0)
			{
				this.ItemIncrId = other.ItemIncrId;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.honamiStoryPosInfo_ != null)
			{
				if (this.honamiStoryPosInfo_ == null)
				{
					this.HonamiStoryPosInfo = new HonamiStoryPosInfo();
				}
				this.HonamiStoryPosInfo.MergeFrom(other.HonamiStoryPosInfo);
			}
			if (other.oriHonamiStoryPosInfo_ != null)
			{
				if (this.oriHonamiStoryPosInfo_ == null)
				{
					this.OriHonamiStoryPosInfo = new HonamiStoryPosInfo();
				}
				this.OriHonamiStoryPosInfo.MergeFrom(other.OriHonamiStoryPosInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AC26 RID: 44070 RVA: 0x0019DF48 File Offset: 0x0019C148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AC27 RID: 44071 RVA: 0x0019DF54 File Offset: 0x0019C154
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ItemIncrId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Type = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						if (this.honamiStoryPosInfo_ == null)
						{
							this.HonamiStoryPosInfo = new HonamiStoryPosInfo();
						}
						input.ReadMessage(this.HonamiStoryPosInfo);
						continue;
					}
					if (num == 34U)
					{
						if (this.oriHonamiStoryPosInfo_ == null)
						{
							this.OriHonamiStoryPosInfo = new HonamiStoryPosInfo();
						}
						input.ReadMessage(this.OriHonamiStoryPosInfo);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004E00 RID: 19968
		private static readonly MessageParser<HonamiStoryBagUpdateInfo> _parser = new MessageParser<HonamiStoryBagUpdateInfo>(() => new HonamiStoryBagUpdateInfo());

		// Token: 0x04004E01 RID: 19969
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004E02 RID: 19970
		public const int ItemIncrIdFieldNumber = 1;

		// Token: 0x04004E03 RID: 19971
		private int itemIncrId_;

		// Token: 0x04004E04 RID: 19972
		public const int TypeFieldNumber = 2;

		// Token: 0x04004E05 RID: 19973
		private int type_;

		// Token: 0x04004E06 RID: 19974
		public const int HonamiStoryPosInfoFieldNumber = 3;

		// Token: 0x04004E07 RID: 19975
		private HonamiStoryPosInfo honamiStoryPosInfo_;

		// Token: 0x04004E08 RID: 19976
		public const int OriHonamiStoryPosInfoFieldNumber = 4;

		// Token: 0x04004E09 RID: 19977
		private HonamiStoryPosInfo oriHonamiStoryPosInfo_;
	}
}
