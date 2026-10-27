using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C7 RID: 711
	public sealed class CondInfo : IMessage<CondInfo>, IMessage, IEquatable<CondInfo>, IDeepCloneable<CondInfo>, IBufferMessage
	{
		// Token: 0x06004907 RID: 18695 RVA: 0x000B2B85 File Offset: 0x000B0D85
		[NullableContext(1)]
		public static CondInfo Create()
		{
			return new CondInfo();
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06004908 RID: 18696 RVA: 0x000B2B8C File Offset: 0x000B0D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CC2 RID: 3266
		// (get) Token: 0x06004909 RID: 18697 RVA: 0x000B2B8F File Offset: 0x000B0D8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CondInfo.Descriptor;
			}
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x000B2B96 File Offset: 0x000B0D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CondInfo()
		{
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x000B2B9E File Offset: 0x000B0D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CondInfo(CondInfo other) : this()
		{
			this.id_ = other.id_;
			this.current_ = other.current_;
			this.target_ = other.target_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x000B2BDB File Offset: 0x000B0DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CondInfo Clone()
		{
			return new CondInfo(this);
		}

		// Token: 0x17000CC3 RID: 3267
		// (get) Token: 0x0600490D RID: 18701 RVA: 0x000B2BE3 File Offset: 0x000B0DE3
		// (set) Token: 0x0600490E RID: 18702 RVA: 0x000B2BEB File Offset: 0x000B0DEB
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

		// Token: 0x17000CC4 RID: 3268
		// (get) Token: 0x0600490F RID: 18703 RVA: 0x000B2BF4 File Offset: 0x000B0DF4
		// (set) Token: 0x06004910 RID: 18704 RVA: 0x000B2BFC File Offset: 0x000B0DFC
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

		// Token: 0x17000CC5 RID: 3269
		// (get) Token: 0x06004911 RID: 18705 RVA: 0x000B2C05 File Offset: 0x000B0E05
		// (set) Token: 0x06004912 RID: 18706 RVA: 0x000B2C0D File Offset: 0x000B0E0D
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

		// Token: 0x06004913 RID: 18707 RVA: 0x000B2C16 File Offset: 0x000B0E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CondInfo);
		}

		// Token: 0x06004914 RID: 18708 RVA: 0x000B2C24 File Offset: 0x000B0E24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CondInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Current == other.Current && this.Target == other.Target && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x000B2C80 File Offset: 0x000B0E80
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

		// Token: 0x06004916 RID: 18710 RVA: 0x000B2CF1 File Offset: 0x000B0EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004917 RID: 18711 RVA: 0x000B2CFE File Offset: 0x000B0EFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004918 RID: 18712 RVA: 0x000B2D08 File Offset: 0x000B0F08
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

		// Token: 0x06004919 RID: 18713 RVA: 0x000B2D7C File Offset: 0x000B0F7C
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

		// Token: 0x0600491A RID: 18714 RVA: 0x000B2DEC File Offset: 0x000B0FEC
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

		// Token: 0x0600491B RID: 18715 RVA: 0x000B2E50 File Offset: 0x000B1050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600491C RID: 18716 RVA: 0x000B2E5C File Offset: 0x000B105C
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

		// Token: 0x04003009 RID: 12297
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400300A RID: 12298
		public const int IdFieldNumber = 1;

		// Token: 0x0400300B RID: 12299
		private int id_;

		// Token: 0x0400300C RID: 12300
		public const int CurrentFieldNumber = 2;

		// Token: 0x0400300D RID: 12301
		private int current_;

		// Token: 0x0400300E RID: 12302
		public const int TargetFieldNumber = 3;

		// Token: 0x0400300F RID: 12303
		private int target_;
	}
}
