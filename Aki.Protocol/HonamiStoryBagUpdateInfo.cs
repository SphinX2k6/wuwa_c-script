using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200075B RID: 1883
	public sealed class HonamiStoryBagUpdateInfo : IMessage<HonamiStoryBagUpdateInfo>, IMessage, IEquatable<HonamiStoryBagUpdateInfo>, IDeepCloneable<HonamiStoryBagUpdateInfo>, IBufferMessage
	{
		// Token: 0x0600AAB9 RID: 43705 RVA: 0x0019B15D File Offset: 0x0019935D
		[NullableContext(1)]
		public static HonamiStoryBagUpdateInfo Create()
		{
			return new HonamiStoryBagUpdateInfo();
		}

		// Token: 0x17002263 RID: 8803
		// (get) Token: 0x0600AABA RID: 43706 RVA: 0x0019B164 File Offset: 0x00199364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryBagUpdateInfo> Parser
		{
			get
			{
				return HonamiStoryBagUpdateInfo._parser;
			}
		}

		// Token: 0x17002264 RID: 8804
		// (get) Token: 0x0600AABB RID: 43707 RVA: 0x0019B16B File Offset: 0x0019936B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002265 RID: 8805
		// (get) Token: 0x0600AABC RID: 43708 RVA: 0x0019B16E File Offset: 0x0019936E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagUpdateInfo.Descriptor;
			}
		}

		// Token: 0x0600AABD RID: 43709 RVA: 0x0019B175 File Offset: 0x00199375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagUpdateInfo()
		{
		}

		// Token: 0x0600AABE RID: 43710 RVA: 0x0019B180 File Offset: 0x00199380
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

		// Token: 0x0600AABF RID: 43711 RVA: 0x0019B1F4 File Offset: 0x001993F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagUpdateInfo Clone()
		{
			return new HonamiStoryBagUpdateInfo(this);
		}

		// Token: 0x17002266 RID: 8806
		// (get) Token: 0x0600AAC0 RID: 43712 RVA: 0x0019B1FC File Offset: 0x001993FC
		// (set) Token: 0x0600AAC1 RID: 43713 RVA: 0x0019B204 File Offset: 0x00199404
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

		// Token: 0x17002267 RID: 8807
		// (get) Token: 0x0600AAC2 RID: 43714 RVA: 0x0019B20D File Offset: 0x0019940D
		// (set) Token: 0x0600AAC3 RID: 43715 RVA: 0x0019B215 File Offset: 0x00199415
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

		// Token: 0x17002268 RID: 8808
		// (get) Token: 0x0600AAC4 RID: 43716 RVA: 0x0019B21E File Offset: 0x0019941E
		// (set) Token: 0x0600AAC5 RID: 43717 RVA: 0x0019B226 File Offset: 0x00199426
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

		// Token: 0x17002269 RID: 8809
		// (get) Token: 0x0600AAC6 RID: 43718 RVA: 0x0019B22F File Offset: 0x0019942F
		// (set) Token: 0x0600AAC7 RID: 43719 RVA: 0x0019B237 File Offset: 0x00199437
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

		// Token: 0x0600AAC8 RID: 43720 RVA: 0x0019B240 File Offset: 0x00199440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagUpdateInfo);
		}

		// Token: 0x0600AAC9 RID: 43721 RVA: 0x0019B250 File Offset: 0x00199450
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagUpdateInfo other)
		{
			return other != null && (other == this || (this.ItemIncrId == other.ItemIncrId && this.Type == other.Type && object.Equals(this.HonamiStoryPosInfo, other.HonamiStoryPosInfo) && object.Equals(this.OriHonamiStoryPosInfo, other.OriHonamiStoryPosInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AACA RID: 43722 RVA: 0x0019B2C4 File Offset: 0x001994C4
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

		// Token: 0x0600AACB RID: 43723 RVA: 0x0019B348 File Offset: 0x00199548
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AACC RID: 43724 RVA: 0x0019B355 File Offset: 0x00199555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AACD RID: 43725 RVA: 0x0019B360 File Offset: 0x00199560
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

		// Token: 0x0600AACE RID: 43726 RVA: 0x0019B3F0 File Offset: 0x001995F0
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

		// Token: 0x0600AACF RID: 43727 RVA: 0x0019B478 File Offset: 0x00199678
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

		// Token: 0x0600AAD0 RID: 43728 RVA: 0x0019B520 File Offset: 0x00199720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AAD1 RID: 43729 RVA: 0x0019B52C File Offset: 0x0019972C
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

		// Token: 0x04004DF9 RID: 19961
		private static readonly MessageParser<HonamiStoryBagUpdateInfo> _parser = new MessageParser<HonamiStoryBagUpdateInfo>(() => new HonamiStoryBagUpdateInfo());

		// Token: 0x04004DFA RID: 19962
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DFB RID: 19963
		public const int ItemIncrIdFieldNumber = 1;

		// Token: 0x04004DFC RID: 19964
		private int itemIncrId_;

		// Token: 0x04004DFD RID: 19965
		public const int TypeFieldNumber = 2;

		// Token: 0x04004DFE RID: 19966
		private int type_;

		// Token: 0x04004DFF RID: 19967
		public const int HonamiStoryPosInfoFieldNumber = 3;

		// Token: 0x04004E00 RID: 19968
		private HonamiStoryPosInfo honamiStoryPosInfo_;

		// Token: 0x04004E01 RID: 19969
		public const int OriHonamiStoryPosInfoFieldNumber = 4;

		// Token: 0x04004E02 RID: 19970
		private HonamiStoryPosInfo oriHonamiStoryPosInfo_;
	}
}
