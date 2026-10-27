using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A7 RID: 2215
	public sealed class KurotatoMonsterEntityPbData : IMessage<KurotatoMonsterEntityPbData>, IMessage, IEquatable<KurotatoMonsterEntityPbData>, IDeepCloneable<KurotatoMonsterEntityPbData>, IBufferMessage
	{
		// Token: 0x0600C4BC RID: 50364 RVA: 0x001D25E9 File Offset: 0x001D07E9
		[NullableContext(1)]
		public static KurotatoMonsterEntityPbData Create()
		{
			return new KurotatoMonsterEntityPbData();
		}

		// Token: 0x170027C5 RID: 10181
		// (get) Token: 0x0600C4BD RID: 50365 RVA: 0x001D25F0 File Offset: 0x001D07F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027C6 RID: 10182
		// (get) Token: 0x0600C4BE RID: 50366 RVA: 0x001D25F3 File Offset: 0x001D07F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoMonsterEntityPbData.Descriptor;
			}
		}

		// Token: 0x0600C4BF RID: 50367 RVA: 0x001D25FA File Offset: 0x001D07FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoMonsterEntityPbData()
		{
		}

		// Token: 0x0600C4C0 RID: 50368 RVA: 0x001D2602 File Offset: 0x001D0802
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoMonsterEntityPbData(KurotatoMonsterEntityPbData other) : this()
		{
			this._hasBits0 = other._hasBits0;
			this.spawnConfigId_ = other.spawnConfigId_;
			this.spawnConfigGroupIndex_ = other.spawnConfigGroupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C4C1 RID: 50369 RVA: 0x001D263F File Offset: 0x001D083F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoMonsterEntityPbData Clone()
		{
			return new KurotatoMonsterEntityPbData(this);
		}

		// Token: 0x170027C7 RID: 10183
		// (get) Token: 0x0600C4C2 RID: 50370 RVA: 0x001D2647 File Offset: 0x001D0847
		// (set) Token: 0x0600C4C3 RID: 50371 RVA: 0x001D265F File Offset: 0x001D085F
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

		// Token: 0x170027C8 RID: 10184
		// (get) Token: 0x0600C4C4 RID: 50372 RVA: 0x001D2676 File Offset: 0x001D0876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSpawnConfigId
		{
			get
			{
				return (this._hasBits0 & 1) != 0;
			}
		}

		// Token: 0x0600C4C5 RID: 50373 RVA: 0x001D2683 File Offset: 0x001D0883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSpawnConfigId()
		{
			this._hasBits0 &= -2;
		}

		// Token: 0x170027C9 RID: 10185
		// (get) Token: 0x0600C4C6 RID: 50374 RVA: 0x001D2694 File Offset: 0x001D0894
		// (set) Token: 0x0600C4C7 RID: 50375 RVA: 0x001D26AC File Offset: 0x001D08AC
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

		// Token: 0x170027CA RID: 10186
		// (get) Token: 0x0600C4C8 RID: 50376 RVA: 0x001D26C3 File Offset: 0x001D08C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasSpawnConfigGroupIndex
		{
			get
			{
				return (this._hasBits0 & 2) != 0;
			}
		}

		// Token: 0x0600C4C9 RID: 50377 RVA: 0x001D26D0 File Offset: 0x001D08D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearSpawnConfigGroupIndex()
		{
			this._hasBits0 &= -3;
		}

		// Token: 0x0600C4CA RID: 50378 RVA: 0x001D26E1 File Offset: 0x001D08E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoMonsterEntityPbData);
		}

		// Token: 0x0600C4CB RID: 50379 RVA: 0x001D26EF File Offset: 0x001D08EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoMonsterEntityPbData other)
		{
			return other != null && (other == this || (this.SpawnConfigId == other.SpawnConfigId && this.SpawnConfigGroupIndex == other.SpawnConfigGroupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C4CC RID: 50380 RVA: 0x001D2730 File Offset: 0x001D0930
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

		// Token: 0x0600C4CD RID: 50381 RVA: 0x001D2788 File Offset: 0x001D0988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C4CE RID: 50382 RVA: 0x001D2795 File Offset: 0x001D0995
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C4CF RID: 50383 RVA: 0x001D27A0 File Offset: 0x001D09A0
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

		// Token: 0x0600C4D0 RID: 50384 RVA: 0x001D27F8 File Offset: 0x001D09F8
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

		// Token: 0x0600C4D1 RID: 50385 RVA: 0x001D2850 File Offset: 0x001D0A50
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

		// Token: 0x0600C4D2 RID: 50386 RVA: 0x001D28A0 File Offset: 0x001D0AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C4D3 RID: 50387 RVA: 0x001D28AC File Offset: 0x001D0AAC
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

		// Token: 0x040054CC RID: 21708
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054CD RID: 21709
		private int _hasBits0;

		// Token: 0x040054CE RID: 21710
		public const int SpawnConfigIdFieldNumber = 1;

		// Token: 0x040054CF RID: 21711
		private static readonly int SpawnConfigIdDefaultValue;

		// Token: 0x040054D0 RID: 21712
		private int spawnConfigId_;

		// Token: 0x040054D1 RID: 21713
		public const int SpawnConfigGroupIndexFieldNumber = 2;

		// Token: 0x040054D2 RID: 21714
		private static readonly int SpawnConfigGroupIndexDefaultValue;

		// Token: 0x040054D3 RID: 21715
		private int spawnConfigGroupIndex_;
	}
}
