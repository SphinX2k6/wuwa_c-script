using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000733 RID: 1843
	public sealed class HackTargetComponentPb : IMessage<HackTargetComponentPb>, IMessage, IEquatable<HackTargetComponentPb>, IDeepCloneable<HackTargetComponentPb>, IBufferMessage
	{
		// Token: 0x0600A726 RID: 42790 RVA: 0x00192708 File Offset: 0x00190908
		[NullableContext(1)]
		public static HackTargetComponentPb Create()
		{
			return new HackTargetComponentPb();
		}

		// Token: 0x1700219A RID: 8602
		// (get) Token: 0x0600A727 RID: 42791 RVA: 0x0019270F File Offset: 0x0019090F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x0600A728 RID: 42792 RVA: 0x00192712 File Offset: 0x00190912
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HackTargetComponentPb.Descriptor;
			}
		}

		// Token: 0x0600A729 RID: 42793 RVA: 0x00192719 File Offset: 0x00190919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HackTargetComponentPb()
		{
		}

		// Token: 0x0600A72A RID: 42794 RVA: 0x00192721 File Offset: 0x00190921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HackTargetComponentPb(HackTargetComponentPb other) : this()
		{
			this.hackTargetEntityId_ = other.hackTargetEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A72B RID: 42795 RVA: 0x00192746 File Offset: 0x00190946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HackTargetComponentPb Clone()
		{
			return new HackTargetComponentPb(this);
		}

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x0600A72C RID: 42796 RVA: 0x0019274E File Offset: 0x0019094E
		// (set) Token: 0x0600A72D RID: 42797 RVA: 0x00192756 File Offset: 0x00190956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long HackTargetEntityId
		{
			get
			{
				return this.hackTargetEntityId_;
			}
			set
			{
				this.hackTargetEntityId_ = value;
			}
		}

		// Token: 0x0600A72E RID: 42798 RVA: 0x0019275F File Offset: 0x0019095F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HackTargetComponentPb);
		}

		// Token: 0x0600A72F RID: 42799 RVA: 0x0019276D File Offset: 0x0019096D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HackTargetComponentPb other)
		{
			return other != null && (other == this || (this.HackTargetEntityId == other.HackTargetEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A730 RID: 42800 RVA: 0x0019279C File Offset: 0x0019099C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HackTargetEntityId != 0L)
			{
				num ^= this.HackTargetEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A731 RID: 42801 RVA: 0x001927DB File Offset: 0x001909DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A732 RID: 42802 RVA: 0x001927E8 File Offset: 0x001909E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A733 RID: 42803 RVA: 0x001927F1 File Offset: 0x001909F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HackTargetEntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.HackTargetEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A734 RID: 42804 RVA: 0x00192824 File Offset: 0x00190A24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HackTargetEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.HackTargetEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A735 RID: 42805 RVA: 0x00192862 File Offset: 0x00190A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HackTargetComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HackTargetEntityId != 0L)
			{
				this.HackTargetEntityId = other.HackTargetEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A736 RID: 42806 RVA: 0x00192893 File Offset: 0x00190A93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A737 RID: 42807 RVA: 0x0019289C File Offset: 0x00190A9C
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
					this.HackTargetEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004C79 RID: 19577
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C7A RID: 19578
		public const int HackTargetEntityIdFieldNumber = 1;

		// Token: 0x04004C7B RID: 19579
		private long hackTargetEntityId_;
	}
}
