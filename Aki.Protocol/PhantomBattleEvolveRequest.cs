using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C85 RID: 3205
	[NetMessage(EMessageId.PhantomBattleEvolveRequest)]
	public sealed class PhantomBattleEvolveRequest : IMessage<PhantomBattleEvolveRequest>, IMessage, IEquatable<PhantomBattleEvolveRequest>, IDeepCloneable<PhantomBattleEvolveRequest>, IBufferMessage
	{
		// Token: 0x060115FC RID: 71164 RVA: 0x0028BBD2 File Offset: 0x00289DD2
		[NullableContext(1)]
		public static PhantomBattleEvolveRequest Create()
		{
			return new PhantomBattleEvolveRequest();
		}

		// Token: 0x17003986 RID: 14726
		// (get) Token: 0x060115FD RID: 71165 RVA: 0x0028BBD9 File Offset: 0x00289DD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003987 RID: 14727
		// (get) Token: 0x060115FE RID: 71166 RVA: 0x0028BBDC File Offset: 0x00289DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleEvolveRequest.Descriptor;
			}
		}

		// Token: 0x060115FF RID: 71167 RVA: 0x0028BBE3 File Offset: 0x00289DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEvolveRequest()
		{
		}

		// Token: 0x06011600 RID: 71168 RVA: 0x0028BBEB File Offset: 0x00289DEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEvolveRequest(PhantomBattleEvolveRequest other) : this()
		{
			this.slotIndex_ = other.slotIndex_;
			this.cardUid_ = other.cardUid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011601 RID: 71169 RVA: 0x0028BC1C File Offset: 0x00289E1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEvolveRequest Clone()
		{
			return new PhantomBattleEvolveRequest(this);
		}

		// Token: 0x17003988 RID: 14728
		// (get) Token: 0x06011602 RID: 71170 RVA: 0x0028BC24 File Offset: 0x00289E24
		// (set) Token: 0x06011603 RID: 71171 RVA: 0x0028BC2C File Offset: 0x00289E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SlotIndex
		{
			get
			{
				return this.slotIndex_;
			}
			set
			{
				this.slotIndex_ = value;
			}
		}

		// Token: 0x17003989 RID: 14729
		// (get) Token: 0x06011604 RID: 71172 RVA: 0x0028BC35 File Offset: 0x00289E35
		// (set) Token: 0x06011605 RID: 71173 RVA: 0x0028BC3D File Offset: 0x00289E3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardUid
		{
			get
			{
				return this.cardUid_;
			}
			set
			{
				this.cardUid_ = value;
			}
		}

		// Token: 0x06011606 RID: 71174 RVA: 0x0028BC46 File Offset: 0x00289E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleEvolveRequest);
		}

		// Token: 0x06011607 RID: 71175 RVA: 0x0028BC54 File Offset: 0x00289E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleEvolveRequest other)
		{
			return other != null && (other == this || (this.SlotIndex == other.SlotIndex && this.CardUid == other.CardUid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011608 RID: 71176 RVA: 0x0028BC94 File Offset: 0x00289E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SlotIndex != 0)
			{
				num ^= this.SlotIndex.GetHashCode();
			}
			if (this.CardUid != 0)
			{
				num ^= this.CardUid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011609 RID: 71177 RVA: 0x0028BCEC File Offset: 0x00289EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601160A RID: 71178 RVA: 0x0028BCF9 File Offset: 0x00289EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601160B RID: 71179 RVA: 0x0028BD04 File Offset: 0x00289F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SlotIndex);
			}
			if (this.CardUid != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.CardUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601160C RID: 71180 RVA: 0x0028BD60 File Offset: 0x00289F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SlotIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SlotIndex);
			}
			if (this.CardUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardUid);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601160D RID: 71181 RVA: 0x0028BDB8 File Offset: 0x00289FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleEvolveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SlotIndex != 0)
			{
				this.SlotIndex = other.SlotIndex;
			}
			if (other.CardUid != 0)
			{
				this.CardUid = other.CardUid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601160E RID: 71182 RVA: 0x0028BE08 File Offset: 0x0028A008
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601160F RID: 71183 RVA: 0x0028BE14 File Offset: 0x0028A014
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
				if (num != 88U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CardUid = input.ReadInt32();
					}
				}
				else
				{
					this.SlotIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006DC3 RID: 28099
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DC4 RID: 28100
		public const int SlotIndexFieldNumber = 11;

		// Token: 0x04006DC5 RID: 28101
		private int slotIndex_;

		// Token: 0x04006DC6 RID: 28102
		public const int CardUidFieldNumber = 12;

		// Token: 0x04006DC7 RID: 28103
		private int cardUid_;
	}
}
