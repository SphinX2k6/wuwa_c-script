using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB6 RID: 4022
	[NetMessage(EMessageId.RoguelikeRoomInfoNotify)]
	public sealed class RoguelikeRoomInfoNotify : IMessage<RoguelikeRoomInfoNotify>, IMessage, IEquatable<RoguelikeRoomInfoNotify>, IDeepCloneable<RoguelikeRoomInfoNotify>, IBufferMessage
	{
		// Token: 0x06015813 RID: 88083 RVA: 0x0031F16D File Offset: 0x0031D36D
		[NullableContext(1)]
		public static RoguelikeRoomInfoNotify Create()
		{
			return new RoguelikeRoomInfoNotify();
		}

		// Token: 0x170047B2 RID: 18354
		// (get) Token: 0x06015814 RID: 88084 RVA: 0x0031F174 File Offset: 0x0031D374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047B3 RID: 18355
		// (get) Token: 0x06015815 RID: 88085 RVA: 0x0031F177 File Offset: 0x0031D377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRoomInfoNotify.Descriptor;
			}
		}

		// Token: 0x06015816 RID: 88086 RVA: 0x0031F17E File Offset: 0x0031D37E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoomInfoNotify()
		{
		}

		// Token: 0x06015817 RID: 88087 RVA: 0x0031F188 File Offset: 0x0031D388
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

		// Token: 0x06015818 RID: 88088 RVA: 0x0031F1E8 File Offset: 0x0031D3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoomInfoNotify Clone()
		{
			return new RoguelikeRoomInfoNotify(this);
		}

		// Token: 0x170047B4 RID: 18356
		// (get) Token: 0x06015819 RID: 88089 RVA: 0x0031F1F0 File Offset: 0x0031D3F0
		// (set) Token: 0x0601581A RID: 88090 RVA: 0x0031F1F8 File Offset: 0x0031D3F8
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

		// Token: 0x170047B5 RID: 18357
		// (get) Token: 0x0601581B RID: 88091 RVA: 0x0031F201 File Offset: 0x0031D401
		// (set) Token: 0x0601581C RID: 88092 RVA: 0x0031F209 File Offset: 0x0031D409
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

		// Token: 0x170047B6 RID: 18358
		// (get) Token: 0x0601581D RID: 88093 RVA: 0x0031F212 File Offset: 0x0031D412
		// (set) Token: 0x0601581E RID: 88094 RVA: 0x0031F21A File Offset: 0x0031D41A
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

		// Token: 0x170047B7 RID: 18359
		// (get) Token: 0x0601581F RID: 88095 RVA: 0x0031F223 File Offset: 0x0031D423
		// (set) Token: 0x06015820 RID: 88096 RVA: 0x0031F22B File Offset: 0x0031D42B
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

		// Token: 0x170047B8 RID: 18360
		// (get) Token: 0x06015821 RID: 88097 RVA: 0x0031F234 File Offset: 0x0031D434
		// (set) Token: 0x06015822 RID: 88098 RVA: 0x0031F23C File Offset: 0x0031D43C
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

		// Token: 0x06015823 RID: 88099 RVA: 0x0031F245 File Offset: 0x0031D445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRoomInfoNotify);
		}

		// Token: 0x06015824 RID: 88100 RVA: 0x0031F254 File Offset: 0x0031D454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRoomInfoNotify other)
		{
			return other != null && (other == this || (this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.RoguelikeRoomTypeId == other.RoguelikeRoomTypeId && this.SkyBoxId == other.SkyBoxId && this.RoguelikeRoomId == other.RoguelikeRoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015825 RID: 88101 RVA: 0x0031F2D0 File Offset: 0x0031D4D0
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

		// Token: 0x06015826 RID: 88102 RVA: 0x0031F373 File Offset: 0x0031D573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015827 RID: 88103 RVA: 0x0031F380 File Offset: 0x0031D580
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015828 RID: 88104 RVA: 0x0031F38C File Offset: 0x0031D58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MaxLayer != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MaxLayer);
			}
			if (this.SkyBoxId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkyBoxId);
			}
			if (this.RoguelikeRoomTypeId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RoguelikeRoomTypeId);
			}
			if (this.CurLayer != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.CurLayer);
			}
			if (this.RoguelikeRoomId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoguelikeRoomId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015829 RID: 88105 RVA: 0x0031F438 File Offset: 0x0031D638
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

		// Token: 0x0601582A RID: 88106 RVA: 0x0031F4D8 File Offset: 0x0031D6D8
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

		// Token: 0x0601582B RID: 88107 RVA: 0x0031F564 File Offset: 0x0031D764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601582C RID: 88108 RVA: 0x0031F570 File Offset: 0x0031D770
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
						this.MaxLayer = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.SkyBoxId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.RoguelikeRoomTypeId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.CurLayer = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.RoguelikeRoomId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008142 RID: 33090
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008143 RID: 33091
		public const int CurLayerFieldNumber = 5;

		// Token: 0x04008144 RID: 33092
		private int curLayer_;

		// Token: 0x04008145 RID: 33093
		public const int MaxLayerFieldNumber = 1;

		// Token: 0x04008146 RID: 33094
		private int maxLayer_;

		// Token: 0x04008147 RID: 33095
		public const int RoguelikeRoomTypeIdFieldNumber = 3;

		// Token: 0x04008148 RID: 33096
		private int roguelikeRoomTypeId_;

		// Token: 0x04008149 RID: 33097
		public const int SkyBoxIdFieldNumber = 2;

		// Token: 0x0400814A RID: 33098
		private int skyBoxId_;

		// Token: 0x0400814B RID: 33099
		public const int RoguelikeRoomIdFieldNumber = 14;

		// Token: 0x0400814C RID: 33100
		private int roguelikeRoomId_;
	}
}
