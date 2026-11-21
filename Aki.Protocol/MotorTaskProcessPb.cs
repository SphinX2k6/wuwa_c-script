using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A96 RID: 2710
	public sealed class MotorTaskProcessPb : IMessage<MotorTaskProcessPb>, IMessage, IEquatable<MotorTaskProcessPb>, IDeepCloneable<MotorTaskProcessPb>, IBufferMessage
	{
		// Token: 0x0600EC4B RID: 60491 RVA: 0x002285E1 File Offset: 0x002267E1
		[NullableContext(1)]
		public static MotorTaskProcessPb Create()
		{
			return new MotorTaskProcessPb();
		}

		// Token: 0x17002FFC RID: 12284
		// (get) Token: 0x0600EC4C RID: 60492 RVA: 0x002285E8 File Offset: 0x002267E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FFD RID: 12285
		// (get) Token: 0x0600EC4D RID: 60493 RVA: 0x002285EB File Offset: 0x002267EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskProcessPb.Descriptor;
			}
		}

		// Token: 0x0600EC4E RID: 60494 RVA: 0x002285F2 File Offset: 0x002267F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskProcessPb()
		{
		}

		// Token: 0x0600EC4F RID: 60495 RVA: 0x002285FA File Offset: 0x002267FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskProcessPb(MotorTaskProcessPb other) : this()
		{
			this.current_ = other.current_;
			this.target_ = other.target_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EC50 RID: 60496 RVA: 0x0022862B File Offset: 0x0022682B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskProcessPb Clone()
		{
			return new MotorTaskProcessPb(this);
		}

		// Token: 0x17002FFE RID: 12286
		// (get) Token: 0x0600EC51 RID: 60497 RVA: 0x00228633 File Offset: 0x00226833
		// (set) Token: 0x0600EC52 RID: 60498 RVA: 0x0022863B File Offset: 0x0022683B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Current
		{
			get
			{
				return this.current_;
			}
			set
			{
				this.current_ = value;
			}
		}

		// Token: 0x17002FFF RID: 12287
		// (get) Token: 0x0600EC53 RID: 60499 RVA: 0x00228644 File Offset: 0x00226844
		// (set) Token: 0x0600EC54 RID: 60500 RVA: 0x0022864C File Offset: 0x0022684C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Target
		{
			get
			{
				return this.target_;
			}
			set
			{
				this.target_ = value;
			}
		}

		// Token: 0x0600EC55 RID: 60501 RVA: 0x00228655 File Offset: 0x00226855
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskProcessPb);
		}

		// Token: 0x0600EC56 RID: 60502 RVA: 0x00228663 File Offset: 0x00226863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskProcessPb other)
		{
			return other != null && (other == this || (this.Current == other.Current && this.Target == other.Target && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EC57 RID: 60503 RVA: 0x002286A4 File Offset: 0x002268A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Current != 0)
			{
				int num2 = num;
				int num3 = this.Current;
				num = (num2 ^ num3.GetHashCode());
			}
			if (this.Target != 0)
			{
				num ^= this.Target.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EC58 RID: 60504 RVA: 0x002286FC File Offset: 0x002268FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EC59 RID: 60505 RVA: 0x00228709 File Offset: 0x00226909
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EC5A RID: 60506 RVA: 0x00228714 File Offset: 0x00226914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Current != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Current);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Target);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EC5B RID: 60507 RVA: 0x0022876C File Offset: 0x0022696C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Current != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Current);
			}
			if (this.Target != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Target);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EC5C RID: 60508 RVA: 0x002287C4 File Offset: 0x002269C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorTaskProcessPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Current != 0)
			{
				this.Current = other.Current;
			}
			if (other.Target != 0)
			{
				this.Target = other.Target;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EC5D RID: 60509 RVA: 0x00228814 File Offset: 0x00226A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EC5E RID: 60510 RVA: 0x00228820 File Offset: 0x00226A20
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
						this.Target = input.ReadInt32();
					}
				}
				else
				{
					this.Current = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006031 RID: 24625
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006032 RID: 24626
		public const int CurrentFieldNumber = 1;

		// Token: 0x04006033 RID: 24627
		private int current_;

		// Token: 0x04006034 RID: 24628
		public const int TargetFieldNumber = 2;

		// Token: 0x04006035 RID: 24629
		private int target_;
	}
}
