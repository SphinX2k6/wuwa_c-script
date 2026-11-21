using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002CE RID: 718
	public sealed class CondInfo : IMessage<CondInfo>, IMessage, IEquatable<CondInfo>, IDeepCloneable<CondInfo>, IBufferMessage
	{
		// Token: 0x060049E0 RID: 18912 RVA: 0x000B4F6D File Offset: 0x000B316D
		[NullableContext(1)]
		public static CondInfo Create()
		{
			return new CondInfo();
		}

		// Token: 0x17000CEE RID: 3310
		// (get) Token: 0x060049E1 RID: 18913 RVA: 0x000B4F74 File Offset: 0x000B3174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CEF RID: 3311
		// (get) Token: 0x060049E2 RID: 18914 RVA: 0x000B4F77 File Offset: 0x000B3177
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CondInfo.Descriptor;
			}
		}

		// Token: 0x060049E3 RID: 18915 RVA: 0x000B4F7E File Offset: 0x000B317E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CondInfo()
		{
		}

		// Token: 0x060049E4 RID: 18916 RVA: 0x000B4F86 File Offset: 0x000B3186
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CondInfo(CondInfo other) : this()
		{
			this.id_ = other.id_;
			this.current_ = other.current_;
			this.target_ = other.target_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049E5 RID: 18917 RVA: 0x000B4FC3 File Offset: 0x000B31C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CondInfo Clone()
		{
			return new CondInfo(this);
		}

		// Token: 0x17000CF0 RID: 3312
		// (get) Token: 0x060049E6 RID: 18918 RVA: 0x000B4FCB File Offset: 0x000B31CB
		// (set) Token: 0x060049E7 RID: 18919 RVA: 0x000B4FD3 File Offset: 0x000B31D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17000CF1 RID: 3313
		// (get) Token: 0x060049E8 RID: 18920 RVA: 0x000B4FDC File Offset: 0x000B31DC
		// (set) Token: 0x060049E9 RID: 18921 RVA: 0x000B4FE4 File Offset: 0x000B31E4
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

		// Token: 0x17000CF2 RID: 3314
		// (get) Token: 0x060049EA RID: 18922 RVA: 0x000B4FED File Offset: 0x000B31ED
		// (set) Token: 0x060049EB RID: 18923 RVA: 0x000B4FF5 File Offset: 0x000B31F5
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

		// Token: 0x060049EC RID: 18924 RVA: 0x000B4FFE File Offset: 0x000B31FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CondInfo);
		}

		// Token: 0x060049ED RID: 18925 RVA: 0x000B500C File Offset: 0x000B320C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CondInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060049EE RID: 18926 RVA: 0x000B5068 File Offset: 0x000B3268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
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

		// Token: 0x060049EF RID: 18927 RVA: 0x000B50D9 File Offset: 0x000B32D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060049F0 RID: 18928 RVA: 0x000B50E6 File Offset: 0x000B32E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060049F1 RID: 18929 RVA: 0x000B50F0 File Offset: 0x000B32F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Current != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Current);
			}
			if (this.Target != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Target);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060049F2 RID: 18930 RVA: 0x000B5164 File Offset: 0x000B3364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
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

		// Token: 0x060049F3 RID: 18931 RVA: 0x000B51D4 File Offset: 0x000B33D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CondInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
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

		// Token: 0x060049F4 RID: 18932 RVA: 0x000B5238 File Offset: 0x000B3438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049F5 RID: 18933 RVA: 0x000B5244 File Offset: 0x000B3444
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
						if (num != 24U)
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
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x040030A0 RID: 12448
		private UnknownFieldSet _unknownFields;

		// Token: 0x040030A1 RID: 12449
		public const int IdFieldNumber = 1;

		// Token: 0x040030A2 RID: 12450
		private int id_;

		// Token: 0x040030A3 RID: 12451
		public const int CurrentFieldNumber = 2;

		// Token: 0x040030A4 RID: 12452
		private int current_;

		// Token: 0x040030A5 RID: 12453
		public const int TargetFieldNumber = 3;

		// Token: 0x040030A6 RID: 12454
		private int target_;
	}
}
