using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B6E RID: 2926
	public sealed class NpcPhantomBattleDealEffectCtx : IMessage<NpcPhantomBattleDealEffectCtx>, IMessage, IEquatable<NpcPhantomBattleDealEffectCtx>, IDeepCloneable<NpcPhantomBattleDealEffectCtx>, IBufferMessage
	{
		// Token: 0x0600FD88 RID: 64904 RVA: 0x0024EDFB File Offset: 0x0024CFFB
		[NullableContext(1)]
		public static NpcPhantomBattleDealEffectCtx Create()
		{
			return new NpcPhantomBattleDealEffectCtx();
		}

		// Token: 0x170033B5 RID: 13237
		// (get) Token: 0x0600FD89 RID: 64905 RVA: 0x0024EE02 File Offset: 0x0024D002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033B6 RID: 13238
		// (get) Token: 0x0600FD8A RID: 64906 RVA: 0x0024EE05 File Offset: 0x0024D005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleDealEffectCtx.Descriptor;
			}
		}

		// Token: 0x0600FD8B RID: 64907 RVA: 0x0024EE0C File Offset: 0x0024D00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDealEffectCtx()
		{
		}

		// Token: 0x0600FD8C RID: 64908 RVA: 0x0024EE14 File Offset: 0x0024D014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDealEffectCtx(NpcPhantomBattleDealEffectCtx other) : this()
		{
			this.curHandNum_ = other.curHandNum_;
			this.cardLibraryNum_ = other.cardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FD8D RID: 64909 RVA: 0x0024EE45 File Offset: 0x0024D045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDealEffectCtx Clone()
		{
			return new NpcPhantomBattleDealEffectCtx(this);
		}

		// Token: 0x170033B7 RID: 13239
		// (get) Token: 0x0600FD8E RID: 64910 RVA: 0x0024EE4D File Offset: 0x0024D04D
		// (set) Token: 0x0600FD8F RID: 64911 RVA: 0x0024EE55 File Offset: 0x0024D055
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

		// Token: 0x170033B8 RID: 13240
		// (get) Token: 0x0600FD90 RID: 64912 RVA: 0x0024EE5E File Offset: 0x0024D05E
		// (set) Token: 0x0600FD91 RID: 64913 RVA: 0x0024EE66 File Offset: 0x0024D066
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardLibraryNum
		{
			get
			{
				return this.cardLibraryNum_;
			}
			set
			{
				this.cardLibraryNum_ = value;
			}
		}

		// Token: 0x0600FD92 RID: 64914 RVA: 0x0024EE6F File Offset: 0x0024D06F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleDealEffectCtx);
		}

		// Token: 0x0600FD93 RID: 64915 RVA: 0x0024EE7D File Offset: 0x0024D07D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleDealEffectCtx other)
		{
			return other != null && (other == this || (this.CurHandNum == other.CurHandNum && this.CardLibraryNum == other.CardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FD94 RID: 64916 RVA: 0x0024EEBC File Offset: 0x0024D0BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurHandNum != 0)
			{
				num ^= this.CurHandNum.GetHashCode();
			}
			if (this.CardLibraryNum != 0)
			{
				num ^= this.CardLibraryNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FD95 RID: 64917 RVA: 0x0024EF14 File Offset: 0x0024D114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FD96 RID: 64918 RVA: 0x0024EF21 File Offset: 0x0024D121
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FD97 RID: 64919 RVA: 0x0024EF2C File Offset: 0x0024D12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurHandNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurHandNum);
			}
			if (this.CardLibraryNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FD98 RID: 64920 RVA: 0x0024EF84 File Offset: 0x0024D184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurHandNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurHandNum);
			}
			if (this.CardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FD99 RID: 64921 RVA: 0x0024EFDC File Offset: 0x0024D1DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleDealEffectCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurHandNum != 0)
			{
				this.CurHandNum = other.CurHandNum;
			}
			if (other.CardLibraryNum != 0)
			{
				this.CardLibraryNum = other.CardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FD9A RID: 64922 RVA: 0x0024F02C File Offset: 0x0024D22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FD9B RID: 64923 RVA: 0x0024F038 File Offset: 0x0024D238
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
						this.CardLibraryNum = input.ReadInt32();
					}
				}
				else
				{
					this.CurHandNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006523 RID: 25891
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006524 RID: 25892
		public const int CurHandNumFieldNumber = 1;

		// Token: 0x04006525 RID: 25893
		private int curHandNum_;

		// Token: 0x04006526 RID: 25894
		public const int CardLibraryNumFieldNumber = 2;

		// Token: 0x04006527 RID: 25895
		private int cardLibraryNum_;
	}
}
