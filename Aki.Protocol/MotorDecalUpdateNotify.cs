using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A1E RID: 2590
	[NetMessage(EMessageId.MotorDecalUpdateNotify)]
	public sealed class MotorDecalUpdateNotify : IMessage<MotorDecalUpdateNotify>, IMessage, IEquatable<MotorDecalUpdateNotify>, IDeepCloneable<MotorDecalUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E2A6 RID: 58022 RVA: 0x00212FA0 File Offset: 0x002111A0
		[NullableContext(1)]
		public static MotorDecalUpdateNotify Create()
		{
			return new MotorDecalUpdateNotify();
		}

		// Token: 0x17002DED RID: 11757
		// (get) Token: 0x0600E2A7 RID: 58023 RVA: 0x00212FA7 File Offset: 0x002111A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002DEE RID: 11758
		// (get) Token: 0x0600E2A8 RID: 58024 RVA: 0x00212FAA File Offset: 0x002111AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorDecalUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E2A9 RID: 58025 RVA: 0x00212FB1 File Offset: 0x002111B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalUpdateNotify()
		{
		}

		// Token: 0x0600E2AA RID: 58026 RVA: 0x00212FB9 File Offset: 0x002111B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalUpdateNotify(MotorDecalUpdateNotify other) : this()
		{
			this.task_ = ((other.task_ != null) ? other.task_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E2AB RID: 58027 RVA: 0x00212FEE File Offset: 0x002111EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorDecalUpdateNotify Clone()
		{
			return new MotorDecalUpdateNotify(this);
		}

		// Token: 0x17002DEF RID: 11759
		// (get) Token: 0x0600E2AC RID: 58028 RVA: 0x00212FF6 File Offset: 0x002111F6
		// (set) Token: 0x0600E2AD RID: 58029 RVA: 0x00212FFE File Offset: 0x002111FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConditionTask Task
		{
			get
			{
				return this.task_;
			}
			set
			{
				this.task_ = value;
			}
		}

		// Token: 0x0600E2AE RID: 58030 RVA: 0x00213007 File Offset: 0x00211207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorDecalUpdateNotify);
		}

		// Token: 0x0600E2AF RID: 58031 RVA: 0x00213015 File Offset: 0x00211215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorDecalUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.Task, other.Task) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E2B0 RID: 58032 RVA: 0x00213048 File Offset: 0x00211248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.task_ != null)
			{
				num ^= this.Task.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E2B1 RID: 58033 RVA: 0x00213084 File Offset: 0x00211284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E2B2 RID: 58034 RVA: 0x00213091 File Offset: 0x00211291
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E2B3 RID: 58035 RVA: 0x0021309A File Offset: 0x0021129A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.task_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.Task);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E2B4 RID: 58036 RVA: 0x002130CC File Offset: 0x002112CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.task_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Task);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E2B5 RID: 58037 RVA: 0x0021310C File Offset: 0x0021130C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorDecalUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.task_ != null)
			{
				if (this.task_ == null)
				{
					this.Task = new ConditionTask();
				}
				this.Task.MergeFrom(other.Task);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E2B6 RID: 58038 RVA: 0x00213160 File Offset: 0x00211360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E2B7 RID: 58039 RVA: 0x0021316C File Offset: 0x0021136C
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.task_ == null)
					{
						this.Task = new ConditionTask();
					}
					input.ReadMessage(this.Task);
				}
			}
		}

		// Token: 0x04005D4D RID: 23885
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005D4E RID: 23886
		public const int TaskFieldNumber = 2;

		// Token: 0x04005D4F RID: 23887
		private ConditionTask task_;
	}
}
