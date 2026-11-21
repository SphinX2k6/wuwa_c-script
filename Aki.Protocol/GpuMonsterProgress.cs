using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006F7 RID: 1783
	public sealed class GpuMonsterProgress : IMessage<GpuMonsterProgress>, IMessage, IEquatable<GpuMonsterProgress>, IDeepCloneable<GpuMonsterProgress>, IBufferMessage
	{
		// Token: 0x0600A2BE RID: 41662 RVA: 0x00189B40 File Offset: 0x00187D40
		[NullableContext(1)]
		public static GpuMonsterProgress Create()
		{
			return new GpuMonsterProgress();
		}

		// Token: 0x170020B6 RID: 8374
		// (get) Token: 0x0600A2BF RID: 41663 RVA: 0x00189B47 File Offset: 0x00187D47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020B7 RID: 8375
		// (get) Token: 0x0600A2C0 RID: 41664 RVA: 0x00189B4A File Offset: 0x00187D4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GpuMonsterProgress.Descriptor;
			}
		}

		// Token: 0x0600A2C1 RID: 41665 RVA: 0x00189B51 File Offset: 0x00187D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuMonsterProgress()
		{
		}

		// Token: 0x0600A2C2 RID: 41666 RVA: 0x00189B59 File Offset: 0x00187D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuMonsterProgress(GpuMonsterProgress other) : this()
		{
			this.curKillNum_ = other.curKillNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A2C3 RID: 41667 RVA: 0x00189B7E File Offset: 0x00187D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuMonsterProgress Clone()
		{
			return new GpuMonsterProgress(this);
		}

		// Token: 0x170020B8 RID: 8376
		// (get) Token: 0x0600A2C4 RID: 41668 RVA: 0x00189B86 File Offset: 0x00187D86
		// (set) Token: 0x0600A2C5 RID: 41669 RVA: 0x00189B8E File Offset: 0x00187D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurKillNum
		{
			get
			{
				return this.curKillNum_;
			}
			set
			{
				this.curKillNum_ = value;
			}
		}

		// Token: 0x0600A2C6 RID: 41670 RVA: 0x00189B97 File Offset: 0x00187D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GpuMonsterProgress);
		}

		// Token: 0x0600A2C7 RID: 41671 RVA: 0x00189BA5 File Offset: 0x00187DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GpuMonsterProgress other)
		{
			return other != null && (other == this || (this.CurKillNum == other.CurKillNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A2C8 RID: 41672 RVA: 0x00189BD4 File Offset: 0x00187DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurKillNum != 0)
			{
				num ^= this.CurKillNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A2C9 RID: 41673 RVA: 0x00189C13 File Offset: 0x00187E13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A2CA RID: 41674 RVA: 0x00189C20 File Offset: 0x00187E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A2CB RID: 41675 RVA: 0x00189C29 File Offset: 0x00187E29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurKillNum != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurKillNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A2CC RID: 41676 RVA: 0x00189C5C File Offset: 0x00187E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurKillNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurKillNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A2CD RID: 41677 RVA: 0x00189C9A File Offset: 0x00187E9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GpuMonsterProgress other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurKillNum != 0)
			{
				this.CurKillNum = other.CurKillNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A2CE RID: 41678 RVA: 0x00189CCB File Offset: 0x00187ECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A2CF RID: 41679 RVA: 0x00189CD4 File Offset: 0x00187ED4
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
					this.CurKillNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004BB4 RID: 19380
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BB5 RID: 19381
		public const int CurKillNumFieldNumber = 1;

		// Token: 0x04004BB6 RID: 19382
		private int curKillNum_;
	}
}
