using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000549 RID: 1353
	[NetMessage(EMessageId.FishingBoatDieNotify)]
	public sealed class FishingBoatDieNotify : IMessage<FishingBoatDieNotify>, IMessage, IEquatable<FishingBoatDieNotify>, IDeepCloneable<FishingBoatDieNotify>, IBufferMessage
	{
		// Token: 0x06007E86 RID: 32390 RVA: 0x00132305 File Offset: 0x00130505
		[NullableContext(1)]
		public static FishingBoatDieNotify Create()
		{
			return new FishingBoatDieNotify();
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x06007E87 RID: 32391 RVA: 0x0013230C File Offset: 0x0013050C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700189F RID: 6303
		// (get) Token: 0x06007E88 RID: 32392 RVA: 0x0013230F File Offset: 0x0013050F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingBoatDieNotify.Descriptor;
			}
		}

		// Token: 0x06007E89 RID: 32393 RVA: 0x00132316 File Offset: 0x00130516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBoatDieNotify()
		{
		}

		// Token: 0x06007E8A RID: 32394 RVA: 0x00132320 File Offset: 0x00130520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBoatDieNotify(FishingBoatDieNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007E8B RID: 32395 RVA: 0x00132388 File Offset: 0x00130588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBoatDieNotify Clone()
		{
			return new FishingBoatDieNotify(this);
		}

		// Token: 0x170018A0 RID: 6304
		// (get) Token: 0x06007E8C RID: 32396 RVA: 0x00132390 File Offset: 0x00130590
		// (set) Token: 0x06007E8D RID: 32397 RVA: 0x00132398 File Offset: 0x00130598
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

		// Token: 0x170018A1 RID: 6305
		// (get) Token: 0x06007E8E RID: 32398 RVA: 0x001323A1 File Offset: 0x001305A1
		// (set) Token: 0x06007E8F RID: 32399 RVA: 0x001323A9 File Offset: 0x001305A9
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

		// Token: 0x170018A2 RID: 6306
		// (get) Token: 0x06007E90 RID: 32400 RVA: 0x001323B2 File Offset: 0x001305B2
		// (set) Token: 0x06007E91 RID: 32401 RVA: 0x001323BA File Offset: 0x001305BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator Rot
		{
			get
			{
				return this.rot_;
			}
			set
			{
				this.rot_ = value;
			}
		}

		// Token: 0x06007E92 RID: 32402 RVA: 0x001323C3 File Offset: 0x001305C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingBoatDieNotify);
		}

		// Token: 0x06007E93 RID: 32403 RVA: 0x001323D4 File Offset: 0x001305D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingBoatDieNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007E94 RID: 32404 RVA: 0x00132438 File Offset: 0x00130638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.rot_ != null)
			{
				num ^= this.Rot.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007E95 RID: 32405 RVA: 0x001324A3 File Offset: 0x001306A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007E96 RID: 32406 RVA: 0x001324B0 File Offset: 0x001306B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007E97 RID: 32407 RVA: 0x001324BC File Offset: 0x001306BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Pos);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Rot);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007E98 RID: 32408 RVA: 0x00132534 File Offset: 0x00130734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.rot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rot);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007E99 RID: 32409 RVA: 0x001325A4 File Offset: 0x001307A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingBoatDieNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			if (other.rot_ != null)
			{
				if (this.rot_ == null)
				{
					this.Rot = new Rotator();
				}
				this.Rot.MergeFrom(other.Rot);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007E9A RID: 32410 RVA: 0x00132638 File Offset: 0x00130838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007E9B RID: 32411 RVA: 0x00132644 File Offset: 0x00130844
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
				if (num != 26U)
				{
					if (num != 50U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EntityId = input.ReadInt64();
						}
					}
					else
					{
						if (this.rot_ == null)
						{
							this.Rot = new Rotator();
						}
						input.ReadMessage(this.Rot);
					}
				}
				else
				{
					if (this.pos_ == null)
					{
						this.Pos = new Vector();
					}
					input.ReadMessage(this.Pos);
				}
			}
		}

		// Token: 0x0400401D RID: 16413
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400401E RID: 16414
		public const int EntityIdFieldNumber = 13;

		// Token: 0x0400401F RID: 16415
		private long entityId_;

		// Token: 0x04004020 RID: 16416
		public const int PosFieldNumber = 3;

		// Token: 0x04004021 RID: 16417
		private Vector pos_;

		// Token: 0x04004022 RID: 16418
		public const int RotFieldNumber = 6;

		// Token: 0x04004023 RID: 16419
		private Rotator rot_;
	}
}
