using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009F6 RID: 2550
	public sealed class MonsterCaptureComponentPb : IMessage<MonsterCaptureComponentPb>, IMessage, IEquatable<MonsterCaptureComponentPb>, IDeepCloneable<MonsterCaptureComponentPb>, IBufferMessage
	{
		// Token: 0x0600DF46 RID: 57158 RVA: 0x0020BB5D File Offset: 0x00209D5D
		[NullableContext(1)]
		public static MonsterCaptureComponentPb Create()
		{
			return new MonsterCaptureComponentPb();
		}

		// Token: 0x17002D41 RID: 11585
		// (get) Token: 0x0600DF47 RID: 57159 RVA: 0x0020BB64 File Offset: 0x00209D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D42 RID: 11586
		// (get) Token: 0x0600DF48 RID: 57160 RVA: 0x0020BB67 File Offset: 0x00209D67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterCaptureComponentPb.Descriptor;
			}
		}

		// Token: 0x0600DF49 RID: 57161 RVA: 0x0020BB6E File Offset: 0x00209D6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCaptureComponentPb()
		{
		}

		// Token: 0x0600DF4A RID: 57162 RVA: 0x0020BB76 File Offset: 0x00209D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCaptureComponentPb(MonsterCaptureComponentPb other) : this()
		{
			this.templateId_ = other.templateId_;
			this.entityId_ = other.entityId_;
			this.monsterId_ = other.monsterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DF4B RID: 57163 RVA: 0x0020BBB3 File Offset: 0x00209DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCaptureComponentPb Clone()
		{
			return new MonsterCaptureComponentPb(this);
		}

		// Token: 0x17002D43 RID: 11587
		// (get) Token: 0x0600DF4C RID: 57164 RVA: 0x0020BBBB File Offset: 0x00209DBB
		// (set) Token: 0x0600DF4D RID: 57165 RVA: 0x0020BBC3 File Offset: 0x00209DC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TemplateId
		{
			get
			{
				return this.templateId_;
			}
			set
			{
				this.templateId_ = value;
			}
		}

		// Token: 0x17002D44 RID: 11588
		// (get) Token: 0x0600DF4E RID: 57166 RVA: 0x0020BBCC File Offset: 0x00209DCC
		// (set) Token: 0x0600DF4F RID: 57167 RVA: 0x0020BBD4 File Offset: 0x00209DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityId
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

		// Token: 0x17002D45 RID: 11589
		// (get) Token: 0x0600DF50 RID: 57168 RVA: 0x0020BBDD File Offset: 0x00209DDD
		// (set) Token: 0x0600DF51 RID: 57169 RVA: 0x0020BBE5 File Offset: 0x00209DE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x0600DF52 RID: 57170 RVA: 0x0020BBEE File Offset: 0x00209DEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterCaptureComponentPb);
		}

		// Token: 0x0600DF53 RID: 57171 RVA: 0x0020BBFC File Offset: 0x00209DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterCaptureComponentPb other)
		{
			return other != null && (other == this || (this.TemplateId == other.TemplateId && this.EntityId == other.EntityId && this.MonsterId == other.MonsterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DF54 RID: 57172 RVA: 0x0020BC58 File Offset: 0x00209E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TemplateId != 0)
			{
				num ^= this.TemplateId.GetHashCode();
			}
			if (this.EntityId != 0)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.MonsterId != 0)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DF55 RID: 57173 RVA: 0x0020BCC9 File Offset: 0x00209EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DF56 RID: 57174 RVA: 0x0020BCD6 File Offset: 0x00209ED6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DF57 RID: 57175 RVA: 0x0020BCE0 File Offset: 0x00209EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TemplateId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TemplateId);
			}
			if (this.EntityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EntityId);
			}
			if (this.MonsterId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.MonsterId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DF58 RID: 57176 RVA: 0x0020BD54 File Offset: 0x00209F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TemplateId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TemplateId);
			}
			if (this.EntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityId);
			}
			if (this.MonsterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DF59 RID: 57177 RVA: 0x0020BDC4 File Offset: 0x00209FC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MonsterCaptureComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TemplateId != 0)
			{
				this.TemplateId = other.TemplateId;
			}
			if (other.EntityId != 0)
			{
				this.EntityId = other.EntityId;
			}
			if (other.MonsterId != 0)
			{
				this.MonsterId = other.MonsterId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DF5A RID: 57178 RVA: 0x0020BE28 File Offset: 0x0020A028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DF5B RID: 57179 RVA: 0x0020BE34 File Offset: 0x0020A034
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.MonsterId = input.ReadInt32();
						}
					}
					else
					{
						this.EntityId = input.ReadInt32();
					}
				}
				else
				{
					this.TemplateId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005C0E RID: 23566
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C0F RID: 23567
		public const int TemplateIdFieldNumber = 1;

		// Token: 0x04005C10 RID: 23568
		private int templateId_;

		// Token: 0x04005C11 RID: 23569
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04005C12 RID: 23570
		private int entityId_;

		// Token: 0x04005C13 RID: 23571
		public const int MonsterIdFieldNumber = 3;

		// Token: 0x04005C14 RID: 23572
		private int monsterId_;
	}
}
