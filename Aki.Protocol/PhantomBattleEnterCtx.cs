using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C72 RID: 3186
	public sealed class PhantomBattleEnterCtx : IMessage<PhantomBattleEnterCtx>, IMessage, IEquatable<PhantomBattleEnterCtx>, IDeepCloneable<PhantomBattleEnterCtx>, IBufferMessage
	{
		// Token: 0x060114BE RID: 70846 RVA: 0x00289593 File Offset: 0x00287793
		[NullableContext(1)]
		public static PhantomBattleEnterCtx Create()
		{
			return new PhantomBattleEnterCtx();
		}

		// Token: 0x17003942 RID: 14658
		// (get) Token: 0x060114BF RID: 70847 RVA: 0x0028959A File Offset: 0x0028779A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003943 RID: 14659
		// (get) Token: 0x060114C0 RID: 70848 RVA: 0x0028959D File Offset: 0x0028779D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleEnterCtx.Descriptor;
			}
		}

		// Token: 0x060114C1 RID: 70849 RVA: 0x002895A4 File Offset: 0x002877A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterCtx()
		{
		}

		// Token: 0x060114C2 RID: 70850 RVA: 0x002895AC File Offset: 0x002877AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterCtx(PhantomBattleEnterCtx other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.cardRoleId_ = other.cardRoleId_;
			this.cardGroupIndex_ = other.cardGroupIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060114C3 RID: 70851 RVA: 0x002895E9 File Offset: 0x002877E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEnterCtx Clone()
		{
			return new PhantomBattleEnterCtx(this);
		}

		// Token: 0x17003944 RID: 14660
		// (get) Token: 0x060114C4 RID: 70852 RVA: 0x002895F1 File Offset: 0x002877F1
		// (set) Token: 0x060114C5 RID: 70853 RVA: 0x002895F9 File Offset: 0x002877F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17003945 RID: 14661
		// (get) Token: 0x060114C6 RID: 70854 RVA: 0x00289602 File Offset: 0x00287802
		// (set) Token: 0x060114C7 RID: 70855 RVA: 0x0028960A File Offset: 0x0028780A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardRoleId
		{
			get
			{
				return this.cardRoleId_;
			}
			set
			{
				this.cardRoleId_ = value;
			}
		}

		// Token: 0x17003946 RID: 14662
		// (get) Token: 0x060114C8 RID: 70856 RVA: 0x00289613 File Offset: 0x00287813
		// (set) Token: 0x060114C9 RID: 70857 RVA: 0x0028961B File Offset: 0x0028781B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardGroupIndex
		{
			get
			{
				return this.cardGroupIndex_;
			}
			set
			{
				this.cardGroupIndex_ = value;
			}
		}

		// Token: 0x060114CA RID: 70858 RVA: 0x00289624 File Offset: 0x00287824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleEnterCtx);
		}

		// Token: 0x060114CB RID: 70859 RVA: 0x00289634 File Offset: 0x00287834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleEnterCtx other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.CardRoleId == other.CardRoleId && this.CardGroupIndex == other.CardGroupIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060114CC RID: 70860 RVA: 0x00289690 File Offset: 0x00287890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.CardRoleId != 0)
			{
				num ^= this.CardRoleId.GetHashCode();
			}
			if (this.CardGroupIndex != 0)
			{
				num ^= this.CardGroupIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060114CD RID: 70861 RVA: 0x00289701 File Offset: 0x00287901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060114CE RID: 70862 RVA: 0x0028970E File Offset: 0x0028790E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060114CF RID: 70863 RVA: 0x00289718 File Offset: 0x00287918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.CardRoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardRoleId);
			}
			if (this.CardGroupIndex != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CardGroupIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060114D0 RID: 70864 RVA: 0x0028978C File Offset: 0x0028798C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.CardRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardRoleId);
			}
			if (this.CardGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardGroupIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060114D1 RID: 70865 RVA: 0x002897FC File Offset: 0x002879FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleEnterCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.CardRoleId != 0)
			{
				this.CardRoleId = other.CardRoleId;
			}
			if (other.CardGroupIndex != 0)
			{
				this.CardGroupIndex = other.CardGroupIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060114D2 RID: 70866 RVA: 0x00289860 File Offset: 0x00287A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060114D3 RID: 70867 RVA: 0x0028986C File Offset: 0x00287A6C
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CardGroupIndex = input.ReadInt32();
						}
					}
					else
					{
						this.CardRoleId = input.ReadInt32();
					}
				}
				else
				{
					this.ChallengeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006DC6 RID: 28102
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DC7 RID: 28103
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04006DC8 RID: 28104
		private int challengeId_;

		// Token: 0x04006DC9 RID: 28105
		public const int CardRoleIdFieldNumber = 2;

		// Token: 0x04006DCA RID: 28106
		private int cardRoleId_;

		// Token: 0x04006DCB RID: 28107
		public const int CardGroupIndexFieldNumber = 3;

		// Token: 0x04006DCC RID: 28108
		private int cardGroupIndex_;
	}
}
