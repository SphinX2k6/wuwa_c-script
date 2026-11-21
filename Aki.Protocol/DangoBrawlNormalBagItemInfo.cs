using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200036B RID: 875
	public sealed class DangoBrawlNormalBagItemInfo : IMessage<DangoBrawlNormalBagItemInfo>, IMessage, IEquatable<DangoBrawlNormalBagItemInfo>, IDeepCloneable<DangoBrawlNormalBagItemInfo>, IBufferMessage
	{
		// Token: 0x0600575D RID: 22365 RVA: 0x000D58A1 File Offset: 0x000D3AA1
		[NullableContext(1)]
		public static DangoBrawlNormalBagItemInfo Create()
		{
			return new DangoBrawlNormalBagItemInfo();
		}

		// Token: 0x1700100C RID: 4108
		// (get) Token: 0x0600575E RID: 22366 RVA: 0x000D58A8 File Offset: 0x000D3AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlNormalBagItemInfo> Parser
		{
			get
			{
				return DangoBrawlNormalBagItemInfo._parser;
			}
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x0600575F RID: 22367 RVA: 0x000D58AF File Offset: 0x000D3AAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x06005760 RID: 22368 RVA: 0x000D58B2 File Offset: 0x000D3AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlNormalBagItemInfo.Descriptor;
			}
		}

		// Token: 0x06005761 RID: 22369 RVA: 0x000D58B9 File Offset: 0x000D3AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlNormalBagItemInfo()
		{
		}

		// Token: 0x06005762 RID: 22370 RVA: 0x000D58C4 File Offset: 0x000D3AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlNormalBagItemInfo(DangoBrawlNormalBagItemInfo other) : this()
		{
			this.inst_ = ((other.inst_ != null) ? other.inst_.Clone() : null);
			this.x_ = other.x_;
			this.y_ = other.y_;
			this.rotation_ = other.rotation_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005763 RID: 22371 RVA: 0x000D5928 File Offset: 0x000D3B28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlNormalBagItemInfo Clone()
		{
			return new DangoBrawlNormalBagItemInfo(this);
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06005764 RID: 22372 RVA: 0x000D5930 File Offset: 0x000D3B30
		// (set) Token: 0x06005765 RID: 22373 RVA: 0x000D5938 File Offset: 0x000D3B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlBaseItemInfo Inst
		{
			get
			{
				return this.inst_;
			}
			set
			{
				this.inst_ = value;
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06005766 RID: 22374 RVA: 0x000D5941 File Offset: 0x000D3B41
		// (set) Token: 0x06005767 RID: 22375 RVA: 0x000D5949 File Offset: 0x000D3B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int X
		{
			get
			{
				return this.x_;
			}
			set
			{
				this.x_ = value;
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06005768 RID: 22376 RVA: 0x000D5952 File Offset: 0x000D3B52
		// (set) Token: 0x06005769 RID: 22377 RVA: 0x000D595A File Offset: 0x000D3B5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Y
		{
			get
			{
				return this.y_;
			}
			set
			{
				this.y_ = value;
			}
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x0600576A RID: 22378 RVA: 0x000D5963 File Offset: 0x000D3B63
		// (set) Token: 0x0600576B RID: 22379 RVA: 0x000D596B File Offset: 0x000D3B6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Rotation
		{
			get
			{
				return this.rotation_;
			}
			set
			{
				this.rotation_ = value;
			}
		}

		// Token: 0x0600576C RID: 22380 RVA: 0x000D5974 File Offset: 0x000D3B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlNormalBagItemInfo);
		}

		// Token: 0x0600576D RID: 22381 RVA: 0x000D5984 File Offset: 0x000D3B84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlNormalBagItemInfo other)
		{
			return other != null && (other == this || (object.Equals(this.Inst, other.Inst) && this.X == other.X && this.Y == other.Y && this.Rotation == other.Rotation && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600576E RID: 22382 RVA: 0x000D59F4 File Offset: 0x000D3BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.inst_ != null)
			{
				num ^= this.Inst.GetHashCode();
			}
			if (this.X != 0)
			{
				num ^= this.X.GetHashCode();
			}
			if (this.Y != 0)
			{
				num ^= this.Y.GetHashCode();
			}
			if (this.Rotation != 0)
			{
				num ^= this.Rotation.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600576F RID: 22383 RVA: 0x000D5A7B File Offset: 0x000D3C7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005770 RID: 22384 RVA: 0x000D5A88 File Offset: 0x000D3C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005771 RID: 22385 RVA: 0x000D5A94 File Offset: 0x000D3C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.inst_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Inst);
			}
			if (this.X != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.X);
			}
			if (this.Y != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Y);
			}
			if (this.Rotation != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005772 RID: 22386 RVA: 0x000D5B28 File Offset: 0x000D3D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.inst_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Inst);
			}
			if (this.X != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.X);
			}
			if (this.Y != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Y);
			}
			if (this.Rotation != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Rotation);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005773 RID: 22387 RVA: 0x000D5BB0 File Offset: 0x000D3DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlNormalBagItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.inst_ != null)
			{
				if (this.inst_ == null)
				{
					this.Inst = new DangoBrawlBaseItemInfo();
				}
				this.Inst.MergeFrom(other.Inst);
			}
			if (other.X != 0)
			{
				this.X = other.X;
			}
			if (other.Y != 0)
			{
				this.Y = other.Y;
			}
			if (other.Rotation != 0)
			{
				this.Rotation = other.Rotation;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005774 RID: 22388 RVA: 0x000D5C40 File Offset: 0x000D3E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005775 RID: 22389 RVA: 0x000D5C4C File Offset: 0x000D3E4C
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
					if (num == 10U)
					{
						if (this.inst_ == null)
						{
							this.Inst = new DangoBrawlBaseItemInfo();
						}
						input.ReadMessage(this.Inst);
						continue;
					}
					if (num == 16U)
					{
						this.X = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Y = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Rotation = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003516 RID: 13590
		private static readonly MessageParser<DangoBrawlNormalBagItemInfo> _parser = new MessageParser<DangoBrawlNormalBagItemInfo>(() => new DangoBrawlNormalBagItemInfo());

		// Token: 0x04003517 RID: 13591
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003518 RID: 13592
		public const int InstFieldNumber = 1;

		// Token: 0x04003519 RID: 13593
		private DangoBrawlBaseItemInfo inst_;

		// Token: 0x0400351A RID: 13594
		public const int XFieldNumber = 2;

		// Token: 0x0400351B RID: 13595
		private int x_;

		// Token: 0x0400351C RID: 13596
		public const int YFieldNumber = 3;

		// Token: 0x0400351D RID: 13597
		private int y_;

		// Token: 0x0400351E RID: 13598
		public const int RotationFieldNumber = 4;

		// Token: 0x0400351F RID: 13599
		private int rotation_;
	}
}
