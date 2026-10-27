using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200102C RID: 4140
	[NetMessage(EMessageId.RogueWeeklyArtifactSelectRequest)]
	public sealed class RogueWeeklyArtifactSelectRequest : IMessage<RogueWeeklyArtifactSelectRequest>, IMessage, IEquatable<RogueWeeklyArtifactSelectRequest>, IDeepCloneable<RogueWeeklyArtifactSelectRequest>, IBufferMessage
	{
		// Token: 0x060161FF RID: 90623 RVA: 0x00336DA4 File Offset: 0x00334FA4
		[NullableContext(1)]
		public static RogueWeeklyArtifactSelectRequest Create()
		{
			return new RogueWeeklyArtifactSelectRequest();
		}

		// Token: 0x170049F1 RID: 18929
		// (get) Token: 0x06016200 RID: 90624 RVA: 0x00336DAB File Offset: 0x00334FAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049F2 RID: 18930
		// (get) Token: 0x06016201 RID: 90625 RVA: 0x00336DAE File Offset: 0x00334FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyArtifactSelectRequest.Descriptor;
			}
		}

		// Token: 0x06016202 RID: 90626 RVA: 0x00336DB5 File Offset: 0x00334FB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactSelectRequest()
		{
		}

		// Token: 0x06016203 RID: 90627 RVA: 0x00336DBD File Offset: 0x00334FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactSelectRequest(RogueWeeklyArtifactSelectRequest other) : this()
		{
			this.index_ = other.index_;
			this.cycleId_ = other.cycleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016204 RID: 90628 RVA: 0x00336DEE File Offset: 0x00334FEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactSelectRequest Clone()
		{
			return new RogueWeeklyArtifactSelectRequest(this);
		}

		// Token: 0x170049F3 RID: 18931
		// (get) Token: 0x06016205 RID: 90629 RVA: 0x00336DF6 File Offset: 0x00334FF6
		// (set) Token: 0x06016206 RID: 90630 RVA: 0x00336DFE File Offset: 0x00334FFE
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

		// Token: 0x170049F4 RID: 18932
		// (get) Token: 0x06016207 RID: 90631 RVA: 0x00336E07 File Offset: 0x00335007
		// (set) Token: 0x06016208 RID: 90632 RVA: 0x00336E0F File Offset: 0x0033500F
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

		// Token: 0x06016209 RID: 90633 RVA: 0x00336E18 File Offset: 0x00335018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyArtifactSelectRequest);
		}

		// Token: 0x0601620A RID: 90634 RVA: 0x00336E26 File Offset: 0x00335026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyArtifactSelectRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.CycleId == other.CycleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601620B RID: 90635 RVA: 0x00336E64 File Offset: 0x00335064
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

		// Token: 0x0601620C RID: 90636 RVA: 0x00336EBC File Offset: 0x003350BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601620D RID: 90637 RVA: 0x00336EC9 File Offset: 0x003350C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601620E RID: 90638 RVA: 0x00336ED4 File Offset: 0x003350D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CycleId != 0)
			{
				output.WriteRawTag(40);
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

		// Token: 0x0601620F RID: 90639 RVA: 0x00336F30 File Offset: 0x00335130
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

		// Token: 0x06016210 RID: 90640 RVA: 0x00336F88 File Offset: 0x00335188
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

		// Token: 0x06016211 RID: 90641 RVA: 0x00336FD8 File Offset: 0x003351D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016212 RID: 90642 RVA: 0x00336FE4 File Offset: 0x003351E4
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
				if (num != 40U)
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

		// Token: 0x0400847A RID: 33914
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400847B RID: 33915
		public const int IndexFieldNumber = 10;

		// Token: 0x0400847C RID: 33916
		private int index_;

		// Token: 0x0400847D RID: 33917
		public const int CycleIdFieldNumber = 5;

		// Token: 0x0400847E RID: 33918
		private int cycleId_;
	}
}
