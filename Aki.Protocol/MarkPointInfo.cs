using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009AA RID: 2474
	public sealed class MarkPointInfo : IMessage<MarkPointInfo>, IMessage, IEquatable<MarkPointInfo>, IDeepCloneable<MarkPointInfo>, IBufferMessage
	{
		// Token: 0x0600D91F RID: 55583 RVA: 0x001FE20D File Offset: 0x001FC40D
		[NullableContext(1)]
		public static MarkPointInfo Create()
		{
			return new MarkPointInfo();
		}

		// Token: 0x17002BF2 RID: 11250
		// (get) Token: 0x0600D920 RID: 55584 RVA: 0x001FE214 File Offset: 0x001FC414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MarkPointInfo> Parser
		{
			get
			{
				return MarkPointInfo._parser;
			}
		}

		// Token: 0x17002BF3 RID: 11251
		// (get) Token: 0x0600D921 RID: 55585 RVA: 0x001FE21B File Offset: 0x001FC41B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BF4 RID: 11252
		// (get) Token: 0x0600D922 RID: 55586 RVA: 0x001FE21E File Offset: 0x001FC41E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkPointInfo.Descriptor;
			}
		}

		// Token: 0x0600D923 RID: 55587 RVA: 0x001FE225 File Offset: 0x001FC425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkPointInfo()
		{
		}

		// Token: 0x0600D924 RID: 55588 RVA: 0x001FE230 File Offset: 0x001FC430
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

		// Token: 0x0600D925 RID: 55589 RVA: 0x001FE2CC File Offset: 0x001FC4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkPointInfo Clone()
		{
			return new MarkPointInfo(this);
		}

		// Token: 0x17002BF5 RID: 11253
		// (get) Token: 0x0600D926 RID: 55590 RVA: 0x001FE2D4 File Offset: 0x001FC4D4
		// (set) Token: 0x0600D927 RID: 55591 RVA: 0x001FE2DC File Offset: 0x001FC4DC
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

		// Token: 0x17002BF6 RID: 11254
		// (get) Token: 0x0600D928 RID: 55592 RVA: 0x001FE2E5 File Offset: 0x001FC4E5
		// (set) Token: 0x0600D929 RID: 55593 RVA: 0x001FE2ED File Offset: 0x001FC4ED
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

		// Token: 0x17002BF7 RID: 11255
		// (get) Token: 0x0600D92A RID: 55594 RVA: 0x001FE2F6 File Offset: 0x001FC4F6
		// (set) Token: 0x0600D92B RID: 55595 RVA: 0x001FE2FE File Offset: 0x001FC4FE
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

		// Token: 0x17002BF8 RID: 11256
		// (get) Token: 0x0600D92C RID: 55596 RVA: 0x001FE307 File Offset: 0x001FC507
		// (set) Token: 0x0600D92D RID: 55597 RVA: 0x001FE30F File Offset: 0x001FC50F
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

		// Token: 0x17002BF9 RID: 11257
		// (get) Token: 0x0600D92E RID: 55598 RVA: 0x001FE318 File Offset: 0x001FC518
		// (set) Token: 0x0600D92F RID: 55599 RVA: 0x001FE320 File Offset: 0x001FC520
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

		// Token: 0x17002BFA RID: 11258
		// (get) Token: 0x0600D930 RID: 55600 RVA: 0x001FE329 File Offset: 0x001FC529
		// (set) Token: 0x0600D931 RID: 55601 RVA: 0x001FE331 File Offset: 0x001FC531
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

		// Token: 0x17002BFB RID: 11259
		// (get) Token: 0x0600D932 RID: 55602 RVA: 0x001FE33A File Offset: 0x001FC53A
		// (set) Token: 0x0600D933 RID: 55603 RVA: 0x001FE342 File Offset: 0x001FC542
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

		// Token: 0x17002BFC RID: 11260
		// (get) Token: 0x0600D934 RID: 55604 RVA: 0x001FE34B File Offset: 0x001FC54B
		// (set) Token: 0x0600D935 RID: 55605 RVA: 0x001FE353 File Offset: 0x001FC553
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

		// Token: 0x17002BFD RID: 11261
		// (get) Token: 0x0600D936 RID: 55606 RVA: 0x001FE35C File Offset: 0x001FC55C
		// (set) Token: 0x0600D937 RID: 55607 RVA: 0x001FE364 File Offset: 0x001FC564
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

		// Token: 0x17002BFE RID: 11262
		// (get) Token: 0x0600D938 RID: 55608 RVA: 0x001FE36D File Offset: 0x001FC56D
		// (set) Token: 0x0600D939 RID: 55609 RVA: 0x001FE375 File Offset: 0x001FC575
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

		// Token: 0x0600D93A RID: 55610 RVA: 0x001FE37E File Offset: 0x001FC57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkPointInfo);
		}

		// Token: 0x0600D93B RID: 55611 RVA: 0x001FE38C File Offset: 0x001FC58C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkPointInfo other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosX, other.PosX) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosY, other.PosY) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosZ, other.PosZ) && this.ConfigId == other.ConfigId && this.MarkId == other.MarkId && this.MapId == other.MapId && this.MarkType == other.MarkType && this.EntityConfigId == other.EntityConfigId && this.IsDisable == other.IsDisable && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D93C RID: 55612 RVA: 0x001FE474 File Offset: 0x001FC674
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

		// Token: 0x0600D93D RID: 55613 RVA: 0x001FE5AF File Offset: 0x001FC7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D93E RID: 55614 RVA: 0x001FE5BC File Offset: 0x001FC7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D93F RID: 55615 RVA: 0x001FE5C8 File Offset: 0x001FC7C8
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

		// Token: 0x0600D940 RID: 55616 RVA: 0x001FE710 File Offset: 0x001FC910
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

		// Token: 0x0600D941 RID: 55617 RVA: 0x001FE808 File Offset: 0x001FCA08
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

		// Token: 0x0600D942 RID: 55618 RVA: 0x001FE907 File Offset: 0x001FCB07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D943 RID: 55619 RVA: 0x001FE910 File Offset: 0x001FCB10
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

		// Token: 0x04005A4E RID: 23118
		private static readonly MessageParser<MarkPointInfo> _parser = new MessageParser<MarkPointInfo>(() => new MarkPointInfo());

		// Token: 0x04005A4F RID: 23119
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A50 RID: 23120
		public const int PosXFieldNumber = 1;

		// Token: 0x04005A51 RID: 23121
		private float posX_;

		// Token: 0x04005A52 RID: 23122
		public const int PosYFieldNumber = 2;

		// Token: 0x04005A53 RID: 23123
		private float posY_;

		// Token: 0x04005A54 RID: 23124
		public const int PosZFieldNumber = 3;

		// Token: 0x04005A55 RID: 23125
		private float posZ_;

		// Token: 0x04005A56 RID: 23126
		public const int ConfigIdFieldNumber = 4;

		// Token: 0x04005A57 RID: 23127
		private int configId_;

		// Token: 0x04005A58 RID: 23128
		public const int MarkIdFieldNumber = 5;

		// Token: 0x04005A59 RID: 23129
		private int markId_;

		// Token: 0x04005A5A RID: 23130
		public const int MapIdFieldNumber = 6;

		// Token: 0x04005A5B RID: 23131
		private int mapId_;

		// Token: 0x04005A5C RID: 23132
		public const int MarkTypeFieldNumber = 7;

		// Token: 0x04005A5D RID: 23133
		private int markType_;

		// Token: 0x04005A5E RID: 23134
		public const int EntityConfigIdFieldNumber = 8;

		// Token: 0x04005A5F RID: 23135
		private int entityConfigId_;

		// Token: 0x04005A60 RID: 23136
		public const int IsDisableFieldNumber = 9;

		// Token: 0x04005A61 RID: 23137
		private bool isDisable_;

		// Token: 0x04005A62 RID: 23138
		public const int StateFieldNumber = 10;

		// Token: 0x04005A63 RID: 23139
		private MarkState state_;
	}
}
