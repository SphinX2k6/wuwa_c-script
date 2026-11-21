using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012DC RID: 4828
	[NetMessage(EMessageId.SplineMoveRequest)]
	public sealed class SplineMoveRequest : IMessage<SplineMoveRequest>, IMessage, IEquatable<SplineMoveRequest>, IDeepCloneable<SplineMoveRequest>, IBufferMessage
	{
		// Token: 0x06019C3A RID: 105530 RVA: 0x003C20D7 File Offset: 0x003C02D7
		[NullableContext(1)]
		public static SplineMoveRequest Create()
		{
			return new SplineMoveRequest();
		}

		// Token: 0x1700573E RID: 22334
		// (get) Token: 0x06019C3B RID: 105531 RVA: 0x003C20DE File Offset: 0x003C02DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700573F RID: 22335
		// (get) Token: 0x06019C3C RID: 105532 RVA: 0x003C20E1 File Offset: 0x003C02E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SplineMoveRequest.Descriptor;
			}
		}

		// Token: 0x06019C3D RID: 105533 RVA: 0x003C20E8 File Offset: 0x003C02E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveRequest()
		{
		}

		// Token: 0x06019C3E RID: 105534 RVA: 0x003C20F0 File Offset: 0x003C02F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveRequest(SplineMoveRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.pathId_ = other.pathId_;
			this.pathRatio_ = other.pathRatio_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019C3F RID: 105535 RVA: 0x003C2154 File Offset: 0x003C0354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveRequest Clone()
		{
			return new SplineMoveRequest(this);
		}

		// Token: 0x17005740 RID: 22336
		// (get) Token: 0x06019C40 RID: 105536 RVA: 0x003C215C File Offset: 0x003C035C
		// (set) Token: 0x06019C41 RID: 105537 RVA: 0x003C2164 File Offset: 0x003C0364
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

		// Token: 0x17005741 RID: 22337
		// (get) Token: 0x06019C42 RID: 105538 RVA: 0x003C216D File Offset: 0x003C036D
		// (set) Token: 0x06019C43 RID: 105539 RVA: 0x003C2175 File Offset: 0x003C0375
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

		// Token: 0x17005742 RID: 22338
		// (get) Token: 0x06019C44 RID: 105540 RVA: 0x003C217E File Offset: 0x003C037E
		// (set) Token: 0x06019C45 RID: 105541 RVA: 0x003C2186 File Offset: 0x003C0386
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

		// Token: 0x17005743 RID: 22339
		// (get) Token: 0x06019C46 RID: 105542 RVA: 0x003C218F File Offset: 0x003C038F
		// (set) Token: 0x06019C47 RID: 105543 RVA: 0x003C2197 File Offset: 0x003C0397
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

		// Token: 0x06019C48 RID: 105544 RVA: 0x003C21A0 File Offset: 0x003C03A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SplineMoveRequest);
		}

		// Token: 0x06019C49 RID: 105545 RVA: 0x003C21B0 File Offset: 0x003C03B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SplineMoveRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.PathId == other.PathId && this.PathRatio == other.PathRatio && object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019C4A RID: 105546 RVA: 0x003C2220 File Offset: 0x003C0420
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

		// Token: 0x06019C4B RID: 105547 RVA: 0x003C22A7 File Offset: 0x003C04A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019C4C RID: 105548 RVA: 0x003C22B4 File Offset: 0x003C04B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019C4D RID: 105549 RVA: 0x003C22C0 File Offset: 0x003C04C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Pos);
			}
			if (this.PathId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.PathId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this.PathRatio != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.PathRatio);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019C4E RID: 105550 RVA: 0x003C2354 File Offset: 0x003C0554
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

		// Token: 0x06019C4F RID: 105551 RVA: 0x003C23DC File Offset: 0x003C05DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SplineMoveRequest other)
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

		// Token: 0x06019C50 RID: 105552 RVA: 0x003C246C File Offset: 0x003C066C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019C51 RID: 105553 RVA: 0x003C2478 File Offset: 0x003C0678
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
				if (num <= 32U)
				{
					if (num == 10U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
					if (num == 32U)
					{
						this.PathId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.PathRatio = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400980F RID: 38927
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009810 RID: 38928
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04009811 RID: 38929
		private long entityId_;

		// Token: 0x04009812 RID: 38930
		public const int PathIdFieldNumber = 4;

		// Token: 0x04009813 RID: 38931
		private int pathId_;

		// Token: 0x04009814 RID: 38932
		public const int PathRatioFieldNumber = 15;

		// Token: 0x04009815 RID: 38933
		private int pathRatio_;

		// Token: 0x04009816 RID: 38934
		public const int PosFieldNumber = 1;

		// Token: 0x04009817 RID: 38935
		private Vector pos_;
	}
}
