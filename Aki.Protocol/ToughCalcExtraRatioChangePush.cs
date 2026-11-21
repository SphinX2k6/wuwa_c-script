using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001406 RID: 5126
	[NetMessage(EMessageId.ToughCalcExtraRatioChangePush)]
	public sealed class ToughCalcExtraRatioChangePush : IMessage<ToughCalcExtraRatioChangePush>, IMessage, IEquatable<ToughCalcExtraRatioChangePush>, IDeepCloneable<ToughCalcExtraRatioChangePush>, IBufferMessage
	{
		// Token: 0x0601B403 RID: 111619 RVA: 0x003F6C58 File Offset: 0x003F4E58
		[NullableContext(1)]
		public static ToughCalcExtraRatioChangePush Create()
		{
			return new ToughCalcExtraRatioChangePush();
		}

		// Token: 0x17005C3E RID: 23614
		// (get) Token: 0x0601B404 RID: 111620 RVA: 0x003F6C5F File Offset: 0x003F4E5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C3F RID: 23615
		// (get) Token: 0x0601B405 RID: 111621 RVA: 0x003F6C62 File Offset: 0x003F4E62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ToughCalcExtraRatioChangePush.Descriptor;
			}
		}

		// Token: 0x0601B406 RID: 111622 RVA: 0x003F6C69 File Offset: 0x003F4E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangePush()
		{
		}

		// Token: 0x0601B407 RID: 111623 RVA: 0x003F6C71 File Offset: 0x003F4E71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangePush(ToughCalcExtraRatioChangePush other) : this()
		{
			this.id_ = other.id_;
			this.duration_ = other.duration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B408 RID: 111624 RVA: 0x003F6CA2 File Offset: 0x003F4EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangePush Clone()
		{
			return new ToughCalcExtraRatioChangePush(this);
		}

		// Token: 0x17005C40 RID: 23616
		// (get) Token: 0x0601B409 RID: 111625 RVA: 0x003F6CAA File Offset: 0x003F4EAA
		// (set) Token: 0x0601B40A RID: 111626 RVA: 0x003F6CB2 File Offset: 0x003F4EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005C41 RID: 23617
		// (get) Token: 0x0601B40B RID: 111627 RVA: 0x003F6CBB File Offset: 0x003F4EBB
		// (set) Token: 0x0601B40C RID: 111628 RVA: 0x003F6CC3 File Offset: 0x003F4EC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x0601B40D RID: 111629 RVA: 0x003F6CCC File Offset: 0x003F4ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ToughCalcExtraRatioChangePush);
		}

		// Token: 0x0601B40E RID: 111630 RVA: 0x003F6CDA File Offset: 0x003F4EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ToughCalcExtraRatioChangePush other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Duration == other.Duration && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B40F RID: 111631 RVA: 0x003F6D18 File Offset: 0x003F4F18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Duration != 0)
			{
				num ^= this.Duration.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B410 RID: 111632 RVA: 0x003F6D70 File Offset: 0x003F4F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B411 RID: 111633 RVA: 0x003F6D7D File Offset: 0x003F4F7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B412 RID: 111634 RVA: 0x003F6D88 File Offset: 0x003F4F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.Id);
			}
			if (this.Duration != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.Duration);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B413 RID: 111635 RVA: 0x003F6DE4 File Offset: 0x003F4FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.Duration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Duration);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B414 RID: 111636 RVA: 0x003F6E3C File Offset: 0x003F503C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ToughCalcExtraRatioChangePush other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B415 RID: 111637 RVA: 0x003F6E8C File Offset: 0x003F508C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B416 RID: 111638 RVA: 0x003F6E98 File Offset: 0x003F5098
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
				if (num != 48U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Duration = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009ED5 RID: 40661
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009ED6 RID: 40662
		public const int IdFieldNumber = 6;

		// Token: 0x04009ED7 RID: 40663
		private long id_;

		// Token: 0x04009ED8 RID: 40664
		public const int DurationFieldNumber = 9;

		// Token: 0x04009ED9 RID: 40665
		private int duration_;
	}
}
