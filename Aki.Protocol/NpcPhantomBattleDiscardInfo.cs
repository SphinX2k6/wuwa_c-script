using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B6F RID: 2927
	public sealed class NpcPhantomBattleDiscardInfo : IMessage<NpcPhantomBattleDiscardInfo>, IMessage, IEquatable<NpcPhantomBattleDiscardInfo>, IDeepCloneable<NpcPhantomBattleDiscardInfo>, IBufferMessage
	{
		// Token: 0x0600FD9C RID: 64924 RVA: 0x0024F08F File Offset: 0x0024D28F
		[NullableContext(1)]
		public static NpcPhantomBattleDiscardInfo Create()
		{
			return new NpcPhantomBattleDiscardInfo();
		}

		// Token: 0x170033B9 RID: 13241
		// (get) Token: 0x0600FD9D RID: 64925 RVA: 0x0024F096 File Offset: 0x0024D296
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170033BA RID: 13242
		// (get) Token: 0x0600FD9E RID: 64926 RVA: 0x0024F099 File Offset: 0x0024D299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NpcPhantomBattleDiscardInfo.Descriptor;
			}
		}

		// Token: 0x0600FD9F RID: 64927 RVA: 0x0024F0A0 File Offset: 0x0024D2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDiscardInfo()
		{
		}

		// Token: 0x0600FDA0 RID: 64928 RVA: 0x0024F0A8 File Offset: 0x0024D2A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDiscardInfo(NpcPhantomBattleDiscardInfo other) : this()
		{
			this.discardNum_ = other.discardNum_;
			this.handCardNum_ = other.handCardNum_;
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600FDA1 RID: 64929 RVA: 0x0024F0E5 File Offset: 0x0024D2E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NpcPhantomBattleDiscardInfo Clone()
		{
			return new NpcPhantomBattleDiscardInfo(this);
		}

		// Token: 0x170033BB RID: 13243
		// (get) Token: 0x0600FDA2 RID: 64930 RVA: 0x0024F0ED File Offset: 0x0024D2ED
		// (set) Token: 0x0600FDA3 RID: 64931 RVA: 0x0024F0F5 File Offset: 0x0024D2F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DiscardNum
		{
			get
			{
				return this.discardNum_;
			}
			set
			{
				this.discardNum_ = value;
			}
		}

		// Token: 0x170033BC RID: 13244
		// (get) Token: 0x0600FDA4 RID: 64932 RVA: 0x0024F0FE File Offset: 0x0024D2FE
		// (set) Token: 0x0600FDA5 RID: 64933 RVA: 0x0024F106 File Offset: 0x0024D306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandCardNum
		{
			get
			{
				return this.handCardNum_;
			}
			set
			{
				this.handCardNum_ = value;
			}
		}

		// Token: 0x170033BD RID: 13245
		// (get) Token: 0x0600FDA6 RID: 64934 RVA: 0x0024F10F File Offset: 0x0024D30F
		// (set) Token: 0x0600FDA7 RID: 64935 RVA: 0x0024F117 File Offset: 0x0024D317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCardLibraryNum
		{
			get
			{
				return this.curCardLibraryNum_;
			}
			set
			{
				this.curCardLibraryNum_ = value;
			}
		}

		// Token: 0x0600FDA8 RID: 64936 RVA: 0x0024F120 File Offset: 0x0024D320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NpcPhantomBattleDiscardInfo);
		}

		// Token: 0x0600FDA9 RID: 64937 RVA: 0x0024F130 File Offset: 0x0024D330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NpcPhantomBattleDiscardInfo other)
		{
			return other != null && (other == this || (this.DiscardNum == other.DiscardNum && this.HandCardNum == other.HandCardNum && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600FDAA RID: 64938 RVA: 0x0024F18C File Offset: 0x0024D38C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DiscardNum != 0)
			{
				num ^= this.DiscardNum.GetHashCode();
			}
			if (this.HandCardNum != 0)
			{
				num ^= this.HandCardNum.GetHashCode();
			}
			if (this.CurCardLibraryNum != 0)
			{
				num ^= this.CurCardLibraryNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600FDAB RID: 64939 RVA: 0x0024F1FD File Offset: 0x0024D3FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600FDAC RID: 64940 RVA: 0x0024F20A File Offset: 0x0024D40A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600FDAD RID: 64941 RVA: 0x0024F214 File Offset: 0x0024D414
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DiscardNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DiscardNum);
			}
			if (this.HandCardNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.HandCardNum);
			}
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600FDAE RID: 64942 RVA: 0x0024F288 File Offset: 0x0024D488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DiscardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DiscardNum);
			}
			if (this.HandCardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandCardNum);
			}
			if (this.CurCardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600FDAF RID: 64943 RVA: 0x0024F2F8 File Offset: 0x0024D4F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NpcPhantomBattleDiscardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DiscardNum != 0)
			{
				this.DiscardNum = other.DiscardNum;
			}
			if (other.HandCardNum != 0)
			{
				this.HandCardNum = other.HandCardNum;
			}
			if (other.CurCardLibraryNum != 0)
			{
				this.CurCardLibraryNum = other.CurCardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600FDB0 RID: 64944 RVA: 0x0024F35C File Offset: 0x0024D55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600FDB1 RID: 64945 RVA: 0x0024F368 File Offset: 0x0024D568
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
							this.CurCardLibraryNum = input.ReadInt32();
						}
					}
					else
					{
						this.HandCardNum = input.ReadInt32();
					}
				}
				else
				{
					this.DiscardNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006528 RID: 25896
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006529 RID: 25897
		public const int DiscardNumFieldNumber = 1;

		// Token: 0x0400652A RID: 25898
		private int discardNum_;

		// Token: 0x0400652B RID: 25899
		public const int HandCardNumFieldNumber = 2;

		// Token: 0x0400652C RID: 25900
		private int handCardNum_;

		// Token: 0x0400652D RID: 25901
		public const int CurCardLibraryNumFieldNumber = 3;

		// Token: 0x0400652E RID: 25902
		private int curCardLibraryNum_;
	}
}
