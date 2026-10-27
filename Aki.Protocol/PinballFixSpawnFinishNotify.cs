using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D45 RID: 3397
	[NetMessage(EMessageId.PinballFixSpawnFinishNotify)]
	public sealed class PinballFixSpawnFinishNotify : IMessage<PinballFixSpawnFinishNotify>, IMessage, IEquatable<PinballFixSpawnFinishNotify>, IDeepCloneable<PinballFixSpawnFinishNotify>, IBufferMessage
	{
		// Token: 0x0601253C RID: 75068 RVA: 0x002AC9EC File Offset: 0x002AABEC
		[NullableContext(1)]
		public static PinballFixSpawnFinishNotify Create()
		{
			return new PinballFixSpawnFinishNotify();
		}

		// Token: 0x17003CB8 RID: 15544
		// (get) Token: 0x0601253D RID: 75069 RVA: 0x002AC9F3 File Offset: 0x002AABF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003CB9 RID: 15545
		// (get) Token: 0x0601253E RID: 75070 RVA: 0x002AC9F6 File Offset: 0x002AABF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballFixSpawnFinishNotify.Descriptor;
			}
		}

		// Token: 0x0601253F RID: 75071 RVA: 0x002AC9FD File Offset: 0x002AABFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFixSpawnFinishNotify()
		{
		}

		// Token: 0x06012540 RID: 75072 RVA: 0x002ACA05 File Offset: 0x002AAC05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFixSpawnFinishNotify(PinballFixSpawnFinishNotify other) : this()
		{
			this.waveId_ = other.waveId_;
			this.spawnId_ = other.spawnId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012541 RID: 75073 RVA: 0x002ACA36 File Offset: 0x002AAC36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFixSpawnFinishNotify Clone()
		{
			return new PinballFixSpawnFinishNotify(this);
		}

		// Token: 0x17003CBA RID: 15546
		// (get) Token: 0x06012542 RID: 75074 RVA: 0x002ACA3E File Offset: 0x002AAC3E
		// (set) Token: 0x06012543 RID: 75075 RVA: 0x002ACA46 File Offset: 0x002AAC46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveId
		{
			get
			{
				return this.waveId_;
			}
			set
			{
				this.waveId_ = value;
			}
		}

		// Token: 0x17003CBB RID: 15547
		// (get) Token: 0x06012544 RID: 75076 RVA: 0x002ACA4F File Offset: 0x002AAC4F
		// (set) Token: 0x06012545 RID: 75077 RVA: 0x002ACA57 File Offset: 0x002AAC57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SpawnId
		{
			get
			{
				return this.spawnId_;
			}
			set
			{
				this.spawnId_ = value;
			}
		}

		// Token: 0x06012546 RID: 75078 RVA: 0x002ACA60 File Offset: 0x002AAC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballFixSpawnFinishNotify);
		}

		// Token: 0x06012547 RID: 75079 RVA: 0x002ACA6E File Offset: 0x002AAC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballFixSpawnFinishNotify other)
		{
			return other != null && (other == this || (this.WaveId == other.WaveId && this.SpawnId == other.SpawnId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012548 RID: 75080 RVA: 0x002ACAAC File Offset: 0x002AACAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WaveId != 0)
			{
				num ^= this.WaveId.GetHashCode();
			}
			if (this.SpawnId != 0)
			{
				num ^= this.SpawnId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012549 RID: 75081 RVA: 0x002ACB04 File Offset: 0x002AAD04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601254A RID: 75082 RVA: 0x002ACB11 File Offset: 0x002AAD11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601254B RID: 75083 RVA: 0x002ACB1C File Offset: 0x002AAD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SpawnId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SpawnId);
			}
			if (this.WaveId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.WaveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601254C RID: 75084 RVA: 0x002ACB74 File Offset: 0x002AAD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WaveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveId);
			}
			if (this.SpawnId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SpawnId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601254D RID: 75085 RVA: 0x002ACBCC File Offset: 0x002AADCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballFixSpawnFinishNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WaveId != 0)
			{
				this.WaveId = other.WaveId;
			}
			if (other.SpawnId != 0)
			{
				this.SpawnId = other.SpawnId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601254E RID: 75086 RVA: 0x002ACC1C File Offset: 0x002AAE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601254F RID: 75087 RVA: 0x002ACC28 File Offset: 0x002AAE28
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.WaveId = input.ReadInt32();
					}
				}
				else
				{
					this.SpawnId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007234 RID: 29236
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007235 RID: 29237
		public const int WaveIdFieldNumber = 15;

		// Token: 0x04007236 RID: 29238
		private int waveId_;

		// Token: 0x04007237 RID: 29239
		public const int SpawnIdFieldNumber = 1;

		// Token: 0x04007238 RID: 29240
		private int spawnId_;
	}
}
