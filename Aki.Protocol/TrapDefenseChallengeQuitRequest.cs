using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001418 RID: 5144
	[NetMessage(EMessageId.TrapDefenseChallengeQuitRequest)]
	public sealed class TrapDefenseChallengeQuitRequest : IMessage<TrapDefenseChallengeQuitRequest>, IMessage, IEquatable<TrapDefenseChallengeQuitRequest>, IDeepCloneable<TrapDefenseChallengeQuitRequest>, IBufferMessage
	{
		// Token: 0x0601B44C RID: 111692 RVA: 0x003F39C6 File Offset: 0x003F1BC6
		[NullableContext(1)]
		public static TrapDefenseChallengeQuitRequest Create()
		{
			return new TrapDefenseChallengeQuitRequest();
		}

		// Token: 0x17005BFE RID: 23550
		// (get) Token: 0x0601B44D RID: 111693 RVA: 0x003F39CD File Offset: 0x003F1BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BFF RID: 23551
		// (get) Token: 0x0601B44E RID: 111694 RVA: 0x003F39D0 File Offset: 0x003F1BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseChallengeQuitRequest.Descriptor;
			}
		}

		// Token: 0x0601B44F RID: 111695 RVA: 0x003F39D7 File Offset: 0x003F1BD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeQuitRequest()
		{
		}

		// Token: 0x0601B450 RID: 111696 RVA: 0x003F39DF File Offset: 0x003F1BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeQuitRequest(TrapDefenseChallengeQuitRequest other) : this()
		{
			this.settle_ = other.settle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B451 RID: 111697 RVA: 0x003F3A04 File Offset: 0x003F1C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseChallengeQuitRequest Clone()
		{
			return new TrapDefenseChallengeQuitRequest(this);
		}

		// Token: 0x17005C00 RID: 23552
		// (get) Token: 0x0601B452 RID: 111698 RVA: 0x003F3A0C File Offset: 0x003F1C0C
		// (set) Token: 0x0601B453 RID: 111699 RVA: 0x003F3A14 File Offset: 0x003F1C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Settle
		{
			get
			{
				return this.settle_;
			}
			set
			{
				this.settle_ = value;
			}
		}

		// Token: 0x0601B454 RID: 111700 RVA: 0x003F3A1D File Offset: 0x003F1C1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseChallengeQuitRequest);
		}

		// Token: 0x0601B455 RID: 111701 RVA: 0x003F3A2B File Offset: 0x003F1C2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseChallengeQuitRequest other)
		{
			return other != null && (other == this || (this.Settle == other.Settle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B456 RID: 111702 RVA: 0x003F3A5C File Offset: 0x003F1C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Settle)
			{
				num ^= this.Settle.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B457 RID: 111703 RVA: 0x003F3A9B File Offset: 0x003F1C9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B458 RID: 111704 RVA: 0x003F3AA8 File Offset: 0x003F1CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B459 RID: 111705 RVA: 0x003F3AB1 File Offset: 0x003F1CB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Settle)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Settle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B45A RID: 111706 RVA: 0x003F3AE4 File Offset: 0x003F1CE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Settle)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B45B RID: 111707 RVA: 0x003F3B16 File Offset: 0x003F1D16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseChallengeQuitRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Settle)
			{
				this.Settle = other.Settle;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B45C RID: 111708 RVA: 0x003F3B47 File Offset: 0x003F1D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B45D RID: 111709 RVA: 0x003F3B50 File Offset: 0x003F1D50
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Settle = input.ReadBool();
				}
			}
		}

		// Token: 0x04009DB2 RID: 40370
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DB3 RID: 40371
		public const int SettleFieldNumber = 7;

		// Token: 0x04009DB4 RID: 40372
		private bool settle_;
	}
}
