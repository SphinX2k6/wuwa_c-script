using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000820 RID: 2080
	public sealed class InteractProgress : IMessage<InteractProgress>, IMessage, IEquatable<InteractProgress>, IDeepCloneable<InteractProgress>, IBufferMessage
	{
		// Token: 0x0600BA4C RID: 47692 RVA: 0x001BC3A4 File Offset: 0x001BA5A4
		[NullableContext(1)]
		public static InteractProgress Create()
		{
			return new InteractProgress();
		}

		// Token: 0x1700259A RID: 9626
		// (get) Token: 0x0600BA4D RID: 47693 RVA: 0x001BC3AB File Offset: 0x001BA5AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700259B RID: 9627
		// (get) Token: 0x0600BA4E RID: 47694 RVA: 0x001BC3AE File Offset: 0x001BA5AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InteractProgress.Descriptor;
			}
		}

		// Token: 0x0600BA4F RID: 47695 RVA: 0x001BC3B5 File Offset: 0x001BA5B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractProgress()
		{
		}

		// Token: 0x0600BA50 RID: 47696 RVA: 0x001BC3C8 File Offset: 0x001BA5C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractProgress(InteractProgress other) : this()
		{
			this.npcId_ = other.npcId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BA51 RID: 47697 RVA: 0x001BC3F2 File Offset: 0x001BA5F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InteractProgress Clone()
		{
			return new InteractProgress(this);
		}

		// Token: 0x1700259C RID: 9628
		// (get) Token: 0x0600BA52 RID: 47698 RVA: 0x001BC3FA File Offset: 0x001BA5FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NpcId
		{
			get
			{
				return this.npcId_;
			}
		}

		// Token: 0x0600BA53 RID: 47699 RVA: 0x001BC402 File Offset: 0x001BA602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InteractProgress);
		}

		// Token: 0x0600BA54 RID: 47700 RVA: 0x001BC410 File Offset: 0x001BA610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InteractProgress other)
		{
			return other != null && (other == this || (this.npcId_.Equals(other.npcId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA55 RID: 47701 RVA: 0x001BC444 File Offset: 0x001BA644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.npcId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BA56 RID: 47702 RVA: 0x001BC478 File Offset: 0x001BA678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BA57 RID: 47703 RVA: 0x001BC485 File Offset: 0x001BA685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA58 RID: 47704 RVA: 0x001BC48E File Offset: 0x001BA68E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.npcId_.WriteTo(ref output, InteractProgress._repeated_npcId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA59 RID: 47705 RVA: 0x001BC4B8 File Offset: 0x001BA6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.npcId_.CalculateSize(InteractProgress._repeated_npcId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BA5A RID: 47706 RVA: 0x001BC4F1 File Offset: 0x001BA6F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InteractProgress other)
		{
			if (other == null)
			{
				return;
			}
			this.npcId_.Add(other.npcId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BA5B RID: 47707 RVA: 0x001BC51F File Offset: 0x001BA71F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA5C RID: 47708 RVA: 0x001BC528 File Offset: 0x001BA728
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.npcId_.AddEntriesFrom(ref input, InteractProgress._repeated_npcId_codec);
				}
			}
		}

		// Token: 0x0400524C RID: 21068
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400524D RID: 21069
		public const int NpcIdFieldNumber = 1;

		// Token: 0x0400524E RID: 21070
		private static readonly FieldCodec<int> _repeated_npcId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400524F RID: 21071
		private readonly RepeatedField<int> npcId_ = new RepeatedField<int>();
	}
}
