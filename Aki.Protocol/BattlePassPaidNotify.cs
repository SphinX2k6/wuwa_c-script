using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200016D RID: 365
	[NetMessage(EMessageId.BattlePassPaidNotify)]
	public sealed class BattlePassPaidNotify : IMessage<BattlePassPaidNotify>, IMessage, IEquatable<BattlePassPaidNotify>, IDeepCloneable<BattlePassPaidNotify>, IBufferMessage
	{
		// Token: 0x06002D18 RID: 11544 RVA: 0x00074ED9 File Offset: 0x000730D9
		[NullableContext(1)]
		public static BattlePassPaidNotify Create()
		{
			return new BattlePassPaidNotify();
		}

		// Token: 0x170006D3 RID: 1747
		// (get) Token: 0x06002D19 RID: 11545 RVA: 0x00074EE0 File Offset: 0x000730E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170006D4 RID: 1748
		// (get) Token: 0x06002D1A RID: 11546 RVA: 0x00074EE3 File Offset: 0x000730E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BattlePassPaidNotify.Descriptor;
			}
		}

		// Token: 0x06002D1B RID: 11547 RVA: 0x00074EEA File Offset: 0x000730EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassPaidNotify()
		{
		}

		// Token: 0x06002D1C RID: 11548 RVA: 0x00074EF2 File Offset: 0x000730F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassPaidNotify(BattlePassPaidNotify other) : this()
		{
			this.payStatus_ = other.payStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002D1D RID: 11549 RVA: 0x00074F17 File Offset: 0x00073117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassPaidNotify Clone()
		{
			return new BattlePassPaidNotify(this);
		}

		// Token: 0x170006D5 RID: 1749
		// (get) Token: 0x06002D1E RID: 11550 RVA: 0x00074F1F File Offset: 0x0007311F
		// (set) Token: 0x06002D1F RID: 11551 RVA: 0x00074F27 File Offset: 0x00073127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BattlePassPayStatus PayStatus
		{
			get
			{
				return this.payStatus_;
			}
			set
			{
				this.payStatus_ = value;
			}
		}

		// Token: 0x06002D20 RID: 11552 RVA: 0x00074F30 File Offset: 0x00073130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BattlePassPaidNotify);
		}

		// Token: 0x06002D21 RID: 11553 RVA: 0x00074F3E File Offset: 0x0007313E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BattlePassPaidNotify other)
		{
			return other != null && (other == this || (this.PayStatus == other.PayStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002D22 RID: 11554 RVA: 0x00074F6C File Offset: 0x0007316C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PayStatus != BattlePassPayStatus.NoPaid)
			{
				num ^= this.PayStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x00074FB1 File Offset: 0x000731B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x00074FBE File Offset: 0x000731BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x00074FC7 File Offset: 0x000731C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PayStatus != BattlePassPayStatus.NoPaid)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.PayStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x00074FFC File Offset: 0x000731FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PayStatus != BattlePassPayStatus.NoPaid)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.PayStatus);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x0007503A File Offset: 0x0007323A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BattlePassPaidNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PayStatus != BattlePassPayStatus.NoPaid)
			{
				this.PayStatus = other.PayStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x0007506B File Offset: 0x0007326B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x00075074 File Offset: 0x00073274
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PayStatus = (BattlePassPayStatus)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002823 RID: 10275
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002824 RID: 10276
		public const int PayStatusFieldNumber = 13;

		// Token: 0x04002825 RID: 10277
		private BattlePassPayStatus payStatus_;
	}
}
