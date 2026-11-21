using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D51 RID: 3409
	[NetMessage(EMessageId.PinballSpawnFirstFinishNotify)]
	public sealed class PinballSpawnFirstFinishNotify : IMessage<PinballSpawnFirstFinishNotify>, IMessage, IEquatable<PinballSpawnFirstFinishNotify>, IDeepCloneable<PinballSpawnFirstFinishNotify>, IBufferMessage
	{
		// Token: 0x06012698 RID: 75416 RVA: 0x002B0608 File Offset: 0x002AE808
		[NullableContext(1)]
		public static PinballSpawnFirstFinishNotify Create()
		{
			return new PinballSpawnFirstFinishNotify();
		}

		// Token: 0x17003D0A RID: 15626
		// (get) Token: 0x06012699 RID: 75417 RVA: 0x002B060F File Offset: 0x002AE80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D0B RID: 15627
		// (get) Token: 0x0601269A RID: 75418 RVA: 0x002B0612 File Offset: 0x002AE812
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballSpawnFirstFinishNotify.Descriptor;
			}
		}

		// Token: 0x0601269B RID: 75419 RVA: 0x002B0619 File Offset: 0x002AE819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSpawnFirstFinishNotify()
		{
		}

		// Token: 0x0601269C RID: 75420 RVA: 0x002B0621 File Offset: 0x002AE821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSpawnFirstFinishNotify(PinballSpawnFirstFinishNotify other) : this()
		{
			this.waveId_ = other.waveId_;
			this.spawnId_ = other.spawnId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601269D RID: 75421 RVA: 0x002B0652 File Offset: 0x002AE852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballSpawnFirstFinishNotify Clone()
		{
			return new PinballSpawnFirstFinishNotify(this);
		}

		// Token: 0x17003D0C RID: 15628
		// (get) Token: 0x0601269E RID: 75422 RVA: 0x002B065A File Offset: 0x002AE85A
		// (set) Token: 0x0601269F RID: 75423 RVA: 0x002B0662 File Offset: 0x002AE862
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

		// Token: 0x17003D0D RID: 15629
		// (get) Token: 0x060126A0 RID: 75424 RVA: 0x002B066B File Offset: 0x002AE86B
		// (set) Token: 0x060126A1 RID: 75425 RVA: 0x002B0673 File Offset: 0x002AE873
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

		// Token: 0x060126A2 RID: 75426 RVA: 0x002B067C File Offset: 0x002AE87C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballSpawnFirstFinishNotify);
		}

		// Token: 0x060126A3 RID: 75427 RVA: 0x002B068A File Offset: 0x002AE88A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballSpawnFirstFinishNotify other)
		{
			return other != null && (other == this || (this.WaveId == other.WaveId && this.SpawnId == other.SpawnId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060126A4 RID: 75428 RVA: 0x002B06C8 File Offset: 0x002AE8C8
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

		// Token: 0x060126A5 RID: 75429 RVA: 0x002B0720 File Offset: 0x002AE920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060126A6 RID: 75430 RVA: 0x002B072D File Offset: 0x002AE92D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060126A7 RID: 75431 RVA: 0x002B0738 File Offset: 0x002AE938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SpawnId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SpawnId);
			}
			if (this.WaveId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.WaveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060126A8 RID: 75432 RVA: 0x002B0794 File Offset: 0x002AE994
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

		// Token: 0x060126A9 RID: 75433 RVA: 0x002B07EC File Offset: 0x002AE9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballSpawnFirstFinishNotify other)
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

		// Token: 0x060126AA RID: 75434 RVA: 0x002B083C File Offset: 0x002AEA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060126AB RID: 75435 RVA: 0x002B0848 File Offset: 0x002AEA48
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
				if (num != 24U)
				{
					if (num != 72U)
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

		// Token: 0x04007307 RID: 29447
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007308 RID: 29448
		public const int WaveIdFieldNumber = 9;

		// Token: 0x04007309 RID: 29449
		private int waveId_;

		// Token: 0x0400730A RID: 29450
		public const int SpawnIdFieldNumber = 3;

		// Token: 0x0400730B RID: 29451
		private int spawnId_;
	}
}
