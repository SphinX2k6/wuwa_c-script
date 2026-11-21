using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200101C RID: 4124
	[NetMessage(EMessageId.RogueWeeklyArtifactSelectRequest)]
	public sealed class RogueWeeklyArtifactSelectRequest : IMessage<RogueWeeklyArtifactSelectRequest>, IMessage, IEquatable<RogueWeeklyArtifactSelectRequest>, IDeepCloneable<RogueWeeklyArtifactSelectRequest>, IBufferMessage
	{
		// Token: 0x0601611A RID: 90394 RVA: 0x003356E4 File Offset: 0x003338E4
		[NullableContext(1)]
		public static RogueWeeklyArtifactSelectRequest Create()
		{
			return new RogueWeeklyArtifactSelectRequest();
		}

		// Token: 0x170049C7 RID: 18887
		// (get) Token: 0x0601611B RID: 90395 RVA: 0x003356EB File Offset: 0x003338EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049C8 RID: 18888
		// (get) Token: 0x0601611C RID: 90396 RVA: 0x003356EE File Offset: 0x003338EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyArtifactSelectRequest.Descriptor;
			}
		}

		// Token: 0x0601611D RID: 90397 RVA: 0x003356F5 File Offset: 0x003338F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactSelectRequest()
		{
		}

		// Token: 0x0601611E RID: 90398 RVA: 0x003356FD File Offset: 0x003338FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactSelectRequest(RogueWeeklyArtifactSelectRequest other) : this()
		{
			this.index_ = other.index_;
			this.cycleId_ = other.cycleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601611F RID: 90399 RVA: 0x0033572E File Offset: 0x0033392E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactSelectRequest Clone()
		{
			return new RogueWeeklyArtifactSelectRequest(this);
		}

		// Token: 0x170049C9 RID: 18889
		// (get) Token: 0x06016120 RID: 90400 RVA: 0x00335736 File Offset: 0x00333936
		// (set) Token: 0x06016121 RID: 90401 RVA: 0x0033573E File Offset: 0x0033393E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x170049CA RID: 18890
		// (get) Token: 0x06016122 RID: 90402 RVA: 0x00335747 File Offset: 0x00333947
		// (set) Token: 0x06016123 RID: 90403 RVA: 0x0033574F File Offset: 0x0033394F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CycleId
		{
			get
			{
				return this.cycleId_;
			}
			set
			{
				this.cycleId_ = value;
			}
		}

		// Token: 0x06016124 RID: 90404 RVA: 0x00335758 File Offset: 0x00333958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyArtifactSelectRequest);
		}

		// Token: 0x06016125 RID: 90405 RVA: 0x00335766 File Offset: 0x00333966
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyArtifactSelectRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.CycleId == other.CycleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016126 RID: 90406 RVA: 0x003357A4 File Offset: 0x003339A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.CycleId != 0)
			{
				num ^= this.CycleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016127 RID: 90407 RVA: 0x003357FC File Offset: 0x003339FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016128 RID: 90408 RVA: 0x00335809 File Offset: 0x00333A09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016129 RID: 90409 RVA: 0x00335814 File Offset: 0x00333A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CycleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CycleId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601612A RID: 90410 RVA: 0x00335870 File Offset: 0x00333A70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.CycleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CycleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601612B RID: 90411 RVA: 0x003358C8 File Offset: 0x00333AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyArtifactSelectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.CycleId != 0)
			{
				this.CycleId = other.CycleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601612C RID: 90412 RVA: 0x00335918 File Offset: 0x00333B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601612D RID: 90413 RVA: 0x00335924 File Offset: 0x00333B24
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
				if (num != 16U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.CycleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040084A4 RID: 33956
		private UnknownFieldSet _unknownFields;

		// Token: 0x040084A5 RID: 33957
		public const int IndexFieldNumber = 10;

		// Token: 0x040084A6 RID: 33958
		private int index_;

		// Token: 0x040084A7 RID: 33959
		public const int CycleIdFieldNumber = 2;

		// Token: 0x040084A8 RID: 33960
		private int cycleId_;
	}
}
