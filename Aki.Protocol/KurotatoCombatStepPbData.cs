using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200088C RID: 2188
	public sealed class KurotatoCombatStepPbData : IMessage<KurotatoCombatStepPbData>, IMessage, IEquatable<KurotatoCombatStepPbData>, IDeepCloneable<KurotatoCombatStepPbData>, IBufferMessage
	{
		// Token: 0x0600C2A7 RID: 49831 RVA: 0x001CE3C6 File Offset: 0x001CC5C6
		[NullableContext(1)]
		public static KurotatoCombatStepPbData Create()
		{
			return new KurotatoCombatStepPbData();
		}

		// Token: 0x1700275C RID: 10076
		// (get) Token: 0x0600C2A8 RID: 49832 RVA: 0x001CE3CD File Offset: 0x001CC5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700275D RID: 10077
		// (get) Token: 0x0600C2A9 RID: 49833 RVA: 0x001CE3D0 File Offset: 0x001CC5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoCombatStepPbData.Descriptor;
			}
		}

		// Token: 0x0600C2AA RID: 49834 RVA: 0x001CE3D7 File Offset: 0x001CC5D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCombatStepPbData()
		{
		}

		// Token: 0x0600C2AB RID: 49835 RVA: 0x001CE3DF File Offset: 0x001CC5DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCombatStepPbData(KurotatoCombatStepPbData other) : this()
		{
			this.waveDuration_ = other.waveDuration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C2AC RID: 49836 RVA: 0x001CE404 File Offset: 0x001CC604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoCombatStepPbData Clone()
		{
			return new KurotatoCombatStepPbData(this);
		}

		// Token: 0x1700275E RID: 10078
		// (get) Token: 0x0600C2AD RID: 49837 RVA: 0x001CE40C File Offset: 0x001CC60C
		// (set) Token: 0x0600C2AE RID: 49838 RVA: 0x001CE414 File Offset: 0x001CC614
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

		// Token: 0x0600C2AF RID: 49839 RVA: 0x001CE41D File Offset: 0x001CC61D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoCombatStepPbData);
		}

		// Token: 0x0600C2B0 RID: 49840 RVA: 0x001CE42B File Offset: 0x001CC62B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoCombatStepPbData other)
		{
			return other != null && (other == this || (this.WaveDuration == other.WaveDuration && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C2B1 RID: 49841 RVA: 0x001CE45C File Offset: 0x001CC65C
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

		// Token: 0x0600C2B2 RID: 49842 RVA: 0x001CE49B File Offset: 0x001CC69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C2B3 RID: 49843 RVA: 0x001CE4A8 File Offset: 0x001CC6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C2B4 RID: 49844 RVA: 0x001CE4B1 File Offset: 0x001CC6B1
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

		// Token: 0x0600C2B5 RID: 49845 RVA: 0x001CE4E4 File Offset: 0x001CC6E4
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

		// Token: 0x0600C2B6 RID: 49846 RVA: 0x001CE522 File Offset: 0x001CC722
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

		// Token: 0x0600C2B7 RID: 49847 RVA: 0x001CE553 File Offset: 0x001CC753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C2B8 RID: 49848 RVA: 0x001CE55C File Offset: 0x001CC75C
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

		// Token: 0x04005447 RID: 21575
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005448 RID: 21576
		public const int WaveDurationFieldNumber = 1;

		// Token: 0x04005449 RID: 21577
		private int waveDuration_;
	}
}
