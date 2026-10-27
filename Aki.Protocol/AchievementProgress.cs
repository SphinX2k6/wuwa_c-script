using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000063 RID: 99
	public sealed class AchievementProgress : IMessage<AchievementProgress>, IMessage, IEquatable<AchievementProgress>, IDeepCloneable<AchievementProgress>, IBufferMessage
	{
		// Token: 0x0600164F RID: 5711 RVA: 0x0003AAF9 File Offset: 0x00038CF9
		[NullableContext(1)]
		public static AchievementProgress Create()
		{
			return new AchievementProgress();
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x0003AB00 File Offset: 0x00038D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x0003AB03 File Offset: 0x00038D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AchievementProgress.Descriptor;
			}
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0003AB0A File Offset: 0x00038D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementProgress()
		{
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x0003AB12 File Offset: 0x00038D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementProgress(AchievementProgress other) : this()
		{
			this.curProgress_ = other.curProgress_;
			this.totalProgress_ = other.totalProgress_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0003AB43 File Offset: 0x00038D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AchievementProgress Clone()
		{
			return new AchievementProgress(this);
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06001655 RID: 5717 RVA: 0x0003AB4B File Offset: 0x00038D4B
		// (set) Token: 0x06001656 RID: 5718 RVA: 0x0003AB53 File Offset: 0x00038D53
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

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06001657 RID: 5719 RVA: 0x0003AB5C File Offset: 0x00038D5C
		// (set) Token: 0x06001658 RID: 5720 RVA: 0x0003AB64 File Offset: 0x00038D64
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

		// Token: 0x06001659 RID: 5721 RVA: 0x0003AB6D File Offset: 0x00038D6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AchievementProgress);
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x0003AB7B File Offset: 0x00038D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AchievementProgress other)
		{
			return other != null && (other == this || (this.CurProgress == other.CurProgress && this.TotalProgress == other.TotalProgress && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0003ABBC File Offset: 0x00038DBC
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

		// Token: 0x0600165C RID: 5724 RVA: 0x0003AC14 File Offset: 0x00038E14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600165D RID: 5725 RVA: 0x0003AC21 File Offset: 0x00038E21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600165E RID: 5726 RVA: 0x0003AC2C File Offset: 0x00038E2C
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

		// Token: 0x0600165F RID: 5727 RVA: 0x0003AC84 File Offset: 0x00038E84
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

		// Token: 0x06001660 RID: 5728 RVA: 0x0003ACDC File Offset: 0x00038EDC
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

		// Token: 0x06001661 RID: 5729 RVA: 0x0003AD2C File Offset: 0x00038F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001662 RID: 5730 RVA: 0x0003AD38 File Offset: 0x00038F38
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

		// Token: 0x040020D9 RID: 8409
		private UnknownFieldSet _unknownFields;

		// Token: 0x040020DA RID: 8410
		public const int CurProgressFieldNumber = 1;

		// Token: 0x040020DB RID: 8411
		private int curProgress_;

		// Token: 0x040020DC RID: 8412
		public const int TotalProgressFieldNumber = 2;

		// Token: 0x040020DD RID: 8413
		private int totalProgress_;
	}
}
