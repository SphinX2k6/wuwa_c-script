using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001351 RID: 4945
	[NetMessage(EMessageId.TestSpawnTemplateEntityPush)]
	public sealed class TestSpawnTemplateEntityPush : IMessage<TestSpawnTemplateEntityPush>, IMessage, IEquatable<TestSpawnTemplateEntityPush>, IDeepCloneable<TestSpawnTemplateEntityPush>, IBufferMessage
	{
		// Token: 0x0601A458 RID: 107608 RVA: 0x003D113F File Offset: 0x003CF33F
		[NullableContext(1)]
		public static TestSpawnTemplateEntityPush Create()
		{
			return new TestSpawnTemplateEntityPush();
		}

		// Token: 0x170058A2 RID: 22690
		// (get) Token: 0x0601A459 RID: 107609 RVA: 0x003D1146 File Offset: 0x003CF346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058A3 RID: 22691
		// (get) Token: 0x0601A45A RID: 107610 RVA: 0x003D1149 File Offset: 0x003CF349
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestSpawnTemplateEntityPush.Descriptor;
			}
		}

		// Token: 0x0601A45B RID: 107611 RVA: 0x003D1150 File Offset: 0x003CF350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestSpawnTemplateEntityPush()
		{
		}

		// Token: 0x0601A45C RID: 107612 RVA: 0x003D1158 File Offset: 0x003CF358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestSpawnTemplateEntityPush(TestSpawnTemplateEntityPush other) : this()
		{
			this.id_ = other.id_;
			this.configId_ = other.configId_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this.rot_ = ((other.rot_ != null) ? other.rot_.Clone() : null);
			this.level_ = other.level_;
			this.extraRatioConfId_ = other.extraRatioConfId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A45D RID: 107613 RVA: 0x003D11E4 File Offset: 0x003CF3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestSpawnTemplateEntityPush Clone()
		{
			return new TestSpawnTemplateEntityPush(this);
		}

		// Token: 0x170058A4 RID: 22692
		// (get) Token: 0x0601A45E RID: 107614 RVA: 0x003D11EC File Offset: 0x003CF3EC
		// (set) Token: 0x0601A45F RID: 107615 RVA: 0x003D11F4 File Offset: 0x003CF3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170058A5 RID: 22693
		// (get) Token: 0x0601A460 RID: 107616 RVA: 0x003D11FD File Offset: 0x003CF3FD
		// (set) Token: 0x0601A461 RID: 107617 RVA: 0x003D1205 File Offset: 0x003CF405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x170058A6 RID: 22694
		// (get) Token: 0x0601A462 RID: 107618 RVA: 0x003D120E File Offset: 0x003CF40E
		// (set) Token: 0x0601A463 RID: 107619 RVA: 0x003D1216 File Offset: 0x003CF416
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

		// Token: 0x170058A7 RID: 22695
		// (get) Token: 0x0601A464 RID: 107620 RVA: 0x003D121F File Offset: 0x003CF41F
		// (set) Token: 0x0601A465 RID: 107621 RVA: 0x003D1227 File Offset: 0x003CF427
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

		// Token: 0x170058A8 RID: 22696
		// (get) Token: 0x0601A466 RID: 107622 RVA: 0x003D1230 File Offset: 0x003CF430
		// (set) Token: 0x0601A467 RID: 107623 RVA: 0x003D1238 File Offset: 0x003CF438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x170058A9 RID: 22697
		// (get) Token: 0x0601A468 RID: 107624 RVA: 0x003D1241 File Offset: 0x003CF441
		// (set) Token: 0x0601A469 RID: 107625 RVA: 0x003D1249 File Offset: 0x003CF449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ExtraRatioConfId
		{
			get
			{
				return this.extraRatioConfId_;
			}
			set
			{
				this.extraRatioConfId_ = value;
			}
		}

		// Token: 0x0601A46A RID: 107626 RVA: 0x003D1252 File Offset: 0x003CF452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestSpawnTemplateEntityPush);
		}

		// Token: 0x0601A46B RID: 107627 RVA: 0x003D1260 File Offset: 0x003CF460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TestSpawnTemplateEntityPush other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ConfigId == other.ConfigId && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && this.Level == other.Level && this.ExtraRatioConfId == other.ExtraRatioConfId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A46C RID: 107628 RVA: 0x003D12F4 File Offset: 0x003CF4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this.rot_ != null)
			{
				num ^= this.Rot.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.ExtraRatioConfId != 0)
			{
				num ^= this.ExtraRatioConfId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A46D RID: 107629 RVA: 0x003D13AA File Offset: 0x003CF5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A46E RID: 107630 RVA: 0x003D13B7 File Offset: 0x003CF5B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A46F RID: 107631 RVA: 0x003D13C0 File Offset: 0x003CF5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.Id);
			}
			if (this.ExtraRatioConfId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.ExtraRatioConfId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Level);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(98);
				output.WriteMessage(this.Pos);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ConfigId);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Rot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A470 RID: 107632 RVA: 0x003D148C File Offset: 0x003CF68C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this.rot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Rot);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.ExtraRatioConfId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ExtraRatioConfId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A471 RID: 107633 RVA: 0x003D1544 File Offset: 0x003CF744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TestSpawnTemplateEntityPush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
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
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.ExtraRatioConfId != 0)
			{
				this.ExtraRatioConfId = other.ExtraRatioConfId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A472 RID: 107634 RVA: 0x003D1614 File Offset: 0x003CF814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A473 RID: 107635 RVA: 0x003D1620 File Offset: 0x003CF820
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
				if (num <= 80U)
				{
					if (num == 48U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
					if (num == 64U)
					{
						this.ExtraRatioConfId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 98U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
					if (num == 104U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						if (this.rot_ == null)
						{
							this.Rot = new Rotator();
						}
						input.ReadMessage(this.Rot);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009936 RID: 39222
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009937 RID: 39223
		public const int IdFieldNumber = 6;

		// Token: 0x04009938 RID: 39224
		private long id_;

		// Token: 0x04009939 RID: 39225
		public const int ConfigIdFieldNumber = 13;

		// Token: 0x0400993A RID: 39226
		private int configId_;

		// Token: 0x0400993B RID: 39227
		public const int PosFieldNumber = 12;

		// Token: 0x0400993C RID: 39228
		private Vector pos_;

		// Token: 0x0400993D RID: 39229
		public const int RotFieldNumber = 15;

		// Token: 0x0400993E RID: 39230
		private Rotator rot_;

		// Token: 0x0400993F RID: 39231
		public const int LevelFieldNumber = 10;

		// Token: 0x04009940 RID: 39232
		private int level_;

		// Token: 0x04009941 RID: 39233
		public const int ExtraRatioConfIdFieldNumber = 8;

		// Token: 0x04009942 RID: 39234
		private int extraRatioConfId_;
	}
}
