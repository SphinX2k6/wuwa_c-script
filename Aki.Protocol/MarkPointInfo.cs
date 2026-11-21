using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000999 RID: 2457
	public sealed class MarkPointInfo : IMessage<MarkPointInfo>, IMessage, IEquatable<MarkPointInfo>, IDeepCloneable<MarkPointInfo>, IBufferMessage
	{
		// Token: 0x0600D805 RID: 55301 RVA: 0x001FC019 File Offset: 0x001FA219
		[NullableContext(1)]
		public static MarkPointInfo Create()
		{
			return new MarkPointInfo();
		}

		// Token: 0x17002BB4 RID: 11188
		// (get) Token: 0x0600D806 RID: 55302 RVA: 0x001FC020 File Offset: 0x001FA220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MarkPointInfo> Parser
		{
			get
			{
				return MarkPointInfo._parser;
			}
		}

		// Token: 0x17002BB5 RID: 11189
		// (get) Token: 0x0600D807 RID: 55303 RVA: 0x001FC027 File Offset: 0x001FA227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BB6 RID: 11190
		// (get) Token: 0x0600D808 RID: 55304 RVA: 0x001FC02A File Offset: 0x001FA22A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkPointInfo.Descriptor;
			}
		}

		// Token: 0x0600D809 RID: 55305 RVA: 0x001FC031 File Offset: 0x001FA231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkPointInfo()
		{
		}

		// Token: 0x0600D80A RID: 55306 RVA: 0x001FC03C File Offset: 0x001FA23C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkPointInfo(MarkPointInfo other) : this()
		{
			this.posX_ = other.posX_;
			this.posY_ = other.posY_;
			this.posZ_ = other.posZ_;
			this.configId_ = other.configId_;
			this.markId_ = other.markId_;
			this.mapId_ = other.mapId_;
			this.markType_ = other.markType_;
			this.entityConfigId_ = other.entityConfigId_;
			this.isDisable_ = other.isDisable_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D80B RID: 55307 RVA: 0x001FC0D8 File Offset: 0x001FA2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkPointInfo Clone()
		{
			return new MarkPointInfo(this);
		}

		// Token: 0x17002BB7 RID: 11191
		// (get) Token: 0x0600D80C RID: 55308 RVA: 0x001FC0E0 File Offset: 0x001FA2E0
		// (set) Token: 0x0600D80D RID: 55309 RVA: 0x001FC0E8 File Offset: 0x001FA2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PosX
		{
			get
			{
				return this.posX_;
			}
			set
			{
				this.posX_ = value;
			}
		}

		// Token: 0x17002BB8 RID: 11192
		// (get) Token: 0x0600D80E RID: 55310 RVA: 0x001FC0F1 File Offset: 0x001FA2F1
		// (set) Token: 0x0600D80F RID: 55311 RVA: 0x001FC0F9 File Offset: 0x001FA2F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PosY
		{
			get
			{
				return this.posY_;
			}
			set
			{
				this.posY_ = value;
			}
		}

		// Token: 0x17002BB9 RID: 11193
		// (get) Token: 0x0600D810 RID: 55312 RVA: 0x001FC102 File Offset: 0x001FA302
		// (set) Token: 0x0600D811 RID: 55313 RVA: 0x001FC10A File Offset: 0x001FA30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float PosZ
		{
			get
			{
				return this.posZ_;
			}
			set
			{
				this.posZ_ = value;
			}
		}

		// Token: 0x17002BBA RID: 11194
		// (get) Token: 0x0600D812 RID: 55314 RVA: 0x001FC113 File Offset: 0x001FA313
		// (set) Token: 0x0600D813 RID: 55315 RVA: 0x001FC11B File Offset: 0x001FA31B
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

		// Token: 0x17002BBB RID: 11195
		// (get) Token: 0x0600D814 RID: 55316 RVA: 0x001FC124 File Offset: 0x001FA324
		// (set) Token: 0x0600D815 RID: 55317 RVA: 0x001FC12C File Offset: 0x001FA32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x17002BBC RID: 11196
		// (get) Token: 0x0600D816 RID: 55318 RVA: 0x001FC135 File Offset: 0x001FA335
		// (set) Token: 0x0600D817 RID: 55319 RVA: 0x001FC13D File Offset: 0x001FA33D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x17002BBD RID: 11197
		// (get) Token: 0x0600D818 RID: 55320 RVA: 0x001FC146 File Offset: 0x001FA346
		// (set) Token: 0x0600D819 RID: 55321 RVA: 0x001FC14E File Offset: 0x001FA34E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkType
		{
			get
			{
				return this.markType_;
			}
			set
			{
				this.markType_ = value;
			}
		}

		// Token: 0x17002BBE RID: 11198
		// (get) Token: 0x0600D81A RID: 55322 RVA: 0x001FC157 File Offset: 0x001FA357
		// (set) Token: 0x0600D81B RID: 55323 RVA: 0x001FC15F File Offset: 0x001FA35F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x17002BBF RID: 11199
		// (get) Token: 0x0600D81C RID: 55324 RVA: 0x001FC168 File Offset: 0x001FA368
		// (set) Token: 0x0600D81D RID: 55325 RVA: 0x001FC170 File Offset: 0x001FA370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsDisable
		{
			get
			{
				return this.isDisable_;
			}
			set
			{
				this.isDisable_ = value;
			}
		}

		// Token: 0x17002BC0 RID: 11200
		// (get) Token: 0x0600D81E RID: 55326 RVA: 0x001FC179 File Offset: 0x001FA379
		// (set) Token: 0x0600D81F RID: 55327 RVA: 0x001FC181 File Offset: 0x001FA381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x0600D820 RID: 55328 RVA: 0x001FC18A File Offset: 0x001FA38A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkPointInfo);
		}

		// Token: 0x0600D821 RID: 55329 RVA: 0x001FC198 File Offset: 0x001FA398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkPointInfo other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosX, other.PosX) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosY, other.PosY) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosZ, other.PosZ) && this.ConfigId == other.ConfigId && this.MarkId == other.MarkId && this.MapId == other.MapId && this.MarkType == other.MarkType && this.EntityConfigId == other.EntityConfigId && this.IsDisable == other.IsDisable && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D822 RID: 55330 RVA: 0x001FC280 File Offset: 0x001FA480
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PosX != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosX);
			}
			if (this.PosY != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosY);
			}
			if (this.PosZ != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.PosZ);
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this.MapId != 0)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this.MarkType != 0)
			{
				num ^= this.MarkType.GetHashCode();
			}
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this.IsDisable)
			{
				num ^= this.IsDisable.GetHashCode();
			}
			if (this.State != MarkState.MarkNormal)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D823 RID: 55331 RVA: 0x001FC3BB File Offset: 0x001FA5BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D824 RID: 55332 RVA: 0x001FC3C8 File Offset: 0x001FA5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D825 RID: 55333 RVA: 0x001FC3D4 File Offset: 0x001FA5D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PosX != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.PosX);
			}
			if (this.PosY != 0f)
			{
				output.WriteRawTag(21);
				output.WriteFloat(this.PosY);
			}
			if (this.PosZ != 0f)
			{
				output.WriteRawTag(29);
				output.WriteFloat(this.PosZ);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ConfigId);
			}
			if (this.MarkId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MarkId);
			}
			if (this.MapId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.MapId);
			}
			if (this.MarkType != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MarkType);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.IsDisable)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsDisable);
			}
			if (this.State != MarkState.MarkNormal)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D826 RID: 55334 RVA: 0x001FC51C File Offset: 0x001FA71C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PosX != 0f)
			{
				num += 5;
			}
			if (this.PosY != 0f)
			{
				num += 5;
			}
			if (this.PosZ != 0f)
			{
				num += 5;
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this.MapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapId);
			}
			if (this.MarkType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkType);
			}
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this.IsDisable)
			{
				num += 2;
			}
			if (this.State != MarkState.MarkNormal)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D827 RID: 55335 RVA: 0x001FC614 File Offset: 0x001FA814
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MarkPointInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PosX != 0f)
			{
				this.PosX = other.PosX;
			}
			if (other.PosY != 0f)
			{
				this.PosY = other.PosY;
			}
			if (other.PosZ != 0f)
			{
				this.PosZ = other.PosZ;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			if (other.MapId != 0)
			{
				this.MapId = other.MapId;
			}
			if (other.MarkType != 0)
			{
				this.MarkType = other.MarkType;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			if (other.IsDisable)
			{
				this.IsDisable = other.IsDisable;
			}
			if (other.State != MarkState.MarkNormal)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D828 RID: 55336 RVA: 0x001FC713 File Offset: 0x001FA913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D829 RID: 55337 RVA: 0x001FC71C File Offset: 0x001FA91C
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
				if (num <= 40U)
				{
					if (num <= 21U)
					{
						if (num == 13U)
						{
							this.PosX = input.ReadFloat();
							continue;
						}
						if (num == 21U)
						{
							this.PosY = input.ReadFloat();
							continue;
						}
					}
					else
					{
						if (num == 29U)
						{
							this.PosZ = input.ReadFloat();
							continue;
						}
						if (num == 32U)
						{
							this.ConfigId = input.ReadInt32();
							continue;
						}
						if (num == 40U)
						{
							this.MarkId = input.ReadInt32();
							continue;
						}
					}
				}
				else if (num <= 56U)
				{
					if (num == 48U)
					{
						this.MapId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.MarkType = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.IsDisable = input.ReadBool();
						continue;
					}
					if (num == 80U)
					{
						this.State = (MarkState)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005A57 RID: 23127
		private static readonly MessageParser<MarkPointInfo> _parser = new MessageParser<MarkPointInfo>(() => new MarkPointInfo());

		// Token: 0x04005A58 RID: 23128
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A59 RID: 23129
		public const int PosXFieldNumber = 1;

		// Token: 0x04005A5A RID: 23130
		private float posX_;

		// Token: 0x04005A5B RID: 23131
		public const int PosYFieldNumber = 2;

		// Token: 0x04005A5C RID: 23132
		private float posY_;

		// Token: 0x04005A5D RID: 23133
		public const int PosZFieldNumber = 3;

		// Token: 0x04005A5E RID: 23134
		private float posZ_;

		// Token: 0x04005A5F RID: 23135
		public const int ConfigIdFieldNumber = 4;

		// Token: 0x04005A60 RID: 23136
		private int configId_;

		// Token: 0x04005A61 RID: 23137
		public const int MarkIdFieldNumber = 5;

		// Token: 0x04005A62 RID: 23138
		private int markId_;

		// Token: 0x04005A63 RID: 23139
		public const int MapIdFieldNumber = 6;

		// Token: 0x04005A64 RID: 23140
		private int mapId_;

		// Token: 0x04005A65 RID: 23141
		public const int MarkTypeFieldNumber = 7;

		// Token: 0x04005A66 RID: 23142
		private int markType_;

		// Token: 0x04005A67 RID: 23143
		public const int EntityConfigIdFieldNumber = 8;

		// Token: 0x04005A68 RID: 23144
		private int entityConfigId_;

		// Token: 0x04005A69 RID: 23145
		public const int IsDisableFieldNumber = 9;

		// Token: 0x04005A6A RID: 23146
		private bool isDisable_;

		// Token: 0x04005A6B RID: 23147
		public const int StateFieldNumber = 10;

		// Token: 0x04005A6C RID: 23148
		private MarkState state_;
	}
}
