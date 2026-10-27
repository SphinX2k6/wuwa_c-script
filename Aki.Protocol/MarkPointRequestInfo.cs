using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009AB RID: 2475
	public sealed class MarkPointRequestInfo : IMessage<MarkPointRequestInfo>, IMessage, IEquatable<MarkPointRequestInfo>, IDeepCloneable<MarkPointRequestInfo>, IBufferMessage
	{
		// Token: 0x0600D945 RID: 55621 RVA: 0x001FEA46 File Offset: 0x001FCC46
		[NullableContext(1)]
		public static MarkPointRequestInfo Create()
		{
			return new MarkPointRequestInfo();
		}

		// Token: 0x17002BFF RID: 11263
		// (get) Token: 0x0600D946 RID: 55622 RVA: 0x001FEA4D File Offset: 0x001FCC4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MarkPointRequestInfo> Parser
		{
			get
			{
				return MarkPointRequestInfo._parser;
			}
		}

		// Token: 0x17002C00 RID: 11264
		// (get) Token: 0x0600D947 RID: 55623 RVA: 0x001FEA54 File Offset: 0x001FCC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C01 RID: 11265
		// (get) Token: 0x0600D948 RID: 55624 RVA: 0x001FEA57 File Offset: 0x001FCC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkPointRequestInfo.Descriptor;
			}
		}

		// Token: 0x0600D949 RID: 55625 RVA: 0x001FEA5E File Offset: 0x001FCC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkPointRequestInfo()
		{
		}

		// Token: 0x0600D94A RID: 55626 RVA: 0x001FEA68 File Offset: 0x001FCC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkPointRequestInfo(MarkPointRequestInfo other) : this()
		{
			this.posX_ = other.posX_;
			this.posY_ = other.posY_;
			this.posZ_ = other.posZ_;
			this.configId_ = other.configId_;
			this.markType_ = other.markType_;
			this.isTrace_ = other.isTrace_;
			this.mapId_ = other.mapId_;
			this.entityConfigId_ = other.entityConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D94B RID: 55627 RVA: 0x001FEAEC File Offset: 0x001FCCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkPointRequestInfo Clone()
		{
			return new MarkPointRequestInfo(this);
		}

		// Token: 0x17002C02 RID: 11266
		// (get) Token: 0x0600D94C RID: 55628 RVA: 0x001FEAF4 File Offset: 0x001FCCF4
		// (set) Token: 0x0600D94D RID: 55629 RVA: 0x001FEAFC File Offset: 0x001FCCFC
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

		// Token: 0x17002C03 RID: 11267
		// (get) Token: 0x0600D94E RID: 55630 RVA: 0x001FEB05 File Offset: 0x001FCD05
		// (set) Token: 0x0600D94F RID: 55631 RVA: 0x001FEB0D File Offset: 0x001FCD0D
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

		// Token: 0x17002C04 RID: 11268
		// (get) Token: 0x0600D950 RID: 55632 RVA: 0x001FEB16 File Offset: 0x001FCD16
		// (set) Token: 0x0600D951 RID: 55633 RVA: 0x001FEB1E File Offset: 0x001FCD1E
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

		// Token: 0x17002C05 RID: 11269
		// (get) Token: 0x0600D952 RID: 55634 RVA: 0x001FEB27 File Offset: 0x001FCD27
		// (set) Token: 0x0600D953 RID: 55635 RVA: 0x001FEB2F File Offset: 0x001FCD2F
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

		// Token: 0x17002C06 RID: 11270
		// (get) Token: 0x0600D954 RID: 55636 RVA: 0x001FEB38 File Offset: 0x001FCD38
		// (set) Token: 0x0600D955 RID: 55637 RVA: 0x001FEB40 File Offset: 0x001FCD40
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

		// Token: 0x17002C07 RID: 11271
		// (get) Token: 0x0600D956 RID: 55638 RVA: 0x001FEB49 File Offset: 0x001FCD49
		// (set) Token: 0x0600D957 RID: 55639 RVA: 0x001FEB51 File Offset: 0x001FCD51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsTrace
		{
			get
			{
				return this.isTrace_;
			}
			set
			{
				this.isTrace_ = value;
			}
		}

		// Token: 0x17002C08 RID: 11272
		// (get) Token: 0x0600D958 RID: 55640 RVA: 0x001FEB5A File Offset: 0x001FCD5A
		// (set) Token: 0x0600D959 RID: 55641 RVA: 0x001FEB62 File Offset: 0x001FCD62
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

		// Token: 0x17002C09 RID: 11273
		// (get) Token: 0x0600D95A RID: 55642 RVA: 0x001FEB6B File Offset: 0x001FCD6B
		// (set) Token: 0x0600D95B RID: 55643 RVA: 0x001FEB73 File Offset: 0x001FCD73
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

		// Token: 0x0600D95C RID: 55644 RVA: 0x001FEB7C File Offset: 0x001FCD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkPointRequestInfo);
		}

		// Token: 0x0600D95D RID: 55645 RVA: 0x001FEB8C File Offset: 0x001FCD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkPointRequestInfo other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosX, other.PosX) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosY, other.PosY) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosZ, other.PosZ) && this.ConfigId == other.ConfigId && this.MarkType == other.MarkType && this.IsTrace == other.IsTrace && this.MapId == other.MapId && this.EntityConfigId == other.EntityConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D95E RID: 55646 RVA: 0x001FEC54 File Offset: 0x001FCE54
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
			if (this.MarkType != 0)
			{
				num ^= this.MarkType.GetHashCode();
			}
			if (this.IsTrace)
			{
				num ^= this.IsTrace.GetHashCode();
			}
			if (this.MapId != 0)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D95F RID: 55647 RVA: 0x001FED57 File Offset: 0x001FCF57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D960 RID: 55648 RVA: 0x001FED64 File Offset: 0x001FCF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D961 RID: 55649 RVA: 0x001FED70 File Offset: 0x001FCF70
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
			if (this.MarkType != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MarkType);
			}
			if (this.IsTrace)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsTrace);
			}
			if (this.MapId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.MapId);
			}
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D962 RID: 55650 RVA: 0x001FEE80 File Offset: 0x001FD080
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
			if (this.MarkType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkType);
			}
			if (this.IsTrace)
			{
				num += 2;
			}
			if (this.MapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapId);
			}
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D963 RID: 55651 RVA: 0x001FEF48 File Offset: 0x001FD148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MarkPointRequestInfo other)
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
			if (other.MarkType != 0)
			{
				this.MarkType = other.MarkType;
			}
			if (other.IsTrace)
			{
				this.IsTrace = other.IsTrace;
			}
			if (other.MapId != 0)
			{
				this.MapId = other.MapId;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D964 RID: 55652 RVA: 0x001FF01F File Offset: 0x001FD21F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D965 RID: 55653 RVA: 0x001FF028 File Offset: 0x001FD228
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
				if (num <= 32U)
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
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.MarkType = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.IsTrace = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.MapId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.EntityConfigId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005A64 RID: 23140
		private static readonly MessageParser<MarkPointRequestInfo> _parser = new MessageParser<MarkPointRequestInfo>(() => new MarkPointRequestInfo());

		// Token: 0x04005A65 RID: 23141
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A66 RID: 23142
		public const int PosXFieldNumber = 1;

		// Token: 0x04005A67 RID: 23143
		private float posX_;

		// Token: 0x04005A68 RID: 23144
		public const int PosYFieldNumber = 2;

		// Token: 0x04005A69 RID: 23145
		private float posY_;

		// Token: 0x04005A6A RID: 23146
		public const int PosZFieldNumber = 3;

		// Token: 0x04005A6B RID: 23147
		private float posZ_;

		// Token: 0x04005A6C RID: 23148
		public const int ConfigIdFieldNumber = 4;

		// Token: 0x04005A6D RID: 23149
		private int configId_;

		// Token: 0x04005A6E RID: 23150
		public const int MarkTypeFieldNumber = 5;

		// Token: 0x04005A6F RID: 23151
		private int markType_;

		// Token: 0x04005A70 RID: 23152
		public const int IsTraceFieldNumber = 6;

		// Token: 0x04005A71 RID: 23153
		private bool isTrace_;

		// Token: 0x04005A72 RID: 23154
		public const int MapIdFieldNumber = 7;

		// Token: 0x04005A73 RID: 23155
		private int mapId_;

		// Token: 0x04005A74 RID: 23156
		public const int EntityConfigIdFieldNumber = 8;

		// Token: 0x04005A75 RID: 23157
		private int entityConfigId_;
	}
}
