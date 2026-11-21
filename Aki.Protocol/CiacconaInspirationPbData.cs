using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000297 RID: 663
	public sealed class CiacconaInspirationPbData : IMessage<CiacconaInspirationPbData>, IMessage, IEquatable<CiacconaInspirationPbData>, IDeepCloneable<CiacconaInspirationPbData>, IBufferMessage
	{
		// Token: 0x06004547 RID: 17735 RVA: 0x000AA2A2 File Offset: 0x000A84A2
		[NullableContext(1)]
		public static CiacconaInspirationPbData Create()
		{
			return new CiacconaInspirationPbData();
		}

		// Token: 0x17000BE7 RID: 3047
		// (get) Token: 0x06004548 RID: 17736 RVA: 0x000AA2A9 File Offset: 0x000A84A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BE8 RID: 3048
		// (get) Token: 0x06004549 RID: 17737 RVA: 0x000AA2AC File Offset: 0x000A84AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CiacconaInspirationPbData.Descriptor;
			}
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x000AA2B3 File Offset: 0x000A84B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaInspirationPbData()
		{
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x000AA2BB File Offset: 0x000A84BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaInspirationPbData(CiacconaInspirationPbData other) : this()
		{
			this.inspiration_ = other.inspiration_;
			this.refreshTime_ = other.refreshTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x000AA2EC File Offset: 0x000A84EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CiacconaInspirationPbData Clone()
		{
			return new CiacconaInspirationPbData(this);
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x0600454D RID: 17741 RVA: 0x000AA2F4 File Offset: 0x000A84F4
		// (set) Token: 0x0600454E RID: 17742 RVA: 0x000AA2FC File Offset: 0x000A84FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Inspiration
		{
			get
			{
				return this.inspiration_;
			}
			set
			{
				this.inspiration_ = value;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x0600454F RID: 17743 RVA: 0x000AA305 File Offset: 0x000A8505
		// (set) Token: 0x06004550 RID: 17744 RVA: 0x000AA30D File Offset: 0x000A850D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long RefreshTime
		{
			get
			{
				return this.refreshTime_;
			}
			set
			{
				this.refreshTime_ = value;
			}
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x000AA316 File Offset: 0x000A8516
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CiacconaInspirationPbData);
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x000AA324 File Offset: 0x000A8524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CiacconaInspirationPbData other)
		{
			return other != null && (other == this || (this.Inspiration == other.Inspiration && this.RefreshTime == other.RefreshTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004553 RID: 17747 RVA: 0x000AA364 File Offset: 0x000A8564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Inspiration != 0)
			{
				num ^= this.Inspiration.GetHashCode();
			}
			if (this.RefreshTime != 0L)
			{
				num ^= this.RefreshTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004554 RID: 17748 RVA: 0x000AA3BC File Offset: 0x000A85BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004555 RID: 17749 RVA: 0x000AA3C9 File Offset: 0x000A85C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004556 RID: 17750 RVA: 0x000AA3D4 File Offset: 0x000A85D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Inspiration != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Inspiration);
			}
			if (this.RefreshTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.RefreshTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004557 RID: 17751 RVA: 0x000AA42C File Offset: 0x000A862C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Inspiration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Inspiration);
			}
			if (this.RefreshTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.RefreshTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004558 RID: 17752 RVA: 0x000AA484 File Offset: 0x000A8684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CiacconaInspirationPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Inspiration != 0)
			{
				this.Inspiration = other.Inspiration;
			}
			if (other.RefreshTime != 0L)
			{
				this.RefreshTime = other.RefreshTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004559 RID: 17753 RVA: 0x000AA4D4 File Offset: 0x000A86D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600455A RID: 17754 RVA: 0x000AA4E0 File Offset: 0x000A86E0
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
						this.RefreshTime = input.ReadInt64();
					}
				}
				else
				{
					this.Inspiration = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002F37 RID: 12087
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F38 RID: 12088
		public const int InspirationFieldNumber = 1;

		// Token: 0x04002F39 RID: 12089
		private int inspiration_;

		// Token: 0x04002F3A RID: 12090
		public const int RefreshTimeFieldNumber = 2;

		// Token: 0x04002F3B RID: 12091
		private long refreshTime_;
	}
}
