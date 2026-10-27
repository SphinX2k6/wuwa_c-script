using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002EA RID: 746
	public sealed class ConsumptiveTaskProcess : IMessage<ConsumptiveTaskProcess>, IMessage, IEquatable<ConsumptiveTaskProcess>, IDeepCloneable<ConsumptiveTaskProcess>, IBufferMessage
	{
		// Token: 0x06004BCF RID: 19407 RVA: 0x000B8AE4 File Offset: 0x000B6CE4
		[NullableContext(1)]
		public static ConsumptiveTaskProcess Create()
		{
			return new ConsumptiveTaskProcess();
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06004BD0 RID: 19408 RVA: 0x000B8AEB File Offset: 0x000B6CEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06004BD1 RID: 19409 RVA: 0x000B8AEE File Offset: 0x000B6CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConsumptiveTaskProcess.Descriptor;
			}
		}

		// Token: 0x06004BD2 RID: 19410 RVA: 0x000B8AF5 File Offset: 0x000B6CF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskProcess()
		{
		}

		// Token: 0x06004BD3 RID: 19411 RVA: 0x000B8AFD File Offset: 0x000B6CFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskProcess(ConsumptiveTaskProcess other) : this()
		{
			this.current_ = other.current_;
			this.target_ = other.target_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004BD4 RID: 19412 RVA: 0x000B8B2E File Offset: 0x000B6D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConsumptiveTaskProcess Clone()
		{
			return new ConsumptiveTaskProcess(this);
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06004BD5 RID: 19413 RVA: 0x000B8B36 File Offset: 0x000B6D36
		// (set) Token: 0x06004BD6 RID: 19414 RVA: 0x000B8B3E File Offset: 0x000B6D3E
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

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06004BD7 RID: 19415 RVA: 0x000B8B47 File Offset: 0x000B6D47
		// (set) Token: 0x06004BD8 RID: 19416 RVA: 0x000B8B4F File Offset: 0x000B6D4F
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

		// Token: 0x06004BD9 RID: 19417 RVA: 0x000B8B58 File Offset: 0x000B6D58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConsumptiveTaskProcess);
		}

		// Token: 0x06004BDA RID: 19418 RVA: 0x000B8B66 File Offset: 0x000B6D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConsumptiveTaskProcess other)
		{
			return other != null && (other == this || (this.Current == other.Current && this.Target == other.Target && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004BDB RID: 19419 RVA: 0x000B8BA4 File Offset: 0x000B6DA4
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

		// Token: 0x06004BDC RID: 19420 RVA: 0x000B8BFC File Offset: 0x000B6DFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004BDD RID: 19421 RVA: 0x000B8C09 File Offset: 0x000B6E09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004BDE RID: 19422 RVA: 0x000B8C14 File Offset: 0x000B6E14
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

		// Token: 0x06004BDF RID: 19423 RVA: 0x000B8C6C File Offset: 0x000B6E6C
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

		// Token: 0x06004BE0 RID: 19424 RVA: 0x000B8CC4 File Offset: 0x000B6EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConsumptiveTaskProcess other)
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

		// Token: 0x06004BE1 RID: 19425 RVA: 0x000B8D14 File Offset: 0x000B6F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004BE2 RID: 19426 RVA: 0x000B8D20 File Offset: 0x000B6F20
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

		// Token: 0x040030D0 RID: 12496
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030D1 RID: 12497
		public const int CurrentFieldNumber = 1;

		// Token: 0x040030D2 RID: 12498
		private int current_;

		// Token: 0x040030D3 RID: 12499
		public const int TargetFieldNumber = 2;

		// Token: 0x040030D4 RID: 12500
		private int target_;
	}
}
