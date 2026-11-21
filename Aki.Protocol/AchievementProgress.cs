using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000064 RID: 100
	public sealed class AchievementProgress : IMessage<AchievementProgress>, IMessage, IEquatable<AchievementProgress>, IDeepCloneable<AchievementProgress>, IBufferMessage
	{
		// Token: 0x06001692 RID: 5778 RVA: 0x0003B49D File Offset: 0x0003969D
		[NullableContext(1)]
		public static AchievementProgress Create()
		{
			return new AchievementProgress();
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06001693 RID: 5779 RVA: 0x0003B4A4 File Offset: 0x000396A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06001694 RID: 5780 RVA: 0x0003B4A7 File Offset: 0x000396A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementProgress.Descriptor;
			}
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x0003B4AE File Offset: 0x000396AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementProgress()
		{
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x0003B4B6 File Offset: 0x000396B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementProgress(AchievementProgress other) : this()
		{
			this.curProgress_ = other.curProgress_;
			this.totalProgress_ = other.totalProgress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x0003B4E7 File Offset: 0x000396E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementProgress Clone()
		{
			return new AchievementProgress(this);
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06001698 RID: 5784 RVA: 0x0003B4EF File Offset: 0x000396EF
		// (set) Token: 0x06001699 RID: 5785 RVA: 0x0003B4F7 File Offset: 0x000396F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurProgress
		{
			get
			{
				return this.curProgress_;
			}
			set
			{
				this.curProgress_ = value;
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600169A RID: 5786 RVA: 0x0003B500 File Offset: 0x00039700
		// (set) Token: 0x0600169B RID: 5787 RVA: 0x0003B508 File Offset: 0x00039708
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalProgress
		{
			get
			{
				return this.totalProgress_;
			}
			set
			{
				this.totalProgress_ = value;
			}
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x0003B511 File Offset: 0x00039711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementProgress);
		}

		// Token: 0x0600169D RID: 5789 RVA: 0x0003B51F File Offset: 0x0003971F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementProgress other)
		{
			return other != null && (other == this || (this.CurProgress == other.CurProgress && this.TotalProgress == other.TotalProgress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x0003B560 File Offset: 0x00039760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurProgress != 0)
			{
				num ^= this.CurProgress.GetHashCode();
			}
			if (this.TotalProgress != 0)
			{
				num ^= this.TotalProgress.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x0003B5B8 File Offset: 0x000397B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x0003B5C5 File Offset: 0x000397C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060016A1 RID: 5793 RVA: 0x0003B5D0 File Offset: 0x000397D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurProgress != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CurProgress);
			}
			if (this.TotalProgress != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalProgress);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060016A2 RID: 5794 RVA: 0x0003B628 File Offset: 0x00039828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurProgress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurProgress);
			}
			if (this.TotalProgress != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalProgress);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x0003B680 File Offset: 0x00039880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AchievementProgress other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurProgress != 0)
			{
				this.CurProgress = other.CurProgress;
			}
			if (other.TotalProgress != 0)
			{
				this.TotalProgress = other.TotalProgress;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x0003B6D0 File Offset: 0x000398D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060016A5 RID: 5797 RVA: 0x0003B6DC File Offset: 0x000398DC
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
						this.TotalProgress = input.ReadInt32();
					}
				}
				else
				{
					this.CurProgress = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002138 RID: 8504
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002139 RID: 8505
		public const int CurProgressFieldNumber = 1;

		// Token: 0x0400213A RID: 8506
		private int curProgress_;

		// Token: 0x0400213B RID: 8507
		public const int TotalProgressFieldNumber = 2;

		// Token: 0x0400213C RID: 8508
		private int totalProgress_;
	}
}
