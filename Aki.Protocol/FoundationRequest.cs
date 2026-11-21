using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000627 RID: 1575
	[NetMessage(EMessageId.FoundationRequest)]
	public sealed class FoundationRequest : IMessage<FoundationRequest>, IMessage, IEquatable<FoundationRequest>, IDeepCloneable<FoundationRequest>, IBufferMessage
	{
		// Token: 0x0600919F RID: 37279 RVA: 0x00160EC6 File Offset: 0x0015F0C6
		[NullableContext(1)]
		public static FoundationRequest Create()
		{
			return new FoundationRequest();
		}

		// Token: 0x17001CF6 RID: 7414
		// (get) Token: 0x060091A0 RID: 37280 RVA: 0x00160ECD File Offset: 0x0015F0CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CF7 RID: 7415
		// (get) Token: 0x060091A1 RID: 37281 RVA: 0x00160ED0 File Offset: 0x0015F0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FoundationRequest.Descriptor;
			}
		}

		// Token: 0x060091A2 RID: 37282 RVA: 0x00160ED7 File Offset: 0x0015F0D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationRequest()
		{
		}

		// Token: 0x060091A3 RID: 37283 RVA: 0x00160EE0 File Offset: 0x0015F0E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationRequest(FoundationRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.accusedEntityId_ = other.accusedEntityId_;
			this.activeOperate_ = other.activeOperate_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091A4 RID: 37284 RVA: 0x00160F60 File Offset: 0x0015F160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationRequest Clone()
		{
			return new FoundationRequest(this);
		}

		// Token: 0x17001CF8 RID: 7416
		// (get) Token: 0x060091A5 RID: 37285 RVA: 0x00160F68 File Offset: 0x0015F168
		// (set) Token: 0x060091A6 RID: 37286 RVA: 0x00160F70 File Offset: 0x0015F170
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

		// Token: 0x17001CF9 RID: 7417
		// (get) Token: 0x060091A7 RID: 37287 RVA: 0x00160F79 File Offset: 0x0015F179
		// (set) Token: 0x060091A8 RID: 37288 RVA: 0x00160F81 File Offset: 0x0015F181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long AccusedEntityId
		{
			get
			{
				return this.accusedEntityId_;
			}
			set
			{
				this.accusedEntityId_ = value;
			}
		}

		// Token: 0x17001CFA RID: 7418
		// (get) Token: 0x060091A9 RID: 37289 RVA: 0x00160F8A File Offset: 0x0015F18A
		// (set) Token: 0x060091AA RID: 37290 RVA: 0x00160F92 File Offset: 0x0015F192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActiveOperate
		{
			get
			{
				return this.activeOperate_;
			}
			set
			{
				this.activeOperate_ = value;
			}
		}

		// Token: 0x17001CFB RID: 7419
		// (get) Token: 0x060091AB RID: 37291 RVA: 0x00160F9B File Offset: 0x0015F19B
		// (set) Token: 0x060091AC RID: 37292 RVA: 0x00160FA3 File Offset: 0x0015F1A3
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

		// Token: 0x17001CFC RID: 7420
		// (get) Token: 0x060091AD RID: 37293 RVA: 0x00160FAC File Offset: 0x0015F1AC
		// (set) Token: 0x060091AE RID: 37294 RVA: 0x00160FB4 File Offset: 0x0015F1B4
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

		// Token: 0x060091AF RID: 37295 RVA: 0x00160FBD File Offset: 0x0015F1BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FoundationRequest);
		}

		// Token: 0x060091B0 RID: 37296 RVA: 0x00160FCC File Offset: 0x0015F1CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FoundationRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.AccusedEntityId == other.AccusedEntityId && this.ActiveOperate == other.ActiveOperate && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060091B1 RID: 37297 RVA: 0x00161050 File Offset: 0x0015F250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.AccusedEntityId != 0L)
			{
				num ^= this.AccusedEntityId.GetHashCode();
			}
			if (this.ActiveOperate != 0)
			{
				num ^= this.ActiveOperate.GetHashCode();
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

		// Token: 0x060091B2 RID: 37298 RVA: 0x001610ED File Offset: 0x0015F2ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060091B3 RID: 37299 RVA: 0x001610FA File Offset: 0x0015F2FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091B4 RID: 37300 RVA: 0x00161104 File Offset: 0x0015F304
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.Pos);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Rot);
			}
			if (this.AccusedEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.AccusedEntityId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.ActiveOperate != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActiveOperate);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060091B5 RID: 37301 RVA: 0x001611B4 File Offset: 0x0015F3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.AccusedEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.AccusedEntityId);
			}
			if (this.ActiveOperate != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActiveOperate);
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

		// Token: 0x060091B6 RID: 37302 RVA: 0x00161254 File Offset: 0x0015F454
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FoundationRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.AccusedEntityId != 0L)
			{
				this.AccusedEntityId = other.AccusedEntityId;
			}
			if (other.ActiveOperate != 0)
			{
				this.ActiveOperate = other.ActiveOperate;
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

		// Token: 0x060091B7 RID: 37303 RVA: 0x00161310 File Offset: 0x0015F510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091B8 RID: 37304 RVA: 0x0016131C File Offset: 0x0015F51C
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
				if (num <= 34U)
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
					if (num == 34U)
					{
						if (this.rot_ == null)
						{
							this.Rot = new Rotator();
						}
						input.ReadMessage(this.Rot);
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.AccusedEntityId = input.ReadInt64();
						continue;
					}
					if (num == 72U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 96U)
					{
						this.ActiveOperate = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040046BC RID: 18108
		private UnknownFieldSet _unknownFields;

		// Token: 0x040046BD RID: 18109
		public const int EntityIdFieldNumber = 9;

		// Token: 0x040046BE RID: 18110
		private long entityId_;

		// Token: 0x040046BF RID: 18111
		public const int AccusedEntityIdFieldNumber = 8;

		// Token: 0x040046C0 RID: 18112
		private long accusedEntityId_;

		// Token: 0x040046C1 RID: 18113
		public const int ActiveOperateFieldNumber = 12;

		// Token: 0x040046C2 RID: 18114
		private int activeOperate_;

		// Token: 0x040046C3 RID: 18115
		public const int PosFieldNumber = 1;

		// Token: 0x040046C4 RID: 18116
		private Vector pos_;

		// Token: 0x040046C5 RID: 18117
		public const int RotFieldNumber = 4;

		// Token: 0x040046C6 RID: 18118
		private Rotator rot_;
	}
}
