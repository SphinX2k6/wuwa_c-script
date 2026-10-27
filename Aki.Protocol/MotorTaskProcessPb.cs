using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000AA7 RID: 2727
	public sealed class MotorTaskProcessPb : IMessage<MotorTaskProcessPb>, IMessage, IEquatable<MotorTaskProcessPb>, IDeepCloneable<MotorTaskProcessPb>, IBufferMessage
	{
		// Token: 0x0600ED65 RID: 60773 RVA: 0x0022A7DD File Offset: 0x002289DD
		[NullableContext(1)]
		public static MotorTaskProcessPb Create()
		{
			return new MotorTaskProcessPb();
		}

		// Token: 0x1700303A RID: 12346
		// (get) Token: 0x0600ED66 RID: 60774 RVA: 0x0022A7E4 File Offset: 0x002289E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700303B RID: 12347
		// (get) Token: 0x0600ED67 RID: 60775 RVA: 0x0022A7E7 File Offset: 0x002289E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorTaskProcessPb.Descriptor;
			}
		}

		// Token: 0x0600ED68 RID: 60776 RVA: 0x0022A7EE File Offset: 0x002289EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskProcessPb()
		{
		}

		// Token: 0x0600ED69 RID: 60777 RVA: 0x0022A7F6 File Offset: 0x002289F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskProcessPb(MotorTaskProcessPb other) : this()
		{
			this.current_ = other.current_;
			this.target_ = other.target_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ED6A RID: 60778 RVA: 0x0022A827 File Offset: 0x00228A27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorTaskProcessPb Clone()
		{
			return new MotorTaskProcessPb(this);
		}

		// Token: 0x1700303C RID: 12348
		// (get) Token: 0x0600ED6B RID: 60779 RVA: 0x0022A82F File Offset: 0x00228A2F
		// (set) Token: 0x0600ED6C RID: 60780 RVA: 0x0022A837 File Offset: 0x00228A37
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

		// Token: 0x1700303D RID: 12349
		// (get) Token: 0x0600ED6D RID: 60781 RVA: 0x0022A840 File Offset: 0x00228A40
		// (set) Token: 0x0600ED6E RID: 60782 RVA: 0x0022A848 File Offset: 0x00228A48
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

		// Token: 0x0600ED6F RID: 60783 RVA: 0x0022A851 File Offset: 0x00228A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorTaskProcessPb);
		}

		// Token: 0x0600ED70 RID: 60784 RVA: 0x0022A85F File Offset: 0x00228A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorTaskProcessPb other)
		{
			return other != null && (other == this || (this.Current == other.Current && this.Target == other.Target && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ED71 RID: 60785 RVA: 0x0022A8A0 File Offset: 0x00228AA0
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

		// Token: 0x0600ED72 RID: 60786 RVA: 0x0022A8F8 File Offset: 0x00228AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ED73 RID: 60787 RVA: 0x0022A905 File Offset: 0x00228B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ED74 RID: 60788 RVA: 0x0022A910 File Offset: 0x00228B10
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

		// Token: 0x0600ED75 RID: 60789 RVA: 0x0022A968 File Offset: 0x00228B68
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

		// Token: 0x0600ED76 RID: 60790 RVA: 0x0022A9C0 File Offset: 0x00228BC0
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

		// Token: 0x0600ED77 RID: 60791 RVA: 0x0022AA10 File Offset: 0x00228C10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ED78 RID: 60792 RVA: 0x0022AA1C File Offset: 0x00228C1C
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

		// Token: 0x04006028 RID: 24616
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006029 RID: 24617
		public const int CurrentFieldNumber = 1;

		// Token: 0x0400602A RID: 24618
		private int current_;

		// Token: 0x0400602B RID: 24619
		public const int TargetFieldNumber = 2;

		// Token: 0x0400602C RID: 24620
		private int target_;
	}
}
