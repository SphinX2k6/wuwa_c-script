using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001004 RID: 4100
	[NetMessage(EMessageId.RogueResRoomInfoNotify)]
	public sealed class RogueResRoomInfoNotify : IMessage<RogueResRoomInfoNotify>, IMessage, IEquatable<RogueResRoomInfoNotify>, IDeepCloneable<RogueResRoomInfoNotify>, IBufferMessage
	{
		// Token: 0x06015EBF RID: 89791 RVA: 0x0032FB47 File Offset: 0x0032DD47
		[NullableContext(1)]
		public static RogueResRoomInfoNotify Create()
		{
			return new RogueResRoomInfoNotify();
		}

		// Token: 0x1700493D RID: 18749
		// (get) Token: 0x06015EC0 RID: 89792 RVA: 0x0032FB4E File Offset: 0x0032DD4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700493E RID: 18750
		// (get) Token: 0x06015EC1 RID: 89793 RVA: 0x0032FB51 File Offset: 0x0032DD51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResRoomInfoNotify.Descriptor;
			}
		}

		// Token: 0x06015EC2 RID: 89794 RVA: 0x0032FB58 File Offset: 0x0032DD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoomInfoNotify()
		{
		}

		// Token: 0x06015EC3 RID: 89795 RVA: 0x0032FB60 File Offset: 0x0032DD60
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

		// Token: 0x06015EC4 RID: 89796 RVA: 0x0032FBC0 File Offset: 0x0032DDC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResRoomInfoNotify Clone()
		{
			return new RogueResRoomInfoNotify(this);
		}

		// Token: 0x1700493F RID: 18751
		// (get) Token: 0x06015EC5 RID: 89797 RVA: 0x0032FBC8 File Offset: 0x0032DDC8
		// (set) Token: 0x06015EC6 RID: 89798 RVA: 0x0032FBD0 File Offset: 0x0032DDD0
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

		// Token: 0x17004940 RID: 18752
		// (get) Token: 0x06015EC7 RID: 89799 RVA: 0x0032FBD9 File Offset: 0x0032DDD9
		// (set) Token: 0x06015EC8 RID: 89800 RVA: 0x0032FBE1 File Offset: 0x0032DDE1
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

		// Token: 0x17004941 RID: 18753
		// (get) Token: 0x06015EC9 RID: 89801 RVA: 0x0032FBEA File Offset: 0x0032DDEA
		// (set) Token: 0x06015ECA RID: 89802 RVA: 0x0032FBF2 File Offset: 0x0032DDF2
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

		// Token: 0x17004942 RID: 18754
		// (get) Token: 0x06015ECB RID: 89803 RVA: 0x0032FBFB File Offset: 0x0032DDFB
		// (set) Token: 0x06015ECC RID: 89804 RVA: 0x0032FC03 File Offset: 0x0032DE03
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

		// Token: 0x17004943 RID: 18755
		// (get) Token: 0x06015ECD RID: 89805 RVA: 0x0032FC0C File Offset: 0x0032DE0C
		// (set) Token: 0x06015ECE RID: 89806 RVA: 0x0032FC14 File Offset: 0x0032DE14
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

		// Token: 0x06015ECF RID: 89807 RVA: 0x0032FC1D File Offset: 0x0032DE1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResRoomInfoNotify);
		}

		// Token: 0x06015ED0 RID: 89808 RVA: 0x0032FC2C File Offset: 0x0032DE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResRoomInfoNotify other)
		{
			return other != null && (other == this || (this.CurLayer == other.CurLayer && this.MaxLayer == other.MaxLayer && this.RoguelikeRoomTypeId == other.RoguelikeRoomTypeId && this.SkyBoxId == other.SkyBoxId && this.RoguelikeRoomId == other.RoguelikeRoomId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015ED1 RID: 89809 RVA: 0x0032FCA8 File Offset: 0x0032DEA8
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

		// Token: 0x06015ED2 RID: 89810 RVA: 0x0032FD4B File Offset: 0x0032DF4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015ED3 RID: 89811 RVA: 0x0032FD58 File Offset: 0x0032DF58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015ED4 RID: 89812 RVA: 0x0032FD64 File Offset: 0x0032DF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkyBoxId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SkyBoxId);
			}
			if (this.RoguelikeRoomTypeId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoguelikeRoomTypeId);
			}
			if (this.MaxLayer != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.MaxLayer);
			}
			if (this.RoguelikeRoomId != 0)
			{
				output.WriteRawTag(112);
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

		// Token: 0x06015ED5 RID: 89813 RVA: 0x0032FE14 File Offset: 0x0032E014
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

		// Token: 0x06015ED6 RID: 89814 RVA: 0x0032FEB4 File Offset: 0x0032E0B4
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

		// Token: 0x06015ED7 RID: 89815 RVA: 0x0032FF40 File Offset: 0x0032E140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015ED8 RID: 89816 RVA: 0x0032FF4C File Offset: 0x0032E14C
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
						this.RoguelikeRoomTypeId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.MaxLayer = input.ReadInt32();
						continue;
					}
					if (num == 112U)
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

		// Token: 0x04008382 RID: 33666
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008383 RID: 33667
		public const int CurLayerFieldNumber = 15;

		// Token: 0x04008384 RID: 33668
		private int curLayer_;

		// Token: 0x04008385 RID: 33669
		public const int MaxLayerFieldNumber = 12;

		// Token: 0x04008386 RID: 33670
		private int maxLayer_;

		// Token: 0x04008387 RID: 33671
		public const int RoguelikeRoomTypeIdFieldNumber = 8;

		// Token: 0x04008388 RID: 33672
		private int roguelikeRoomTypeId_;

		// Token: 0x04008389 RID: 33673
		public const int SkyBoxIdFieldNumber = 5;

		// Token: 0x0400838A RID: 33674
		private int skyBoxId_;

		// Token: 0x0400838B RID: 33675
		public const int RoguelikeRoomIdFieldNumber = 14;

		// Token: 0x0400838C RID: 33676
		private int roguelikeRoomId_;
	}
}
