using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000580 RID: 1408
	public sealed class FlagChallengeCtx : IMessage<FlagChallengeCtx>, IMessage, IEquatable<FlagChallengeCtx>, IDeepCloneable<FlagChallengeCtx>, IBufferMessage
	{
		// Token: 0x060082F5 RID: 33525 RVA: 0x0013BC84 File Offset: 0x00139E84
		[NullableContext(1)]
		public static FlagChallengeCtx Create()
		{
			return new FlagChallengeCtx();
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x060082F6 RID: 33526 RVA: 0x0013BC8B File Offset: 0x00139E8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x060082F7 RID: 33527 RVA: 0x0013BC8E File Offset: 0x00139E8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlagChallengeCtx.Descriptor;
			}
		}

		// Token: 0x060082F8 RID: 33528 RVA: 0x0013BC95 File Offset: 0x00139E95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeCtx()
		{
		}

		// Token: 0x060082F9 RID: 33529 RVA: 0x0013BC9D File Offset: 0x00139E9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeCtx(FlagChallengeCtx other) : this()
		{
			this.flagStrongholdId_ = other.flagStrongholdId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060082FA RID: 33530 RVA: 0x0013BCC2 File Offset: 0x00139EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlagChallengeCtx Clone()
		{
			return new FlagChallengeCtx(this);
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x060082FB RID: 33531 RVA: 0x0013BCCA File Offset: 0x00139ECA
		// (set) Token: 0x060082FC RID: 33532 RVA: 0x0013BCD2 File Offset: 0x00139ED2
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

		// Token: 0x060082FD RID: 33533 RVA: 0x0013BCDB File Offset: 0x00139EDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlagChallengeCtx);
		}

		// Token: 0x060082FE RID: 33534 RVA: 0x0013BCE9 File Offset: 0x00139EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlagChallengeCtx other)
		{
			return other != null && (other == this || (this.FlagStrongholdId == other.FlagStrongholdId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060082FF RID: 33535 RVA: 0x0013BD18 File Offset: 0x00139F18
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

		// Token: 0x06008300 RID: 33536 RVA: 0x0013BD57 File Offset: 0x00139F57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008301 RID: 33537 RVA: 0x0013BD64 File Offset: 0x00139F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008302 RID: 33538 RVA: 0x0013BD6D File Offset: 0x00139F6D
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

		// Token: 0x06008303 RID: 33539 RVA: 0x0013BDA0 File Offset: 0x00139FA0
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

		// Token: 0x06008304 RID: 33540 RVA: 0x0013BDDE File Offset: 0x00139FDE
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

		// Token: 0x06008305 RID: 33541 RVA: 0x0013BE0F File Offset: 0x0013A00F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008306 RID: 33542 RVA: 0x0013BE18 File Offset: 0x0013A018
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

		// Token: 0x040041AB RID: 16811
		private UnknownFieldSet _unknownFields;

		// Token: 0x040041AC RID: 16812
		public const int FlagStrongholdIdFieldNumber = 1;

		// Token: 0x040041AD RID: 16813
		private int flagStrongholdId_;
	}
}
