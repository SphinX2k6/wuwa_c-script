using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C4 RID: 5060
	[NetMessage(EMessageId.TestSpawnTemplateEntityPush)]
	public sealed class TestSpawnTemplateEntityPush : IMessage<TestSpawnTemplateEntityPush>, IMessage, IEquatable<TestSpawnTemplateEntityPush>, IDeepCloneable<TestSpawnTemplateEntityPush>, IBufferMessage
	{
		// Token: 0x0601AEDF RID: 110303 RVA: 0x003EC26F File Offset: 0x003EA46F
		[NullableContext(1)]
		public static TestSpawnTemplateEntityPush Create()
		{
			return new TestSpawnTemplateEntityPush();
		}

		// Token: 0x17005B35 RID: 23349
		// (get) Token: 0x0601AEE0 RID: 110304 RVA: 0x003EC276 File Offset: 0x003EA476
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B36 RID: 23350
		// (get) Token: 0x0601AEE1 RID: 110305 RVA: 0x003EC279 File Offset: 0x003EA479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TestSpawnTemplateEntityPush.Descriptor;
			}
		}

		// Token: 0x0601AEE2 RID: 110306 RVA: 0x003EC280 File Offset: 0x003EA480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestSpawnTemplateEntityPush()
		{
		}

		// Token: 0x0601AEE3 RID: 110307 RVA: 0x003EC288 File Offset: 0x003EA488
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

		// Token: 0x0601AEE4 RID: 110308 RVA: 0x003EC314 File Offset: 0x003EA514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TestSpawnTemplateEntityPush Clone()
		{
			return new TestSpawnTemplateEntityPush(this);
		}

		// Token: 0x17005B37 RID: 23351
		// (get) Token: 0x0601AEE5 RID: 110309 RVA: 0x003EC31C File Offset: 0x003EA51C
		// (set) Token: 0x0601AEE6 RID: 110310 RVA: 0x003EC324 File Offset: 0x003EA524
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

		// Token: 0x17005B38 RID: 23352
		// (get) Token: 0x0601AEE7 RID: 110311 RVA: 0x003EC32D File Offset: 0x003EA52D
		// (set) Token: 0x0601AEE8 RID: 110312 RVA: 0x003EC335 File Offset: 0x003EA535
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

		// Token: 0x17005B39 RID: 23353
		// (get) Token: 0x0601AEE9 RID: 110313 RVA: 0x003EC33E File Offset: 0x003EA53E
		// (set) Token: 0x0601AEEA RID: 110314 RVA: 0x003EC346 File Offset: 0x003EA546
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

		// Token: 0x17005B3A RID: 23354
		// (get) Token: 0x0601AEEB RID: 110315 RVA: 0x003EC34F File Offset: 0x003EA54F
		// (set) Token: 0x0601AEEC RID: 110316 RVA: 0x003EC357 File Offset: 0x003EA557
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

		// Token: 0x17005B3B RID: 23355
		// (get) Token: 0x0601AEED RID: 110317 RVA: 0x003EC360 File Offset: 0x003EA560
		// (set) Token: 0x0601AEEE RID: 110318 RVA: 0x003EC368 File Offset: 0x003EA568
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

		// Token: 0x17005B3C RID: 23356
		// (get) Token: 0x0601AEEF RID: 110319 RVA: 0x003EC371 File Offset: 0x003EA571
		// (set) Token: 0x0601AEF0 RID: 110320 RVA: 0x003EC379 File Offset: 0x003EA579
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

		// Token: 0x0601AEF1 RID: 110321 RVA: 0x003EC382 File Offset: 0x003EA582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TestSpawnTemplateEntityPush);
		}

		// Token: 0x0601AEF2 RID: 110322 RVA: 0x003EC390 File Offset: 0x003EA590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TestSpawnTemplateEntityPush other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.ConfigId == other.ConfigId && object.Equals(this.Pos, other.Pos) && object.Equals(this.Rot, other.Rot) && this.Level == other.Level && this.ExtraRatioConfId == other.ExtraRatioConfId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AEF3 RID: 110323 RVA: 0x003EC424 File Offset: 0x003EA624
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

		// Token: 0x0601AEF4 RID: 110324 RVA: 0x003EC4DA File Offset: 0x003EA6DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AEF5 RID: 110325 RVA: 0x003EC4E7 File Offset: 0x003EA6E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AEF6 RID: 110326 RVA: 0x003EC4F0 File Offset: 0x003EA6F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ConfigId);
			}
			if (this.rot_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Rot);
			}
			if (this.pos_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.Pos);
			}
			if (this.ExtraRatioConfId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ExtraRatioConfId);
			}
			if (this.Id != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.Id);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AEF7 RID: 110327 RVA: 0x003EC5BC File Offset: 0x003EA7BC
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

		// Token: 0x0601AEF8 RID: 110328 RVA: 0x003EC674 File Offset: 0x003EA874
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

		// Token: 0x0601AEF9 RID: 110329 RVA: 0x003EC744 File Offset: 0x003EA944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AEFA RID: 110330 RVA: 0x003EC750 File Offset: 0x003EA950
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
				if (num <= 50U)
				{
					if (num == 16U)
					{
						this.ConfigId = input.ReadInt32();
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
					if (num == 50U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
				}
				else
				{
					if (num == 72U)
					{
						this.ExtraRatioConfId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.Id = input.ReadInt64();
						continue;
					}
					if (num == 96U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009D78 RID: 40312
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D79 RID: 40313
		public const int IdFieldNumber = 11;

		// Token: 0x04009D7A RID: 40314
		private long id_;

		// Token: 0x04009D7B RID: 40315
		public const int ConfigIdFieldNumber = 2;

		// Token: 0x04009D7C RID: 40316
		private int configId_;

		// Token: 0x04009D7D RID: 40317
		public const int PosFieldNumber = 6;

		// Token: 0x04009D7E RID: 40318
		private Vector pos_;

		// Token: 0x04009D7F RID: 40319
		public const int RotFieldNumber = 5;

		// Token: 0x04009D80 RID: 40320
		private Rotator rot_;

		// Token: 0x04009D81 RID: 40321
		public const int LevelFieldNumber = 12;

		// Token: 0x04009D82 RID: 40322
		private int level_;

		// Token: 0x04009D83 RID: 40323
		public const int ExtraRatioConfIdFieldNumber = 9;

		// Token: 0x04009D84 RID: 40324
		private int extraRatioConfId_;
	}
}
