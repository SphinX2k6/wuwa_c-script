using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AB2 RID: 2738
	[NetMessage(EMessageId.MotorTechUnlockNotify)]
	public sealed class MotorTechUnlockNotify : IMessage<MotorTechUnlockNotify>, IMessage, IEquatable<MotorTechUnlockNotify>, IDeepCloneable<MotorTechUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600EE47 RID: 60999 RVA: 0x0022C5B1 File Offset: 0x0022A7B1
		[NullableContext(1)]
		public static MotorTechUnlockNotify Create()
		{
			return new MotorTechUnlockNotify();
		}

		// Token: 0x1700306A RID: 12394
		// (get) Token: 0x0600EE48 RID: 61000 RVA: 0x0022C5B8 File Offset: 0x0022A7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700306B RID: 12395
		// (get) Token: 0x0600EE49 RID: 61001 RVA: 0x0022C5BB File Offset: 0x0022A7BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600EE4A RID: 61002 RVA: 0x0022C5C2 File Offset: 0x0022A7C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechUnlockNotify()
		{
		}

		// Token: 0x0600EE4B RID: 61003 RVA: 0x0022C5D5 File Offset: 0x0022A7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechUnlockNotify(MotorTechUnlockNotify other) : this()
		{
			this.techId_ = other.techId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EE4C RID: 61004 RVA: 0x0022C5FF File Offset: 0x0022A7FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechUnlockNotify Clone()
		{
			return new MotorTechUnlockNotify(this);
		}

		// Token: 0x1700306C RID: 12396
		// (get) Token: 0x0600EE4D RID: 61005 RVA: 0x0022C607 File Offset: 0x0022A807
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TechId
		{
			get
			{
				return this.techId_;
			}
		}

		// Token: 0x0600EE4E RID: 61006 RVA: 0x0022C60F File Offset: 0x0022A80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechUnlockNotify);
		}

		// Token: 0x0600EE4F RID: 61007 RVA: 0x0022C61D File Offset: 0x0022A81D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechUnlockNotify other)
		{
			return other != null && (other == this || (this.techId_.Equals(other.techId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EE50 RID: 61008 RVA: 0x0022C650 File Offset: 0x0022A850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.techId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EE51 RID: 61009 RVA: 0x0022C684 File Offset: 0x0022A884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EE52 RID: 61010 RVA: 0x0022C691 File Offset: 0x0022A891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EE53 RID: 61011 RVA: 0x0022C69A File Offset: 0x0022A89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.techId_.WriteTo(ref output, MotorTechUnlockNotify._repeated_techId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EE54 RID: 61012 RVA: 0x0022C6C4 File Offset: 0x0022A8C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.techId_.CalculateSize(MotorTechUnlockNotify._repeated_techId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EE55 RID: 61013 RVA: 0x0022C6FD File Offset: 0x0022A8FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTechUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.techId_.Add(other.techId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EE56 RID: 61014 RVA: 0x0022C72B File Offset: 0x0022A92B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EE57 RID: 61015 RVA: 0x0022C734 File Offset: 0x0022A934
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
				if (num != 104U && num != 106U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.techId_.AddEntriesFrom(ref input, MotorTechUnlockNotify._repeated_techId_codec);
				}
			}
		}

		// Token: 0x04006067 RID: 24679
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006068 RID: 24680
		public const int TechIdFieldNumber = 13;

		// Token: 0x04006069 RID: 24681
		private static readonly FieldCodec<int> _repeated_techId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x0400606A RID: 24682
		private readonly RepeatedField<int> techId_ = new RepeatedField<int>();
	}
}
