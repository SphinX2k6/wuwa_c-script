using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B71 RID: 2929
	public sealed class NpcPhantomBattleEnterSlotInfo : IMessage<NpcPhantomBattleEnterSlotInfo>, IMessage, IEquatable<NpcPhantomBattleEnterSlotInfo>, IDeepCloneable<NpcPhantomBattleEnterSlotInfo>, IBufferMessage
	{
		// Token: 0x0600FDCA RID: 64970 RVA: 0x0024F7D0 File Offset: 0x0024D9D0
		[NullableContext(1)]
		public static NpcPhantomBattleEnterSlotInfo Create()
		{
			return new NpcPhantomBattleEnterSlotInfo();
		}

		// Token: 0x170033C4 RID: 13252
		// (get) Token: 0x0600FDCB RID: 64971 RVA: 0x0024F7D7 File Offset: 0x0024D9D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033C5 RID: 13253
		// (get) Token: 0x0600FDCC RID: 64972 RVA: 0x0024F7DA File Offset: 0x0024D9DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleEnterSlotInfo.Descriptor;
			}
		}

		// Token: 0x0600FDCD RID: 64973 RVA: 0x0024F7E1 File Offset: 0x0024D9E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleEnterSlotInfo()
		{
		}

		// Token: 0x0600FDCE RID: 64974 RVA: 0x0024F7EC File Offset: 0x0024D9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleEnterSlotInfo(NpcPhantomBattleEnterSlotInfo other) : this()
		{
			this.phantomBattleFighterInfo_ = ((other.phantomBattleFighterInfo_ != null) ? other.phantomBattleFighterInfo_.Clone() : null);
			this.curHandNum_ = other.curHandNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FDCF RID: 64975 RVA: 0x0024F838 File Offset: 0x0024DA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleEnterSlotInfo Clone()
		{
			return new NpcPhantomBattleEnterSlotInfo(this);
		}

		// Token: 0x170033C6 RID: 13254
		// (get) Token: 0x0600FDD0 RID: 64976 RVA: 0x0024F840 File Offset: 0x0024DA40
		// (set) Token: 0x0600FDD1 RID: 64977 RVA: 0x0024F848 File Offset: 0x0024DA48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleFighterInfo PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
			set
			{
				this.phantomBattleFighterInfo_ = value;
			}
		}

		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x0600FDD2 RID: 64978 RVA: 0x0024F851 File Offset: 0x0024DA51
		// (set) Token: 0x0600FDD3 RID: 64979 RVA: 0x0024F859 File Offset: 0x0024DA59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurHandNum
		{
			get
			{
				return this.curHandNum_;
			}
			set
			{
				this.curHandNum_ = value;
			}
		}

		// Token: 0x0600FDD4 RID: 64980 RVA: 0x0024F862 File Offset: 0x0024DA62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleEnterSlotInfo);
		}

		// Token: 0x0600FDD5 RID: 64981 RVA: 0x0024F870 File Offset: 0x0024DA70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleEnterSlotInfo other)
		{
			return other != null && (other == this || (object.Equals(this.PhantomBattleFighterInfo, other.PhantomBattleFighterInfo) && this.CurHandNum == other.CurHandNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FDD6 RID: 64982 RVA: 0x0024F8C0 File Offset: 0x0024DAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.phantomBattleFighterInfo_ != null)
			{
				num ^= this.PhantomBattleFighterInfo.GetHashCode();
			}
			if (this.CurHandNum != 0)
			{
				num ^= this.CurHandNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FDD7 RID: 64983 RVA: 0x0024F915 File Offset: 0x0024DB15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FDD8 RID: 64984 RVA: 0x0024F922 File Offset: 0x0024DB22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FDD9 RID: 64985 RVA: 0x0024F92C File Offset: 0x0024DB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.phantomBattleFighterInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.PhantomBattleFighterInfo);
			}
			if (this.CurHandNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurHandNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FDDA RID: 64986 RVA: 0x0024F988 File Offset: 0x0024DB88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.phantomBattleFighterInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PhantomBattleFighterInfo);
			}
			if (this.CurHandNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurHandNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FDDB RID: 64987 RVA: 0x0024F9E0 File Offset: 0x0024DBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleEnterSlotInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.phantomBattleFighterInfo_ != null)
			{
				if (this.phantomBattleFighterInfo_ == null)
				{
					this.PhantomBattleFighterInfo = new PhantomBattleFighterInfo();
				}
				this.PhantomBattleFighterInfo.MergeFrom(other.PhantomBattleFighterInfo);
			}
			if (other.CurHandNum != 0)
			{
				this.CurHandNum = other.CurHandNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FDDC RID: 64988 RVA: 0x0024FA48 File Offset: 0x0024DC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FDDD RID: 64989 RVA: 0x0024FA54 File Offset: 0x0024DC54
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
				if (num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CurHandNum = input.ReadInt32();
					}
				}
				else
				{
					if (this.phantomBattleFighterInfo_ == null)
					{
						this.PhantomBattleFighterInfo = new PhantomBattleFighterInfo();
					}
					input.ReadMessage(this.PhantomBattleFighterInfo);
				}
			}
		}

		// Token: 0x04006538 RID: 25912
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006539 RID: 25913
		public const int PhantomBattleFighterInfoFieldNumber = 1;

		// Token: 0x0400653A RID: 25914
		private PhantomBattleFighterInfo phantomBattleFighterInfo_;

		// Token: 0x0400653B RID: 25915
		public const int CurHandNumFieldNumber = 2;

		// Token: 0x0400653C RID: 25916
		private int curHandNum_;
	}
}
