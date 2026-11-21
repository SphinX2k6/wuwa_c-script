using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000534 RID: 1332
	[NetMessage(EMessageId.FishingBoatDieNotify)]
	public sealed class FishingBoatDieNotify : IMessage<FishingBoatDieNotify>, IMessage, IEquatable<FishingBoatDieNotify>, IDeepCloneable<FishingBoatDieNotify>, IBufferMessage
	{
		// Token: 0x06007D1E RID: 32030 RVA: 0x0012F701 File Offset: 0x0012D901
		[NullableContext(1)]
		public static FishingBoatDieNotify Create()
		{
			return new FishingBoatDieNotify();
		}

		// Token: 0x17001851 RID: 6225
		// (get) Token: 0x06007D1F RID: 32031 RVA: 0x0012F708 File Offset: 0x0012D908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001852 RID: 6226
		// (get) Token: 0x06007D20 RID: 32032 RVA: 0x0012F70B File Offset: 0x0012D90B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingBoatDieNotify.Descriptor;
			}
		}

		// Token: 0x06007D21 RID: 32033 RVA: 0x0012F712 File Offset: 0x0012D912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBoatDieNotify()
		{
		}

		// Token: 0x06007D22 RID: 32034 RVA: 0x0012F71C File Offset: 0x0012D91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBoatDieNotify(FishingBoatDieNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D23 RID: 32035 RVA: 0x0012F784 File Offset: 0x0012D984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingBoatDieNotify Clone()
		{
			return new FishingBoatDieNotify(this);
		}

		// Token: 0x17001853 RID: 6227
		// (get) Token: 0x06007D24 RID: 32036 RVA: 0x0012F78C File Offset: 0x0012D98C
		// (set) Token: 0x06007D25 RID: 32037 RVA: 0x0012F794 File Offset: 0x0012D994
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

		// Token: 0x17001854 RID: 6228
		// (get) Token: 0x06007D26 RID: 32038 RVA: 0x0012F79D File Offset: 0x0012D99D
		// (set) Token: 0x06007D27 RID: 32039 RVA: 0x0012F7A5 File Offset: 0x0012D9A5
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

		// Token: 0x17001855 RID: 6229
		// (get) Token: 0x06007D28 RID: 32040 RVA: 0x0012F7AE File Offset: 0x0012D9AE
		// (set) Token: 0x06007D29 RID: 32041 RVA: 0x0012F7B6 File Offset: 0x0012D9B6
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

		// Token: 0x06007D2A RID: 32042 RVA: 0x0012F7BF File Offset: 0x0012D9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingBoatDieNotify);
		}

		// Token: 0x06007D2B RID: 32043 RVA: 0x0012F7D0 File Offset: 0x0012D9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingBoatDieNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D2C RID: 32044 RVA: 0x0012F834 File Offset: 0x0012DA34
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

		// Token: 0x06007D2D RID: 32045 RVA: 0x0012F89F File Offset: 0x0012DA9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007D2E RID: 32046 RVA: 0x0012F8AC File Offset: 0x0012DAAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D2F RID: 32047 RVA: 0x0012F8B8 File Offset: 0x0012DAB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Rot);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Pos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007D30 RID: 32048 RVA: 0x0012F930 File Offset: 0x0012DB30
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

		// Token: 0x06007D31 RID: 32049 RVA: 0x0012F9A0 File Offset: 0x0012DBA0
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

		// Token: 0x06007D32 RID: 32050 RVA: 0x0012FA34 File Offset: 0x0012DC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D33 RID: 32051 RVA: 0x0012FA40 File Offset: 0x0012DC40
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
				if (num != 16U)
				{
					if (num != 34U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004013 RID: 16403
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004014 RID: 16404
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04004015 RID: 16405
		private long entityId_;

		// Token: 0x04004016 RID: 16406
		public const int PosFieldNumber = 14;

		// Token: 0x04004017 RID: 16407
		private Vector pos_;

		// Token: 0x04004018 RID: 16408
		public const int RotFieldNumber = 4;

		// Token: 0x04004019 RID: 16409
		private Rotator rot_;
	}
}
