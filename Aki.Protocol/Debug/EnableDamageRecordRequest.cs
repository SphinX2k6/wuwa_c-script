using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001697 RID: 5783
	[NetMessage(EMessageId.EnableDamageRecordRequest)]
	public sealed class EnableDamageRecordRequest : IMessage<EnableDamageRecordRequest>, IMessage, IEquatable<EnableDamageRecordRequest>, IDeepCloneable<EnableDamageRecordRequest>, IBufferMessage
	{
		// Token: 0x0601CFC9 RID: 118729 RVA: 0x0043E604 File Offset: 0x0043C804
		[NullableContext(1)]
		public static EnableDamageRecordRequest Create()
		{
			return new EnableDamageRecordRequest();
		}

		// Token: 0x1700625E RID: 25182
		// (get) Token: 0x0601CFCA RID: 118730 RVA: 0x0043E60B File Offset: 0x0043C80B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700625F RID: 25183
		// (get) Token: 0x0601CFCB RID: 118731 RVA: 0x0043E60E File Offset: 0x0043C80E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnableDamageRecordRequest.Descriptor;
			}
		}

		// Token: 0x0601CFCC RID: 118732 RVA: 0x0043E615 File Offset: 0x0043C815
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableDamageRecordRequest()
		{
		}

		// Token: 0x0601CFCD RID: 118733 RVA: 0x0043E61D File Offset: 0x0043C81D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableDamageRecordRequest(EnableDamageRecordRequest other) : this()
		{
			this.enable_ = other.enable_;
			this.damageRandomSeed_ = other.damageRandomSeed_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CFCE RID: 118734 RVA: 0x0043E64E File Offset: 0x0043C84E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnableDamageRecordRequest Clone()
		{
			return new EnableDamageRecordRequest(this);
		}

		// Token: 0x17006260 RID: 25184
		// (get) Token: 0x0601CFCF RID: 118735 RVA: 0x0043E656 File Offset: 0x0043C856
		// (set) Token: 0x0601CFD0 RID: 118736 RVA: 0x0043E65E File Offset: 0x0043C85E
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

		// Token: 0x17006261 RID: 25185
		// (get) Token: 0x0601CFD1 RID: 118737 RVA: 0x0043E667 File Offset: 0x0043C867
		// (set) Token: 0x0601CFD2 RID: 118738 RVA: 0x0043E66F File Offset: 0x0043C86F
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

		// Token: 0x0601CFD3 RID: 118739 RVA: 0x0043E678 File Offset: 0x0043C878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnableDamageRecordRequest);
		}

		// Token: 0x0601CFD4 RID: 118740 RVA: 0x0043E686 File Offset: 0x0043C886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnableDamageRecordRequest other)
		{
			return other != null && (other == this || (this.Enable == other.Enable && this.DamageRandomSeed == other.DamageRandomSeed && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CFD5 RID: 118741 RVA: 0x0043E6C4 File Offset: 0x0043C8C4
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

		// Token: 0x0601CFD6 RID: 118742 RVA: 0x0043E71C File Offset: 0x0043C91C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CFD7 RID: 118743 RVA: 0x0043E729 File Offset: 0x0043C929
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CFD8 RID: 118744 RVA: 0x0043E734 File Offset: 0x0043C934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Enable)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.Enable);
			}
			if (this.DamageRandomSeed != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.DamageRandomSeed);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CFD9 RID: 118745 RVA: 0x0043E78C File Offset: 0x0043C98C
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

		// Token: 0x0601CFDA RID: 118746 RVA: 0x0043E7D8 File Offset: 0x0043C9D8
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

		// Token: 0x0601CFDB RID: 118747 RVA: 0x0043E828 File Offset: 0x0043CA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CFDC RID: 118748 RVA: 0x0043E834 File Offset: 0x0043CA34
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
					if (num != 80U)
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

		// Token: 0x0400C3C5 RID: 50117
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C3C6 RID: 50118
		public const int EnableFieldNumber = 1;

		// Token: 0x0400C3C7 RID: 50119
		private bool enable_;

		// Token: 0x0400C3C8 RID: 50120
		public const int DamageRandomSeedFieldNumber = 10;

		// Token: 0x0400C3C9 RID: 50121
		private int damageRandomSeed_;
	}
}
