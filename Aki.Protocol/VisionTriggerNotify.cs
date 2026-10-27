using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014E5 RID: 5349
	[NetMessage(EMessageId.VisionTriggerNotify)]
	public sealed class VisionTriggerNotify : IMessage<VisionTriggerNotify>, IMessage, IEquatable<VisionTriggerNotify>, IDeepCloneable<VisionTriggerNotify>, IBufferMessage
	{
		// Token: 0x0601C48D RID: 115853 RVA: 0x00416746 File Offset: 0x00414946
		[NullableContext(1)]
		public static VisionTriggerNotify Create()
		{
			return new VisionTriggerNotify();
		}

		// Token: 0x17005F5D RID: 24413
		// (get) Token: 0x0601C48E RID: 115854 RVA: 0x0041674D File Offset: 0x0041494D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F5E RID: 24414
		// (get) Token: 0x0601C48F RID: 115855 RVA: 0x00416750 File Offset: 0x00414950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VisionTriggerNotify.Descriptor;
			}
		}

		// Token: 0x0601C490 RID: 115856 RVA: 0x00416757 File Offset: 0x00414957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionTriggerNotify()
		{
		}

		// Token: 0x0601C491 RID: 115857 RVA: 0x0041675F File Offset: 0x0041495F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionTriggerNotify(VisionTriggerNotify other) : this()
		{
			this.numberId_ = other.numberId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C492 RID: 115858 RVA: 0x00416784 File Offset: 0x00414984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VisionTriggerNotify Clone()
		{
			return new VisionTriggerNotify(this);
		}

		// Token: 0x17005F5F RID: 24415
		// (get) Token: 0x0601C493 RID: 115859 RVA: 0x0041678C File Offset: 0x0041498C
		// (set) Token: 0x0601C494 RID: 115860 RVA: 0x00416794 File Offset: 0x00414994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NumberId
		{
			get
			{
				return this.numberId_;
			}
			set
			{
				this.numberId_ = value;
			}
		}

		// Token: 0x0601C495 RID: 115861 RVA: 0x0041679D File Offset: 0x0041499D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VisionTriggerNotify);
		}

		// Token: 0x0601C496 RID: 115862 RVA: 0x004167AB File Offset: 0x004149AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VisionTriggerNotify other)
		{
			return other != null && (other == this || (this.NumberId == other.NumberId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C497 RID: 115863 RVA: 0x004167DC File Offset: 0x004149DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.NumberId != 0)
			{
				num ^= this.NumberId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C498 RID: 115864 RVA: 0x0041681B File Offset: 0x00414A1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C499 RID: 115865 RVA: 0x00416828 File Offset: 0x00414A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C49A RID: 115866 RVA: 0x00416831 File Offset: 0x00414A31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NumberId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.NumberId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C49B RID: 115867 RVA: 0x00416864 File Offset: 0x00414A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.NumberId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NumberId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C49C RID: 115868 RVA: 0x004168A2 File Offset: 0x00414AA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VisionTriggerNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.NumberId != 0)
			{
				this.NumberId = other.NumberId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C49D RID: 115869 RVA: 0x004168D3 File Offset: 0x00414AD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C49E RID: 115870 RVA: 0x004168DC File Offset: 0x00414ADC
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.NumberId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A221 RID: 41505
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A222 RID: 41506
		public const int NumberIdFieldNumber = 15;

		// Token: 0x0400A223 RID: 41507
		private int numberId_;
	}
}
