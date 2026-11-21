using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001713 RID: 5907
	[NetMessage(EMessageId.EnableDamageRecordRequest)]
	public sealed class EnableDamageRecordRequest : IMessage<EnableDamageRecordRequest>, IMessage, IEquatable<EnableDamageRecordRequest>, IDeepCloneable<EnableDamageRecordRequest>, IBufferMessage
	{
		// Token: 0x0601DA98 RID: 121496 RVA: 0x0045A340 File Offset: 0x00458540
		[NullableContext(1)]
		public static EnableDamageRecordRequest Create()
		{
			return new EnableDamageRecordRequest();
		}

		// Token: 0x17006503 RID: 25859
		// (get) Token: 0x0601DA99 RID: 121497 RVA: 0x0045A347 File Offset: 0x00458547
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006504 RID: 25860
		// (get) Token: 0x0601DA9A RID: 121498 RVA: 0x0045A34A File Offset: 0x0045854A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnableDamageRecordRequest.Descriptor;
			}
		}

		// Token: 0x0601DA9B RID: 121499 RVA: 0x0045A351 File Offset: 0x00458551
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableDamageRecordRequest()
		{
		}

		// Token: 0x0601DA9C RID: 121500 RVA: 0x0045A359 File Offset: 0x00458559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableDamageRecordRequest(EnableDamageRecordRequest other) : this()
		{
			this.enable_ = other.enable_;
			this.damageRandomSeed_ = other.damageRandomSeed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DA9D RID: 121501 RVA: 0x0045A38A File Offset: 0x0045858A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableDamageRecordRequest Clone()
		{
			return new EnableDamageRecordRequest(this);
		}

		// Token: 0x17006505 RID: 25861
		// (get) Token: 0x0601DA9E RID: 121502 RVA: 0x0045A392 File Offset: 0x00458592
		// (set) Token: 0x0601DA9F RID: 121503 RVA: 0x0045A39A File Offset: 0x0045859A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Enable
		{
			get
			{
				return this.enable_;
			}
			set
			{
				this.enable_ = value;
			}
		}

		// Token: 0x17006506 RID: 25862
		// (get) Token: 0x0601DAA0 RID: 121504 RVA: 0x0045A3A3 File Offset: 0x004585A3
		// (set) Token: 0x0601DAA1 RID: 121505 RVA: 0x0045A3AB File Offset: 0x004585AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DamageRandomSeed
		{
			get
			{
				return this.damageRandomSeed_;
			}
			set
			{
				this.damageRandomSeed_ = value;
			}
		}

		// Token: 0x0601DAA2 RID: 121506 RVA: 0x0045A3B4 File Offset: 0x004585B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnableDamageRecordRequest);
		}

		// Token: 0x0601DAA3 RID: 121507 RVA: 0x0045A3C2 File Offset: 0x004585C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnableDamageRecordRequest other)
		{
			return other != null && (other == this || (this.Enable == other.Enable && this.DamageRandomSeed == other.DamageRandomSeed && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DAA4 RID: 121508 RVA: 0x0045A400 File Offset: 0x00458600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Enable)
			{
				num ^= this.Enable.GetHashCode();
			}
			if (this.DamageRandomSeed != 0)
			{
				num ^= this.DamageRandomSeed.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DAA5 RID: 121509 RVA: 0x0045A458 File Offset: 0x00458658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DAA6 RID: 121510 RVA: 0x0045A465 File Offset: 0x00458665
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DAA7 RID: 121511 RVA: 0x0045A470 File Offset: 0x00458670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Enable)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.Enable);
			}
			if (this.DamageRandomSeed != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.DamageRandomSeed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DAA8 RID: 121512 RVA: 0x0045A4CC File Offset: 0x004586CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Enable)
			{
				num += 2;
			}
			if (this.DamageRandomSeed != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DamageRandomSeed);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DAA9 RID: 121513 RVA: 0x0045A518 File Offset: 0x00458718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnableDamageRecordRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Enable)
			{
				this.Enable = other.Enable;
			}
			if (other.DamageRandomSeed != 0)
			{
				this.DamageRandomSeed = other.DamageRandomSeed;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DAAA RID: 121514 RVA: 0x0045A568 File Offset: 0x00458768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DAAB RID: 121515 RVA: 0x0045A574 File Offset: 0x00458774
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
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DamageRandomSeed = input.ReadInt32();
					}
				}
				else
				{
					this.Enable = input.ReadBool();
				}
			}
		}

		// Token: 0x0400C8F4 RID: 51444
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C8F5 RID: 51445
		public const int EnableFieldNumber = 6;

		// Token: 0x0400C8F6 RID: 51446
		private bool enable_;

		// Token: 0x0400C8F7 RID: 51447
		public const int DamageRandomSeedFieldNumber = 7;

		// Token: 0x0400C8F8 RID: 51448
		private int damageRandomSeed_;
	}
}
