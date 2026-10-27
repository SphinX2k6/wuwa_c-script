using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001023 RID: 4131
	[NetMessage(EMessageId.RogueTowerTrialSelectBossRequest)]
	public sealed class RogueTowerTrialSelectBossRequest : IMessage<RogueTowerTrialSelectBossRequest>, IMessage, IEquatable<RogueTowerTrialSelectBossRequest>, IDeepCloneable<RogueTowerTrialSelectBossRequest>, IBufferMessage
	{
		// Token: 0x06016152 RID: 90450 RVA: 0x003358C5 File Offset: 0x00333AC5
		[NullableContext(1)]
		public static RogueTowerTrialSelectBossRequest Create()
		{
			return new RogueTowerTrialSelectBossRequest();
		}

		// Token: 0x170049D0 RID: 18896
		// (get) Token: 0x06016153 RID: 90451 RVA: 0x003358CC File Offset: 0x00333ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049D1 RID: 18897
		// (get) Token: 0x06016154 RID: 90452 RVA: 0x003358CF File Offset: 0x00333ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueTowerTrialSelectBossRequest.Descriptor;
			}
		}

		// Token: 0x06016155 RID: 90453 RVA: 0x003358D6 File Offset: 0x00333AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossRequest()
		{
		}

		// Token: 0x06016156 RID: 90454 RVA: 0x003358DE File Offset: 0x00333ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossRequest(RogueTowerTrialSelectBossRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016157 RID: 90455 RVA: 0x00335903 File Offset: 0x00333B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueTowerTrialSelectBossRequest Clone()
		{
			return new RogueTowerTrialSelectBossRequest(this);
		}

		// Token: 0x170049D2 RID: 18898
		// (get) Token: 0x06016158 RID: 90456 RVA: 0x0033590B File Offset: 0x00333B0B
		// (set) Token: 0x06016159 RID: 90457 RVA: 0x00335913 File Offset: 0x00333B13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x0601615A RID: 90458 RVA: 0x0033591C File Offset: 0x00333B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueTowerTrialSelectBossRequest);
		}

		// Token: 0x0601615B RID: 90459 RVA: 0x0033592A File Offset: 0x00333B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueTowerTrialSelectBossRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601615C RID: 90460 RVA: 0x00335958 File Offset: 0x00333B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601615D RID: 90461 RVA: 0x00335997 File Offset: 0x00333B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601615E RID: 90462 RVA: 0x003359A4 File Offset: 0x00333BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601615F RID: 90463 RVA: 0x003359AD File Offset: 0x00333BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016160 RID: 90464 RVA: 0x003359E0 File Offset: 0x00333BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016161 RID: 90465 RVA: 0x00335A1E File Offset: 0x00333C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueTowerTrialSelectBossRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016162 RID: 90466 RVA: 0x00335A4F File Offset: 0x00333C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016163 RID: 90467 RVA: 0x00335A58 File Offset: 0x00333C58
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008454 RID: 33876
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008455 RID: 33877
		public const int IdFieldNumber = 4;

		// Token: 0x04008456 RID: 33878
		private int id_;
	}
}
