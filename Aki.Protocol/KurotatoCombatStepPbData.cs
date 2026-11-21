using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200087B RID: 2171
	public sealed class KurotatoCombatStepPbData : IMessage<KurotatoCombatStepPbData>, IMessage, IEquatable<KurotatoCombatStepPbData>, IDeepCloneable<KurotatoCombatStepPbData>, IBufferMessage
	{
		// Token: 0x0600C18B RID: 49547 RVA: 0x001CC0DE File Offset: 0x001CA2DE
		[NullableContext(1)]
		public static KurotatoCombatStepPbData Create()
		{
			return new KurotatoCombatStepPbData();
		}

		// Token: 0x1700271D RID: 10013
		// (get) Token: 0x0600C18C RID: 49548 RVA: 0x001CC0E5 File Offset: 0x001CA2E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700271E RID: 10014
		// (get) Token: 0x0600C18D RID: 49549 RVA: 0x001CC0E8 File Offset: 0x001CA2E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoCombatStepPbData.Descriptor;
			}
		}

		// Token: 0x0600C18E RID: 49550 RVA: 0x001CC0EF File Offset: 0x001CA2EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCombatStepPbData()
		{
		}

		// Token: 0x0600C18F RID: 49551 RVA: 0x001CC0F7 File Offset: 0x001CA2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCombatStepPbData(KurotatoCombatStepPbData other) : this()
		{
			this.waveDuration_ = other.waveDuration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C190 RID: 49552 RVA: 0x001CC11C File Offset: 0x001CA31C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCombatStepPbData Clone()
		{
			return new KurotatoCombatStepPbData(this);
		}

		// Token: 0x1700271F RID: 10015
		// (get) Token: 0x0600C191 RID: 49553 RVA: 0x001CC124 File Offset: 0x001CA324
		// (set) Token: 0x0600C192 RID: 49554 RVA: 0x001CC12C File Offset: 0x001CA32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WaveDuration
		{
			get
			{
				return this.waveDuration_;
			}
			set
			{
				this.waveDuration_ = value;
			}
		}

		// Token: 0x0600C193 RID: 49555 RVA: 0x001CC135 File Offset: 0x001CA335
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoCombatStepPbData);
		}

		// Token: 0x0600C194 RID: 49556 RVA: 0x001CC143 File Offset: 0x001CA343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoCombatStepPbData other)
		{
			return other != null && (other == this || (this.WaveDuration == other.WaveDuration && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C195 RID: 49557 RVA: 0x001CC174 File Offset: 0x001CA374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.WaveDuration != 0)
			{
				num ^= this.WaveDuration.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C196 RID: 49558 RVA: 0x001CC1B3 File Offset: 0x001CA3B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C197 RID: 49559 RVA: 0x001CC1C0 File Offset: 0x001CA3C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C198 RID: 49560 RVA: 0x001CC1C9 File Offset: 0x001CA3C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.WaveDuration != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.WaveDuration);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C199 RID: 49561 RVA: 0x001CC1FC File Offset: 0x001CA3FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.WaveDuration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WaveDuration);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C19A RID: 49562 RVA: 0x001CC23A File Offset: 0x001CA43A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoCombatStepPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.WaveDuration != 0)
			{
				this.WaveDuration = other.WaveDuration;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C19B RID: 49563 RVA: 0x001CC26B File Offset: 0x001CA46B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C19C RID: 49564 RVA: 0x001CC274 File Offset: 0x001CA474
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.WaveDuration = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400544E RID: 21582
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400544F RID: 21583
		public const int WaveDurationFieldNumber = 1;

		// Token: 0x04005450 RID: 21584
		private int waveDuration_;
	}
}
