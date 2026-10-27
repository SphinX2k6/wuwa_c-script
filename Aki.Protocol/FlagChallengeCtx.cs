using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000595 RID: 1429
	public sealed class FlagChallengeCtx : IMessage<FlagChallengeCtx>, IMessage, IEquatable<FlagChallengeCtx>, IDeepCloneable<FlagChallengeCtx>, IBufferMessage
	{
		// Token: 0x0600845D RID: 33885 RVA: 0x0013E88B File Offset: 0x0013CA8B
		[NullableContext(1)]
		public static FlagChallengeCtx Create()
		{
			return new FlagChallengeCtx();
		}

		// Token: 0x170019CB RID: 6603
		// (get) Token: 0x0600845E RID: 33886 RVA: 0x0013E892 File Offset: 0x0013CA92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019CC RID: 6604
		// (get) Token: 0x0600845F RID: 33887 RVA: 0x0013E895 File Offset: 0x0013CA95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeCtx.Descriptor;
			}
		}

		// Token: 0x06008460 RID: 33888 RVA: 0x0013E89C File Offset: 0x0013CA9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeCtx()
		{
		}

		// Token: 0x06008461 RID: 33889 RVA: 0x0013E8A4 File Offset: 0x0013CAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeCtx(FlagChallengeCtx other) : this()
		{
			this.flagStrongholdId_ = other.flagStrongholdId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008462 RID: 33890 RVA: 0x0013E8C9 File Offset: 0x0013CAC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeCtx Clone()
		{
			return new FlagChallengeCtx(this);
		}

		// Token: 0x170019CD RID: 6605
		// (get) Token: 0x06008463 RID: 33891 RVA: 0x0013E8D1 File Offset: 0x0013CAD1
		// (set) Token: 0x06008464 RID: 33892 RVA: 0x0013E8D9 File Offset: 0x0013CAD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FlagStrongholdId
		{
			get
			{
				return this.flagStrongholdId_;
			}
			set
			{
				this.flagStrongholdId_ = value;
			}
		}

		// Token: 0x06008465 RID: 33893 RVA: 0x0013E8E2 File Offset: 0x0013CAE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeCtx);
		}

		// Token: 0x06008466 RID: 33894 RVA: 0x0013E8F0 File Offset: 0x0013CAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeCtx other)
		{
			return other != null && (other == this || (this.FlagStrongholdId == other.FlagStrongholdId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008467 RID: 33895 RVA: 0x0013E920 File Offset: 0x0013CB20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FlagStrongholdId != 0)
			{
				num ^= this.FlagStrongholdId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008468 RID: 33896 RVA: 0x0013E95F File Offset: 0x0013CB5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008469 RID: 33897 RVA: 0x0013E96C File Offset: 0x0013CB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600846A RID: 33898 RVA: 0x0013E975 File Offset: 0x0013CB75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FlagStrongholdId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FlagStrongholdId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600846B RID: 33899 RVA: 0x0013E9A8 File Offset: 0x0013CBA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FlagStrongholdId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FlagStrongholdId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600846C RID: 33900 RVA: 0x0013E9E6 File Offset: 0x0013CBE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlagChallengeCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FlagStrongholdId != 0)
			{
				this.FlagStrongholdId = other.FlagStrongholdId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600846D RID: 33901 RVA: 0x0013EA17 File Offset: 0x0013CC17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600846E RID: 33902 RVA: 0x0013EA20 File Offset: 0x0013CC20
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.FlagStrongholdId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040041B5 RID: 16821
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041B6 RID: 16822
		public const int FlagStrongholdIdFieldNumber = 1;

		// Token: 0x040041B7 RID: 16823
		private int flagStrongholdId_;
	}
}
