using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C75 RID: 3189
	[NetMessage(EMessageId.PhantomBattleEvolveRequest)]
	public sealed class PhantomBattleEvolveRequest : IMessage<PhantomBattleEvolveRequest>, IMessage, IEquatable<PhantomBattleEvolveRequest>, IDeepCloneable<PhantomBattleEvolveRequest>, IBufferMessage
	{
		// Token: 0x060114FC RID: 70908 RVA: 0x00289E67 File Offset: 0x00288067
		[NullableContext(1)]
		public static PhantomBattleEvolveRequest Create()
		{
			return new PhantomBattleEvolveRequest();
		}

		// Token: 0x1700394F RID: 14671
		// (get) Token: 0x060114FD RID: 70909 RVA: 0x00289E6E File Offset: 0x0028806E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003950 RID: 14672
		// (get) Token: 0x060114FE RID: 70910 RVA: 0x00289E71 File Offset: 0x00288071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleEvolveRequest.Descriptor;
			}
		}

		// Token: 0x060114FF RID: 70911 RVA: 0x00289E78 File Offset: 0x00288078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEvolveRequest()
		{
		}

		// Token: 0x06011500 RID: 70912 RVA: 0x00289E80 File Offset: 0x00288080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEvolveRequest(PhantomBattleEvolveRequest other) : this()
		{
			this.slotIndex_ = other.slotIndex_;
			this.cardUid_ = other.cardUid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011501 RID: 70913 RVA: 0x00289EB1 File Offset: 0x002880B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEvolveRequest Clone()
		{
			return new PhantomBattleEvolveRequest(this);
		}

		// Token: 0x17003951 RID: 14673
		// (get) Token: 0x06011502 RID: 70914 RVA: 0x00289EB9 File Offset: 0x002880B9
		// (set) Token: 0x06011503 RID: 70915 RVA: 0x00289EC1 File Offset: 0x002880C1
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

		// Token: 0x17003952 RID: 14674
		// (get) Token: 0x06011504 RID: 70916 RVA: 0x00289ECA File Offset: 0x002880CA
		// (set) Token: 0x06011505 RID: 70917 RVA: 0x00289ED2 File Offset: 0x002880D2
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

		// Token: 0x06011506 RID: 70918 RVA: 0x00289EDB File Offset: 0x002880DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleEvolveRequest);
		}

		// Token: 0x06011507 RID: 70919 RVA: 0x00289EE9 File Offset: 0x002880E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleEvolveRequest other)
		{
			return other != null && (other == this || (this.SlotIndex == other.SlotIndex && this.CardUid == other.CardUid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011508 RID: 70920 RVA: 0x00289F28 File Offset: 0x00288128
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

		// Token: 0x06011509 RID: 70921 RVA: 0x00289F80 File Offset: 0x00288180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601150A RID: 70922 RVA: 0x00289F8D File Offset: 0x0028818D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601150B RID: 70923 RVA: 0x00289F98 File Offset: 0x00288198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SlotIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SlotIndex);
			}
			if (this.CardUid != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.CardUid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601150C RID: 70924 RVA: 0x00289FF4 File Offset: 0x002881F4
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

		// Token: 0x0601150D RID: 70925 RVA: 0x0028A04C File Offset: 0x0028824C
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

		// Token: 0x0601150E RID: 70926 RVA: 0x0028A09C File Offset: 0x0028829C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601150F RID: 70927 RVA: 0x0028A0A8 File Offset: 0x002882A8
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
				if (num != 16U)
				{
					if (num != 120U)
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

		// Token: 0x04006DD7 RID: 28119
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DD8 RID: 28120
		public const int SlotIndexFieldNumber = 2;

		// Token: 0x04006DD9 RID: 28121
		private int slotIndex_;

		// Token: 0x04006DDA RID: 28122
		public const int CardUidFieldNumber = 15;

		// Token: 0x04006DDB RID: 28123
		private int cardUid_;
	}
}
