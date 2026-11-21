using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A82 RID: 2690
	public sealed class MotorParkourCtx : IMessage<MotorParkourCtx>, IMessage, IEquatable<MotorParkourCtx>, IDeepCloneable<MotorParkourCtx>, IBufferMessage
	{
		// Token: 0x0600EAA3 RID: 60067 RVA: 0x002248E9 File Offset: 0x00222AE9
		[NullableContext(1)]
		public static MotorParkourCtx Create()
		{
			return new MotorParkourCtx();
		}

		// Token: 0x17002F9F RID: 12191
		// (get) Token: 0x0600EAA4 RID: 60068 RVA: 0x002248F0 File Offset: 0x00222AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002FA0 RID: 12192
		// (get) Token: 0x0600EAA5 RID: 60069 RVA: 0x002248F3 File Offset: 0x00222AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorParkourCtx.Descriptor;
			}
		}

		// Token: 0x0600EAA6 RID: 60070 RVA: 0x002248FA File Offset: 0x00222AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourCtx()
		{
		}

		// Token: 0x0600EAA7 RID: 60071 RVA: 0x00224902 File Offset: 0x00222B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourCtx(MotorParkourCtx other) : this()
		{
			this.motorParkourId_ = other.motorParkourId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600EAA8 RID: 60072 RVA: 0x00224927 File Offset: 0x00222B27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorParkourCtx Clone()
		{
			return new MotorParkourCtx(this);
		}

		// Token: 0x17002FA1 RID: 12193
		// (get) Token: 0x0600EAA9 RID: 60073 RVA: 0x0022492F File Offset: 0x00222B2F
		// (set) Token: 0x0600EAAA RID: 60074 RVA: 0x00224937 File Offset: 0x00222B37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MotorParkourId
		{
			get
			{
				return this.motorParkourId_;
			}
			set
			{
				this.motorParkourId_ = value;
			}
		}

		// Token: 0x0600EAAB RID: 60075 RVA: 0x00224940 File Offset: 0x00222B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorParkourCtx);
		}

		// Token: 0x0600EAAC RID: 60076 RVA: 0x0022494E File Offset: 0x00222B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorParkourCtx other)
		{
			return other != null && (other == this || (this.MotorParkourId == other.MotorParkourId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600EAAD RID: 60077 RVA: 0x0022497C File Offset: 0x00222B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MotorParkourId != 0)
			{
				num ^= this.MotorParkourId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600EAAE RID: 60078 RVA: 0x002249BB File Offset: 0x00222BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600EAAF RID: 60079 RVA: 0x002249C8 File Offset: 0x00222BC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600EAB0 RID: 60080 RVA: 0x002249D1 File Offset: 0x00222BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MotorParkourId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MotorParkourId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600EAB1 RID: 60081 RVA: 0x00224A04 File Offset: 0x00222C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MotorParkourId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MotorParkourId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600EAB2 RID: 60082 RVA: 0x00224A42 File Offset: 0x00222C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorParkourCtx other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MotorParkourId != 0)
			{
				this.MotorParkourId = other.MotorParkourId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600EAB3 RID: 60083 RVA: 0x00224A73 File Offset: 0x00222C73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600EAB4 RID: 60084 RVA: 0x00224A7C File Offset: 0x00222C7C
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
					this.MotorParkourId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005FAD RID: 24493
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005FAE RID: 24494
		public const int MotorParkourIdFieldNumber = 1;

		// Token: 0x04005FAF RID: 24495
		private int motorParkourId_;
	}
}
