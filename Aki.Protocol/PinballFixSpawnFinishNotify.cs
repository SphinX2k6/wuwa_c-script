using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D35 RID: 3381
	[NetMessage(EMessageId.PinballFixSpawnFinishNotify)]
	public sealed class PinballFixSpawnFinishNotify : IMessage<PinballFixSpawnFinishNotify>, IMessage, IEquatable<PinballFixSpawnFinishNotify>, IDeepCloneable<PinballFixSpawnFinishNotify>, IBufferMessage
	{
		// Token: 0x06012440 RID: 74816 RVA: 0x002AADCC File Offset: 0x002A8FCC
		[NullableContext(1)]
		public static PinballFixSpawnFinishNotify Create()
		{
			return new PinballFixSpawnFinishNotify();
		}

		// Token: 0x17003C83 RID: 15491
		// (get) Token: 0x06012441 RID: 74817 RVA: 0x002AADD3 File Offset: 0x002A8FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C84 RID: 15492
		// (get) Token: 0x06012442 RID: 74818 RVA: 0x002AADD6 File Offset: 0x002A8FD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballFixSpawnFinishNotify.Descriptor;
			}
		}

		// Token: 0x06012443 RID: 74819 RVA: 0x002AADDD File Offset: 0x002A8FDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFixSpawnFinishNotify()
		{
		}

		// Token: 0x06012444 RID: 74820 RVA: 0x002AADE5 File Offset: 0x002A8FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFixSpawnFinishNotify(PinballFixSpawnFinishNotify other) : this()
		{
			this.waveId_ = other.waveId_;
			this.spawnId_ = other.spawnId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012445 RID: 74821 RVA: 0x002AAE16 File Offset: 0x002A9016
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballFixSpawnFinishNotify Clone()
		{
			return new PinballFixSpawnFinishNotify(this);
		}

		// Token: 0x17003C85 RID: 15493
		// (get) Token: 0x06012446 RID: 74822 RVA: 0x002AAE1E File Offset: 0x002A901E
		// (set) Token: 0x06012447 RID: 74823 RVA: 0x002AAE26 File Offset: 0x002A9026
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

		// Token: 0x17003C86 RID: 15494
		// (get) Token: 0x06012448 RID: 74824 RVA: 0x002AAE2F File Offset: 0x002A902F
		// (set) Token: 0x06012449 RID: 74825 RVA: 0x002AAE37 File Offset: 0x002A9037
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

		// Token: 0x0601244A RID: 74826 RVA: 0x002AAE40 File Offset: 0x002A9040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballFixSpawnFinishNotify);
		}

		// Token: 0x0601244B RID: 74827 RVA: 0x002AAE4E File Offset: 0x002A904E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballFixSpawnFinishNotify other)
		{
			return other != null && (other == this || (this.WaveId == other.WaveId && this.SpawnId == other.SpawnId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601244C RID: 74828 RVA: 0x002AAE8C File Offset: 0x002A908C
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

		// Token: 0x0601244D RID: 74829 RVA: 0x002AAEE4 File Offset: 0x002A90E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601244E RID: 74830 RVA: 0x002AAEF1 File Offset: 0x002A90F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601244F RID: 74831 RVA: 0x002AAEFC File Offset: 0x002A90FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SpawnId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.SpawnId);
			}
			if (this.WaveId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.WaveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012450 RID: 74832 RVA: 0x002AAF58 File Offset: 0x002A9158
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

		// Token: 0x06012451 RID: 74833 RVA: 0x002AAFB0 File Offset: 0x002A91B0
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

		// Token: 0x06012452 RID: 74834 RVA: 0x002AB000 File Offset: 0x002A9200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012453 RID: 74835 RVA: 0x002AB00C File Offset: 0x002A920C
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
				if (num != 96U)
				{
					if (num != 112U)
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

		// Token: 0x0400724C RID: 29260
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400724D RID: 29261
		public const int WaveIdFieldNumber = 14;

		// Token: 0x0400724E RID: 29262
		private int waveId_;

		// Token: 0x0400724F RID: 29263
		public const int SpawnIdFieldNumber = 12;

		// Token: 0x04007250 RID: 29264
		private int spawnId_;
	}
}
