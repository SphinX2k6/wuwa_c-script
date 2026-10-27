using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200070B RID: 1803
	public sealed class GpuMonsterProgress : IMessage<GpuMonsterProgress>, IMessage, IEquatable<GpuMonsterProgress>, IDeepCloneable<GpuMonsterProgress>, IBufferMessage
	{
		// Token: 0x0600A414 RID: 42004 RVA: 0x0018C574 File Offset: 0x0018A774
		[NullableContext(1)]
		public static GpuMonsterProgress Create()
		{
			return new GpuMonsterProgress();
		}

		// Token: 0x17002100 RID: 8448
		// (get) Token: 0x0600A415 RID: 42005 RVA: 0x0018C57B File Offset: 0x0018A77B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002101 RID: 8449
		// (get) Token: 0x0600A416 RID: 42006 RVA: 0x0018C57E File Offset: 0x0018A77E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GpuMonsterProgress.Descriptor;
			}
		}

		// Token: 0x0600A417 RID: 42007 RVA: 0x0018C585 File Offset: 0x0018A785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuMonsterProgress()
		{
		}

		// Token: 0x0600A418 RID: 42008 RVA: 0x0018C58D File Offset: 0x0018A78D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuMonsterProgress(GpuMonsterProgress other) : this()
		{
			this.curKillNum_ = other.curKillNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A419 RID: 42009 RVA: 0x0018C5B2 File Offset: 0x0018A7B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GpuMonsterProgress Clone()
		{
			return new GpuMonsterProgress(this);
		}

		// Token: 0x17002102 RID: 8450
		// (get) Token: 0x0600A41A RID: 42010 RVA: 0x0018C5BA File Offset: 0x0018A7BA
		// (set) Token: 0x0600A41B RID: 42011 RVA: 0x0018C5C2 File Offset: 0x0018A7C2
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

		// Token: 0x0600A41C RID: 42012 RVA: 0x0018C5CB File Offset: 0x0018A7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GpuMonsterProgress);
		}

		// Token: 0x0600A41D RID: 42013 RVA: 0x0018C5D9 File Offset: 0x0018A7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GpuMonsterProgress other)
		{
			return other != null && (other == this || (this.CurKillNum == other.CurKillNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A41E RID: 42014 RVA: 0x0018C608 File Offset: 0x0018A808
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

		// Token: 0x0600A41F RID: 42015 RVA: 0x0018C647 File Offset: 0x0018A847
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A420 RID: 42016 RVA: 0x0018C654 File Offset: 0x0018A854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A421 RID: 42017 RVA: 0x0018C65D File Offset: 0x0018A85D
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

		// Token: 0x0600A422 RID: 42018 RVA: 0x0018C690 File Offset: 0x0018A890
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

		// Token: 0x0600A423 RID: 42019 RVA: 0x0018C6CE File Offset: 0x0018A8CE
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

		// Token: 0x0600A424 RID: 42020 RVA: 0x0018C6FF File Offset: 0x0018A8FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A425 RID: 42021 RVA: 0x0018C708 File Offset: 0x0018A908
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

		// Token: 0x04004BBB RID: 19387
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BBC RID: 19388
		public const int CurKillNumFieldNumber = 1;

		// Token: 0x04004BBD RID: 19389
		private int curKillNum_;
	}
}
