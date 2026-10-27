using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008A9 RID: 2217
	[NetMessage(EMessageId.KurotatoNextWaveTypeNotify)]
	public sealed class KurotatoNextWaveTypeNotify : IMessage<KurotatoNextWaveTypeNotify>, IMessage, IEquatable<KurotatoNextWaveTypeNotify>, IDeepCloneable<KurotatoNextWaveTypeNotify>, IBufferMessage
	{
		// Token: 0x0600C4E6 RID: 50406 RVA: 0x001D2ADC File Offset: 0x001D0CDC
		[NullableContext(1)]
		public static KurotatoNextWaveTypeNotify Create()
		{
			return new KurotatoNextWaveTypeNotify();
		}

		// Token: 0x170027CE RID: 10190
		// (get) Token: 0x0600C4E7 RID: 50407 RVA: 0x001D2AE3 File Offset: 0x001D0CE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170027CF RID: 10191
		// (get) Token: 0x0600C4E8 RID: 50408 RVA: 0x001D2AE6 File Offset: 0x001D0CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoNextWaveTypeNotify.Descriptor;
			}
		}

		// Token: 0x0600C4E9 RID: 50409 RVA: 0x001D2AED File Offset: 0x001D0CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoNextWaveTypeNotify()
		{
		}

		// Token: 0x0600C4EA RID: 50410 RVA: 0x001D2AF5 File Offset: 0x001D0CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoNextWaveTypeNotify(KurotatoNextWaveTypeNotify other) : this()
		{
			this.nextWaveType_ = other.nextWaveType_;
			this.nextWaveId_ = other.nextWaveId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C4EB RID: 50411 RVA: 0x001D2B26 File Offset: 0x001D0D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoNextWaveTypeNotify Clone()
		{
			return new KurotatoNextWaveTypeNotify(this);
		}

		// Token: 0x170027D0 RID: 10192
		// (get) Token: 0x0600C4EC RID: 50412 RVA: 0x001D2B2E File Offset: 0x001D0D2E
		// (set) Token: 0x0600C4ED RID: 50413 RVA: 0x001D2B36 File Offset: 0x001D0D36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoNextWaveType NextWaveType
		{
			get
			{
				return this.nextWaveType_;
			}
			set
			{
				this.nextWaveType_ = value;
			}
		}

		// Token: 0x170027D1 RID: 10193
		// (get) Token: 0x0600C4EE RID: 50414 RVA: 0x001D2B3F File Offset: 0x001D0D3F
		// (set) Token: 0x0600C4EF RID: 50415 RVA: 0x001D2B47 File Offset: 0x001D0D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NextWaveId
		{
			get
			{
				return this.nextWaveId_;
			}
			set
			{
				this.nextWaveId_ = value;
			}
		}

		// Token: 0x0600C4F0 RID: 50416 RVA: 0x001D2B50 File Offset: 0x001D0D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoNextWaveTypeNotify);
		}

		// Token: 0x0600C4F1 RID: 50417 RVA: 0x001D2B5E File Offset: 0x001D0D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoNextWaveTypeNotify other)
		{
			return other != null && (other == this || (this.NextWaveType == other.NextWaveType && this.NextWaveId == other.NextWaveId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C4F2 RID: 50418 RVA: 0x001D2B9C File Offset: 0x001D0D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NextWaveType != KurotatoNextWaveType.Default)
			{
				num ^= this.NextWaveType.GetHashCode();
			}
			if (this.NextWaveId != 0)
			{
				num ^= this.NextWaveId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C4F3 RID: 50419 RVA: 0x001D2BFA File Offset: 0x001D0DFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C4F4 RID: 50420 RVA: 0x001D2C07 File Offset: 0x001D0E07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C4F5 RID: 50421 RVA: 0x001D2C10 File Offset: 0x001D0E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NextWaveType != KurotatoNextWaveType.Default)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.NextWaveType);
			}
			if (this.NextWaveId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.NextWaveId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C4F6 RID: 50422 RVA: 0x001D2C6C File Offset: 0x001D0E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NextWaveType != KurotatoNextWaveType.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.NextWaveType);
			}
			if (this.NextWaveId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NextWaveId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C4F7 RID: 50423 RVA: 0x001D2CC4 File Offset: 0x001D0EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoNextWaveTypeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NextWaveType != KurotatoNextWaveType.Default)
			{
				this.NextWaveType = other.NextWaveType;
			}
			if (other.NextWaveId != 0)
			{
				this.NextWaveId = other.NextWaveId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C4F8 RID: 50424 RVA: 0x001D2D14 File Offset: 0x001D0F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C4F9 RID: 50425 RVA: 0x001D2D20 File Offset: 0x001D0F20
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
				if (num != 80U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.NextWaveId = input.ReadInt32();
					}
				}
				else
				{
					this.NextWaveType = (KurotatoNextWaveType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040054D7 RID: 21719
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054D8 RID: 21720
		public const int NextWaveTypeFieldNumber = 10;

		// Token: 0x040054D9 RID: 21721
		private KurotatoNextWaveType nextWaveType_;

		// Token: 0x040054DA RID: 21722
		public const int NextWaveIdFieldNumber = 13;

		// Token: 0x040054DB RID: 21723
		private int nextWaveId_;
	}
}
