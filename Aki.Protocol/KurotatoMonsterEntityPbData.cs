using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000896 RID: 2198
	public sealed class KurotatoMonsterEntityPbData : IMessage<KurotatoMonsterEntityPbData>, IMessage, IEquatable<KurotatoMonsterEntityPbData>, IDeepCloneable<KurotatoMonsterEntityPbData>, IBufferMessage
	{
		// Token: 0x0600C3A0 RID: 50080 RVA: 0x001D0309 File Offset: 0x001CE509
		[NullableContext(1)]
		public static KurotatoMonsterEntityPbData Create()
		{
			return new KurotatoMonsterEntityPbData();
		}

		// Token: 0x17002786 RID: 10118
		// (get) Token: 0x0600C3A1 RID: 50081 RVA: 0x001D0310 File Offset: 0x001CE510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002787 RID: 10119
		// (get) Token: 0x0600C3A2 RID: 50082 RVA: 0x001D0313 File Offset: 0x001CE513
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoMonsterEntityPbData.Descriptor;
			}
		}

		// Token: 0x0600C3A3 RID: 50083 RVA: 0x001D031A File Offset: 0x001CE51A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoMonsterEntityPbData()
		{
		}

		// Token: 0x0600C3A4 RID: 50084 RVA: 0x001D0322 File Offset: 0x001CE522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoMonsterEntityPbData(KurotatoMonsterEntityPbData other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.spawnConfigId_ = other.spawnConfigId_;
			this.spawnConfigGroupIndex_ = other.spawnConfigGroupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C3A5 RID: 50085 RVA: 0x001D035F File Offset: 0x001CE55F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoMonsterEntityPbData Clone()
		{
			return new KurotatoMonsterEntityPbData(this);
		}

		// Token: 0x17002788 RID: 10120
		// (get) Token: 0x0600C3A6 RID: 50086 RVA: 0x001D0367 File Offset: 0x001CE567
		// (set) Token: 0x0600C3A7 RID: 50087 RVA: 0x001D037F File Offset: 0x001CE57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpawnConfigId
		{
			get
			{
				if ((this._hasBits0 & 1) != 0)
				{
					return this.spawnConfigId_;
				}
				return KurotatoMonsterEntityPbData.SpawnConfigIdDefaultValue;
			}
			set
			{
				this._hasBits0 |= 1;
				this.spawnConfigId_ = value;
			}
		}

		// Token: 0x17002789 RID: 10121
		// (get) Token: 0x0600C3A8 RID: 50088 RVA: 0x001D0396 File Offset: 0x001CE596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSpawnConfigId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600C3A9 RID: 50089 RVA: 0x001D03A3 File Offset: 0x001CE5A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSpawnConfigId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x1700278A RID: 10122
		// (get) Token: 0x0600C3AA RID: 50090 RVA: 0x001D03B4 File Offset: 0x001CE5B4
		// (set) Token: 0x0600C3AB RID: 50091 RVA: 0x001D03CC File Offset: 0x001CE5CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpawnConfigGroupIndex
		{
			get
			{
				if ((this._hasBits0 & 2) != 0)
				{
					return this.spawnConfigGroupIndex_;
				}
				return KurotatoMonsterEntityPbData.SpawnConfigGroupIndexDefaultValue;
			}
			set
			{
				this._hasBits0 |= 2;
				this.spawnConfigGroupIndex_ = value;
			}
		}

		// Token: 0x1700278B RID: 10123
		// (get) Token: 0x0600C3AC RID: 50092 RVA: 0x001D03E3 File Offset: 0x001CE5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSpawnConfigGroupIndex
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600C3AD RID: 50093 RVA: 0x001D03F0 File Offset: 0x001CE5F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSpawnConfigGroupIndex()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600C3AE RID: 50094 RVA: 0x001D0401 File Offset: 0x001CE601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoMonsterEntityPbData);
		}

		// Token: 0x0600C3AF RID: 50095 RVA: 0x001D040F File Offset: 0x001CE60F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoMonsterEntityPbData other)
		{
			return other != null && (other == this || (this.SpawnConfigId == other.SpawnConfigId && this.SpawnConfigGroupIndex == other.SpawnConfigGroupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C3B0 RID: 50096 RVA: 0x001D0450 File Offset: 0x001CE650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HasSpawnConfigId)
			{
				num ^= this.SpawnConfigId.GetHashCode();
			}
			if (this.HasSpawnConfigGroupIndex)
			{
				num ^= this.SpawnConfigGroupIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C3B1 RID: 50097 RVA: 0x001D04A8 File Offset: 0x001CE6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C3B2 RID: 50098 RVA: 0x001D04B5 File Offset: 0x001CE6B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C3B3 RID: 50099 RVA: 0x001D04C0 File Offset: 0x001CE6C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasSpawnConfigId)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SpawnConfigId);
			}
			if (this.HasSpawnConfigGroupIndex)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SpawnConfigGroupIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C3B4 RID: 50100 RVA: 0x001D0518 File Offset: 0x001CE718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HasSpawnConfigId)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpawnConfigId);
			}
			if (this.HasSpawnConfigGroupIndex)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpawnConfigGroupIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C3B5 RID: 50101 RVA: 0x001D0570 File Offset: 0x001CE770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoMonsterEntityPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HasSpawnConfigId)
			{
				this.SpawnConfigId = other.SpawnConfigId;
			}
			if (other.HasSpawnConfigGroupIndex)
			{
				this.SpawnConfigGroupIndex = other.SpawnConfigGroupIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C3B6 RID: 50102 RVA: 0x001D05C0 File Offset: 0x001CE7C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C3B7 RID: 50103 RVA: 0x001D05CC File Offset: 0x001CE7CC
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SpawnConfigGroupIndex = input.ReadInt32();
					}
				}
				else
				{
					this.SpawnConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040054D3 RID: 21715
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054D4 RID: 21716
		private int _hasBits0;

		// Token: 0x040054D5 RID: 21717
		public const int SpawnConfigIdFieldNumber = 1;

		// Token: 0x040054D6 RID: 21718
		private static readonly int SpawnConfigIdDefaultValue;

		// Token: 0x040054D7 RID: 21719
		private int spawnConfigId_;

		// Token: 0x040054D8 RID: 21720
		public const int SpawnConfigGroupIndexFieldNumber = 2;

		// Token: 0x040054D9 RID: 21721
		private static readonly int SpawnConfigGroupIndexDefaultValue;

		// Token: 0x040054DA RID: 21722
		private int spawnConfigGroupIndex_;
	}
}
