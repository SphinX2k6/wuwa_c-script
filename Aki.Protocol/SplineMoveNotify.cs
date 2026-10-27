using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200126C RID: 4716
	[NetMessage(EMessageId.SplineMoveNotify)]
	public sealed class SplineMoveNotify : IMessage<SplineMoveNotify>, IMessage, IEquatable<SplineMoveNotify>, IDeepCloneable<SplineMoveNotify>, IBufferMessage
	{
		// Token: 0x060191EC RID: 102892 RVA: 0x003A7555 File Offset: 0x003A5755
		[NullableContext(1)]
		public static SplineMoveNotify Create()
		{
			return new SplineMoveNotify();
		}

		// Token: 0x170054B7 RID: 21687
		// (get) Token: 0x060191ED RID: 102893 RVA: 0x003A755C File Offset: 0x003A575C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054B8 RID: 21688
		// (get) Token: 0x060191EE RID: 102894 RVA: 0x003A755F File Offset: 0x003A575F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SplineMoveNotify.Descriptor;
			}
		}

		// Token: 0x060191EF RID: 102895 RVA: 0x003A7566 File Offset: 0x003A5766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveNotify()
		{
		}

		// Token: 0x060191F0 RID: 102896 RVA: 0x003A7570 File Offset: 0x003A5770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveNotify(SplineMoveNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.pathId_ = other.pathId_;
			this.pathRatio_ = other.pathRatio_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060191F1 RID: 102897 RVA: 0x003A75D4 File Offset: 0x003A57D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveNotify Clone()
		{
			return new SplineMoveNotify(this);
		}

		// Token: 0x170054B9 RID: 21689
		// (get) Token: 0x060191F2 RID: 102898 RVA: 0x003A75DC File Offset: 0x003A57DC
		// (set) Token: 0x060191F3 RID: 102899 RVA: 0x003A75E4 File Offset: 0x003A57E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170054BA RID: 21690
		// (get) Token: 0x060191F4 RID: 102900 RVA: 0x003A75ED File Offset: 0x003A57ED
		// (set) Token: 0x060191F5 RID: 102901 RVA: 0x003A75F5 File Offset: 0x003A57F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PathId
		{
			get
			{
				return this.pathId_;
			}
			set
			{
				this.pathId_ = value;
			}
		}

		// Token: 0x170054BB RID: 21691
		// (get) Token: 0x060191F6 RID: 102902 RVA: 0x003A75FE File Offset: 0x003A57FE
		// (set) Token: 0x060191F7 RID: 102903 RVA: 0x003A7606 File Offset: 0x003A5806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PathRatio
		{
			get
			{
				return this.pathRatio_;
			}
			set
			{
				this.pathRatio_ = value;
			}
		}

		// Token: 0x170054BC RID: 21692
		// (get) Token: 0x060191F8 RID: 102904 RVA: 0x003A760F File Offset: 0x003A580F
		// (set) Token: 0x060191F9 RID: 102905 RVA: 0x003A7617 File Offset: 0x003A5817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x060191FA RID: 102906 RVA: 0x003A7620 File Offset: 0x003A5820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SplineMoveNotify);
		}

		// Token: 0x060191FB RID: 102907 RVA: 0x003A7630 File Offset: 0x003A5830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SplineMoveNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.PathId == other.PathId && this.PathRatio == other.PathRatio && object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060191FC RID: 102908 RVA: 0x003A76A0 File Offset: 0x003A58A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.PathId != 0)
			{
				num ^= this.PathId.GetHashCode();
			}
			if (this.PathRatio != 0)
			{
				num ^= this.PathRatio.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060191FD RID: 102909 RVA: 0x003A7727 File Offset: 0x003A5927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060191FE RID: 102910 RVA: 0x003A7734 File Offset: 0x003A5934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060191FF RID: 102911 RVA: 0x003A7740 File Offset: 0x003A5940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.PathId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PathId);
			}
			if (this.PathRatio != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.PathRatio);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Pos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019200 RID: 102912 RVA: 0x003A77D0 File Offset: 0x003A59D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.PathId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PathId);
			}
			if (this.PathRatio != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PathRatio);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019201 RID: 102913 RVA: 0x003A7858 File Offset: 0x003A5A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SplineMoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.PathId != 0)
			{
				this.PathId = other.PathId;
			}
			if (other.PathRatio != 0)
			{
				this.PathRatio = other.PathRatio;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019202 RID: 102914 RVA: 0x003A78E8 File Offset: 0x003A5AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019203 RID: 102915 RVA: 0x003A78F4 File Offset: 0x003A5AF4
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.PathId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.PathRatio = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040093DC RID: 37852
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093DD RID: 37853
		public const int EntityIdFieldNumber = 1;

		// Token: 0x040093DE RID: 37854
		private long entityId_;

		// Token: 0x040093DF RID: 37855
		public const int PathIdFieldNumber = 3;

		// Token: 0x040093E0 RID: 37856
		private int pathId_;

		// Token: 0x040093E1 RID: 37857
		public const int PathRatioFieldNumber = 13;

		// Token: 0x040093E2 RID: 37858
		private int pathRatio_;

		// Token: 0x040093E3 RID: 37859
		public const int PosFieldNumber = 15;

		// Token: 0x040093E4 RID: 37860
		private Vector pos_;
	}
}
