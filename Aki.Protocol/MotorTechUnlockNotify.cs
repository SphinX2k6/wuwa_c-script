using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA1 RID: 2721
	[NetMessage(EMessageId.MotorTechUnlockNotify)]
	public sealed class MotorTechUnlockNotify : IMessage<MotorTechUnlockNotify>, IMessage, IEquatable<MotorTechUnlockNotify>, IDeepCloneable<MotorTechUnlockNotify>, IBufferMessage
	{
		// Token: 0x0600ED2D RID: 60717 RVA: 0x0022A3B1 File Offset: 0x002285B1
		[NullableContext(1)]
		public static MotorTechUnlockNotify Create()
		{
			return new MotorTechUnlockNotify();
		}

		// Token: 0x1700302C RID: 12332
		// (get) Token: 0x0600ED2E RID: 60718 RVA: 0x0022A3B8 File Offset: 0x002285B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700302D RID: 12333
		// (get) Token: 0x0600ED2F RID: 60719 RVA: 0x0022A3BB File Offset: 0x002285BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTechUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0600ED30 RID: 60720 RVA: 0x0022A3C2 File Offset: 0x002285C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechUnlockNotify()
		{
		}

		// Token: 0x0600ED31 RID: 60721 RVA: 0x0022A3D5 File Offset: 0x002285D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechUnlockNotify(MotorTechUnlockNotify other) : this()
		{
			this.techId_ = other.techId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED32 RID: 60722 RVA: 0x0022A3FF File Offset: 0x002285FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTechUnlockNotify Clone()
		{
			return new MotorTechUnlockNotify(this);
		}

		// Token: 0x1700302E RID: 12334
		// (get) Token: 0x0600ED33 RID: 60723 RVA: 0x0022A407 File Offset: 0x00228607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TechId
		{
			get
			{
				return this.techId_;
			}
		}

		// Token: 0x0600ED34 RID: 60724 RVA: 0x0022A40F File Offset: 0x0022860F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTechUnlockNotify);
		}

		// Token: 0x0600ED35 RID: 60725 RVA: 0x0022A41D File Offset: 0x0022861D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTechUnlockNotify other)
		{
			return other != null && (other == this || (this.techId_.Equals(other.techId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED36 RID: 60726 RVA: 0x0022A450 File Offset: 0x00228650
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

		// Token: 0x0600ED37 RID: 60727 RVA: 0x0022A484 File Offset: 0x00228684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED38 RID: 60728 RVA: 0x0022A491 File Offset: 0x00228691
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED39 RID: 60729 RVA: 0x0022A49A File Offset: 0x0022869A
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

		// Token: 0x0600ED3A RID: 60730 RVA: 0x0022A4C4 File Offset: 0x002286C4
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

		// Token: 0x0600ED3B RID: 60731 RVA: 0x0022A4FD File Offset: 0x002286FD
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

		// Token: 0x0600ED3C RID: 60732 RVA: 0x0022A52B File Offset: 0x0022872B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED3D RID: 60733 RVA: 0x0022A534 File Offset: 0x00228734
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
				if (num != 56U && num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.techId_.AddEntriesFrom(ref input, MotorTechUnlockNotify._repeated_techId_codec);
				}
			}
		}

		// Token: 0x04006070 RID: 24688
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006071 RID: 24689
		public const int TechIdFieldNumber = 7;

		// Token: 0x04006072 RID: 24690
		private static readonly FieldCodec<int> _repeated_techId_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04006073 RID: 24691
		private readonly RepeatedField<int> techId_ = new RepeatedField<int>();
	}
}
