using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012BC RID: 4796
	public sealed class SunSpiritTakeUpPb : IMessage<SunSpiritTakeUpPb>, IMessage, IEquatable<SunSpiritTakeUpPb>, IDeepCloneable<SunSpiritTakeUpPb>, IBufferMessage
	{
		// Token: 0x06019850 RID: 104528 RVA: 0x003B56D5 File Offset: 0x003B38D5
		[NullableContext(1)]
		public static SunSpiritTakeUpPb Create()
		{
			return new SunSpiritTakeUpPb();
		}

		// Token: 0x1700560F RID: 22031
		// (get) Token: 0x06019851 RID: 104529 RVA: 0x003B56DC File Offset: 0x003B38DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005610 RID: 22032
		// (get) Token: 0x06019852 RID: 104530 RVA: 0x003B56DF File Offset: 0x003B38DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SunSpiritTakeUpPb.Descriptor;
			}
		}

		// Token: 0x06019853 RID: 104531 RVA: 0x003B56E6 File Offset: 0x003B38E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritTakeUpPb()
		{
		}

		// Token: 0x06019854 RID: 104532 RVA: 0x003B56EE File Offset: 0x003B38EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritTakeUpPb(SunSpiritTakeUpPb other) : this()
		{
			this.trapEntityConfigId_ = other.trapEntityConfigId_;
			this.index_ = other.index_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019855 RID: 104533 RVA: 0x003B571F File Offset: 0x003B391F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SunSpiritTakeUpPb Clone()
		{
			return new SunSpiritTakeUpPb(this);
		}

		// Token: 0x17005611 RID: 22033
		// (get) Token: 0x06019856 RID: 104534 RVA: 0x003B5727 File Offset: 0x003B3927
		// (set) Token: 0x06019857 RID: 104535 RVA: 0x003B572F File Offset: 0x003B392F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TrapEntityConfigId
		{
			get
			{
				return this.trapEntityConfigId_;
			}
			set
			{
				this.trapEntityConfigId_ = value;
			}
		}

		// Token: 0x17005612 RID: 22034
		// (get) Token: 0x06019858 RID: 104536 RVA: 0x003B5738 File Offset: 0x003B3938
		// (set) Token: 0x06019859 RID: 104537 RVA: 0x003B5740 File Offset: 0x003B3940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x0601985A RID: 104538 RVA: 0x003B5749 File Offset: 0x003B3949
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SunSpiritTakeUpPb);
		}

		// Token: 0x0601985B RID: 104539 RVA: 0x003B5757 File Offset: 0x003B3957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SunSpiritTakeUpPb other)
		{
			return other != null && (other == this || (this.TrapEntityConfigId == other.TrapEntityConfigId && this.Index == other.Index && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601985C RID: 104540 RVA: 0x003B5798 File Offset: 0x003B3998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TrapEntityConfigId != 0)
			{
				num ^= this.TrapEntityConfigId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601985D RID: 104541 RVA: 0x003B57F0 File Offset: 0x003B39F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601985E RID: 104542 RVA: 0x003B57FD File Offset: 0x003B39FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601985F RID: 104543 RVA: 0x003B5808 File Offset: 0x003B3A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TrapEntityConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.TrapEntityConfigId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019860 RID: 104544 RVA: 0x003B5860 File Offset: 0x003B3A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TrapEntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TrapEntityConfigId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019861 RID: 104545 RVA: 0x003B58B8 File Offset: 0x003B3AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SunSpiritTakeUpPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TrapEntityConfigId != 0)
			{
				this.TrapEntityConfigId = other.TrapEntityConfigId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019862 RID: 104546 RVA: 0x003B5908 File Offset: 0x003B3B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019863 RID: 104547 RVA: 0x003B5914 File Offset: 0x003B3B14
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
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.TrapEntityConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040095B3 RID: 38323
		private UnknownFieldSet _unknownFields;

		// Token: 0x040095B4 RID: 38324
		public const int TrapEntityConfigIdFieldNumber = 1;

		// Token: 0x040095B5 RID: 38325
		private int trapEntityConfigId_;

		// Token: 0x040095B6 RID: 38326
		public const int IndexFieldNumber = 2;

		// Token: 0x040095B7 RID: 38327
		private int index_;
	}
}
