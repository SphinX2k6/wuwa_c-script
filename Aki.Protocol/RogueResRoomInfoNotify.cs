using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF4 RID: 4084
	[NetMessage(EMessageId.RogueResRoomInfoNotify)]
	public sealed class RogueResRoomInfoNotify : IMessage<RogueResRoomInfoNotify>, IMessage, IEquatable<RogueResRoomInfoNotify>, IDeepCloneable<RogueResRoomInfoNotify>, IBufferMessage
	{
		// Token: 0x06015DDA RID: 89562 RVA: 0x0032E48B File Offset: 0x0032C68B
		[NullableContext(1)]
		public static RogueResRoomInfoNotify Create()
		{
			return new RogueResRoomInfoNotify();
		}

		// Token: 0x17004913 RID: 18707
		// (get) Token: 0x06015DDB RID: 89563 RVA: 0x0032E492 File Offset: 0x0032C692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004914 RID: 18708
		// (get) Token: 0x06015DDC RID: 89564 RVA: 0x0032E495 File Offset: 0x0032C695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResRoomInfoNotify.Descriptor;
			}
		}

		// Token: 0x06015DDD RID: 89565 RVA: 0x0032E49C File Offset: 0x0032C69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoomInfoNotify()
		{
		}

		// Token: 0x06015DDE RID: 89566 RVA: 0x0032E4A4 File Offset: 0x0032C6A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoomInfoNotify(RogueResRoomInfoNotify other) : this()
		{
			this.curLayer_ = other.curLayer_;
			this.maxLayer_ = other.maxLayer_;
			this.roguelikeRoomTypeId_ = other.roguelikeRoomTypeId_;
			this.skyBoxId_ = other.skyBoxId_;
			this.roguelikeRoomId_ = other.roguelikeRoomId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015DDF RID: 89567 RVA: 0x0032E504 File Offset: 0x0032C704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoomInfoNotify Clone()
		{
			return new RogueResRoomInfoNotify(this);
		}

		// Token: 0x17004915 RID: 18709
		// (get) Token: 0x06015DE0 RID: 89568 RVA: 0x0032E50C File Offset: 0x0032C70C
		// (set) Token: 0x06015DE1 RID: 89569 RVA: 0x0032E514 File Offset: 0x0032C714
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

		// Token: 0x17004916 RID: 18710
		// (get) Token: 0x06015DE2 RID: 89570 RVA: 0x0032E51D File Offset: 0x0032C71D
		// (set) Token: 0x06015DE3 RID: 89571 RVA: 0x0032E525 File Offset: 0x0032C725
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

		// Token: 0x17004917 RID: 18711
		// (get) Token: 0x06015DE4 RID: 89572 RVA: 0x0032E52E File Offset: 0x0032C72E
		// (set) Token: 0x06015DE5 RID: 89573 RVA: 0x0032E536 File Offset: 0x0032C736
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

		// Token: 0x17004918 RID: 18712
		// (get) Token: 0x06015DE6 RID: 89574 RVA: 0x0032E53F File Offset: 0x0032C73F
		// (set) Token: 0x06015DE7 RID: 89575 RVA: 0x0032E547 File Offset: 0x0032C747
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

		// Token: 0x17004919 RID: 18713
		// (get) Token: 0x06015DE8 RID: 89576 RVA: 0x0032E550 File Offset: 0x0032C750
		// (set) Token: 0x06015DE9 RID: 89577 RVA: 0x0032E558 File Offset: 0x0032C758
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

		// Token: 0x06015DEA RID: 89578 RVA: 0x0032E561 File Offset: 0x0032C761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResRoomInfoNotify);
		}

		// Token: 0x06015DEB RID: 89579 RVA: 0x0032E570 File Offset: 0x0032C770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResRoomInfoNotify other)
		{
			return other != null && (other == this || (this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.RoguelikeRoomTypeId == other.RoguelikeRoomTypeId && this.SkyBoxId == other.SkyBoxId && this.RoguelikeRoomId == other.RoguelikeRoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015DEC RID: 89580 RVA: 0x0032E5EC File Offset: 0x0032C7EC
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

		// Token: 0x06015DED RID: 89581 RVA: 0x0032E68F File Offset: 0x0032C88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015DEE RID: 89582 RVA: 0x0032E69C File Offset: 0x0032C89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015DEF RID: 89583 RVA: 0x0032E6A8 File Offset: 0x0032C8A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkyBoxId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SkyBoxId);
			}
			if (this.MaxLayer != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.MaxLayer);
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
			if (this.CurLayer != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.CurLayer);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015DF0 RID: 89584 RVA: 0x0032E758 File Offset: 0x0032C958
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

		// Token: 0x06015DF1 RID: 89585 RVA: 0x0032E7F8 File Offset: 0x0032C9F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResRoomInfoNotify other)
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

		// Token: 0x06015DF2 RID: 89586 RVA: 0x0032E884 File Offset: 0x0032CA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015DF3 RID: 89587 RVA: 0x0032E890 File Offset: 0x0032CA90
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
				if (num <= 64U)
				{
					if (num == 40U)
					{
						this.SkyBoxId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.MaxLayer = input.ReadInt32();
						continue;
					}
				}
				else
				{
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
					if (num == 120U)
					{
						this.CurLayer = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040083AC RID: 33708
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083AD RID: 33709
		public const int CurLayerFieldNumber = 15;

		// Token: 0x040083AE RID: 33710
		private int curLayer_;

		// Token: 0x040083AF RID: 33711
		public const int MaxLayerFieldNumber = 8;

		// Token: 0x040083B0 RID: 33712
		private int maxLayer_;

		// Token: 0x040083B1 RID: 33713
		public const int RoguelikeRoomTypeIdFieldNumber = 10;

		// Token: 0x040083B2 RID: 33714
		private int roguelikeRoomTypeId_;

		// Token: 0x040083B3 RID: 33715
		public const int SkyBoxIdFieldNumber = 5;

		// Token: 0x040083B4 RID: 33716
		private int skyBoxId_;

		// Token: 0x040083B5 RID: 33717
		public const int RoguelikeRoomIdFieldNumber = 13;

		// Token: 0x040083B6 RID: 33718
		private int roguelikeRoomId_;
	}
}
