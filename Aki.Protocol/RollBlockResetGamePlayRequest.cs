using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200111E RID: 4382
	[NetMessage(EMessageId.RollBlockResetGamePlayRequest)]
	public sealed class RollBlockResetGamePlayRequest : IMessage<RollBlockResetGamePlayRequest>, IMessage, IEquatable<RollBlockResetGamePlayRequest>, IDeepCloneable<RollBlockResetGamePlayRequest>, IBufferMessage
	{
		// Token: 0x060176A6 RID: 95910 RVA: 0x0036814C File Offset: 0x0036634C
		[NullableContext(1)]
		public static RollBlockResetGamePlayRequest Create()
		{
			return new RollBlockResetGamePlayRequest();
		}

		// Token: 0x17004EAD RID: 20141
		// (get) Token: 0x060176A7 RID: 95911 RVA: 0x00368153 File Offset: 0x00366353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004EAE RID: 20142
		// (get) Token: 0x060176A8 RID: 95912 RVA: 0x00368156 File Offset: 0x00366356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockResetGamePlayRequest.Descriptor;
			}
		}

		// Token: 0x060176A9 RID: 95913 RVA: 0x0036815D File Offset: 0x0036635D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayRequest()
		{
		}

		// Token: 0x060176AA RID: 95914 RVA: 0x00368165 File Offset: 0x00366365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayRequest(RollBlockResetGamePlayRequest other) : this()
		{
			this.incId_ = other.incId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060176AB RID: 95915 RVA: 0x0036818A File Offset: 0x0036638A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockResetGamePlayRequest Clone()
		{
			return new RollBlockResetGamePlayRequest(this);
		}

		// Token: 0x17004EAF RID: 20143
		// (get) Token: 0x060176AC RID: 95916 RVA: 0x00368192 File Offset: 0x00366392
		// (set) Token: 0x060176AD RID: 95917 RVA: 0x0036819A File Offset: 0x0036639A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x060176AE RID: 95918 RVA: 0x003681A3 File Offset: 0x003663A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockResetGamePlayRequest);
		}

		// Token: 0x060176AF RID: 95919 RVA: 0x003681B1 File Offset: 0x003663B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockResetGamePlayRequest other)
		{
			return other != null && (other == this || (this.IncId == other.IncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060176B0 RID: 95920 RVA: 0x003681E0 File Offset: 0x003663E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060176B1 RID: 95921 RVA: 0x0036821F File Offset: 0x0036641F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060176B2 RID: 95922 RVA: 0x0036822C File Offset: 0x0036642C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060176B3 RID: 95923 RVA: 0x00368235 File Offset: 0x00366435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.IncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060176B4 RID: 95924 RVA: 0x00368268 File Offset: 0x00366468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060176B5 RID: 95925 RVA: 0x003682A6 File Offset: 0x003664A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockResetGamePlayRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060176B6 RID: 95926 RVA: 0x003682D7 File Offset: 0x003664D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060176B7 RID: 95927 RVA: 0x003682E0 File Offset: 0x003664E0
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008BCD RID: 35789
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BCE RID: 35790
		public const int IncIdFieldNumber = 10;

		// Token: 0x04008BCF RID: 35791
		private int incId_;
	}
}
