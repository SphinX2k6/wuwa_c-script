using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA6 RID: 4006
	[NetMessage(EMessageId.RoguelikeRoomInfoNotify)]
	public sealed class RoguelikeRoomInfoNotify : IMessage<RoguelikeRoomInfoNotify>, IMessage, IEquatable<RoguelikeRoomInfoNotify>, IDeepCloneable<RoguelikeRoomInfoNotify>, IBufferMessage
	{
		// Token: 0x0601572E RID: 87854 RVA: 0x0031DABD File Offset: 0x0031BCBD
		[NullableContext(1)]
		public static RoguelikeRoomInfoNotify Create()
		{
			return new RoguelikeRoomInfoNotify();
		}

		// Token: 0x17004788 RID: 18312
		// (get) Token: 0x0601572F RID: 87855 RVA: 0x0031DAC4 File Offset: 0x0031BCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004789 RID: 18313
		// (get) Token: 0x06015730 RID: 87856 RVA: 0x0031DAC7 File Offset: 0x0031BCC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRoomInfoNotify.Descriptor;
			}
		}

		// Token: 0x06015731 RID: 87857 RVA: 0x0031DACE File Offset: 0x0031BCCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoomInfoNotify()
		{
		}

		// Token: 0x06015732 RID: 87858 RVA: 0x0031DAD8 File Offset: 0x0031BCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoomInfoNotify(RoguelikeRoomInfoNotify other) : this()
		{
			this.curLayer_ = other.curLayer_;
			this.maxLayer_ = other.maxLayer_;
			this.roguelikeRoomTypeId_ = other.roguelikeRoomTypeId_;
			this.skyBoxId_ = other.skyBoxId_;
			this.roguelikeRoomId_ = other.roguelikeRoomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015733 RID: 87859 RVA: 0x0031DB38 File Offset: 0x0031BD38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoomInfoNotify Clone()
		{
			return new RoguelikeRoomInfoNotify(this);
		}

		// Token: 0x1700478A RID: 18314
		// (get) Token: 0x06015734 RID: 87860 RVA: 0x0031DB40 File Offset: 0x0031BD40
		// (set) Token: 0x06015735 RID: 87861 RVA: 0x0031DB48 File Offset: 0x0031BD48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurLayer
		{
			get
			{
				return this.curLayer_;
			}
			set
			{
				this.curLayer_ = value;
			}
		}

		// Token: 0x1700478B RID: 18315
		// (get) Token: 0x06015736 RID: 87862 RVA: 0x0031DB51 File Offset: 0x0031BD51
		// (set) Token: 0x06015737 RID: 87863 RVA: 0x0031DB59 File Offset: 0x0031BD59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MaxLayer
		{
			get
			{
				return this.maxLayer_;
			}
			set
			{
				this.maxLayer_ = value;
			}
		}

		// Token: 0x1700478C RID: 18316
		// (get) Token: 0x06015738 RID: 87864 RVA: 0x0031DB62 File Offset: 0x0031BD62
		// (set) Token: 0x06015739 RID: 87865 RVA: 0x0031DB6A File Offset: 0x0031BD6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoguelikeRoomTypeId
		{
			get
			{
				return this.roguelikeRoomTypeId_;
			}
			set
			{
				this.roguelikeRoomTypeId_ = value;
			}
		}

		// Token: 0x1700478D RID: 18317
		// (get) Token: 0x0601573A RID: 87866 RVA: 0x0031DB73 File Offset: 0x0031BD73
		// (set) Token: 0x0601573B RID: 87867 RVA: 0x0031DB7B File Offset: 0x0031BD7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkyBoxId
		{
			get
			{
				return this.skyBoxId_;
			}
			set
			{
				this.skyBoxId_ = value;
			}
		}

		// Token: 0x1700478E RID: 18318
		// (get) Token: 0x0601573C RID: 87868 RVA: 0x0031DB84 File Offset: 0x0031BD84
		// (set) Token: 0x0601573D RID: 87869 RVA: 0x0031DB8C File Offset: 0x0031BD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoguelikeRoomId
		{
			get
			{
				return this.roguelikeRoomId_;
			}
			set
			{
				this.roguelikeRoomId_ = value;
			}
		}

		// Token: 0x0601573E RID: 87870 RVA: 0x0031DB95 File Offset: 0x0031BD95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRoomInfoNotify);
		}

		// Token: 0x0601573F RID: 87871 RVA: 0x0031DBA4 File Offset: 0x0031BDA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRoomInfoNotify other)
		{
			return other != null && (other == this || (this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.RoguelikeRoomTypeId == other.RoguelikeRoomTypeId && this.SkyBoxId == other.SkyBoxId && this.RoguelikeRoomId == other.RoguelikeRoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015740 RID: 87872 RVA: 0x0031DC20 File Offset: 0x0031BE20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurLayer != 0)
			{
				num ^= this.CurLayer.GetHashCode();
			}
			if (this.MaxLayer != 0)
			{
				num ^= this.MaxLayer.GetHashCode();
			}
			if (this.RoguelikeRoomTypeId != 0)
			{
				num ^= this.RoguelikeRoomTypeId.GetHashCode();
			}
			if (this.SkyBoxId != 0)
			{
				num ^= this.SkyBoxId.GetHashCode();
			}
			if (this.RoguelikeRoomId != 0)
			{
				num ^= this.RoguelikeRoomId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015741 RID: 87873 RVA: 0x0031DCC3 File Offset: 0x0031BEC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015742 RID: 87874 RVA: 0x0031DCD0 File Offset: 0x0031BED0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015743 RID: 87875 RVA: 0x0031DCDC File Offset: 0x0031BEDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurLayer != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurLayer);
			}
			if (this.MaxLayer != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MaxLayer);
			}
			if (this.SkyBoxId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.SkyBoxId);
			}
			if (this.RoguelikeRoomTypeId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoguelikeRoomTypeId);
			}
			if (this.RoguelikeRoomId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.RoguelikeRoomId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015744 RID: 87876 RVA: 0x0031DD8C File Offset: 0x0031BF8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurLayer);
			}
			if (this.MaxLayer != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MaxLayer);
			}
			if (this.RoguelikeRoomTypeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoguelikeRoomTypeId);
			}
			if (this.SkyBoxId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkyBoxId);
			}
			if (this.RoguelikeRoomId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoguelikeRoomId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015745 RID: 87877 RVA: 0x0031DE2C File Offset: 0x0031C02C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeRoomInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurLayer != 0)
			{
				this.CurLayer = other.CurLayer;
			}
			if (other.MaxLayer != 0)
			{
				this.MaxLayer = other.MaxLayer;
			}
			if (other.RoguelikeRoomTypeId != 0)
			{
				this.RoguelikeRoomTypeId = other.RoguelikeRoomTypeId;
			}
			if (other.SkyBoxId != 0)
			{
				this.SkyBoxId = other.SkyBoxId;
			}
			if (other.RoguelikeRoomId != 0)
			{
				this.RoguelikeRoomId = other.RoguelikeRoomId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015746 RID: 87878 RVA: 0x0031DEB8 File Offset: 0x0031C0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015747 RID: 87879 RVA: 0x0031DEC4 File Offset: 0x0031C0C4
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
				if (num <= 56U)
				{
					if (num == 24U)
					{
						this.CurLayer = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.MaxLayer = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.SkyBoxId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.RoguelikeRoomTypeId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.RoguelikeRoomId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400816C RID: 33132
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400816D RID: 33133
		public const int CurLayerFieldNumber = 3;

		// Token: 0x0400816E RID: 33134
		private int curLayer_;

		// Token: 0x0400816F RID: 33135
		public const int MaxLayerFieldNumber = 7;

		// Token: 0x04008170 RID: 33136
		private int maxLayer_;

		// Token: 0x04008171 RID: 33137
		public const int RoguelikeRoomTypeIdFieldNumber = 10;

		// Token: 0x04008172 RID: 33138
		private int roguelikeRoomTypeId_;

		// Token: 0x04008173 RID: 33139
		public const int SkyBoxIdFieldNumber = 8;

		// Token: 0x04008174 RID: 33140
		private int skyBoxId_;

		// Token: 0x04008175 RID: 33141
		public const int RoguelikeRoomIdFieldNumber = 13;

		// Token: 0x04008176 RID: 33142
		private int roguelikeRoomId_;
	}
}
