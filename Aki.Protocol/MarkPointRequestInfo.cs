using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200099A RID: 2458
	public sealed class MarkPointRequestInfo : IMessage<MarkPointRequestInfo>, IMessage, IEquatable<MarkPointRequestInfo>, IDeepCloneable<MarkPointRequestInfo>, IBufferMessage
	{
		// Token: 0x0600D82B RID: 55339 RVA: 0x001FC852 File Offset: 0x001FAA52
		[NullableContext(1)]
		public static MarkPointRequestInfo Create()
		{
			return new MarkPointRequestInfo();
		}

		// Token: 0x17002BC1 RID: 11201
		// (get) Token: 0x0600D82C RID: 55340 RVA: 0x001FC859 File Offset: 0x001FAA59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MarkPointRequestInfo> Parser
		{
			get
			{
				return MarkPointRequestInfo._parser;
			}
		}

		// Token: 0x17002BC2 RID: 11202
		// (get) Token: 0x0600D82D RID: 55341 RVA: 0x001FC860 File Offset: 0x001FAA60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002BC3 RID: 11203
		// (get) Token: 0x0600D82E RID: 55342 RVA: 0x001FC863 File Offset: 0x001FAA63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MarkPointRequestInfo.Descriptor;
			}
		}

		// Token: 0x0600D82F RID: 55343 RVA: 0x001FC86A File Offset: 0x001FAA6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkPointRequestInfo()
		{
		}

		// Token: 0x0600D830 RID: 55344 RVA: 0x001FC874 File Offset: 0x001FAA74
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

		// Token: 0x0600D831 RID: 55345 RVA: 0x001FC8F8 File Offset: 0x001FAAF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MarkPointRequestInfo Clone()
		{
			return new MarkPointRequestInfo(this);
		}

		// Token: 0x17002BC4 RID: 11204
		// (get) Token: 0x0600D832 RID: 55346 RVA: 0x001FC900 File Offset: 0x001FAB00
		// (set) Token: 0x0600D833 RID: 55347 RVA: 0x001FC908 File Offset: 0x001FAB08
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

		// Token: 0x17002BC5 RID: 11205
		// (get) Token: 0x0600D834 RID: 55348 RVA: 0x001FC911 File Offset: 0x001FAB11
		// (set) Token: 0x0600D835 RID: 55349 RVA: 0x001FC919 File Offset: 0x001FAB19
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

		// Token: 0x17002BC6 RID: 11206
		// (get) Token: 0x0600D836 RID: 55350 RVA: 0x001FC922 File Offset: 0x001FAB22
		// (set) Token: 0x0600D837 RID: 55351 RVA: 0x001FC92A File Offset: 0x001FAB2A
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

		// Token: 0x17002BC7 RID: 11207
		// (get) Token: 0x0600D838 RID: 55352 RVA: 0x001FC933 File Offset: 0x001FAB33
		// (set) Token: 0x0600D839 RID: 55353 RVA: 0x001FC93B File Offset: 0x001FAB3B
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

		// Token: 0x17002BC8 RID: 11208
		// (get) Token: 0x0600D83A RID: 55354 RVA: 0x001FC944 File Offset: 0x001FAB44
		// (set) Token: 0x0600D83B RID: 55355 RVA: 0x001FC94C File Offset: 0x001FAB4C
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

		// Token: 0x17002BC9 RID: 11209
		// (get) Token: 0x0600D83C RID: 55356 RVA: 0x001FC955 File Offset: 0x001FAB55
		// (set) Token: 0x0600D83D RID: 55357 RVA: 0x001FC95D File Offset: 0x001FAB5D
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

		// Token: 0x17002BCA RID: 11210
		// (get) Token: 0x0600D83E RID: 55358 RVA: 0x001FC966 File Offset: 0x001FAB66
		// (set) Token: 0x0600D83F RID: 55359 RVA: 0x001FC96E File Offset: 0x001FAB6E
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

		// Token: 0x17002BCB RID: 11211
		// (get) Token: 0x0600D840 RID: 55360 RVA: 0x001FC977 File Offset: 0x001FAB77
		// (set) Token: 0x0600D841 RID: 55361 RVA: 0x001FC97F File Offset: 0x001FAB7F
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

		// Token: 0x0600D842 RID: 55362 RVA: 0x001FC988 File Offset: 0x001FAB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MarkPointRequestInfo);
		}

		// Token: 0x0600D843 RID: 55363 RVA: 0x001FC998 File Offset: 0x001FAB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MarkPointRequestInfo other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosX, other.PosX) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosY, other.PosY) && ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.PosZ, other.PosZ) && this.ConfigId == other.ConfigId && this.MarkType == other.MarkType && this.IsTrace == other.IsTrace && this.MapId == other.MapId && this.EntityConfigId == other.EntityConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D844 RID: 55364 RVA: 0x001FCA60 File Offset: 0x001FAC60
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

		// Token: 0x0600D845 RID: 55365 RVA: 0x001FCB63 File Offset: 0x001FAD63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D846 RID: 55366 RVA: 0x001FCB70 File Offset: 0x001FAD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D847 RID: 55367 RVA: 0x001FCB7C File Offset: 0x001FAD7C
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

		// Token: 0x0600D848 RID: 55368 RVA: 0x001FCC8C File Offset: 0x001FAE8C
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

		// Token: 0x0600D849 RID: 55369 RVA: 0x001FCD54 File Offset: 0x001FAF54
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

		// Token: 0x0600D84A RID: 55370 RVA: 0x001FCE2B File Offset: 0x001FB02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D84B RID: 55371 RVA: 0x001FCE34 File Offset: 0x001FB034
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

		// Token: 0x04005A6D RID: 23149
		private static readonly MessageParser<MarkPointRequestInfo> _parser = new MessageParser<MarkPointRequestInfo>(() => new MarkPointRequestInfo());

		// Token: 0x04005A6E RID: 23150
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005A6F RID: 23151
		public const int PosXFieldNumber = 1;

		// Token: 0x04005A70 RID: 23152
		private float posX_;

		// Token: 0x04005A71 RID: 23153
		public const int PosYFieldNumber = 2;

		// Token: 0x04005A72 RID: 23154
		private float posY_;

		// Token: 0x04005A73 RID: 23155
		public const int PosZFieldNumber = 3;

		// Token: 0x04005A74 RID: 23156
		private float posZ_;

		// Token: 0x04005A75 RID: 23157
		public const int ConfigIdFieldNumber = 4;

		// Token: 0x04005A76 RID: 23158
		private int configId_;

		// Token: 0x04005A77 RID: 23159
		public const int MarkTypeFieldNumber = 5;

		// Token: 0x04005A78 RID: 23160
		private int markType_;

		// Token: 0x04005A79 RID: 23161
		public const int IsTraceFieldNumber = 6;

		// Token: 0x04005A7A RID: 23162
		private bool isTrace_;

		// Token: 0x04005A7B RID: 23163
		public const int MapIdFieldNumber = 7;

		// Token: 0x04005A7C RID: 23164
		private int mapId_;

		// Token: 0x04005A7D RID: 23165
		public const int EntityConfigIdFieldNumber = 8;

		// Token: 0x04005A7E RID: 23166
		private int entityConfigId_;
	}
}
