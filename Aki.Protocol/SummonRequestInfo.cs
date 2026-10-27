using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B4 RID: 4788
	public sealed class SummonRequestInfo : IMessage<SummonRequestInfo>, IMessage, IEquatable<SummonRequestInfo>, IDeepCloneable<SummonRequestInfo>, IBufferMessage
	{
		// Token: 0x060197A2 RID: 104354 RVA: 0x003B3D1E File Offset: 0x003B1F1E
		[NullableContext(1)]
		public static SummonRequestInfo Create()
		{
			return new SummonRequestInfo();
		}

		// Token: 0x170055E8 RID: 21992
		// (get) Token: 0x060197A3 RID: 104355 RVA: 0x003B3D25 File Offset: 0x003B1F25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055E9 RID: 21993
		// (get) Token: 0x060197A4 RID: 104356 RVA: 0x003B3D28 File Offset: 0x003B1F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonRequestInfo.Descriptor;
			}
		}

		// Token: 0x060197A5 RID: 104357 RVA: 0x003B3D2F File Offset: 0x003B1F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRequestInfo()
		{
		}

		// Token: 0x060197A6 RID: 104358 RVA: 0x003B3D38 File Offset: 0x003B1F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRequestInfo(SummonRequestInfo other) : this()
		{
			this.summonEntityId_ = other.summonEntityId_;
			this.skillId_ = other.skillId_;
			this.summonConfigId_ = other.summonConfigId_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this.isVisible_ = other.isVisible_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060197A7 RID: 104359 RVA: 0x003B3DC4 File Offset: 0x003B1FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonRequestInfo Clone()
		{
			return new SummonRequestInfo(this);
		}

		// Token: 0x170055EA RID: 21994
		// (get) Token: 0x060197A8 RID: 104360 RVA: 0x003B3DCC File Offset: 0x003B1FCC
		// (set) Token: 0x060197A9 RID: 104361 RVA: 0x003B3DD4 File Offset: 0x003B1FD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SummonEntityId
		{
			get
			{
				return this.summonEntityId_;
			}
			set
			{
				this.summonEntityId_ = value;
			}
		}

		// Token: 0x170055EB RID: 21995
		// (get) Token: 0x060197AA RID: 104362 RVA: 0x003B3DDD File Offset: 0x003B1FDD
		// (set) Token: 0x060197AB RID: 104363 RVA: 0x003B3DE5 File Offset: 0x003B1FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x170055EC RID: 21996
		// (get) Token: 0x060197AC RID: 104364 RVA: 0x003B3DEE File Offset: 0x003B1FEE
		// (set) Token: 0x060197AD RID: 104365 RVA: 0x003B3DF6 File Offset: 0x003B1FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SummonConfigId
		{
			get
			{
				return this.summonConfigId_;
			}
			set
			{
				this.summonConfigId_ = value;
			}
		}

		// Token: 0x170055ED RID: 21997
		// (get) Token: 0x060197AE RID: 104366 RVA: 0x003B3DFF File Offset: 0x003B1FFF
		// (set) Token: 0x060197AF RID: 104367 RVA: 0x003B3E07 File Offset: 0x003B2007
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

		// Token: 0x170055EE RID: 21998
		// (get) Token: 0x060197B0 RID: 104368 RVA: 0x003B3E10 File Offset: 0x003B2010
		// (set) Token: 0x060197B1 RID: 104369 RVA: 0x003B3E18 File Offset: 0x003B2018
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

		// Token: 0x170055EF RID: 21999
		// (get) Token: 0x060197B2 RID: 104370 RVA: 0x003B3E21 File Offset: 0x003B2021
		// (set) Token: 0x060197B3 RID: 104371 RVA: 0x003B3E29 File Offset: 0x003B2029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsVisible
		{
			get
			{
				return this.isVisible_;
			}
			set
			{
				this.isVisible_ = value;
			}
		}

		// Token: 0x060197B4 RID: 104372 RVA: 0x003B3E32 File Offset: 0x003B2032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonRequestInfo);
		}

		// Token: 0x060197B5 RID: 104373 RVA: 0x003B3E40 File Offset: 0x003B2040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonRequestInfo other)
		{
			return other != null && (other == this || (this.SummonEntityId == other.SummonEntityId && this.SkillId == other.SkillId && this.SummonConfigId == other.SummonConfigId && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && this.IsVisible == other.IsVisible && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060197B6 RID: 104374 RVA: 0x003B3ED4 File Offset: 0x003B20D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SummonEntityId != 0L)
			{
				num ^= this.SummonEntityId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.SummonConfigId != 0)
			{
				num ^= this.SummonConfigId.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.rot_ != null)
			{
				num ^= this.Rot.GetHashCode();
			}
			if (this.IsVisible)
			{
				num ^= this.IsVisible.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060197B7 RID: 104375 RVA: 0x003B3F8A File Offset: 0x003B218A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060197B8 RID: 104376 RVA: 0x003B3F97 File Offset: 0x003B2197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060197B9 RID: 104377 RVA: 0x003B3FA0 File Offset: 0x003B21A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SummonEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SummonEntityId);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SkillId);
			}
			if (this.SummonConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SummonConfigId);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Pos);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Rot);
			}
			if (this.IsVisible)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsVisible);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060197BA RID: 104378 RVA: 0x003B4068 File Offset: 0x003B2268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SummonEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SummonEntityId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.SummonConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SummonConfigId);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.rot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rot);
			}
			if (this.IsVisible)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060197BB RID: 104379 RVA: 0x003B4114 File Offset: 0x003B2314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonRequestInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SummonEntityId != 0L)
			{
				this.SummonEntityId = other.SummonEntityId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.SummonConfigId != 0)
			{
				this.SummonConfigId = other.SummonConfigId;
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
			if (other.IsVisible)
			{
				this.IsVisible = other.IsVisible;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060197BC RID: 104380 RVA: 0x003B41E4 File Offset: 0x003B23E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060197BD RID: 104381 RVA: 0x003B41F0 File Offset: 0x003B23F0
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
						this.SummonEntityId = input.ReadInt64();
						continue;
					}
					if (num == 16U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.SummonConfigId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 34U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
					if (num == 42U)
					{
						if (this.rot_ == null)
						{
							this.Rot = new Rotator();
						}
						input.ReadMessage(this.Rot);
						continue;
					}
					if (num == 48U)
					{
						this.IsVisible = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400957B RID: 38267
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400957C RID: 38268
		public const int SummonEntityIdFieldNumber = 1;

		// Token: 0x0400957D RID: 38269
		private long summonEntityId_;

		// Token: 0x0400957E RID: 38270
		public const int SkillIdFieldNumber = 2;

		// Token: 0x0400957F RID: 38271
		private int skillId_;

		// Token: 0x04009580 RID: 38272
		public const int SummonConfigIdFieldNumber = 3;

		// Token: 0x04009581 RID: 38273
		private int summonConfigId_;

		// Token: 0x04009582 RID: 38274
		public const int PosFieldNumber = 4;

		// Token: 0x04009583 RID: 38275
		private Vector pos_;

		// Token: 0x04009584 RID: 38276
		public const int RotFieldNumber = 5;

		// Token: 0x04009585 RID: 38277
		private Rotator rot_;

		// Token: 0x04009586 RID: 38278
		public const int IsVisibleFieldNumber = 6;

		// Token: 0x04009587 RID: 38279
		private bool isVisible_;
	}
}
