using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009E5 RID: 2533
	public sealed class MonsterCaptureComponentPb : IMessage<MonsterCaptureComponentPb>, IMessage, IEquatable<MonsterCaptureComponentPb>, IDeepCloneable<MonsterCaptureComponentPb>, IBufferMessage
	{
		// Token: 0x0600DE2C RID: 56876 RVA: 0x00209971 File Offset: 0x00207B71
		[NullableContext(1)]
		public static MonsterCaptureComponentPb Create()
		{
			return new MonsterCaptureComponentPb();
		}

		// Token: 0x17002D03 RID: 11523
		// (get) Token: 0x0600DE2D RID: 56877 RVA: 0x00209978 File Offset: 0x00207B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002D04 RID: 11524
		// (get) Token: 0x0600DE2E RID: 56878 RVA: 0x0020997B File Offset: 0x00207B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MonsterCaptureComponentPb.Descriptor;
			}
		}

		// Token: 0x0600DE2F RID: 56879 RVA: 0x00209982 File Offset: 0x00207B82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCaptureComponentPb()
		{
		}

		// Token: 0x0600DE30 RID: 56880 RVA: 0x0020998A File Offset: 0x00207B8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCaptureComponentPb(MonsterCaptureComponentPb other) : this()
		{
			this.templateId_ = other.templateId_;
			this.entityId_ = other.entityId_;
			this.monsterId_ = other.monsterId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DE31 RID: 56881 RVA: 0x002099C7 File Offset: 0x00207BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MonsterCaptureComponentPb Clone()
		{
			return new MonsterCaptureComponentPb(this);
		}

		// Token: 0x17002D05 RID: 11525
		// (get) Token: 0x0600DE32 RID: 56882 RVA: 0x002099CF File Offset: 0x00207BCF
		// (set) Token: 0x0600DE33 RID: 56883 RVA: 0x002099D7 File Offset: 0x00207BD7
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

		// Token: 0x17002D06 RID: 11526
		// (get) Token: 0x0600DE34 RID: 56884 RVA: 0x002099E0 File Offset: 0x00207BE0
		// (set) Token: 0x0600DE35 RID: 56885 RVA: 0x002099E8 File Offset: 0x00207BE8
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

		// Token: 0x17002D07 RID: 11527
		// (get) Token: 0x0600DE36 RID: 56886 RVA: 0x002099F1 File Offset: 0x00207BF1
		// (set) Token: 0x0600DE37 RID: 56887 RVA: 0x002099F9 File Offset: 0x00207BF9
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

		// Token: 0x0600DE38 RID: 56888 RVA: 0x00209A02 File Offset: 0x00207C02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MonsterCaptureComponentPb);
		}

		// Token: 0x0600DE39 RID: 56889 RVA: 0x00209A10 File Offset: 0x00207C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MonsterCaptureComponentPb other)
		{
			return other != null && (other == this || (this.TemplateId == other.TemplateId && this.EntityId == other.EntityId && this.MonsterId == other.MonsterId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DE3A RID: 56890 RVA: 0x00209A6C File Offset: 0x00207C6C
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

		// Token: 0x0600DE3B RID: 56891 RVA: 0x00209ADD File Offset: 0x00207CDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DE3C RID: 56892 RVA: 0x00209AEA File Offset: 0x00207CEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DE3D RID: 56893 RVA: 0x00209AF4 File Offset: 0x00207CF4
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

		// Token: 0x0600DE3E RID: 56894 RVA: 0x00209B68 File Offset: 0x00207D68
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

		// Token: 0x0600DE3F RID: 56895 RVA: 0x00209BD8 File Offset: 0x00207DD8
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

		// Token: 0x0600DE40 RID: 56896 RVA: 0x00209C3C File Offset: 0x00207E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DE41 RID: 56897 RVA: 0x00209C48 File Offset: 0x00207E48
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

		// Token: 0x04005C17 RID: 23575
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005C18 RID: 23576
		public const int TemplateIdFieldNumber = 1;

		// Token: 0x04005C19 RID: 23577
		private int templateId_;

		// Token: 0x04005C1A RID: 23578
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04005C1B RID: 23579
		private int entityId_;

		// Token: 0x04005C1C RID: 23580
		public const int MonsterIdFieldNumber = 3;

		// Token: 0x04005C1D RID: 23581
		private int monsterId_;
	}
}
